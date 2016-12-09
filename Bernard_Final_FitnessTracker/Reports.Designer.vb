<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Reports
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.DiaryBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Diary = New Bernard_Final_FitnessTracker.Diary()
        Me.DiaryTableAdapter = New Bernard_Final_FitnessTracker.DiaryTableAdapters.DiaryTableAdapter()
        CType(Me.DiaryBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Diary, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        'DiaryTableAdapter
        '
        Me.DiaryTableAdapter.ClearBeforeFill = True
        '
        'Reports
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(816, 480)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Reports"
        Me.Text = "Reports"
        CType(Me.DiaryBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Diary, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DiaryBindingSource As BindingSource
    Friend WithEvents Diary As Diary
    Friend WithEvents DiaryTableAdapter As DiaryTableAdapters.DiaryTableAdapter
End Class
