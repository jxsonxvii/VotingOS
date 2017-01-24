﻿Imports System.Data.OleDb
Public Class authorisedlogin
    Dim provider As String
    Dim dataFile As String
    Dim connString As String
    Dim myConnection As OleDbConnection = New OleDbConnection

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim cmd As OleDb.OleDbCommand = myConnection.CreateCommand

        myConnection.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source = Database.accdb"
        myConnection.Open()
        cmd = New OleDbCommand("SELECT * FROM [authorisedmembers] WHERE [password] = '" & TextBox1.Text & "'", myConnection)
        Dim dr As OleDbDataReader = cmd.ExecuteReader

        ' the following variable is hold true if user is found, and false if user is not found
        Dim userFound As Boolean = False
        ' the following variables will hold the user first and last name if found.
        Dim FirstName As String = ""
        Dim LastName As String = ""

        'if found:
        While dr.Read
            userFound = True
            FirstName = dr("FirstName").ToString
            LastName = dr("LastName").ToString
        End While

        'checking the result
        If String.IsNullOrEmpty(TextBox1.Text) Then
            MsgBox("Please enter your credentials")
        ElseIf userFound = True Then
            Me.Hide()
            configchoice.Show()

        Else
            'This is a validation confirmation to review whether the piece has been applied in order to verify whether the user credidentials are within the database. If not found, a msgbox is preseneted. 
            MsgBox("Sorry, your credentials are incorrect/have not been found. Please try again or contact your administrator. You will be taken back to the main login page.", MsgBoxStyle.OkOnly, "Invalid Login")
            Me.Hide()
            MainLogin.Show()
        End If

        myConnection.Close()

    End Sub


    ' This is just to make sure that the credentials entered in the textbox1 is deleted if someone else wishes to enter their details without closing the entire form. 
    Private Sub authorisedlogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBox1.Clear()

    End Sub




    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox1.KeyPress
        If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Enter) Then
            e.Handled = True

            Dim cmd As OleDb.OleDbCommand = myConnection.CreateCommand

            myConnection.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source = Database.accdb"
            myConnection.Open()

            cmd = New OleDbCommand("SELECT * FROM [authorisedmembers] WHERE [password] = '" & TextBox1.Text & "'", myConnection)
            Dim dr As OleDbDataReader = cmd.ExecuteReader

            ' the following variable is hold true if user is found, and false if user is not found
            Dim userFound As Boolean = False
            ' the following variables will hold the user first and last name if found.
            Dim FirstName As String = ""
            Dim LastName As String = ""

            'if found:
            While dr.Read
                userFound = True
                FirstName = dr("FirstName").ToString
                LastName = dr("LastName").ToString
            End While

            'checking the result
            If String.IsNullOrEmpty(TextBox1.Text) Then
                MsgBox("Please enter your credentials")
            ElseIf userFound = True Then
                Me.Hide()
                configchoice.Show()

            Else
                'This is a validation confirmation to review whether the piece has been applied in order to verify whether the user credidentials are within the database. If not found, a msgbox is preseneted. 
                MsgBox("Sorry, your credentials are incorrect/have not been found. Please try again or contact your administrator. You will be taken back to the main login page.", MsgBoxStyle.OkOnly, "Invalid Login")
                Me.Hide()
                MainLogin.Show()
            End If

            myConnection.Close()
        End If
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        Me.WindowState = System.Windows.Forms.FormWindowState.Minimized

    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        closeform()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Dim result As Integer = MsgBox("By clicking back here, you will be taken out of the Authorised Members' login and returned back to the student login, do you wish to proceed", MsgBoxStyle.YesNo)
        If result = DialogResult.Yes Then
            MainLogin.Show()
            Me.Hide()
        End If
    End Sub
End Class