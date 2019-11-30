﻿Public Class PN_Menu
    Dim namaisi As Boolean
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles L1.Click

    End Sub


    Private Sub BT_Mulai_Click(sender As Object, e As EventArgs) Handles BT_Mulai.Click
        namaisi = True
        If Main_Menu.RB_P2.Checked = True Then
            If PN_1.Text = "" And PN_2.Text = "" Then
                MsgBox("Nama pemain belum terisi")
                namaisi = False
            End If
        ElseIf Main_Menu.RB_P3.Checked = True Then
            If PN_1.Text = "" And PN_2.Text = "" And PN_3.Text = "" Then
                MsgBox("Nama pemain belum terisi")
                namaisi = False
            End If
        ElseIf Main_Menu.RB_P4.Checked = True Then
            If PN_1.Text = "" And PN_2.Text = "" And PN_3.Text = "" And PN_4.Text = "" Then
                MsgBox("Nama pemain belum terisi")
                namaisi = False
            End If
        End If
        If namaisi = True Then
            Dim result = MessageBox.Show("Apakah sudah yakin?", "Yakin?", MessageBoxButtons.OKCancel, MessageBoxIcon.Information)
            If result = DialogResult.OK Then
                MsgBox("mulai")
            ElseIf result = DialogResult.Cancel Then
                MsgBox("batal")
            End If
        End If
    End Sub

    Private Sub PN_Menu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LB_Diff.Text = "Difficult: " & Main_Menu.LB_Diff.Text
        LB_Ukur.Text = "Ukuran: " & Main_Menu.LB_Ukuran.Text
        If Main_Menu.RB_P4.Checked = True Then
            P1_Name.Visible = True
            PN_1.Visible = True
            P2_Name.Visible = True
            PN_2.Visible = True
            P3_Name.Visible = True
            PN_3.Visible = True
            P4_Name.Visible = True
            PN_4.Visible = True
        ElseIf Main_Menu.RB_P3.Checked = True Then
            P1_Name.Visible = True
            PN_1.Visible = True
            P2_Name.Visible = True
            PN_2.Visible = True
            P3_Name.Visible = True
            PN_3.Visible = True
            P4_Name.Visible = False
            PN_4.Visible = False
        ElseIf Main_Menu.RB_P2.Checked = True Then
            P1_Name.Visible = True
            PN_1.Visible = True
            P2_Name.Visible = True
            PN_2.Visible = True
            P3_Name.Visible = False
            PN_3.Visible = False
            P4_Name.Visible = False
            PN_4.Visible = False
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub
End Class