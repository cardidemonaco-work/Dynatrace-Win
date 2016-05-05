<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.txtOsVersion = New System.Windows.Forms.TextBox()
        Me.txtUserName = New System.Windows.Forms.TextBox()
        Me.lblOsVersion = New System.Windows.Forms.Label()
        Me.lblUserName = New System.Windows.Forms.Label()
        Me.cb64bit = New System.Windows.Forms.CheckBox()
        Me.dtpCurrentTimestampDate = New System.Windows.Forms.DateTimePicker()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.dtpCurrentTimestampTime = New System.Windows.Forms.DateTimePicker()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.txtCores = New System.Windows.Forms.TextBox()
        Me.lblCores = New System.Windows.Forms.Label()
        Me.lbEnvironmentVariables = New System.Windows.Forms.ListBox()
        Me.lblEnvironmentVariables = New System.Windows.Forms.Label()
        Me.lbEnvironmentVariablesRelevant = New System.Windows.Forms.ListBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnEvsAdd = New System.Windows.Forms.Button()
        Me.btnEvsRemove = New System.Windows.Forms.Button()
        Me.lblCurrentTimestamp = New System.Windows.Forms.Label()
        Me.txtEv = New System.Windows.Forms.TextBox()
        Me.txtOsName = New System.Windows.Forms.TextBox()
        Me.lblOsName = New System.Windows.Forms.Label()
        Me.linkOsName = New System.Windows.Forms.LinkLabel()
        Me.dtpLastRestartDate = New System.Windows.Forms.DateTimePicker()
        Me.dtpLastRestartTime = New System.Windows.Forms.DateTimePicker()
        Me.lblLastRestart = New System.Windows.Forms.Label()
        Me.lblCpuUsage = New System.Windows.Forms.Label()
        Me.txtCpuUsage = New System.Windows.Forms.TextBox()
        Me.lblPerfCounterSearch = New System.Windows.Forms.Label()
        Me.txtPerfCounterCategoryName = New System.Windows.Forms.TextBox()
        Me.txtPerfCounterName = New System.Windows.Forms.TextBox()
        Me.txtPerfCounterInstanceName = New System.Windows.Forms.TextBox()
        Me.lblPerfCounterQuery = New System.Windows.Forms.Label()
        Me.lblRamAvailable = New System.Windows.Forms.Label()
        Me.txtRamAvailable = New System.Windows.Forms.TextBox()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.txtRamTotal = New System.Windows.Forms.TextBox()
        Me.lblRamTotal = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtOsVersion
        '
        Me.txtOsVersion.Location = New System.Drawing.Point(745, 49)
        Me.txtOsVersion.Name = "txtOsVersion"
        Me.txtOsVersion.ReadOnly = True
        Me.txtOsVersion.Size = New System.Drawing.Size(241, 20)
        Me.txtOsVersion.TabIndex = 5
        '
        'txtUserName
        '
        Me.txtUserName.Location = New System.Drawing.Point(745, 161)
        Me.txtUserName.Name = "txtUserName"
        Me.txtUserName.ReadOnly = True
        Me.txtUserName.Size = New System.Drawing.Size(241, 20)
        Me.txtUserName.TabIndex = 1
        '
        'lblOsVersion
        '
        Me.lblOsVersion.AutoSize = True
        Me.lblOsVersion.Location = New System.Drawing.Point(611, 52)
        Me.lblOsVersion.Name = "lblOsVersion"
        Me.lblOsVersion.Size = New System.Drawing.Size(128, 13)
        Me.lblOsVersion.TabIndex = 2
        Me.lblOsVersion.Text = "Operating System Version"
        '
        'lblUserName
        '
        Me.lblUserName.AutoSize = True
        Me.lblUserName.Location = New System.Drawing.Point(679, 164)
        Me.lblUserName.Name = "lblUserName"
        Me.lblUserName.Size = New System.Drawing.Size(60, 13)
        Me.lblUserName.TabIndex = 3
        Me.lblUserName.Text = "User Name"
        '
        'cb64bit
        '
        Me.cb64bit.AutoSize = True
        Me.cb64bit.Enabled = False
        Me.cb64bit.Location = New System.Drawing.Point(745, 75)
        Me.cb64bit.Name = "cb64bit"
        Me.cb64bit.Size = New System.Drawing.Size(144, 17)
        Me.cb64bit.TabIndex = 6
        Me.cb64bit.Text = "64-bit Operating System?"
        Me.cb64bit.UseVisualStyleBackColor = True
        '
        'dtpCurrentTimestampDate
        '
        Me.dtpCurrentTimestampDate.Enabled = False
        Me.dtpCurrentTimestampDate.Location = New System.Drawing.Point(256, 99)
        Me.dtpCurrentTimestampDate.Name = "dtpCurrentTimestampDate"
        Me.dtpCurrentTimestampDate.Size = New System.Drawing.Size(200, 20)
        Me.dtpCurrentTimestampDate.TabIndex = 7
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "dynatrace.png")
        Me.ImageList1.Images.SetKeyName(1, "ruxit.png")
        '
        'dtpCurrentTimestampTime
        '
        Me.dtpCurrentTimestampTime.Enabled = False
        Me.dtpCurrentTimestampTime.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.dtpCurrentTimestampTime.Location = New System.Drawing.Point(462, 99)
        Me.dtpCurrentTimestampTime.Name = "dtpCurrentTimestampTime"
        Me.dtpCurrentTimestampTime.Size = New System.Drawing.Size(106, 20)
        Me.dtpCurrentTimestampTime.TabIndex = 8
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(12, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(556, 80)
        Me.PictureBox1.TabIndex = 9
        Me.PictureBox1.TabStop = False
        '
        'txtCores
        '
        Me.txtCores.Location = New System.Drawing.Point(953, 75)
        Me.txtCores.Name = "txtCores"
        Me.txtCores.ReadOnly = True
        Me.txtCores.Size = New System.Drawing.Size(33, 20)
        Me.txtCores.TabIndex = 10
        '
        'lblCores
        '
        Me.lblCores.AutoSize = True
        Me.lblCores.Location = New System.Drawing.Point(992, 76)
        Me.lblCores.Name = "lblCores"
        Me.lblCores.Size = New System.Drawing.Size(34, 13)
        Me.lblCores.TabIndex = 11
        Me.lblCores.Text = "Cores"
        '
        'lbEnvironmentVariables
        '
        Me.lbEnvironmentVariables.FormattingEnabled = True
        Me.lbEnvironmentVariables.Location = New System.Drawing.Point(12, 230)
        Me.lbEnvironmentVariables.Name = "lbEnvironmentVariables"
        Me.lbEnvironmentVariables.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended
        Me.lbEnvironmentVariables.Size = New System.Drawing.Size(556, 199)
        Me.lbEnvironmentVariables.TabIndex = 12
        '
        'lblEnvironmentVariables
        '
        Me.lblEnvironmentVariables.AutoSize = True
        Me.lblEnvironmentVariables.Location = New System.Drawing.Point(9, 212)
        Me.lblEnvironmentVariables.Name = "lblEnvironmentVariables"
        Me.lblEnvironmentVariables.Size = New System.Drawing.Size(126, 13)
        Me.lblEnvironmentVariables.TabIndex = 13
        Me.lblEnvironmentVariables.Text = "All Environment Variables"
        '
        'lbEnvironmentVariablesRelevant
        '
        Me.lbEnvironmentVariablesRelevant.FormattingEnabled = True
        Me.lbEnvironmentVariablesRelevant.Location = New System.Drawing.Point(614, 230)
        Me.lbEnvironmentVariablesRelevant.Name = "lbEnvironmentVariablesRelevant"
        Me.lbEnvironmentVariablesRelevant.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended
        Me.lbEnvironmentVariablesRelevant.Size = New System.Drawing.Size(577, 199)
        Me.lbEnvironmentVariablesRelevant.TabIndex = 14
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(611, 212)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(158, 13)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "Relevant Environment Variables"
        '
        'btnEvsAdd
        '
        Me.btnEvsAdd.Location = New System.Drawing.Point(574, 230)
        Me.btnEvsAdd.Name = "btnEvsAdd"
        Me.btnEvsAdd.Size = New System.Drawing.Size(34, 99)
        Me.btnEvsAdd.TabIndex = 16
        Me.btnEvsAdd.Text = ">"
        Me.btnEvsAdd.UseVisualStyleBackColor = True
        '
        'btnEvsRemove
        '
        Me.btnEvsRemove.Location = New System.Drawing.Point(574, 335)
        Me.btnEvsRemove.Name = "btnEvsRemove"
        Me.btnEvsRemove.Size = New System.Drawing.Size(34, 94)
        Me.btnEvsRemove.TabIndex = 17
        Me.btnEvsRemove.Text = "X"
        Me.btnEvsRemove.UseVisualStyleBackColor = True
        '
        'lblCurrentTimestamp
        '
        Me.lblCurrentTimestamp.AutoSize = True
        Me.lblCurrentTimestamp.Location = New System.Drawing.Point(155, 102)
        Me.lblCurrentTimestamp.Name = "lblCurrentTimestamp"
        Me.lblCurrentTimestamp.Size = New System.Drawing.Size(95, 13)
        Me.lblCurrentTimestamp.TabIndex = 18
        Me.lblCurrentTimestamp.Text = "Current Timestamp"
        '
        'txtEv
        '
        Me.txtEv.Location = New System.Drawing.Point(13, 436)
        Me.txtEv.Multiline = True
        Me.txtEv.Name = "txtEv"
        Me.txtEv.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtEv.Size = New System.Drawing.Size(1178, 104)
        Me.txtEv.TabIndex = 19
        Me.txtEv.Text = "Click an Environment Variable to view it more easily here..."
        '
        'txtOsName
        '
        Me.txtOsName.Location = New System.Drawing.Point(745, 23)
        Me.txtOsName.Name = "txtOsName"
        Me.txtOsName.ReadOnly = True
        Me.txtOsName.Size = New System.Drawing.Size(241, 20)
        Me.txtOsName.TabIndex = 20
        '
        'lblOsName
        '
        Me.lblOsName.AutoSize = True
        Me.lblOsName.Location = New System.Drawing.Point(618, 26)
        Me.lblOsName.Name = "lblOsName"
        Me.lblOsName.Size = New System.Drawing.Size(121, 13)
        Me.lblOsName.TabIndex = 21
        Me.lblOsName.Text = "Operating System Name"
        '
        'linkOsName
        '
        Me.linkOsName.AutoSize = True
        Me.linkOsName.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.linkOsName.Location = New System.Drawing.Point(993, 29)
        Me.linkOsName.Name = "linkOsName"
        Me.linkOsName.Size = New System.Drawing.Size(76, 13)
        Me.linkOsName.TabIndex = 22
        Me.linkOsName.TabStop = True
        Me.linkOsName.Text = "* The fine print"
        '
        'dtpLastRestartDate
        '
        Me.dtpLastRestartDate.Location = New System.Drawing.Point(256, 126)
        Me.dtpLastRestartDate.Name = "dtpLastRestartDate"
        Me.dtpLastRestartDate.Size = New System.Drawing.Size(200, 20)
        Me.dtpLastRestartDate.TabIndex = 23
        '
        'dtpLastRestartTime
        '
        Me.dtpLastRestartTime.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.dtpLastRestartTime.Location = New System.Drawing.Point(462, 126)
        Me.dtpLastRestartTime.Name = "dtpLastRestartTime"
        Me.dtpLastRestartTime.Size = New System.Drawing.Size(106, 20)
        Me.dtpLastRestartTime.TabIndex = 24
        '
        'lblLastRestart
        '
        Me.lblLastRestart.AutoSize = True
        Me.lblLastRestart.Location = New System.Drawing.Point(131, 129)
        Me.lblLastRestart.Name = "lblLastRestart"
        Me.lblLastRestart.Size = New System.Drawing.Size(119, 13)
        Me.lblLastRestart.TabIndex = 25
        Me.lblLastRestart.Text = "Last Restart of the Host"
        '
        'lblCpuUsage
        '
        Me.lblCpuUsage.AutoSize = True
        Me.lblCpuUsage.Location = New System.Drawing.Point(679, 105)
        Me.lblCpuUsage.Name = "lblCpuUsage"
        Me.lblCpuUsage.Size = New System.Drawing.Size(63, 13)
        Me.lblCpuUsage.TabIndex = 26
        Me.lblCpuUsage.Text = "CPU Usage"
        '
        'txtCpuUsage
        '
        Me.txtCpuUsage.Location = New System.Drawing.Point(745, 102)
        Me.txtCpuUsage.Name = "txtCpuUsage"
        Me.txtCpuUsage.ReadOnly = True
        Me.txtCpuUsage.Size = New System.Drawing.Size(112, 20)
        Me.txtCpuUsage.TabIndex = 27
        '
        'lblPerfCounterSearch
        '
        Me.lblPerfCounterSearch.AutoSize = True
        Me.lblPerfCounterSearch.Location = New System.Drawing.Point(13, 547)
        Me.lblPerfCounterSearch.Name = "lblPerfCounterSearch"
        Me.lblPerfCounterSearch.Size = New System.Drawing.Size(196, 13)
        Me.lblPerfCounterSearch.TabIndex = 28
        Me.lblPerfCounterSearch.Text = "Search Windows Performance Counters"
        '
        'txtPerfCounterCategoryName
        '
        Me.txtPerfCounterCategoryName.Location = New System.Drawing.Point(215, 544)
        Me.txtPerfCounterCategoryName.Name = "txtPerfCounterCategoryName"
        Me.txtPerfCounterCategoryName.Size = New System.Drawing.Size(286, 20)
        Me.txtPerfCounterCategoryName.TabIndex = 29
        Me.txtPerfCounterCategoryName.Text = "CATEGORY NAME"
        '
        'txtPerfCounterName
        '
        Me.txtPerfCounterName.Location = New System.Drawing.Point(508, 544)
        Me.txtPerfCounterName.Name = "txtPerfCounterName"
        Me.txtPerfCounterName.Size = New System.Drawing.Size(190, 20)
        Me.txtPerfCounterName.TabIndex = 30
        Me.txtPerfCounterName.Text = "COUNTER NAME"
        '
        'txtPerfCounterInstanceName
        '
        Me.txtPerfCounterInstanceName.Location = New System.Drawing.Point(704, 544)
        Me.txtPerfCounterInstanceName.Name = "txtPerfCounterInstanceName"
        Me.txtPerfCounterInstanceName.Size = New System.Drawing.Size(185, 20)
        Me.txtPerfCounterInstanceName.TabIndex = 31
        Me.txtPerfCounterInstanceName.Text = "INSTANCE NAME"
        '
        'lblPerfCounterQuery
        '
        Me.lblPerfCounterQuery.AutoSize = True
        Me.lblPerfCounterQuery.Location = New System.Drawing.Point(895, 547)
        Me.lblPerfCounterQuery.Name = "lblPerfCounterQuery"
        Me.lblPerfCounterQuery.Size = New System.Drawing.Size(39, 13)
        Me.lblPerfCounterQuery.TabIndex = 32
        Me.lblPerfCounterQuery.Text = "Label3"
        '
        'lblRamAvailable
        '
        Me.lblRamAvailable.AutoSize = True
        Me.lblRamAvailable.Location = New System.Drawing.Point(662, 135)
        Me.lblRamAvailable.Name = "lblRamAvailable"
        Me.lblRamAvailable.Size = New System.Drawing.Size(77, 13)
        Me.lblRamAvailable.TabIndex = 33
        Me.lblRamAvailable.Text = "Available RAM"
        '
        'txtRamAvailable
        '
        Me.txtRamAvailable.Location = New System.Drawing.Point(745, 132)
        Me.txtRamAvailable.Name = "txtRamAvailable"
        Me.txtRamAvailable.ReadOnly = True
        Me.txtRamAvailable.Size = New System.Drawing.Size(112, 20)
        Me.txtRamAvailable.TabIndex = 34
        '
        'btnUpdate
        '
        Me.btnUpdate.Location = New System.Drawing.Point(1088, 23)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(103, 158)
        Me.btnUpdate.TabIndex = 0
        Me.btnUpdate.Text = "UPDATE"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'txtRamTotal
        '
        Me.txtRamTotal.Location = New System.Drawing.Point(863, 132)
        Me.txtRamTotal.Name = "txtRamTotal"
        Me.txtRamTotal.ReadOnly = True
        Me.txtRamTotal.Size = New System.Drawing.Size(123, 20)
        Me.txtRamTotal.TabIndex = 36
        '
        'lblRamTotal
        '
        Me.lblRamTotal.AutoSize = True
        Me.lblRamTotal.Location = New System.Drawing.Point(992, 135)
        Me.lblRamTotal.Name = "lblRamTotal"
        Me.lblRamTotal.Size = New System.Drawing.Size(58, 13)
        Me.lblRamTotal.TabIndex = 37
        Me.lblRamTotal.Text = "Total RAM"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(1203, 573)
        Me.Controls.Add(Me.lblRamTotal)
        Me.Controls.Add(Me.txtRamTotal)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.txtRamAvailable)
        Me.Controls.Add(Me.lblRamAvailable)
        Me.Controls.Add(Me.lblPerfCounterQuery)
        Me.Controls.Add(Me.txtPerfCounterInstanceName)
        Me.Controls.Add(Me.txtPerfCounterName)
        Me.Controls.Add(Me.txtPerfCounterCategoryName)
        Me.Controls.Add(Me.lblPerfCounterSearch)
        Me.Controls.Add(Me.txtCpuUsage)
        Me.Controls.Add(Me.lblCpuUsage)
        Me.Controls.Add(Me.lblLastRestart)
        Me.Controls.Add(Me.dtpLastRestartTime)
        Me.Controls.Add(Me.dtpLastRestartDate)
        Me.Controls.Add(Me.linkOsName)
        Me.Controls.Add(Me.lblOsName)
        Me.Controls.Add(Me.txtOsName)
        Me.Controls.Add(Me.txtEv)
        Me.Controls.Add(Me.lblCurrentTimestamp)
        Me.Controls.Add(Me.btnEvsRemove)
        Me.Controls.Add(Me.btnEvsAdd)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lbEnvironmentVariablesRelevant)
        Me.Controls.Add(Me.lblEnvironmentVariables)
        Me.Controls.Add(Me.lbEnvironmentVariables)
        Me.Controls.Add(Me.lblCores)
        Me.Controls.Add(Me.txtCores)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.dtpCurrentTimestampTime)
        Me.Controls.Add(Me.dtpCurrentTimestampDate)
        Me.Controls.Add(Me.cb64bit)
        Me.Controls.Add(Me.lblUserName)
        Me.Controls.Add(Me.lblOsVersion)
        Me.Controls.Add(Me.txtUserName)
        Me.Controls.Add(Me.txtOsVersion)
        Me.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Name = "Form1"
        Me.Text = "Useful Stuff"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblUserName As Label
    Friend WithEvents lblOsVersion As Label
    Friend WithEvents txtUserName As TextBox
    Friend WithEvents txtOsVersion As TextBox
    Friend WithEvents cb64bit As CheckBox
    Friend WithEvents dtpCurrentTimestampDate As DateTimePicker
    Friend WithEvents ImageList1 As ImageList
    Friend WithEvents dtpCurrentTimestampTime As DateTimePicker
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents txtCores As TextBox
    Friend WithEvents lblCores As Label
    Friend WithEvents lbEnvironmentVariables As ListBox
    Friend WithEvents lblEnvironmentVariables As Label
    Friend WithEvents lbEnvironmentVariablesRelevant As ListBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnEvsAdd As Button
    Friend WithEvents btnEvsRemove As Button
    Friend WithEvents lblCurrentTimestamp As Label
    Friend WithEvents txtEv As TextBox
    Friend WithEvents txtOsName As TextBox
    Friend WithEvents lblOsName As Label
    Friend WithEvents linkOsName As LinkLabel
    Friend WithEvents dtpLastRestartDate As DateTimePicker
    Friend WithEvents dtpLastRestartTime As DateTimePicker
    Friend WithEvents lblLastRestart As Label
    Friend WithEvents lblCpuUsage As Label
    Friend WithEvents txtCpuUsage As TextBox
    Friend WithEvents lblPerfCounterSearch As Label
    Friend WithEvents txtPerfCounterCategoryName As TextBox
    Friend WithEvents txtPerfCounterName As TextBox
    Friend WithEvents txtPerfCounterInstanceName As TextBox
    Friend WithEvents lblPerfCounterQuery As Label
    Friend WithEvents lblRamAvailable As Label
    Friend WithEvents txtRamAvailable As TextBox
    Friend WithEvents btnUpdate As Button
    Friend WithEvents txtRamTotal As TextBox
    Friend WithEvents lblRamTotal As Label
End Class
