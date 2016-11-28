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
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.pbAttrib = New System.Windows.Forms.PictureBox()
        Me.lblName = New System.Windows.Forms.Label()
        Me.dgvResults = New System.Windows.Forms.DataGridView()
        Me.SearchResults1BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SearchResultsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.RadioButton3 = New System.Windows.Forms.RadioButton()
        Me.RadioButton4 = New System.Windows.Forms.RadioButton()
        Me.gbMeal = New System.Windows.Forms.GroupBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BrandNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ItemNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ItemId1DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Results = New Bernard_Final_FitnessTracker.Results()
        Me.SearchResultsBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.SearchResultsTableAdapter2 = New Bernard_Final_FitnessTracker.ResultsTableAdapters.SearchResultsTableAdapter()
        Me.BrandNameDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ItemNameDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ItemIdDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CaloriesDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StatusStrip1.SuspendLayout()
        CType(Me.pbAttrib, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvResults, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SearchResults1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SearchResultsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbMeal.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.Results, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SearchResultsBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnSearch
        '
        Me.btnSearch.Location = New System.Drawing.Point(426, 56)
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
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 291)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(680, 22)
        Me.StatusStrip1.TabIndex = 4
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(0, 17)
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(383, 254)
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
        Me.pbAttrib.Location = New System.Drawing.Point(514, 12)
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
        Me.dgvResults.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.BrandNameDataGridViewTextBoxColumn1, Me.ItemNameDataGridViewTextBoxColumn1, Me.ItemIdDataGridViewTextBoxColumn, Me.CaloriesDataGridViewTextBoxColumn})
        Me.dgvResults.DataSource = Me.SearchResultsBindingSource1
        Me.dgvResults.Location = New System.Drawing.Point(56, 96)
        Me.dgvResults.Name = "dgvResults"
        Me.dgvResults.ReadOnly = True
        Me.dgvResults.Size = New System.Drawing.Size(445, 107)
        Me.dgvResults.TabIndex = 8
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Location = New System.Drawing.Point(23, 19)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(70, 17)
        Me.RadioButton1.TabIndex = 9
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "Breakfast"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Location = New System.Drawing.Point(119, 19)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(55, 17)
        Me.RadioButton2.TabIndex = 10
        Me.RadioButton2.TabStop = True
        Me.RadioButton2.Text = "Lunch"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'RadioButton3
        '
        Me.RadioButton3.AutoSize = True
        Me.RadioButton3.Location = New System.Drawing.Point(23, 42)
        Me.RadioButton3.Name = "RadioButton3"
        Me.RadioButton3.Size = New System.Drawing.Size(56, 17)
        Me.RadioButton3.TabIndex = 11
        Me.RadioButton3.TabStop = True
        Me.RadioButton3.Text = "Dinner"
        Me.RadioButton3.UseVisualStyleBackColor = True
        '
        'RadioButton4
        '
        Me.RadioButton4.AutoSize = True
        Me.RadioButton4.Location = New System.Drawing.Point(119, 42)
        Me.RadioButton4.Name = "RadioButton4"
        Me.RadioButton4.Size = New System.Drawing.Size(56, 17)
        Me.RadioButton4.TabIndex = 12
        Me.RadioButton4.TabStop = True
        Me.RadioButton4.Text = "Snack"
        Me.RadioButton4.UseVisualStyleBackColor = True
        '
        'gbMeal
        '
        Me.gbMeal.Controls.Add(Me.RadioButton4)
        Me.gbMeal.Controls.Add(Me.RadioButton3)
        Me.gbMeal.Controls.Add(Me.RadioButton2)
        Me.gbMeal.Controls.Add(Me.RadioButton1)
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
        Me.MenuStrip1.Size = New System.Drawing.Size(680, 24)
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
        'Results
        '
        Me.Results.DataSetName = "Results"
        Me.Results.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'SearchResultsBindingSource1
        '
        Me.SearchResultsBindingSource1.DataMember = "SearchResults"
        Me.SearchResultsBindingSource1.DataSource = Me.Results
        '
        'SearchResultsTableAdapter2
        '
        Me.SearchResultsTableAdapter2.ClearBeforeFill = True
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
        'ItemIdDataGridViewTextBoxColumn
        '
        Me.ItemIdDataGridViewTextBoxColumn.DataPropertyName = "item id"
        Me.ItemIdDataGridViewTextBoxColumn.HeaderText = "item id"
        Me.ItemIdDataGridViewTextBoxColumn.Name = "ItemIdDataGridViewTextBoxColumn"
        Me.ItemIdDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CaloriesDataGridViewTextBoxColumn
        '
        Me.CaloriesDataGridViewTextBoxColumn.DataPropertyName = "calories"
        Me.CaloriesDataGridViewTextBoxColumn.HeaderText = "calories"
        Me.CaloriesDataGridViewTextBoxColumn.Name = "CaloriesDataGridViewTextBoxColumn"
        Me.CaloriesDataGridViewTextBoxColumn.ReadOnly = True
        '
        'frmFoodLookup
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(680, 313)
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
        CType(Me.SearchResults1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SearchResultsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbMeal.ResumeLayout(False)
        Me.gbMeal.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.Results, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SearchResultsBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents RadioButton3 As RadioButton
    Friend WithEvents RadioButton4 As RadioButton
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
    Friend WithEvents BrandNameDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents ItemNameDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents ItemIdDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CaloriesDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
