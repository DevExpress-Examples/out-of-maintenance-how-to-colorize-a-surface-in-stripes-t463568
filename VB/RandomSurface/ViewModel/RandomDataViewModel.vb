#Region "#ViewModel"
Imports System
Imports System.Collections.ObjectModel

Namespace Bar3DChart

    Public Class RandomDataViewModel

        Public Property DataPoints As ObservableCollection(Of Point)

        Public Sub New()
            Dim barsCount As Integer = 200
            Dim maxValue As Integer = 200
            DataPoints = GenerateData(barsCount, maxValue)
        End Sub
    End Class

    Public Module DataGenerator

        Public Function GenerateData(ByVal pointCount As Integer, ByVal maxValue As Integer) As ObservableCollection(Of Point)
            Dim rand As Random = New Random()
            Dim bars As ObservableCollection(Of Point) = New ObservableCollection(Of Point)()
            For i As Integer = 0 To pointCount - 1
                Dim bar As Point
                Dim x As Double = rand.NextDouble() * maxValue * 2
                Dim y As Double = rand.NextDouble() * maxValue * 2
                Dim z As Double = rand.NextDouble() * maxValue
                bar = New Point(x, y, z)
                bars.Add(bar)
            Next

            Return bars
        End Function
    End Module
End Namespace
#End Region  ' #ViewModel
