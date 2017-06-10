Module MainModule

    Sub Main()

        Dim injector As New Mother
        Dim clientObject As New Child(injector.GetDrinkService())

        clientObject.Drink()

        Console.ReadLine()

    End Sub

End Module
