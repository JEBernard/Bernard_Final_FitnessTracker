﻿Imports System
Imports System.Configuration
Imports Nutritionix
Imports System.Collections.Specialized

Public Class frmFoodLookup

    Public SearchFood As String
    Dim Nutritionix As New NutritionixClient()
    Dim request = New SearchRequest
    Dim response As SearchResponse
    Dim result As New SearchResult
    Dim listResults As New List(Of String)
    Dim appId As String = ConfigurationManager.AppSettings.Get("appid")
    Dim appKey As String = ConfigurationManager.AppSettings.Get("appkey")
    Dim searchResultsTableAdapter As New SearchResultsTableAdapters.SearchResults1TableAdapter

    Private Sub Food_Lookup_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'SearchResults.SearchResults1' table. You can move, or remove it, as needed.
        Me.SearchResults1TableAdapter.FillTable(Me.SearchResults.SearchResults1)
        'TODO: This line of code loads data into the 'SearchResults._SearchResults' table. You can move, or remove it, as needed.
        Me.SearchResultsTableAdapter1.Fill(Me.SearchResults._SearchResults)
        lblName.Text = frmLogin.Username
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click

        SearchFood = txtSearch.Text

        Nutritionix.Initialize(appId, appKey)

        request.Query = SearchFood

        ToolStripStatusLabel1.Text = "Searching Nutritionix for " & SearchFood & "..."

        response = Nutritionix.SearchItems(request)

        For Each result In response.Results
            searchResultsTableAdapter.addResults(result.Item.BrandName, result.Item.Name, result.Item.Id, result.Item.NutritionFact_Calories)
        Next
        ToolStripStatusLabel1.Text = ""
        searchResultsTableAdapter.FillTable(SearchResults.SearchResults1)


    End Sub

    Private Sub btnInformation_Click(sender As Object, e As EventArgs) Handles btnAdd.Click

    End Sub

    Private Sub lstResults_SelectedIndexChanged(sender As Object, e As EventArgs)

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
End Class