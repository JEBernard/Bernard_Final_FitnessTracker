Imports System
Imports System.Configuration
Imports Nutritionix

Public Class Food_Lookup

    Public SearchFood As String
    Dim Nutritionix As New NutritionixClient()
    Dim request = New SearchRequest
    Dim response As SearchResponse
    Dim result As New SearchResult
    Dim listResults As New List(Of String)

    Private Sub Food_Lookup_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click

        SearchFood = txtSearch.Text

        'Dim Nutritionix = New NutritionixClient()

        Dim appId = "8e960d18"
        Dim appKey = "3e2a36b455b6c25cad2c6c4bd888ac63"

        Nutritionix.Initialize(appId, appKey)

        'Dim request = New SearchRequest
        request.Query = SearchFood

        ToolStripStatusLabel1.Text = "Searching Nutritionix for " & SearchFood & "..."

        response = Nutritionix.SearchItems(request)

        Console.WriteLine("Displaying results 1 - {0} of {1}", response.Results.Length, response.TotalResults)

        'Dim result As New SearchResult

        For Each result In response.Results

            'listResults.Add(result.Item.BrandName & result.Item.Name)
            lstResults.DisplayMember = result.Item.BrandName & result.Item.Name
            lstResults.DataSource = listResults

        Next

    End Sub

    Private Sub btnInformation_Click(sender As Object, e As EventArgs) Handles btnInformation.Click
        Try

            ToolStripStatusLabel1.Text = lstResults.SelectedValue
        Catch

        End Try
    End Sub

    Private Sub lstResults_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstResults.SelectedIndexChanged

    End Sub
End Class