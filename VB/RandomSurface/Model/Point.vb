#Region "#Model"
Namespace Bar3DChart
   Public Class Point
		Private privateX As Double
		Public Property X() As Double
			Get
				Return privateX
			End Get
			Private Set(ByVal value As Double)
				privateX = value
			End Set
		End Property
		Private privateY As Double
		Public Property Y() As Double
			Get
				Return privateY
			End Get
			Private Set(ByVal value As Double)
				privateY = value
			End Set
		End Property
		Private privateZ As Double
		Public Property Z() As Double
			Get
				Return privateZ
			End Get
			Private Set(ByVal value As Double)
				privateZ = value
			End Set
		End Property

		Public Sub New(ByVal x As Double, ByVal y As Double, ByVal z As Double)
			Me.X = x
			Me.Y = y
			Me.Z = z
		End Sub
   End Class
End Namespace
#End Region ' #Model