Public Class Loro

    Private _nombre As String
    Private _fechaNacimiento As Date
    Private _edad As Short
    Private _memoria As New Queue

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
            Return _edad
        End Get

    End Property

    Private Property Memoria() As String
        Get
            Return _memoria.Peek()
        End Get
        Set(ByVal value As String)
            Dim aux As String
            aux = value
            _memoria.Enqueue(aux)
        End Set
    End Property

    '////////// Metodos /////////////////////
    Public Sub Escuchar(ByRef sonido As String)
        _memoria.Enqueue(sonido)
    End Sub

    Public Sub Hablar(ByRef numero As Integer)
        For index = 1 To numero
            Console.WriteLine(_memoria.Peek())
        Next
    End Sub

End Class
