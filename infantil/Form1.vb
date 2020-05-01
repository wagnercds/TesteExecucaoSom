
Public Class Form1

    
    Private Sub Button2_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button2.MouseEnter
        Media.AutoStart = False
        Media.FileName = "D:\projetos\Infantil\papai.wav"
        Media.Play()
    End Sub

    Private Sub Button1_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button1.MouseEnter
        Media.AutoStart = False
        Media.FileName = "D:\projetos\Infantil\mamae.wav"
        Media.Play()
    End Sub
End Class
