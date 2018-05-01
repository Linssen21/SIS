Imports System.Drawing.Imaging
Module ModFunction



    Public Sub DisplayForm(frm As Form, pnl As Panel)
        frm.Width = pnl.Width
        frm.Height = pnl.Height
        frm.TopLevel = False
        frm.Parent = pnl
        frm.Show()
        frm.BringToFront()
    End Sub


    Public EditCourse As Boolean = False
    Public EditStudent As Boolean = False
    Public EditAdmin As Boolean = False
    Public Sub loadPic(ByVal s As String, ByVal fn As String)

        Dim myBitmap As Bitmap
        Dim myImageCodecInfo As ImageCodecInfo
        Dim myEncoder As Encoder
        Dim myEncoderParameter As EncoderParameter
        Dim myEncoderParameters As EncoderParameters

        myBitmap = New Bitmap(s)

        myImageCodecInfo = GetEncoderInfo(ImageFormat.Jpeg)
        myEncoder = Encoder.Quality
        myEncoderParameters = New EncoderParameters(1)
        myEncoderParameter = New EncoderParameter(myEncoder, CType(75L, Int32))
        myEncoderParameters.Param(0) = myEncoderParameter
        myBitmap.Save(fn, myImageCodecInfo, myEncoderParameters)
    End Sub


    Private Function GetEncoderInfo(ByVal format As ImageFormat) As ImageCodecInfo
        Dim j As Integer
        Dim encoders() As ImageCodecInfo
        encoders = ImageCodecInfo.GetImageEncoders()
        j = 0
        While j < encoders.Length
            If encoders(j).FormatID = format.Guid Then
                Return encoders(j)
            End If
            j += 1
        End While
        Return Nothing
    End Function

    Public UserId As String
    Public userName As String
    Public IDNumber As String
    Public AdID As String
    Public cID As String
    Public IDn As String
End Module
