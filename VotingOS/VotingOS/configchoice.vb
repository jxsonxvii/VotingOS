﻿Public Class configchoice
    ' This aspect has been specifically created in order for the admin to gain access to configure the voters that wish to vote for those running for a position.
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Hide()
        addadminlogin.Show()
    End Sub

    ' If wanting to exit the entire system. 
    Private Sub Button4_Click(sender As Object, e As EventArgs)
        MsgBox("Are you sure you want to quit?", MsgBoxStyle.YesNo)
        If vbYes Then
            Close()
        ElseIf vbNo Then
            Me.Close()
        End If
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs)
        Me.Hide()
        PollsViewer.Show()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Dim result As Integer = MsgBox("Is your level of access: ADDITIONAL ADMINISTRATOR?", MsgBoxStyle.YesNo)
        If result = DialogResult.Yes Then
            Me.Hide()
            addadminlogin.Show()
        Else
            Me.Hide()
            sysadminlogin.Show()
        End If
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs)
        Close()
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Me.Hide()
        headlogin.Show()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Dim result As Integer = MsgBox("By clicking back here, you will be signed out of VotingOS. Do you wish to proceed?", MsgBoxStyle.YesNo)
        If result = DialogResult.Yes Then
            Me.Hide()
            authorisedlogin.TextBox1.Clear()
            authorisedlogin.Show()
        End If
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        Me.WindowState = System.Windows.Forms.FormWindowState.Minimized

    End Sub

    Private Sub configchoice_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub PictureBox2_Click_1(sender As Object, e As EventArgs) Handles PictureBox2.Click
        closeform()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        Me.Hide()
        deleteforms.Show()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
        sysadminlogin.Show()
    End Sub

    Private Sub Button4_Click_1(sender As Object, e As EventArgs) Handles Button4.Click
        Me.Hide()
        addadminlogin.Show()
    End Sub

    Private Sub Button5_Click_1(sender As Object, e As EventArgs) Handles Button5.Click
        Me.Hide()
        addadminlogin.Show()

    End Sub
End Class