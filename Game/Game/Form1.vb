Option Explicit On
Imports System.Threading
Imports System.Drawing
Public Class Form1
    Dim T1 As Thread
    Dim x, y As Integer
    Dim BoltExecuted As Integer
    Dim enemyHit As Integer
    Dim mana As Integer
    Dim manaSub As Integer
    Dim hp As Integer
    Dim frameRate As Long
    Const FPS As Integer = 60
    Const heroSpeed As Integer = 450
    Const arrowSpeed As Integer = 900
    Const villianSpeed As Integer = 300
    Const frostBoltSpeed As Integer = 400
    Dim isWPressed As Boolean
    Dim isSPressed As Boolean
    Dim isAPressed As Boolean
    Dim isDPressed As Boolean
    Dim isRPressed As Boolean
    Dim villianGoingUp As Boolean
    Public MenuOpen As Boolean
    '(0) - W (1) - S (2) - A (3)-D
    Dim keyState() As Boolean = New Boolean() {isWPressed, isSPressed, isAPressed, isDPressed, isRPressed}
    Private Sub Form1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Me.KeyPress
        If Asc(e.KeyChar) = Keys.Escape Then
            IngameMenu()
            MenuOpen = True
        End If
    End Sub
    Private Sub Form1_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.W Then
            isWPressed = True
        ElseIf e.KeyCode = Keys.S Then
            isSPressed = True
        ElseIf e.KeyCode = Keys.A Then
            isAPressed = True
        ElseIf e.KeyCode = Keys.D Then
            isDPressed = True
        ElseIf e.KeyCode = Keys.R Then
            isRPressed = True
        End If
    End Sub
    Private Sub Form1_KeyUp(sender As Object, e As KeyEventArgs) Handles Me.KeyUp
        If e.KeyCode = Keys.W Then
            isWPressed = False
        ElseIf e.KeyCode = Keys.S Then
            isSPressed = False
        ElseIf e.KeyCode = Keys.A Then
            isAPressed = False
        ElseIf e.KeyCode = Keys.D Then
            isDPressed = False
        ElseIf e.KeyCode = Keys.R Then
            isRPressed = False
        End If
    End Sub
    Sub IngameMenu()
        Form2.Show()
    End Sub
    Sub MoveMyHero()
        If isWPressed = True Then
            MoveHeroUp()
        ElseIf isSPressed Then
            MoveHeroDown()
        ElseIf isAPressed Then
            MoveHeroLeft()
        ElseIf isDPressed Then
            MoveHeroRight()
        ElseIf isRPressed Then
            ShootArrow()
        End If
    End Sub

    Sub MoveHeroUp()
        If PictureHero.Top - heroSpeed / FPS > ONN.Bottom Then
            PictureHero.Top = PictureHero.Top - heroSpeed / FPS
        End If
    End Sub
    Sub MoveHeroDown()
        If PictureHero.Bottom + heroSpeed / FPS < Me.Bottom Then
            PictureHero.Top = PictureHero.Top + heroSpeed / FPS
        End If
    End Sub
    Sub MoveHeroLeft()
        PictureHero.Left = PictureHero.Left - heroSpeed / FPS
    End Sub
    Sub MoveHeroRight()
        PictureHero.Left = PictureHero.Left + heroSpeed / FPS
    End Sub
    Sub ShootArrow()
        If FireArrow.Visible = False Then
            FireArrow.Visible = True
            FireArrow.Left = PictureHero.Left
            FireArrow.Top = PictureHero.Top + 30
        End If
    End Sub
    Sub MoveArrow()
        If FireArrow.Right > PictureVillian.Left And FireArrow.Top > PictureVillian.Top And FireArrow.Bottom < PictureVillian.Bottom Or FireArrow.Right > Me.Width Then
            FireArrow.Visible = False
        Else
            If manaSub = 0 Then
                mana -= 1
            End If
            manaSub += 1
            FireArrow.Left = FireArrow.Left + arrowSpeed / FPS

        End If
    End Sub
    Sub ShootBolt()
        FrostBolt.Visible = True
        FrostBolt.Left = PictureVillian.Left + 20
        FrostBolt.Top = PictureVillian.Top + 30
    End Sub
    Sub MoveBolt()
        If FrostBolt.Left < PictureHero.Right And FrostBolt.Top > PictureHero.Top And FrostBolt.Bottom < PictureHero.Bottom Or FrostBolt.Left < 0 Then
            FrostBolt.Visible = False
            BoltExecuted = 0
        Else
            FrostBolt.Left = FrostBolt.Left - frostBoltSpeed / FPS
            If FrostBolt.Top > PictureHero.Top And FrostBolt.Bottom < PictureHero.Bottom Then

            ElseIf FrostBolt.Top > PictureHero.Top Then
                FrostBolt.Top = FrostBolt.Top - 5
            ElseIf FrostBolt.Top < PictureHero.Top Then
                FrostBolt.Top = FrostBolt.Top + 5
            End If

        End If
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        manaSub = 0
        FF.Visible = True
        FireArrow.Visible = False
        FrostBolt.Visible = False
        BoltExecuted = 0
        Me.DoubleBuffered = True
        Me.Width = My.Computer.Screen.WorkingArea.Width
        Me.Height = Screen.PrimaryScreen.Bounds.Height
        FF.Visible = True
        enemyHit = 10
        mana = 4
        hp = 4
        Control.CheckForIllegalCrossThreadCalls = False
        T1 = New Thread(AddressOf ThreadProc1)
        T1.Start()
    End Sub
    Sub ThreadProc1()
        While True
            If MenuOpen = False Then
                MainGameLoop()
                Thread.Sleep(1000 / FPS)
            End If
        End While
    End Sub
    Sub MoveVillian()
        If villianGoingUp = False Then
            PictureVillian.Top = PictureVillian.Top + villianSpeed / FPS
            If PictureVillian.Bottom + villianSpeed / FPS > Me.Bottom Then
                villianGoingUp = True
                'If mana = 4 Then
                '    FF.Visible = False
                '    FTH.Visible = True
                '    FTW.Visible = False
                '    FO.Visible = False
                '    FN.Visible = False
                'ElseIf mana = 3 Then
                '    FF.Visible = False
                '    FTH.Visible = False
                '    FTW.Visible = True
                '    FO.Visible = False
                '    FN.Visible = False
                'ElseIf mana = 2 Then
                '    FF.Visible = False
                '    FTH.Visible = False
                '    FTW.Visible = False
                '    FO.Visible = True
                '    FN.Visible = False
                'ElseIf mana = 1 Then
                '    FF.Visible = False
                '    FTH.Visible = False
                '    FTW.Visible = False
                '    FO.Visible = False
                '    FN.Visible = True
                'End If
            End If
        End If
        If villianGoingUp = True Then
            PictureVillian.Top = PictureVillian.Top - villianSpeed / FPS
            If PictureVillian.Top - villianSpeed / FPS < Me.Top Then
                villianGoingUp = False
            End If
        End If
        If (PictureVillian.Top - 30 > PictureHero.Top And villianGoingUp = True Or PictureVillian.Top + 30 < PictureHero.Top And villianGoingUp = False) And BoltExecuted = 0 Then
            ShootBolt()
            BoltExecuted += 1
        End If
    End Sub
    Sub MainGameLoop()
        MoveMyHero()
        MoveArrow()
        MoveVillian()
        MoveBolt()
    End Sub
    Private Sub Form1_FormClosed(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        T1.Abort()
    End Sub





End Class