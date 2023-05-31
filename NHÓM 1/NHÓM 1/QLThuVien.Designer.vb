<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class QLThuVien
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
        Me.QLThuVienDataSet1 = New NHÓM_1.QLThuVienDataSet1()
        Me.DocgiaTableAdapter1 = New NHÓM_1.QLThuVienDataSet1TableAdapters.DocgiaTableAdapter()
        Me.DocgiaBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label7 = New System.Windows.Forms.Label()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.NgaySinhPicker = New System.Windows.Forms.DateTimePicker()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.txtDienThoai = New System.Windows.Forms.TextBox()
        Me.txtDiaChi = New System.Windows.Forms.TextBox()
        Me.cbbGioiTinh = New System.Windows.Forms.ComboBox()
        Me.txtHoTen = New System.Windows.Forms.TextBox()
        Me.txtMaKH = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblExit = New System.Windows.Forms.Label()
        Me.lblLogOut = New System.Windows.Forms.Label()
        Me.lblUpdate = New System.Windows.Forms.Label()
        Me.lblSearch = New System.Windows.Forms.Label()
        Me.lblDelete = New System.Windows.Forms.Label()
        Me.lblAdd = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.MaDGDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TenDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GioiTinhDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SDTDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NgaySinhDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DiachiDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EmailDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        CType(Me.QLThuVienDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DocgiaBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'QLThuVienDataSet1
        '
        Me.QLThuVienDataSet1.DataSetName = "QLThuVienDataSet1"
        Me.QLThuVienDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DocgiaTableAdapter1
        '
        Me.DocgiaTableAdapter1.ClearBeforeFill = True
        '
        'DocgiaBindingSource1
        '
        Me.DocgiaBindingSource1.DataMember = "Docgia"
        Me.DocgiaBindingSource1.DataSource = Me.QLThuVienDataSet1
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.Info
        Me.Label7.Location = New System.Drawing.Point(454, 307)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(177, 25)
        Me.Label7.TabIndex = 102
        Me.Label7.Text = "Quản Lý Độc Giả"
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.btnSave.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSave.Location = New System.Drawing.Point(440, 381)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(59, 100)
        Me.btnSave.TabIndex = 101
        Me.btnSave.Text = "Lưu"
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'NgaySinhPicker
        '
        Me.NgaySinhPicker.Location = New System.Drawing.Point(899, 381)
        Me.NgaySinhPicker.Name = "NgaySinhPicker"
        Me.NgaySinhPicker.Size = New System.Drawing.Size(131, 22)
        Me.NgaySinhPicker.TabIndex = 100
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(459, 24)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(200, 22)
        Me.DateTimePicker1.TabIndex = 99
        '
        'txtDienThoai
        '
        Me.txtDienThoai.Location = New System.Drawing.Point(722, 459)
        Me.txtDienThoai.Name = "txtDienThoai"
        Me.txtDienThoai.Size = New System.Drawing.Size(131, 22)
        Me.txtDienThoai.TabIndex = 98
        '
        'txtDiaChi
        '
        Me.txtDiaChi.Location = New System.Drawing.Point(899, 453)
        Me.txtDiaChi.Name = "txtDiaChi"
        Me.txtDiaChi.Size = New System.Drawing.Size(131, 22)
        Me.txtDiaChi.TabIndex = 97
        '
        'cbbGioiTinh
        '
        Me.cbbGioiTinh.FormattingEnabled = True
        Me.cbbGioiTinh.Items.AddRange(New Object() {"Nam", "Nữ", "Khác"})
        Me.cbbGioiTinh.Location = New System.Drawing.Point(722, 385)
        Me.cbbGioiTinh.Name = "cbbGioiTinh"
        Me.cbbGioiTinh.Size = New System.Drawing.Size(131, 24)
        Me.cbbGioiTinh.TabIndex = 96
        '
        'txtHoTen
        '
        Me.txtHoTen.Location = New System.Drawing.Point(555, 457)
        Me.txtHoTen.Name = "txtHoTen"
        Me.txtHoTen.Size = New System.Drawing.Size(131, 22)
        Me.txtHoTen.TabIndex = 95
        '
        'txtMaKH
        '
        Me.txtMaKH.Location = New System.Drawing.Point(555, 381)
        Me.txtMaKH.Name = "txtMaKH"
        Me.txtMaKH.Size = New System.Drawing.Size(131, 22)
        Me.txtMaKH.TabIndex = 94
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(719, 434)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(75, 16)
        Me.Label6.TabIndex = 93
        Me.Label6.Text = "Điện Thoại:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(896, 434)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(52, 16)
        Me.Label5.TabIndex = 92
        Me.Label5.Text = "Địa Chỉ:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(719, 362)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(63, 16)
        Me.Label4.TabIndex = 91
        Me.Label4.Text = "Giới Tính:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(896, 362)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(72, 16)
        Me.Label3.TabIndex = 90
        Me.Label3.Text = "Ngày Sinh:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(554, 434)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(52, 16)
        Me.Label2.TabIndex = 89
        Me.Label2.Text = "Họ Tên"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(552, 362)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(52, 16)
        Me.Label1.TabIndex = 88
        Me.Label1.Text = "Mã DG:"
        '
        'lblExit
        '
        Me.lblExit.AutoSize = True
        Me.lblExit.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.lblExit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblExit.Location = New System.Drawing.Point(234, 457)
        Me.lblExit.Name = "lblExit"
        Me.lblExit.Size = New System.Drawing.Size(51, 20)
        Me.lblExit.TabIndex = 87
        Me.lblExit.Text = "Thoát"
        '
        'lblLogOut
        '
        Me.lblLogOut.AutoSize = True
        Me.lblLogOut.BackColor = System.Drawing.Color.Red
        Me.lblLogOut.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblLogOut.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLogOut.Location = New System.Drawing.Point(321, 383)
        Me.lblLogOut.Name = "lblLogOut"
        Me.lblLogOut.Size = New System.Drawing.Size(87, 20)
        Me.lblLogOut.TabIndex = 86
        Me.lblLogOut.Text = "Đăng Xuất"
        '
        'lblUpdate
        '
        Me.lblUpdate.AutoSize = True
        Me.lblUpdate.BackColor = System.Drawing.Color.Orange
        Me.lblUpdate.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblUpdate.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUpdate.Location = New System.Drawing.Point(321, 457)
        Me.lblUpdate.Name = "lblUpdate"
        Me.lblUpdate.Size = New System.Drawing.Size(86, 20)
        Me.lblUpdate.TabIndex = 85
        Me.lblUpdate.Text = "Chỉnh Sửa"
        '
        'lblSearch
        '
        Me.lblSearch.AutoSize = True
        Me.lblSearch.BackColor = System.Drawing.Color.Aqua
        Me.lblSearch.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSearch.Location = New System.Drawing.Point(132, 459)
        Me.lblSearch.Name = "lblSearch"
        Me.lblSearch.Size = New System.Drawing.Size(80, 20)
        Me.lblSearch.TabIndex = 84
        Me.lblSearch.Text = "Tìm Kiếm"
        '
        'lblDelete
        '
        Me.lblDelete.AutoSize = True
        Me.lblDelete.BackColor = System.Drawing.Color.Yellow
        Me.lblDelete.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblDelete.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDelete.Location = New System.Drawing.Point(247, 381)
        Me.lblDelete.Name = "lblDelete"
        Me.lblDelete.Size = New System.Drawing.Size(38, 20)
        Me.lblDelete.TabIndex = 83
        Me.lblDelete.Text = "Xóa"
        '
        'lblAdd
        '
        Me.lblAdd.AutoSize = True
        Me.lblAdd.BackColor = System.Drawing.Color.GreenYellow
        Me.lblAdd.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblAdd.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAdd.Location = New System.Drawing.Point(142, 383)
        Me.lblAdd.Name = "lblAdd"
        Me.lblAdd.Size = New System.Drawing.Size(51, 20)
        Me.lblAdd.TabIndex = 82
        Me.lblAdd.Text = "Thêm"
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.MaDGDataGridViewTextBoxColumn, Me.TenDataGridViewTextBoxColumn, Me.GioiTinhDataGridViewTextBoxColumn, Me.SDTDataGridViewTextBoxColumn, Me.NgaySinhDataGridViewTextBoxColumn, Me.DiachiDataGridViewTextBoxColumn, Me.EmailDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.DocgiaBindingSource1
        Me.DataGridView1.Location = New System.Drawing.Point(103, 52)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(938, 236)
        Me.DataGridView1.TabIndex = 103
        '
        'MaDGDataGridViewTextBoxColumn
        '
        Me.MaDGDataGridViewTextBoxColumn.DataPropertyName = "MaDG"
        Me.MaDGDataGridViewTextBoxColumn.HeaderText = "MaDG"
        Me.MaDGDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.MaDGDataGridViewTextBoxColumn.Name = "MaDGDataGridViewTextBoxColumn"
        Me.MaDGDataGridViewTextBoxColumn.Width = 125
        '
        'TenDataGridViewTextBoxColumn
        '
        Me.TenDataGridViewTextBoxColumn.DataPropertyName = "Ten"
        Me.TenDataGridViewTextBoxColumn.HeaderText = "Ten"
        Me.TenDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.TenDataGridViewTextBoxColumn.Name = "TenDataGridViewTextBoxColumn"
        Me.TenDataGridViewTextBoxColumn.Width = 125
        '
        'GioiTinhDataGridViewTextBoxColumn
        '
        Me.GioiTinhDataGridViewTextBoxColumn.DataPropertyName = "GioiTinh"
        Me.GioiTinhDataGridViewTextBoxColumn.HeaderText = "GioiTinh"
        Me.GioiTinhDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.GioiTinhDataGridViewTextBoxColumn.Name = "GioiTinhDataGridViewTextBoxColumn"
        Me.GioiTinhDataGridViewTextBoxColumn.Width = 125
        '
        'SDTDataGridViewTextBoxColumn
        '
        Me.SDTDataGridViewTextBoxColumn.DataPropertyName = "SDT"
        Me.SDTDataGridViewTextBoxColumn.HeaderText = "SDT"
        Me.SDTDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.SDTDataGridViewTextBoxColumn.Name = "SDTDataGridViewTextBoxColumn"
        Me.SDTDataGridViewTextBoxColumn.Width = 125
        '
        'NgaySinhDataGridViewTextBoxColumn
        '
        Me.NgaySinhDataGridViewTextBoxColumn.DataPropertyName = "NgaySinh"
        Me.NgaySinhDataGridViewTextBoxColumn.HeaderText = "NgaySinh"
        Me.NgaySinhDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.NgaySinhDataGridViewTextBoxColumn.Name = "NgaySinhDataGridViewTextBoxColumn"
        Me.NgaySinhDataGridViewTextBoxColumn.Width = 125
        '
        'DiachiDataGridViewTextBoxColumn
        '
        Me.DiachiDataGridViewTextBoxColumn.DataPropertyName = "Diachi"
        Me.DiachiDataGridViewTextBoxColumn.HeaderText = "Diachi"
        Me.DiachiDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.DiachiDataGridViewTextBoxColumn.Name = "DiachiDataGridViewTextBoxColumn"
        Me.DiachiDataGridViewTextBoxColumn.Width = 125
        '
        'EmailDataGridViewTextBoxColumn
        '
        Me.EmailDataGridViewTextBoxColumn.DataPropertyName = "Email"
        Me.EmailDataGridViewTextBoxColumn.HeaderText = "Email"
        Me.EmailDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.EmailDataGridViewTextBoxColumn.Name = "EmailDataGridViewTextBoxColumn"
        Me.EmailDataGridViewTextBoxColumn.Width = 125
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(695, 508)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(44, 16)
        Me.Label8.TabIndex = 104
        Me.Label8.Text = "Email:"
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(745, 505)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(131, 22)
        Me.txtEmail.TabIndex = 106
        '
        'QLThuVien
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1173, 550)
        Me.Controls.Add(Me.txtEmail)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.NgaySinhPicker)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.txtDienThoai)
        Me.Controls.Add(Me.txtDiaChi)
        Me.Controls.Add(Me.cbbGioiTinh)
        Me.Controls.Add(Me.txtHoTen)
        Me.Controls.Add(Me.txtMaKH)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblExit)
        Me.Controls.Add(Me.lblLogOut)
        Me.Controls.Add(Me.lblUpdate)
        Me.Controls.Add(Me.lblSearch)
        Me.Controls.Add(Me.lblDelete)
        Me.Controls.Add(Me.lblAdd)
        Me.Name = "QLThuVien"
        Me.Text = "QLThuVien"
        CType(Me.QLThuVienDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DocgiaBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents QLThuVienDataSet1 As QLThuVienDataSet1
    Friend WithEvents DocgiaTableAdapter1 As QLThuVienDataSet1TableAdapters.DocgiaTableAdapter
    Friend WithEvents DocgiaBindingSource1 As BindingSource
    Friend WithEvents Label7 As Label
    Friend WithEvents btnSave As Button
    Friend WithEvents NgaySinhPicker As DateTimePicker
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents txtDienThoai As TextBox
    Friend WithEvents txtDiaChi As TextBox
    Friend WithEvents cbbGioiTinh As ComboBox
    Friend WithEvents txtHoTen As TextBox
    Friend WithEvents txtMaKH As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents lblExit As Label
    Friend WithEvents lblLogOut As Label
    Friend WithEvents lblUpdate As Label
    Friend WithEvents lblSearch As Label
    Friend WithEvents lblDelete As Label
    Friend WithEvents lblAdd As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Label8 As Label
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents MaDGDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TenDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents GioiTinhDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SDTDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NgaySinhDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DiachiDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EmailDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
