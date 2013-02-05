<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form2))
        Me.Restart = New System.Windows.Forms.Button()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.Restart1 = New System.Windows.Forms.Button()
        Me.Controls1 = New System.Windows.Forms.Button()
        Me.MControls = New System.Windows.Forms.Button()
        Me.ResumeGame1 = New System.Windows.Forms.Button()
        Me.ResumeGame = New System.Windows.Forms.Button()
        Me.Quit1 = New System.Windows.Forms.Button()
        Me.Quit = New System.Windows.Forms.Button()
        Me.MMenu1 = New System.Windows.Forms.Button()
        Me.MMenu = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Restart
        '
        Me.Restart.BackgroundImage = Global.Game.My.Resources.Resources.Restart
        Me.Restart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Restart.Location = New System.Drawing.Point(306, 178)
        Me.Restart.Name = "Restart"
        Me.Restart.Size = New System.Drawing.Size(254, 77)
        Me.Restart.TabIndex = 10
        Me.Restart.UseVisualStyleBackColor = True
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "Restart.png")
        '
        'Restart1
        '
        Me.Restart1.BackgroundImage = Global.Game.My.Resources.Resources.Restart_edited
        Me.Restart1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Restart1.Location = New System.Drawing.Point(306, 178)
        Me.Restart1.Name = "Restart1"
        Me.Restart1.Size = New System.Drawing.Size(254, 77)
        Me.Restart1.TabIndex = 11
        Me.Restart1.UseVisualStyleBackColor = True
        '
        'Controls1
        '
        Me.Controls1.BackgroundImage = Global.Game.My.Resources.Resources.Controls_edited
        Me.Controls1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Controls1.Location = New System.Drawing.Point(306, 95)
        Me.Controls1.Name = "Controls1"
        Me.Controls1.Size = New System.Drawing.Size(254, 77)
        Me.Controls1.TabIndex = 13
        Me.Controls1.UseVisualStyleBackColor = True
        '
        'MControls
        '
        Me.MControls.BackgroundImage = Global.Game.My.Resources.Resources.Controls
        Me.MControls.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.MControls.Location = New System.Drawing.Point(306, 95)
        Me.MControls.Name = "MControls"
        Me.MControls.Size = New System.Drawing.Size(254, 77)
        Me.MControls.TabIndex = 12
        Me.MControls.UseVisualStyleBackColor = True
        '
        'ResumeGame1
        '
        Me.ResumeGame1.BackgroundImage = Global.Game.My.Resources.Resources.Resume_Edited
        Me.ResumeGame1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ResumeGame1.Location = New System.Drawing.Point(306, 12)
        Me.ResumeGame1.Name = "ResumeGame1"
        Me.ResumeGame1.Size = New System.Drawing.Size(254, 77)
        Me.ResumeGame1.TabIndex = 15
        Me.ResumeGame1.UseVisualStyleBackColor = True
        '
        'ResumeGame
        '
        Me.ResumeGame.BackgroundImage = Global.Game.My.Resources.Resources._Resume
        Me.ResumeGame.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ResumeGame.Location = New System.Drawing.Point(306, 12)
        Me.ResumeGame.Name = "ResumeGame"
        Me.ResumeGame.Size = New System.Drawing.Size(254, 77)
        Me.ResumeGame.TabIndex = 14
        Me.ResumeGame.UseVisualStyleBackColor = True
        '
        'Quit1
        '
        Me.Quit1.BackgroundImage = Global.Game.My.Resources.Resources.quit_edited
        Me.Quit1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Quit1.Location = New System.Drawing.Point(306, 344)
        Me.Quit1.Name = "Quit1"
        Me.Quit1.Size = New System.Drawing.Size(254, 77)
        Me.Quit1.TabIndex = 17
        Me.Quit1.UseVisualStyleBackColor = True
        '
        'Quit
        '
        Me.Quit.BackgroundImage = Global.Game.My.Resources.Resources.Quit
        Me.Quit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Quit.Location = New System.Drawing.Point(306, 344)
        Me.Quit.Name = "Quit"
        Me.Quit.Size = New System.Drawing.Size(254, 77)
        Me.Quit.TabIndex = 16
        Me.Quit.UseVisualStyleBackColor = True
        '
        'MMenu1
        '
        Me.MMenu1.BackgroundImage = Global.Game.My.Resources.Resources.Back_to_main_menu__edited
        Me.MMenu1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.MMenu1.Location = New System.Drawing.Point(306, 261)
        Me.MMenu1.Name = "MMenu1"
        Me.MMenu1.Size = New System.Drawing.Size(254, 77)
        Me.MMenu1.TabIndex = 19
        Me.MMenu1.UseVisualStyleBackColor = True
        '
        'MMenu
        '
        Me.MMenu.BackgroundImage = Global.Game.My.Resources.Resources.Back_to_main_menu
        Me.MMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.MMenu.Location = New System.Drawing.Point(306, 261)
        Me.MMenu.Name = "MMenu"
        Me.MMenu.Size = New System.Drawing.Size(254, 77)
        Me.MMenu.TabIndex = 18
        Me.MMenu.UseVisualStyleBackColor = True
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Game.My.Resources.Resources.lotr_ring_by_hrnclk777_d40ev97
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(827, 514)
        Me.Controls.Add(Me.MMenu1)
        Me.Controls.Add(Me.MMenu)
        Me.Controls.Add(Me.Quit1)
        Me.Controls.Add(Me.Quit)
        Me.Controls.Add(Me.ResumeGame1)
        Me.Controls.Add(Me.ResumeGame)
        Me.Controls.Add(Me.Controls1)
        Me.Controls.Add(Me.MControls)
        Me.Controls.Add(Me.Restart1)
        Me.Controls.Add(Me.Restart)
        Me.Name = "Form2"
        Me.Text = "Form2"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Restart As System.Windows.Forms.Button
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents Restart1 As System.Windows.Forms.Button
    Friend WithEvents Controls1 As System.Windows.Forms.Button
    Friend WithEvents MControls As System.Windows.Forms.Button
    Friend WithEvents ResumeGame1 As System.Windows.Forms.Button
    Friend WithEvents ResumeGame As System.Windows.Forms.Button
    Friend WithEvents Quit1 As System.Windows.Forms.Button
    Friend WithEvents Quit As System.Windows.Forms.Button
    Friend WithEvents MMenu1 As System.Windows.Forms.Button
    Friend WithEvents MMenu As System.Windows.Forms.Button
End Class
