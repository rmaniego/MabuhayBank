<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Edit_Account
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Edit_Account))
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.foneNo = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.address = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.lastNm = New System.Windows.Forms.TextBox
        Me.firstNm = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.ClientTitle = New System.Windows.Forms.Label
        Me.PictureBox2 = New System.Windows.Forms.PictureBox
        Me.addCreate = New System.Windows.Forms.Button
        Me.addCancel = New System.Windows.Forms.Button
        Me.PictureBox3 = New System.Windows.Forms.PictureBox
        Me.BridgeAccno = New System.Windows.Forms.Label
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.foneNo)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.address)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.lastNm)
        Me.Panel1.Controls.Add(Me.firstNm)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(8, 96)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(608, 155)
        Me.Panel1.TabIndex = 28
        '
        'foneNo
        '
        Me.foneNo.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.foneNo.Location = New System.Drawing.Point(501, 45)
        Me.foneNo.MaxLength = 50
        Me.foneNo.Name = "foneNo"
        Me.foneNo.Size = New System.Drawing.Size(101, 26)
        Me.foneNo.TabIndex = 13
        Me.foneNo.Text = "3354878"
        Me.foneNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(420, 48)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(75, 19)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Contact:"
        '
        'address
        '
        Me.address.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.address.Location = New System.Drawing.Point(96, 77)
        Me.address.MaxLength = 50
        Me.address.Name = "address"
        Me.address.Size = New System.Drawing.Size(506, 26)
        Me.address.TabIndex = 11
        Me.address.Text = "City, Province, State"
        Me.address.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(15, 80)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(79, 19)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Address:"
        '
        'lastNm
        '
        Me.lastNm.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lastNm.Location = New System.Drawing.Point(247, 45)
        Me.lastNm.MaxLength = 50
        Me.lastNm.Name = "lastNm"
        Me.lastNm.Size = New System.Drawing.Size(167, 26)
        Me.lastNm.TabIndex = 5
        Me.lastNm.Text = "Last"
        Me.lastNm.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'firstNm
        '
        Me.firstNm.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.firstNm.Location = New System.Drawing.Point(80, 45)
        Me.firstNm.MaxLength = 50
        Me.firstNm.Name = "firstNm"
        Me.firstNm.Size = New System.Drawing.Size(157, 26)
        Me.firstNm.TabIndex = 3
        Me.firstNm.Text = "First"
        Me.firstNm.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(15, 48)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(59, 19)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Name:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(15, 10)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(147, 26)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Account Details"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(14, 14)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(50, 50)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 30
        Me.PictureBox1.TabStop = False
        '
        'ClientTitle
        '
        Me.ClientTitle.AutoSize = True
        Me.ClientTitle.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientTitle.Font = New System.Drawing.Font("Rockwell", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ClientTitle.ForeColor = System.Drawing.Color.Gold
        Me.ClientTitle.Location = New System.Drawing.Point(76, 18)
        Me.ClientTitle.Name = "ClientTitle"
        Me.ClientTitle.Size = New System.Drawing.Size(456, 46)
        Me.ClientTitle.TabIndex = 32
        Me.ClientTitle.Text = "Mabuhay Funds System"
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.PictureBox2.Location = New System.Drawing.Point(-7, -2)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(646, 84)
        Me.PictureBox2.TabIndex = 31
        Me.PictureBox2.TabStop = False
        '
        'addCreate
        '
        Me.addCreate.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.addCreate.Location = New System.Drawing.Point(437, 300)
        Me.addCreate.Name = "addCreate"
        Me.addCreate.Size = New System.Drawing.Size(81, 40)
        Me.addCreate.TabIndex = 27
        Me.addCreate.Text = "Save"
        Me.addCreate.UseVisualStyleBackColor = True
        '
        'addCancel
        '
        Me.addCancel.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.addCancel.Location = New System.Drawing.Point(524, 300)
        Me.addCancel.Name = "addCancel"
        Me.addCancel.Size = New System.Drawing.Size(86, 40)
        Me.addCancel.TabIndex = 29
        Me.addCancel.Text = "Cancel"
        Me.addCancel.UseVisualStyleBackColor = True
        '
        'PictureBox3
        '
        Me.PictureBox3.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.PictureBox3.Location = New System.Drawing.Point(-7, 270)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(646, 93)
        Me.PictureBox3.TabIndex = 33
        Me.PictureBox3.TabStop = False
        '
        'BridgeAccno
        '
        Me.BridgeAccno.AutoSize = True
        Me.BridgeAccno.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BridgeAccno.Location = New System.Drawing.Point(645, 217)
        Me.BridgeAccno.Name = "BridgeAccno"
        Me.BridgeAccno.Size = New System.Drawing.Size(18, 19)
        Me.BridgeAccno.TabIndex = 14
        Me.BridgeAccno.Text = "0"
        '
        'Edit_Account
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(632, 361)
        Me.Controls.Add(Me.BridgeAccno)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.ClientTitle)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.addCreate)
        Me.Controls.Add(Me.addCancel)
        Me.Controls.Add(Me.PictureBox3)
        Me.MaximumSize = New System.Drawing.Size(640, 395)
        Me.MinimumSize = New System.Drawing.Size(640, 395)
        Me.Name = "Edit_Account"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Edit Account"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents foneNo As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents address As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents lastNm As System.Windows.Forms.TextBox
    Friend WithEvents firstNm As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents ClientTitle As System.Windows.Forms.Label
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents addCreate As System.Windows.Forms.Button
    Friend WithEvents addCancel As System.Windows.Forms.Button
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents BridgeAccno As System.Windows.Forms.Label
End Class
