<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        BackgroundWorker1 = New ComponentModel.BackgroundWorker()
        Label1 = New Label()
        btn_old = New Button()
        btn_new = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(122, 408)
        Label1.Name = "Label1"
        Label1.Size = New Size(291, 32)
        Label1.TabIndex = 0
        Label1.Text = "Already own a parkinglot?"
        ' 
        ' btn_old
        ' 
        btn_old.Font = New Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btn_old.Location = New Point(95, 452)
        btn_old.Name = "btn_old"
        btn_old.Size = New Size(347, 64)
        btn_old.TabIndex = 1
        btn_old.Text = "Login"
        btn_old.UseVisualStyleBackColor = True
        ' 
        ' btn_new
        ' 
        btn_new.BackColor = SystemColors.Control
        btn_new.Font = New Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btn_new.Location = New Point(60, 209)
        btn_new.Name = "btn_new"
        btn_new.Size = New Size(414, 116)
        btn_new.TabIndex = 2
        btn_new.Text = "Own a Parking lot"
        btn_new.UseVisualStyleBackColor = False
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(948, 562)
        Controls.Add(btn_new)
        Controls.Add(btn_old)
        Controls.Add(Label1)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Name = "Form1"
        Text = "Welcome to AVIA"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents Label1 As Label
    Friend WithEvents btn_old As Button
    Friend WithEvents btn_new As Button

End Class
