Module Generic

    Public Const TIMESTAMP_FORMAT As String = "yyyy-MM-dd hh:mm:ss:ff tt"

    Public Sub EnsureDirectoriesExistInPath(path As String, includesFilename As Boolean)

        Dim builder As New Text.StringBuilder()
        Dim folders() As String = path.Split("\")
        Dim folderCount As Integer = IIf(includesFilename, folders.Count - 2, folders.Count - 1)

        If folderCount < 0 Then
            Exit Sub
        End If

        For i As Integer = 0 To folderCount Step 1

            builder.Append($"{folders(i)}\")

            If Not IO.Directory.Exists(builder.ToString()) Then
                IO.Directory.CreateDirectory(builder.ToString())
            End If

        Next

    End Sub

End Module