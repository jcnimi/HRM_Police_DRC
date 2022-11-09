Imports System.Data
Imports System.Data.SqlClient
Imports Newtonsoft.Json.Linq

Module Module1
    Public userId As String = 1
    Public connString As String = ""
    Public conn As New SqlConnection()
    Public capturedImage As String


    Public Sub saveData(ByVal queryString As String, Optional dbParam As List(Of SqlParameter) = Nothing)
        Using cmd As New SqlCommand(queryString, conn)
            'if param not null, add
            If dbParam IsNot Nothing AndAlso dbParam.Count > 0 Then
                For Each e As SqlParameter In dbParam
                    cmd.Parameters.Add(e)
                Next
            End If
            cmd.ExecuteNonQuery()
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
            combo.BeginUpdate()

            Using cmd As New SqlCommand(queryString, conn)
                adapter.SelectCommand = cmd
                adapter.Fill(ds)
                adapter.Dispose()
                combo.DataSource = ds.Tables(0)
                combo.ValueMember = "value"
                combo.DisplayMember = "display"
            End Using
            combo.EndUpdate()

        Catch ex As Exception
            MessageBox.Show("Error: " + ex.Message)
        End Try
    End Sub


    Sub Main()
        'config file
        Dim configFile As String = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location) + "\" + "settings.json"
        Dim fileReader As New System.IO.StreamReader(configFile)
        Dim configFileContent As String = fileReader.ReadToEnd()
        Dim parsejson As JObject = JObject.Parse(configFileContent)
        Dim windows_authetication = parsejson.SelectToken("windows_authetication").ToString()
        Dim Server = parsejson.SelectToken("Server").ToString()
        Dim Database = parsejson.SelectToken("Database").ToString()
        Dim UserId = parsejson.SelectToken("UserId").ToString()
        Dim Password = parsejson.SelectToken("Password").ToString()
        If windows_authetication = "yes" Then
            connString = $"Persist Security Info=False;Trusted_Connection=True;database={Database};server={Server}"
        Else
            connString = $"Server={Server};Database={Database};User Id={UserId};Password={Password};"
        End If

        conn.ConnectionString = connString
        conn.Open()
        Dim frm As New frmLogin
        frm.ShowDialog()
        conn.Close()
    End Sub
End Module


