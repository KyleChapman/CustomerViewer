<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CustomerViewer
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
        Me.components = New System.ComponentModel.Container()
        Me.chkVIP = New System.Windows.Forms.CheckBox()
        Me.lbLastName = New System.Windows.Forms.Label()
        Me.lblFirstName = New System.Windows.Forms.Label()
        Me.lbTitle = New System.Windows.Forms.Label()
        Me.tbLastName = New System.Windows.Forms.TextBox()
        Me.tbFirstName = New System.Windows.Forms.TextBox()
        Me.lbIdentifcationNumber = New System.Windows.Forms.Label()
        Me.tbIdentificationNumber = New System.Windows.Forms.TextBox()
        Me.btnPrevious = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnNext = New System.Windows.Forms.Button()
        Me.ttpCustomerTips = New System.Windows.Forms.ToolTip(Me.components)
        Me.tbTitles = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'chkVIP
        '
        Me.chkVIP.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chkVIP.Location = New System.Drawing.Point(65, 137)
        Me.chkVIP.Margin = New System.Windows.Forms.Padding(4)
        Me.chkVIP.Name = "chkVIP"
        Me.chkVIP.Size = New System.Drawing.Size(61, 30)
        Me.chkVIP.TabIndex = 13
        Me.chkVIP.Text = "&VIP:"
        Me.chkVIP.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ttpCustomerTips.SetToolTip(Me.chkVIP, "Displays whether the current customer is considered a VIP or not")
        Me.chkVIP.UseVisualStyleBackColor = True
        '
        'lbLastName
        '
        Me.lbLastName.Location = New System.Drawing.Point(13, 113)
        Me.lbLastName.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbLastName.Name = "lbLastName"
        Me.lbLastName.Size = New System.Drawing.Size(88, 16)
        Me.lbLastName.TabIndex = 11
        Me.lbLastName.Text = "&Last Name: "
        Me.lbLastName.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblFirstName
        '
        Me.lblFirstName.Location = New System.Drawing.Point(13, 77)
        Me.lblFirstName.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblFirstName.Name = "lblFirstName"
        Me.lblFirstName.Size = New System.Drawing.Size(88, 16)
        Me.lblFirstName.TabIndex = 9
        Me.lblFirstName.Text = "&First Name: "
        Me.lblFirstName.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lblFirstName.UseWaitCursor = True
        '
        'lbTitle
        '
        Me.lbTitle.Location = New System.Drawing.Point(13, 44)
        Me.lbTitle.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbTitle.Name = "lbTitle"
        Me.lbTitle.Size = New System.Drawing.Size(88, 16)
        Me.lbTitle.TabIndex = 7
        Me.lbTitle.Text = "&Title: "
        Me.lbTitle.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'tbLastName
        '
        Me.tbLastName.Enabled = False
        Me.tbLastName.Location = New System.Drawing.Point(109, 109)
        Me.tbLastName.Margin = New System.Windows.Forms.Padding(4)
        Me.tbLastName.Name = "tbLastName"
        Me.tbLastName.Size = New System.Drawing.Size(160, 22)
        Me.tbLastName.TabIndex = 12
        Me.ttpCustomerTips.SetToolTip(Me.tbLastName, "Displays the last name for the current customer")
        '
        'tbFirstName
        '
        Me.tbFirstName.Enabled = False
        Me.tbFirstName.Location = New System.Drawing.Point(109, 77)
        Me.tbFirstName.Margin = New System.Windows.Forms.Padding(4)
        Me.tbFirstName.Name = "tbFirstName"
        Me.tbFirstName.Size = New System.Drawing.Size(160, 22)
        Me.tbFirstName.TabIndex = 10
        Me.ttpCustomerTips.SetToolTip(Me.tbFirstName, "Displays the first name for the current customer")
        '
        'lbIdentifcationNumber
        '
        Me.lbIdentifcationNumber.Location = New System.Drawing.Point(13, 13)
        Me.lbIdentifcationNumber.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbIdentifcationNumber.Name = "lbIdentifcationNumber"
        Me.lbIdentifcationNumber.Size = New System.Drawing.Size(88, 16)
        Me.lbIdentifcationNumber.TabIndex = 14
        Me.lbIdentifcationNumber.Text = "&ID:"
        Me.lbIdentifcationNumber.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lbIdentifcationNumber.UseWaitCursor = True
        '
        'tbIdentificationNumber
        '
        Me.tbIdentificationNumber.Enabled = False
        Me.tbIdentificationNumber.Location = New System.Drawing.Point(109, 13)
        Me.tbIdentificationNumber.Margin = New System.Windows.Forms.Padding(4)
        Me.tbIdentificationNumber.Name = "tbIdentificationNumber"
        Me.tbIdentificationNumber.Size = New System.Drawing.Size(160, 22)
        Me.tbIdentificationNumber.TabIndex = 15
        Me.ttpCustomerTips.SetToolTip(Me.tbIdentificationNumber, "Displays the identifcation number for the current customer")
        '
        'btnPrevious
        '
        Me.btnPrevious.Enabled = False
        Me.btnPrevious.Location = New System.Drawing.Point(16, 206)
        Me.btnPrevious.Name = "btnPrevious"
        Me.btnPrevious.Size = New System.Drawing.Size(75, 23)
        Me.btnPrevious.TabIndex = 16
        Me.btnPrevious.Text = "&Previous"
        Me.ttpCustomerTips.SetToolTip(Me.btnPrevious, "View the previous customer in the list")
        Me.btnPrevious.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnExit.Location = New System.Drawing.Point(105, 206)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 17
        Me.btnExit.Text = "E&xit"
        Me.ttpCustomerTips.SetToolTip(Me.btnExit, "Exit the application")
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnNext
        '
        Me.btnNext.Location = New System.Drawing.Point(194, 206)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(75, 23)
        Me.btnNext.TabIndex = 18
        Me.btnNext.Text = "&Next"
        Me.ttpCustomerTips.SetToolTip(Me.btnNext, "View the next customer in the list")
        Me.btnNext.UseVisualStyleBackColor = True
        '
        'tbTitles
        '
        Me.tbTitles.Enabled = False
        Me.tbTitles.Location = New System.Drawing.Point(109, 45)
        Me.tbTitles.Margin = New System.Windows.Forms.Padding(4)
        Me.tbTitles.Name = "tbTitles"
        Me.tbTitles.Size = New System.Drawing.Size(160, 22)
        Me.tbTitles.TabIndex = 19
        Me.ttpCustomerTips.SetToolTip(Me.tbTitles, "Displays the title for the current customer")
        '
        'CustomerViewer
        '
        Me.AcceptButton = Me.btnNext
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnExit
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.tbTitles)
        Me.Controls.Add(Me.btnNext)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnPrevious)
        Me.Controls.Add(Me.lbIdentifcationNumber)
        Me.Controls.Add(Me.tbIdentificationNumber)
        Me.Controls.Add(Me.chkVIP)
        Me.Controls.Add(Me.lbLastName)
        Me.Controls.Add(Me.lblFirstName)
        Me.Controls.Add(Me.lbTitle)
        Me.Controls.Add(Me.tbLastName)
        Me.Controls.Add(Me.tbFirstName)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "CustomerViewer"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Customer Viewer"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents chkVIP As CheckBox
    Friend WithEvents lbLastName As Label
    Friend WithEvents lblFirstName As Label
    Friend WithEvents lbTitle As Label
    Friend WithEvents tbLastName As TextBox
    Friend WithEvents tbFirstName As TextBox
    Friend WithEvents lbIdentifcationNumber As Label
    Friend WithEvents tbIdentificationNumber As TextBox
    Friend WithEvents btnPrevious As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents btnNext As Button
    Friend WithEvents ttpCustomerTips As ToolTip
    Friend WithEvents tbTitles As TextBox
End Class
