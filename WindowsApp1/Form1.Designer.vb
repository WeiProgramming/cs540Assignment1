﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.greetingLabel = New System.Windows.Forms.Label()
        Me.exitButton = New System.Windows.Forms.Button()
        Me.belarusPictureBox = New System.Windows.Forms.PictureBox()
        Me.usaPictureBox = New System.Windows.Forms.PictureBox()
        CType(Me.belarusPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.usaPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'greetingLabel
        '
        Me.greetingLabel.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.greetingLabel.Font = New System.Drawing.Font("Lucida Sans Unicode", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.greetingLabel.Location = New System.Drawing.Point(172, 50)
        Me.greetingLabel.Name = "greetingLabel"
        Me.greetingLabel.Size = New System.Drawing.Size(341, 88)
        Me.greetingLabel.TabIndex = 1
        Me.greetingLabel.Text = "Good Day!"
        Me.greetingLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'exitButton
        '
        Me.exitButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.exitButton.Font = New System.Drawing.Font("Lucida Sans Unicode", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.exitButton.Location = New System.Drawing.Point(517, 285)
        Me.exitButton.Name = "exitButton"
        Me.exitButton.Size = New System.Drawing.Size(166, 73)
        Me.exitButton.TabIndex = 2
        Me.exitButton.Text = "Exit"
        Me.exitButton.UseVisualStyleBackColor = False
        '
        'belarusPictureBox
        '
        Me.belarusPictureBox.Image = Global.WindowsApp1.My.Resources.Resources.belarus_flag
        Me.belarusPictureBox.Location = New System.Drawing.Point(361, 175)
        Me.belarusPictureBox.Name = "belarusPictureBox"
        Me.belarusPictureBox.Size = New System.Drawing.Size(152, 69)
        Me.belarusPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.belarusPictureBox.TabIndex = 4
        Me.belarusPictureBox.TabStop = False
        '
        'usaPictureBox
        '
        Me.usaPictureBox.Image = Global.WindowsApp1.My.Resources.Resources._1280px_Flag_of_the_United_States_svg
        Me.usaPictureBox.Location = New System.Drawing.Point(179, 175)
        Me.usaPictureBox.Name = "usaPictureBox"
        Me.usaPictureBox.Size = New System.Drawing.Size(146, 69)
        Me.usaPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.usaPictureBox.TabIndex = 3
        Me.usaPictureBox.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(695, 370)
        Me.Controls.Add(Me.belarusPictureBox)
        Me.Controls.Add(Me.usaPictureBox)
        Me.Controls.Add(Me.exitButton)
        Me.Controls.Add(Me.greetingLabel)
        Me.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Name = "Form1"
        Me.Text = "CS 540 Program 1"
        CType(Me.belarusPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.usaPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents greetingLabel As Label
    Friend WithEvents exitButton As Button
    Friend WithEvents usaPictureBox As PictureBox
    Friend WithEvents belarusPictureBox As PictureBox
End Class
