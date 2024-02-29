Imports System.Runtime.Remoting.Messaging
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
    Sub insertnickel()
        nickels = nickels + 1
    End Sub
    Sub insertdime()
        dimes = dimes + 1
    End Sub
    Sub insertdollar()
        Dollars = Dollars + 1
    End Sub
    Sub buy(p As productcontrol)
        If p.count > 0 And p.productPrice <= _total Then
            p.buy()
            _total = _total - p.productPrice
            quarters = 0
            nickels = _total / 0.05
            dimes = 0
            Dollars = 0
            RaiseEvent buyevent(p.productpicture)
        End If
    End Sub

End Class
