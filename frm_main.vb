Public Class frm_main

    Public strJudul As String
    Public strPertanyaan As String

    Public strOutput As String

    Public idxResolution As Integer
    Public idxBitrate As Integer
    Public idxFPS As Integer

    Public strOnChange As String

    Public strIntegerOutput As Integer
    Public strStringOutput As String
    Public strPresetOutput As String

    'String Append
    Dim strScrcpyPath As String = "scrcpy"
    Dim strFullscreen As String
    Dim strResolution As String
    Dim strBitrate As String
    Dim strFPS As String
    Dim strTCPIP As String

    Dim strAdvancedIsOn As Integer



    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btn_toggle_adv.Click
        If btn_toggle_adv.Text = "advanced_mode ▶" Then
            'ketika advanced modenya nyala
            btn_toggle_adv.Text = "advanced_mode ▼"
            MaximumSize = New Size(763, 382)
            MinimumSize = New Size(763, 382)
            Size = New Size(763, 382)
            strAdvancedIsOn = 1
        Else
            'ketika advanced modenya mati
            btn_toggle_adv.Text = "advanced_mode ▶"
            MaximumSize = New Size(763, 270)
            MinimumSize = New Size(763, 270)
            Size = New Size(763, 270)
            strAdvancedIsOn = 0

            cmb_resolution.SelectedIndex = 0
            cmb_bitrate.SelectedIndex = 0
            cmb_fps.SelectedIndex = 4
            cmb_mode.SelectedIndex = 0
            cmb_ip.SelectedIndex = 0

            Call updateEZMode()
        End If
    End Sub
    Private Sub chk_60fps_CheckedChanged(sender As Object, e As EventArgs) Handles chk_60fps.CheckedChanged
        If chk_60fps.Checked = True Then
            lbl_480.Text = "480p60"
            lbl_720.Text = "720p60"
            lbl_900.Text = "900p60"
            lbl_1080.Text = "1080p60"
            cmb_fps.SelectedIndex = 3
        Else
            lbl_480.Text = "480p30"
            lbl_720.Text = "720p30"
            lbl_900.Text = "900p30"
            lbl_1080.Text = "1080p30"
            cmb_fps.SelectedIndex = 4
        End If
    End Sub
    Private Sub cmb_resolution_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_resolution.SelectedIndexChanged
        If cmb_resolution.SelectedIndex = 5 Then
            strJudul = "please_enter_your_desired_resolution"
            strPertanyaan = "desired_resolution>"
            strOnChange = "resolution"
            frm_customInput.Show()
        Else
            idxResolution = cmb_resolution.SelectedIndex
            If cmb_resolution.SelectedItem.ToString = "Native" Then
                strResolution = ""
            Else
                strResolution = " -m " & cmb_resolution.SelectedItem.Trim.Substring(0, cmb_resolution.SelectedItem.ToString.Count - 1)
            End If
        End If
    End Sub

    Private Sub cmb_bitrate_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_bitrate.SelectedIndexChanged
        If cmb_bitrate.SelectedIndex = 6 Then
            strJudul = "please_enter_your_desired_bitrate"
            strPertanyaan = "desired_bitrate>"
            strOnChange = "bitrate"
            frm_customInput.Show()
        Else
            idxBitrate = cmb_bitrate.SelectedIndex
            If cmb_bitrate.SelectedItem.ToString = "Default" Then
                strBitrate = ""
            Else
                strBitrate = " -b " & cmb_bitrate.SelectedItem.Trim.Substring(0, cmb_bitrate.SelectedItem.ToString.Count - 1) & "M"
            End If
        End If
    End Sub
    Private Sub cmb_fps_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_fps.SelectedIndexChanged
        If cmb_fps.SelectedIndex = 6 Then
            strJudul = "please_enter_your_desired_fps"
            strPertanyaan = "desired_fps>"
            strOnChange = "fps"
            frm_customInput.Show()
        Else
            idxFPS = cmb_fps.SelectedIndex
            If cmb_fps.SelectedItem.ToString = "Default" Then
                strFPS = ""
            Else
                Dim tempFPS As String = cmb_fps.SelectedItem.Trim.Substring(0, cmb_fps.SelectedItem.ToString.Count - 4)
                strFPS = " --max-fps " & tempFPS
                If Not tempFPS = "60" Then
                    chk_60fps.Checked = False
                End If
            End If
        End If
    End Sub
    Private Sub cmb_mode_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_mode.SelectedIndexChanged
        'Check TCPIP
        If cmb_mode.SelectedIndex = 0 Then
            cmb_ip.Enabled = False
            strTCPIP = ""
        Else
            cmb_ip.Enabled = True
            strTCPIP = " --tcp-ip"
        End If
    End Sub
    Private Sub cmb_ip_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_ip.SelectedIndexChanged
        If cmb_ip.Enabled = True And cmb_ip.SelectedIndex = 0 Then
            strTCPIP = " --tcp-ip"
        End If
        If cmb_ip.SelectedIndex = 1 Then
            strJudul = "please_enter_your_wireless_debugging_ip"
            strPertanyaan = "device_ip>"
            strOnChange = "tcpip"
            frm_customInput.Show()
        End If
    End Sub

    Public Sub acceptChanges()
        If strOnChange = "tcpip" Then
            If strStringOutput = "" Then
                MsgBox("IP Address must be filled.", vbCritical, "Error!")
                cmb_ip.SelectedIndex = 0
            Else
                strTCPIP = " --tcp-ip=" & strStringOutput
                'cmb_ip.Items.Insert(cmb_ip.Items.Count + 1, strStringOutput)
            End If
        End If

        If strOnChange = "resolution" Or strOnChange = "bitrate" Or strOnChange = "fps" Then
            If Not strIntegerOutput = "0" Then
                If strOnChange = "resolution" Then
                    If strIntegerOutput < 144 Then
                        MsgBox("Resolution must be higher than 144p.", vbCritical, "Error!")
                        cmb_resolution.SelectedIndex = idxResolution
                    Else
                        strResolution = " -m " & strIntegerOutput
                        'cmb_resolution.Items.Insert(cmb_resolution.Items.Count, strIntegerOutput & "p")
                    End If
                End If

                If strOnChange = "bitrate" Then
                    If strIntegerOutput < 5 Then
                        MsgBox("Bitrate must be higher than 5M.", vbCritical, "Error!")
                        cmb_bitrate.SelectedIndex = idxBitrate
                    Else
                        strBitrate = " -b " & strIntegerOutput & "M"
                        'cmb_bitrate.Items.Insert(cmb_bitrate.Items.Count, strIntegerOutput & " M")
                    End If
                End If

                If strOnChange = "fps" Then
                    'cmb_fps.Items.Insert(cmb_fps.Items.Count, strIntegerOutput & " fps")
                    strFPS = " --max-fps " & strIntegerOutput
                End If
            Else
                If strOnChange = "resolution" Then
                    cmb_resolution.SelectedIndex = idxResolution
                End If
                If strOnChange = "bitrate" Then
                    cmb_bitrate.SelectedIndex = idxBitrate
                End If
                If strOnChange = "fps" Then
                    cmb_bitrate.SelectedIndex = idxFPS
                End If
            End If
        End If

        If strOnChange = "preset" Then
            tb_preset.Clear()
            tb_preset.AppendText(bar_ezpreset.Value.ToString & vbNewLine)
            tb_preset.AppendText(chk_60fps.Checked.ToString & vbNewLine)
            tb_preset.AppendText(chk_fullscreen.Checked.ToString & vbNewLine)
            tb_preset.AppendText(cmb_resolution.SelectedIndex.ToString & vbNewLine)
            tb_preset.AppendText(cmb_bitrate.SelectedIndex.ToString & vbNewLine)
            tb_preset.AppendText(cmb_fps.SelectedIndex.ToString & vbNewLine)
            tb_preset.AppendText(cmb_mode.SelectedIndex.ToString & vbNewLine)
            tb_preset.AppendText(cmb_ip.SelectedIndex.ToString & vbNewLine)
            tb_preset.AppendText("-----BREAK----------strStates-----" & vbNewLine)
            tb_preset.AppendText(strScrcpyPath & vbNewLine)
            tb_preset.AppendText(strFullscreen & vbNewLine)
            tb_preset.AppendText(strResolution & vbNewLine)
            tb_preset.AppendText(strBitrate & vbNewLine)
            tb_preset.AppendText(strFPS & vbNewLine)
            tb_preset.AppendText(strTCPIP)

            If Not System.IO.Directory.Exists(Application.StartupPath & "\output\") Then
                System.IO.Directory.CreateDirectory(Application.StartupPath & "\output\")
            End If
            System.IO.File.WriteAllText(Application.StartupPath & "\output\" & strPresetOutput & ".anpf", tb_preset.Text)
        End If
    End Sub

    Sub launchArguments()
        Dim pHelp As New ProcessStartInfo
        pHelp.FileName = "cmd.exe"
        pHelp.Arguments = ("/c scrcpy.exe" & strFullscreen & strResolution & strBitrate & strFPS & strTCPIP)
        pHelp.UseShellExecute = True
        pHelp.WindowStyle = ProcessWindowStyle.Hidden
        Dim proc As Process = Process.Start(pHelp)
    End Sub

    Private Sub chk_fullscreen_CheckedChanged(sender As Object, e As EventArgs) Handles chk_fullscreen.CheckedChanged
        If chk_fullscreen.Checked = True Then
            strFullscreen = " -f"
        Else
            strFullscreen = ""
        End If
    End Sub

    Private Sub btn_start_Click(sender As Object, e As EventArgs) Handles btn_start.Click
        Call launchArguments()
        'MsgBox(strFullscreen & strResolution & strBitrate & strFPS & strTCPIP)
    End Sub

    Private Sub bar_ezpreset_Scroll(sender As Object, e As EventArgs) Handles bar_ezpreset.Scroll
        Call updateEZMode()
    End Sub

    Sub updateEZMode()
        If bar_ezpreset.Value = 0 Then
            cmb_resolution.SelectedIndex = 4
        ElseIf bar_ezpreset.Value = 1 Then
            cmb_resolution.SelectedIndex = 3
        ElseIf bar_ezpreset.Value = 2 Then
            cmb_resolution.SelectedIndex = 2
        ElseIf bar_ezpreset.Value = 3 Then
            cmb_resolution.SelectedIndex = 1
        ElseIf bar_ezpreset.Value = 4 Then
            cmb_resolution.SelectedIndex = 0
        End If
    End Sub

    Private Sub pic_preset_save_Click(sender As Object, e As EventArgs) Handles pic_preset_save.Click
        strJudul = "save_preset_as"
        strPertanyaan = "preset_name>"
        strOnChange = "preset"
        frm_customInput.Show()
    End Sub

    Private Sub cmb_preset_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_preset.SelectedIndexChanged

    End Sub

    Private Sub pic_preset_load_Click(sender As Object, e As EventArgs) Handles pic_preset_load.Click
        Dim lines = System.IO.File.ReadAllLines(Application.StartupPath & "\output\" & cmb_preset.SelectedItem & ".anpf")

        bar_ezpreset.Value = Convert.ToInt32(lines(0))
        chk_60fps.Checked = lines(1)
        chk_fullscreen.Checked = lines(2)
        cmb_resolution.SelectedIndex = Convert.ToInt32(lines(3))
        cmb_bitrate.SelectedIndex = Convert.ToInt32(lines(4))
        cmb_fps.SelectedIndex = Convert.ToInt32(lines(5))
        cmb_mode.SelectedIndex = Convert.ToInt32(lines(6))
        cmb_ip.SelectedIndex = Convert.ToInt32(lines(7))
        strScrcpyPath = lines(8)
        strFullscreen = lines(9)
        strResolution = lines(10)
        strBitrate = lines(11)
        strFPS = lines(12)
        strTCPIP = lines(13)
    End Sub

    Private Sub cmb_preset_MouseClick(sender As Object, e As MouseEventArgs) Handles cmb_preset.MouseClick
        cmb_preset.Items.Clear()
        If Not System.IO.Directory.Exists(Application.StartupPath & "\output\") Then
            System.IO.Directory.CreateDirectory(Application.StartupPath & "\output\")
        End If
        For Each file As String In System.IO.Directory.GetFiles(Application.StartupPath & "\output\")
            cmb_preset.Items.Add(System.IO.Path.GetFileNameWithoutExtension(file))
        Next
    End Sub

    Private Sub frm_main_Load(sender As Object, e As EventArgs) Handles Me.Load
        'Initialize Controls
        cmb_resolution.SelectedIndex = 4
        cmb_bitrate.SelectedIndex = 0
        cmb_fps.SelectedIndex = 4

        cmb_mode.SelectedIndex = 0
        cmb_ip.SelectedIndex = 0

        cmb_preset.SelectedIndex = 0

        'If Not System.IO.File.Exists(Application.StartupPath & "\scrcpy.exe") Then
        'MsgBox("Please run this program on the same folder where scrcpy is being placed.", vbCritical, "Critical Error!")
        'Me.close
        'End If
    End Sub
End Class
