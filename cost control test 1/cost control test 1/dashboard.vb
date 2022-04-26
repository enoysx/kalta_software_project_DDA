Public Class dashboard

    '--/ Dashboard form Load
    Private Sub dashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call connection()
        panel_dash.Visible = True
        panel_cost_control.Visible = False
        pnl_inven.Visible = False
        panel_admin.Visible = False
    End Sub
    '--/ Breakdown RAP button 
    Private Sub brkdown_rap_Click(sender As Object, e As EventArgs)
        breakdown_rap.Show()
    End Sub
    '--/ Dashboard
    Private Sub btn_dash_Click(sender As Object, e As EventArgs) Handles btn_dash.Click
        panel_dash.Visible = True
        panel_cost_control.Visible = False
        panel_admin.Visible = False
        pnl_inven.Visible = False
    End Sub
    '--/ Cost Control Menu
    Private Sub btn_cost_menu_Click(sender As Object, e As EventArgs) Handles btn_cost_menu.Click
        panel_dash.Visible = False
        pnl_inven.Visible = False
        panel_admin.Visible = False
        panel_cost_control.Visible = True
    End Sub
    '--/ Administration
    Private Sub btn_admin_Click(sender As Object, e As EventArgs) Handles btn_admin.Click
        panel_dash.Visible = False
        pnl_inven.Visible = False
        panel_cost_control.Visible = False
        panel_admin.Visible = True
    End Sub
    '--/ Inventory Menu
    Private Sub btn_inven_Click(sender As Object, e As EventArgs) Handles btn_inven.Click
        panel_dash.Visible = False
        pnl_inven.Visible = True
        panel_cost_control.Visible = False
        panel_admin.Visible = False
    End Sub
    '--/ Date
    Private Sub jam_Tick(sender As Object, e As EventArgs) Handles jam.Tick
        hari_tgl.Text = Format(Now, "")
    End Sub
    '--/ showing form breakdown RAP
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        breakdown_rap.Show()
    End Sub
    '--/ Tender Form and Display
    Private Sub btn_dash_tender_Click(sender As Object, e As EventArgs) Handles btn_dash_tender.Click
        tender.Show()
    End Sub
    '--/ Logout
    Private Sub LogoutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LogoutToolStripMenuItem.Click
        Me.Close()
        form_login.Show()
    End Sub

    Private Sub KeluarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles KeluarToolStripMenuItem.Click
        Me.Close()
    End Sub
    '--/ About
    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        About.Show()
    End Sub

End Class