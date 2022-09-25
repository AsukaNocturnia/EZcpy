Public Class frm_customInput


    Private Sub btn_ok_Click(sender As Object, e As EventArgs) Handles btn_ok.Click
        If num_integerInput.Visible = True Then
            frm_main.strIntegerOutput = num_integerInput.Value
        End If
        If tb_stringInput.Visible = True Then
            frm_main.strStringOutput = tb_stringInput.Text
        End If
        If tb_presetInput.Visible = True Then
            frm_main.strPresetOutput = tb_presetInput.Text
        End If
        Call frm_main.acceptChanges()
        Me.Close()
    End Sub

    Private Sub frm_customInput_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        Text = frm_main.strJudul
        lbl_pertanyaan.Text = frm_main.strPertanyaan

        If frm_main.strOnChange = "resolution" Or frm_main.strOnChange = "bitrate" Or frm_main.strOnChange = "fps" Then
            num_integerInput.Visible = True
            tb_stringInput.Visible = False
            tb_presetInput.visible = False
        End If

        If frm_main.strOnChange = "tcpip" Then
            num_integerInput.Visible = False
            tb_stringInput.Visible = True
            tb_presetInput.visible = False
        End If

        If frm_main.strOnChange = "preset" Then
            num_integerInput.Visible = False
            tb_stringInput.Visible = False
            tb_presetInput.visible = True
        End If
    End Sub

    Private Sub tb_stringInput_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tb_stringInput.KeyPress
        If Not Char.IsNumber(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) AndAlso Not e.KeyChar = "." Then
            e.Handled = True
        End If
    End Sub
End Class