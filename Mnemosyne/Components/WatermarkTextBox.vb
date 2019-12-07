Public Class WatermarkTextBox
    Inherits TextBox

    Private _WatermarkEnabled As Boolean = False
    Private _WatermarkColor As Color = Color.Gray
    Private _WatermarkFont As Font = Nothing
    Private _WatermarkText As String = ""

    Public Property WatermarkEnabled As Boolean
        Get
            Return _WatermarkEnabled
        End Get
        Set(value As Boolean)
            _WatermarkEnabled = value
            Invalidate()
        End Set
    End Property

    Public Property WaterMarkColor As Color
        Get
            Return _WatermarkColor
        End Get
        Set(value As Color)
            _WatermarkColor = value
            Invalidate()
        End Set
    End Property

    Public Property WatermarkFont As Font
        Get
            Return _WatermarkFont
        End Get
        Set(value As Font)
            _WatermarkFont = value
            Invalidate()
        End Set
    End Property

    Public Property WatermarkText As String
        Get
            Return _WatermarkText
        End Get
        Set(value As String)
            _WatermarkText = value
            Invalidate()
        End Set
    End Property

    Public Sub New()
        AddHandler TextChanged, New EventHandler(AddressOf WatermarkToggle)
        AddHandler LostFocus, New EventHandler(AddressOf WatermarkToggle)
        AddHandler FontChanged, New EventHandler(AddressOf WatermarkFontChanged)
    End Sub

    Private Sub WatermarkToggle(sender As Object, e As EventArgs)
        If Text.Length > 0 Then
            WatermarkEnabled = False
            SetStyle(ControlStyles.UserPaint, False)
            Font = IIf(WatermarkFont IsNot Nothing, New Font(WatermarkFont.FontFamily, WatermarkFont.Size, WatermarkFont.Style, WatermarkFont.Unit), Font)
            Refresh()
        Else
            WatermarkFont = New Font(Font.FontFamily, Font.Size, Font.Style, Font.Unit)
            SetStyle(ControlStyles.UserPaint, True)
            WatermarkEnabled = True
            Refresh()
        End If
    End Sub

    Private Sub WatermarkFontChanged(sender As Object, e As EventArgs)
        WatermarkFont = IIf(WatermarkEnabled, New Font(Font.FontFamily, Font.Size, Font.Style, Font.Unit), WatermarkFont)
    End Sub

    Protected Overrides Sub OnCreateControl()
        MyBase.OnCreateControl()
        WatermarkToggle(Nothing, Nothing)
    End Sub

    Protected Overrides Sub OnPaint(e As PaintEventArgs)
        Dim content As String = IIf(WatermarkEnabled, WatermarkText, Text)
        Dim contentFont As New Font(Font.FontFamily, Font.Size, Font.Style, Font.Unit)
        Dim contentBrush As New SolidBrush(WaterMarkColor)
        Dim contentStringSize As SizeF = e.Graphics.MeasureString(content, contentFont)

        Dim x As Single = -30
        Dim y As Single = -5
        Dim w As Single = Me.Parent.Width
        Dim h As Single = Me.Parent.Height
        Dim xOffset As Single = (w - contentStringSize.Width) / 2
        Dim yOffset As Single = (h - contentStringSize.Height) / 2
        Dim contentRectangle As New Rectangle(x + xOffset, y + yOffset, contentStringSize.Width, contentStringSize.Height)

        Dim contentStringFormat As New StringFormat()
        contentStringFormat.FormatFlags = StringFormatFlags.NoWrap
        contentStringFormat.Alignment = StringAlignment.Center
        contentStringFormat.LineAlignment = StringAlignment.Center

        e.Graphics.DrawString(content, contentFont, contentBrush, contentRectangle, contentStringFormat)
        MyBase.OnPaint(e)
    End Sub

End Class