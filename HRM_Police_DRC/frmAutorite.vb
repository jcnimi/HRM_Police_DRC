Imports System.Runtime.Intrinsics

Public Class frmAutorite
    Private isUpdate As Boolean = False
    Private selectedRow As DataGridViewRow
    Private id As String

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub btnsave_Click(sender As Object, e As EventArgs) Handles btnsave.Click
        Me.Cursor = Cursors.WaitCursor
        Try
            Dim queryInsert As String = $"
            INSERT INTO [autorite]
               ([nom]
               ,[signature]
               ,[date_creation]
               ,[date_fin_activite]
               ,[cree_par]
               ,[status])
            VALUES
               ('{txtNom.Text}'
               ,@signature
               ,SYSDATETIME()
               ,NULL
               ,{userId}
               ,'Actif')
            "
            Dim queryUpdate As String = $"
            UPDATE [autorite]
            SET [nom] = '{txtNom.Text}'
            ,[signature] = @signature
            ,[status] = '{cboStatus.Text}'
            {If(cboStatus.Text = "Actif", ",date_fin_activite=NULL", "")}
            WHERE id_autorite = {id}
            "
            Dim queryChangeAutorite As String = $"
            update autorite 
            set status = 'Inactif',
            [date_fin_activite] = SYSDATETIME()
            where status = 'Actif'
            "

            Dim im1 As Image
            Dim ms As System.IO.MemoryStream
            Dim md As Byte()
            Dim param As SqlParameter
            Dim listParams As New Generic.List(Of SqlParameter)

            'add signature
            If picSignature.Image IsNot Nothing Then
                im1 = picSignature.Image
                ms = New System.IO.MemoryStream
                im1.Save(ms, System.Drawing.Imaging.ImageFormat.Bmp)
                md = ms.GetBuffer
                param = New SqlParameter("@signature", SqlDbType.Image)
                param.Value = md
                listParams.Add(param)
            Else
                param = New SqlParameter("@signature", SqlDbType.Image)
                param.Value = System.DBNull.Value
                listParams.Add(param)
            End If

            'Run queries

            'add of update
            If isUpdate = True Then
                If cboStatus.Text = "Actif" Then
                    'update any actif to inactif
                    saveData(queryChangeAutorite)
                End If
                saveData(queryUpdate, listParams)
            Else
                'update any actif to inactif
                saveData(queryChangeAutorite)
                saveData(queryInsert, listParams)
            End If
            loadDataGridView()
            Me.Cursor = Cursors.Default
            MessageBox.Show("Autorité enregistré avec succes")
        Catch ex As Exception
            MessageBox.Show("Erreur : " + ex.Message)
        End Try
    End Sub

    Private Sub btnNew_Click(sender As Object, e As EventArgs) Handles btnNew.Click
        isUpdate = False
        cboStatus.Enabled = False
        cboStatus.Text = "Actif"
        picSignature.Image = Nothing
        txtNom.Text = ""
        cboStatus.Text = ""
        dtpCreateDate.ResetText()
    End Sub

    Private Sub btnScanner_Click(sender As Object, e As EventArgs) Handles btnScanner.Click
        Me.Cursor = Cursors.WaitCursor
        Dim MyComputer = New Microsoft.VisualBasic.Devices.Computer
        Dim grabpicture As System.Drawing.Image
        grabpicture = MyComputer.Clipboard.GetImage()
        picSignature.Image = grabpicture
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub btnImporter_Click(sender As Object, e As EventArgs) Handles btnImporter.Click
        Me.Cursor = Cursors.WaitCursor
        With OpenFileDialog1
            .Filter = "Bitmap Image (.bmp)|*.bmp|Gif Image (.gif)|*.gif|JPEG Image|*.jpeg;*.jpg|Png Image (.png)|*.png|All(*.*)|*.*"
            .Title = "Ouvrir une image"
            If .ShowDialog = Windows.Forms.DialogResult.OK Then
                picSignature.Image = New Bitmap(OpenFileDialog1.FileName)
            End If
        End With
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub frmAutorite_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'load data from db
        loadDataGridView()
        If isUpdate = False Then
            cboStatus.Enabled = False
            cboStatus.Text = "Actif"
        End If
    End Sub

    Private Sub loadDataGridView()
        'load datagridview from db
        Try
            Dim queryString As String = "
            SELECT [id_autorite]
                  ,[nom]
                  ,[date_creation]
                  ,[date_fin_activite]
                  ,[status]
              FROM [dbo].[autorite]
            "
            Dim cmd As New SqlCommand(queryString, conn)
            Dim adapter As New SqlDataAdapter(cmd)
            Dim table As New DataTable
            adapter.Fill(table)
            DataGridView1.DataSource = table
        Catch ex As Exception
            MessageBox.Show("Erreur : " + ex.Message)
        End Try
    End Sub

    Private Sub DataGridView1_CellMouseDoubleClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DataGridView1.CellMouseDoubleClick
        Me.Cursor = Cursors.WaitCursor
        If e.RowIndex >= 0 And selectedRow IsNot Nothing Then
            isUpdate = True
            cboStatus.Enabled = True
            id = selectedRow.Cells("id_autorite").Value
            txtNom.Text = selectedRow.Cells("nom").Value
            cboStatus.Text = selectedRow.Cells("status").Value

            Dim dateCreation As String = selectedRow.Cells("date_creation").Value
            If IsDate(dateCreation) Then
                dtpCreateDate.Value = dateCreation
            End If
            'load the signature from the db
            Dim query As String = $"
                select signature from autorite where id_autorite = {id}
            "
            Try
                Using reader As SqlDataReader = getData(query)
                    If reader.HasRows Then
                        reader.Read()
                        If Not reader.IsDBNull("signature") Then
                            imageLoad(CType(reader("signature"), Byte()), picSignature)
                        End If
                    End If
                End Using
            Catch ex As Exception
                MessageBox.Show("Erreur : " + ex.Message)
            End Try
        End If
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub DataGridView1_SelectionChanged(sender As Object, e As EventArgs) Handles DataGridView1.SelectionChanged
        If DataGridView1.SelectedRows.Count > 0 Then
            selectedRow = DataGridView1.SelectedRows.Item(0)
        End If
    End Sub
End Class