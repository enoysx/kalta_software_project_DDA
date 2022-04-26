Public Class tender
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        txt_no_tender.Clear()
        txt_nama_tender.Clear()
        txt_tgl_tender.Clear()
        txt_kd_client.Clear()
        txt_nama_client.Clear()
        txt_ket_client.Clear()

        txt_no_tender.Focus()
    End Sub

    Private Sub BACKToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BACKToolStripMenuItem.Click
        Me.Close()
    End Sub
End Class