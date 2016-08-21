<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class InfoForm
    Inherits DevComponents.DotNetBar.Metro.MetroForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(InfoForm))
        Me.picMain = New System.Windows.Forms.PictureBox()
        Me.lblPackName = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblAuthor = New System.Windows.Forms.Label()
        Me.txtIntro = New System.Windows.Forms.TextBox()
        CType(Me.picMain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'picMain
        '
        Me.picMain.Location = New System.Drawing.Point(15, 15)
        Me.picMain.Margin = New System.Windows.Forms.Padding(4)
        Me.picMain.Name = "picMain"
        Me.picMain.Size = New System.Drawing.Size(90, 90)
        Me.picMain.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picMain.TabIndex = 0
        Me.picMain.TabStop = False
        '
        'lblPackName
        '
        Me.lblPackName.AutoSize = True
        Me.lblPackName.Font = New System.Drawing.Font("Î¢ÈíÑÅºÚ", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.lblPackName.Location = New System.Drawing.Point(113, 26)
        Me.lblPackName.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblPackName.Name = "lblPackName"
        Me.lblPackName.Size = New System.Drawing.Size(156, 36)
        Me.lblPackName.TabIndex = 1
        Me.lblPackName.Text = "PackName"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(115, 68)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(78, 23)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "ÖÆ×÷Õß£º"
        '
        'lblAuthor
        '
        Me.lblAuthor.AutoSize = True
        Me.lblAuthor.Location = New System.Drawing.Point(191, 68)
        Me.lblAuthor.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblAuthor.Name = "lblAuthor"
        Me.lblAuthor.Size = New System.Drawing.Size(65, 23)
        Me.lblAuthor.TabIndex = 2
        Me.lblAuthor.Text = "Author"
        '
        'txtIntro
        '
        Me.txtIntro.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtIntro.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtIntro.ForeColor = System.Drawing.Color.White
        Me.txtIntro.Location = New System.Drawing.Point(15, 113)
        Me.txtIntro.Multiline = True
        Me.txtIntro.Name = "txtIntro"
        Me.txtIntro.ReadOnly = True
        Me.txtIntro.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtIntro.Size = New System.Drawing.Size(732, 333)
        Me.txtIntro.TabIndex = 3
        '
        'InfoForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 23.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(759, 458)
        Me.Controls.Add(Me.txtIntro)
        Me.Controls.Add(Me.lblAuthor)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lblPackName)
        Me.Controls.Add(Me.picMain)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Î¢ÈíÑÅºÚ", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "InfoForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "InfoForm"
        CType(Me.picMain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents picMain As PictureBox
    Friend WithEvents lblPackName As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents lblAuthor As Label
    Friend WithEvents txtIntro As TextBox
End Class
