Imports System.Data.OleDb
Public Class form_login
    Private Sub form_login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call connection()
    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub

    Private Sub btn_exit_Click(sender As Object, e As EventArgs) Handles btn_exit.Click
        Me.Close()
    End Sub

    Private Sub btn_login_Click(sender As Object, e As EventArgs) Handles btn_login.Click

        If txt_usr.Text = "" Or txt_pass.Text = "" Then
            MsgBox("Harap masukan username atau password", MsgBoxStyle.Information, "Peringatan")

        Else
            Call connection()
            command = New OleDbCommand(" Select * from user_info where username = '" & txt_usr.Text & "','" password = "' & txt_pass.Text & "' )
        End If

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If connect.State = ConnectionState.Closed Then
            MsgBox("Koneksi Database Gagal", vbCritical, "Disconnected")
        Else
            MsgBox("Koneksi Database Berhasil", vbOKOnly, "Connected")
        End If
    End Sub


End Class
