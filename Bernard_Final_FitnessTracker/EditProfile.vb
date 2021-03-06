﻿Imports System.Data.SqlClient
Public Class frmEdit
    Dim connection As String = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Users.mdf;Integrated Security=True"

    Dim myConn As New SqlConnection(connection)
    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        'TODO: add form closing event

        'Check if unsaved data exists in textboxes and ask to save before closing

        Me.Close()

    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim comm As New SqlCommand
        Dim query As String =
            " Update [dbo].[Users] Set  [Height] = @Height, [Weight] = @Weight, [Goal Weight] = @Goal_Weight WHERE
[UserName] = @Username"
        With comm
            .Connection = myConn
            .CommandType = CommandType.Text
            .CommandText = query
            .Parameters.AddWithValue("@UserName", lblName.Text)
            .Parameters.AddWithValue("@Height", txtHeight.Text)
            .Parameters.AddWithValue("@Weight", txtWeight.Text)
            .Parameters.AddWithValue("@Goal_Weight", txtGoal.Text)
        End With

        'Validate textbox entries then save to database

        If txtHeight.Text = String.Empty Then
            ErrorProvider1.SetError(txtHeight, "Height cannot be blank")
        ElseIf Not IsNumeric(txtHeight.Text) Then
            ErrorProvider1.SetError(txtHeight, "Please enter a valid Height")
        ElseIf txtWeight.Text = String.Empty Then
            ErrorProvider1.SetError(txtWeight, "Weight cannot be blank")
        ElseIf Not IsNumeric(txtWeight.Text) Then
            ErrorProvider1.SetError(txtWeight, "Please enter a valid Weight")
        ElseIf txtGoal.Text = String.Empty Then
            ErrorProvider1.SetError(txtGoal, "Goal cannot be blank")
        ElseIf Not IsNumeric(txtGoal.Text) Then
            ErrorProvider1.SetError(txtGoal, "Please enter a valid Goal Weight")
        Else
            Try
                myConn.Open()
                comm.ExecuteNonQuery()
                ToolStripStatusLabel1.Text = "User profile has been updated"
                Me.Close()
                myConn.Close()
            Catch ex As Exception
                ToolStripStatusLabel1.Text = ex.Message
                myConn.Close()
            End Try
        End If
    End Sub

    Private Sub frmEdit_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblName.Text = frmLogin.Username
    End Sub
End Class