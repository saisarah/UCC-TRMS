<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class recentBorrowed
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Me.Guna2Panel6 = New Guna.UI2.WinForms.Guna2Panel()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.lblCode = New System.Windows.Forms.Label()
        Me.lblDate = New System.Windows.Forms.Label()
        Me.lblBorrower = New System.Windows.Forms.Label()
        Me.Guna2Panel6.SuspendLayout()
        Me.SuspendLayout()
        '
        'Guna2Panel6
        '
        Me.Guna2Panel6.BackColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.Guna2Panel6.Controls.Add(Me.lblBorrower)
        Me.Guna2Panel6.Controls.Add(Me.lblTitle)
        Me.Guna2Panel6.Controls.Add(Me.lblCode)
        Me.Guna2Panel6.Controls.Add(Me.lblDate)
        Me.Guna2Panel6.CustomBorderColor = System.Drawing.Color.Gainsboro
        Me.Guna2Panel6.CustomBorderThickness = New System.Windows.Forms.Padding(0, 0, 0, 1)
        Me.Guna2Panel6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Guna2Panel6.Location = New System.Drawing.Point(0, 0)
        Me.Guna2Panel6.Name = "Guna2Panel6"
        Me.Guna2Panel6.ShadowDecoration.Parent = Me.Guna2Panel6
        Me.Guna2Panel6.Size = New System.Drawing.Size(1077, 59)
        Me.Guna2Panel6.TabIndex = 16
        '
        'lblTitle
        '
        Me.lblTitle.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblTitle.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.ForeColor = System.Drawing.Color.White
        Me.lblTitle.Location = New System.Drawing.Point(223, 19)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(313, 21)
        Me.lblTitle.TabIndex = 12
        Me.lblTitle.Text = "TITLE"
        Me.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblCode
        '
        Me.lblCode.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblCode.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCode.ForeColor = System.Drawing.Color.White
        Me.lblCode.Location = New System.Drawing.Point(31, 19)
        Me.lblCode.Name = "lblCode"
        Me.lblCode.Size = New System.Drawing.Size(161, 21)
        Me.lblCode.TabIndex = 6
        Me.lblCode.Text = "CODE"
        Me.lblCode.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblDate
        '
        Me.lblDate.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblDate.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDate.ForeColor = System.Drawing.Color.White
        Me.lblDate.Location = New System.Drawing.Point(562, 19)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(232, 21)
        Me.lblDate.TabIndex = 11
        Me.lblDate.Text = "DATE ISSUED"
        Me.lblDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblBorrower
        '
        Me.lblBorrower.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblBorrower.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBorrower.ForeColor = System.Drawing.Color.White
        Me.lblBorrower.Location = New System.Drawing.Point(820, 19)
        Me.lblBorrower.Name = "lblBorrower"
        Me.lblBorrower.Size = New System.Drawing.Size(251, 21)
        Me.lblBorrower.TabIndex = 13
        Me.lblBorrower.Text = "BORROWER"
        Me.lblBorrower.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'recentBorrowed
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.Guna2Panel6)
        Me.Name = "recentBorrowed"
        Me.Size = New System.Drawing.Size(1077, 59)
        Me.Guna2Panel6.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Guna2Panel6 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents lblTitle As Label
    Friend WithEvents lblCode As Label
    Friend WithEvents lblDate As Label
    Friend WithEvents lblBorrower As Label
End Class
