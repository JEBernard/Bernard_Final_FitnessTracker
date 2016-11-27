<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLogin
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
        Me.txtLoginPassword = New System.Windows.Forms.TextBox()
        Me.txtLoginUsername = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnLogin = New System.Windows.Forms.Button()
        Me.Register = New System.Windows.Forms.TabPage()
        Me.txtRegPassword = New System.Windows.Forms.TextBox()
        Me.txtRegUsername = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnRegister = New System.Windows.Forms.Button()
        Me.TabControl1.SuspendLayout()
        Me.Login.SuspendLayout()
        Me.Register.SuspendLayout()
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
        Me.Login.Controls.Add(Me.txtLoginPassword)
        Me.Login.Controls.Add(Me.txtLoginUsername)
        Me.Login.Controls.Add(Me.Label3)
        Me.Login.Controls.Add(Me.Label4)
        Me.Login.Controls.Add(Me.btnLogin)
        Me.Login.Location = New System.Drawing.Point(4, 22)
        Me.Login.Name = "Login"
        Me.Login.Padding = New System.Windows.Forms.Padding(3)
        Me.Login.Size = New System.Drawing.Size(413, 251)
        Me.Login.TabIndex = 0
        Me.Login.Text = "Login"
        Me.Login.UseVisualStyleBackColor = True
        '
        'txtLoginPassword
        '
        Me.txtLoginPassword.Location = New System.Drawing.Point(115, 95)
        Me.txtLoginPassword.Name = "txtLoginPassword"
        Me.txtLoginPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtLoginPassword.Size = New System.Drawing.Size(188, 20)
        Me.txtLoginPassword.TabIndex = 9
        '
        'txtLoginUsername
        '
        Me.txtLoginUsername.Location = New System.Drawing.Point(115, 49)
        Me.txtLoginUsername.Name = "txtLoginUsername"
        Me.txtLoginUsername.Size = New System.Drawing.Size(188, 20)
        Me.txtLoginUsername.TabIndex = 8
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(35, 98)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(56, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Password:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(35, 51)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(58, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Username:"
        '
        'btnLogin
        '
        Me.btnLogin.Location = New System.Drawing.Point(284, 203)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.Size = New System.Drawing.Size(103, 25)
        Me.btnLogin.TabIndex = 0
        Me.btnLogin.Text = "Login"
        Me.btnLogin.UseVisualStyleBackColor = True
        '
        'Register
        '
        Me.Register.Controls.Add(Me.txtRegPassword)
        Me.Register.Controls.Add(Me.txtRegUsername)
        Me.Register.Controls.Add(Me.Label2)
        Me.Register.Controls.Add(Me.Label1)
        Me.Register.Controls.Add(Me.btnRegister)
        Me.Register.Location = New System.Drawing.Point(4, 22)
        Me.Register.Name = "Register"
        Me.Register.Padding = New System.Windows.Forms.Padding(3)
        Me.Register.Size = New System.Drawing.Size(413, 251)
        Me.Register.TabIndex = 1
        Me.Register.Text = "Register"
        Me.Register.UseVisualStyleBackColor = True
        '
        'txtRegPassword
        '
        Me.txtRegPassword.Location = New System.Drawing.Point(106, 91)
        Me.txtRegPassword.Name = "txtRegPassword"
        Me.txtRegPassword.Size = New System.Drawing.Size(188, 20)
        Me.txtRegPassword.TabIndex = 5
        '
        'txtRegUsername
        '
        Me.txtRegUsername.Location = New System.Drawing.Point(106, 45)
        Me.txtRegUsername.Name = "txtRegUsername"
        Me.txtRegUsername.Size = New System.Drawing.Size(188, 20)
        Me.txtRegUsername.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(26, 94)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Password:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(26, 47)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(58, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Username:"
        '
        'btnRegister
        '
        Me.btnRegister.Location = New System.Drawing.Point(294, 204)
        Me.btnRegister.Name = "btnRegister"
        Me.btnRegister.Size = New System.Drawing.Size(103, 25)
        Me.btnRegister.TabIndex = 1
        Me.btnRegister.Text = "Register"
        Me.btnRegister.UseVisualStyleBackColor = True
        '
        'frmLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(468, 323)
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "frmLogin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Fitness Tracker"
        Me.TabControl1.ResumeLayout(False)
        Me.Login.ResumeLayout(False)
        Me.Login.PerformLayout()
        Me.Register.ResumeLayout(False)
        Me.Register.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents Login As TabPage
    Friend WithEvents Register As TabPage
    Friend WithEvents txtLoginPassword As TextBox
    Friend WithEvents txtLoginUsername As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents btnLogin As Button
    Friend WithEvents txtRegPassword As TextBox
    Friend WithEvents txtRegUsername As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btnRegister As Button
End Class
