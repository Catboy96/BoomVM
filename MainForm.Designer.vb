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
        resources.ApplyResources(Me.Label1, "Label1")
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Name = "Label1"
        '
        'Label2
        '
        resources.ApplyResources(Me.Label2, "Label2")
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Name = "Label2"
        '
        'Label3
        '
        resources.ApplyResources(Me.Label3, "Label3")
        Me.Label3.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Name = "Label3"
        '
        'txtBOM
        '
        resources.ApplyResources(Me.txtBOM, "txtBOM")
        Me.txtBOM.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.txtBOM.ForeColor = System.Drawing.Color.White
        Me.txtBOM.Name = "txtBOM"
        '
        'Button1
        '
        resources.ApplyResources(Me.Button1, "Button1")
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Name = "Button1"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Label5
        '
        resources.ApplyResources(Me.Label5, "Label5")
        Me.Label5.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Name = "Label5"
        '
        'Label6
        '
        resources.ApplyResources(Me.Label6, "Label6")
        Me.Label6.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Name = "Label6"
        '
        'Label7
        '
        resources.ApplyResources(Me.Label7, "Label7")
        Me.Label7.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Name = "Label7"
        '
        'txtPort
        '
        resources.ApplyResources(Me.txtPort, "txtPort")
        Me.txtPort.BackColor = System.Drawing.Color.Black
        Me.txtPort.ForeColor = System.Drawing.Color.White
        Me.txtPort.Name = "txtPort"
        '
        'txtIP
        '
        resources.ApplyResources(Me.txtIP, "txtIP")
        Me.txtIP.AutoOverwrite = True
        Me.txtIP.BackColor = System.Drawing.Color.Black
        '
        '
        '
        Me.txtIP.BackgroundStyle.Class = "DateTimeInputBackground"
        Me.txtIP.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtIP.ButtonClear.DisplayPosition = CType(resources.GetObject("txtIP.ButtonClear.DisplayPosition"), Integer)
        Me.txtIP.ButtonClear.Image = CType(resources.GetObject("txtIP.ButtonClear.Image"), System.Drawing.Image)
        Me.txtIP.ButtonClear.Text = resources.GetString("txtIP.ButtonClear.Text")
        Me.txtIP.ButtonClear.Tooltip = resources.GetString("txtIP.ButtonClear.Tooltip")
        Me.txtIP.ButtonCustom.DisplayPosition = CType(resources.GetObject("txtIP.ButtonCustom.DisplayPosition"), Integer)
        Me.txtIP.ButtonCustom.Image = CType(resources.GetObject("txtIP.ButtonCustom.Image"), System.Drawing.Image)
        Me.txtIP.ButtonCustom.Text = resources.GetString("txtIP.ButtonCustom.Text")
        Me.txtIP.ButtonCustom.Tooltip = resources.GetString("txtIP.ButtonCustom.Tooltip")
        Me.txtIP.ButtonCustom2.DisplayPosition = CType(resources.GetObject("txtIP.ButtonCustom2.DisplayPosition"), Integer)
        Me.txtIP.ButtonCustom2.Image = CType(resources.GetObject("txtIP.ButtonCustom2.Image"), System.Drawing.Image)
        Me.txtIP.ButtonCustom2.Text = resources.GetString("txtIP.ButtonCustom2.Text")
        Me.txtIP.ButtonCustom2.Tooltip = resources.GetString("txtIP.ButtonCustom2.Tooltip")
        Me.txtIP.ButtonDropDown.DisplayPosition = CType(resources.GetObject("txtIP.ButtonDropDown.DisplayPosition"), Integer)
        Me.txtIP.ButtonDropDown.Image = CType(resources.GetObject("txtIP.ButtonDropDown.Image"), System.Drawing.Image)
        Me.txtIP.ButtonDropDown.Text = resources.GetString("txtIP.ButtonDropDown.Text")
        Me.txtIP.ButtonDropDown.Tooltip = resources.GetString("txtIP.ButtonDropDown.Tooltip")
        Me.txtIP.ButtonFreeText.DisplayPosition = CType(resources.GetObject("txtIP.ButtonFreeText.DisplayPosition"), Integer)
        Me.txtIP.ButtonFreeText.Image = CType(resources.GetObject("txtIP.ButtonFreeText.Image"), System.Drawing.Image)
        Me.txtIP.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2
        Me.txtIP.ButtonFreeText.Text = resources.GetString("txtIP.ButtonFreeText.Text")
        Me.txtIP.ButtonFreeText.Tooltip = resources.GetString("txtIP.ButtonFreeText.Tooltip")
        Me.txtIP.ButtonFreeText.Visible = True
        Me.txtIP.ForeColor = System.Drawing.Color.White
        Me.txtIP.Name = "txtIP"
        Me.txtIP.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.txtIP.Value = "0.0.0.0"
        '
        'Label8
        '
        resources.ApplyResources(Me.Label8, "Label8")
        Me.Label8.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Name = "Label8"
        '
        'Label9
        '
        resources.ApplyResources(Me.Label9, "Label9")
        Me.Label9.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Name = "Label9"
        '
        'txtUser
        '
        resources.ApplyResources(Me.txtUser, "txtUser")
        Me.txtUser.BackColor = System.Drawing.Color.Black
        Me.txtUser.ForeColor = System.Drawing.Color.White
        Me.txtUser.Name = "txtUser"
        '
        'Label10
        '
        resources.ApplyResources(Me.Label10, "Label10")
        Me.Label10.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.Label10.ForeColor = System.Drawing.Color.White
        Me.Label10.Name = "Label10"
        '
        'txtPasswd
        '
        resources.ApplyResources(Me.txtPasswd, "txtPasswd")
        Me.txtPasswd.BackColor = System.Drawing.Color.Black
        Me.txtPasswd.ForeColor = System.Drawing.Color.White
        Me.txtPasswd.Name = "txtPasswd"
        '
        'Button2
        '
        resources.ApplyResources(Me.Button2, "Button2")
        Me.Button2.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.Button2.ForeColor = System.Drawing.Color.White
        Me.Button2.Name = "Button2"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button3
        '
        resources.ApplyResources(Me.Button3, "Button3")
        Me.Button3.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.Button3.ForeColor = System.Drawing.Color.White
        Me.Button3.Name = "Button3"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button4
        '
        resources.ApplyResources(Me.Button4, "Button4")
        Me.Button4.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.Button4.ForeColor = System.Drawing.Color.White
        Me.Button4.Name = "Button4"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'ofdMain
        '
        resources.ApplyResources(Me.ofdMain, "ofdMain")
        '
        'btnInfo
        '
        resources.ApplyResources(Me.btnInfo, "btnInfo")
        Me.btnInfo.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.btnInfo.ForeColor = System.Drawing.Color.White
        Me.btnInfo.Name = "btnInfo"
        Me.btnInfo.UseVisualStyleBackColor = False
        '
        'sfdMain
        '
        resources.ApplyResources(Me.sfdMain, "sfdMain")
        '
        'picBOM
        '
        resources.ApplyResources(Me.picBOM, "picBOM")
        Me.picBOM.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.picBOM.ForeColor = System.Drawing.Color.White
        Me.picBOM.Image = Global.BoomVM.My.Resources.Resources.FUS_004
        Me.picBOM.Name = "picBOM"
        Me.picBOM.TabStop = False
        '
        'PictureBox1
        '
        resources.ApplyResources(Me.PictureBox1, "PictureBox1")
        Me.PictureBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.PictureBox1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox1.ForeColor = System.Drawing.Color.White
        Me.PictureBox1.Image = Global.BoomVM.My.Resources.Resources.BoomVM_004
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.TabStop = False
        '
        'MainForm
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
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
        Me.MaximizeBox = False
        Me.Name = "MainForm"
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
    Public WithEvents txtUser As TextBox
    Public WithEvents txtPasswd As TextBox
    Public WithEvents txtIP As DevComponents.Editors.IpAddressInput
End Class
