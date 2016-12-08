Imports System.Data.SqlClient

Public Class frmLogin
    'Login and Register form
    Dim users As New Dictionary(Of String, String)

    Dim connection As String = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Users.mdf;Integrated Security=True"

    Dim myConn As New SqlConnection(connection)

    Public Shared Username As String
    Private Sub frmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim strName As String = txtLoginUsername.Text
        Dim strPassword As String = txtLoginPassword.Text
        Dim count As Integer
        Dim comm As New SqlCommand()
        Dim query As String = "SELECT COUNT(*) FROM Users
WHERE UserName = @UserName AND  Password = @Password"

        With comm
            .Connection = myConn
            .CommandType = CommandType.Text
            .CommandText = query
            .Parameters.AddWithValue("@UserName", strName)
            .Parameters.AddWithValue("@Password", strPassword)
        End With

        Try
            myConn.Open()

            count = comm.ExecuteScalar()

            If count > 0 Then

                Username = strName
                myConn.Close()

                frmProfile.ShowDialog()

                Me.Close()
            Else
                MessageBox.Show("Invalid Username/Password")
                myConn.Close()
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub btnRegister_Click(sender As Object, e As EventArgs) Handles btnRegister.Click
        Dim strName As String = txtRegUsername.Text
        Dim strPassword As String = txtRegPassword.Text
        Dim query As String = "INSERT INTO Users
                         (UserName, Password)
VALUES        (@UserName,@Password)"

        Dim comm As New SqlCommand()
        With comm
            .Connection = myConn
            .CommandType = CommandType.Text
            .CommandText = query
            .Parameters.AddWithValue("@UserName", strName)
            .Parameters.AddWithValue("@Password", strPassword)
        End With
        Try
            myConn.Open()
            comm.ExecuteNonQuery()
            MessageBox.Show("New user: " & strName & " has been registered")
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        myConn.Close()

    End Sub
End Class