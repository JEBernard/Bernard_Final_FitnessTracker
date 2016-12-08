<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmFoodLookup
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.LookupStatusLabel = New System.Windows.Forms.ToolStripStatusLabel()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.pbAttrib = New System.Windows.Forms.PictureBox()
        Me.lblName = New System.Windows.Forms.Label()
        Me.dgvResults = New System.Windows.Forms.DataGridView()
        Me.BrandNameDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ItemNameDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CaloriesDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ItemIdDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SearchResultsBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.Results = New Bernard_Final_FitnessTracker.Results()
        Me.SearchResults1BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SearchResultsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.radBreakfast = New System.Windows.Forms.RadioButton()
        Me.radLunch = New System.Windows.Forms.RadioButton()
        Me.radDinner = New System.Windows.Forms.RadioButton()
        Me.radSnack = New System.Windows.Forms.RadioButton()
        Me.gbMeal = New System.Windows.Forms.GroupBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BrandNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ItemNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ItemId1DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SearchResultsTableAdapter2 = New Bernard_Final_FitnessTracker.ResultsTableAdapters.SearchResultsTableAdapter()
        Me.Results1 = New Bernard_Final_FitnessTracker.Results()
        Me.SearchResultsBindingSource2 = New System.Windows.Forms.BindingSource(Me.components)
        Me.StatusStrip1.SuspendLayout()
        CType(Me.pbAttrib, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvResults, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SearchResultsBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Results, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SearchResults1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SearchResultsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbMeal.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.Results1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SearchResultsBindingSource2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnSearch
        '
        Me.btnSearch.Location = New System.Drawing.Point(353, 56)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(75, 23)
        Me.btnSearch.TabIndex = 0
        Me.btnSearch.Text = "Search"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'txtSearch
        '
        Me.txtSearch.Location = New System.Drawing.Point(148, 58)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(164, 20)
        Me.txtSearch.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(53, 56)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(73, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Enter an Item:"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1, Me.LookupStatusLabel})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 291)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(582, 22)
        Me.StatusStrip1.TabIndex = 4
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(0, 17)
        '
        'LookupStatusLabel
        '
        Me.LookupStatusLabel.Name = "LookupStatusLabel"
        Me.LookupStatusLabel.Size = New System.Drawing.Size(0, 17)
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(310, 243)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(118, 23)
        Me.btnAdd.TabIndex = 5
        Me.btnAdd.Text = "Add to Diary"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'pbAttrib
        '
        Me.pbAttrib.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pbAttrib.Image = Global.Bernard_Final_FitnessTracker.My.Resources.Resources.attribution_jqfdgy
        Me.pbAttrib.Location = New System.Drawing.Point(425, 12)
        Me.pbAttrib.Name = "pbAttrib"
        Me.pbAttrib.Size = New System.Drawing.Size(154, 37)
        Me.pbAttrib.TabIndex = 6
        Me.pbAttrib.TabStop = False
        '
        'lblName
        '
        Me.lblName.Location = New System.Drawing.Point(172, 9)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(233, 23)
        Me.lblName.TabIndex = 7
        Me.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'dgvResults
        '
        Me.dgvResults.AllowUserToAddRows = False
        Me.dgvResults.AllowUserToDeleteRows = False
        Me.dgvResults.AutoGenerateColumns = False
        Me.dgvResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvResults.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.BrandNameDataGridViewTextBoxColumn1, Me.ItemNameDataGridViewTextBoxColumn1, Me.CaloriesDataGridViewTextBoxColumn, Me.ItemIdDataGridViewTextBoxColumn})
        Me.dgvResults.DataSource = Me.SearchResultsBindingSource1
        Me.dgvResults.Location = New System.Drawing.Point(79, 97)
        Me.dgvResults.Name = "dgvResults"
        Me.dgvResults.ReadOnly = True
        Me.dgvResults.Size = New System.Drawing.Size(349, 107)
        Me.dgvResults.TabIndex = 8
        '
        'BrandNameDataGridViewTextBoxColumn1
        '
        Me.BrandNameDataGridViewTextBoxColumn1.DataPropertyName = "brand name"
        Me.BrandNameDataGridViewTextBoxColumn1.HeaderText = "brand name"
        Me.BrandNameDataGridViewTextBoxColumn1.Name = "BrandNameDataGridViewTextBoxColumn1"
        Me.BrandNameDataGridViewTextBoxColumn1.ReadOnly = True
        '
        'ItemNameDataGridViewTextBoxColumn1
        '
        Me.ItemNameDataGridViewTextBoxColumn1.DataPropertyName = "item name"
        Me.ItemNameDataGridViewTextBoxColumn1.HeaderText = "item name"
        Me.ItemNameDataGridViewTextBoxColumn1.Name = "ItemNameDataGridViewTextBoxColumn1"
        Me.ItemNameDataGridViewTextBoxColumn1.ReadOnly = True
        '
        'CaloriesDataGridViewTextBoxColumn
        '
        Me.CaloriesDataGridViewTextBoxColumn.DataPropertyName = "calories"
        Me.CaloriesDataGridViewTextBoxColumn.HeaderText = "calories"
        Me.CaloriesDataGridViewTextBoxColumn.Name = "CaloriesDataGridViewTextBoxColumn"
        Me.CaloriesDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ItemIdDataGridViewTextBoxColumn
        '
        Me.ItemIdDataGridViewTextBoxColumn.DataPropertyName = "item id"
        Me.ItemIdDataGridViewTextBoxColumn.HeaderText = "item id"
        Me.ItemIdDataGridViewTextBoxColumn.Name = "ItemIdDataGridViewTextBoxColumn"
        Me.ItemIdDataGridViewTextBoxColumn.ReadOnly = True
        Me.ItemIdDataGridViewTextBoxColumn.Visible = False
        '
        'SearchResultsBindingSource1
        '
        Me.SearchResultsBindingSource1.DataMember = "SearchResults"
        Me.SearchResultsBindingSource1.DataSource = Me.Results
        '
        'Results
        '
        Me.Results.DataSetName = "Results"
        Me.Results.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'radBreakfast
        '
        Me.radBreakfast.AutoSize = True
        Me.radBreakfast.Location = New System.Drawing.Point(23, 19)
        Me.radBreakfast.Name = "radBreakfast"
        Me.radBreakfast.Size = New System.Drawing.Size(70, 17)
        Me.radBreakfast.TabIndex = 9
        Me.radBreakfast.TabStop = True
        Me.radBreakfast.Text = "Breakfast"
        Me.radBreakfast.UseVisualStyleBackColor = True
        '
        'radLunch
        '
        Me.radLunch.AutoSize = True
        Me.radLunch.Location = New System.Drawing.Point(119, 19)
        Me.radLunch.Name = "radLunch"
        Me.radLunch.Size = New System.Drawing.Size(55, 17)
        Me.radLunch.TabIndex = 10
        Me.radLunch.TabStop = True
        Me.radLunch.Text = "Lunch"
        Me.radLunch.UseVisualStyleBackColor = True
        '
        'radDinner
        '
        Me.radDinner.AutoSize = True
        Me.radDinner.Location = New System.Drawing.Point(23, 42)
        Me.radDinner.Name = "radDinner"
        Me.radDinner.Size = New System.Drawing.Size(56, 17)
        Me.radDinner.TabIndex = 11
        Me.radDinner.TabStop = True
        Me.radDinner.Text = "Dinner"
        Me.radDinner.UseVisualStyleBackColor = True
        '
        'radSnack
        '
        Me.radSnack.AutoSize = True
        Me.radSnack.Location = New System.Drawing.Point(119, 42)
        Me.radSnack.Name = "radSnack"
        Me.radSnack.Size = New System.Drawing.Size(56, 17)
        Me.radSnack.TabIndex = 12
        Me.radSnack.TabStop = True
        Me.radSnack.Text = "Snack"
        Me.radSnack.UseVisualStyleBackColor = True
        '
        'gbMeal
        '
        Me.gbMeal.Controls.Add(Me.radSnack)
        Me.gbMeal.Controls.Add(Me.radDinner)
        Me.gbMeal.Controls.Add(Me.radLunch)
        Me.gbMeal.Controls.Add(Me.radBreakfast)
        Me.gbMeal.Location = New System.Drawing.Point(56, 224)
        Me.gbMeal.Name = "gbMeal"
        Me.gbMeal.Size = New System.Drawing.Size(216, 64)
        Me.gbMeal.TabIndex = 13
        Me.gbMeal.TabStop = False
        Me.gbMeal.Text = "Add to Meal"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(582, 24)
        Me.MenuStrip1.TabIndex = 14
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(92, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'BrandNameDataGridViewTextBoxColumn
        '
        Me.BrandNameDataGridViewTextBoxColumn.DataPropertyName = "Brand Name"
        Me.BrandNameDataGridViewTextBoxColumn.HeaderText = "Brand Name"
        Me.BrandNameDataGridViewTextBoxColumn.Name = "BrandNameDataGridViewTextBoxColumn"
        '
        'ItemNameDataGridViewTextBoxColumn
        '
        Me.ItemNameDataGridViewTextBoxColumn.DataPropertyName = "Item Name"
        Me.ItemNameDataGridViewTextBoxColumn.HeaderText = "Item Name"
        Me.ItemNameDataGridViewTextBoxColumn.Name = "ItemNameDataGridViewTextBoxColumn"
        '
        'ItemId1DataGridViewTextBoxColumn
        '
        Me.ItemId1DataGridViewTextBoxColumn.DataPropertyName = "item id1"
        Me.ItemId1DataGridViewTextBoxColumn.HeaderText = "item id1"
        Me.ItemId1DataGridViewTextBoxColumn.Name = "ItemId1DataGridViewTextBoxColumn"
        '
        'SearchResultsTableAdapter2
        '
        Me.SearchResultsTableAdapter2.ClearBeforeFill = True
        '
        'Results1
        '
        Me.Results1.DataSetName = "Results"
        Me.Results1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'SearchResultsBindingSource2
        '
        Me.SearchResultsBindingSource2.DataMember = "SearchResults"
        Me.SearchResultsBindingSource2.DataSource = Me.Results1
        '
        'frmFoodLookup
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(582, 313)
        Me.Controls.Add(Me.gbMeal)
        Me.Controls.Add(Me.dgvResults)
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.pbAttrib)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtSearch)
        Me.Controls.Add(Me.btnSearch)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmFoodLookup"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Food Lookup"
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        CType(Me.pbAttrib, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvResults, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SearchResultsBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Results, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SearchResults1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SearchResultsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbMeal.ResumeLayout(False)
        Me.gbMeal.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.Results1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SearchResultsBindingSource2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnSearch As Button
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents ToolStripStatusLabel1 As ToolStripStatusLabel
    Friend WithEvents btnAdd As Button
    Friend WithEvents pbAttrib As PictureBox
    Friend WithEvents lblName As Label
    Friend WithEvents dgvResults As DataGridView
    Friend WithEvents SearchResultsBindingSource As BindingSource
    Friend WithEvents SearchResults1BindingSource As BindingSource
    Friend WithEvents radBreakfast As RadioButton
    Friend WithEvents radLunch As RadioButton
    Friend WithEvents radDinner As RadioButton
    Friend WithEvents radSnack As RadioButton
    Friend WithEvents gbMeal As GroupBox
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BrandNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ItemNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ItemId1DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Results As Results
    Friend WithEvents SearchResultsBindingSource1 As BindingSource
    Friend WithEvents SearchResultsTableAdapter2 As ResultsTableAdapters.SearchResultsTableAdapter
    Friend WithEvents Results1 As Results
    Friend WithEvents SearchResultsBindingSource2 As BindingSource
    Friend WithEvents BrandNameDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents ItemNameDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents CaloriesDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ItemIdDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents LookupStatusLabel As ToolStripStatusLabel
End Class
