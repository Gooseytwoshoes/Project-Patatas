<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
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
        components = New ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form3))
        Label1 = New Label()
        Button1 = New Button()
        TextBox1 = New TextBox()
        TextBox2 = New TextBox()
        Label2 = New Label()
        TextBox3 = New TextBox()
        Label3 = New Label()
        TextBox4 = New TextBox()
        txt_customerID = New TextBox()
        Label4 = New Label()
        Label5 = New Label()
        TextBox5 = New TextBox()
        Label6 = New Label()
        TextBox6 = New TextBox()
        GroupBox1 = New GroupBox()
        RadioButton2 = New RadioButton()
        RadioButton1 = New RadioButton()
        Label7 = New Label()
        Label8 = New Label()
        BindingSource1 = New BindingSource(components)
        Label9 = New Label()
        Label10 = New Label()
        Label11 = New Label()
        Label12 = New Label()
        Label13 = New Label()
        Label14 = New Label()
        Label15 = New Label()
        Label16 = New Label()
        Label17 = New Label()
        Label18 = New Label()
        Label19 = New Label()
        DateTimePicker1 = New DateTimePicker()
        DateTimePicker2 = New DateTimePicker()
        TextBox7 = New TextBox()
        TextBox8 = New TextBox()
        TextBox9 = New TextBox()
        TextBox10 = New TextBox()
        btn_pay = New Button()
        GroupBox1.SuspendLayout()
        CType(BindingSource1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(302, 179)
        Label1.Name = "Label1"
        Label1.Size = New Size(78, 30)
        Label1.TabIndex = 0
        Label1.Text = "Name*"
        ' 
        ' Button1
        ' 
        Button1.Font = New Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Button1.Location = New Point(1008, 21)
        Button1.Name = "Button1"
        Button1.Size = New Size(65, 39)
        Button1.TabIndex = 1
        Button1.Text = "🔍"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' TextBox1
        ' 
        TextBox1.Font = New Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TextBox1.Location = New Point(486, 21)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(516, 39)
        TextBox1.TabIndex = 2
        ' 
        ' TextBox2
        ' 
        TextBox2.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TextBox2.Location = New Point(398, 180)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(361, 29)
        TextBox2.TabIndex = 3
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(302, 219)
        Label2.Name = "Label2"
        Label2.Size = New Size(63, 30)
        Label2.TabIndex = 4
        Label2.Text = "Email"
        ' 
        ' TextBox3
        ' 
        TextBox3.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TextBox3.Location = New Point(398, 220)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(361, 29)
        TextBox3.TabIndex = 5
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.Transparent
        Label3.Font = New Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(302, 252)
        Label3.Name = "Label3"
        Label3.Size = New Size(87, 30)
        Label3.TabIndex = 6
        Label3.Text = "Address"
        ' 
        ' TextBox4
        ' 
        TextBox4.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TextBox4.Location = New Point(398, 252)
        TextBox4.Name = "TextBox4"
        TextBox4.Size = New Size(361, 29)
        TextBox4.TabIndex = 7
        ' 
        ' txt_customerID
        ' 
        txt_customerID.Enabled = False
        txt_customerID.Font = New Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txt_customerID.Location = New Point(147, 122)
        txt_customerID.Name = "txt_customerID"
        txt_customerID.Size = New Size(72, 39)
        txt_customerID.TabIndex = 8
        txt_customerID.TextAlign = HorizontalAlignment.Center
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = Color.Transparent
        Label4.Font = New Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(12, 127)
        Label4.Name = "Label4"
        Label4.Size = New Size(129, 30)
        Label4.TabIndex = 9
        Label4.Text = "Customer ID"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.BackColor = Color.Transparent
        Label5.Font = New Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(12, 176)
        Label5.Name = "Label5"
        Label5.Size = New Size(120, 30)
        Label5.TabIndex = 10
        Label5.Text = "Payment ID"
        ' 
        ' TextBox5
        ' 
        TextBox5.Enabled = False
        TextBox5.Font = New Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TextBox5.Location = New Point(12, 209)
        TextBox5.Name = "TextBox5"
        TextBox5.Size = New Size(207, 39)
        TextBox5.TabIndex = 11
        TextBox5.TextAlign = HorizontalAlignment.Center
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.BackColor = Color.Transparent
        Label6.Font = New Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label6.Location = New Point(302, 371)
        Label6.Name = "Label6"
        Label6.Size = New Size(150, 30)
        Label6.TabIndex = 12
        Label6.Text = "Plate Number*"
        ' 
        ' TextBox6
        ' 
        TextBox6.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TextBox6.Location = New Point(466, 371)
        TextBox6.Name = "TextBox6"
        TextBox6.Size = New Size(293, 29)
        TextBox6.TabIndex = 13
        ' 
        ' GroupBox1
        ' 
        GroupBox1.BackColor = Color.Transparent
        GroupBox1.Controls.Add(RadioButton2)
        GroupBox1.Controls.Add(RadioButton1)
        GroupBox1.Controls.Add(Label7)
        GroupBox1.Location = New Point(302, 284)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(457, 62)
        GroupBox1.TabIndex = 14
        GroupBox1.TabStop = False
        ' 
        ' RadioButton2
        ' 
        RadioButton2.AutoSize = True
        RadioButton2.Checked = True
        RadioButton2.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        RadioButton2.Location = New Point(313, 20)
        RadioButton2.Name = "RadioButton2"
        RadioButton2.Size = New Size(57, 29)
        RadioButton2.TabIndex = 17
        RadioButton2.TabStop = True
        RadioButton2.Text = "No"
        RadioButton2.UseVisualStyleBackColor = True
        ' 
        ' RadioButton1
        ' 
        RadioButton1.AutoSize = True
        RadioButton1.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        RadioButton1.Location = New Point(164, 19)
        RadioButton1.Name = "RadioButton1"
        RadioButton1.Size = New Size(58, 29)
        RadioButton1.TabIndex = 16
        RadioButton1.Text = "Yes"
        RadioButton1.UseVisualStyleBackColor = True
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.BackColor = Color.Transparent
        Label7.Font = New Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label7.Location = New Point(0, 19)
        Label7.Name = "Label7"
        Label7.Size = New Size(69, 30)
        Label7.TabIndex = 15
        Label7.Text = "PWD*"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.BackColor = Color.Transparent
        Label8.Font = New Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label8.Location = New Point(302, 400)
        Label8.Name = "Label8"
        Label8.Size = New Size(102, 30)
        Label8.TabIndex = 15
        Label8.Text = "Car Type*"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.BackColor = Color.Transparent
        Label9.Font = New Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label9.Location = New Point(302, 442)
        Label9.Name = "Label9"
        Label9.Size = New Size(99, 30)
        Label9.TabIndex = 16
        Label9.Text = "Car Color"
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.BackColor = Color.Transparent
        Label10.Font = New Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label10.Location = New Point(302, 477)
        Label10.Name = "Label10"
        Label10.Size = New Size(101, 30)
        Label10.TabIndex = 17
        Label10.Text = "Car Make"
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.BackColor = Color.Transparent
        Label11.Font = New Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label11.Location = New Point(302, 515)
        Label11.Name = "Label11"
        Label11.Size = New Size(109, 30)
        Label11.TabIndex = 18
        Label11.Text = "Car Model"
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.BackColor = Color.Transparent
        Label12.Font = New Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label12.Location = New Point(302, 547)
        Label12.Name = "Label12"
        Label12.Size = New Size(89, 30)
        Label12.TabIndex = 19
        Label12.Text = "Car Year"
        ' 
        ' Label13
        ' 
        Label13.AutoSize = True
        Label13.BackColor = Color.Transparent
        Label13.Font = New Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label13.Location = New Point(302, 578)
        Label13.Name = "Label13"
        Label13.Size = New Size(129, 30)
        Label13.TabIndex = 20
        Label13.Text = "Space Floor*"
        ' 
        ' Label14
        ' 
        Label14.AutoSize = True
        Label14.BackColor = Color.Transparent
        Label14.Font = New Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label14.Location = New Point(302, 608)
        Label14.Name = "Label14"
        Label14.Size = New Size(139, 30)
        Label14.TabIndex = 21
        Label14.Text = "Space Name*"
        ' 
        ' Label15
        ' 
        Label15.AutoSize = True
        Label15.BackColor = Color.Transparent
        Label15.Font = New Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label15.Location = New Point(820, 180)
        Label15.Name = "Label15"
        Label15.Size = New Size(95, 30)
        Label15.TabIndex = 22
        Label15.Text = "Method*"
        ' 
        ' Label16
        ' 
        Label16.AutoSize = True
        Label16.BackColor = Color.Transparent
        Label16.Font = New Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label16.Location = New Point(820, 220)
        Label16.Name = "Label16"
        Label16.Size = New Size(55, 30)
        Label16.TabIndex = 23
        Label16.Text = "Start"
        ' 
        ' Label17
        ' 
        Label17.AutoSize = True
        Label17.BackColor = Color.Transparent
        Label17.Font = New Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label17.Location = New Point(820, 252)
        Label17.Name = "Label17"
        Label17.Size = New Size(98, 30)
        Label17.TabIndex = 24
        Label17.Text = "Due date"
        ' 
        ' Label18
        ' 
        Label18.AutoSize = True
        Label18.BackColor = Color.Transparent
        Label18.Font = New Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label18.Location = New Point(820, 304)
        Label18.Name = "Label18"
        Label18.Size = New Size(148, 30)
        Label18.TabIndex = 25
        Label18.Text = "Total Payment:"
        ' 
        ' Label19
        ' 
        Label19.AutoSize = True
        Label19.BackColor = Color.Transparent
        Label19.Font = New Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label19.Location = New Point(977, 304)
        Label19.Name = "Label19"
        Label19.Size = New Size(25, 30)
        Label19.TabIndex = 26
        Label19.Text = "0"
        ' 
        ' DateTimePicker1
        ' 
        DateTimePicker1.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        DateTimePicker1.Location = New Point(924, 219)
        DateTimePicker1.Name = "DateTimePicker1"
        DateTimePicker1.Size = New Size(209, 29)
        DateTimePicker1.TabIndex = 27
        ' 
        ' DateTimePicker2
        ' 
        DateTimePicker2.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        DateTimePicker2.Location = New Point(924, 252)
        DateTimePicker2.Name = "DateTimePicker2"
        DateTimePicker2.Size = New Size(209, 29)
        DateTimePicker2.TabIndex = 28
        ' 
        ' TextBox7
        ' 
        TextBox7.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TextBox7.Location = New Point(466, 446)
        TextBox7.Name = "TextBox7"
        TextBox7.Size = New Size(293, 29)
        TextBox7.TabIndex = 29
        ' 
        ' TextBox8
        ' 
        TextBox8.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TextBox8.Location = New Point(466, 481)
        TextBox8.Name = "TextBox8"
        TextBox8.Size = New Size(293, 29)
        TextBox8.TabIndex = 30
        ' 
        ' TextBox9
        ' 
        TextBox9.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TextBox9.Location = New Point(466, 516)
        TextBox9.Name = "TextBox9"
        TextBox9.Size = New Size(293, 29)
        TextBox9.TabIndex = 31
        ' 
        ' TextBox10
        ' 
        TextBox10.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TextBox10.Location = New Point(466, 551)
        TextBox10.Name = "TextBox10"
        TextBox10.Size = New Size(293, 29)
        TextBox10.TabIndex = 32
        ' 
        ' btn_pay
        ' 
        btn_pay.Font = New Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btn_pay.Location = New Point(840, 547)
        btn_pay.Name = "btn_pay"
        btn_pay.Size = New Size(285, 59)
        btn_pay.TabIndex = 33
        btn_pay.Text = "Pay"
        btn_pay.UseVisualStyleBackColor = True
        ' 
        ' Form3
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(1145, 656)
        Controls.Add(btn_pay)
        Controls.Add(TextBox10)
        Controls.Add(TextBox9)
        Controls.Add(TextBox8)
        Controls.Add(TextBox7)
        Controls.Add(DateTimePicker2)
        Controls.Add(DateTimePicker1)
        Controls.Add(Label19)
        Controls.Add(Label18)
        Controls.Add(Label17)
        Controls.Add(Label16)
        Controls.Add(Label15)
        Controls.Add(Label14)
        Controls.Add(Label13)
        Controls.Add(Label12)
        Controls.Add(Label11)
        Controls.Add(Label10)
        Controls.Add(Label9)
        Controls.Add(Label8)
        Controls.Add(GroupBox1)
        Controls.Add(TextBox6)
        Controls.Add(Label6)
        Controls.Add(TextBox5)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(txt_customerID)
        Controls.Add(TextBox4)
        Controls.Add(Label3)
        Controls.Add(TextBox3)
        Controls.Add(Label2)
        Controls.Add(TextBox2)
        Controls.Add(TextBox1)
        Controls.Add(Button1)
        Controls.Add(Label1)
        Name = "Form3"
        Text = "Parking lot"
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        CType(BindingSource1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents txt_customerID As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label7 As Label
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents Label8 As Label
    Friend WithEvents BindingSource1 As BindingSource
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents DateTimePicker2 As DateTimePicker
    Friend WithEvents TextBox7 As TextBox
    Friend WithEvents TextBox8 As TextBox
    Friend WithEvents TextBox9 As TextBox
    Friend WithEvents TextBox10 As TextBox
    Friend WithEvents btn_pay As Button
End Class
