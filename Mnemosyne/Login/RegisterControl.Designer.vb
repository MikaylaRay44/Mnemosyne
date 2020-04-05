<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RegisterControl
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
        Me.RegisterTableLayoutPanel = New System.Windows.Forms.TableLayoutPanel()
        Me.UsernameTableLayoutPanel = New System.Windows.Forms.TableLayoutPanel()
        Me.UsernameSplitter = New System.Windows.Forms.Splitter()
        Me.PasswordTableLayoutPanel = New System.Windows.Forms.TableLayoutPanel()
        Me.Splitter1 = New System.Windows.Forms.Splitter()
        Me.EmailTableLayoutPanel = New System.Windows.Forms.TableLayoutPanel()
        Me.Splitter2 = New System.Windows.Forms.Splitter()
        Me.PhoneTableLayoutPanel = New System.Windows.Forms.TableLayoutPanel()
        Me.Splitter3 = New System.Windows.Forms.Splitter()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.ReturnButton = New System.Windows.Forms.Button()
        Me.RegisterButton = New System.Windows.Forms.Button()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.TermsOfServiceCheckbox = New System.Windows.Forms.CheckBox()
        Me.TermsOfServiceLinkLabel = New System.Windows.Forms.LinkLabel()
        Me.RegisterTableLayoutPanel.SuspendLayout()
        Me.UsernameTableLayoutPanel.SuspendLayout()
        Me.PasswordTableLayoutPanel.SuspendLayout()
        Me.EmailTableLayoutPanel.SuspendLayout()
        Me.PhoneTableLayoutPanel.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'RegisterTableLayoutPanel
        '
        Me.RegisterTableLayoutPanel.ColumnCount = 3
        Me.RegisterTableLayoutPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.RegisterTableLayoutPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.RegisterTableLayoutPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.RegisterTableLayoutPanel.Controls.Add(Me.UsernameTableLayoutPanel, 1, 1)
        Me.RegisterTableLayoutPanel.Controls.Add(Me.PasswordTableLayoutPanel, 1, 2)
        Me.RegisterTableLayoutPanel.Controls.Add(Me.EmailTableLayoutPanel, 1, 3)
        Me.RegisterTableLayoutPanel.Controls.Add(Me.PhoneTableLayoutPanel, 1, 4)
        Me.RegisterTableLayoutPanel.Controls.Add(Me.TableLayoutPanel1, 1, 10)
        Me.RegisterTableLayoutPanel.Controls.Add(Me.RegisterButton, 1, 8)
        Me.RegisterTableLayoutPanel.Controls.Add(Me.TableLayoutPanel2, 1, 6)
        Me.RegisterTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RegisterTableLayoutPanel.Location = New System.Drawing.Point(0, 0)
        Me.RegisterTableLayoutPanel.Name = "RegisterTableLayoutPanel"
        Me.RegisterTableLayoutPanel.RowCount = 12
        Me.RegisterTableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 15.0!))
        Me.RegisterTableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.78947!))
        Me.RegisterTableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.78947!))
        Me.RegisterTableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.78947!))
        Me.RegisterTableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.78947!))
        Me.RegisterTableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 15.0!))
        Me.RegisterTableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.52632!))
        Me.RegisterTableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 15.0!))
        Me.RegisterTableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.78947!))
        Me.RegisterTableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 15.0!))
        Me.RegisterTableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.52632!))
        Me.RegisterTableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 15.0!))
        Me.RegisterTableLayoutPanel.Size = New System.Drawing.Size(400, 400)
        Me.RegisterTableLayoutPanel.TabIndex = 0
        '
        'UsernameTableLayoutPanel
        '
        Me.UsernameTableLayoutPanel.ColumnCount = 3
        Me.UsernameTableLayoutPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.UsernameTableLayoutPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.UsernameTableLayoutPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.UsernameTableLayoutPanel.Controls.Add(Me.UsernameSplitter, 0, 1)
        Me.UsernameTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UsernameTableLayoutPanel.Location = New System.Drawing.Point(33, 18)
        Me.UsernameTableLayoutPanel.Name = "UsernameTableLayoutPanel"
        Me.UsernameTableLayoutPanel.RowCount = 2
        Me.UsernameTableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.UsernameTableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10.0!))
        Me.UsernameTableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.UsernameTableLayoutPanel.Size = New System.Drawing.Size(334, 45)
        Me.UsernameTableLayoutPanel.TabIndex = 2
        '
        'UsernameSplitter
        '
        Me.UsernameSplitter.BackColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(218, Byte), Integer))
        Me.UsernameTableLayoutPanel.SetColumnSpan(Me.UsernameSplitter, 3)
        Me.UsernameSplitter.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.UsernameSplitter.Location = New System.Drawing.Point(0, 39)
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
        Me.PasswordTableLayoutPanel.Controls.Add(Me.Splitter1, 0, 1)
        Me.PasswordTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PasswordTableLayoutPanel.Location = New System.Drawing.Point(33, 69)
        Me.PasswordTableLayoutPanel.Name = "PasswordTableLayoutPanel"
        Me.PasswordTableLayoutPanel.RowCount = 2
        Me.PasswordTableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.PasswordTableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10.0!))
        Me.PasswordTableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.PasswordTableLayoutPanel.Size = New System.Drawing.Size(334, 45)
        Me.PasswordTableLayoutPanel.TabIndex = 3
        '
        'Splitter1
        '
        Me.Splitter1.BackColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(218, Byte), Integer))
        Me.PasswordTableLayoutPanel.SetColumnSpan(Me.Splitter1, 3)
        Me.Splitter1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Splitter1.Location = New System.Drawing.Point(0, 39)
        Me.Splitter1.Margin = New System.Windows.Forms.Padding(0, 3, 0, 3)
        Me.Splitter1.Name = "Splitter1"
        Me.Splitter1.Size = New System.Drawing.Size(334, 3)
        Me.Splitter1.TabIndex = 1
        Me.Splitter1.TabStop = False
        '
        'EmailTableLayoutPanel
        '
        Me.EmailTableLayoutPanel.ColumnCount = 3
        Me.EmailTableLayoutPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.EmailTableLayoutPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.EmailTableLayoutPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.EmailTableLayoutPanel.Controls.Add(Me.Splitter2, 0, 1)
        Me.EmailTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EmailTableLayoutPanel.Location = New System.Drawing.Point(33, 120)
        Me.EmailTableLayoutPanel.Name = "EmailTableLayoutPanel"
        Me.EmailTableLayoutPanel.RowCount = 2
        Me.EmailTableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.EmailTableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10.0!))
        Me.EmailTableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.EmailTableLayoutPanel.Size = New System.Drawing.Size(334, 45)
        Me.EmailTableLayoutPanel.TabIndex = 4
        '
        'Splitter2
        '
        Me.Splitter2.BackColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(218, Byte), Integer))
        Me.EmailTableLayoutPanel.SetColumnSpan(Me.Splitter2, 3)
        Me.Splitter2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Splitter2.Location = New System.Drawing.Point(0, 39)
        Me.Splitter2.Margin = New System.Windows.Forms.Padding(0, 3, 0, 3)
        Me.Splitter2.Name = "Splitter2"
        Me.Splitter2.Size = New System.Drawing.Size(334, 3)
        Me.Splitter2.TabIndex = 1
        Me.Splitter2.TabStop = False
        '
        'PhoneTableLayoutPanel
        '
        Me.PhoneTableLayoutPanel.ColumnCount = 3
        Me.PhoneTableLayoutPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.PhoneTableLayoutPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.PhoneTableLayoutPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.PhoneTableLayoutPanel.Controls.Add(Me.Splitter3, 0, 1)
        Me.PhoneTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PhoneTableLayoutPanel.Location = New System.Drawing.Point(33, 171)
        Me.PhoneTableLayoutPanel.Name = "PhoneTableLayoutPanel"
        Me.PhoneTableLayoutPanel.RowCount = 2
        Me.PhoneTableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.PhoneTableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10.0!))
        Me.PhoneTableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.PhoneTableLayoutPanel.Size = New System.Drawing.Size(334, 45)
        Me.PhoneTableLayoutPanel.TabIndex = 5
        '
        'Splitter3
        '
        Me.Splitter3.BackColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(218, Byte), Integer))
        Me.PhoneTableLayoutPanel.SetColumnSpan(Me.Splitter3, 3)
        Me.Splitter3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Splitter3.Location = New System.Drawing.Point(0, 39)
        Me.Splitter3.Margin = New System.Windows.Forms.Padding(0, 3, 0, 3)
        Me.Splitter3.Name = "Splitter3"
        Me.Splitter3.Size = New System.Drawing.Size(334, 3)
        Me.Splitter3.TabIndex = 1
        Me.Splitter3.TabStop = False
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 3
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.ReturnButton, 0, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(33, 352)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(334, 28)
        Me.TableLayoutPanel1.TabIndex = 7
        '
        'ReturnButton
        '
        Me.ReturnButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ReturnButton.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ReturnButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ReturnButton.Font = New System.Drawing.Font("Montserrat Medium", 8.249999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ReturnButton.ForeColor = System.Drawing.Color.FromArgb(CType(CType(166, Byte), Integer), CType(CType(144, Byte), Integer), CType(CType(126, Byte), Integer))
        Me.ReturnButton.Location = New System.Drawing.Point(0, 0)
        Me.ReturnButton.Margin = New System.Windows.Forms.Padding(0)
        Me.ReturnButton.Name = "ReturnButton"
        Me.ReturnButton.Size = New System.Drawing.Size(100, 28)
        Me.ReturnButton.TabIndex = 0
        Me.ReturnButton.Text = "RETURN"
        Me.ReturnButton.UseVisualStyleBackColor = True
        '
        'RegisterButton
        '
        Me.RegisterButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(218, Byte), Integer))
        Me.RegisterButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.RegisterButton.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RegisterButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.RegisterButton.Font = New System.Drawing.Font("Montserrat Medium", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RegisterButton.ForeColor = System.Drawing.Color.FromArgb(CType(CType(166, Byte), Integer), CType(CType(144, Byte), Integer), CType(CType(126, Byte), Integer))
        Me.RegisterButton.Location = New System.Drawing.Point(30, 283)
        Me.RegisterButton.Margin = New System.Windows.Forms.Padding(0)
        Me.RegisterButton.Name = "RegisterButton"
        Me.RegisterButton.Size = New System.Drawing.Size(340, 51)
        Me.RegisterButton.TabIndex = 6
        Me.RegisterButton.Text = "REGISTER"
        Me.RegisterButton.UseVisualStyleBackColor = False
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 2
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.TermsOfServiceCheckbox, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.TermsOfServiceLinkLabel, 1, 0)
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(33, 237)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 1
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(334, 28)
        Me.TableLayoutPanel2.TabIndex = 8
        '
        'TermsOfServiceCheckbox
        '
        Me.TermsOfServiceCheckbox.AutoSize = True
        Me.TermsOfServiceCheckbox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TermsOfServiceCheckbox.Font = New System.Drawing.Font("Montserrat Medium", 8.249999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TermsOfServiceCheckbox.ForeColor = System.Drawing.Color.FromArgb(CType(CType(166, Byte), Integer), CType(CType(144, Byte), Integer), CType(CType(126, Byte), Integer))
        Me.TermsOfServiceCheckbox.Location = New System.Drawing.Point(3, 3)
        Me.TermsOfServiceCheckbox.Name = "TermsOfServiceCheckbox"
        Me.TermsOfServiceCheckbox.Size = New System.Drawing.Size(14, 22)
        Me.TermsOfServiceCheckbox.TabIndex = 0
        Me.TermsOfServiceCheckbox.UseVisualStyleBackColor = True
        '
        'TermsOfServiceLinkLabel
        '
        Me.TermsOfServiceLinkLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TermsOfServiceLinkLabel.AutoSize = True
        Me.TermsOfServiceLinkLabel.Font = New System.Drawing.Font("Montserrat Medium", 8.249999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TermsOfServiceLinkLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(166, Byte), Integer), CType(CType(144, Byte), Integer), CType(CType(126, Byte), Integer))
        Me.TermsOfServiceLinkLabel.LinkArea = New System.Windows.Forms.LinkArea(15, 32)
        Me.TermsOfServiceLinkLabel.Location = New System.Drawing.Point(23, 5)
        Me.TermsOfServiceLinkLabel.Name = "TermsOfServiceLinkLabel"
        Me.TermsOfServiceLinkLabel.Size = New System.Drawing.Size(308, 18)
        Me.TermsOfServiceLinkLabel.TabIndex = 1
        Me.TermsOfServiceLinkLabel.TabStop = True
        Me.TermsOfServiceLinkLabel.Text = "I agree to the Terms of Service."
        Me.TermsOfServiceLinkLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.TermsOfServiceLinkLabel.UseCompatibleTextRendering = True
        '
        'RegisterControl
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.Controls.Add(Me.RegisterTableLayoutPanel)
        Me.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Name = "RegisterControl"
        Me.Size = New System.Drawing.Size(400, 400)
        Me.RegisterTableLayoutPanel.ResumeLayout(False)
        Me.UsernameTableLayoutPanel.ResumeLayout(False)
        Me.PasswordTableLayoutPanel.ResumeLayout(False)
        Me.EmailTableLayoutPanel.ResumeLayout(False)
        Me.PhoneTableLayoutPanel.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents RegisterTableLayoutPanel As TableLayoutPanel
    Friend WithEvents UsernameTableLayoutPanel As TableLayoutPanel
    Friend WithEvents UsernameSplitter As Splitter
    Friend WithEvents PasswordTableLayoutPanel As TableLayoutPanel
    Friend WithEvents Splitter1 As Splitter
    Friend WithEvents EmailTableLayoutPanel As TableLayoutPanel
    Friend WithEvents Splitter2 As Splitter
    Friend WithEvents PhoneTableLayoutPanel As TableLayoutPanel
    Friend WithEvents Splitter3 As Splitter
    Friend WithEvents RegisterButton As Button
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents ReturnButton As Button
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents TermsOfServiceCheckbox As CheckBox
    Friend WithEvents TermsOfServiceLinkLabel As LinkLabel
End Class
