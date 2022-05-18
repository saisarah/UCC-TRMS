<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Confirmation
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Confirmation))
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.lblmsg = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnYesOk = New Guna.UI2.WinForms.Guna2Button()
        Me.btnNoCancel = New Guna.UI2.WinForms.Guna2Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Guna2Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.Image = Global.UCC_TRMS.My.Resources.Resources.question__2_
        Me.PictureBox2.Location = New System.Drawing.Point(0, 30)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(399, 88)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 1
        Me.PictureBox2.TabStop = False
        '
        'lblmsg
        '
        Me.lblmsg.BackColor = System.Drawing.Color.Transparent
        Me.lblmsg.Font = New System.Drawing.Font("Arial Narrow", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblmsg.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.lblmsg.Location = New System.Drawing.Point(1, 201)
        Me.lblmsg.Name = "lblmsg"
        Me.lblmsg.Size = New System.Drawing.Size(396, 23)
        Me.lblmsg.TabIndex = 2
        Me.lblmsg.Text = "Do you want to save this record?"
        Me.lblmsg.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Arial Narrow", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(146, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(0, 134)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(400, 42)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Wait!"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnYesOk
        '
        Me.btnYesOk.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnYesOk.BackColor = System.Drawing.Color.Transparent
        Me.btnYesOk.BorderColor = System.Drawing.Color.Empty
        Me.btnYesOk.BorderRadius = 5
        Me.btnYesOk.CheckedState.Parent = Me.btnYesOk
        Me.btnYesOk.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnYesOk.CustomImages.Parent = Me.btnYesOk
        Me.btnYesOk.FillColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(146, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnYesOk.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnYesOk.ForeColor = System.Drawing.Color.White
        Me.btnYesOk.HoverState.Parent = Me.btnYesOk
        Me.btnYesOk.Location = New System.Drawing.Point(73, 244)
        Me.btnYesOk.Name = "btnYesOk"
        Me.btnYesOk.ShadowDecoration.Depth = 255
        Me.btnYesOk.ShadowDecoration.Parent = Me.btnYesOk
        Me.btnYesOk.Size = New System.Drawing.Size(112, 34)
        Me.btnYesOk.TabIndex = 16
        Me.btnYesOk.Text = "Yes"
        '
        'btnNoCancel
        '
        Me.btnNoCancel.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnNoCancel.BackColor = System.Drawing.Color.Transparent
        Me.btnNoCancel.BorderRadius = 5
        Me.btnNoCancel.CheckedState.Parent = Me.btnNoCancel
        Me.btnNoCancel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnNoCancel.CustomImages.Parent = Me.btnNoCancel
        Me.btnNoCancel.FillColor = System.Drawing.Color.FromArgb(CType(CType(76, Byte), Integer), CType(CType(71, Byte), Integer), CType(CType(67, Byte), Integer))
        Me.btnNoCancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNoCancel.ForeColor = System.Drawing.Color.White
        Me.btnNoCancel.HoverState.Parent = Me.btnNoCancel
        Me.btnNoCancel.Location = New System.Drawing.Point(213, 244)
        Me.btnNoCancel.Name = "btnNoCancel"
        Me.btnNoCancel.ShadowDecoration.Depth = 255
        Me.btnNoCancel.ShadowDecoration.Parent = Me.btnNoCancel
        Me.btnNoCancel.Size = New System.Drawing.Size(112, 34)
        Me.btnNoCancel.TabIndex = 17
        Me.btnNoCancel.Text = "No"
        '
        'Timer1
        '
        '
        'Guna2Panel1
        '
        Me.Guna2Panel1.BackColor = System.Drawing.Color.White
        Me.Guna2Panel1.Controls.Add(Me.PictureBox1)
        Me.Guna2Panel1.Controls.Add(Me.Label2)
        Me.Guna2Panel1.Controls.Add(Me.PictureBox2)
        Me.Guna2Panel1.Controls.Add(Me.btnNoCancel)
        Me.Guna2Panel1.Controls.Add(Me.lblmsg)
        Me.Guna2Panel1.Controls.Add(Me.btnYesOk)
        Me.Guna2Panel1.ImeMode = System.Windows.Forms.ImeMode.[On]
        Me.Guna2Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Guna2Panel1.Name = "Guna2Panel1"
        Me.Guna2Panel1.ShadowDecoration.BorderRadius = 0
        Me.Guna2Panel1.ShadowDecoration.Color = System.Drawing.Color.Transparent
        Me.Guna2Panel1.ShadowDecoration.Depth = 0
        Me.Guna2Panel1.ShadowDecoration.Enabled = True
        Me.Guna2Panel1.ShadowDecoration.Parent = Me.Guna2Panel1
        Me.Guna2Panel1.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(0)
        Me.Guna2Panel1.Size = New System.Drawing.Size(400, 398)
        Me.Guna2Panel1.TabIndex = 18
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.White
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(0, 308)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(399, 185)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 18
        Me.PictureBox1.TabStop = False
        '
        'Confirmation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(400, 398)
        Me.Controls.Add(Me.Guna2Panel1)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Confirmation"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Confirmation"
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Guna2Panel1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents lblmsg As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents PictureBox1 As PictureBox
    Public WithEvents btnYesOk As Guna.UI2.WinForms.Guna2Button
    Public WithEvents btnNoCancel As Guna.UI2.WinForms.Guna2Button
End Class
