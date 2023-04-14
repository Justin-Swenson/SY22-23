Public Class box
    Public Property Length As Integer
    Public Property Width As Integer
    Public Property Height As Integer
    Public ReadOnly Property volume As Integer
        Get
            Return Length * Width * Height
        End Get
    End Property
End Class
