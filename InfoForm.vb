Imports System.ComponentModel

Public Class InfoForm

    Private Temp As String = Application.StartupPath & "\Temp"

    Private Sub InfoForm_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        'Dispose Loaded Image
        picMain.Image.Dispose()
    End Sub

    Private Sub InfoForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Create Stream Reader
        Dim sr As IO.StreamReader

        'Load Title
        sr = New IO.StreamReader(Temp & "\packname", System.Text.Encoding.UTF8)
        Me.Text = sr.ReadToEnd()
        lblPackName.Text = Me.Text
        sr.Close()
        sr.Dispose()

        'Load Author
        sr = New IO.StreamReader(Temp & "\author", System.Text.Encoding.UTF8)
        lblAuthor.Text = sr.ReadToEnd()
        sr.Close()
        sr.Dispose()

        'Load Intro
        sr = New IO.StreamReader(Temp & "\intro", System.Text.Encoding.UTF8)
        txtIntro.Text = sr.ReadToEnd()
        sr.Close()
        sr.Dispose()

        'Load Logo
        picMain.Image = Image.FromFile(Temp & "\logo.png")

    End Sub
End Class