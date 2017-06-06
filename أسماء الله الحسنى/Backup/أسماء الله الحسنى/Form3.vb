Imports System.IO
Public Class Form3

    Public Sub RunatStartup(ByVal PutAtStartup As Boolean, ByVal ProgramName As String)
        Dim StartupPath As String = "Software\Microsoft\Windows\CurrentVersion\Run"
        Dim MyKey As Microsoft.Win32.RegistryKey
        MyKey = Microsoft.Win32.Registry.CurrentUser.OpenSubKey(StartupPath, True)
        If PutAtStartup = True Then
            MyKey.SetValue(ProgramName, Application.ExecutablePath)
        Else
            Try
                MyKey.DeleteValue(ProgramName, False)
            Catch ex As Exception
                ex = Nothing
            End Try
        End If
    End Sub
    Public Sub CH()
        If Me.CheckBox2.Checked = True Then
            Form2.UC = True
        Else
            Form2.UC = False
        End If
    End Sub

    Private Sub Form3_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Form1.Show()
    End Sub
    Private Sub Form3_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If File.Exists(Application.StartupPath & "/smp.ini") = True Then
            Using Read As New StreamReader(Application.StartupPath & "/smp.ini")
                For i As Integer = 0 To 0
                    CheckBox1.Checked = Read.ReadLine
                Next
                For i2 As Integer = 1 To 1
                    CheckBox2.Checked = Read.ReadLine
                Next
            End Using
        Else
            Exit Sub
        End If
        If Me.CheckBox2.Checked = True Then
            Form2.UC = True
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        Using Write As New StreamWriter(Application.StartupPath & "/smp.ini")
            If CheckBox1.Checked = True Then
                Write.Write(1)
                RunatStartup(True, "asmaa")
                Write.WriteLine()
            Else
                Write.Write(0)
                RunatStartup(False, "asmaa")
                Write.WriteLine()
            End If
            If CheckBox2.Checked = True Then
                Form2.UC = True
                Write.Write(1)
            Else
                Write.Write(0)
                Form2.UC = False
            End If
            MessageBox.Show("تم الحفظ بنجاح", "Vb4Arab", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Using
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
        Form1.Show()
    End Sub

    Private Sub CheckBox2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox2.CheckedChanged
        If Me.CheckBox2.Checked = True Then
            Form2.UC = True
            CH()
        Else
            Form2.UC = False
            CH()
        End If
    End Sub
End Class