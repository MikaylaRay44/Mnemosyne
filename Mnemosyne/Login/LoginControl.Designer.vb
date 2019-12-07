<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LoginControl
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
        Me.LoginTableLayoutPanel = New System.Windows.Forms.TableLayoutPanel()
        Me.UsernameTableLayoutPanel = New System.Windows.Forms.TableLayoutPanel()
        Me.UsernameSplitter = New System.Windows.Forms.Splitter()
        Me.PasswordTableLayoutPanel = New System.Windows.Forms.TableLayoutPanel()
        Me.PasswordSplitter = New System.Windows.Forms.Splitter()
        Me.LoginButton = New System.Windows.Forms.Button()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.RegisterButton = New System.Windows.Forms.Button()
        Me.RecoverButton = New System.Windows.Forms.Button()
        Me.LogoPictureBox = New System.Windows.Forms.PictureBox()
        Me.LoginTableLayoutPanel.SuspendLayout()
        Me.UsernameTableLayoutPanel.SuspendLayout()
        Me.PasswordTableLayoutPanel.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.LogoPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LoginTableLayoutPanel
        '
        Me.LoginTableLayoutPanel.ColumnCount = 3
        Me.LoginTableLayoutPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.LoginTableLayoutPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.LoginTableLayoutPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.LoginTableLayoutPanel.Controls.Add(Me.LogoPictureBox, 0, 1)
        Me.LoginTableLayoutPanel.Controls.Add(Me.UsernameTableLayoutPanel, 1, 3)
        Me.LoginTableLayoutPanel.Controls.Add(Me.PasswordTableLayoutPanel, 1, 4)
        Me.LoginTableLayoutPanel.Controls.Add(Me.LoginButton, 1, 6)
        Me.LoginTableLayoutPanel.Controls.Add(Me.TableLayoutPanel1, 1, 8)
        Me.LoginTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LoginTableLayoutPanel.Location = New System.Drawing.Point(0, 0)
        Me.LoginTableLayoutPanel.Name = "LoginTableLayoutPanel"
        Me.LoginTableLayoutPanel.RowCount = 10
        Me.LoginTableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 15.0!))
        Me.LoginTableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 45.0!))
        Me.LoginTableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 15.0!))
        Me.LoginTableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.0!))
        Me.LoginTableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.0!))
        Me.LoginTableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 15.0!))
        Me.LoginTableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.0!))
        Me.LoginTableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 15.0!))
        Me.LoginTableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.LoginTableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 15.0!))
        Me.LoginTableLayoutPanel.Size = New System.Drawing.Size(400, 400)
        Me.LoginTableLayoutPanel.TabIndex = 0
        '
        'UsernameTableLayoutPanel
        '
        Me.UsernameTableLayoutPanel.ColumnCount = 3
        Me.UsernameTableLayoutPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.UsernameTableLayoutPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.UsernameTableLayoutPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.UsernameTableLayoutPanel.Controls.Add(Me.UsernameSplitter, 0, 1)
        Me.UsernameTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UsernameTableLayoutPanel.Location = New System.Drawing.Point(33, 179)
        Me.UsernameTableLayoutPanel.Name = "UsernameTableLayoutPanel"
        Me.UsernameTableLayoutPanel.RowCount = 2
        Me.UsernameTableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.UsernameTableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10.0!))
        Me.UsernameTableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.UsernameTableLayoutPanel.Size = New System.Drawing.Size(334, 42)
        Me.UsernameTableLayoutPanel.TabIndex = 1
        '
        'UsernameSplitter
        '
        Me.UsernameSplitter.BackColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(218, Byte), Integer))
        Me.UsernameTableLayoutPanel.SetColumnSpan(Me.UsernameSplitter, 3)
        Me.UsernameSplitter.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.UsernameSplitter.Location = New System.Drawing.Point(0, 36)
        Me.UsernameSplitter.Margin = New System.Windows.Forms.Padding(0, 3, 0, 3)
        Me.UsernameSplitter.Name = "UsernameSplitter"
        Me.UsernameSplitter.Size = New System.Drawing.Size(334, 3)
        Me.UsernameSplitter.TabIndex = 1
        Me.UsernameSplitter.TabStop = False
        '
        'PasswordTableLayoutPanel
        '
        Me.PasswordTableLayoutPanel.ColumnCount = 3
        Me.PasswordTableLayoutPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.PasswordTableLayoutPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.PasswordTableLayoutPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.PasswordTableLayoutPanel.Controls.Add(Me.PasswordSplitter, 0, 1)
        Me.PasswordTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PasswordTableLayoutPanel.Location = New System.Drawing.Point(33, 227)
        Me.PasswordTableLayoutPanel.Name = "PasswordTableLayoutPanel"
        Me.PasswordTableLayoutPanel.RowCount = 2
        Me.PasswordTableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.PasswordTableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10.0!))
        Me.PasswordTableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.PasswordTableLayoutPanel.Size = New System.Drawing.Size(334, 42)
        Me.PasswordTableLayoutPanel.TabIndex = 2
        '
        'PasswordSplitter
        '
        Me.PasswordSplitter.BackColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(218, Byte), Integer))
        Me.PasswordTableLayoutPanel.SetColumnSpan(Me.PasswordSplitter, 3)
        Me.PasswordSplitter.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PasswordSplitter.Location = New System.Drawing.Point(0, 36)
        Me.PasswordSplitter.Margin = New System.Windows.Forms.Padding(0, 3, 0, 3)
        Me.PasswordSplitter.Name = "PasswordSplitter"
        Me.PasswordSplitter.Size = New System.Drawing.Size(334, 3)
        Me.PasswordSplitter.TabIndex = 1
        Me.PasswordSplitter.TabStop = False
        '
        'LoginButton
        '
        Me.LoginButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(218, Byte), Integer))
        Me.LoginButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.LoginButton.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LoginButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.LoginButton.Font = New System.Drawing.Font("Montserrat Medium", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LoginButton.ForeColor = System.Drawing.Color.FromArgb(CType(CType(166, Byte), Integer), CType(CType(144, Byte), Integer), CType(CType(126, Byte), Integer))
        Me.LoginButton.Location = New System.Drawing.Point(30, 287)
        Me.LoginButton.Margin = New System.Windows.Forms.Padding(0)
        Me.LoginButton.Name = "LoginButton"
        Me.LoginButton.Size = New System.Drawing.Size(340, 48)
        Me.LoginButton.TabIndex = 3
        Me.LoginButton.Text = "LOGIN"
        Me.LoginButton.UseVisualStyleBackColor = False
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 3
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.RegisterButton, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.RecoverButton, 2, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(33, 353)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(334, 26)
        Me.TableLayoutPanel1.TabIndex = 4
        '
        'RegisterButton
        '
        Me.RegisterButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.RegisterButton.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RegisterButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.RegisterButton.Font = New System.Drawing.Font("Montserrat Medium", 8.249999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RegisterButton.ForeColor = System.Drawing.Color.FromArgb(CType(CType(166, Byte), Integer), CType(CType(144, Byte), Integer), CType(CType(126, Byte), Integer))
        Me.RegisterButton.Location = New System.Drawing.Point(0, 0)
        Me.RegisterButton.Margin = New System.Windows.Forms.Padding(0)
        Me.RegisterButton.Name = "RegisterButton"
        Me.RegisterButton.Size = New System.Drawing.Size(100, 26)
        Me.RegisterButton.TabIndex = 0
        Me.RegisterButton.Text = "REGISTER"
        Me.RegisterButton.UseVisualStyleBackColor = True
        '
        'RecoverButton
        '
        Me.RecoverButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.RecoverButton.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RecoverButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.RecoverButton.Font = New System.Drawing.Font("Montserrat Medium", 8.249999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RecoverButton.ForeColor = System.Drawing.Color.FromArgb(CType(CType(166, Byte), Integer), CType(CType(144, Byte), Integer), CType(CType(126, Byte), Integer))
        Me.RecoverButton.Location = New System.Drawing.Point(233, 0)
        Me.RecoverButton.Margin = New System.Windows.Forms.Padding(0)
        Me.RecoverButton.Name = "RecoverButton"
        Me.RecoverButton.Size = New System.Drawing.Size(101, 26)
        Me.RecoverButton.TabIndex = 1
        Me.RecoverButton.Text = "RECOVER"
        Me.RecoverButton.UseVisualStyleBackColor = True
        '
        'LogoPictureBox
        '
        Me.LogoPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.LoginTableLayoutPanel.SetColumnSpan(Me.LogoPictureBox, 3)
        Me.LogoPictureBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LogoPictureBox.Image = Global.Mnemosyne.My.Resources.Resources.Logo
        Me.LogoPictureBox.Location = New System.Drawing.Point(0, 15)
        Me.LogoPictureBox.Margin = New System.Windows.Forms.Padding(0)
        Me.LogoPictureBox.Name = "LogoPictureBox"
        Me.LogoPictureBox.Size = New System.Drawing.Size(400, 146)
        Me.LogoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.LogoPictureBox.TabIndex = 0
        Me.LogoPictureBox.TabStop = False
        '
        'LoginControl
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.Controls.Add(Me.LoginTableLayoutPanel)
        Me.Name = "LoginControl"
        Me.Size = New System.Drawing.Size(400, 400)
        Me.LoginTableLayoutPanel.ResumeLayout(False)
        Me.UsernameTableLayoutPanel.ResumeLayout(False)
        Me.PasswordTableLayoutPanel.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        CType(Me.LogoPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents LoginTableLayoutPanel As TableLayoutPanel
    Friend WithEvents LogoPictureBox As PictureBox
    Friend WithEvents UsernameTableLayoutPanel As TableLayoutPanel
    Friend WithEvents UsernameSplitter As Splitter
    Friend WithEvents PasswordTableLayoutPanel As TableLayoutPanel
    Friend WithEvents PasswordSplitter As Splitter
    Friend WithEvents LoginButton As Button
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents RegisterButton As Button
    Friend WithEvents RecoverButton As Button
End Class
