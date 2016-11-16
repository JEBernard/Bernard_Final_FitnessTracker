Public Class frmLogin
    'Login and Register tabs
    Dim users As New Dictionary(Of String, String)

    Private Sub frmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        users.Add("Jason", "Password")
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click

        Dim password As String = txtRegPassword.Text
        If (users.TryGetValue(txtLoginUsername.Text, password) AndAlso password = txtLoginPassword.Text) Then
            MessageBox.Show("Login successful")

            'Launch Profile form
            Profile.ShowDialog()
            Me.Close()
        Else
            MessageBox.Show("Invalid Username/Password")
        End If
    End Sub

    Private Sub btnRegister_Click(sender As Object, e As EventArgs) Handles btnRegister.Click

        Dim password As String = txtRegPassword.Text
        If (users.TryGetValue(txtRegUsername.Text, txtRegPassword.Text)) Then
            MessageBox.Show("Username already exists please use the login screen")
        Else
            users.Add(txtRegUsername.Text, password)
            MessageBox.Show("User has been registered successfully")
        End If

    End Sub
End Class