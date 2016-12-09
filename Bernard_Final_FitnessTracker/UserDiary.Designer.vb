<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmDiary
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.lblName = New System.Windows.Forms.Label()
        Me.dtpDate = New System.Windows.Forms.DateTimePicker()
        Me.DiaryBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DiaryBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.LunchDiaryBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.radSnack = New System.Windows.Forms.RadioButton()
        Me.radDinner = New System.Windows.Forms.RadioButton()
        Me.radLunch = New System.Windows.Forms.RadioButton()
        Me.radBreakfast = New System.Windows.Forms.RadioButton()
        Me.gbViewMeal = New System.Windows.Forms.GroupBox()
        Me.btnViewAll = New System.Windows.Forms.Button()
        Me.UserDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MealDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EntryDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CaloriesDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DiaryBindingSource5 = New System.Windows.Forms.BindingSource(Me.components)
        Me.Diary = New Bernard_Final_FitnessTracker.Diary()
        Me.DiaryBindingSource4 = New System.Windows.Forms.BindingSource(Me.components)
        Me.DiaryBindingSource3 = New System.Windows.Forms.BindingSource(Me.components)
        Me.DiaryTableAdapter = New Bernard_Final_FitnessTracker.DiaryTableAdapters.DiaryTableAdapter()
        Me.DiaryBindingSource2 = New System.Windows.Forms.BindingSource(Me.components)
        Me.lblUser = New System.Windows.Forms.Label()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.DiaryBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DiaryBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LunchDiaryBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbViewMeal.SuspendLayout()
        CType(Me.DiaryBindingSource5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Diary, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DiaryBindingSource4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DiaryBindingSource3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DiaryBindingSource2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(672, 24)
        Me.MenuStrip1.TabIndex = 1
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
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(515, 304)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(75, 23)
        Me.btnClose.TabIndex = 9
        Me.btnClose.Text = "Ok"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'lblName
        '
        Me.lblName.CausesValidation = False
        Me.lblName.Location = New System.Drawing.Point(152, 9)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(143, 23)
        Me.lblName.TabIndex = 10
        '
        'dtpDate
        '
        Me.dtpDate.Location = New System.Drawing.Point(204, 73)
        Me.dtpDate.Name = "dtpDate"
        Me.dtpDate.Size = New System.Drawing.Size(200, 20)
        Me.dtpDate.TabIndex = 12
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.UserDataGridViewTextBoxColumn, Me.MealDataGridViewTextBoxColumn, Me.EntryDataGridViewTextBoxColumn, Me.CaloriesDataGridViewTextBoxColumn, Me.DateDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.DiaryBindingSource5
        Me.DataGridView1.Location = New System.Drawing.Point(45, 115)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(545, 130)
        Me.DataGridView1.TabIndex = 13
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
        'gbViewMeal
        '
        Me.gbViewMeal.Controls.Add(Me.radSnack)
        Me.gbViewMeal.Controls.Add(Me.radDinner)
        Me.gbViewMeal.Controls.Add(Me.radLunch)
        Me.gbViewMeal.Controls.Add(Me.radBreakfast)
        Me.gbViewMeal.Location = New System.Drawing.Point(188, 268)
        Me.gbViewMeal.Name = "gbViewMeal"
        Me.gbViewMeal.Size = New System.Drawing.Size(216, 64)
        Me.gbViewMeal.TabIndex = 14
        Me.gbViewMeal.TabStop = False
        Me.gbViewMeal.Text = "View By Meal"
        '
        'btnViewAll
        '
        Me.btnViewAll.Location = New System.Drawing.Point(495, 73)
        Me.btnViewAll.Name = "btnViewAll"
        Me.btnViewAll.Size = New System.Drawing.Size(95, 23)
        Me.btnViewAll.TabIndex = 15
        Me.btnViewAll.Text = "View All Meals"
        Me.btnViewAll.UseVisualStyleBackColor = True
        '
        'UserDataGridViewTextBoxColumn
        '
        Me.UserDataGridViewTextBoxColumn.DataPropertyName = "User"
        Me.UserDataGridViewTextBoxColumn.HeaderText = "User"
        Me.UserDataGridViewTextBoxColumn.Name = "UserDataGridViewTextBoxColumn"
        Me.UserDataGridViewTextBoxColumn.ReadOnly = True
        '
        'MealDataGridViewTextBoxColumn
        '
        Me.MealDataGridViewTextBoxColumn.DataPropertyName = "Meal"
        Me.MealDataGridViewTextBoxColumn.HeaderText = "Meal"
        Me.MealDataGridViewTextBoxColumn.Name = "MealDataGridViewTextBoxColumn"
        Me.MealDataGridViewTextBoxColumn.ReadOnly = True
        '
        'EntryDataGridViewTextBoxColumn
        '
        Me.EntryDataGridViewTextBoxColumn.DataPropertyName = "Entry"
        Me.EntryDataGridViewTextBoxColumn.HeaderText = "Entry"
        Me.EntryDataGridViewTextBoxColumn.Name = "EntryDataGridViewTextBoxColumn"
        Me.EntryDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CaloriesDataGridViewTextBoxColumn
        '
        Me.CaloriesDataGridViewTextBoxColumn.DataPropertyName = "Calories"
        Me.CaloriesDataGridViewTextBoxColumn.HeaderText = "Calories"
        Me.CaloriesDataGridViewTextBoxColumn.Name = "CaloriesDataGridViewTextBoxColumn"
        Me.CaloriesDataGridViewTextBoxColumn.ReadOnly = True
        '
        'DateDataGridViewTextBoxColumn
        '
        Me.DateDataGridViewTextBoxColumn.DataPropertyName = "Date"
        Me.DateDataGridViewTextBoxColumn.HeaderText = "Date"
        Me.DateDataGridViewTextBoxColumn.Name = "DateDataGridViewTextBoxColumn"
        Me.DateDataGridViewTextBoxColumn.ReadOnly = True
        '
        'DiaryBindingSource5
        '
        Me.DiaryBindingSource5.DataMember = "Diary"
        Me.DiaryBindingSource5.DataSource = Me.Diary
        '
        'Diary
        '
        Me.Diary.DataSetName = "Diary"
        Me.Diary.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DiaryBindingSource4
        '
        Me.DiaryBindingSource4.DataMember = "Diary"
        Me.DiaryBindingSource4.DataSource = Me.Diary
        '
        'DiaryBindingSource3
        '
        Me.DiaryBindingSource3.DataMember = "Diary"
        Me.DiaryBindingSource3.DataSource = Me.Diary
        '
        'DiaryTableAdapter
        '
        Me.DiaryTableAdapter.ClearBeforeFill = True
        '
        'DiaryBindingSource2
        '
        Me.DiaryBindingSource2.DataSource = Me.Diary
        Me.DiaryBindingSource2.Position = 0
        '
        'lblUser
        '
        Me.lblUser.Location = New System.Drawing.Point(262, 32)
        Me.lblUser.Name = "lblUser"
        Me.lblUser.Size = New System.Drawing.Size(100, 23)
        Me.lblUser.TabIndex = 16
        '
        'frmDiary
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange
        Me.ClientSize = New System.Drawing.Size(672, 361)
        Me.Controls.Add(Me.lblUser)
        Me.Controls.Add(Me.btnViewAll)
        Me.Controls.Add(Me.gbViewMeal)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.dtpDate)
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Name = "frmDiary"
        Me.Text = "Diary"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.DiaryBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DiaryBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LunchDiaryBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbViewMeal.ResumeLayout(False)
        Me.gbViewMeal.PerformLayout()
        CType(Me.DiaryBindingSource5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Diary, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DiaryBindingSource4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DiaryBindingSource3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DiaryBindingSource2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents btnClose As Button
    Friend WithEvents lblName As Label
    Friend WithEvents dtpDate As DateTimePicker
    Friend WithEvents DiaryBindingSource As BindingSource
    Friend WithEvents DiaryTableAdapter As DiaryTableAdapters.DiaryTableAdapter
    Friend WithEvents DiaryBindingSource1 As BindingSource
    Friend WithEvents DiaryBindingSource2 As BindingSource
    Friend WithEvents Diary As Diary
    Friend WithEvents DiaryBindingSource3 As BindingSource
    Friend WithEvents DiaryBindingSource4 As BindingSource
    Friend WithEvents DiaryBindingSource5 As BindingSource
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents UserDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MealDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EntryDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CaloriesDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DateDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents LunchDiaryBindingSource As BindingSource
    Friend WithEvents radSnack As RadioButton
    Friend WithEvents radDinner As RadioButton
    Friend WithEvents radLunch As RadioButton
    Friend WithEvents radBreakfast As RadioButton
    Friend WithEvents gbViewMeal As GroupBox
    Friend WithEvents btnViewAll As Button
    Friend WithEvents lblUser As Label
End Class
