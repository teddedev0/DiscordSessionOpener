<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Client1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Client1))
        Me.DLL = New System.Windows.Forms.Label()
        Me.XVisualTheme1 = New DiscordSessionOpener.xVisualTheme()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.XVisualButton1 = New DiscordSessionOpener.xVisualButton()
        Me.TextBox1 = New DiscordSessionOpener.xVisualTextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.XVisualTheme1.SuspendLayout()
        Me.SuspendLayout()
        '
        'DLL
        '
        Me.DLL.AutoSize = True
        Me.DLL.Location = New System.Drawing.Point(784, 116)
        Me.DLL.Name = "DLL"
        Me.DLL.Size = New System.Drawing.Size(39, 13)
        Me.DLL.TabIndex = 2
        Me.DLL.Text = "Label1"
        Me.DLL.Visible = False
        '
        'XVisualTheme1
        '
        Me.XVisualTheme1.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.XVisualTheme1.Controls.Add(Me.Label3)
        Me.XVisualTheme1.Controls.Add(Me.Label1)
        Me.XVisualTheme1.Controls.Add(Me.Label5)
        Me.XVisualTheme1.Controls.Add(Me.Label2)
        Me.XVisualTheme1.Controls.Add(Me.XVisualButton1)
        Me.XVisualTheme1.Controls.Add(Me.TextBox1)
        Me.XVisualTheme1.Controls.Add(Me.Panel1)
        Me.XVisualTheme1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.XVisualTheme1.Location = New System.Drawing.Point(0, 0)
        Me.XVisualTheme1.Name = "XVisualTheme1"
        Me.XVisualTheme1.Size = New System.Drawing.Size(812, 500)
        Me.XVisualTheme1.TabIndex = 9
        Me.XVisualTheme1.Text = "Client 1"
        '
        'Label3
        '
        Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.SeaShell
        Me.Label3.Location = New System.Drawing.Point(732, -8)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(22, 29)
        Me.Label3.TabIndex = 27
        Me.Label3.Text = "_"
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.SeaShell
        Me.Label1.Location = New System.Drawing.Point(753, -2)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(34, 29)
        Me.Label1.TabIndex = 26
        Me.Label1.Text = "🗖"
        '
        'Label5
        '
        Me.Label5.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.SeaShell
        Me.Label5.Location = New System.Drawing.Point(785, -1)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(24, 29)
        Me.Label5.TabIndex = 25
        Me.Label5.Text = "x"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(773, 487)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(39, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Label1"
        Me.Label2.Visible = False
        '
        'XVisualButton1
        '
        Me.XVisualButton1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.XVisualButton1.BackColor = System.Drawing.Color.Transparent
        Me.XVisualButton1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(205, Byte), Integer), CType(CType(205, Byte), Integer), CType(CType(205, Byte), Integer))
        Me.XVisualButton1.Location = New System.Drawing.Point(695, 59)
        Me.XVisualButton1.Name = "XVisualButton1"
        Me.XVisualButton1.Shade = DiscordSessionOpener.xVisualButton.InnerShade.Dark
        Me.XVisualButton1.Size = New System.Drawing.Size(100, 32)
        Me.XVisualButton1.TabIndex = 9
        Me.XVisualButton1.Text = "LOGIN"
        '
        'TextBox1
        '
        Me.TextBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox1.BackColor = System.Drawing.Color.Transparent
        Me.TextBox1.Location = New System.Drawing.Point(17, 63)
        Me.TextBox1.MaxLength = 32767
        Me.TextBox1.Multiline = False
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = False
        Me.TextBox1.Size = New System.Drawing.Size(672, 24)
        Me.TextBox1.Style = DiscordSessionOpener.xVisualTextBox.RoundingStyle.Normal
        Me.TextBox1.TabIndex = 8
        Me.TextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.TextBox1.UseSystemPasswordChar = False
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.Location = New System.Drawing.Point(17, 97)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(778, 366)
        Me.Panel1.TabIndex = 7
        '
        'Client1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(812, 500)
        Me.Controls.Add(Me.XVisualTheme1)
        Me.Controls.Add(Me.DLL)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Client1"
        Me.Text = "Form1"
        Me.TransparencyKey = System.Drawing.Color.Fuchsia
        Me.XVisualTheme1.ResumeLayout(False)
        Me.XVisualTheme1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DLL As Label
    Friend WithEvents XVisualTheme1 As xVisualTheme
    Friend WithEvents Label1 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents XVisualButton1 As xVisualButton
    Friend WithEvents TextBox1 As xVisualTextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label3 As Label
End Class
