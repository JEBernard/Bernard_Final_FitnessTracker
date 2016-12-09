Imports System.Data.SqlClient
Public Class frmDiary
    Dim comm As New SqlCommand
    Dim connection As String = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Users.mdf;Integrated Security=True"
    Dim myConn As New SqlConnection(connection)
    Dim selectedDate As DateTime
    Dim tableAdapter As New DiaryTableAdapters.DiaryTableAdapter()

    Private Sub UserDiary_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        lblUser.Text = frmLogin.Username
        dtpDate.Value = DateTime.Now.ToShortDateString
        Dim selectedDate As DateTime = dtpDate.Value
        tableAdapter.showAll(Diary._Diary, frmLogin.Username)
    End Sub
    Private Sub FillDiary()
        If radBreakfast.Checked Then
            tableAdapter.FillByMeal(Diary._Diary, frmLogin.Username, "Breakfast", dtpDate.Value)
        ElseIf radLunch.Checked Then
            tableAdapter.FillByMeal(Diary._Diary, frmLogin.Username, "Lunch", dtpDate.Value)
        ElseIf radDinner.Checked Then
            tableAdapter.FillByMeal(Diary._Diary, frmLogin.Username, "Dinner", dtpDate.Value)
        Else
            tableAdapter.FillByMeal(Diary._Diary, frmLogin.Username, "Snack", dtpDate.Value)
        End If
    End Sub

    Private Sub btnViewAll_Click(sender As Object, e As EventArgs) Handles btnViewAll.Click

        For Each ctrl As Control In gbViewMeal.Controls
            If TypeOf ctrl Is RadioButton Then
                DirectCast(ctrl, RadioButton).Checked = False
            End If
        Next

        Try
            tableAdapter.showAll(Diary._Diary, frmLogin.Username)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        FillDiary()
    End Sub
End Class