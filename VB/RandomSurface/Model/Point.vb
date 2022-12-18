#Region "#Model"
Namespace Bar3DChart

    Public Class Point

        Private _X As Double, _Y As Double, _Z As Double

        Public Property X As Double
            Get
                Return _X
            End Get

            Private Set(ByVal value As Double)
                _X = value
            End Set
        End Property

        Public Property Y As Double
            Get
                Return _Y
            End Get

            Private Set(ByVal value As Double)
                _Y = value
            End Set
        End Property

        Public Property Z As Double
            Get
                Return _Z
            End Get

            Private Set(ByVal value As Double)
                _Z = value
            End Set
        End Property

        Public Sub New(ByVal x As Double, ByVal y As Double, ByVal z As Double)
            Me.X = x
            Me.Y = y
            Me.Z = z
        End Sub
    End Class
End Namespace
#End Region  ' #Model
