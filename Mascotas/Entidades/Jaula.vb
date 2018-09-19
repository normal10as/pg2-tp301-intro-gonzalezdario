Public Class Jaula

    Private _nombre As String
    Private _loro As Loro
    Private _cotorras As List(Of Cotorra)

    Sub New()
        Me.Nombre = Nombre
        _cotorras = New List(Of Cotorra)
    End Sub

    Public Property Nombre As String
        Get
            Return _nombre
        End Get
        Set(value As String)
            _nombre = value
        End Set
    End Property

    Public Property Loro As Loro
        Get
            Return _loro
        End Get
        Set(value As Loro)
            _loro = value
        End Set
    End Property

    Public Sub AddCotorras(cotorra As Cotorra)
        If _cotorras.Count < 3 Then
            _cotorras.Add(cotorra)
        End If
    End Sub

    Public Function GetAllCotorras() As List(Of Cotorra)
        Return _cotorras
    End Function

    Public Overrides Function ToString() As String
        Return "Esta es la jaula: " & Nombre
    End Function

End Class
