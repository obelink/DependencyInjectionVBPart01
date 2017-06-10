Public Class Mother

    Public Function GetDrinkService() As IDrinkService
        Return New MilkDrinkService()
        'Return New OrangeJuiceDrinkService()
        'Return New AppleJuiceDrinkService()
    End Function

End Class
