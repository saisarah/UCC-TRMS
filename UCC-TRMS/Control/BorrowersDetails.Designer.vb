<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BorrowersDetails
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Guna2Panel4 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.lblCleared = New System.Windows.Forms.Label()
        Me.Guna2Panel3 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblPending = New System.Windows.Forms.Label()
        Me.Guna2Panel5 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.lblBorrowed = New System.Windows.Forms.Label()
        Me.Guna2Panel6 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.lblOverDue = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.Guna2Panel4.SuspendLayout()
        Me.Guna2Panel3.SuspendLayout()
        Me.Guna2Panel5.SuspendLayout()
        Me.Guna2Panel6.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.Guna2Panel4)
        Me.Panel1.Controls.Add(Me.Guna2Panel3)
        Me.Panel1.Controls.Add(Me.Guna2Panel5)
        Me.Panel1.Controls.Add(Me.Guna2Panel6)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(297, 299)
        Me.Panel1.TabIndex = 22
        '
        'Guna2Panel4
        '
        Me.Guna2Panel4.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Guna2Panel4.BackColor = System.Drawing.Color.FromArgb(CType(CType(76, Byte), Integer), CType(CType(71, Byte), Integer), CType(CType(67, Byte), Integer))
        Me.Guna2Panel4.Controls.Add(Me.Label9)
        Me.Guna2Panel4.Controls.Add(Me.lblCleared)
        Me.Guna2Panel4.Location = New System.Drawing.Point(151, 152)
        Me.Guna2Panel4.Name = "Guna2Panel4"
        Me.Guna2Panel4.ShadowDecoration.Parent = Me.Guna2Panel4
        Me.Guna2Panel4.Size = New System.Drawing.Size(140, 140)
        Me.Guna2Panel4.TabIndex = 1
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Poppins", 10.0!)
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(2, 103)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(137, 37)
        Me.Label9.TabIndex = 16
        Me.Label9.Text = "CLEARED PAYMENT"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblCleared
        '
        Me.lblCleared.BackColor = System.Drawing.Color.Transparent
        Me.lblCleared.Font = New System.Drawing.Font("Poppins", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCleared.ForeColor = System.Drawing.Color.White
        Me.lblCleared.Location = New System.Drawing.Point(38, 26)
        Me.lblCleared.Name = "lblCleared"
        Me.lblCleared.Size = New System.Drawing.Size(67, 85)
        Me.lblCleared.TabIndex = 15
        Me.lblCleared.Text = "0"
        Me.lblCleared.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Guna2Panel3
        '
        Me.Guna2Panel3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Guna2Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(195, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.Guna2Panel3.Controls.Add(Me.Label1)
        Me.Guna2Panel3.Controls.Add(Me.lblPending)
        Me.Guna2Panel3.Location = New System.Drawing.Point(6, 152)
        Me.Guna2Panel3.Name = "Guna2Panel3"
        Me.Guna2Panel3.ShadowDecoration.Parent = Me.Guna2Panel3
        Me.Guna2Panel3.Size = New System.Drawing.Size(140, 140)
        Me.Guna2Panel3.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Poppins", 10.0!)
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(4, 103)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(137, 37)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "PENDING PAYMENT"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblPending
        '
        Me.lblPending.BackColor = System.Drawing.Color.Transparent
        Me.lblPending.Font = New System.Drawing.Font("Poppins", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPending.ForeColor = System.Drawing.Color.White
        Me.lblPending.Location = New System.Drawing.Point(43, 26)
        Me.lblPending.Name = "lblPending"
        Me.lblPending.Size = New System.Drawing.Size(67, 85)
        Me.lblPending.TabIndex = 13
        Me.lblPending.Text = "0"
        Me.lblPending.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Guna2Panel5
        '
        Me.Guna2Panel5.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Guna2Panel5.BackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(104, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.Guna2Panel5.Controls.Add(Me.Label11)
        Me.Guna2Panel5.Controls.Add(Me.lblBorrowed)
        Me.Guna2Panel5.Location = New System.Drawing.Point(151, 6)
        Me.Guna2Panel5.Name = "Guna2Panel5"
        Me.Guna2Panel5.ShadowDecoration.Parent = Me.Guna2Panel5
        Me.Guna2Panel5.Size = New System.Drawing.Size(140, 140)
        Me.Guna2Panel5.TabIndex = 1
        '
        'Label11
        '
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Poppins", 15.0!)
        Me.Label11.ForeColor = System.Drawing.Color.White
        Me.Label11.Location = New System.Drawing.Point(10, 93)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(127, 47)
        Me.Label11.TabIndex = 14
        Me.Label11.Text = "BORROWED"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblBorrowed
        '
        Me.lblBorrowed.BackColor = System.Drawing.Color.Transparent
        Me.lblBorrowed.Font = New System.Drawing.Font("Poppins", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBorrowed.ForeColor = System.Drawing.Color.White
        Me.lblBorrowed.Location = New System.Drawing.Point(38, 34)
        Me.lblBorrowed.Name = "lblBorrowed"
        Me.lblBorrowed.Size = New System.Drawing.Size(67, 85)
        Me.lblBorrowed.TabIndex = 13
        Me.lblBorrowed.Text = "0"
        Me.lblBorrowed.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Guna2Panel6
        '
        Me.Guna2Panel6.BackColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.Guna2Panel6.Controls.Add(Me.Label14)
        Me.Guna2Panel6.Controls.Add(Me.lblOverDue)
        Me.Guna2Panel6.Location = New System.Drawing.Point(6, 6)
        Me.Guna2Panel6.Name = "Guna2Panel6"
        Me.Guna2Panel6.ShadowDecoration.Parent = Me.Guna2Panel6
        Me.Guna2Panel6.Size = New System.Drawing.Size(140, 140)
        Me.Guna2Panel6.TabIndex = 0
        '
        'Label14
        '
        Me.Label14.BackColor = System.Drawing.Color.Transparent
        Me.Label14.Font = New System.Drawing.Font("Poppins", 15.0!)
        Me.Label14.ForeColor = System.Drawing.Color.White
        Me.Label14.Location = New System.Drawing.Point(24, 93)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(105, 47)
        Me.Label14.TabIndex = 12
        Me.Label14.Text = "OVERDUE"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblOverDue
        '
        Me.lblOverDue.BackColor = System.Drawing.Color.Transparent
        Me.lblOverDue.Font = New System.Drawing.Font("Poppins", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOverDue.ForeColor = System.Drawing.Color.White
        Me.lblOverDue.Location = New System.Drawing.Point(43, 34)
        Me.lblOverDue.Name = "lblOverDue"
        Me.lblOverDue.Size = New System.Drawing.Size(67, 85)
        Me.lblOverDue.TabIndex = 11
        Me.lblOverDue.Text = "0"
        Me.lblOverDue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BorrowersDetails
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.Panel1)
        Me.Name = "BorrowersDetails"
        Me.Size = New System.Drawing.Size(297, 299)
        Me.Panel1.ResumeLayout(False)
        Me.Guna2Panel4.ResumeLayout(False)
        Me.Guna2Panel3.ResumeLayout(False)
        Me.Guna2Panel5.ResumeLayout(False)
        Me.Guna2Panel6.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Guna2Panel4 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Label9 As Label
    Friend WithEvents lblCleared As Label
    Friend WithEvents Guna2Panel3 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents lblPending As Label
    Friend WithEvents Guna2Panel5 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Label11 As Label
    Friend WithEvents lblBorrowed As Label
    Friend WithEvents Guna2Panel6 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Label14 As Label
    Friend WithEvents lblOverDue As Label
End Class
