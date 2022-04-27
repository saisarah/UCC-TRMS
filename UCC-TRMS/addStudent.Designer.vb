<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class addStudent
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(addStudent))
        Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Guna2Panel2 = New Guna.UI2.WinForms.Guna2Panel()
        Me.tbemail = New Guna.UI2.WinForms.Guna2TextBox()
        Me.btnUpdateStudent = New Guna.UI2.WinForms.Guna2Button()
        Me.btnSaveStudent = New Guna.UI2.WinForms.Guna2Button()
        Me.tbstudentno = New Guna.UI2.WinForms.Guna2TextBox()
        Me.btnAddStudentClose = New Guna.UI2.WinForms.Guna2ImageButton()
        Me.Guna2Panel3 = New Guna.UI2.WinForms.Guna2Panel()
        Me.cbyear = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.tbcontact = New Guna.UI2.WinForms.Guna2TextBox()
        Me.tbcourse = New Guna.UI2.WinForms.Guna2TextBox()
        Me.tbfullname = New Guna.UI2.WinForms.Guna2TextBox()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.cbSection = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.Guna2Panel2.SuspendLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Guna2Panel1
        '
        Me.Guna2Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Guna2Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(76, Byte), Integer), CType(CType(71, Byte), Integer), CType(CType(67, Byte), Integer))
        Me.Guna2Panel1.BorderRadius = 20
        Me.Guna2Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Guna2Panel1.Name = "Guna2Panel1"
        Me.Guna2Panel1.ShadowDecoration.Parent = Me.Guna2Panel1
        Me.Guna2Panel1.Size = New System.Drawing.Size(500, 10)
        Me.Guna2Panel1.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(12, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(65, 25)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Label"
        '
        'Guna2Panel2
        '
        Me.Guna2Panel2.BackColor = System.Drawing.Color.Transparent
        Me.Guna2Panel2.BorderColor = System.Drawing.Color.FromArgb(CType(CType(76, Byte), Integer), CType(CType(71, Byte), Integer), CType(CType(67, Byte), Integer))
        Me.Guna2Panel2.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom
        Me.Guna2Panel2.Controls.Add(Me.cbSection)
        Me.Guna2Panel2.Controls.Add(Me.tbemail)
        Me.Guna2Panel2.Controls.Add(Me.btnUpdateStudent)
        Me.Guna2Panel2.Controls.Add(Me.btnSaveStudent)
        Me.Guna2Panel2.Controls.Add(Me.tbstudentno)
        Me.Guna2Panel2.Controls.Add(Me.btnAddStudentClose)
        Me.Guna2Panel2.Controls.Add(Me.Guna2Panel3)
        Me.Guna2Panel2.Controls.Add(Me.Label1)
        Me.Guna2Panel2.Controls.Add(Me.cbyear)
        Me.Guna2Panel2.Controls.Add(Me.tbcontact)
        Me.Guna2Panel2.Controls.Add(Me.tbcourse)
        Me.Guna2Panel2.Controls.Add(Me.tbfullname)
        Me.Guna2Panel2.CustomBorderColor = System.Drawing.Color.FromArgb(CType(CType(76, Byte), Integer), CType(CType(71, Byte), Integer), CType(CType(67, Byte), Integer))
        Me.Guna2Panel2.CustomBorderThickness = New System.Windows.Forms.Padding(1, 0, 1, 1)
        Me.Guna2Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Guna2Panel2.FillColor = System.Drawing.Color.White
        Me.Guna2Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Guna2Panel2.Name = "Guna2Panel2"
        Me.Guna2Panel2.ShadowDecoration.Parent = Me.Guna2Panel2
        Me.Guna2Panel2.Size = New System.Drawing.Size(500, 301)
        Me.Guna2Panel2.TabIndex = 3
        '
        'tbemail
        '
        Me.tbemail.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tbemail.BackColor = System.Drawing.Color.Transparent
        Me.tbemail.BorderRadius = 5
        Me.tbemail.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.tbemail.DefaultText = ""
        Me.tbemail.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.tbemail.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.tbemail.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tbemail.DisabledState.Parent = Me.tbemail
        Me.tbemail.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tbemail.FocusedState.BorderColor = System.Drawing.Color.Gray
        Me.tbemail.FocusedState.Parent = Me.tbemail
        Me.tbemail.HoverState.BorderColor = System.Drawing.Color.Gray
        Me.tbemail.HoverState.Parent = Me.tbemail
        Me.tbemail.Location = New System.Drawing.Point(258, 210)
        Me.tbemail.Margin = New System.Windows.Forms.Padding(4)
        Me.tbemail.Name = "tbemail"
        Me.tbemail.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tbemail.PlaceholderText = "Email"
        Me.tbemail.SelectedText = ""
        Me.tbemail.ShadowDecoration.Parent = Me.tbemail
        Me.tbemail.Size = New System.Drawing.Size(230, 36)
        Me.tbemail.TabIndex = 17
        '
        'btnUpdateStudent
        '
        Me.btnUpdateStudent.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnUpdateStudent.BackColor = System.Drawing.Color.Transparent
        Me.btnUpdateStudent.BorderRadius = 10
        Me.btnUpdateStudent.CheckedState.Parent = Me.btnUpdateStudent
        Me.btnUpdateStudent.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnUpdateStudent.CustomImages.Parent = Me.btnUpdateStudent
        Me.btnUpdateStudent.FillColor = System.Drawing.Color.FromArgb(CType(CType(76, Byte), Integer), CType(CType(71, Byte), Integer), CType(CType(67, Byte), Integer))
        Me.btnUpdateStudent.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdateStudent.ForeColor = System.Drawing.Color.White
        Me.btnUpdateStudent.HoverState.Parent = Me.btnUpdateStudent
        Me.btnUpdateStudent.Location = New System.Drawing.Point(308, 253)
        Me.btnUpdateStudent.Name = "btnUpdateStudent"
        Me.btnUpdateStudent.ShadowDecoration.Parent = Me.btnUpdateStudent
        Me.btnUpdateStudent.Size = New System.Drawing.Size(87, 34)
        Me.btnUpdateStudent.TabIndex = 16
        Me.btnUpdateStudent.Text = "Update"
        '
        'btnSaveStudent
        '
        Me.btnSaveStudent.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSaveStudent.BackColor = System.Drawing.Color.Transparent
        Me.btnSaveStudent.BorderRadius = 10
        Me.btnSaveStudent.CheckedState.Parent = Me.btnSaveStudent
        Me.btnSaveStudent.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSaveStudent.CustomImages.Parent = Me.btnSaveStudent
        Me.btnSaveStudent.FillColor = System.Drawing.Color.FromArgb(CType(CType(76, Byte), Integer), CType(CType(71, Byte), Integer), CType(CType(67, Byte), Integer))
        Me.btnSaveStudent.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSaveStudent.ForeColor = System.Drawing.Color.White
        Me.btnSaveStudent.HoverState.Parent = Me.btnSaveStudent
        Me.btnSaveStudent.Location = New System.Drawing.Point(401, 253)
        Me.btnSaveStudent.Name = "btnSaveStudent"
        Me.btnSaveStudent.ShadowDecoration.Parent = Me.btnSaveStudent
        Me.btnSaveStudent.Size = New System.Drawing.Size(87, 34)
        Me.btnSaveStudent.TabIndex = 15
        Me.btnSaveStudent.Text = "Save"
        '
        'tbstudentno
        '
        Me.tbstudentno.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tbstudentno.BackColor = System.Drawing.Color.Transparent
        Me.tbstudentno.BorderRadius = 5
        Me.tbstudentno.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.tbstudentno.DefaultText = ""
        Me.tbstudentno.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.tbstudentno.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.tbstudentno.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tbstudentno.DisabledState.Parent = Me.tbstudentno
        Me.tbstudentno.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tbstudentno.FocusedState.BorderColor = System.Drawing.Color.Gray
        Me.tbstudentno.FocusedState.Parent = Me.tbstudentno
        Me.tbstudentno.HoverState.BorderColor = System.Drawing.Color.Gray
        Me.tbstudentno.HoverState.Parent = Me.tbstudentno
        Me.tbstudentno.Location = New System.Drawing.Point(13, 122)
        Me.tbstudentno.Margin = New System.Windows.Forms.Padding(4)
        Me.tbstudentno.Name = "tbstudentno"
        Me.tbstudentno.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tbstudentno.PlaceholderText = "Student Number"
        Me.tbstudentno.SelectedText = ""
        Me.tbstudentno.ShadowDecoration.Parent = Me.tbstudentno
        Me.tbstudentno.Size = New System.Drawing.Size(238, 36)
        Me.tbstudentno.TabIndex = 14
        '
        'btnAddStudentClose
        '
        Me.btnAddStudentClose.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAddStudentClose.CheckedState.Parent = Me.btnAddStudentClose
        Me.btnAddStudentClose.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAddStudentClose.HoverState.ImageSize = New System.Drawing.Size(16, 16)
        Me.btnAddStudentClose.HoverState.Parent = Me.btnAddStudentClose
        Me.btnAddStudentClose.Image = CType(resources.GetObject("btnAddStudentClose.Image"), System.Drawing.Image)
        Me.btnAddStudentClose.ImageSize = New System.Drawing.Size(15, 15)
        Me.btnAddStudentClose.Location = New System.Drawing.Point(455, 6)
        Me.btnAddStudentClose.Name = "btnAddStudentClose"
        Me.btnAddStudentClose.PressedState.Parent = Me.btnAddStudentClose
        Me.btnAddStudentClose.Size = New System.Drawing.Size(53, 27)
        Me.btnAddStudentClose.TabIndex = 13
        '
        'Guna2Panel3
        '
        Me.Guna2Panel3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Guna2Panel3.BackColor = System.Drawing.Color.Gray
        Me.Guna2Panel3.Location = New System.Drawing.Point(16, 62)
        Me.Guna2Panel3.Name = "Guna2Panel3"
        Me.Guna2Panel3.ShadowDecoration.Parent = Me.Guna2Panel3
        Me.Guna2Panel3.Size = New System.Drawing.Size(467, 1)
        Me.Guna2Panel3.TabIndex = 12
        '
        'cbyear
        '
        Me.cbyear.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cbyear.BackColor = System.Drawing.Color.Transparent
        Me.cbyear.BorderRadius = 5
        Me.cbyear.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cbyear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbyear.FocusedColor = System.Drawing.Color.Empty
        Me.cbyear.FocusedState.Parent = Me.cbyear
        Me.cbyear.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.cbyear.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.cbyear.FormattingEnabled = True
        Me.cbyear.HoverState.Parent = Me.cbyear
        Me.cbyear.ItemHeight = 30
        Me.cbyear.Items.AddRange(New Object() {"Please select year", "1", "2", "3", "4"})
        Me.cbyear.ItemsAppearance.Parent = Me.cbyear
        Me.cbyear.Location = New System.Drawing.Point(258, 122)
        Me.cbyear.Name = "cbyear"
        Me.cbyear.ShadowDecoration.Parent = Me.cbyear
        Me.cbyear.Size = New System.Drawing.Size(230, 36)
        Me.cbyear.TabIndex = 11
        '
        'tbcontact
        '
        Me.tbcontact.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tbcontact.BackColor = System.Drawing.Color.Transparent
        Me.tbcontact.BorderRadius = 5
        Me.tbcontact.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.tbcontact.DefaultText = ""
        Me.tbcontact.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.tbcontact.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.tbcontact.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tbcontact.DisabledState.Parent = Me.tbcontact
        Me.tbcontact.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tbcontact.FocusedState.BorderColor = System.Drawing.Color.Gray
        Me.tbcontact.FocusedState.Parent = Me.tbcontact
        Me.tbcontact.HoverState.BorderColor = System.Drawing.Color.Gray
        Me.tbcontact.HoverState.Parent = Me.tbcontact
        Me.tbcontact.Location = New System.Drawing.Point(13, 210)
        Me.tbcontact.Margin = New System.Windows.Forms.Padding(4)
        Me.tbcontact.Name = "tbcontact"
        Me.tbcontact.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tbcontact.PlaceholderText = "Contact Number"
        Me.tbcontact.SelectedText = ""
        Me.tbcontact.ShadowDecoration.Parent = Me.tbcontact
        Me.tbcontact.Size = New System.Drawing.Size(238, 36)
        Me.tbcontact.TabIndex = 8
        '
        'tbcourse
        '
        Me.tbcourse.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tbcourse.BackColor = System.Drawing.Color.Transparent
        Me.tbcourse.BorderRadius = 5
        Me.tbcourse.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.tbcourse.DefaultText = ""
        Me.tbcourse.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.tbcourse.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.tbcourse.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tbcourse.DisabledState.Parent = Me.tbcourse
        Me.tbcourse.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tbcourse.FocusedState.BorderColor = System.Drawing.Color.Gray
        Me.tbcourse.FocusedState.Parent = Me.tbcourse
        Me.tbcourse.HoverState.BorderColor = System.Drawing.Color.Gray
        Me.tbcourse.HoverState.Parent = Me.tbcourse
        Me.tbcourse.Location = New System.Drawing.Point(13, 166)
        Me.tbcourse.Margin = New System.Windows.Forms.Padding(4)
        Me.tbcourse.Name = "tbcourse"
        Me.tbcourse.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tbcourse.PlaceholderText = "Course"
        Me.tbcourse.SelectedText = ""
        Me.tbcourse.ShadowDecoration.Parent = Me.tbcourse
        Me.tbcourse.Size = New System.Drawing.Size(238, 36)
        Me.tbcourse.TabIndex = 6
        '
        'tbfullname
        '
        Me.tbfullname.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tbfullname.BackColor = System.Drawing.Color.Transparent
        Me.tbfullname.BorderRadius = 5
        Me.tbfullname.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.tbfullname.DefaultText = ""
        Me.tbfullname.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.tbfullname.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.tbfullname.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tbfullname.DisabledState.Parent = Me.tbfullname
        Me.tbfullname.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tbfullname.FocusedState.BorderColor = System.Drawing.Color.Gray
        Me.tbfullname.FocusedState.Parent = Me.tbfullname
        Me.tbfullname.HoverState.BorderColor = System.Drawing.Color.Gray
        Me.tbfullname.HoverState.Parent = Me.tbfullname
        Me.tbfullname.Location = New System.Drawing.Point(13, 78)
        Me.tbfullname.Margin = New System.Windows.Forms.Padding(4)
        Me.tbfullname.Name = "tbfullname"
        Me.tbfullname.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tbfullname.PlaceholderText = "Fullname"
        Me.tbfullname.SelectedText = ""
        Me.tbfullname.ShadowDecoration.Parent = Me.tbfullname
        Me.tbfullname.Size = New System.Drawing.Size(475, 36)
        Me.tbfullname.TabIndex = 4
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'cbSection
        '
        Me.cbSection.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cbSection.BackColor = System.Drawing.Color.Transparent
        Me.cbSection.BorderRadius = 5
        Me.cbSection.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cbSection.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbSection.FocusedColor = System.Drawing.Color.Empty
        Me.cbSection.FocusedState.Parent = Me.cbSection
        Me.cbSection.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.cbSection.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.cbSection.FormattingEnabled = True
        Me.cbSection.HoverState.Parent = Me.cbSection
        Me.cbSection.ItemHeight = 30
        Me.cbSection.Items.AddRange(New Object() {"Please select section", "A", "B", "C", "D"})
        Me.cbSection.ItemsAppearance.Parent = Me.cbSection
        Me.cbSection.Location = New System.Drawing.Point(258, 167)
        Me.cbSection.Name = "cbSection"
        Me.cbSection.ShadowDecoration.Parent = Me.cbSection
        Me.cbSection.Size = New System.Drawing.Size(230, 36)
        Me.cbSection.TabIndex = 18
        '
        'addStudent
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(500, 301)
        Me.Controls.Add(Me.Guna2Panel1)
        Me.Controls.Add(Me.Guna2Panel2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "addStudent"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "addStudent"
        Me.Guna2Panel2.ResumeLayout(False)
        Me.Guna2Panel2.PerformLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Guna2Panel2 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents btnAddStudentClose As Guna.UI2.WinForms.Guna2ImageButton
    Friend WithEvents Guna2Panel3 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents cbyear As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents tbcontact As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents tbcourse As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents tbfullname As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents tbstudentno As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents btnUpdateStudent As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnSaveStudent As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents tbemail As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents ErrorProvider1 As ErrorProvider
    Friend WithEvents cbSection As Guna.UI2.WinForms.Guna2ComboBox
End Class
