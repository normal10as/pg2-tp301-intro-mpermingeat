Public Class Loro

    Private _nombre As String
    Private _fechaNacimiento As Date
    Private _edad As Short
    Private _memoria As New Queue
    Private texto As String

    Public Sub New()
        Nombre = ""
        FechaNacimiento = Date.Now

    End Sub
    '////////// Properties /////////////////////
    Public Property Nombre() As String
        Get
            Return _nombre
        End Get
        Set(ByVal value As String)
            _nombre = value
        End Set
    End Property

    Public Property FechaNacimiento() As Date
        Get
            Return _fechaNacimiento
        End Get
        Set(ByVal value As Date)
            _fechaNacimiento = value
        End Set
    End Property

    Public ReadOnly Property Edad() As Short
        Get
            _edad = Now.Year - _fechaNacimiento.Year
            Return _edad
        End Get

    End Property



    '////////// Metodos /////////////////////
    Public Sub Escuchar(ByRef sonido As String)
        _memoria.Enqueue(sonido)
    End Sub

    Public Function Hablar()
        texto = texto & _memoria.Dequeue
        Return texto
    End Function

End Class
