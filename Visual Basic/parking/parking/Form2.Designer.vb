<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form2))
        lbl_password = New Label()
        txt_password = New TextBox()
        btn_login = New Button()
        lbl_username = New Label()
        txt_username = New TextBox()
        btn_cancel = New Button()
        SuspendLayout()
        ' 
        ' lbl_password
        ' 
        lbl_password.AutoSize = True
        lbl_password.BackColor = Color.Transparent
        lbl_password.Font = New Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lbl_password.Location = New Point(37, 223)
        lbl_password.Name = "lbl_password"
        lbl_password.Size = New Size(111, 32)
        lbl_password.TabIndex = 3
        lbl_password.Text = "Password"
        ' 
        ' txt_password
        ' 
        txt_password.Font = New Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txt_password.Location = New Point(37, 258)
        txt_password.Name = "txt_password"
        txt_password.Size = New Size(408, 46)
        txt_password.TabIndex = 4
        ' 
        ' btn_login
        ' 
        btn_login.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btn_login.Location = New Point(37, 355)
        btn_login.Name = "btn_login"
        btn_login.Size = New Size(223, 59)
        btn_login.TabIndex = 5
        btn_login.Text = "Login"
        btn_login.UseVisualStyleBackColor = True
        ' 
        ' lbl_username
        ' 
        lbl_username.AutoSize = True
        lbl_username.BackColor = Color.Transparent
        lbl_username.Font = New Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lbl_username.Location = New Point(37, 129)
        lbl_username.Name = "lbl_username"
        lbl_username.Size = New Size(121, 32)
        lbl_username.TabIndex = 6
        lbl_username.Text = "Username"
        ' 
        ' txt_username
        ' 
        txt_username.Font = New Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txt_username.Location = New Point(37, 164)
        txt_username.Name = "txt_username"
        txt_username.Size = New Size(408, 46)
        txt_username.TabIndex = 7
        ' 
        ' btn_cancel
        ' 
        btn_cancel.BackColor = SystemColors.ControlDark
        btn_cancel.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btn_cancel.Location = New Point(298, 355)
        btn_cancel.Name = "btn_cancel"
        btn_cancel.Size = New Size(223, 59)
        btn_cancel.TabIndex = 8
        btn_cancel.Text = "Cancel"
        btn_cancel.UseVisualStyleBackColor = False
        ' 
        ' Form2
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(938, 475)
        Controls.Add(btn_cancel)
        Controls.Add(txt_username)
        Controls.Add(lbl_username)
        Controls.Add(btn_login)
        Controls.Add(txt_password)
        Controls.Add(lbl_password)
        Name = "Form2"
        Text = "Login"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents lbl_password As Label
    Friend WithEvents txt_password As TextBox
    Friend WithEvents btn_login As Button
    Friend WithEvents lbl_username As Label
    Friend WithEvents txt_username As TextBox
    Friend WithEvents btn_cancel As Button
End Class
