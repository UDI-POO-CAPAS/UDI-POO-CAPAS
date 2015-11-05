Public Class Base
    Function AreaCuadrado(ByVal b As Integer) As Integer
        Dim area As Integer
        area = Math.Pow(b, 2)
        Return area
    End Function

    Function AreaRectangulo(ByVal b As Integer, ByVal h As Integer) As Integer
        Dim area As Integer
        area = b * h
        Return area

    End Function

    Function AreaTriangulo(ByVal b As Double, ByVal h As Double) As Double
        Dim area As Double
        area = (b * h) / 2
        Return area

    End Function

    Function AreaCirculo(ByVal r As Double) As Double
        Dim area As Double
        area = Math.PI * Math.Pow(r, 2)
        Return area

    End Function



End Class
