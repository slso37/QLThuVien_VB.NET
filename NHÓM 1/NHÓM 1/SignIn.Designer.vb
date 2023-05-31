<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SignIn
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
        Me.lblForget = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lblSignUp = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtMK = New System.Windows.Forms.TextBox()
        Me.txtTK = New System.Windows.Forms.TextBox()
        Me.lblExit = New System.Windows.Forms.Label()
        Me.btnSignUp = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblForget
        '
        Me.lblForget.AutoSize = True
        Me.lblForget.BackColor = System.Drawing.SystemColors.Highlight
        Me.lblForget.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblForget.Font = New System.Drawing.Font("Microsoft Tai Le", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblForget.Location = New System.Drawing.Point(113, 179)
        Me.lblForget.Name = "lblForget"
        Me.lblForget.Size = New System.Drawing.Size(107, 16)
        Me.lblForget.TabIndex = 45
        Me.lblForget.Text = "Quên Mật Khẩu"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.Info
        Me.Label5.Location = New System.Drawing.Point(111, 19)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(120, 25)
        Me.Label5.TabIndex = 44
        Me.Label5.Text = "Đăng Nhập"
        '
        'lblSignUp
        '
        Me.lblSignUp.AutoSize = True
        Me.lblSignUp.BackColor = System.Drawing.Color.Chartreuse
        Me.lblSignUp.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblSignUp.Font = New System.Drawing.Font("Microsoft Tai Le", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSignUp.Location = New System.Drawing.Point(63, 143)
        Me.lblSignUp.Name = "lblSignUp"
        Me.lblSignUp.Size = New System.Drawing.Size(126, 16)
        Me.lblSignUp.TabIndex = 42
        Me.lblSignUp.Text = "Đăng Kí Tài Khoản"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Tai Le", 7.8!, System.Drawing.FontStyle.Bold)
        Me.Label2.Location = New System.Drawing.Point(36, 104)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(74, 16)
        Me.Label2.TabIndex = 40
        Me.Label2.Text = "Mật Khẩu:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Tai Le", 7.8!, System.Drawing.FontStyle.Bold)
        Me.Label1.Location = New System.Drawing.Point(-2, 64)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(112, 16)
        Me.Label1.TabIndex = 39
        Me.Label1.Text = "Tên Đăng Nhập:"
        '
        'txtMK
        '
        Me.txtMK.Location = New System.Drawing.Point(137, 98)
        Me.txtMK.Name = "txtMK"
        Me.txtMK.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtMK.Size = New System.Drawing.Size(127, 22)
        Me.txtMK.TabIndex = 38
        '
        'txtTK
        '
        Me.txtTK.Location = New System.Drawing.Point(137, 58)
        Me.txtTK.Name = "txtTK"
        Me.txtTK.Size = New System.Drawing.Size(127, 22)
        Me.txtTK.TabIndex = 37
        '
        'lblExit
        '
        Me.lblExit.AutoSize = True
        Me.lblExit.BackColor = System.Drawing.Color.Red
        Me.lblExit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblExit.Font = New System.Drawing.Font("Microsoft Tai Le", 7.8!, System.Drawing.FontStyle.Bold)
        Me.lblExit.Location = New System.Drawing.Point(200, 143)
        Me.lblExit.Name = "lblExit"
        Me.lblExit.Size = New System.Drawing.Size(43, 16)
        Me.lblExit.TabIndex = 47
        Me.lblExit.Text = "Thoát"
        '
        'btnSignUp
        '
        Me.btnSignUp.BackColor = System.Drawing.Color.Tan
        Me.btnSignUp.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSignUp.Font = New System.Drawing.Font("Microsoft Tai Le", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnSignUp.Location = New System.Drawing.Point(270, 58)
        Me.btnSignUp.Name = "btnSignUp"
        Me.btnSignUp.Size = New System.Drawing.Size(74, 62)
        Me.btnSignUp.TabIndex = 48
        Me.btnSignUp.Text = "Đăng Nhập"
        Me.btnSignUp.UseVisualStyleBackColor = False
        '
        'SignIn
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkOrange
        Me.ClientSize = New System.Drawing.Size(382, 227)
        Me.Controls.Add(Me.btnSignUp)
        Me.Controls.Add(Me.lblExit)
        Me.Controls.Add(Me.lblForget)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.lblSignUp)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtMK)
        Me.Controls.Add(Me.txtTK)
        Me.Name = "SignIn"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Đăng Nhập"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblForget As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents lblSignUp As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtMK As TextBox
    Friend WithEvents txtTK As TextBox
    Friend WithEvents lblExit As Label
    Friend WithEvents btnSignUp As Button
End Class
