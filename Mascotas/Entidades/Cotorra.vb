Public Class Cotorra
    Inherits Loro

    Private _escuchar As Boolean

    Sub New()
        MyBase.FechaNacimiento = Date.Now()
        MyBase.Nombre = ""
        _escuchar = True
    End Sub

    Sub New(Nombre As String)
        MyBase.FechaNacimiento = Date.Now()
        MyBase.Nombre = Nombre
        _escuchar = True
    End Sub

    Public ReadOnly Property EdadHumana As Short
        Get
            Return MyBase.Edad * 2
        End Get
    End Property

    Public Overrides Sub Escuchar(value As String)
        If _escuchar = True Then
            MyBase.Escuchar(value)
        End If
        _escuchar = Not _escuchar
    End Sub

End Class
