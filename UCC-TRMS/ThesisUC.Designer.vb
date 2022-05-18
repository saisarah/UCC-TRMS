<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ThesisUC
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
        Me.lblCategory = New System.Windows.Forms.Label()
        Me.lblLimi = New System.Windows.Forms.Label()
        Me.lblScope = New System.Windows.Forms.Label()
        Me.lblObjectives = New System.Windows.Forms.Label()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.lblCode = New System.Windows.Forms.Label()
        Me.Guna2Panel4 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Guna2Panel4.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblCategory
        '
        Me.lblCategory.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblCategory.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCategory.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblCategory.Location = New System.Drawing.Point(638, 18)
        Me.lblCategory.Name = "lblCategory"
        Me.lblCategory.Size = New System.Drawing.Size(121, 21)
        Me.lblCategory.TabIndex = 11
        Me.lblCategory.Text = "CATEGORY"
        Me.lblCategory.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblLimi
        '
        Me.lblLimi.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblLimi.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLimi.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblLimi.Location = New System.Drawing.Point(511, 18)
        Me.lblLimi.Name = "lblLimi"
        Me.lblLimi.Size = New System.Drawing.Size(121, 21)
        Me.lblLimi.TabIndex = 10
        Me.lblLimi.Text = "LIMITATION"
        Me.lblLimi.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblScope
        '
        Me.lblScope.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblScope.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblScope.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblScope.Location = New System.Drawing.Point(384, 18)
        Me.lblScope.Name = "lblScope"
        Me.lblScope.Size = New System.Drawing.Size(121, 21)
        Me.lblScope.TabIndex = 9
        Me.lblScope.Text = "SCOPE"
        Me.lblScope.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblObjectives
        '
        Me.lblObjectives.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblObjectives.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblObjectives.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblObjectives.Location = New System.Drawing.Point(257, 18)
        Me.lblObjectives.Name = "lblObjectives"
        Me.lblObjectives.Size = New System.Drawing.Size(121, 21)
        Me.lblObjectives.TabIndex = 8
        Me.lblObjectives.Text = "OBJECTIVES"
        Me.lblObjectives.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblTitle
        '
        Me.lblTitle.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblTitle.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblTitle.Location = New System.Drawing.Point(130, 18)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(121, 21)
        Me.lblTitle.TabIndex = 7
        Me.lblTitle.Text = "TITLE"
        Me.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblCode
        '
        Me.lblCode.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblCode.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCode.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblCode.Location = New System.Drawing.Point(3, 18)
        Me.lblCode.Name = "lblCode"
        Me.lblCode.Size = New System.Drawing.Size(121, 21)
        Me.lblCode.TabIndex = 6
        Me.lblCode.Text = "CODE"
        Me.lblCode.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Guna2Panel4
        '
        Me.Guna2Panel4.Controls.Add(Me.lblCode)
        Me.Guna2Panel4.Controls.Add(Me.lblTitle)
        Me.Guna2Panel4.Controls.Add(Me.lblScope)
        Me.Guna2Panel4.Controls.Add(Me.lblLimi)
        Me.Guna2Panel4.Controls.Add(Me.lblCategory)
        Me.Guna2Panel4.Controls.Add(Me.lblObjectives)
        Me.Guna2Panel4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Guna2Panel4.CustomBorderColor = System.Drawing.Color.Gainsboro
        Me.Guna2Panel4.CustomBorderThickness = New System.Windows.Forms.Padding(0, 0, 0, 2)
        Me.Guna2Panel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Guna2Panel4.Location = New System.Drawing.Point(0, 0)
        Me.Guna2Panel4.Name = "Guna2Panel4"
        Me.Guna2Panel4.ShadowDecoration.Parent = Me.Guna2Panel4
        Me.Guna2Panel4.Size = New System.Drawing.Size(774, 58)
        Me.Guna2Panel4.TabIndex = 12
        '
        'ThesisUC
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.Guna2Panel4)
        Me.Name = "ThesisUC"
        Me.Size = New System.Drawing.Size(774, 58)
        Me.Guna2Panel4.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lblCategory As Label
    Friend WithEvents lblLimi As Label
    Friend WithEvents lblScope As Label
    Friend WithEvents lblObjectives As Label
    Friend WithEvents lblTitle As Label
    Friend WithEvents lblCode As Label
    Friend WithEvents Guna2Panel4 As Guna.UI2.WinForms.Guna2Panel
End Class
