<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.Login = New System.Windows.Forms.TabPage()
        Me.Register = New System.Windows.Forms.TabPage()
        Me.TabControl1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.Login)
        Me.TabControl1.Controls.Add(Me.Register)
        Me.TabControl1.Location = New System.Drawing.Point(12, 21)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(421, 277)
        Me.TabControl1.TabIndex = 0
        Me.TabControl1.TabStop = False
        '
        'Login
        '
        Me.Login.Location = New System.Drawing.Point(4, 22)
        Me.Login.Name = "Login"
        Me.Login.Padding = New System.Windows.Forms.Padding(3)
        Me.Login.Size = New System.Drawing.Size(413, 251)
        Me.Login.TabIndex = 0
        Me.Login.Text = "Login"
        Me.Login.UseVisualStyleBackColor = True
        '
        'Register
        '
        Me.Register.Location = New System.Drawing.Point(4, 22)
        Me.Register.Name = "Register"
        Me.Register.Padding = New System.Windows.Forms.Padding(3)
        Me.Register.Size = New System.Drawing.Size(413, 251)
        Me.Register.TabIndex = 1
        Me.Register.Text = "Register"
        Me.Register.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(468, 323)
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.TabControl1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents Login As TabPage
    Friend WithEvents Register As TabPage
End Class
