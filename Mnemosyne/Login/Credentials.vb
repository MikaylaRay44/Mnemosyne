Imports System.Text
Imports System.Security.Cryptography

Public Class Credentials

    Public Shared Function Create(username As String, password As String) As Boolean

        '

    End Function

    Public Shared Function Submit(username As String, password As String) As Boolean

        Dim salt(24) As Byte
        Dim saltProvider As New RNGCryptoServiceProvider()
        Dim serviceProvider As New SHA1CryptoServiceProvider()
        saltProvider.GetBytes(salt)
        Dim hashTool As New Rfc2898DeriveBytes(password, salt)
        hashTool.IterationCount = 1000
        Dim data() As Byte = hashTool.GetBytes(password)
        Dim hash() As Byte = serviceProvider.ComputeHash(data)

        ' TODO: Save the {iterationCount}, {salt}, and {hash} for verification later. --- In order to TODO this should work on backend database
        ' TODO : Store to serialized and encrypted file?

    End Function

    ' Dim hashTool as new Rfc2898DeriveBytes(testPassword, originalSalt)
    ' hashTool.IterationCount = iterations
    ' Dim testHash() as byte = hashTool.getBytes(originalHash.length)
    '    uint differences = (uint)originalHash.Length ^ (uint)testHash.Length;
    'For (int position = 0; position < Math.Min(originalHash.Length,
    '  testHash.Length); position++)
    '  differences |= (uint)(originalHash[position] ^ testHash[position]);
    'bool passwordMatches = (differences == 0);

End Class