Public Class Loro

    Private _nombre As String
    Private _fechaNacimiento As Date
    Private _edad As Short
    Private _memoria As New Queue

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

    Private Property Memoria() As Queue
        Get
            Return _memoria
        End Get
        Set(ByVal value As Queue)
            _memoria = value
        End Set
    End Property

    '////////// Metodos /////////////////////

End Class
