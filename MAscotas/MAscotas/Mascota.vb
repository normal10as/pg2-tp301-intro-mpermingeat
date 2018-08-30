Imports ClassLibrary1

Module Mascota

    Sub Main()
        Dim pepe As Loro
        pepe = New Loro
        pepe.Escuchar("Papita ")
        pepe.Escuchar("Pa el loro ")
        pepe.Escuchar("juan")


        Console.WriteLine(pepe.Hablar())
        Console.WriteLine(pepe.Hablar())
        Console.WriteLine(pepe.Hablar())
        Console.WriteLine(pepe.Edad)
    End Sub

End Module
