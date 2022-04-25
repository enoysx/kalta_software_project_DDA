Imports System.Data.OleDb
Public Class breakdown_po
    '--/ Form Load
    Private Sub breakdown_po_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    '--/ Close form
    Private Sub BACKToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BACKToolStripMenuItem.Click
        Me.Close()
    End Sub
    '--/ NEW Variable for input button excel to dgv
    Dim excel As String
    Dim OpenFileDialog As New OpenFileDialog
    '--/ Input file excel to dgv
    Private Sub input_file_Click(sender As Object, e As EventArgs) Handles input_file.Click
        Try

            OpenFileDialog.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyDocuments
            OpenFileDialog.Filter = "All files (*.*)|*.*|Excel files (*.xlsx|*.xlsx|Xls files (*.xls)|*.xls"

            If OpenFileDialog.ShowDialog(Me) = System.Windows.Forms.DialogResult.OK Then
                Dim fi As New IO.FileInfo(OpenFileDialog.FileName)
                Dim FileName As String = OpenFileDialog.FileName
                excel = fi.FullName
                connect = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0; Data Source" + excel + ";Extended Properties = Excel 12.0;")
                dAdapt = New OleDbDataAdapter("select * from [Sheet1$]", connect)
                dSet = New DataSet
                dAdapt.Fill(dSet, "[Sheet1$]")

                dgv_input.DataSource = dSet
                dgv_input.DataMember = "[Sheet1$]"

                connect.Close()
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
            Exit Sub
        End Try

    End Sub
End Class