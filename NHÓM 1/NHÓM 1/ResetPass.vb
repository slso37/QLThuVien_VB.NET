Imports System.Data.SqlClient
Public Class ResetPass

    Dim connectionString As String = "Data Source=HEHE\SQLEXPRESS;Initial Catalog=QLThuVien;Integrated Security=True"
    Private Sub lblExit_Click(sender As Object, e As EventArgs) Handles lblExit.Click
        Dim result As DialogResult = MessageBox.Show("Bạn có chắc chắn muốn thoát chương trình không ?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If result = DialogResult.Yes Then
            End
        End If
    End Sub

    Private Sub lblSignIn_Click(sender As Object, e As EventArgs) Handles lblSignIn.Click
        Me.Hide()
        SignIn.Show()
    End Sub

    Private Sub lblSignUp_Click(sender As Object, e As EventArgs) Handles lblSignUp.Click
        Me.Hide()
        SignUp.Show()
    End Sub

    Private Sub ResetPass_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtTK.Focus()
    End Sub

    Private Function isTKvalid(tk As String) As Boolean
        Return True
    End Function
    Private Function isTKexist(tk As String) As Boolean
        Using connection As New SqlConnection(connectionString)
            connection.Open()

            Dim querry As String = "SELECT COUNT (*) FROM DANGNHAP Where TK = @tk"
            Dim command As New SqlCommand(querry, connection)
            command.Parameters.AddWithValue("@tk", tk)

            Dim count As Integer = Convert.ToInt32(command.ExecuteScalar())
            Return count > 0
        End Using
    End Function
    Private Sub lblResetPass_Click(sender As Object, e As EventArgs) Handles lblResetPass.Click
        If isTKvalid(txtTK.Text) Then
            If isTKexist(txtTK.Text) Then
                Using connection As New SqlConnection(connectionString)
                    connection.Open()

                    Dim query As String = "UPDATE [DANGNHAP] SET MK = @MatKhau WHERE TK = @tk"

                    Using command As New SqlCommand(query, connection)
                        command.Parameters.AddWithValue("@MatKhau", txtMKmoi.Text)
                        command.Parameters.AddWithValue("@tk", txtTK.Text)

                        command.ExecuteNonQuery()

                        MsgBox("Mật khẩu đã được cập nhật thành công!")
                        txtMKmoi.Clear()
                        txtReMKmoi.Clear()
                        txtTK.Clear()
                        txtTK.Focus()
                    End Using
                End Using
            Else
                MsgBox("Không tồn tại tài khoản !")

            End If
        End If
    End Sub
End Class