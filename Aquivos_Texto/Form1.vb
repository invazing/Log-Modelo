Imports System.IO
Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim oEscrever As System.IO.StreamWriter
        Dim objStream As New System.IO.FileStream("C:\Teste.txt", IO.FileMode.OpenOrCreate)
        Dim Arq As New System.IO.StreamWriter(objStream)
        If IO.File.Exists("C:\Teste.txt") Then
            Arq.Write("Acessado em " + Now)
            Arq.Close()
        Else
            oEscrever = File.CreateText("C:\Teste.txt")
        End If
    End Sub
    Private Sub Ler_Click(sender As Object, e As EventArgs) Handles Ler.Click
        Dim objStream As New System.IO.FileStream("C:\Teste.txt", IO.FileMode.OpenOrCreate)
        Dim Arq As New System.IO.StreamReader(objStream)
        Texto.Clear()
        Texto.Text = Arq.ReadToEnd
        Arq.Close()
    End Sub
    Private Sub Gravar_Click(sender As Object, e As EventArgs) Handles Gravar.Click
        Dim objStream As New System.IO.FileStream("C:\Teste.txt", IO.FileMode.OpenOrCreate)
        Dim Arq As New System.IO.StreamWriter(objStream)
        Arq.Write(Texto.Text)
        Arq.Close()
        MsgBox("Gravado com Sucesso", MsgBoxStyle.Information, Title:="Sucesso")
    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Dim fluxoTexto As IO.StreamWriter
        ' Dim linhaTexto As String
        If IO.File.Exists("C:\Teste.txt") Then
            fluxoTexto = New IO.StreamWriter("C:\Teste.txt", True)
            fluxoTexto.WriteLine("Acessado em " + Now)
            fluxoTexto.Close()
        Else
            MessageBox.Show("Arquivo não existe")
        End If
    End Sub
End Class
