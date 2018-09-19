Imports Entidades

Module CotorraTest

    Sub Main()

        Dim cotorra1 As New Cotorra
        cotorra1.FechaNacimiento = #1989-10-10#
        cotorra1.Nombre = "Pepo"

        cotorra1.Escuchar("Hola")
        cotorra1.Escuchar("Papita")
        cotorra1.Escuchar("pa la cotorra")
        cotorra1.Escuchar("Juancho")
        cotorra1.Escuchar("Papita")

        Console.WriteLine(cotorra1.Edad)
        Console.WriteLine(cotorra1.EdadHumana)
        Console.WriteLine(cotorra1.Nombre)

        Console.WriteLine(cotorra1.Hablar())
        Console.WriteLine(cotorra1.Hablar())
        Console.WriteLine(cotorra1.Hablar())

        Console.WriteLine(cotorra1.Edad)

    End Sub

End Module
