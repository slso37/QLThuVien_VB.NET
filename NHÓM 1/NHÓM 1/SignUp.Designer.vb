<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SignUp
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
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtReMK = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtMK = New System.Windows.Forms.TextBox()
        Me.txtTK = New System.Windows.Forms.TextBox()
        Me.lblExit = New System.Windows.Forms.Label()
        Me.btnSignUp = New System.Windows.Forms.Button()
        Me.lblSignIn = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Tai Le", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(12, 175)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(134, 16)
        Me.Label3.TabIndex = 37
        Me.Label3.Text = "Nhập lại Mật Khẩu:"
        '
        'txtReMK
        '
        Me.txtReMK.Location = New System.Drawing.Point(172, 169)
        Me.txtReMK.Name = "txtReMK"
        Me.txtReMK.Size = New System.Drawing.Size(127, 22)
        Me.txtReMK.TabIndex = 36
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label5.Font = New System.Drawing.Font("Microsoft Tai Le", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.Info
        Me.Label5.Location = New System.Drawing.Point(109, 24)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(190, 26)
        Me.Label5.TabIndex = 35
        Me.Label5.Text = "Đăng Kí Tài Khoản"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Tai Le", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(72, 132)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(74, 16)
        Me.Label2.TabIndex = 32
        Me.Label2.Text = "Mật Khẩu:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Tai Le", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(71, 85)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(75, 16)
        Me.Label1.TabIndex = 31
        Me.Label1.Text = "Tài Khoản:"
        '
        'txtMK
        '
        Me.txtMK.Location = New System.Drawing.Point(172, 126)
        Me.txtMK.Name = "txtMK"
        Me.txtMK.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtMK.Size = New System.Drawing.Size(127, 22)
        Me.txtMK.TabIndex = 30
        '
        'txtTK
        '
        Me.txtTK.Location = New System.Drawing.Point(172, 81)
        Me.txtTK.Name = "txtTK"
        Me.txtTK.Size = New System.Drawing.Size(127, 22)
        Me.txtTK.TabIndex = 29
        '
        'lblExit
        '
        Me.lblExit.AutoSize = True
        Me.lblExit.BackColor = System.Drawing.Color.Red
        Me.lblExit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblExit.Font = New System.Drawing.Font("Microsoft Tai Le", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblExit.Location = New System.Drawing.Point(229, 223)
        Me.lblExit.Name = "lblExit"
        Me.lblExit.Size = New System.Drawing.Size(50, 19)
        Me.lblExit.TabIndex = 49
        Me.lblExit.Text = "Thoát"
        '
        'btnSignUp
        '
        Me.btnSignUp.BackColor = System.Drawing.Color.Chartreuse
        Me.btnSignUp.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSignUp.Font = New System.Drawing.Font("Microsoft Tai Le", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnSignUp.Location = New System.Drawing.Point(305, 77)
        Me.btnSignUp.Name = "btnSignUp"
        Me.btnSignUp.Size = New System.Drawing.Size(74, 114)
        Me.btnSignUp.TabIndex = 38
        Me.btnSignUp.Text = "Đăng Kí Tài Khoản"
        Me.btnSignUp.UseVisualStyleBackColor = False
        '
        'lblSignIn
        '
        Me.lblSignIn.AutoSize = True
        Me.lblSignIn.BackColor = System.Drawing.Color.Tan
        Me.lblSignIn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblSignIn.Font = New System.Drawing.Font("Microsoft Tai Le", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSignIn.Location = New System.Drawing.Point(120, 223)
        Me.lblSignIn.Name = "lblSignIn"
        Me.lblSignIn.Size = New System.Drawing.Size(91, 19)
        Me.lblSignIn.TabIndex = 50
        Me.lblSignIn.Text = "Đăng Nhập"
        '
        'SignUp
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkSlateGray
        Me.ClientSize = New System.Drawing.Size(413, 302)
        Me.Controls.Add(Me.lblSignIn)
        Me.Controls.Add(Me.lblExit)
        Me.Controls.Add(Me.btnSignUp)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtReMK)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtMK)
        Me.Controls.Add(Me.txtTK)
        Me.Name = "SignUp"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SignUp"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label3 As Label
    Friend WithEvents txtReMK As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtMK As TextBox
    Friend WithEvents txtTK As TextBox
    Friend WithEvents lblExit As Label
    Friend WithEvents btnSignUp As Button
    Friend WithEvents lblSignIn As Label
End Class
