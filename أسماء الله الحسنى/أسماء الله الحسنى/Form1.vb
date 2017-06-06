Imports System.Drawing.Drawing2D
Public Class Form1
    Friend Gr As Graphics
    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub PictureBox1_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles PictureBox1.Paint
        Gr = e.Graphics
        Dim LGB As New LinearGradientBrush(New Point(10), New Point(20), Color.Orange, Color.OrangeRed)
        Gr.DrawString("رمضان كريم", New Font("Andalus", 50), LGB, 10, 10)
    End Sub
    Sub Stopx()
        Form2.TimerX.Enabled = False
        Me.Button1.Enabled = False
        Me.Show()
        Form2.Close()
    End Sub
    Sub Go()
        Form2.Show()
        Form2.TimerX.Enabled = True
        Me.Hide()
    End Sub
    Sub OptionX()
        Form3.Show()
    End Sub
    Sub ExitX()
        If MessageBox.Show("هل تريد الخروج حقا ؟", "تأكيد الخروج", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            Application.Exit()
        Else
            Exit Sub
        End If
    End Sub
    Sub About()
        Me.Hide()
        Form4.Show()
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim ContextMenuStrip As New ContextMenuStrip
        ContextMenuStrip.Items.Add("تشغيل")
        AddHandler ContextMenuStrip.Items(0).Click, AddressOf Go
        ContextMenuStrip.Items.Add("ايقاف")
        AddHandler ContextMenuStrip.Items(1).Click, AddressOf Stopx
        ContextMenuStrip.Items.Add("خصائص")
        AddHandler ContextMenuStrip.Items(2).Click, AddressOf OptionX
        ContextMenuStrip.Items.Add("حول البرنامج ...")
        AddHandler ContextMenuStrip.Items(3).Click, AddressOf About
        ContextMenuStrip.Items.Add("خروج")
        AddHandler ContextMenuStrip.Items(4).Click, AddressOf ExitX
        Dim NotifyIconX As New NotifyIcon
        NotifyIconX.Icon = Me.Icon
        NotifyIconX.ContextMenuStrip = ContextMenuStrip
        NotifyIconX.Visible = True
        Me.Hide()
        Form2.Show()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Hide()
        Form3.Show()
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        ExitX()
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Form4.Show()
        Me.Hide()
    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click

    End Sub
End Class
