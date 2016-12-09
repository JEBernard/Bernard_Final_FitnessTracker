Imports System.Data
Imports System.Data.SqlClient
Imports System.Windows.Forms.DataVisualization.Charting
Public Class Reports
    Private Sub Reports_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim strConn As String = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Users.mdf;Integrated Security=True"

        Dim conn As New SqlConnection(strConn)

        Dim sqlProducts As String = "SELECT        [User], Meal, Entry, Calories, Date
FROM            Diary
WHERE        ([User] = @User)"
        Dim da As New SqlDataAdapter(sqlProducts, conn)
        da.SelectCommand.Parameters.AddWithValue("@User", frmLogin.Username)
        Dim ds As New DataSet()
        da.Fill(ds, "Diary")

        Dim ChartArea1 As ChartArea = New ChartArea()
        Dim Legend1 As Legend = New Legend()
        Dim Series1 As Series = New Series()
        Dim Chart1 = New Chart()
        Me.Controls.Add(Chart1)

        ChartArea1.Name = "ChartArea1"
        Chart1.ChartAreas.Add(ChartArea1)
        Legend1.Name = "Legend1"
        Chart1.Legends.Add(Legend1)
        Chart1.Location = New System.Drawing.Point(13, 13)
        Chart1.Name = "Chart1"
        Series1.ChartArea = "ChartArea1"
        Series1.Legend = "Legend1"
        Series1.Name = "Calories"
        Chart1.Series.Add(Series1)
        Chart1.Size = New System.Drawing.Size(800, 400)
        Chart1.TabIndex = 0
        Chart1.Text = "Chart1"

        Chart1.Series("Calories").XValueMember = "Date"
        Chart1.Series("Calories").YValueMembers = "Calories"

        Chart1.DataSource = ds.Tables("Diary")

    End Sub
End Class