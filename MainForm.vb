Public Class MainForm

    'Select Package
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'Select ZIP file
        ofdMain.Filter = "BoomVM Package|*.bom"
        If Not ofdMain.ShowDialog() = DialogResult.OK Then Exit Sub

        'Check Temp Directory Exists
        If IO.Directory.Exists(Application.StartupPath & "\Temp") = True Then
            'If Exists, Clear The Directory
            picBOM.Image.Dispose()
            My.Computer.FileSystem.DeleteDirectory(Application.StartupPath & "\Temp", FileIO.DeleteDirectoryOption.DeleteAllContents)
            IO.Directory.CreateDirectory(Application.StartupPath & "\Temp")
        Else
            'If NOT Exist, Create One
            IO.Directory.CreateDirectory(Application.StartupPath & "\Temp")
        End If

        'Unzip the file
        UnZip(ofdMain.FileName)

        'If exists, Load the Picture
        If IO.File.Exists(Application.StartupPath & "\Temp\logo.png") Then
            picBOM.Image = Image.FromFile(Application.StartupPath & "\Temp\logo.png")
        Else
            picBOM.Image = Image.FromHbitmap(My.Resources.FUS_004.GetHbitmap)
        End If

        'Load the Title
        Dim sr As New IO.StreamReader(Application.StartupPath & "\Temp\packname", System.Text.Encoding.UTF8)
        txtBOM.Text = sr.ReadToEnd
        sr.Close()
        sr.Dispose()

        'Enable The Info Button
        btnInfo.Enabled = True
    End Sub

    'Form Closing
    Private Sub MainForm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        'Dispose Loaded Image
        picBOM.Image.Dispose()
        'If Exists, Remove Temp Folder
        If IO.Directory.Exists(Application.StartupPath & "\Temp") = True Then
            My.Computer.FileSystem.DeleteDirectory(Application.StartupPath & "\Temp", FileIO.DeleteDirectoryOption.DeleteAllContents)
        End If
    End Sub

    'Get Server From File
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        'Select INI file
        ofdMain.Filter = "BoomVM Server Info|*.svr"
        If Not ofdMain.ShowDialog() = DialogResult.OK Then Exit Sub
        Dim strINI As String = ofdMain.FileName

        'Read From File
        txtIP.Value = INIGet("Server", "IP", "0.0.0.0", strINI)
        txtPort.Text = INIGet("Server", "Port", "22", strINI)
        txtUser.Text = INIGet("Server", "User", "root", strINI)
        txtPasswd.Text = INIGet("Server", "Passwd", "", strINI)

    End Sub

    'Show Details
    Private Sub btnInfo_Click(sender As Object, e As EventArgs) Handles btnInfo.Click
        InfoForm.Show()
    End Sub

    'Save Server Info
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If Not sfdMain.ShowDialog = DialogResult.OK Then Exit Sub
        Dim strINI As String = sfdMain.FileName
        INISet("Server", "IP", txtIP.Value, strINI)
        INISet("Server", "Port", txtPort.Text, strINI)
        INISet("Server", "User", txtUser.Text, strINI)
        INISet("Server", "Passwd", txtPasswd.Text, strINI)
    End Sub

    'Deploy
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        DeployForm.ShowDialog()
    End Sub

    'Show About Form
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        AboutForm.ShowDialog()
    End Sub
End Class

