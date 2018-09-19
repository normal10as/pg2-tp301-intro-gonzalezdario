Imports Entidades

Module LoroTest

    Sub Main()

        Dim loro1 As New Loro
        loro1.FechaNacimiento = #1989-10-10#

        loro1.Escuchar("Papita")
        loro1.Escuchar("pa el loro")
        loro1.Escuchar("Juan")

        Console.WriteLine(loro1.Hablar())
        Console.WriteLine(loro1.Hablar())
        Console.WriteLine(loro1.Hablar())
        Console.WriteLine(loro1.Hablar())

        Console.WriteLine(loro1.Edad)

    End Sub

End Module
