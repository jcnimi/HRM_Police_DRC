Imports System.Data
Imports System.Data.SqlClient
Imports System.Drawing.Imaging
Imports System.IO
Imports Microsoft.VisualBasic.Devices
Imports Newtonsoft.Json.Linq

Module Module1
    Public userId As String = ""
    Public userFullName As String = ""
    Public userName_ As String = ""
    Public userPwd As String = ""
    Public connString As String = ""
    Public conn As New SqlConnection()
    Public capturedImage As String
    Public cardPressoPath As String

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
        Try
            'config file
            Dim configFile As String = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location) + "\" + "settings.json"
            Dim fileReader As New System.IO.StreamReader(configFile)
            Dim configFileContent As String = fileReader.ReadToEnd()
            Dim parsejson As JObject = JObject.Parse(configFileContent)
            Dim db As JObject = JObject.Parse(parsejson.SelectToken("db").ToString())
            Dim windows_authetication = parsejson.SelectToken("db.windows_authetication").ToString()
            Dim Server = parsejson.SelectToken("db.Server").ToString()
            Dim Database = parsejson.SelectToken("db.Database").ToString()
            Dim UserId = parsejson.SelectToken("db.UserId").ToString()
            Dim Password = parsejson.SelectToken("db.Password").ToString()
            If windows_authetication = "yes" Then
                connString = $"Persist Security Info=False;Trusted_Connection=True;database={Database};server={Server}"
            Else
                connString = $"Server={Server};Database={Database};User Id={UserId};Password={Password};"
            End If
            cardPressoPath = parsejson.SelectToken("cardpresso.path").ToString()

            conn.ConnectionString = connString
            conn.Open()
            Dim frm As New frmLogin
            frm.ShowDialog()
            conn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Public Function btnScale_Click(ByRef img As System.Drawing.Image, ByVal scale As Integer) As System.Drawing.Image
        ' Get the scale factor.
        Dim scale_factor As Single = Single.Parse(scale)

        ' Get the source bitmap.
        Dim bm_source As New Bitmap(img)

        ' Make a bitmap for the result.
        Dim bm_dest As New Bitmap(
            CInt(bm_source.Width * scale_factor),
            CInt(bm_source.Height * scale_factor))

        ' Make a Graphics object for the result Bitmap.
        Dim gr_dest As Graphics = Graphics.FromImage(bm_dest)

        ' Copy the source image into the destination bitmap.
        gr_dest.DrawImage(bm_source, 0, 0,
            bm_dest.Width + 1,
            bm_dest.Height + 1)

        ' Display the result.
        Return bm_dest
    End Function

    Public Sub imageLoad(buffer As Byte(), ByRef pic As PictureBox)
        Dim fileName As String = System.IO.Path.GetTempPath() + Guid.NewGuid().ToString() + ".png"
        Using ms As New IO.MemoryStream(buffer)
            Using img As System.Drawing.Image = System.Drawing.Image.FromStream(ms)
                img.Save(fileName)
                pic.Image = Image.FromFile(fileName)
            End Using
        End Using
    End Sub

End Module


