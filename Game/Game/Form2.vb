Option Explicit On
Imports System.Threading
Imports System.Drawing
Public Class Form2

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ResumeGame1.Visible = False
        Quit1.Visible = False
        MMenu1.Visible = False
        Controls1.Visible = False
        Restart1.Visible = False
    End Sub

    Private Sub Restart_MouseEnter(sender As Object, e As EventArgs) Handles Restart.MouseEnter
        Restart.Visible = False
        Restart1.Visible = True
    End Sub
    Private Sub Restart1_MouseLeave(sender As Object, e As EventArgs) Handles Restart1.MouseLeave
        Restart1.Visible = False
        Restart.Visible = True
    End Sub
    Private Sub MMenu_MouseEnter(sender As Object, e As EventArgs) Handles MMenu.MouseEnter
        MMenu.Visible = False
        MMenu1.Visible = True
    End Sub
    Private Sub MMenu1_MouseLeave(sender As Object, e As EventArgs) Handles MMenu1.MouseLeave
        MMenu1.Visible = False
        MMenu.Visible = True
    End Sub
    Private Sub MControls_MouseEnter(sender As Object, e As EventArgs) Handles MControls.MouseEnter
        MControls.Visible = False
        Controls1.Visible = True
    End Sub
    Private Sub Conrtols1_MouseLeave(sender As Object, e As EventArgs) Handles Controls1.MouseLeave
        Controls1.Visible = False
        MControls.Visible = True
    End Sub
    Private Sub Quit_MouseEnter(sender As Object, e As EventArgs) Handles Quit.MouseEnter
        Quit.Visible = False
        Quit1.Visible = True
    End Sub
    Private Sub Quit1_MouseLeave(sender As Object, e As EventArgs) Handles Quit1.MouseLeave
        Quit1.Visible = False
        Quit.Visible = True
    End Sub
    Private Sub ResumeGame_MouseEnter(sender As Object, e As EventArgs) Handles ResumeGame.MouseEnter
        ResumeGame.Visible = False
        ResumeGame1.Visible = True
    End Sub
    Private Sub ResumeGame1_MouseLeave(sender As Object, e As EventArgs) Handles ResumeGame1.MouseLeave
        ResumeGame1.Visible = False
        ResumeGame.Visible = True
    End Sub

    Private Sub ResumeGame1_Click(sender As Object, e As EventArgs) Handles ResumeGame1.Click
        Me.Close()
        Form1.MenuOpen = False
    End Sub

    Private Sub Restart1_Click(sender As Object, e As EventArgs) Handles Restart1.Click
        Me.Close()
        Application.Restart()
    End Sub
End Class