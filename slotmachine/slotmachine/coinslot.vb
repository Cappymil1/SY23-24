Public Class coinslot
    Public Event coinreturnevent(d As Integer, q As Integer, di As Integer, n As Integer)
    Public Event buyevent(p As Image)

    Public Property quarters As Integer
    Public Property nickels As Integer
    Public Property dimes As Integer
    Public Property Dollars As Integer
    Dim _total As Decimal
    Public ReadOnly Property total As Decimal
        Get
            _total = Dollars + quarters * 0.25 + dimes * 0.1 + nickels * 0.05

            Return _total
        End Get
    End Property
    Sub coinreturn()
        RaiseEvent coinreturnevent(Dollars, quarters, dimes, nickels)
    End Sub
    Sub insertquarter()
        quarters = quarters + 1
    End Sub

    Sub insertdollar()
        Dollars = Dollars + 1
    End Sub

End Class
