Imports System.Threading
Imports System.Drawing
Public Class Form1
    Dim T1 As Thread
    Dim x, y As Integer
    Dim enemyHit As Integer
    Dim mana As Integer
    Dim hp As Integer
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.DoubleBuffered = True
        FF.Visible = True
        enemyHit = 10
        mana = 4
        hp = 4
        Control.CheckForIllegalCrossThreadCalls = False
        T1 = New Thread(AddressOf ThreadProc1)
        T1.Start()
    End Sub
    Sub ThreadProc1()
        x = 1000
        While y < Me.Bottom

            PictureBox2.Location = New Point(x, y)
            y = y + 2
            Thread.Sleep(20)
            If y = Me.Bottom Then
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
    Private Sub Form1_KeyPress1(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles Me.KeyPress
        If Asc(e.KeyChar) = 97 Then
            PictureBox1.Left = PictureBox1.Left - 30
            If Timer2.Enabled = False Then
                PictureBox4.Left = PictureBox4.Left - 30
            End If
        ElseIf Asc(e.KeyChar) = 100 Then
            PictureBox1.Left = PictureBox1.Left + 30
            If Timer2.Enabled = False Then
                PictureBox4.Left = PictureBox4.Left + 30
            End If
        ElseIf Asc(e.KeyChar) = 119 Then
            If PictureBox1.Top - 30 > Me.Top Then
                PictureBox1.Top = PictureBox1.Top - 30
                If Timer2.Enabled = False Then
                    PictureBox4.Top = PictureBox4.Top - 30
                End If
            End If
        ElseIf Asc(e.KeyChar) = 115 Then
            If PictureBox1.Bottom + 30 < Me.Bottom Then
                PictureBox1.Top = PictureBox1.Top + 30
                If Timer2.Enabled = False Then
                    PictureBox4.Top = PictureBox4.Top + 30
                End If
            End If
        ElseIf Asc(e.KeyChar) = 114 Then
            If mana > 0 Then
                Timer2.Enabled = True
                If mana = 4 Then
                    FF.Visible = False
                    FTH.Visible = True
                    FTW.Visible = False
                    FO.Visible = False
                    FN.Visible = False
                ElseIf mana = 3 Then
                    FF.Visible = False
                    FTH.Visible = False
                    FTW.Visible = True
                    FO.Visible = False
                    FN.Visible = False
                ElseIf mana = 2 Then
                    FF.Visible = False
                    FTH.Visible = False
                    FTW.Visible = False
                    FO.Visible = True
                    FN.Visible = False
                ElseIf mana = 1 Then
                    FF.Visible = False
                    FTH.Visible = False
                    FTW.Visible = False
                    FO.Visible = False
                    FN.Visible = True
                End If
            End If
        End If
    End Sub
    Private Sub Timer1_Tick(ByVal sender As Object, ByVal e As EventArgs) Handles Timer1.Tick
        PictureBox1.Left = PictureBox1.Left + 5
    End Sub

    Private Sub Timer2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer2.Tick
        PictureBox4.Left += 20
        PictureBox4.Left += 20
        PictureBox4.Left += 20
        Thread.Sleep(20)
        If PictureBox4.Left > 1360 Or PictureBox4.Right > PictureBox2.Left And PictureBox4.Top >= PictureBox2.Top And PictureBox4.Bottom <= PictureBox2.Bottom Then
            If PictureBox4.Right > PictureBox2.Left And PictureBox4.Top >= PictureBox2.Top And PictureBox4.Bottom <= PictureBox2.Bottom Then
                enemyHit -= 1
            End If
            Timer2.Enabled = False
            PictureBox4.Left = PictureBox1.Left
            PictureBox4.Top = PictureBox1.Top + 40
            mana -= 1
        End If
    End Sub
End Class