<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ResetPass
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
        Me.lblResetPass = New System.Windows.Forms.Button()
        Me.txtReMKmoi = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtMKmoi = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtTK = New System.Windows.Forms.TextBox()
        Me.lblSignUp = New System.Windows.Forms.Label()
        Me.lblExit = New System.Windows.Forms.Label()
        Me.lblSignIn = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblResetPass
        '
        Me.lblResetPass.BackColor = System.Drawing.SystemColors.Highlight
        Me.lblResetPass.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblResetPass.Font = New System.Drawing.Font("Microsoft Tai Le", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblResetPass.Location = New System.Drawing.Point(371, 92)
        Me.lblResetPass.Name = "lblResetPass"
        Me.lblResetPass.Size = New System.Drawing.Size(74, 87)
        Me.lblResetPass.TabIndex = 74
        Me.lblResetPass.Text = "Đặt Lại Mật Khẩu"
        Me.lblResetPass.UseVisualStyleBackColor = False
        '
        'txtReMKmoi
        '
        Me.txtReMKmoi.Location = New System.Drawing.Point(188, 157)
        Me.txtReMKmoi.Name = "txtReMKmoi"
        Me.txtReMKmoi.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtReMKmoi.Size = New System.Drawing.Size(158, 22)
        Me.txtReMKmoi.TabIndex = 73
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Tai Le", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(3, 163)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(179, 19)
        Me.Label4.TabIndex = 72
        Me.Label4.Text = "Nhập lại Mật Khẩu Mới:"
        '
        'txtMKmoi
        '
        Me.txtMKmoi.Location = New System.Drawing.Point(188, 125)
        Me.txtMKmoi.Name = "txtMKmoi"
        Me.txtMKmoi.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtMKmoi.Size = New System.Drawing.Size(158, 22)
        Me.txtMKmoi.TabIndex = 71
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Tai Le", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(67, 128)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(115, 19)
        Me.Label3.TabIndex = 70
        Me.Label3.Text = "Mật Khẩu Mới:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.Info
        Me.Label5.Location = New System.Drawing.Point(163, 33)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(164, 25)
        Me.Label5.TabIndex = 68
        Me.Label5.Text = "Quên Mật Khẩu"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Tai Le", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(98, 95)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(84, 19)
        Me.Label1.TabIndex = 65
        Me.Label1.Text = "Tài Khoản:"
        '
        'txtTK
        '
        Me.txtTK.Location = New System.Drawing.Point(188, 92)
        Me.txtTK.Name = "txtTK"
        Me.txtTK.Size = New System.Drawing.Size(158, 22)
        Me.txtTK.TabIndex = 64
        '
        'lblSignUp
        '
        Me.lblSignUp.AutoSize = True
        Me.lblSignUp.BackColor = System.Drawing.Color.Chartreuse
        Me.lblSignUp.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblSignUp.Font = New System.Drawing.Font("Microsoft Tai Le", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSignUp.Location = New System.Drawing.Point(106, 211)
        Me.lblSignUp.Name = "lblSignUp"
        Me.lblSignUp.Size = New System.Drawing.Size(126, 16)
        Me.lblSignUp.TabIndex = 75
        Me.lblSignUp.Text = "Đăng Kí Tài Khoản"
        '
        'lblExit
        '
        Me.lblExit.AutoSize = True
        Me.lblExit.BackColor = System.Drawing.Color.Red
        Me.lblExit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblExit.Font = New System.Drawing.Font("Microsoft Tai Le", 7.8!, System.Drawing.FontStyle.Bold)
        Me.lblExit.Location = New System.Drawing.Point(325, 211)
        Me.lblExit.Name = "lblExit"
        Me.lblExit.Size = New System.Drawing.Size(43, 16)
        Me.lblExit.TabIndex = 76
        Me.lblExit.Text = "Thoát"
        '
        'lblSignIn
        '
        Me.lblSignIn.AutoSize = True
        Me.lblSignIn.BackColor = System.Drawing.Color.Tan
        Me.lblSignIn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblSignIn.Font = New System.Drawing.Font("Microsoft Tai Le", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSignIn.Location = New System.Drawing.Point(238, 211)
        Me.lblSignIn.Name = "lblSignIn"
        Me.lblSignIn.Size = New System.Drawing.Size(81, 16)
        Me.lblSignIn.TabIndex = 77
        Me.lblSignIn.Text = "Đăng Nhập"
        '
        'ResetPass
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(512, 264)
        Me.Controls.Add(Me.lblSignIn)
        Me.Controls.Add(Me.lblExit)
        Me.Controls.Add(Me.lblSignUp)
        Me.Controls.Add(Me.lblResetPass)
        Me.Controls.Add(Me.txtReMKmoi)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtMKmoi)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtTK)
        Me.Name = "ResetPass"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ResetPass"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblResetPass As Button
    Friend WithEvents txtReMKmoi As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtMKmoi As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtTK As TextBox
    Friend WithEvents lblSignUp As Label
    Friend WithEvents lblExit As Label
    Friend WithEvents lblSignIn As Label
End Class
