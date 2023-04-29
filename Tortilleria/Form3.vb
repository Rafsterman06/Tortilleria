Public Class Pronostico_de_Ventas_CLASE

    Dim Pronostico() As Integer
    Dim Precio() As Integer
    Dim Presupuesto(12) As Integer
    Dim total1, total2 As String

    Sub llenadoPronostico()

        Pronostico = {PronVEnero.Text, PronVFebrero.Text, PronVMarzo.Text, PronVAbril.Text, PronVMayo.Text, PronVJunio.Text, PronVJulio.Text, PronVAgosto.Text, PronVSeptiembre.Text, PronVOctubre.Text, PronVNoviembre.Text, PronVDiciembre.Text}

    End Sub
    Sub llenadoPrecio()

        Precio = {PrecVEnero.Text, PrecVFebrero.Text, PrecVMarzo.Text, PrecVAbril.Text, PrecVMayo.Text, PrecVJunio.Text, PrecVJulio.Text, PrecVAgosto.Text, PrecVSeptiembre.Text, PrecVOctubre.Text, PrecVNoviembre.Text, PrecVDiciembre.Text}

    End Sub

    Sub totalPronostico()
        Dim totalpron, auxpron As Integer

        For i = 0 To UBound(Pronostico)

            auxpron = Pronostico(i)
            totalpron += auxpron

        Next

        PronTotal.Text = totalpron
        total1 = PronTotal.Text
    End Sub
    Sub multiplicacion(arreglo1() As Integer, arreglo2() As Integer, arreglo3() As Integer)
        'arreglo1 es el pronostico
        'arreglo2 es el precio
        'arreglo3 es el presupuesto

        For i = 0 To UBound(arreglo1)


            arreglo3(i) = arreglo2(i) * arreglo1(i)
        Next
    End Sub
    Sub mostrarMultiplicacion()

        PresVEnero.Text = Presupuesto(0)
        PresVFebrero.Text = Presupuesto(1)
        PresVMarzo.Text = Presupuesto(2)
        PresVAbril.Text = Presupuesto(3)
        PresVMayo.Text = Presupuesto(4)
        PresVJunio.Text = Presupuesto(5)
        PresVJulio.Text = Presupuesto(6)
        PresVAgosto.Text = Presupuesto(7)
        PresVSeptiembre.Text = Presupuesto(8)
        PresVOctubre.Text = Presupuesto(9)
        PresVNoviembre.Text = Presupuesto(10)
        PresVDiciembre.Text = Presupuesto(11)
    End Sub
    Sub totalPresupuestoSuma()
        Dim totalpres, auxpres As Integer
        For i = 0 To UBound(Presupuesto)
            auxpres = Presupuesto(i)
            totalpres += auxpres

        Next
        PresTotal.Text = totalpres
        total2 = PresTotal.Text
    End Sub
    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Calcular.Click

        Call llenadoPronostico()
        Call llenadoPrecio()
        Call totalPronostico()
        Call multiplicacion(Pronostico, Precio, Presupuesto)
        Call mostrarMultiplicacion()
        Call totalPresupuestoSuma()


    End Sub

    Private Sub Vaciar_Click(sender As Object, e As EventArgs) Handles Vaciar.Click
        'Precio
        PrecVEnero.Text = 0
        PrecVFebrero.Text = 0
        PrecVMarzo.Text = 0
        PrecVAbril.Text = 0
        PrecVMayo.Text = 0
        PrecVJunio.Text = 0
        PrecVJulio.Text = 0
        PrecVAgosto.Text = 0
        PrecVSeptiembre.Text = 0
        PrecVOctubre.Text = 0
        PrecVNoviembre.Text = 0
        PrecVDiciembre.Text = 0
        'Presupuesto
        PresVEnero.Text = 0
        PresVFebrero.Text = 0
        PresVMarzo.Text = 0
        PresVAbril.Text = 0
        PresVMayo.Text = 0
        PresVJunio.Text = 0
        PresVJulio.Text = 0
        PresVAgosto.Text = 0
        PresVSeptiembre.Text = 0
        PresVOctubre.Text = 0
        PresVNoviembre.Text = 0
        PresVDiciembre.Text = 0
        'Pronostico
        PronVEnero.Text = 0
        PronVFebrero.Text = 0
        PronVMarzo.Text = 0
        PronVAbril.Text = 0
        PronVMayo.Text = 0
        PronVJunio.Text = 0
        PronVJulio.Text = 0
        PronVAgosto.Text = 0
        PronVSeptiembre.Text = 0
        PronVOctubre.Text = 0
        PronVNoviembre.Text = 0
        PronVDiciembre.Text = 0
        'TOTALES
        PronTotal.Text = ""
        PresTotal.Text = ""
    End Sub

    Private Sub Imprimir_Click(sender As Object, e As EventArgs) Handles Imprimir.Click
        Dim ExcelApp = New Microsoft.Office.Interop.Excel.Application
        Dim Libro = ExcelApp.Workbooks.Add

        Libro.Worksheets("hoja1").cells(1, 1) = "MES"
        Libro.Worksheets("hoja1").cells(2, 1) = "ENERO"
        Libro.Worksheets("hoja1").cells(3, 1) = "FEBRERO"
        Libro.Worksheets("hoja1").cells(4, 1) = "MARZO"
        Libro.Worksheets("hoja1").cells(5, 1) = "ABRIL"
        Libro.Worksheets("hoja1").cells(6, 1) = "MAYO"
        Libro.Worksheets("hoja1").cells(7, 1) = "JUNIO"
        Libro.Worksheets("hoja1").cells(8, 1) = "JULIO"
        Libro.Worksheets("hoja1").cells(9, 1) = "AGOSTO"
        Libro.Worksheets("hoja1").cells(10, 1) = "SEPTIEMBRE"
        Libro.Worksheets("hoja1").cells(11, 1) = "OCTUBRE"
        Libro.Worksheets("hoja1").cells(12, 1) = "NOVIEMBRE"
        Libro.Worksheets("hoja1").cells(13, 1) = "DICIEMBRE"
        Libro.Worksheets("hoja1").cells(14, 1) = "TOTAL"
        Libro.Worksheets("hoja1").cells(1, 2) = "PRONOSTICO DE VENTAS"
        Libro.Worksheets("hoja1").cells(2, 2) = "" & PronVEnero.Text
        Libro.Worksheets("hoja1").cells(3, 2) = "" & PronVFebrero.Text
        Libro.Worksheets("hoja1").cells(4, 2) = "" & PronVMarzo.Text
        Libro.Worksheets("hoja1").cells(5, 2) = "" & PronVAbril.Text
        Libro.Worksheets("hoja1").cells(6, 2) = "" & PronVMayo.Text
        Libro.Worksheets("hoja1").cells(7, 2) = "" & PronVJunio.Text
        Libro.Worksheets("hoja1").cells(8, 2) = "" & PronVJulio.Text
        Libro.Worksheets("hoja1").cells(9, 2) = "" & PronVAgosto.Text
        Libro.Worksheets("hoja1").cells(10, 2) = "" & PronVSeptiembre.Text
        Libro.Worksheets("hoja1").cells(11, 2) = "" & PronVOctubre.Text
        Libro.Worksheets("hoja1").cells(12, 2) = "" & PronVNoviembre.Text
        Libro.Worksheets("hoja1").cells(13, 2) = "" & PronVDiciembre.Text
        Libro.Worksheets("hoja1").cells(1, 3) = "PRECIO DE VENTAS"
        Libro.Worksheets("hoja1").cells(2, 3) = PrecVEnero.Text
        Libro.Worksheets("hoja1").cells(3, 3) = PrecVFebrero.Text
        Libro.Worksheets("hoja1").cells(4, 3) = PrecVMarzo.Text
        Libro.Worksheets("hoja1").cells(5, 3) = PrecVAbril.Text
        Libro.Worksheets("hoja1").cells(6, 3) = PrecVMayo.Text
        Libro.Worksheets("hoja1").cells(7, 3) = PrecVJunio.Text
        Libro.Worksheets("hoja1").cells(8, 3) = PrecVJulio.Text
        Libro.Worksheets("hoja1").cells(9, 3) = PrecVAgosto.Text
        Libro.Worksheets("hoja1").cells(10, 3) = PrecVSeptiembre.Text
        Libro.Worksheets("hoja1").cells(11, 3) = PrecVOctubre.Text
        Libro.Worksheets("hoja1").cells(12, 3) = PrecVNoviembre.Text
        Libro.Worksheets("hoja1").cells(13, 3) = PrecVDiciembre.Text
        Libro.Worksheets("hoja1").cells(1, 4) = "PRESUPUESTO DE VENTAS"
        Libro.Worksheets("hoja1").cells(2, 4) = PresVEnero.Text
        Libro.Worksheets("hoja1").cells(3, 4) = PresVFebrero.Text
        Libro.Worksheets("hoja1").cells(4, 4) = PresVMarzo.Text
        Libro.Worksheets("hoja1").cells(5, 4) = PresVAbril.Text
        Libro.Worksheets("hoja1").cells(6, 4) = PresVMayo.Text
        Libro.Worksheets("hoja1").cells(7, 4) = PresVJunio.Text
        Libro.Worksheets("hoja1").cells(8, 4) = PresVJulio.Text
        Libro.Worksheets("hoja1").cells(9, 4) = PresVAgosto.Text
        Libro.Worksheets("hoja1").cells(12, 4) = PresVNoviembre.Text
        Libro.Worksheets("hoja1").cells(10, 4) = PresVSeptiembre.Text
        Libro.Worksheets("hoja1").cells(11, 4) = PresVOctubre.Text
        Libro.Worksheets("hoja1").cells(13, 4) = PresVDiciembre.Text
        Libro.Worksheets(1).cells(14, 4) = total2
        Libro.Worksheets(1).cells(14, 2) = total1

        Libro.SaveAs(Filename:="C:\Users\f\desktop\PRONOSTICO_DE_VENTAS.xlsx")
        ExcelApp.Quit()
        Libro = Nothing
        ExcelApp = Nothing
        MsgBox("SE A GUARDADO CON EXITO")

    End Sub
End Class