Imports System.Data.SqlClient
Public Class SignIn
    Dim connectionString As String = "Data Source=HEHE\SQLEXPRESS;Initial Catalog=QLThuVien;Integrated Security=True"
    Private Sub lblExit_Click(sender As Object, e As EventArgs) Handles lblExit.Click
        Dim result As DialogResult = MessageBox.Show("Bạn có chắc chắn muốn thoát chương trình không ?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If result = DialogResult.Yes Then
            End
        End If
    End Sub

    Private Sub lblSignUp_Click(sender As Object, e As EventArgs) Handles lblSignUp.Click
        Me.Hide()
        SignUp.Show()
    End Sub

    Private Sub lblForget_Click(sender As Object, e As EventArgs) Handles lblForget.Click
        Me.Hide()
        ResetPass.Show()
    End Sub
    Private Function isTKvalid(tk As String) As Boolean
        Return True
    End Function
    Private Function isTKexist(tk As String, mk As String) As Boolean
        Using connection As New SqlConnection(connectionString)
            connection.Open()

            Dim querry As String = "SELECT COUNT (*) FROM DANGNHAP Where TK = @tk and MK = @mk"
            Dim command As New SqlCommand(querry, connection)
            command.Parameters.AddWithValue("@tk", tk)
            command.Parameters.AddWithValue("@mk", mk)

            Dim count As Integer = Convert.ToInt32(command.ExecuteScalar())
            Return count > 0
        End Using
    End Function

    Private Sub btnSignUp_Click(sender As Object, e As EventArgs) Handles btnSignUp.Click
        Dim TK As String = txtTK.Text.Trim()
        Dim MK As String = txtMK.Text.Trim()

        If isTKvalid(TK) Then
            If (isTKexist(TK, MK)) Then
                Me.Hide()
                QLThuVien.Show()
            Else
                MsgBox("Sai tài khoản hoặc mật khẩu !")
            End If

        End If
    End Sub

    Private Sub SignIn_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtTK.Focus()
    End Sub
End Class
