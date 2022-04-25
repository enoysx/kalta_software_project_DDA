Imports System.Data.OleDb
Module DbConnection

    Public connect As New OleDbConnection
    Public dRead As OleDbDataReader
    Public dAdapt As OleDbDataAdapter
    Public dSet As New DataSet
    Public dTab As New DataTable
    Public command As New OleDbCommand

    Public db As String
    Public SQLstring As String

    Public Sub connection()

        'connect to database access 
        db = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source='cost_control.accdb'; persist security info = false;"
        connect = New OleDbConnection(db)

        'check if connection close, then automatic open connection when app started
        If connect.State = ConnectionState.Closed Then
            connect.Open()
        End If

    End Sub

End Module
