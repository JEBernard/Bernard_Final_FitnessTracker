Imports System.Data.SqlClient
Public Class frmProfile
    Dim connection As String = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Users.mdf;Integrated Security=True"

    Dim myConn As New SqlConnection(connection)

    Private Sub DiaryToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DiaryToolStripMenuItem.Click
        Food_Lookup.ShowDialog()
    End Sub

    Private Sub frmProfile_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ReadData()
    End Sub

    Private Sub EditProfileToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EditProfileToolStripMenuItem.Click
        frmEdit.ShowDialog()

    End Sub

    Private Sub ReadData()
        Dim comm As New SqlCommand
        Dim query As String = "SELECT Id, UserName, Password, Height, Weight, [Goal Weight] FROM dbo.Users
WHERE UserName = @UserName"
        With comm
            .Connection = myConn
            .CommandType = CommandType.Text
            .CommandText = query
            .Parameters.AddWithValue("@UserName", txtName.Text)
        End With

        Try

            myConn.Open()
            Dim dr As SqlDataReader
            dr = comm.ExecuteReader

            If dr.HasRows Then
                dr.Read()
                txtHeight.Text = dr.Item("Height")
                txtWeight.Text = dr.Item("Weight")
                txtGoal.Text = dr.Item("Goal Weight")
                dr.Close()
                myConn.Close()
            End If

            txtName.Text = frmLogin.Username
            txtDate.Text = Date.Now.ToShortDateString()
            myConn.Close()
        Catch ex As Exception
            ToolStripStatusLabel1.Text = ex.Message
            myConn.Close()
        End Try
    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        ReadData()
    End Sub
End Class