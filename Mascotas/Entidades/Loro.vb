Public Class Loro
    Private _fechaNacimiento As Date
    Private _nombre As String
    Private _memoria As Queue(Of String)
    Private texto As String

    'Constructor
    Public Sub New()
        Me.FechaNacimiento = Date.Now()
        Me.Nombre = "Anonimo"
        _memoria = New Queue(Of String)
        texto = ""
    End Sub

    Public Sub New(FechaNacimiento As Date, Nombre As String)
        Me.FechaNacimiento = FechaNacimiento
        Me.Nombre = Nombre
    End Sub

    'Propiedades
    Public ReadOnly Property Edad As Short
        Get
            Return CalcularEdad(FechaNacimiento)
        End Get
    End Property

    Public Property FechaNacimiento As Date
        Get
            Return _fechaNacimiento
        End Get
        Set(value As Date)
            _fechaNacimiento = value
        End Set
    End Property

    Public Property Nombre As String
        Get
            Return _nombre
        End Get
        Set(value As String)
            _nombre = value
        End Set
    End Property

    'Metodos
    Private Function CalcularEdad(FechaNacimiento As Date) As UShort
        Dim edad As UShort
        edad = Year(Date.Now) - Year(FechaNacimiento)
        If Month(Date.Now) > Month(FechaNacimiento) Then
            Return edad
        Else
            Return edad - 1
        End If
    End Function

    Public Overrides Function ToString() As String
        Return Nombre
    End Function

    Public Overridable Sub Escuchar(value As String)
        _memoria.Enqueue(value)
    End Sub

    Public Function Hablar() As String
        If _memoria.Count > 0 Then
            texto = texto & _memoria.Dequeue & " "
        End If
        Return texto
    End Function

End Class