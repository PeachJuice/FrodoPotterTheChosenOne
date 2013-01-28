Imports System.Threading
Public Class Form1
    Dim T1 As Thread
    Dim x, y As Integer
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Control.CheckForIllegalCrossThreadCalls = False
        T1 = New Thread(AddressOf ThreadProc1)
        T1.Start()
    End Sub

    Sub ThreadProc1()
        x = 800
        While y < Me.Bottom - 200
            PictureBox2.Location = New Point(x, y)
            y = y + 2
            Thread.Sleep(20)
            If y = Me.Bottom - 200 Then
                While y > Me.Top
                    PictureBox2.Location = New Point(x, y)
                    y = y - 1
                    Thread.Sleep(20)
                End While
            End If
        End While
    End Sub

    Private Sub Form1_FormClosed(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        T1.Abort()
    End Sub
    Private Sub Form1_KeyPress1(sender As Object, e As KeyPressEventArgs) Handles Me.KeyPress
        If Asc(e.KeyChar) = 97 Then
            PictureBox1.Left = PictureBox1.Left - 60
        ElseIf Asc(e.KeyChar) = 100 Then
            PictureBox1.Left = PictureBox1.Left + 60
        ElseIf Asc(e.KeyChar) = 119 Then
            PictureBox1.Top = PictureBox1.Top - 60
        ElseIf Asc(e.KeyChar) = 115 Then
            PictureBox1.Top = PictureBox1.Top + 60
        End If
    End Sub
End Class