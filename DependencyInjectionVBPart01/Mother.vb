Public Class Mother

    Public Function GetDrinkService() As IDrinkService
        Return New MilkDrinkService()
    End Function

End Class
