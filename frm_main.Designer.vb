<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_main
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_main))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.bar_ezpreset = New System.Windows.Forms.TrackBar()
        Me.btn_start = New System.Windows.Forms.Button()
        Me.btn_toggle_adv = New System.Windows.Forms.Button()
        Me.chk_60fps = New System.Windows.Forms.CheckBox()
        Me.cmb_preset = New System.Windows.Forms.ComboBox()
        Me.cmb_resolution = New System.Windows.Forms.ComboBox()
        Me.cmb_bitrate = New System.Windows.Forms.ComboBox()
        Me.cmb_fps = New System.Windows.Forms.ComboBox()
        Me.lbl_credit = New System.Windows.Forms.Label()
        Me.lbl_480 = New System.Windows.Forms.Label()
        Me.lbl_720 = New System.Windows.Forms.Label()
        Me.lbl_900 = New System.Windows.Forms.Label()
        Me.lbl_1080 = New System.Windows.Forms.Label()
        Me.lbl_native = New System.Windows.Forms.Label()
        Me.lbl_divider = New System.Windows.Forms.Label()
        Me.lbl_resolution = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lbl_userpreset = New System.Windows.Forms.Label()
        Me.chk_fullscreen = New System.Windows.Forms.CheckBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cmb_ip = New System.Windows.Forms.ComboBox()
        Me.cmb_mode = New System.Windows.Forms.ComboBox()
        Me.pic_preset_del = New System.Windows.Forms.PictureBox()
        Me.pic_preset_load = New System.Windows.Forms.PictureBox()
        Me.pic_preset_save = New System.Windows.Forms.PictureBox()
        Me.tb_launchOutput = New System.Windows.Forms.TextBox()
        Me.tb_preset = New System.Windows.Forms.TextBox()
        CType(Me.bar_ezpreset, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pic_preset_del, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pic_preset_load, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pic_preset_save, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Open Sans SemiBold", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(277, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(192, 69)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "EZcpy>"
        '
        'bar_ezpreset
        '
        Me.bar_ezpreset.Location = New System.Drawing.Point(12, 96)
        Me.bar_ezpreset.Maximum = 4
        Me.bar_ezpreset.Name = "bar_ezpreset"
        Me.bar_ezpreset.Size = New System.Drawing.Size(723, 45)
        Me.bar_ezpreset.TabIndex = 1
        '
        'btn_start
        '
        Me.btn_start.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_start.Font = New System.Drawing.Font("Open Sans Medium", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_start.Location = New System.Drawing.Point(291, 170)
        Me.btn_start.Name = "btn_start"
        Me.btn_start.Size = New System.Drawing.Size(164, 47)
        Me.btn_start.TabIndex = 3
        Me.btn_start.Text = "start>"
        Me.btn_start.UseVisualStyleBackColor = True
        '
        'btn_toggle_adv
        '
        Me.btn_toggle_adv.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_toggle_adv.Font = New System.Drawing.Font("Open Sans", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_toggle_adv.Location = New System.Drawing.Point(613, 186)
        Me.btn_toggle_adv.Name = "btn_toggle_adv"
        Me.btn_toggle_adv.Size = New System.Drawing.Size(122, 31)
        Me.btn_toggle_adv.TabIndex = 4
        Me.btn_toggle_adv.Text = "advanced_mode ▶"
        Me.btn_toggle_adv.UseVisualStyleBackColor = True
        '
        'chk_60fps
        '
        Me.chk_60fps.AutoSize = True
        Me.chk_60fps.Font = New System.Drawing.Font("Open Sans", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chk_60fps.Location = New System.Drawing.Point(12, 178)
        Me.chk_60fps.Name = "chk_60fps"
        Me.chk_60fps.Size = New System.Drawing.Size(92, 19)
        Me.chk_60fps.TabIndex = 5
        Me.chk_60fps.Text = "enable 60fps"
        Me.chk_60fps.UseVisualStyleBackColor = True
        '
        'cmb_preset
        '
        Me.cmb_preset.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(37, Byte), Integer))
        Me.cmb_preset.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_preset.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmb_preset.Font = New System.Drawing.Font("Open Sans", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_preset.ForeColor = System.Drawing.Color.FromArgb(CType(CType(233, Byte), Integer), CType(CType(233, Byte), Integer), CType(CType(233, Byte), Integer))
        Me.cmb_preset.FormattingEnabled = True
        Me.cmb_preset.Items.AddRange(New Object() {"Click to Refresh"})
        Me.cmb_preset.Location = New System.Drawing.Point(12, 308)
        Me.cmb_preset.Name = "cmb_preset"
        Me.cmb_preset.Size = New System.Drawing.Size(141, 23)
        Me.cmb_preset.TabIndex = 9
        '
        'cmb_resolution
        '
        Me.cmb_resolution.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(37, Byte), Integer))
        Me.cmb_resolution.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_resolution.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmb_resolution.Font = New System.Drawing.Font("Open Sans", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_resolution.ForeColor = System.Drawing.Color.FromArgb(CType(CType(233, Byte), Integer), CType(CType(233, Byte), Integer), CType(CType(233, Byte), Integer))
        Me.cmb_resolution.FormattingEnabled = True
        Me.cmb_resolution.Items.AddRange(New Object() {"Native", "1080p", "900p", "720p", "480p", "Custom"})
        Me.cmb_resolution.Location = New System.Drawing.Point(12, 259)
        Me.cmb_resolution.Name = "cmb_resolution"
        Me.cmb_resolution.Size = New System.Drawing.Size(87, 23)
        Me.cmb_resolution.TabIndex = 10
        '
        'cmb_bitrate
        '
        Me.cmb_bitrate.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(37, Byte), Integer))
        Me.cmb_bitrate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_bitrate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmb_bitrate.Font = New System.Drawing.Font("Open Sans", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_bitrate.ForeColor = System.Drawing.Color.FromArgb(CType(CType(233, Byte), Integer), CType(CType(233, Byte), Integer), CType(CType(233, Byte), Integer))
        Me.cmb_bitrate.FormattingEnabled = True
        Me.cmb_bitrate.Items.AddRange(New Object() {"Default", "50M", "40M", "30M", "20M", "10M", "Custom"})
        Me.cmb_bitrate.Location = New System.Drawing.Point(105, 259)
        Me.cmb_bitrate.Name = "cmb_bitrate"
        Me.cmb_bitrate.Size = New System.Drawing.Size(87, 23)
        Me.cmb_bitrate.TabIndex = 11
        '
        'cmb_fps
        '
        Me.cmb_fps.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(37, Byte), Integer))
        Me.cmb_fps.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_fps.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmb_fps.Font = New System.Drawing.Font("Open Sans", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_fps.ForeColor = System.Drawing.Color.FromArgb(CType(CType(233, Byte), Integer), CType(CType(233, Byte), Integer), CType(CType(233, Byte), Integer))
        Me.cmb_fps.FormattingEnabled = True
        Me.cmb_fps.Items.AddRange(New Object() {"Default", "120 fps", "90 fps", "60 fps", "30 fps", "15 fps", "Custom"})
        Me.cmb_fps.Location = New System.Drawing.Point(198, 259)
        Me.cmb_fps.Name = "cmb_fps"
        Me.cmb_fps.Size = New System.Drawing.Size(68, 23)
        Me.cmb_fps.TabIndex = 12
        '
        'lbl_credit
        '
        Me.lbl_credit.AutoSize = True
        Me.lbl_credit.Font = New System.Drawing.Font("Open Sans", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_credit.Location = New System.Drawing.Point(539, 308)
        Me.lbl_credit.Name = "lbl_credit"
        Me.lbl_credit.Size = New System.Drawing.Size(196, 17)
        Me.lbl_credit.TabIndex = 14
        Me.lbl_credit.Text = "made with ♥ by Asuka Nocturnia"
        '
        'lbl_480
        '
        Me.lbl_480.AutoSize = True
        Me.lbl_480.Font = New System.Drawing.Font("Open Sans", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_480.Location = New System.Drawing.Point(5, 124)
        Me.lbl_480.Name = "lbl_480"
        Me.lbl_480.Size = New System.Drawing.Size(44, 15)
        Me.lbl_480.TabIndex = 15
        Me.lbl_480.Text = "480p30"
        Me.lbl_480.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl_720
        '
        Me.lbl_720.AutoSize = True
        Me.lbl_720.Font = New System.Drawing.Font("Open Sans", 8.25!)
        Me.lbl_720.Location = New System.Drawing.Point(177, 124)
        Me.lbl_720.Name = "lbl_720"
        Me.lbl_720.Size = New System.Drawing.Size(44, 15)
        Me.lbl_720.TabIndex = 16
        Me.lbl_720.Text = "720p30"
        Me.lbl_720.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl_900
        '
        Me.lbl_900.AutoSize = True
        Me.lbl_900.Font = New System.Drawing.Font("Open Sans", 8.25!)
        Me.lbl_900.Location = New System.Drawing.Point(352, 126)
        Me.lbl_900.Name = "lbl_900"
        Me.lbl_900.Size = New System.Drawing.Size(44, 15)
        Me.lbl_900.TabIndex = 17
        Me.lbl_900.Text = "900p30"
        Me.lbl_900.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl_1080
        '
        Me.lbl_1080.AutoSize = True
        Me.lbl_1080.Font = New System.Drawing.Font("Open Sans", 8.25!)
        Me.lbl_1080.Location = New System.Drawing.Point(521, 126)
        Me.lbl_1080.Name = "lbl_1080"
        Me.lbl_1080.Size = New System.Drawing.Size(50, 15)
        Me.lbl_1080.TabIndex = 18
        Me.lbl_1080.Text = "1080p30"
        Me.lbl_1080.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl_native
        '
        Me.lbl_native.AutoSize = True
        Me.lbl_native.Font = New System.Drawing.Font("Open Sans", 8.25!)
        Me.lbl_native.Location = New System.Drawing.Point(702, 126)
        Me.lbl_native.Name = "lbl_native"
        Me.lbl_native.Size = New System.Drawing.Size(39, 15)
        Me.lbl_native.TabIndex = 19
        Me.lbl_native.Text = "Native"
        Me.lbl_native.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl_divider
        '
        Me.lbl_divider.AutoSize = True
        Me.lbl_divider.Font = New System.Drawing.Font("Open Sans", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_divider.Location = New System.Drawing.Point(-24, 218)
        Me.lbl_divider.Name = "lbl_divider"
        Me.lbl_divider.Size = New System.Drawing.Size(933, 17)
        Me.lbl_divider.TabIndex = 20
        Me.lbl_divider.Text = "_________________________________________________________________________________" &
    "________________________________________________________________________________" &
    "________________________"
        '
        'lbl_resolution
        '
        Me.lbl_resolution.AutoSize = True
        Me.lbl_resolution.Font = New System.Drawing.Font("Open Sans", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_resolution.Location = New System.Drawing.Point(9, 240)
        Me.lbl_resolution.Name = "lbl_resolution"
        Me.lbl_resolution.Size = New System.Drawing.Size(71, 17)
        Me.lbl_resolution.TabIndex = 21
        Me.lbl_resolution.Text = "resolution>"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Open Sans", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(102, 240)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(52, 17)
        Me.Label2.TabIndex = 22
        Me.Label2.Text = "bitrate>"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Open Sans", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(195, 240)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(32, 17)
        Me.Label3.TabIndex = 23
        Me.Label3.Text = "fps>"
        '
        'lbl_userpreset
        '
        Me.lbl_userpreset.AutoSize = True
        Me.lbl_userpreset.Font = New System.Drawing.Font("Open Sans", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_userpreset.Location = New System.Drawing.Point(9, 289)
        Me.lbl_userpreset.Name = "lbl_userpreset"
        Me.lbl_userpreset.Size = New System.Drawing.Size(81, 17)
        Me.lbl_userpreset.TabIndex = 24
        Me.lbl_userpreset.Text = "user_preset>"
        '
        'chk_fullscreen
        '
        Me.chk_fullscreen.AutoSize = True
        Me.chk_fullscreen.Font = New System.Drawing.Font("Open Sans", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chk_fullscreen.Location = New System.Drawing.Point(12, 198)
        Me.chk_fullscreen.Name = "chk_fullscreen"
        Me.chk_fullscreen.Size = New System.Drawing.Size(114, 19)
        Me.chk_fullscreen.TabIndex = 25
        Me.chk_fullscreen.Text = "enable fullscreen"
        Me.chk_fullscreen.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Open Sans", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(582, 244)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(25, 17)
        Me.Label4.TabIndex = 29
        Me.Label4.Text = "ip>"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Open Sans", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(489, 244)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(47, 17)
        Me.Label5.TabIndex = 28
        Me.Label5.Text = "mode>"
        '
        'cmb_ip
        '
        Me.cmb_ip.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(37, Byte), Integer))
        Me.cmb_ip.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_ip.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmb_ip.Font = New System.Drawing.Font("Open Sans", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_ip.ForeColor = System.Drawing.Color.FromArgb(CType(CType(233, Byte), Integer), CType(CType(233, Byte), Integer), CType(CType(233, Byte), Integer))
        Me.cmb_ip.FormattingEnabled = True
        Me.cmb_ip.Items.AddRange(New Object() {"init_with_usb", "manually_enter_ip"})
        Me.cmb_ip.Location = New System.Drawing.Point(585, 263)
        Me.cmb_ip.Name = "cmb_ip"
        Me.cmb_ip.Size = New System.Drawing.Size(150, 23)
        Me.cmb_ip.TabIndex = 27
        '
        'cmb_mode
        '
        Me.cmb_mode.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(37, Byte), Integer))
        Me.cmb_mode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_mode.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmb_mode.Font = New System.Drawing.Font("Open Sans", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_mode.ForeColor = System.Drawing.Color.FromArgb(CType(CType(233, Byte), Integer), CType(CType(233, Byte), Integer), CType(CType(233, Byte), Integer))
        Me.cmb_mode.FormattingEnabled = True
        Me.cmb_mode.Items.AddRange(New Object() {"usb_cable", "tcp_ip"})
        Me.cmb_mode.Location = New System.Drawing.Point(492, 263)
        Me.cmb_mode.Name = "cmb_mode"
        Me.cmb_mode.Size = New System.Drawing.Size(87, 23)
        Me.cmb_mode.TabIndex = 26
        '
        'pic_preset_del
        '
        Me.pic_preset_del.BackColor = System.Drawing.Color.Transparent
        Me.pic_preset_del.BackgroundImage = Global.EZcpy.My.Resources.Resources.wastebasket
        Me.pic_preset_del.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pic_preset_del.Location = New System.Drawing.Point(219, 308)
        Me.pic_preset_del.Name = "pic_preset_del"
        Me.pic_preset_del.Size = New System.Drawing.Size(24, 24)
        Me.pic_preset_del.TabIndex = 8
        Me.pic_preset_del.TabStop = False
        '
        'pic_preset_load
        '
        Me.pic_preset_load.BackColor = System.Drawing.Color.Transparent
        Me.pic_preset_load.BackgroundImage = Global.EZcpy.My.Resources.Resources.open_file_folder
        Me.pic_preset_load.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pic_preset_load.Location = New System.Drawing.Point(189, 308)
        Me.pic_preset_load.Name = "pic_preset_load"
        Me.pic_preset_load.Size = New System.Drawing.Size(24, 24)
        Me.pic_preset_load.TabIndex = 7
        Me.pic_preset_load.TabStop = False
        '
        'pic_preset_save
        '
        Me.pic_preset_save.BackColor = System.Drawing.Color.Transparent
        Me.pic_preset_save.BackgroundImage = Global.EZcpy.My.Resources.Resources.floppy_disk
        Me.pic_preset_save.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pic_preset_save.Location = New System.Drawing.Point(159, 308)
        Me.pic_preset_save.Name = "pic_preset_save"
        Me.pic_preset_save.Size = New System.Drawing.Size(24, 24)
        Me.pic_preset_save.TabIndex = 6
        Me.pic_preset_save.TabStop = False
        '
        'tb_launchOutput
        '
        Me.tb_launchOutput.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(37, Byte), Integer))
        Me.tb_launchOutput.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tb_launchOutput.Font = New System.Drawing.Font("Open Sans", 8.25!)
        Me.tb_launchOutput.ForeColor = System.Drawing.Color.FromArgb(CType(CType(233, Byte), Integer), CType(CType(233, Byte), Integer), CType(CType(233, Byte), Integer))
        Me.tb_launchOutput.Location = New System.Drawing.Point(12, 12)
        Me.tb_launchOutput.Multiline = True
        Me.tb_launchOutput.Name = "tb_launchOutput"
        Me.tb_launchOutput.ReadOnly = True
        Me.tb_launchOutput.Size = New System.Drawing.Size(723, 66)
        Me.tb_launchOutput.TabIndex = 30
        Me.tb_launchOutput.TabStop = False
        Me.tb_launchOutput.Visible = False
        '
        'tb_preset
        '
        Me.tb_preset.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(37, Byte), Integer))
        Me.tb_preset.ForeColor = System.Drawing.Color.FromArgb(CType(CType(233, Byte), Integer), CType(CType(233, Byte), Integer), CType(CType(233, Byte), Integer))
        Me.tb_preset.Location = New System.Drawing.Point(-96, -237)
        Me.tb_preset.Multiline = True
        Me.tb_preset.Name = "tb_preset"
        Me.tb_preset.ReadOnly = True
        Me.tb_preset.Size = New System.Drawing.Size(176, 327)
        Me.tb_preset.TabIndex = 31
        Me.tb_preset.TabStop = False
        Me.tb_preset.Visible = False
        '
        'frm_main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(37, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(747, 231)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.cmb_ip)
        Me.Controls.Add(Me.cmb_mode)
        Me.Controls.Add(Me.chk_fullscreen)
        Me.Controls.Add(Me.lbl_userpreset)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lbl_resolution)
        Me.Controls.Add(Me.lbl_divider)
        Me.Controls.Add(Me.lbl_native)
        Me.Controls.Add(Me.lbl_1080)
        Me.Controls.Add(Me.lbl_900)
        Me.Controls.Add(Me.lbl_720)
        Me.Controls.Add(Me.lbl_480)
        Me.Controls.Add(Me.lbl_credit)
        Me.Controls.Add(Me.cmb_fps)
        Me.Controls.Add(Me.cmb_bitrate)
        Me.Controls.Add(Me.cmb_resolution)
        Me.Controls.Add(Me.cmb_preset)
        Me.Controls.Add(Me.pic_preset_del)
        Me.Controls.Add(Me.pic_preset_load)
        Me.Controls.Add(Me.pic_preset_save)
        Me.Controls.Add(Me.chk_60fps)
        Me.Controls.Add(Me.btn_toggle_adv)
        Me.Controls.Add(Me.btn_start)
        Me.Controls.Add(Me.bar_ezpreset)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.tb_launchOutput)
        Me.Controls.Add(Me.tb_preset)
        Me.ForeColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frm_main"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "EZcpy"
        CType(Me.bar_ezpreset, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pic_preset_del, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pic_preset_load, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pic_preset_save, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents bar_ezpreset As TrackBar
    Friend WithEvents btn_start As Button
    Friend WithEvents btn_toggle_adv As Button
    Friend WithEvents chk_60fps As CheckBox
    Friend WithEvents pic_preset_save As PictureBox
    Friend WithEvents pic_preset_load As PictureBox
    Friend WithEvents pic_preset_del As PictureBox
    Friend WithEvents cmb_preset As ComboBox
    Friend WithEvents cmb_resolution As ComboBox
    Friend WithEvents cmb_bitrate As ComboBox
    Friend WithEvents cmb_fps As ComboBox
    Friend WithEvents lbl_credit As Label
    Friend WithEvents lbl_480 As Label
    Friend WithEvents lbl_720 As Label
    Friend WithEvents lbl_900 As Label
    Friend WithEvents lbl_1080 As Label
    Friend WithEvents lbl_native As Label
    Friend WithEvents lbl_divider As Label
    Friend WithEvents lbl_resolution As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents lbl_userpreset As Label
    Friend WithEvents chk_fullscreen As CheckBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents cmb_ip As ComboBox
    Friend WithEvents cmb_mode As ComboBox
    Friend WithEvents tb_launchOutput As TextBox
    Friend WithEvents tb_preset As TextBox
End Class
