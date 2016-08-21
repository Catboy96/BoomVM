<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainForm
    Inherits DevComponents.DotNetBar.Metro.MetroForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
        Me.StyleMain = New DevComponents.DotNetBar.StyleManager(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtBOM = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtPort = New System.Windows.Forms.TextBox()
        Me.txtIP = New DevComponents.Editors.IpAddressInput()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtUser = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtPasswd = New System.Windows.Forms.TextBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.ofdMain = New System.Windows.Forms.OpenFileDialog()
        Me.btnInfo = New System.Windows.Forms.Button()
        Me.sfdMain = New System.Windows.Forms.SaveFileDialog()
        Me.picBOM = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.txtIP, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picBOM, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'StyleMain
        '
        Me.StyleMain.ManagerStyle = DevComponents.DotNetBar.eStyle.VisualStudio2012Dark
        Me.StyleMain.MetroColorParameters = New DevComponents.DotNetBar.Metro.ColorTables.MetroColorGeneratorParameters(System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer)))
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("微软雅黑", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(88, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(253, 36)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "欢迎使用BoomVM"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(90, 57)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(333, 23)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "只需几个步骤，即可部署应用到你的服务器"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.Label3.Font = New System.Drawing.Font("微软雅黑", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(119, 109)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(192, 31)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "选择一个BOM包"
        '
        'txtBOM
        '
        Me.txtBOM.AutoSize = True
        Me.txtBOM.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.txtBOM.Font = New System.Drawing.Font("微软雅黑", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.txtBOM.ForeColor = System.Drawing.Color.White
        Me.txtBOM.Location = New System.Drawing.Point(128, 183)
        Me.txtBOM.Name = "txtBOM"
        Me.txtBOM.Size = New System.Drawing.Size(90, 32)
        Me.txtBOM.TabIndex = 5
        Me.txtBOM.Text = "未选定"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(134, 234)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(69, 42)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "选择"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.Label5.Font = New System.Drawing.Font("微软雅黑", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(124, 311)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(182, 31)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "提供服务器信息"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.Label6.Font = New System.Drawing.Font("微软雅黑", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(106, 345)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(219, 20)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "填写信息或选择服务器配置文件"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(26, 393)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(59, 23)
        Me.Label7.TabIndex = 11
        Me.Label7.Text = "IP地址"
        '
        'txtPort
        '
        Me.txtPort.BackColor = System.Drawing.Color.Black
        Me.txtPort.ForeColor = System.Drawing.Color.White
        Me.txtPort.Location = New System.Drawing.Point(122, 426)
        Me.txtPort.Name = "txtPort"
        Me.txtPort.Size = New System.Drawing.Size(283, 30)
        Me.txtPort.TabIndex = 10
        Me.txtPort.Text = "22"
        Me.txtPort.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtIP
        '
        Me.txtIP.AutoOverwrite = True
        Me.txtIP.BackColor = System.Drawing.Color.Black
        '
        '
        '
        Me.txtIP.BackgroundStyle.Class = "DateTimeInputBackground"
        Me.txtIP.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtIP.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2
        Me.txtIP.ButtonFreeText.Visible = True
        Me.txtIP.ForeColor = System.Drawing.Color.White
        Me.txtIP.Location = New System.Drawing.Point(122, 390)
        Me.txtIP.Name = "txtIP"
        Me.txtIP.Size = New System.Drawing.Size(282, 30)
        Me.txtIP.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.txtIP.TabIndex = 12
        Me.txtIP.Value = "0.0.0.0"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(26, 429)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(77, 23)
        Me.Label8.TabIndex = 13
        Me.Label8.Text = "SSH端口"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(26, 463)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(61, 23)
        Me.Label9.TabIndex = 13
        Me.Label9.Text = "用户名"
        '
        'txtUser
        '
        Me.txtUser.BackColor = System.Drawing.Color.Black
        Me.txtUser.ForeColor = System.Drawing.Color.White
        Me.txtUser.Location = New System.Drawing.Point(122, 460)
        Me.txtUser.Name = "txtUser"
        Me.txtUser.Size = New System.Drawing.Size(283, 30)
        Me.txtUser.TabIndex = 10
        Me.txtUser.Text = "root"
        Me.txtUser.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.Label10.ForeColor = System.Drawing.Color.White
        Me.Label10.Location = New System.Drawing.Point(26, 496)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(44, 23)
        Me.Label10.TabIndex = 13
        Me.Label10.Text = "密码"
        '
        'txtPasswd
        '
        Me.txtPasswd.BackColor = System.Drawing.Color.Black
        Me.txtPasswd.ForeColor = System.Drawing.Color.White
        Me.txtPasswd.Location = New System.Drawing.Point(122, 493)
        Me.txtPasswd.Name = "txtPasswd"
        Me.txtPasswd.PasswordChar = Global.Microsoft.VisualBasic.ChrW(8226)
        Me.txtPasswd.Size = New System.Drawing.Size(283, 30)
        Me.txtPasswd.TabIndex = 10
        Me.txtPasswd.Text = "123456"
        Me.txtPasswd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.ForeColor = System.Drawing.Color.White
        Me.Button2.Location = New System.Drawing.Point(30, 529)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(173, 42)
        Me.Button2.TabIndex = 14
        Me.Button2.Text = "从文件载入"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.ForeColor = System.Drawing.Color.White
        Me.Button3.Location = New System.Drawing.Point(225, 529)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(180, 42)
        Me.Button3.TabIndex = 15
        Me.Button3.Text = "保存到文件"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.Green
        Me.Button4.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.Font = New System.Drawing.Font("微软雅黑", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Button4.ForeColor = System.Drawing.Color.White
        Me.Button4.Location = New System.Drawing.Point(0, 591)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(430, 62)
        Me.Button4.TabIndex = 16
        Me.Button4.Text = "部署"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'btnInfo
        '
        Me.btnInfo.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnInfo.Enabled = False
        Me.btnInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnInfo.ForeColor = System.Drawing.Color.White
        Me.btnInfo.Location = New System.Drawing.Point(209, 234)
        Me.btnInfo.Name = "btnInfo"
        Me.btnInfo.Size = New System.Drawing.Size(196, 42)
        Me.btnInfo.TabIndex = 17
        Me.btnInfo.Text = "查看详细信息"
        Me.btnInfo.UseVisualStyleBackColor = False
        '
        'sfdMain
        '
        Me.sfdMain.Filter = "BoomVM Server Info|*.svr"
        '
        'picBOM
        '
        Me.picBOM.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.picBOM.ForeColor = System.Drawing.Color.White
        Me.picBOM.Image = Global.BoomVM.My.Resources.Resources.FUS_004
        Me.picBOM.Location = New System.Drawing.Point(12, 167)
        Me.picBOM.Name = "picBOM"
        Me.picBOM.Size = New System.Drawing.Size(110, 110)
        Me.picBOM.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picBOM.TabIndex = 3
        Me.picBOM.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.PictureBox1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox1.ForeColor = System.Drawing.Color.White
        Me.PictureBox1.Image = Global.BoomVM.My.Resources.Resources.BoomVM_004
        Me.PictureBox1.Location = New System.Drawing.Point(12, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(70, 68)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 23.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(430, 653)
        Me.Controls.Add(Me.btnInfo)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtIP)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtPasswd)
        Me.Controls.Add(Me.txtUser)
        Me.Controls.Add(Me.txtPort)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.txtBOM)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.picBOM)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("微软雅黑", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.White
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(448, 700)
        Me.MinimumSize = New System.Drawing.Size(448, 212)
        Me.Name = "MainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "BoomVM"
        CType(Me.txtIP, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picBOM, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents StyleMain As DevComponents.DotNetBar.StyleManager
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents picBOM As PictureBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtBOM As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents ofdMain As OpenFileDialog
    Friend WithEvents btnInfo As Button
    Friend WithEvents sfdMain As SaveFileDialog
    Public WithEvents txtPort As TextBox
    Public WithEvents txtIP As DevComponents.Editors.IpAddressInput
    Public WithEvents txtUser As TextBox
    Public WithEvents txtPasswd As TextBox
End Class
