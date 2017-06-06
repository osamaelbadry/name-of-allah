Public Class Form4
    Dim m, h As Integer
    Sub Mx()
        Label1.Top = Label1.Top + 5
        If Label1.Top = m Then
            Label1.Top = h

        End If
    End Sub

    Private Sub Form4_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Form1.Show()
    End Sub
    Private Sub Form4_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        h = Label1.Top
        m = Label1.Top + 230
        Dim TimerX2 As New Timer
        TimerX2.Interval = 100
        AddHandler TimerX2.Tick, AddressOf Mx
        TimerX2.Enabled = True
    End Sub

    Private Sub LinkLabel1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs)


    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click

    End Sub
End Class