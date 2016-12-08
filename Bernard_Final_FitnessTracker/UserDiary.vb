Imports System.Data.SqlClient
Public Class frmDiary
    Dim comm As New SqlCommand
    Dim connection As String = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Users.mdf;Integrated Security=True"
    Dim myConn As New SqlConnection(connection)
    Dim selectedDate As DateTime = dtpDate.Value.ToShortDateString

    Private Sub UserDiary_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblName.Text = frmLogin.Username
        dtpDate.Value = DateTime.Now.ToShortDateString
        FillBreakfast()
        FillLunch()
        FillDinner()
        FillSnack()

    End Sub
    Private Sub FillBreakfast()

        Dim query As String = "SELECT [User], Meal, Entry, Date FROM Diary
                               WHERE (Meal = @Meal) AND (USER = @User) AND (Date =@Date)"
        Try
            With comm
                .Connection = myConn
                .CommandType = CommandType.Text
                .CommandText = query
                .Parameters.AddWithValue("@Meal", "Breakfast")
                .Parameters.AddWithValue("@User", frmLogin.Username)
                .Parameters.AddWithValue("@Date", selectedDate)

            End With

        Catch ex As Exception
            MessageBox.Show(ex.InnerException.Message)
        End Try
    End Sub

    Private Sub FillLunch()
        Dim query As String = "SELECT [User], Meal, Entry, Date FROM Diary
                               WHERE (Meal = @Meal) AND (USER = @User) AND (Date =@Date)"
        Try
            With comm
                .Connection = myConn
                .CommandType = CommandType.Text
                .CommandText = query
                .Parameters.AddWithValue("@Meal", "Lunch")
                .Parameters.AddWithValue("@User", frmLogin.Username)
                .Parameters.AddWithValue("@Date", selectedDate)

            End With

        Catch ex As Exception
            MessageBox.Show(ex.InnerException.Message)
        End Try

    End Sub

    Private Sub FillDinner()
        Dim query As String = "SELECT [User], Meal, Entry, Date FROM Diary
                               WHERE (Meal = @Meal) AND (USER = @User) AND (Date =@Date)"
        Try
            With comm
                .Connection = myConn
                .CommandType = CommandType.Text
                .CommandText = query
                .Parameters.AddWithValue("@Meal", "Dinner")
                .Parameters.AddWithValue("@User", frmLogin.Username)
                .Parameters.AddWithValue("@Date", selectedDate)

            End With

        Catch ex As Exception
            MessageBox.Show(ex.InnerException.Message)
        End Try

    End Sub

    Private Sub FillSnack()
        Dim query As String = "SELECT [User], Meal, Entry, Date FROM Diary
                               WHERE (Meal = @Meal) AND (USER = @User) AND (Date =@Date)"
        Try
            With comm
                .Connection = myConn
                .CommandType = CommandType.Text
                .CommandText = query
                .Parameters.AddWithValue("@Meal", "Snack")
                .Parameters.AddWithValue("@User", frmLogin.Username)
                .Parameters.AddWithValue("@Date", selectedDate)

            End With

        Catch ex As Exception
            MessageBox.Show(ex.InnerException.Message)
        End Try

    End Sub
    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub
End Class