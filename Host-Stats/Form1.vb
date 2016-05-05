'Should call this Dynatrace Diagnostics instead...
' Add functionality for detecting the versions of Dynatrace installed

Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load

        'Current Timestamp
        '-Handled in the UI

        'Last restart of the Host
        Dim lastRestartTickCount As Long = System.Environment.TickCount
        Dim lastRestartDate As New Date(Now.Ticks - (lastRestartTickCount * 10000)) '100 nanoseconds is 0.0001 milliseconds? so multiply by 10,000? check this
        dtpLastRestartDate.Value = lastRestartDate
        dtpLastRestartTime.Value = lastRestartDate

        'Operating System Name
        'https://msdn.microsoft.com/en-us/library/windows/desktop/ms724832.aspx
        Dim osName As String = ""
        Select Case System.Environment.OSVersion.Version.Major
            Case "10"
                Select Case System.Environment.OSVersion.Version.Minor
                    Case "0"
                        osName = "Windows 10 or Windows Server 2016 Technical Preview"
                End Select
            Case "6"
                Select Case System.Environment.OSVersion.Version.Minor
                    Case "3"
                        osName = "Windows 8.1 or Windows Server 2012 R2"
                    Case "2"
                        osName = "Windows 8 or Windows Server 2012"
                    Case "1"
                        osName = "Windows 7 or Windows Server 2008 R2"
                    Case "0"
                        osName = "Windows Vista or Windows Server 2008"
                End Select
            Case "5"
                'finish this list...
        End Select
        txtOsName.Text = osName

        'Fine Print link...
        Dim l As New LinkLabel.Link
        l.LinkData = "https://msdn.microsoft.com/en-us/library/windows/desktop/ms724832.aspx"
        linkOsName.Links.Add(l)

        'Operating System Version
        Dim osVersion As String = System.Environment.OSVersion.ToString 'Operating System Version
        txtOsVersion.Text = osVersion

        'Bitness
        Dim bit64 As String = System.Environment.Is64BitOperatingSystem '64-bit?
        cb64bit.Checked = bit64
        ''Below
        'If bit64 Then
        '    cb64bit.ForeColor = Color.Green
        'Else
        '    cb64bit.ForeColor = Color.Red
        'End If

        'Cores
        Dim cores As String = System.Environment.ProcessorCount 'Amount of Cores
        txtCores.Text = cores

        'CPU Usage, Available RAM
        '-Handled in updateHostStats()

        ''Total RAM
        'Dim pcCommittedBytes As New PerformanceCounter("Memory", "Committed Bytes")
        'Dim pcAvailableBytes As New PerformanceCounter("Memory", "Available Bytes")
        'txtRamTotal.Text = ((pcCommittedBytes.NextValue + pcAvailableBytes.NextValue) / 1024 / 1024 / 1024).ToString + " GB"

        'User Name
        Dim userName As String = System.Environment.UserName 'User Name
        txtUserName.Text = userName

        'All Environment Variables
        Dim evs As IDictionary = System.Environment.GetEnvironmentVariables 'Gather from OS the Environment Variables
        Dim evsSorted As New SortedDictionary(Of Object, Object) 'Create Object to insert them sorted
        For Each ev As Object In evs
            evsSorted.Add(ev.key, ev.Value)  'Put items in evsSorted
        Next

        'Relevant Environment Variables
        '-Insert Environment Variables into the List Box in the interface (alphabetically)
        For Each x As Object In evsSorted
            Select Case x.key.ToString
                Case "COMPUTERNAME", "COR_ENABLE_PROFILING", "COR_PROFILER", "HOMEPATH", "JAVA_HOME",
"NUMBER_OF_PROCESSORS", "OS", "Path", "USERDOMAIN", "USERNAME"
                    lbEnvironmentVariablesRelevant.Items.Add(x.Key.ToString + "=" + x.Value.ToString)
                Case Else
                    'Do nothing.. leave the above items in "All Environment Variables" so that all EVs are in one list
            End Select

            lbEnvironmentVariables.Items.Add(x.Key.ToString + "=" + x.Value.ToString)
        Next

        'Use this function for items that will update constantly...
        updateHostStats()

    End Sub

    'When ">" clicked, adds the EVs to the relevant side...
    Private Sub btnEvsAdd_Click(sender As Object, e As EventArgs) Handles btnEvsAdd.Click

        'When clicking ">", add the selected items in the left box to the right box
        For Each ev As Object In lbEnvironmentVariables.SelectedItems
            lbEnvironmentVariablesRelevant.Items.Add(ev.ToString)
        Next

    End Sub

    'When "X" is clicked, removes relevant environment variables...
    Private Sub btnEvsRemove_Click(sender As Object, e As EventArgs) Handles btnEvsRemove.Click

        'When clicking "X", remove the selected items in the right box
        Dim selectedItems As New ListBox
        For Each item As Object In lbEnvironmentVariablesRelevant.SelectedItems
            selectedItems.Items.Add(item.ToString)
        Next

        For Each ev As Object In selectedItems.Items
            lbEnvironmentVariablesRelevant.Items.Remove(ev.ToString)
        Next

    End Sub

    'Clicked inside the All Environment Variables ListBox...
    Private Sub lbEnvironmentVariables_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lbEnvironmentVariables.SelectedIndexChanged
        txtEv.Text = lbEnvironmentVariables.SelectedItem.ToString
    End Sub

    'Clicked inside the Relevant Environment Variables ListBox...
    Private Sub lbEnvironmentVariablesRelevant_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lbEnvironmentVariablesRelevant.SelectedIndexChanged
        'txtEv.Text = lbEnvironmentVariablesRelevant.SelectedItem.ToString
    End Sub

    'Clicked the "Fine Print" link...
    Private Sub linkOsName_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles linkOsName.LinkClicked
        Process.Start(e.Link.LinkData)
    End Sub

    'Clicked "Update"...
    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        updateHostStats()
    End Sub

    'Updates all data that is not static...
    Public Sub updateHostStats()

        'Performance Counter doc
        'https://msdn.microsoft.com/en-us/library/fxk122b4.aspx
        'https://msdn.microsoft.com/en-us/library/y84hetex.aspx
        'https://msdn.microsoft.com/en-us/library/xx7e9t8e(v=vs.110).aspx

        'CPU Usage
        Dim cCpuUsage As New System.Diagnostics.PerformanceCounter("Processor Information", "% Processor Time", "_Total")
        '... assign this eventually

        'Available Memory
        Dim pcMemory As New PerformanceCounter("Memory", "Available MBytes")
        Dim pcMemoryNextValue As Single = pcMemory.NextValue()
        txtRamAvailable.Text = (pcMemoryNextValue / 1024).ToString + " GB"

    End Sub
End Class
