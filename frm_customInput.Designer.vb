<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_customInput
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
        Me.lbl_pertanyaan = New System.Windows.Forms.Label()
        Me.tb_stringInput = New System.Windows.Forms.TextBox()
        Me.btn_ok = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.num_integerInput = New System.Windows.Forms.NumericUpDown()
        Me.tb_presetInput = New System.Windows.Forms.TextBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.num_integerInput, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbl_pertanyaan
        '
        Me.lbl_pertanyaan.AutoSize = True
        Me.lbl_pertanyaan.Font = New System.Drawing.Font("Open Sans Medium", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_pertanyaan.Location = New System.Drawing.Point(178, 9)
        Me.lbl_pertanyaan.Name = "lbl_pertanyaan"
        Me.lbl_pertanyaan.Size = New System.Drawing.Size(304, 54)
        Me.lbl_pertanyaan.TabIndex = 1
        Me.lbl_pertanyaan.Text = "Ini Pertanyaan:"
        '
        'tb_stringInput
        '
        Me.tb_stringInput.Font = New System.Drawing.Font("Open Sans", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_stringInput.Location = New System.Drawing.Point(187, 69)
        Me.tb_stringInput.Name = "tb_stringInput"
        Me.tb_stringInput.Size = New System.Drawing.Size(475, 33)
        Me.tb_stringInput.TabIndex = 2
        '
        'btn_ok
        '
        Me.btn_ok.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_ok.Font = New System.Drawing.Font("Open Sans Medium", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_ok.Location = New System.Drawing.Point(498, 116)
        Me.btn_ok.Name = "btn_ok"
        Me.btn_ok.Size = New System.Drawing.Size(164, 47)
        Me.btn_ok.TabIndex = 4
        Me.btn_ok.Text = "ok>"
        Me.btn_ok.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = Global.EZcpy.My.Resources.Resources.asukabingung
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(-3, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(175, 175)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'num_integerInput
        '
        Me.num_integerInput.Font = New System.Drawing.Font("Open Sans", 14.25!)
        Me.num_integerInput.Location = New System.Drawing.Point(187, 70)
        Me.num_integerInput.Maximum = New Decimal(New Integer() {9999, 0, 0, 0})
        Me.num_integerInput.Name = "num_integerInput"
        Me.num_integerInput.Size = New System.Drawing.Size(475, 33)
        Me.num_integerInput.TabIndex = 5
        '
        'tb_presetInput
        '
        Me.tb_presetInput.Font = New System.Drawing.Font("Open Sans", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_presetInput.Location = New System.Drawing.Point(187, 69)
        Me.tb_presetInput.Name = "tb_presetInput"
        Me.tb_presetInput.Size = New System.Drawing.Size(475, 33)
        Me.tb_presetInput.TabIndex = 6
        '
        'frm_customInput
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(37, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(674, 175)
        Me.Controls.Add(Me.tb_presetInput)
        Me.Controls.Add(Me.btn_ok)
        Me.Controls.Add(Me.tb_stringInput)
        Me.Controls.Add(Me.lbl_pertanyaan)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.num_integerInput)
        Me.Font = New System.Drawing.Font("Open Sans", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.FromArgb(CType(CType(233, Byte), Integer), CType(CType(233, Byte), Integer), CType(CType(233, Byte), Integer))
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frm_customInput"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ini title"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.num_integerInput, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents lbl_pertanyaan As Label
    Friend WithEvents tb_stringInput As TextBox
    Friend WithEvents btn_ok As Button
    Friend WithEvents num_integerInput As NumericUpDown
    Friend WithEvents tb_presetInput As TextBox
End Class
