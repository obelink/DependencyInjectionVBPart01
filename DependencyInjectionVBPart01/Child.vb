Public Class Child

    Private ReadOnly _drinkService As IDrinkService

    Public Sub New(drinkService As IDrinkService)
        _drinkService = drinkService
    End Sub

    Public Sub Drink()
        _drinkService.Drink()
    End Sub

End Class
