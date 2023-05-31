Imports System.Data.SqlClient
Public Class SignUp

    Dim connectionString As String = "Data Source=HEHE\SQLEXPRESS;Initial Catalog=QLThuVien;Integrated Security=True"
    Private Sub lblSignIn_Click(sender As Object, e As EventArgs) Handles lblSignIn.Click
        Me.Hide()
        SignIn.Show()
    End Sub

    Private Sub lblExit_Click(sender As Object, e As EventArgs) Handles lblExit.Click
        Dim result As DialogResult = MessageBox.Show("Bạn có chắc chắn muốn thoát chương trình không ?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If result = DialogResult.Yes Then
            End
        End If
    End Sub

    Private Function clear_information()
        txtMK.Clear()
        txtReMK.Clear()
        txtTK.Clear()
    End Function
    Private Sub btnSignUp_Click(sender As Object, e As EventArgs) Handles btnSignUp.Click
        If txtReMK.Text = txtMK.Text Then
            Using connection As New SqlConnection(connectionString)
                connection.Open()

                Dim query As String = "INSERT INTO [DANGNHAP] ([TK], [MK]) VALUES (@TenDN, @MatKhau)"

                Using command As New SqlCommand(query, connection)
                    command.Parameters.AddWithValue("@TenDN", txtTK.Text)
                    command.Parameters.AddWithValue("@MatKhau", txtMK.Text)

                    command.ExecuteNonQuery()
                End Using
            End Using
            clear_information()
            MsgBox("Thêm tài khoản thành công !!")
        Else
            MsgBox("Mật khẩu nhập lại không trùng !!")
            txtReMK.Clear()
            txtReMK.Focus()
        End If
    End Sub

    Private Sub SignUp_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtTK.Focus()
    End Sub
End Class