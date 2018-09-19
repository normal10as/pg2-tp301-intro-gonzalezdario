Imports Entidades

Module JaulaTest

    Sub Main()
        Dim Chismosin As New Cotorra("Chismosin")
        Dim Chismosito As New Cotorra("Chismosito")
        Dim Chismosita As New Cotorra("Chismosita")
        Dim Chismoson As New Cotorra("Chismoson")

        Dim jaula1 As New Jaula
        jaula1.Nombre = "Los chismosos"
        jaula1.AddCotorras(Chismosin)
        jaula1.AddCotorras(Chismosito)
        jaula1.AddCotorras(Chismosita)

        Console.WriteLine(jaula1.ToString())
        Informar(jaula1)

        jaula1.AddCotorras(Chismoson)
        Console.WriteLine(jaula1.ToString())
        Informar(jaula1)

    End Sub

    Sub Informar(jaula1 As Jaula)
        For Each cotorra In jaula1.GetAllCotorras
            Console.WriteLine(cotorra.Nombre)
        Next
    End Sub
End Module
