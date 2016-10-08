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
        resources.ApplyResources(Me.txtMain, "txtMain")
        Me.txtMain.BackColor = System.Drawing.Color.Black
        Me.txtMain.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtMain.ForeColor = System.Drawing.Color.White
        Me.txtMain.Name = "txtMain"
        Me.txtMain.ReadOnly = True
        '
        'proMain
        '
        resources.ApplyResources(Me.proMain, "proMain")
        Me.proMain.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        '
        '
        '
        Me.proMain.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.proMain.ForeColor = System.Drawing.Color.White
        Me.proMain.Name = "proMain"
        Me.proMain.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        '
        'DeployForm
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.proMain)
        Me.Controls.Add(Me.txtMain)
        Me.DoubleBuffered = True
        Me.Name = "DeployForm"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtMain As TextBox
    Friend WithEvents proMain As DevComponents.DotNetBar.Controls.ProgressBarX
End Class
