Imports Ionic.Zip

Module Mod_ZIP

    Public Function UnZip(ByVal Pack As String)
        Try
            Dim zipFile As New ZipFile(Pack)
            zipFile.ExtractAll(Application.StartupPath & "\Temp", ExtractExistingFileAction.OverwriteSilently)
            Return Nothing
        Catch ex As Exception
            Return ex.Message
        End Try
    End Function

End Module