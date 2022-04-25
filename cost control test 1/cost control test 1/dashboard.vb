Public Class dashboard

    '--/ Dashboard form Load
    Private Sub dashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call connection()
        panel_dash.Visible = True
        panel_cost_control.Visible = False
        pnl_inven.Visible = False
    End Sub
    '--/ Logout
    Private Sub LogoutToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles LogoutToolStripMenuItem1.Click
        Me.Close()
        form_login.Show()
    End Sub
    '--/ Breakdown RAP button 
    Private Sub brkdown_rap_Click(sender As Object, e As EventArgs)
        breakdown_po.Show()
    End Sub
    '--/ Dashboard
    Private Sub btn_dash_Click(sender As Object, e As EventArgs) Handles btn_dash.Click
        panel_dash.Visible = True
        panel_cost_control.Visible = False
        pnl_inven.Visible = False
    End Sub
    '--/ Cost Control Menu
    Private Sub btn_cost_menu_Click(sender As Object, e As EventArgs) Handles btn_cost_menu.Click
        panel_dash.Visible = False
        pnl_inven.Visible = False
        panel_cost_control.Visible = True
    End Sub
    '--/ Inventory Menu
    Private Sub btn_inven_Click(sender As Object, e As EventArgs) Handles btn_inven.Click
        panel_dash.Visible = False
        pnl_inven.Visible = True
        panel_cost_control.Visible = False
    End Sub
    '--/ Date
    Private Sub jam_Tick(sender As Object, e As EventArgs) Handles jam.Tick
        hari_tgl.Text = Format(Now, "")
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        breakdown_po.Show()
    End Sub
End Class