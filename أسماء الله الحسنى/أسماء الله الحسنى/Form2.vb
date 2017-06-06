Imports System.Drawing.Drawing2D
Public Class Form2
    Dim x As Integer
    Dim xx As Integer
    Dim C1, C2 As Color
    Public TimerX As New Timer
    Friend UC As Boolean
    Sub smp()
        If Form3.CheckBox2.Checked = True Then
            UC = True

        End If
        xx = Int(Rnd() * 9)
        If UC = True Then
            Select Case xx
                Case 0
                    C1 = Color.Orange
                    C2 = Color.Yellow
                Case 1
                    C1 = Color.White
                    C2 = Color.Blue
                Case 2
                    C1 = Color.Red
                    C2 = Color.Yellow
                Case 3
                    C1 = Color.Green
                    C2 = Color.Green
                Case 4
                    C1 = Color.White
                    C2 = Color.Green
                Case 5
                    C1 = Color.White
                    C2 = Color.White
                Case 6
                    C1 = Color.Blue
                    C2 = Color.White
                Case 7
                    C1 = Color.Tomato
                    C2 = Color.Gold
                Case 8
                    C1 = Color.BlueViolet
                    C2 = Color.BlueViolet
            End Select
        Else
            C1 = Color.Green
            C2 = Color.Green
        End If
        x = x + 1
        Dim asmaa(99) As String
        asmaa(1) = "الله"
        asmaa(2) = "الرحمن"
        asmaa(3) = "الرحيم"
        asmaa(4) = "الملك"
        asmaa(5) = "القدوس"
        asmaa(6) = "السلام"
        asmaa(7) = "المؤمن"
        asmaa(8) = "المهيمن"
        asmaa(9) = "العزيز"
        asmaa(10) = "الجبار"
        asmaa(11) = "المتكبر"
        asmaa(12) = "الخالق"
        asmaa(13) = "البارئ"
        asmaa(14) = "المصور"
        asmaa(15) = "الغفار"
        asmaa(16) = "القهار"
        asmaa(17) = "الوهاب"
        asmaa(18) = "الرزاق"
        asmaa(19) = "الفتاح"
        asmaa(20) = "العليم"
        asmaa(21) = "القابض"
        asmaa(22) = "الباسط"
        asmaa(23) = "الخافض"
        asmaa(24) = "الرافع"
        asmaa(25) = "المعز"
        asmaa(26) = "المذل"
        asmaa(27) = "السميع"
        asmaa(28) = "البصير"
        asmaa(29) = "الحكم"
        asmaa(30) = "العدل"
        asmaa(31) = "اللطيف"
        asmaa(32) = "الخبير"
        asmaa(33) = "الحليم"
        asmaa(34) = "العظيم"
        asmaa(35) = "الغفور"
        asmaa(36) = "الشكور"
        asmaa(37) = "العلي"
        asmaa(38) = "الكبير"
        asmaa(39) = "الحفيظ"
        asmaa(40) = "المقيت"
        asmaa(41) = "الحسيب"
        asmaa(42) = "الجليل"
        asmaa(43) = "الكريم"
        asmaa(44) = "الرقيب"
        asmaa(45) = "المجيب"
        asmaa(46) = "الواسع"
        asmaa(47) = "الحكيم"
        asmaa(48) = "الودود"
        asmaa(49) = "المجيد"
        asmaa(50) = "الباعث"
        asmaa(51) = "الشهيد"
        asmaa(52) = "الحق"
        asmaa(53) = "الوكيل"
        asmaa(54) = "القوي"
        asmaa(55) = "المتين"
        asmaa(56) = "الولي"
        asmaa(57) = "الحميد"
        asmaa(58) = "المحصي"
        asmaa(59) = "المبدئ"
        asmaa(60) = "المعيد"
        asmaa(61) = "المحيى"
        asmaa(62) = "المميت"
        asmaa(63) = "الحي"
        asmaa(64) = "القيوم"
        asmaa(65) = "الواجد"
        asmaa(66) = "الماجد"
        asmaa(67) = "الواحد "
        asmaa(68) = "الصمد"
        asmaa(69) = "القادر"
        asmaa(70) = "المقتدر"
        asmaa(71) = "المقدم"
        asmaa(72) = "المؤخر"
        asmaa(73) = "الأول"
        asmaa(74) = "الآخر"
        asmaa(75) = "الظاهر"
        asmaa(76) = "الباطن"
        asmaa(77) = "الوالي"
        asmaa(78) = "المتعالي"
        asmaa(79) = "البر"
        asmaa(80) = "التواب"
        asmaa(81) = "المنتقم"
        asmaa(82) = "العفو"
        asmaa(83) = "الرؤوف "
        asmaa(84) = "مالك الملك"
        asmaa(85) = "ذو الجلال والإكرام"
        asmaa(86) = "المقسط"
        asmaa(87) = "الجامع"
        asmaa(88) = "الغني"
        asmaa(89) = "المغني"
        asmaa(90) = "المانع"
        asmaa(91) = "الضار"
        asmaa(92) = "النافع"
        asmaa(93) = "النور"
        asmaa(94) = "الهادي"
        asmaa(95) = "البديع"
        asmaa(96) = "الباقي"
        asmaa(97) = "الوارث"
        asmaa(98) = "الرشيد"
        asmaa(99) = "الصبور"
        If x = 99 Then x = 0
        Me.Refresh()
        Form1.Gr = Form1.Gr.FromHwnd(Me.Handle)
        Dim LGBx As New LinearGradientBrush(New Point(10), New Point(20), C1, C2)
        Form1.Gr.DrawString(asmaa(x), New Font("Andalus", 20), LGBx, Windows.Forms.Cursor.Position.X - Me.Left - 30, Windows.Forms.Cursor.Position.Y - Me.Top - 30)
    End Sub
    Private Sub Form2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        MyBase.TransparencyKey = Me.BackColor
        Me.FormBorderStyle = Windows.Forms.FormBorderStyle.None
        Me.Height = My.Computer.Screen.Bounds.Height
        Me.Width = My.Computer.Screen.Bounds.Width
        Me.ShowInTaskbar = False
        Me.TopMost = True
        Form3.Show()
        Form3.Hide()
        TimerX.Interval = 1000
        AddHandler TimerX.Tick, AddressOf smp
        TimerX.Enabled = True
    End Sub
End Class