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
        Me.dgvBreakfast = New System.Windows.Forms.DataGridView()
        Me.UserDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MealDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EntryDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DiaryBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Diary = New Bernard_Final_FitnessTracker.Diary()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.lblBreakfast = New System.Windows.Forms.Label()
        Me.lblLunch = New System.Windows.Forms.Label()
        Me.dgvLunch = New System.Windows.Forms.DataGridView()
        Me.lblSnack = New System.Windows.Forms.Label()
        Me.dgvSnack = New System.Windows.Forms.DataGridView()
        Me.lblDinner = New System.Windows.Forms.Label()
        Me.dgvDinner = New System.Windows.Forms.DataGridView()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.lblName = New System.Windows.Forms.Label()
        Me.dtpDate = New System.Windows.Forms.DateTimePicker()
        Me.DiaryTableAdapter = New Bernard_Final_FitnessTracker.DiaryTableAdapters.DiaryTableAdapter()
        Me.DiaryBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.UserDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MealDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EntryDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DateDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UserDataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MealDataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EntryDataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DateDataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UserDataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MealDataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EntryDataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DateDataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.dgvBreakfast, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DiaryBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Diary, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.dgvLunch, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvSnack, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvDinner, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DiaryBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvBreakfast
        '
        Me.dgvBreakfast.AllowUserToAddRows = False
        Me.dgvBreakfast.AllowUserToDeleteRows = False
        Me.dgvBreakfast.AutoGenerateColumns = False
        Me.dgvBreakfast.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvBreakfast.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.UserDataGridViewTextBoxColumn, Me.MealDataGridViewTextBoxColumn, Me.EntryDataGridViewTextBoxColumn, Me.DateDataGridViewTextBoxColumn})
        Me.dgvBreakfast.DataSource = Me.DiaryBindingSource
        Me.dgvBreakfast.Location = New System.Drawing.Point(21, 123)
        Me.dgvBreakfast.Name = "dgvBreakfast"
        Me.dgvBreakfast.ReadOnly = True
        Me.dgvBreakfast.Size = New System.Drawing.Size(147, 44)
        Me.dgvBreakfast.TabIndex = 0
        '
        'UserDataGridViewTextBoxColumn
        '
        Me.UserDataGridViewTextBoxColumn.DataPropertyName = "User"
        Me.UserDataGridViewTextBoxColumn.HeaderText = "User"
        Me.UserDataGridViewTextBoxColumn.Name = "UserDataGridViewTextBoxColumn"
        Me.UserDataGridViewTextBoxColumn.ReadOnly = True
        Me.UserDataGridViewTextBoxColumn.Visible = False
        '
        'MealDataGridViewTextBoxColumn
        '
        Me.MealDataGridViewTextBoxColumn.DataPropertyName = "Meal"
        Me.MealDataGridViewTextBoxColumn.HeaderText = "Meal"
        Me.MealDataGridViewTextBoxColumn.Name = "MealDataGridViewTextBoxColumn"
        Me.MealDataGridViewTextBoxColumn.ReadOnly = True
        Me.MealDataGridViewTextBoxColumn.Visible = False
        '
        'EntryDataGridViewTextBoxColumn
        '
        Me.EntryDataGridViewTextBoxColumn.DataPropertyName = "Entry"
        Me.EntryDataGridViewTextBoxColumn.HeaderText = "Entry"
        Me.EntryDataGridViewTextBoxColumn.Name = "EntryDataGridViewTextBoxColumn"
        Me.EntryDataGridViewTextBoxColumn.ReadOnly = True
        '
        'DateDataGridViewTextBoxColumn
        '
        Me.DateDataGridViewTextBoxColumn.DataPropertyName = "Date"
        Me.DateDataGridViewTextBoxColumn.HeaderText = "Date"
        Me.DateDataGridViewTextBoxColumn.Name = "DateDataGridViewTextBoxColumn"
        Me.DateDataGridViewTextBoxColumn.ReadOnly = True
        Me.DateDataGridViewTextBoxColumn.Visible = False
        '
        'DiaryBindingSource
        '
        Me.DiaryBindingSource.DataMember = "Diary"
        Me.DiaryBindingSource.DataSource = Me.Diary
        '
        'Diary
        '
        Me.Diary.DataSetName = "Diary"
        Me.Diary.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(497, 24)
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
        'lblBreakfast
        '
        Me.lblBreakfast.AutoSize = True
        Me.lblBreakfast.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBreakfast.Location = New System.Drawing.Point(21, 97)
        Me.lblBreakfast.Name = "lblBreakfast"
        Me.lblBreakfast.Size = New System.Drawing.Size(74, 16)
        Me.lblBreakfast.TabIndex = 2
        Me.lblBreakfast.Text = "Breakfast"
        '
        'lblLunch
        '
        Me.lblLunch.AutoSize = True
        Me.lblLunch.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLunch.Location = New System.Drawing.Point(296, 97)
        Me.lblLunch.Name = "lblLunch"
        Me.lblLunch.Size = New System.Drawing.Size(48, 16)
        Me.lblLunch.TabIndex = 4
        Me.lblLunch.Text = "Lunch"
        '
        'dgvLunch
        '
        Me.dgvLunch.AllowUserToAddRows = False
        Me.dgvLunch.AllowUserToDeleteRows = False
        Me.dgvLunch.AutoGenerateColumns = False
        Me.dgvLunch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvLunch.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.UserDataGridViewTextBoxColumn1, Me.MealDataGridViewTextBoxColumn1, Me.EntryDataGridViewTextBoxColumn1, Me.DateDataGridViewTextBoxColumn1})
        Me.dgvLunch.DataSource = Me.DiaryBindingSource
        Me.dgvLunch.Location = New System.Drawing.Point(296, 123)
        Me.dgvLunch.Name = "dgvLunch"
        Me.dgvLunch.ReadOnly = True
        Me.dgvLunch.Size = New System.Drawing.Size(147, 44)
        Me.dgvLunch.TabIndex = 3
        '
        'lblSnack
        '
        Me.lblSnack.AutoSize = True
        Me.lblSnack.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSnack.Location = New System.Drawing.Point(294, 198)
        Me.lblSnack.Name = "lblSnack"
        Me.lblSnack.Size = New System.Drawing.Size(51, 16)
        Me.lblSnack.TabIndex = 6
        Me.lblSnack.Text = "Snack"
        '
        'dgvSnack
        '
        Me.dgvSnack.AllowUserToAddRows = False
        Me.dgvSnack.AllowUserToDeleteRows = False
        Me.dgvSnack.AutoGenerateColumns = False
        Me.dgvSnack.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvSnack.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.UserDataGridViewTextBoxColumn3, Me.MealDataGridViewTextBoxColumn3, Me.EntryDataGridViewTextBoxColumn3, Me.DateDataGridViewTextBoxColumn3})
        Me.dgvSnack.DataSource = Me.DiaryBindingSource
        Me.dgvSnack.Location = New System.Drawing.Point(294, 224)
        Me.dgvSnack.Name = "dgvSnack"
        Me.dgvSnack.ReadOnly = True
        Me.dgvSnack.Size = New System.Drawing.Size(147, 44)
        Me.dgvSnack.TabIndex = 5
        '
        'lblDinner
        '
        Me.lblDinner.AutoSize = True
        Me.lblDinner.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDinner.Location = New System.Drawing.Point(21, 198)
        Me.lblDinner.Name = "lblDinner"
        Me.lblDinner.Size = New System.Drawing.Size(53, 16)
        Me.lblDinner.TabIndex = 8
        Me.lblDinner.Text = "Dinner"
        '
        'dgvDinner
        '
        Me.dgvDinner.AllowUserToAddRows = False
        Me.dgvDinner.AllowUserToDeleteRows = False
        Me.dgvDinner.AutoGenerateColumns = False
        Me.dgvDinner.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDinner.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.UserDataGridViewTextBoxColumn2, Me.MealDataGridViewTextBoxColumn2, Me.EntryDataGridViewTextBoxColumn2, Me.DateDataGridViewTextBoxColumn2})
        Me.dgvDinner.DataSource = Me.DiaryBindingSource
        Me.dgvDinner.Location = New System.Drawing.Point(21, 224)
        Me.dgvDinner.Name = "dgvDinner"
        Me.dgvDinner.ReadOnly = True
        Me.dgvDinner.Size = New System.Drawing.Size(147, 44)
        Me.dgvDinner.TabIndex = 7
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(368, 318)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(75, 23)
        Me.btnClose.TabIndex = 9
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'lblName
        '
        Me.lblName.CausesValidation = False
        Me.lblName.Location = New System.Drawing.Point(176, 9)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(143, 23)
        Me.lblName.TabIndex = 10
        '
        'dtpDate
        '
        Me.dtpDate.Location = New System.Drawing.Point(119, 59)
        Me.dtpDate.Name = "dtpDate"
        Me.dtpDate.Size = New System.Drawing.Size(200, 20)
        Me.dtpDate.TabIndex = 12
        '
        'DiaryTableAdapter
        '
        Me.DiaryTableAdapter.ClearBeforeFill = True
        '
        'DiaryBindingSource1
        '
        Me.DiaryBindingSource1.DataMember = "Diary"
        Me.DiaryBindingSource1.DataSource = Me.Diary
        '
        'UserDataGridViewTextBoxColumn1
        '
        Me.UserDataGridViewTextBoxColumn1.DataPropertyName = "User"
        Me.UserDataGridViewTextBoxColumn1.HeaderText = "User"
        Me.UserDataGridViewTextBoxColumn1.Name = "UserDataGridViewTextBoxColumn1"
        Me.UserDataGridViewTextBoxColumn1.ReadOnly = True
        '
        'MealDataGridViewTextBoxColumn1
        '
        Me.MealDataGridViewTextBoxColumn1.DataPropertyName = "Meal"
        Me.MealDataGridViewTextBoxColumn1.HeaderText = "Meal"
        Me.MealDataGridViewTextBoxColumn1.Name = "MealDataGridViewTextBoxColumn1"
        Me.MealDataGridViewTextBoxColumn1.ReadOnly = True
        '
        'EntryDataGridViewTextBoxColumn1
        '
        Me.EntryDataGridViewTextBoxColumn1.DataPropertyName = "Entry"
        Me.EntryDataGridViewTextBoxColumn1.HeaderText = "Entry"
        Me.EntryDataGridViewTextBoxColumn1.Name = "EntryDataGridViewTextBoxColumn1"
        Me.EntryDataGridViewTextBoxColumn1.ReadOnly = True
        '
        'DateDataGridViewTextBoxColumn1
        '
        Me.DateDataGridViewTextBoxColumn1.DataPropertyName = "Date"
        Me.DateDataGridViewTextBoxColumn1.HeaderText = "Date"
        Me.DateDataGridViewTextBoxColumn1.Name = "DateDataGridViewTextBoxColumn1"
        Me.DateDataGridViewTextBoxColumn1.ReadOnly = True
        '
        'UserDataGridViewTextBoxColumn2
        '
        Me.UserDataGridViewTextBoxColumn2.DataPropertyName = "User"
        Me.UserDataGridViewTextBoxColumn2.HeaderText = "User"
        Me.UserDataGridViewTextBoxColumn2.Name = "UserDataGridViewTextBoxColumn2"
        Me.UserDataGridViewTextBoxColumn2.ReadOnly = True
        '
        'MealDataGridViewTextBoxColumn2
        '
        Me.MealDataGridViewTextBoxColumn2.DataPropertyName = "Meal"
        Me.MealDataGridViewTextBoxColumn2.HeaderText = "Meal"
        Me.MealDataGridViewTextBoxColumn2.Name = "MealDataGridViewTextBoxColumn2"
        Me.MealDataGridViewTextBoxColumn2.ReadOnly = True
        '
        'EntryDataGridViewTextBoxColumn2
        '
        Me.EntryDataGridViewTextBoxColumn2.DataPropertyName = "Entry"
        Me.EntryDataGridViewTextBoxColumn2.HeaderText = "Entry"
        Me.EntryDataGridViewTextBoxColumn2.Name = "EntryDataGridViewTextBoxColumn2"
        Me.EntryDataGridViewTextBoxColumn2.ReadOnly = True
        '
        'DateDataGridViewTextBoxColumn2
        '
        Me.DateDataGridViewTextBoxColumn2.DataPropertyName = "Date"
        Me.DateDataGridViewTextBoxColumn2.HeaderText = "Date"
        Me.DateDataGridViewTextBoxColumn2.Name = "DateDataGridViewTextBoxColumn2"
        Me.DateDataGridViewTextBoxColumn2.ReadOnly = True
        '
        'UserDataGridViewTextBoxColumn3
        '
        Me.UserDataGridViewTextBoxColumn3.DataPropertyName = "User"
        Me.UserDataGridViewTextBoxColumn3.HeaderText = "User"
        Me.UserDataGridViewTextBoxColumn3.Name = "UserDataGridViewTextBoxColumn3"
        Me.UserDataGridViewTextBoxColumn3.ReadOnly = True
        '
        'MealDataGridViewTextBoxColumn3
        '
        Me.MealDataGridViewTextBoxColumn3.DataPropertyName = "Meal"
        Me.MealDataGridViewTextBoxColumn3.HeaderText = "Meal"
        Me.MealDataGridViewTextBoxColumn3.Name = "MealDataGridViewTextBoxColumn3"
        Me.MealDataGridViewTextBoxColumn3.ReadOnly = True
        '
        'EntryDataGridViewTextBoxColumn3
        '
        Me.EntryDataGridViewTextBoxColumn3.DataPropertyName = "Entry"
        Me.EntryDataGridViewTextBoxColumn3.HeaderText = "Entry"
        Me.EntryDataGridViewTextBoxColumn3.Name = "EntryDataGridViewTextBoxColumn3"
        Me.EntryDataGridViewTextBoxColumn3.ReadOnly = True
        '
        'DateDataGridViewTextBoxColumn3
        '
        Me.DateDataGridViewTextBoxColumn3.DataPropertyName = "Date"
        Me.DateDataGridViewTextBoxColumn3.HeaderText = "Date"
        Me.DateDataGridViewTextBoxColumn3.Name = "DateDataGridViewTextBoxColumn3"
        Me.DateDataGridViewTextBoxColumn3.ReadOnly = True
        '
        'frmDiary
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(497, 354)
        Me.Controls.Add(Me.dtpDate)
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.lblDinner)
        Me.Controls.Add(Me.dgvDinner)
        Me.Controls.Add(Me.lblSnack)
        Me.Controls.Add(Me.dgvSnack)
        Me.Controls.Add(Me.lblLunch)
        Me.Controls.Add(Me.dgvLunch)
        Me.Controls.Add(Me.lblBreakfast)
        Me.Controls.Add(Me.dgvBreakfast)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmDiary"
        Me.Text = "Diary"
        CType(Me.dgvBreakfast, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DiaryBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Diary, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.dgvLunch, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvSnack, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvDinner, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DiaryBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgvBreakfast As DataGridView
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents lblBreakfast As Label
    Friend WithEvents lblLunch As Label
    Friend WithEvents dgvLunch As DataGridView
    Friend WithEvents lblSnack As Label
    Friend WithEvents dgvSnack As DataGridView
    Friend WithEvents lblDinner As Label
    Friend WithEvents dgvDinner As DataGridView
    Friend WithEvents btnClose As Button
    Friend WithEvents lblName As Label
    Friend WithEvents dtpDate As DateTimePicker
    Friend WithEvents Diary As Diary
    Friend WithEvents DiaryBindingSource As BindingSource
    Friend WithEvents DiaryTableAdapter As DiaryTableAdapters.DiaryTableAdapter
    Friend WithEvents UserDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MealDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EntryDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DateDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents UserDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents MealDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents EntryDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DateDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents UserDataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents MealDataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents EntryDataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DateDataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents UserDataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents MealDataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents EntryDataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DateDataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DiaryBindingSource1 As BindingSource
End Class
