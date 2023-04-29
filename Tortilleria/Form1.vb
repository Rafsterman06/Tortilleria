Public Class Form1

    Dim usuario() As String = {"RAYMUNDO", "RAFAEL", ""}
    Dim contraseña() As String = {"19887043", "19887041", ""}
    Dim usuar, contr As String
    Dim valor As Integer
    Dim it As Integer = 0
    Sub buscar(arreglo_usu() As String)
        usuar = TextBox1.Text
        For i = 0 To UBound(arreglo_usu)
            If (arreglo_usu(i) = usuar) Then
                valor = i
                Return
            End If
        Next
    End Sub
    Sub comparar_contraseña()
        contr = TextBox2.Text
        usuar = TextBox1.Text
        If (contr = contraseña(valor) And usuar = usuario(valor)) Then
            Form2.Visible = True
        Else

            MsgBox("CONTRASEÑA O USUARIO INCORRECTO")

        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Call buscar(usuario)
        Call comparar_contraseña()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dispose()

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        SetDesktopLocation(500, 100)
        TextBox1.Focus()
    End Sub
End Class
