<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class reports
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(reports))
        Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.btnSearchDate = New Guna.UI2.WinForms.Guna2Button()
        Me.dtpTo = New Guna.UI2.WinForms.Guna2DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dtpFrom = New Guna.UI2.WinForms.Guna2DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnPrint = New Guna.UI2.WinForms.Guna2Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.lblTo = New System.Windows.Forms.Label()
        Me.lblFrom = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.prntDate = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.tb = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.lblNoThesis = New System.Windows.Forms.Label()
        Me.lblNoStudent = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Guna2Elipse1 = New Guna.UI2.WinForms.Guna2Elipse(Me.components)
        Me.EasyHTMLReports1 = New KimToo.EasyHTMLReports(Me.components)
        Me.Guna2Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Guna2Panel1
        '
        Me.Guna2Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.Guna2Panel1.Controls.Add(Me.btnSearchDate)
        Me.Guna2Panel1.Controls.Add(Me.dtpTo)
        Me.Guna2Panel1.Controls.Add(Me.Label2)
        Me.Guna2Panel1.Controls.Add(Me.dtpFrom)
        Me.Guna2Panel1.Controls.Add(Me.Label1)
        Me.Guna2Panel1.Controls.Add(Me.btnPrint)
        Me.Guna2Panel1.Controls.Add(Me.Panel2)
        Me.Guna2Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Guna2Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Guna2Panel1.Name = "Guna2Panel1"
        Me.Guna2Panel1.ShadowDecoration.Parent = Me.Guna2Panel1
        Me.Guna2Panel1.Size = New System.Drawing.Size(1190, 706)
        Me.Guna2Panel1.TabIndex = 3
        '
        'btnSearchDate
        '
        Me.btnSearchDate.BorderRadius = 5
        Me.btnSearchDate.CheckedState.Parent = Me.btnSearchDate
        Me.btnSearchDate.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSearchDate.CustomImages.Parent = Me.btnSearchDate
        Me.btnSearchDate.FillColor = System.Drawing.Color.FromArgb(CType(CType(76, Byte), Integer), CType(CType(71, Byte), Integer), CType(CType(67, Byte), Integer))
        Me.btnSearchDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearchDate.ForeColor = System.Drawing.Color.White
        Me.btnSearchDate.HoverState.Parent = Me.btnSearchDate
        Me.btnSearchDate.Image = CType(resources.GetObject("btnSearchDate.Image"), System.Drawing.Image)
        Me.btnSearchDate.Location = New System.Drawing.Point(552, 22)
        Me.btnSearchDate.Name = "btnSearchDate"
        Me.btnSearchDate.ShadowDecoration.Parent = Me.btnSearchDate
        Me.btnSearchDate.Size = New System.Drawing.Size(89, 36)
        Me.btnSearchDate.TabIndex = 23
        Me.btnSearchDate.Text = "Search"
        '
        'dtpTo
        '
        Me.dtpTo.BorderRadius = 5
        Me.dtpTo.CheckedState.Parent = Me.dtpTo
        Me.dtpTo.FillColor = System.Drawing.Color.FromArgb(CType(CType(195, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.dtpTo.Font = New System.Drawing.Font("Poppins", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpTo.ForeColor = System.Drawing.Color.White
        Me.dtpTo.Format = System.Windows.Forms.DateTimePickerFormat.[Long]
        Me.dtpTo.HoverState.Parent = Me.dtpTo
        Me.dtpTo.Location = New System.Drawing.Point(346, 22)
        Me.dtpTo.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.dtpTo.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.dtpTo.Name = "dtpTo"
        Me.dtpTo.ShadowDecoration.Parent = Me.dtpTo
        Me.dtpTo.Size = New System.Drawing.Size(199, 36)
        Me.dtpTo.TabIndex = 22
        Me.dtpTo.Value = New Date(2022, 3, 9, 17, 56, 30, 651)
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Poppins", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(299, 25)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(41, 33)
        Me.Label2.TabIndex = 21
        Me.Label2.Text = "To:"
        '
        'dtpFrom
        '
        Me.dtpFrom.BorderRadius = 5
        Me.dtpFrom.CheckedState.Parent = Me.dtpFrom
        Me.dtpFrom.FillColor = System.Drawing.Color.FromArgb(CType(CType(195, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.dtpFrom.Font = New System.Drawing.Font("Poppins", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFrom.ForeColor = System.Drawing.Color.White
        Me.dtpFrom.Format = System.Windows.Forms.DateTimePickerFormat.[Long]
        Me.dtpFrom.HoverState.Parent = Me.dtpFrom
        Me.dtpFrom.Location = New System.Drawing.Point(85, 22)
        Me.dtpFrom.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.dtpFrom.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.dtpFrom.Name = "dtpFrom"
        Me.dtpFrom.ShadowDecoration.Parent = Me.dtpFrom
        Me.dtpFrom.Size = New System.Drawing.Size(199, 36)
        Me.dtpFrom.TabIndex = 20
        Me.dtpFrom.Value = New Date(2022, 3, 9, 17, 56, 30, 651)
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Poppins", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(15, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(68, 33)
        Me.Label1.TabIndex = 19
        Me.Label1.Text = "From:"
        '
        'btnPrint
        '
        Me.btnPrint.BorderRadius = 5
        Me.btnPrint.CheckedState.Parent = Me.btnPrint
        Me.btnPrint.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnPrint.CustomImages.Parent = Me.btnPrint
        Me.btnPrint.FillColor = System.Drawing.Color.FromArgb(CType(CType(76, Byte), Integer), CType(CType(71, Byte), Integer), CType(CType(67, Byte), Integer))
        Me.btnPrint.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrint.ForeColor = System.Drawing.Color.White
        Me.btnPrint.HoverState.Parent = Me.btnPrint
        Me.btnPrint.Image = CType(resources.GetObject("btnPrint.Image"), System.Drawing.Image)
        Me.btnPrint.Location = New System.Drawing.Point(647, 22)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.ShadowDecoration.Parent = Me.btnPrint
        Me.btnPrint.Size = New System.Drawing.Size(89, 36)
        Me.btnPrint.TabIndex = 18
        Me.btnPrint.Text = "Preview"
        '
        'Panel2
        '
        Me.Panel2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Panel2.BackColor = System.Drawing.Color.White
        Me.Panel2.Controls.Add(Me.PictureBox1)
        Me.Panel2.Controls.Add(Me.Label22)
        Me.Panel2.Controls.Add(Me.Label21)
        Me.Panel2.Controls.Add(Me.Label20)
        Me.Panel2.Controls.Add(Me.lblTo)
        Me.Panel2.Controls.Add(Me.lblFrom)
        Me.Panel2.Controls.Add(Me.Label17)
        Me.Panel2.Controls.Add(Me.Label16)
        Me.Panel2.Controls.Add(Me.prntDate)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.TableLayoutPanel1)
        Me.Panel2.Location = New System.Drawing.Point(12, 67)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1166, 627)
        Me.Panel2.TabIndex = 5
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(204, 17)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(188, 145)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 10
        Me.PictureBox1.TabStop = False
        '
        'Label22
        '
        Me.Label22.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label22.BackColor = System.Drawing.Color.Transparent
        Me.Label22.Font = New System.Drawing.Font("Poppins", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.Location = New System.Drawing.Point(399, 143)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(392, 28)
        Me.Label22.TabIndex = 9
        Me.Label22.Text = "+63 9000000000"
        Me.Label22.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label21
        '
        Me.Label21.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label21.BackColor = System.Drawing.Color.Transparent
        Me.Label21.Font = New System.Drawing.Font("Poppins", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.Location = New System.Drawing.Point(399, 115)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(392, 28)
        Me.Label21.TabIndex = 8
        Me.Label21.Text = "Sample Address, Lorem Ipsum"
        Me.Label21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label20
        '
        Me.Label20.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label20.BackColor = System.Drawing.Color.Transparent
        Me.Label20.Font = New System.Drawing.Font("Poppins", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(399, 67)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(392, 48)
        Me.Label20.TabIndex = 7
        Me.Label20.Text = "University of Caloocan City"
        Me.Label20.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblTo
        '
        Me.lblTo.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblTo.AutoSize = True
        Me.lblTo.Font = New System.Drawing.Font("Poppins", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTo.Location = New System.Drawing.Point(208, 269)
        Me.lblTo.Name = "lblTo"
        Me.lblTo.Size = New System.Drawing.Size(55, 28)
        Me.lblTo.TabIndex = 6
        Me.lblTo.Text = "From:"
        '
        'lblFrom
        '
        Me.lblFrom.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblFrom.AutoSize = True
        Me.lblFrom.Font = New System.Drawing.Font("Poppins", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFrom.Location = New System.Drawing.Point(208, 241)
        Me.lblFrom.Name = "lblFrom"
        Me.lblFrom.Size = New System.Drawing.Size(55, 28)
        Me.lblFrom.TabIndex = 5
        Me.lblFrom.Text = "From:"
        '
        'Label17
        '
        Me.Label17.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Poppins", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(151, 269)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(34, 28)
        Me.Label17.TabIndex = 4
        Me.Label17.Text = "To:"
        '
        'Label16
        '
        Me.Label16.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Poppins", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(147, 241)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(55, 28)
        Me.Label16.TabIndex = 3
        Me.Label16.Text = "From:"
        '
        'prntDate
        '
        Me.prntDate.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.prntDate.AutoSize = True
        Me.prntDate.Font = New System.Drawing.Font("Poppins", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.prntDate.Location = New System.Drawing.Point(1053, 3)
        Me.prntDate.Name = "prntDate"
        Me.prntDate.Size = New System.Drawing.Size(50, 28)
        Me.prntDate.TabIndex = 2
        Me.prntDate.Text = "Date"
        Me.prntDate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label3
        '
        Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Poppins", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(955, 3)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(92, 28)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Print Date:"
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.Label15, 1, 5)
        Me.TableLayoutPanel1.Controls.Add(Me.Label14, 1, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.Label13, 1, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.Label4, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.tb, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Label7, 0, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.Label8, 0, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.lblNoThesis, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.lblNoStudent, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Label12, 1, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.Label10, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.Label6, 0, 5)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(145, 316)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 6
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(901, 220)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'Label15
        '
        Me.Label15.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Poppins Light", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(454, 183)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(27, 33)
        Me.Label15.TabIndex = 9
        Me.Label15.Text = "0"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label14
        '
        Me.Label14.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Poppins Light", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(454, 146)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(27, 33)
        Me.Label14.TabIndex = 9
        Me.Label14.Text = "0"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label13
        '
        Me.Label13.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Poppins Light", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(454, 110)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(27, 33)
        Me.Label13.TabIndex = 9
        Me.Label13.Text = "0"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label4
        '
        Me.Label4.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Poppins Light", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(4, 2)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(228, 33)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Total Number of Thesis"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'tb
        '
        Me.tb.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.tb.AutoSize = True
        Me.tb.Font = New System.Drawing.Font("Poppins Light", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb.Location = New System.Drawing.Point(4, 38)
        Me.tb.Name = "tb"
        Me.tb.Size = New System.Drawing.Size(246, 33)
        Me.tb.TabIndex = 4
        Me.tb.Text = "Total Student Registered"
        Me.tb.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label7
        '
        Me.Label7.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Poppins Light", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(4, 110)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(243, 33)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Total Thesis in Possesion"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label8
        '
        Me.Label8.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Poppins Light", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(4, 146)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(231, 33)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "Total Cleared Payment"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblNoThesis
        '
        Me.lblNoThesis.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lblNoThesis.AutoSize = True
        Me.lblNoThesis.Font = New System.Drawing.Font("Poppins Light", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNoThesis.Location = New System.Drawing.Point(454, 2)
        Me.lblNoThesis.Name = "lblNoThesis"
        Me.lblNoThesis.Size = New System.Drawing.Size(27, 33)
        Me.lblNoThesis.TabIndex = 8
        Me.lblNoThesis.Text = "0"
        Me.lblNoThesis.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblNoStudent
        '
        Me.lblNoStudent.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lblNoStudent.AutoSize = True
        Me.lblNoStudent.Font = New System.Drawing.Font("Poppins Light", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNoStudent.Location = New System.Drawing.Point(454, 38)
        Me.lblNoStudent.Name = "lblNoStudent"
        Me.lblNoStudent.Size = New System.Drawing.Size(27, 33)
        Me.lblNoStudent.TabIndex = 10
        Me.lblNoStudent.Text = "0"
        Me.lblNoStudent.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label12
        '
        Me.Label12.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Poppins Light", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(454, 74)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(27, 33)
        Me.Label12.TabIndex = 11
        Me.Label12.Text = "0"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label10
        '
        Me.Label10.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Poppins Light", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(4, 74)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(344, 33)
        Me.Label10.TabIndex = 9
        Me.Label10.Text = "Total Numer of Borrowed Hardcopy" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label6
        '
        Me.Label6.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Poppins Light", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(4, 183)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(147, 33)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Total Overdue"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Guna2Elipse1
        '
        Me.Guna2Elipse1.BorderRadius = 3
        Me.Guna2Elipse1.TargetControl = Me
        '
        'EasyHTMLReports1
        '
        Me.EasyHTMLReports1.AlternativeRowBackgroundColor = System.Drawing.Color.FromArgb(CType(CType(229, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.EasyHTMLReports1.AlternativeRowGridColor = System.Drawing.Color.FromArgb(CType(CType(56, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.EasyHTMLReports1.HeaderBackgroundColor = System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(183, Byte), Integer), CType(CType(197, Byte), Integer))
        Me.EasyHTMLReports1.HeaderFontColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.EasyHTMLReports1.HeaderGridColor = System.Drawing.Color.FromArgb(CType(CType(56, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.EasyHTMLReports1.RowDefaultBackgroudColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.EasyHTMLReports1.RowDefaultFontColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.EasyHTMLReports1.RowDefaultGridColor = System.Drawing.Color.FromArgb(CType(CType(56, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(65, Byte), Integer))
        '
        'reports
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1190, 706)
        Me.Controls.Add(Me.Guna2Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "reports"
        Me.Text = "reports"
        Me.Guna2Panel1.ResumeLayout(False)
        Me.Guna2Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2Elipse1 As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents btnPrint As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Label1 As Label
    Friend WithEvents dtpFrom As Guna.UI2.WinForms.Guna2DateTimePicker
    Friend WithEvents Label2 As Label
    Friend WithEvents dtpTo As Guna.UI2.WinForms.Guna2DateTimePicker
    Friend WithEvents btnSearchDate As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents Label3 As Label
    Friend WithEvents prntDate As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents tb As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents lblNoThesis As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents lblNoStudent As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents EasyHTMLReports1 As KimToo.EasyHTMLReports
    Friend WithEvents lblTo As Label
    Friend WithEvents lblFrom As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label21 As Label
    Friend WithEvents Label22 As Label
    Friend WithEvents PictureBox1 As PictureBox
End Class
