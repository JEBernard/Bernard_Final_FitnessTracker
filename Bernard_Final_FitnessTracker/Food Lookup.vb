Imports System
Imports System.Configuration
Imports Nutritionix
Imports System.Collections.Specialized
Imports System.Data.SqlClient

Public Class frmFoodLookup

    Public SearchFood As String
    Dim Nutritionix As New NutritionixClient()
    Dim request = New SearchRequest
    Dim response As SearchResponse
    Dim calResponse As SearchResponse
    Dim calRequest As SearchRequest
    Dim calResult As New SearchResult
    Dim result As New SearchResult
    Dim appId As String = ConfigurationManager.AppSettings.Get("appid")
    Dim appKey As String = ConfigurationManager.AppSettings.Get("appkey")
    Dim resultsTableAdapter As New ResultsTableAdapters.SearchResultsTableAdapter
    Dim diaryTableAdpater As New DiaryTableAdapters.DiaryTableAdapter
    Dim connection As String = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Users.mdf;Integrated Security=True"
    Dim myConn As New SqlConnection(connection)
    Dim tableAdapter As New DiaryTableAdapters.DiaryTableAdapter()

    Private Sub Food_Lookup_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Results1.SearchResults' table. You can move, or remove it, as needed.
        Me.SearchResultsTableAdapter2.Fill(Me.Results1.SearchResults)
        lblName.Text = frmLogin.Username
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click

        SearchFood = txtSearch.Text

        Nutritionix.Initialize(appId, appKey)

        request.Query = SearchFood

        ToolStripStatusLabel1.Text = "Searching Nutritionix for " & SearchFood & "..."

        response = Nutritionix.SearchItems(request)

        For Each result In response.Results
            resultsTableAdapter.addResults(result.Item.BrandName, result.Item.Name, result.Item.Id, result.Item.NutritionFact_Calories)
            Dim item As New Item
            item = Nutritionix.RetrieveItem(result.Item.Id)
            resultsTableAdapter.addCalories(item.NutritionFact_Calories, item.Id)

        Next
        ToolStripStatusLabel1.Text = ""
        resultsTableAdapter.ClearBeforeFill = True
        resultsTableAdapter.Fill(Results.SearchResults)

    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub pbAttrib_Click(sender As Object, e As EventArgs) Handles pbAttrib.Click
        Process.Start("http://www.nutritionix.com/api")
    End Sub

    Private Sub pbAttrib_MouseHover(sender As Object, e As EventArgs) Handles pbAttrib.MouseHover
        Cursor.Current = Cursors.Hand
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim itemName As String = dgvResults.SelectedRows(0).Cells(1).Value.ToString()
        Dim calories As String = dgvResults.SelectedRows(0).Cells(2).Value.ToString()



        Dim mealSelection As String
        Dim currDate As DateTime = DateTime.Now.ToShortDateString
        If radBreakfast.Checked Then
            mealSelection = "Breakfast"
        ElseIf radLunch.Checked Then
            mealSelection = "Lunch"
        ElseIf radDinner.Checked Then
            mealSelection = "Dinner"
        ElseIf radSnack.Checked Then
            mealSelection = "Snack"
        End If

        Try
            tableAdapter.AddEntry(frmLogin.Username, mealSelection, itemName, calories, currDate)
            LookupStatusLabel.Text = "Food entry added to diary"
        Catch ex As Exception
            LookupStatusLabel.Text = ex.Message
        End Try
    End Sub
End Class