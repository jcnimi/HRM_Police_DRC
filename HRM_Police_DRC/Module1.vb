Imports System.Data
Imports System.Data.SqlClient

Module Module1
    Public userId As String = 1
    Public conn As New SqlConnection("Server=localhost;Database=hrm_police;User Id=jcnimi;Password=finca4321;")

    Public Sub insertData(ByVal queryString As String)
        Using cmd As New SqlCommand(queryString, conn)
            Try
                cmd.ExecuteNonQuery()
            Catch ex As SqlException
                MessageBox.Show("Error:" + ex.Message)
            End Try
        End Using
    End Sub

    Public Function getData(ByVal queryString As String)
        Using cmd As New SqlCommand(queryString, conn)
            Try
                Dim result As SqlDataReader = cmd.ExecuteReader()
                Return result
            Catch ex As SqlException
                MessageBox.Show("Error:" + ex.Message)
            End Try
        End Using
    End Function

    Public Sub loadComboBox(ByRef combo As ComboBox, ByVal queryString As String)
        Dim adapter As New SqlDataAdapter()
        Dim ds As New DataSet()
        Dim i As Integer = 0
        Try
            combo.DataSource = Nothing
            combo.Items.Clear()
            Using cmd As New SqlCommand(queryString, conn)
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
        Dim frm As New frmLogin
        frm.ShowDialog()
        conn.Close()
    End Sub
End Module


