﻿Imports VotingOS.MainLogin
Imports System.Data.OleDb

Class VotePage


    Private Sub CandidateHeadBoyBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.CandidateHeadBoyBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DatabaseDataSet)

    End Sub

    Private Sub VotePage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        headboyvote.Clear()
        headgirlvote.Clear()
        'TODO: This line of code loads data into the 'DatabaseDataSet.users' table. You can move, or remove it, as needed.
        Me.UsersTableAdapter.Fill(Me.DatabaseDataSet.users)
        'TODO: This line of code loads data into the 'DatabaseDataSet.CandidatesHeadGirl' table. You can move, or remove it, as needed.
        Me.CandidatesHeadGirlTableAdapter.Fill(Me.DatabaseDataSet.CandidatesHeadGirl)
        'TODO: This line of code loads data into the 'DatabaseDataSet.CandidateHeadBoy' table. You can move, or remove it, as needed.
        Me.CandidateHeadBoyTableAdapter.Fill(Me.DatabaseDataSet.CandidateHeadBoy)
        TextBox1.Text = ("Name: " & MainLogin.MyName & " " & MainLogin.MySurname)
        Dim SQL As String = "SELECT * FROM Database"



    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            Dim cmd As OleDb.OleDbCommand = myConnection.CreateCommand
            myConnection.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source = Database.accdb"
            myConnection.Open()
            cmd.CommandText = "UPDATE users SET VotedHeadBoy = @update1, VotedHeadGirl = @update2, Voted = True WHERE user = @update3 "
            cmd.Parameters.AddWithValue("@update1", headboyvote.Text)
            cmd.Parameters.AddWithValue("@update2", headgirlvote.Text)
            cmd.Parameters.AddWithValue("@update3", Username)

            MsgBox("You have successfully casted your vote. You will now be signed out. Thank you and goodbye.")
            cmd.ExecuteNonQuery()
            cmd.Dispose()
            myConnection.Close()
            Me.Close()
            Application.Exit()
        Catch ex As Exception
            MsgBox("Your vote has not been succesfully saved. Please try again later")
        End Try
    End Sub


    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub



    Private Sub headgirlvote_KeyPress(sender As Object, e As KeyPressEventArgs) Handles headgirlvote.KeyPress
        If Asc(e.KeyChar) <> 13 AndAlso Asc(e.KeyChar) <> 8 AndAlso Not IsNumeric(e.KeyChar) Then
            MessageBox.Show("Please enter numbers only. Make sure the value you have entered is a candidate running for this position else your vote will not be counted.")
            e.Handled = True
        End If

    End Sub


    Private Sub headboyvote_KeyPress(sender As Object, e As KeyPressEventArgs) Handles headboyvote.KeyPress
        If Asc(e.KeyChar) <> 13 AndAlso Asc(e.KeyChar) <> 8 AndAlso Not IsNumeric(e.KeyChar) Then
            MessageBox.Show("Please enter numbers only. Make sure the value you have entered is a candidate running for this position else your vote will not be counted.")
            e.Handled = True
        End If
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Dim result As Integer = MsgBox("By clicking back here, your vote will not be saved. Do you wish to proceed?", MsgBoxStyle.YesNo)
        If result = DialogResult.Yes Then
            Me.Hide()
            votingchoice.Show()
        End If
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        Me.WindowState = System.Windows.Forms.FormWindowState.Minimized

    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        closeform()
    End Sub
End Class