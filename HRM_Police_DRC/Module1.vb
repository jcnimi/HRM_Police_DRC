Imports System.IO
Imports System.Xml.Serialization
Imports Newtonsoft.Json.Linq
Imports SourceAFIS
Imports SourceAFIS.Engine
Imports System.Xml
Imports Emgu.CV.OCR

Module Module1
    Public userId As String = ""
    Public userFullName As String = ""
    Public userName_ As String = ""
    Public userPwd As String = ""
    Public connString As String = ""
    Public conn As New SqlConnection()
    Public capturedImage As String
    Public cardPressoPath As String
    Public Candidates As List(Of Subject)
    Public MappingList As List(Of Mapping)
    Public fileFieldList As ArrayList
    Public dsVillage As DataSet

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

    Public Sub saveDataSP(ByVal procName As String, dbParam As List(Of SqlParameter))
        Using cmd As New SqlCommand(procName, conn)
            cmd.CommandType = CommandType.StoredProcedure
            'if param not null, add
            If dbParam IsNot Nothing AndAlso dbParam.Count > 0 Then
                For Each e As SqlParameter In dbParam
                    cmd.Parameters.Add(e)
                Next
            End If
            cmd.ExecuteNonQuery()
        End Using
    End Sub

    Public Function getData(ByVal queryString As String) As SqlDataReader
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
        Application.EnableVisualStyles()
        Application.SetCompatibleTextRenderingDefault(False)

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

    Public Sub imageLoad(buffer As Byte(), ByRef pic As PictureBox)
        Dim fileName As String = System.IO.Path.GetTempPath() + Guid.NewGuid().ToString() + ".png"
        Using ms As New IO.MemoryStream(buffer)
            Using img As System.Drawing.Image = System.Drawing.Image.FromStream(ms)
                img.Save(fileName)
                pic.Image = Image.FromFile(fileName)
            End Using
        End Using
    End Sub

    Public Function SerialiseFingerPrintTemplate(ByRef template As FingerprintTemplate) As Byte()
        'old way
        'Dim memStream As MemoryStream = New MemoryStream()
        'Dim serializer As New XmlSerializer(GetType(FingerprintTemplate))
        'serializer.Serialize(memStream, template)
        'Dim memData As Byte() = memStream.GetBuffer()
        'memStream.Close()
        Return template.ToByteArray()
    End Function
    Public Function DeserializeFingerPrintTemplate(ByRef data As Byte()) As FingerprintTemplate
        'Dim serializer As New XmlSerializer(GetType(FingerprintTemplate))
        'Dim memStream As MemoryStream = New IO.MemoryStream(data)
        'Dim template As FingerprintTemplate = CType(serializer.Deserialize(memStream), FingerprintTemplate)
        Return New FingerprintTemplate(data)
    End Function

    Public Function excapeSpecialChar(ByVal text As String) As String
        If text.Contains("'") Then
            Return text.Replace("'", "''")
        End If
        Return text
    End Function

    Public Function exportMapping() As String
        Dim retString As String = ""
        For Each item As Mapping In MappingList
            retString += $"{item.ToString()}{vbCrLf}"
        Next
        Return retString
    End Function

    'get the db colum equivalent to the provided file colum
    Public Function getDBFieldMappingByFileField(ByVal file As String) As String
        Dim returnValue As String = ""
        For Each item As Mapping In MappingList
            If file = item.fileFieldName Then
                returnValue = item.dbFieldName
            End If
        Next
        Return returnValue
    End Function

    Public Function getGuid() As String
        Dim myuuid As Guid = Guid.NewGuid()
        Return myuuid.ToString().ToUpper().Replace("-", "")
    End Function
End Module


