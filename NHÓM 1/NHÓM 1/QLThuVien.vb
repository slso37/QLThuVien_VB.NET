Imports System.Data.SqlClient
Public Class QLThuVien
    Dim connectionString As String = "Data Source=HEHE\SQLEXPRESS;Initial Catalog=QLThuVien;Integrated Security=True"

    Private Function clear_infomation()
        txtMaKH.Clear()
        txtHoTen.Clear()
        txtEmail.Clear()
        txtDienThoai.Clear()
        txtDiaChi.Clear()
        cbbGioiTinh.ResetText()
        NgaySinhPicker.ResetText()
    End Function
    Private Sub lblAdd_Click(sender As Object, e As EventArgs) Handles lblAdd.Click
        Using connection As New SqlConnection(connectionString)
            connection.Open()

            Dim query As String = "INSERT INTO [Docgia] ([MaDG], [Ten], [GioiTinh], [SDT], [NgaySinh], [DiaChi], [Email]) VALUES (@MaDG, @Ten, @GioiTinh, @SDT, @NgaySinh, @DiaChi, @Email)"

            Using command As New SqlCommand(query, connection)
                command.Parameters.AddWithValue("@MaDG", txtMaKH.Text)
                command.Parameters.AddWithValue("@Ten", txtHoTen.Text)
                command.Parameters.AddWithValue("@NgaySinh", NgaySinhPicker.Value)
                command.Parameters.AddWithValue("@GioiTinh", cbbGioiTinh.Text)
                command.Parameters.AddWithValue("@DiaChi", txtDiaChi.Text)
                command.Parameters.AddWithValue("@SDT", txtDienThoai.Text)
                command.Parameters.AddWithValue("@Email", txtEmail.Text)

                command.ExecuteNonQuery()
            End Using

            clear_infomation()
        End Using

        ' Refresh data after adding a new record
        Me.DocgiaTableAdapter1.Fill(Me.QLThuVienDataSet1.Docgia)


    End Sub

    Private Sub lblExit_Click(sender As Object, e As EventArgs) Handles lblExit.Click
        End
    End Sub

    Private Sub lblLogOut_Click(sender As Object, e As EventArgs) Handles lblLogOut.Click
        Me.Hide()
        SignIn.Show()
    End Sub

    Private Sub lblDelete_Click(sender As Object, e As EventArgs) Handles lblDelete.Click
        Dim result As DialogResult = MessageBox.Show("Bạn có chắc chắn muốn xóa khách hàng này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If result = DialogResult.Yes Then
            Using connection As New SqlConnection(connectionString)
                connection.Open()

                Dim query As String = "DELETE FROM [Docgia] WHERE MaDG = @MaKH"

                Using command As New SqlCommand(query, connection)
                    command.Parameters.AddWithValue("@MaKH", txtMaKH.Text)

                    command.ExecuteNonQuery()
                End Using
            End Using

            ' Refresh data after deleting a record
            Me.DocgiaTableAdapter1.Fill(Me.QLThuVienDataSet1.Docgia)
        End If
    End Sub

    Private Sub lblUpdate_Click(sender As Object, e As EventArgs) Handles lblUpdate.Click
        Dim search As String = InputBox("Nhập mã khách bạn muốn cập nhật vào đây", "Cập nhật")

        ' Kiểm tra xem mã khách hàng đã được nhập hay chưa
        If Not String.IsNullOrEmpty(search) Then

            Using connection As New SqlConnection(connectionString)
                connection.Open()

                Dim query As String = "SELECT * FROM [Docgia] WHERE MaDG = @MaKH"

                Using command As New SqlCommand(query, connection)
                    command.Parameters.AddWithValue("@MaKH", search)

                    Using reader As SqlDataReader = command.ExecuteReader()
                        ' Kiểm tra xem có dữ liệu trả về hay không
                        If reader.Read() Then
                            ' Hiển thị thông tin khách hàng lên các điều khiển TextBox
                            txtMaKH.Text = reader("MaDG").ToString()
                            txtHoTen.Text = reader("Ten").ToString()
                            cbbGioiTinh.Text = reader("GioiTinh").ToString()
                            txtDiaChi.Text = reader("Diachi").ToString()
                            txtDienThoai.Text = reader("SDT").ToString()
                            txtEmail.Text = reader("Email").ToString()
                            btnSave.Visible = True
                        Else
                            MessageBox.Show("Không tìm thấy độc giả với mã đã nhập.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        End If
                    End Using
                End Using
            End Using
            ' Refresh data after deleting a record
            Me.DocgiaTableAdapter1.Fill(Me.QLThuVienDataSet1.Docgia)
        End If
    End Sub


    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim queryString As String = "UPDATE [Docgia] SET MaDG = @MaDG, Ten = @Ten, GioiTinh = @GioiTinh, SDT = @SDT, NgaySinh = @NgaySinh, email = @email, DiaChi = @DiaChi WHERE MaDG = @MaDG"

        Using connection As New SqlConnection(connectionString)
            Dim command As New SqlCommand(queryString, connection)
            command.Parameters.AddWithValue("@MaDG", txtMaKH.Text)
            command.Parameters.AddWithValue("@Ten", txtHoTen.Text)
            command.Parameters.AddWithValue("@GioiTinh", cbbGioiTinh.Text)
            command.Parameters.AddWithValue("@SDT", txtDienThoai.Text)
            command.Parameters.AddWithValue("@NgaySinh", NgaySinhPicker.Value)
            command.Parameters.AddWithValue("@email", txtEmail.Text)
            command.Parameters.AddWithValue("@DiaChi", txtDiaChi.Text)

            connection.Open()
            Dim rowsAffected As Integer = command.ExecuteNonQuery()
        End Using

        clear_infomation()
        btnSave.Visible = False
        Me.DocgiaTableAdapter1.Fill(Me.QLThuVienDataSet1.Docgia)
    End Sub

    Private Sub QLThuVien_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'QLYBHDataSet.tblKhachHang' table. You can move, or remove it, as needed.
        Me.DocgiaTableAdapter1.Fill(Me.QLThuVienDataSet1.Docgia)
        btnSave.Visible = False
    End Sub

    Private Sub lblSearch_Click(sender As Object, e As EventArgs) Handles lblSearch.Click
        Dim search As String = InputBox("Nhập mã khách bạn muốn tìm kiếm vào đây", "Tìm kiếm")

        ' Kiểm tra xem mã khách hàng đã được nhập hay chưa
        If Not String.IsNullOrEmpty(search) Then

            Using connection As New SqlConnection(connectionString)
                connection.Open()

                Dim query As String = "SELECT * FROM [Docgia] WHERE MaDG = @MaKH"

                Using command As New SqlCommand(query, connection)
                    command.Parameters.AddWithValue("@MaKH", search)

                    Using reader As SqlDataReader = command.ExecuteReader()
                        ' Kiểm tra xem có dữ liệu trả về hay không
                        If reader.Read() Then
                            ' Hiển thị thông tin khách hàng lên các điều khiển TextBox
                            txtMaKH.Text = reader("MaDG").ToString()
                            txtHoTen.Text = reader("Ten").ToString()
                            cbbGioiTinh.Text = reader("GioiTinh").ToString()
                            txtDiaChi.Text = reader("Diachi").ToString()
                            txtDienThoai.Text = reader("SDT").ToString()
                            txtEmail.Text = reader("Email").ToString()
                        Else
                            MessageBox.Show("Không tìm thấy độc giả với mã đã nhập.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        End If
                    End Using
                End Using
            End Using
            ' Refresh data after deleting a record
            Me.DocgiaTableAdapter1.Fill(Me.QLThuVienDataSet1.Docgia)
        End If
    End Sub
End Class

