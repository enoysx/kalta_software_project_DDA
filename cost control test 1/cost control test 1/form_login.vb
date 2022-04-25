Imports System.Data.OleDb
Public Class form_login
    Private Sub form_login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call connection()
        txt_pass.Focus()
    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub

    Private Sub btn_exit_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub

    Private Sub btn_login_Click(sender As Object, e As EventArgs) Handles btn_login.Click

        If txt_pass.Text = "" Then
            MsgBox("Harap masukan password", MsgBoxStyle.Information, "Peringatan")
        Else
            Call connection()
            SQLstring = (" Select * from user_info where password = '" & txt_pass.Text & "'")
            command = New OleDbCommand(SQLstring, connect)
            dRead = command.ExecuteReader
            If dRead.HasRows Then
                Me.Hide()
                dashboard.Show()
                txt_pass.Clear()
            Else
                dRead.Close()
                MessageBox.Show("Password salah !", "Login Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txt_pass.Clear()
                txt_pass.Focus()
            End If

        End If

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        If connect.State = ConnectionState.Closed Then
            MsgBox("Koneksi Database Gagal", vbCritical, "Disconnected")
        Else
            MsgBox("Koneksi Database Berhasil", vbOKOnly, "Connected")
        End If
    End Sub

    Private Sub txt_pass_TextChanged(sender As Object, e As EventArgs) Handles txt_pass.TextChanged
        txt_pass.PasswordChar = "*"
    End Sub

    Private Sub jam_login_Tick(sender As Object, e As EventArgs) Handles jam_login.Tick
        jam.Text = Format(Now, "")
    End Sub


End Class
