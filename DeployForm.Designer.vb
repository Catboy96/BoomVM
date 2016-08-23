<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DeployForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DeployForm))
        Me.txtMain = New System.Windows.Forms.TextBox()
        Me.proMain = New DevComponents.DotNetBar.Controls.ProgressBarX()
        Me.SuspendLayout()
        '
        'txtMain
        '
        Me.txtMain.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtMain.BackColor = System.Drawing.Color.Black
        Me.txtMain.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtMain.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMain.ForeColor = System.Drawing.Color.White
        Me.txtMain.Location = New System.Drawing.Point(0, 0)
        Me.txtMain.Multiline = True
        Me.txtMain.Name = "txtMain"
        Me.txtMain.ReadOnly = True
        Me.txtMain.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtMain.Size = New System.Drawing.Size(653, 407)
        Me.txtMain.TabIndex = 0
        '
        'proMain
        '
        '
        '
        '
        Me.proMain.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.proMain.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.proMain.Location = New System.Drawing.Point(0, 413)
        Me.proMain.Name = "proMain"
        Me.proMain.Size = New System.Drawing.Size(653, 23)
        Me.proMain.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.proMain.TabIndex = 2
        Me.proMain.Text = "ProgressBarX1"
        Me.proMain.Value = 50
        '
        'DeployForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(653, 436)
        Me.Controls.Add(Me.proMain)
        Me.Controls.Add(Me.txtMain)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "DeployForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "²¿Êð½ø³Ì"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtMain As TextBox
    Friend WithEvents proMain As DevComponents.DotNetBar.Controls.ProgressBarX
End Class
