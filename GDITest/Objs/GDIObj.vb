Public Class GDIObj
    Dim _pen As Pen
    Dim _g As Graphics

    Public Sub New(pen As Pen, g As Graphics)
        _pen = pen
        _g = g
    End Sub

    Public Sub Dispose()
        _pen.Dispose()
        _g.Dispose()
    End Sub

End Class


Public Class ThreadedRefreshEventArgs
    Public _value As Integer

    Public Sub New(value As Integer)
        _value = value
    End Sub
End Class
