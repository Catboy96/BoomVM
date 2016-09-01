Imports System.ComponentModel
Imports System.Threading
Imports Renci.SshNet

Delegate Sub DeleHandler()

Public Class DeployForm

    Private IP As String
    Private Port As String
    Private User As String
    Private Passwd As String
    Private Param As String = ""

    Private Sub DeleFunc()
        Me.Invoke(New DeleHandler(AddressOf Processor))
    End Sub

    Private Sub DeployForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Get Server Info
        IP = MainForm.txtIP.Value
        Port = MainForm.txtPort.Text
        User = MainForm.txtUser.Text
        Passwd = MainForm.txtPasswd.Text
        Dim thProcess As New System.Threading.Thread(AddressOf DeleFunc)
        thProcess.Start()
    End Sub

    Private Sub Loggin(ByVal str As String)
        txtMain.AppendText(str)
    End Sub

    Private Sub Processor()
        'Get Params If Needed
        Dim strInput As String
        If IO.File.Exists(Application.StartupPath & "\Temp\param") = True Then
            Dim sr As New IO.StreamReader(Application.StartupPath & "\Temp\param", System.Text.Encoding.UTF8)
            Dim vars As String
            Do
                vars = sr.ReadLine()
                If "" = vars Then Exit Do
InputParam:
                strInput = InputBox(vars)
                If "" <> strInput Then
                    Param = Param & " " & InputBox(vars)
                Else
                    MessageBox.Show("输入不能为空。", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    GoTo InputParam
                End If
            Loop
        End If


        'Create SFTP Connection
        Dim sftpc As SftpClient
        Try
            Loggin("启动SFTP连接...")
            sftpc = New SftpClient(IP, Port, User, Passwd)
            Loggin("完成" & vbCrLf)
            proMain.Value = 5
        Catch ex As Exception
            Loggin("失败：" & ex.Message & vbCrLf)
            Exit Sub
        End Try


        'Establish SFTP Connection
        Try
            Loggin("正在连接至SFTP服务器...")
            sftpc.Connect()
            Loggin("完成" & vbCrLf)
            proMain.Value = 10
        Catch ex As Exception
            Loggin("失败：" & ex.Message & vbCrLf)
            Exit Sub
        End Try


        'Upload INSTALL.SH
        Try
            Try
                Loggin("切换至/root/boomvm...")
                sftpc.ChangeDirectory("/root/boomvm")
                Loggin("完成" & vbCrLf)
                proMain.Value = 20
            Catch ex0 As Exception
                Loggin("失败：" & ex0.Message & vbCrLf)
                Try
                    Loggin("创建目录/root/boomvm...")
                    sftpc.CreateDirectory("/root/boomvm")
                    Loggin("完成" & vbCrLf)
                    proMain.Value = 15
                    Loggin("切换至/root/boomvm...")
                    sftpc.ChangeDirectory("/root/boomvm")
                    Loggin("完成" & vbCrLf)
                    proMain.Value = 20
                Catch ex1 As Exception
                    Loggin("失败：" & ex1.Message & vbCrLf)
                    Exit Sub
                End Try
            End Try
            Loggin("上传install.sh...")
            Dim stm As New IO.FileStream(Application.StartupPath & "\Temp\install.sh", IO.FileMode.Open)
            sftpc.UploadFile(stm, "/root/boomvm/install.sh", True)
            Loggin("完成" & vbCrLf)
            proMain.Value = 50
        Catch ex As Exception
            Loggin("失败：" & ex.Message & vbCrLf)
            Exit Sub
        End Try


        'Create SSH Connection
        Dim sshc As SshClient
        Try
            Loggin("启动SSH连接...")
            sshc = New SshClient(IP, Port, User, Passwd)
            Loggin("完成" & vbCrLf)
            proMain.Value = 55
        Catch ex As Exception
            Loggin("失败：" & ex.Message & vbCrLf)
            Exit Sub
        End Try


        'Establish SSH Connection
        Try
            Loggin("正在连接至服务器...")
            sshc.Connect()
            Loggin("完成" & vbCrLf)
            proMain.Value = 60
        Catch ex As Exception
            Loggin("失败：" & ex.Message & vbCrLf)
            Exit Sub
        End Try


        'Grant Execution Permission
        Dim cmd As SshCommand
        Try
            Loggin("向install.sh添加可执行权限...")
            cmd = sshc.CreateCommand("chmod +x /root/boomvm/install.sh")
            cmd.Execute()
            Loggin("完成" & vbCrLf)
            proMain.Value = 65
        Catch ex As Exception
            Loggin("失败：" & ex.Message & vbCrLf)
            Exit Sub
        End Try

        'Process Installation
        Try
            Loggin("正在进行安装...")
            cmd = sshc.CreateCommand("bash /root/boomvm/install.sh" & Param)
            Dim result As String = cmd.Execute()
            Loggin("完成" & vbCrLf)
            proMain.Value = 100
            Loggin(vbCrLf)
            Loggin("部署结束，详细信息将显示在下方。" & vbCrLf)
            Loggin(vbCrLf & "====================" & vbCrLf)
            result.Replace(vbLf, vbCrLf)
            txtMain.AppendText(result)
        Catch ex As Exception
            Loggin("失败：" & ex.Message & vbCrLf)
            Exit Sub
        End Try

    End Sub

    'Closing the window
    Private Sub DeployForm_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        txtMain.Clear()
    End Sub
End Class