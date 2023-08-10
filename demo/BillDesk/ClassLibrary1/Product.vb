Public Class Product
    Private product_id As Integer
    Public Property productid() As Integer
        Get
            Return product_id


        End Get
        Set(ByVal value As Integer)
            product_id = value

        End Set

    End Property
    Public product_name As String
    Public rate As Integer
    Public qty As Integer



End Class
