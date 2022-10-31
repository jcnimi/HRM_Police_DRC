Imports System.Data
Imports System.Data.SqlClient

Module Module1
    Public userId As String = 1
    Public conn As New SqlConnection("Server=localhost;Database=hrm_police;User Id=jcnimi;Password=finca4321;")

    Public Sub loadComboBox(ByRef combo As ComboBox, ByVal queryString As String)
        Dim adapter As New SqlDataAdapter()
        Dim ds As New DataSet()
        Dim i As Integer = 0
        Try
            combo.Items.Clear()
            Using cmd As SqlCommand = New SqlCommand(queryString, conn)
                adapter.SelectCommand = cmd
                adapter.Fill(ds)
                adapter.Dispose()
                combo.DataSource = ds.Tables(0)
                combo.ValueMember = "value"
                combo.DisplayMember = "display"
            End Using

        Catch ex As Exception
            MessageBox.Show("Error: " + ex.Message)
        End Try
    End Sub


    Sub Main()
        conn.Open()
        Dim frm As New frmMain
        frm.ShowDialog()
        conn.Close()
    End Sub
End Module


