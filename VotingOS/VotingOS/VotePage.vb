﻿Imports VotingOS.MainLogin

Class VotePage


    Private Sub CandidateHeadBoyBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.CandidateHeadBoyBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DatabaseDataSet)

    End Sub

    Private Sub VotePage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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




        Dim cmd As OleDb.OleDbCommand = myConnection.CreateCommand

        myConnection.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source = Database.accdb"
        myConnection.Open()
        cmd.CommandText = "UPDATE users SET VotedHeadBoy = @update1, VotedHeadGirl = @update2 WHERE user = @update3 "
        cmd.Parameters.AddWithValue("@update1", headboyvote.text)
        cmd.Parameters.AddWithValue("@update2", headgirlvote.text)
        cmd.Parameters.AddWithValue("@update3", Username)
        MsgBox("Update Successful. You will now be signed out.")
        cmd.ExecuteNonQuery()
        cmd.Dispose()
        myConnection.Close()
        Me.Close()


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
End Class