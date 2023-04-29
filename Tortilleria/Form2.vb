Imports System.ComponentModel

Public Class Form2
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Form1.Dispose()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles BOTON_Pronostico_de_ventas.Click
        Pronostico_de_Ventas_CLASE.Visible = True
    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles Me.Load
        Form1.Hide()


    End Sub

    Private Sub Form2_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Form1.Dispose()

    End Sub
End Class