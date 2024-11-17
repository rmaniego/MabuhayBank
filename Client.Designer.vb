<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Client
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
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Client))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.PictureBox2 = New System.Windows.Forms.PictureBox
        Me.ClientTitle = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.clientNm = New System.Windows.Forms.Label
        Me.Message = New System.Windows.Forms.Label
        Me.Messenger = New System.Windows.Forms.Timer(Me.components)
        Me.clientNo = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.Label2 = New System.Windows.Forms.Label
        Me.Button7 = New System.Windows.Forms.Button
        Me.TabControl1 = New System.Windows.Forms.TabControl
        Me.TabPage4 = New System.Windows.Forms.TabPage
        Me.Label5 = New System.Windows.Forms.Label
        Me.TabPage2 = New System.Windows.Forms.TabPage
        Me.Button6 = New System.Windows.Forms.Button
        Me.clientBal2 = New System.Windows.Forms.Label
        Me.Button1 = New System.Windows.Forms.Button
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.TabPage3 = New System.Windows.Forms.TabPage
        Me.clientTransfer = New System.Windows.Forms.Panel
        Me.clientAmount = New System.Windows.Forms.TextBox
        Me.Label15 = New System.Windows.Forms.Label
        Me.Button3 = New System.Windows.Forms.Button
        Me.Button5 = New System.Windows.Forms.Button
        Me.clientBal3 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.clientFound = New System.Windows.Forms.Label
        Me.Button4 = New System.Windows.Forms.Button
        Me.clientCheck = New System.Windows.Forms.TextBox
        Me.Label13 = New System.Windows.Forms.Label
        Me.TabPage1 = New System.Windows.Forms.TabPage
        Me.Button2 = New System.Windows.Forms.Button
        Me.clientBal = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.bridgeAmount = New System.Windows.Forms.Label
        Me.t4 = New System.Windows.Forms.Button
        Me.t2 = New System.Windows.Forms.Label
        Me.t1 = New System.Windows.Forms.Label
        Me.t3 = New System.Windows.Forms.PictureBox
        Me.t5 = New System.Windows.Forms.PictureBox
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage4.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.clientTransfer.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.t3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.t5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(20, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(50, 50)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 7
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.PictureBox2.Location = New System.Drawing.Point(-1, -4)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(646, 84)
        Me.PictureBox2.TabIndex = 8
        Me.PictureBox2.TabStop = False
        '
        'ClientTitle
        '
        Me.ClientTitle.AutoSize = True
        Me.ClientTitle.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientTitle.Font = New System.Drawing.Font("Rockwell", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ClientTitle.ForeColor = System.Drawing.Color.Gold
        Me.ClientTitle.Location = New System.Drawing.Point(82, 16)
        Me.ClientTitle.Name = "ClientTitle"
        Me.ClientTitle.Size = New System.Drawing.Size(538, 46)
        Me.ClientTitle.TabIndex = 9
        Me.ClientTitle.Text = "Welcome to Mabuhay Funds"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(12, 53)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(116, 19)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Account Name: "
        '
        'clientNm
        '
        Me.clientNm.AutoSize = True
        Me.clientNm.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.clientNm.ForeColor = System.Drawing.Color.Black
        Me.clientNm.Location = New System.Drawing.Point(134, 53)
        Me.clientNm.Name = "clientNm"
        Me.clientNm.Size = New System.Drawing.Size(101, 19)
        Me.clientNm.TabIndex = 11
        Me.clientNm.Text = "Juan Dela Cruz"
        '
        'Message
        '
        Me.Message.AutoSize = True
        Me.Message.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Message.Location = New System.Drawing.Point(595, 83)
        Me.Message.Name = "Message"
        Me.Message.Size = New System.Drawing.Size(194, 19)
        Me.Message.TabIndex = 12
        Me.Message.Text = "Thanks for banking with us!"
        Me.Message.Visible = False
        '
        'Messenger
        '
        Me.Messenger.Enabled = True
        '
        'clientNo
        '
        Me.clientNo.AutoSize = True
        Me.clientNo.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.clientNo.ForeColor = System.Drawing.Color.Black
        Me.clientNo.Location = New System.Drawing.Point(148, 17)
        Me.clientNo.Name = "clientNo"
        Me.clientNo.Size = New System.Drawing.Size(49, 19)
        Me.clientNo.TabIndex = 14
        Me.clientNo.Text = "00001"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(12, 17)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(130, 19)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "Account Number: "
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.Button7)
        Me.Panel2.Controls.Add(Me.clientNo)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.clientNm)
        Me.Panel2.ForeColor = System.Drawing.SystemColors.AppWorkspace
        Me.Panel2.Location = New System.Drawing.Point(12, 112)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(296, 322)
        Me.Panel2.TabIndex = 16
        Me.Panel2.Visible = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(12, 284)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(92, 19)
        Me.Label2.TabIndex = 16
        Me.Label2.Text = "Change PIN: "
        '
        'Button7
        '
        Me.Button7.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button7.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.Button7.Location = New System.Drawing.Point(110, 278)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(64, 30)
        Me.Button7.TabIndex = 15
        Me.Button7.Text = "Yes"
        Me.Button7.UseVisualStyleBackColor = True
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage4)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabControl1.Location = New System.Drawing.Point(326, 112)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(296, 322)
        Me.TabControl1.TabIndex = 0
        Me.TabControl1.Visible = False
        '
        'TabPage4
        '
        Me.TabPage4.BackColor = System.Drawing.Color.White
        Me.TabPage4.Controls.Add(Me.Label5)
        Me.TabPage4.Location = New System.Drawing.Point(4, 28)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Size = New System.Drawing.Size(288, 290)
        Me.TabPage4.TabIndex = 3
        Me.TabPage4.Text = "Home"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(54, 137)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(189, 19)
        Me.Label5.TabIndex = 15
        Me.Label5.Text = "Be sure that you are alone."
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.Color.White
        Me.TabPage2.Controls.Add(Me.Button6)
        Me.TabPage2.Controls.Add(Me.clientBal2)
        Me.TabPage2.Controls.Add(Me.Button1)
        Me.TabPage2.Controls.Add(Me.TextBox1)
        Me.TabPage2.Controls.Add(Me.Label3)
        Me.TabPage2.Controls.Add(Me.Label8)
        Me.TabPage2.Location = New System.Drawing.Point(4, 28)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(288, 290)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Withdraw"
        '
        'Button6
        '
        Me.Button6.Font = New System.Drawing.Font("Cambria", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button6.Location = New System.Drawing.Point(127, 89)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(121, 31)
        Me.Button6.TabIndex = 18
        Me.Button6.Text = "Refresh"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'clientBal2
        '
        Me.clientBal2.AutoSize = True
        Me.clientBal2.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.clientBal2.Location = New System.Drawing.Point(173, 56)
        Me.clientBal2.Name = "clientBal2"
        Me.clientBal2.Size = New System.Drawing.Size(21, 19)
        Me.clientBal2.TabIndex = 19
        Me.clientBal2.Text = "--"
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Cambria", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(127, 178)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(121, 31)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Continue"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(127, 136)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(121, 26)
        Me.TextBox1.TabIndex = 18
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(39, 56)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(128, 19)
        Me.Label3.TabIndex = 17
        Me.Label3.Text = "Current Balance: "
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(39, 139)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(82, 19)
        Me.Label8.TabIndex = 17
        Me.Label8.Text = "Withdraw: "
        '
        'TabPage3
        '
        Me.TabPage3.BackColor = System.Drawing.Color.White
        Me.TabPage3.Controls.Add(Me.clientTransfer)
        Me.TabPage3.Controls.Add(Me.Button5)
        Me.TabPage3.Controls.Add(Me.clientBal3)
        Me.TabPage3.Controls.Add(Me.Label9)
        Me.TabPage3.Controls.Add(Me.clientFound)
        Me.TabPage3.Controls.Add(Me.Button4)
        Me.TabPage3.Controls.Add(Me.clientCheck)
        Me.TabPage3.Controls.Add(Me.Label13)
        Me.TabPage3.Location = New System.Drawing.Point(4, 28)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Size = New System.Drawing.Size(288, 290)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Transfer"
        '
        'clientTransfer
        '
        Me.clientTransfer.Controls.Add(Me.clientAmount)
        Me.clientTransfer.Controls.Add(Me.Label15)
        Me.clientTransfer.Controls.Add(Me.Button3)
        Me.clientTransfer.Enabled = False
        Me.clientTransfer.Location = New System.Drawing.Point(3, 179)
        Me.clientTransfer.Name = "clientTransfer"
        Me.clientTransfer.Size = New System.Drawing.Size(282, 108)
        Me.clientTransfer.TabIndex = 26
        '
        'clientAmount
        '
        Me.clientAmount.Location = New System.Drawing.Point(101, 13)
        Me.clientAmount.MaxLength = 8
        Me.clientAmount.Name = "clientAmount"
        Me.clientAmount.Size = New System.Drawing.Size(151, 26)
        Me.clientAmount.TabIndex = 25
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(34, 16)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(70, 19)
        Me.Label15.TabIndex = 24
        Me.Label15.Text = "Amount: "
        '
        'Button3
        '
        Me.Button3.Font = New System.Drawing.Font("Cambria", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(101, 54)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(151, 31)
        Me.Button3.TabIndex = 19
        Me.Button3.Text = "Start"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Font = New System.Drawing.Font("Cambria", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.Location = New System.Drawing.Point(104, 74)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(151, 31)
        Me.Button5.TabIndex = 21
        Me.Button5.Text = "Refresh"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'clientBal3
        '
        Me.clientBal3.AutoSize = True
        Me.clientBal3.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.clientBal3.Location = New System.Drawing.Point(168, 41)
        Me.clientBal3.Name = "clientBal3"
        Me.clientBal3.Size = New System.Drawing.Size(21, 19)
        Me.clientBal3.TabIndex = 22
        Me.clientBal3.Text = "--"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(37, 41)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(128, 19)
        Me.Label9.TabIndex = 20
        Me.Label9.Text = "Current Balance: "
        '
        'clientFound
        '
        Me.clientFound.AutoSize = True
        Me.clientFound.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.clientFound.Location = New System.Drawing.Point(37, 150)
        Me.clientFound.Name = "clientFound"
        Me.clientFound.Size = New System.Drawing.Size(169, 19)
        Me.clientFound.TabIndex = 23
        Me.clientFound.Text = "Check to enable transfer..."
        '
        'Button4
        '
        Me.Button4.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.Location = New System.Drawing.Point(172, 121)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(83, 27)
        Me.Button4.TabIndex = 22
        Me.Button4.Text = "Check"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'clientCheck
        '
        Me.clientCheck.Location = New System.Drawing.Point(71, 121)
        Me.clientCheck.MaxLength = 5
        Me.clientCheck.Name = "clientCheck"
        Me.clientCheck.Size = New System.Drawing.Size(94, 26)
        Me.clientCheck.TabIndex = 21
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(37, 124)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(36, 19)
        Me.Label13.TabIndex = 20
        Me.Label13.Text = "To: "
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.Color.White
        Me.TabPage1.Controls.Add(Me.Button2)
        Me.TabPage1.Controls.Add(Me.clientBal)
        Me.TabPage1.Controls.Add(Me.Label7)
        Me.TabPage1.Location = New System.Drawing.Point(4, 28)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(288, 290)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Balance Inquiry"
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Cambria", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(124, 133)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(121, 31)
        Me.Button2.TabIndex = 15
        Me.Button2.Text = "Refresh"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'clientBal
        '
        Me.clientBal.AutoSize = True
        Me.clientBal.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.clientBal.Location = New System.Drawing.Point(163, 100)
        Me.clientBal.Name = "clientBal"
        Me.clientBal.Size = New System.Drawing.Size(21, 19)
        Me.clientBal.TabIndex = 16
        Me.clientBal.Text = "--"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(32, 99)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(128, 19)
        Me.Label7.TabIndex = 15
        Me.Label7.Text = "Current Balance: "
        '
        'bridgeAmount
        '
        Me.bridgeAmount.AutoSize = True
        Me.bridgeAmount.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bridgeAmount.Location = New System.Drawing.Point(636, 408)
        Me.bridgeAmount.Name = "bridgeAmount"
        Me.bridgeAmount.Size = New System.Drawing.Size(17, 19)
        Me.bridgeAmount.TabIndex = 15
        Me.bridgeAmount.Text = "0"
        '
        't4
        '
        Me.t4.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.t4.Location = New System.Drawing.Point(493, 350)
        Me.t4.Name = "t4"
        Me.t4.Size = New System.Drawing.Size(105, 35)
        Me.t4.TabIndex = 27
        Me.t4.Text = "Continue"
        Me.t4.UseVisualStyleBackColor = True
        Me.t4.Visible = False
        '
        't2
        '
        Me.t2.AutoSize = True
        Me.t2.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.t2.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.t2.Location = New System.Drawing.Point(145, 219)
        Me.t2.Name = "t2"
        Me.t2.Size = New System.Drawing.Size(313, 21)
        Me.t2.TabIndex = 26
        Me.t2.Text = """With patience come great beginnings."""
        Me.t2.Visible = False
        '
        't1
        '
        Me.t1.AutoSize = True
        Me.t1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.t1.Font = New System.Drawing.Font("Rockwell", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.t1.Location = New System.Drawing.Point(9, 157)
        Me.t1.Name = "t1"
        Me.t1.Size = New System.Drawing.Size(609, 190)
        Me.t1.TabIndex = 24
        Me.t1.Text = resources.GetString("t1.Text")
        Me.t1.Visible = False
        '
        't3
        '
        Me.t3.Image = CType(resources.GetObject("t3.Image"), System.Drawing.Image)
        Me.t3.Location = New System.Drawing.Point(85, 40)
        Me.t3.Name = "t3"
        Me.t3.Size = New System.Drawing.Size(448, 108)
        Me.t3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.t3.TabIndex = 25
        Me.t3.TabStop = False
        Me.t3.Visible = False
        '
        't5
        '
        Me.t5.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.t5.Location = New System.Drawing.Point(-6, -36)
        Me.t5.Name = "t5"
        Me.t5.Size = New System.Drawing.Size(646, 521)
        Me.t5.TabIndex = 23
        Me.t5.TabStop = False
        Me.t5.Visible = False
        '
        'Client
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(634, 448)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.Message)
        Me.Controls.Add(Me.ClientTitle)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.bridgeAmount)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.t4)
        Me.Controls.Add(Me.t2)
        Me.Controls.Add(Me.t1)
        Me.Controls.Add(Me.t3)
        Me.Controls.Add(Me.t5)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximumSize = New System.Drawing.Size(640, 480)
        Me.MinimumSize = New System.Drawing.Size(640, 480)
        Me.Name = "Client"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Client"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage4.ResumeLayout(False)
        Me.TabPage4.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage3.PerformLayout()
        Me.clientTransfer.ResumeLayout(False)
        Me.clientTransfer.PerformLayout()
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        CType(Me.t3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.t5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents ClientTitle As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents clientNm As System.Windows.Forms.Label
    Friend WithEvents Message As System.Windows.Forms.Label
    Friend WithEvents Messenger As System.Windows.Forms.Timer
    Friend WithEvents clientNo As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage4 As System.Windows.Forms.TabPage
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents clientBal As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents clientCheck As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents clientFound As System.Windows.Forms.Label
    Friend WithEvents clientAmount As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents clientBal2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents clientBal3 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents clientTransfer As System.Windows.Forms.Panel
    Friend WithEvents bridgeAmount As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Button7 As System.Windows.Forms.Button
    Friend WithEvents t4 As System.Windows.Forms.Button
    Friend WithEvents t2 As System.Windows.Forms.Label
    Friend WithEvents t1 As System.Windows.Forms.Label
    Friend WithEvents t3 As System.Windows.Forms.PictureBox
    Friend WithEvents t5 As System.Windows.Forms.PictureBox
End Class
