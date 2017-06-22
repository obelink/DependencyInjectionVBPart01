Module MainModule

    Sub Main()

        Dim injector As New Mother
        Dim serviceObject = injector.GetDrinkService()
        Dim clientObject As New Child(serviceObject)

        clientObject.Drink()

        Console.ReadLine()

    End Sub

End Module
