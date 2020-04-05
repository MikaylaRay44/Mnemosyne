Imports System.Security.Cryptography

Public Module Credentials

#Region "Declarations"

    Private Const CREDENTIALS_DATABASE_PATH As String = "C:\Program Files\Mnemosyne\Databases\credentials.db"
    Private Const CREDENTIALS_DATABASE_CONNECTION As String = "Data Source=C:\Z\Mnemosyne\Databases\credentials.db;Version=3;"

    Private Structure CredentialsDatabaseTables
        Public Const CREDENTIALS As String = "Credentials"
    End Structure

    Private Structure CredentialsDatabaseColumnHeaders
        Public Const SALT As String = "Salt"
        Public Const HASH As String = "Hash"
        Public Const USER As String = "User"
        Public Const ITERATION As String = "Iteration"
    End Structure

#End Region

    Public Function Create(username As String, password As String) As Boolean

        '

    End Function

    Public Function Submit(username As String, password As String) As Boolean

        Dim salt(24) As Byte
        Dim saltProvider As New RNGCryptoServiceProvider()
        Dim serviceProvider As New SHA1CryptoServiceProvider()
        saltProvider.GetBytes(salt)
        Dim hashTool As New Rfc2898DeriveBytes(password, salt)
        hashTool.IterationCount = 1000
        Dim data() As Byte = hashTool.GetBytes(password)
        Dim hash() As Byte = serviceProvider.ComputeHash(data) ' TODO: store hash in db with salt?

        ' TODO: Make create a password menu ...

    End Function

    ' Dim hashTool as new Rfc2898DeriveBytes(testPassword, originalSalt)
    ' hashTool.IterationCount = iterations
    ' Dim testHash() as byte = hashTool.getBytes(originalHash.length)
    '    uint differences = (uint)originalHash.Length ^ (uint)testHash.Length;
    'For (int position = 0; position < Math.Min(originalHash.Length,
    '  testHash.Length); position++)
    '  differences |= (uint)(originalHash[position] ^ testHash[position]);
    'bool passwordMatches = (differences == 0);

#Region "Credentials Database"

    Public Sub CreateDatabase()
        Try
            EnsureDirectoriesExistInPath(CREDENTIALS_DATABASE_PATH, True)
            SQLite.SQLiteConnection.CreateFile(CREDENTIALS_DATABASE_PATH)
            ExecuteNonQuery($"CREATE TABLE IF NOT EXISTS {CredentialsDatabaseTables.CREDENTIALS} 
                              ({CredentialsDatabaseColumnHeaders.USER} TEXT PRIMARY KEY, 
                               {CredentialsDatabaseColumnHeaders.HASH} TEXT NOT NULL,
                               {CredentialsDatabaseColumnHeaders.SALT} TEXT NOT NULL,
                               {CredentialsDatabaseColumnHeaders.ITERATION} INTEGER DEFAULT 1000);")
        Catch ex As Exception
            'Log.Error("Failed to create credentials database.", ex)
        End Try
    End Sub

    Public Sub ExecuteNonQuery(content As String)

        If Not IO.File.Exists(CREDENTIALS_DATABASE_PATH) Then
            CreateDatabase()
        End If

        Dim connection As New SQLite.SQLiteConnection(CREDENTIALS_DATABASE_CONNECTION)
        connection.Open()
        Dim command As New SQLite.SQLiteCommand(content, connection)
        command.ExecuteNonQuery()
        connection.Close()

    End Sub

    Public Function ExecuteQuery(content As String) As DataTable

        If Not IO.File.Exists(CREDENTIALS_DATABASE_PATH) Then
            CreateDatabase()
        End If

        Dim connection As New SQLite.SQLiteConnection(CREDENTIALS_DATABASE_CONNECTION)
        connection.Open()
        Dim command As New SQLite.SQLiteCommand(content, connection)
        Dim reader As SQLite.SQLiteDataReader = command.ExecuteReader()
        Dim data As New DataTable()
        data.Load(reader)
        reader.Close()
        connection.Close()
        Return data

    End Function

    Public Function UserExists(username As String) As Boolean
        Return ExecuteQuery($"SELECT {CredentialsDatabaseColumnHeaders.USER} 
                              FROM {CredentialsDatabaseTables.CREDENTIALS} 
                              WHERE {CredentialsDatabaseColumnHeaders.USER}='{username}'").Rows().Count > 0
    End Function

    Public Sub AddCredentials(username As String, password As String, salt As String, iteration As Integer)
        If Not UserExists(username) Then
            ExecuteNonQuery($"INSERT INTO {CredentialsDatabaseTables.CREDENTIALS}
                              ({CredentialsDatabaseColumnHeaders.USER}, 
                               {CredentialsDatabaseColumnHeaders.HASH}, 
                               {CredentialsDatabaseColumnHeaders.SALT}, 
                               {CredentialsDatabaseColumnHeaders.ITERATION})
                              VALUES ('{username}', '{password}', '{salt}', {iteration}")
        End If
    End Sub

#End Region

End Module