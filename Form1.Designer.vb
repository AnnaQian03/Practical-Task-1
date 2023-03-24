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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.LabelEmployeeDetail = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.OPENToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SAVEToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EXITToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtEmployeeName = New System.Windows.Forms.TextBox()
        Me.txtEmployeeAddress = New System.Windows.Forms.TextBox()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.NumericUpDown1 = New System.Windows.Forms.NumericUpDown()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtSalary = New System.Windows.Forms.TextBox()
        Me.txtOvertime = New System.Windows.Forms.TextBox()
        Me.BTNAbout = New System.Windows.Forms.Button()
        Me.BTNClear = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.BTNBrowse = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.txtRateHour = New System.Windows.Forms.TextBox()
        Me.txtWorkHour = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtFinalTotal = New System.Windows.Forms.TextBox()
        Me.Panel1.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Panel1.Controls.Add(Me.LabelEmployeeDetail)
        Me.Panel1.Controls.Add(Me.MenuStrip1)
        Me.Panel1.Location = New System.Drawing.Point(-1, 1)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1165, 100)
        Me.Panel1.TabIndex = 0
        '
        'LabelEmployeeDetail
        '
        Me.LabelEmployeeDetail.Font = New System.Drawing.Font("Microsoft Sans Serif", 35.0!)
        Me.LabelEmployeeDetail.Location = New System.Drawing.Point(274, 28)
        Me.LabelEmployeeDetail.Name = "LabelEmployeeDetail"
        Me.LabelEmployeeDetail.Size = New System.Drawing.Size(670, 72)
        Me.LabelEmployeeDetail.TabIndex = 1
        Me.LabelEmployeeDetail.Text = "Kedai Poly Employee Detail"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OPENToolStripMenuItem, Me.SAVEToolStripMenuItem, Me.EXITToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1165, 24)
        Me.MenuStrip1.TabIndex = 2
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'OPENToolStripMenuItem
        '
        Me.OPENToolStripMenuItem.Name = "OPENToolStripMenuItem"
        Me.OPENToolStripMenuItem.Size = New System.Drawing.Size(50, 20)
        Me.OPENToolStripMenuItem.Text = "OPEN"
        '
        'SAVEToolStripMenuItem
        '
        Me.SAVEToolStripMenuItem.Name = "SAVEToolStripMenuItem"
        Me.SAVEToolStripMenuItem.Size = New System.Drawing.Size(45, 20)
        Me.SAVEToolStripMenuItem.Text = "SAVE"
        '
        'EXITToolStripMenuItem
        '
        Me.EXITToolStripMenuItem.Name = "EXITToolStripMenuItem"
        Me.EXITToolStripMenuItem.Size = New System.Drawing.Size(41, 20)
        Me.EXITToolStripMenuItem.Text = "EXIT"
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.Label3.Location = New System.Drawing.Point(23, 232)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(190, 57)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Gender :"
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.Label1.Location = New System.Drawing.Point(23, 115)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(190, 42)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Employee Name :"
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.Label2.Location = New System.Drawing.Point(23, 176)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(208, 46)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Employee Birth Date :"
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.Label4.Location = New System.Drawing.Point(23, 289)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(208, 38)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Employee Address :"
        '
        'txtEmployeeName
        '
        Me.txtEmployeeName.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.txtEmployeeName.Location = New System.Drawing.Point(237, 115)
        Me.txtEmployeeName.Name = "txtEmployeeName"
        Me.txtEmployeeName.Size = New System.Drawing.Size(443, 30)
        Me.txtEmployeeName.TabIndex = 8
        '
        'txtEmployeeAddress
        '
        Me.txtEmployeeAddress.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.txtEmployeeAddress.Location = New System.Drawing.Point(237, 289)
        Me.txtEmployeeAddress.Multiline = True
        Me.txtEmployeeAddress.Name = "txtEmployeeAddress"
        Me.txtEmployeeAddress.Size = New System.Drawing.Size(443, 110)
        Me.txtEmployeeAddress.TabIndex = 9
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.RadioButton1.Location = New System.Drawing.Point(237, 239)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(73, 29)
        Me.RadioButton1.TabIndex = 10
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "Male"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.RadioButton2.Location = New System.Drawing.Point(326, 239)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(95, 29)
        Me.RadioButton2.TabIndex = 11
        Me.RadioButton2.TabStop = True
        Me.RadioButton2.Text = "Female"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.DateTimePicker1.Location = New System.Drawing.Point(237, 176)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(335, 30)
        Me.DateTimePicker1.TabIndex = 12
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.Label5.Location = New System.Drawing.Point(590, 176)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(205, 46)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "Age :"
        '
        'NumericUpDown1
        '
        Me.NumericUpDown1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.NumericUpDown1.Location = New System.Drawing.Point(657, 174)
        Me.NumericUpDown1.Name = "NumericUpDown1"
        Me.NumericUpDown1.Size = New System.Drawing.Size(120, 30)
        Me.NumericUpDown1.TabIndex = 14
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.CheckBox1.Location = New System.Drawing.Point(288, 535)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(448, 29)
        Me.CheckBox1.TabIndex = 15
        Me.CheckBox1.Text = "I agree that all the information is correct and true."
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.Label6.Location = New System.Drawing.Point(12, 249)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(109, 30)
        Me.Label6.TabIndex = 18
        Me.Label6.Text = "Salary : "
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.Label7.Location = New System.Drawing.Point(8, 113)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(109, 42)
        Me.Label7.TabIndex = 19
        Me.Label7.Text = "Overtime :"
        '
        'txtSalary
        '
        Me.txtSalary.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.txtSalary.Location = New System.Drawing.Point(139, 243)
        Me.txtSalary.Name = "txtSalary"
        Me.txtSalary.Size = New System.Drawing.Size(194, 30)
        Me.txtSalary.TabIndex = 21
        '
        'txtOvertime
        '
        Me.txtOvertime.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.txtOvertime.Location = New System.Drawing.Point(139, 113)
        Me.txtOvertime.Name = "txtOvertime"
        Me.txtOvertime.Size = New System.Drawing.Size(194, 30)
        Me.txtOvertime.TabIndex = 22
        '
        'BTNAbout
        '
        Me.BTNAbout.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.BTNAbout.Location = New System.Drawing.Point(1030, 529)
        Me.BTNAbout.Name = "BTNAbout"
        Me.BTNAbout.Size = New System.Drawing.Size(117, 39)
        Me.BTNAbout.TabIndex = 24
        Me.BTNAbout.Text = "About"
        Me.BTNAbout.UseVisualStyleBackColor = True
        '
        'BTNClear
        '
        Me.BTNClear.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.BTNClear.Location = New System.Drawing.Point(907, 529)
        Me.BTNClear.Name = "BTNClear"
        Me.BTNClear.Size = New System.Drawing.Size(117, 39)
        Me.BTNClear.TabIndex = 25
        Me.BTNClear.Text = "Clear"
        Me.BTNClear.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox1.Location = New System.Drawing.Point(12, 407)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(270, 155)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 26
        Me.PictureBox1.TabStop = False
        '
        'BTNBrowse
        '
        Me.BTNBrowse.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!)
        Me.BTNBrowse.Location = New System.Drawing.Point(288, 407)
        Me.BTNBrowse.Name = "BTNBrowse"
        Me.BTNBrowse.Size = New System.Drawing.Size(168, 35)
        Me.BTNBrowse.TabIndex = 27
        Me.BTNBrowse.Text = "Browse Picture"
        Me.BTNBrowse.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Aqua
        Me.Panel2.Controls.Add(Me.txtFinalTotal)
        Me.Panel2.Controls.Add(Me.Label11)
        Me.Panel2.Controls.Add(Me.txtRateHour)
        Me.Panel2.Controls.Add(Me.txtWorkHour)
        Me.Panel2.Controls.Add(Me.Label10)
        Me.Panel2.Controls.Add(Me.txtSalary)
        Me.Panel2.Controls.Add(Me.Label9)
        Me.Panel2.Controls.Add(Me.txtOvertime)
        Me.Panel2.Controls.Add(Me.Label7)
        Me.Panel2.Controls.Add(Me.Label6)
        Me.Panel2.Location = New System.Drawing.Point(801, 104)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(359, 419)
        Me.Panel2.TabIndex = 28
        '
        'txtRateHour
        '
        Me.txtRateHour.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.txtRateHour.Location = New System.Drawing.Point(139, 65)
        Me.txtRateHour.Name = "txtRateHour"
        Me.txtRateHour.Size = New System.Drawing.Size(194, 30)
        Me.txtRateHour.TabIndex = 24
        '
        'txtWorkHour
        '
        Me.txtWorkHour.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.txtWorkHour.Location = New System.Drawing.Point(139, 23)
        Me.txtWorkHour.Name = "txtWorkHour"
        Me.txtWorkHour.Size = New System.Drawing.Size(194, 30)
        Me.txtWorkHour.TabIndex = 23
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.Label10.Location = New System.Drawing.Point(8, 65)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(111, 25)
        Me.Label10.TabIndex = 22
        Me.Label10.Text = "Rate/Hour :"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.Label9.Location = New System.Drawing.Point(8, 28)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(117, 25)
        Me.Label9.TabIndex = 21
        Me.Label9.Text = "Work Hour :"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.Label11.Location = New System.Drawing.Point(12, 303)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(67, 25)
        Me.Label11.TabIndex = 25
        Me.Label11.Text = "Total :"
        '
        'txtFinalTotal
        '
        Me.txtFinalTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.txtFinalTotal.Location = New System.Drawing.Point(139, 298)
        Me.txtFinalTotal.Name = "txtFinalTotal"
        Me.txtFinalTotal.Size = New System.Drawing.Size(194, 30)
        Me.txtFinalTotal.TabIndex = 26
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1159, 574)
        Me.Controls.Add(Me.BTNBrowse)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.BTNClear)
        Me.Controls.Add(Me.BTNAbout)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.NumericUpDown1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.RadioButton2)
        Me.Controls.Add(Me.RadioButton1)
        Me.Controls.Add(Me.txtEmployeeAddress)
        Me.Controls.Add(Me.txtEmployeeName)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel2)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Employee Detail"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents LabelEmployeeDetail As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtEmployeeName As TextBox
    Friend WithEvents txtEmployeeAddress As TextBox
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents Label5 As Label
    Friend WithEvents NumericUpDown1 As NumericUpDown
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents txtSalary As TextBox
    Friend WithEvents txtOvertime As TextBox
    Friend WithEvents BTNAbout As Button
    Friend WithEvents BTNClear As Button
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents OPENToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SAVEToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EXITToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents BTNBrowse As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents txtRateHour As TextBox
    Friend WithEvents txtWorkHour As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents txtFinalTotal As TextBox
    Friend WithEvents Label11 As Label
End Class
