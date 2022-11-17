Imports Microsoft.Office.Interop
Imports Microsoft.Office
Imports System.Runtime.InteropServices
Public Class frmRapports
    Dim dtFrom As String = ""
    Dim dtTo As String = ""
    Private Sub Filter()
        Try
            Dim cmd As SqlCommand = conn.CreateCommand()
            With cmd
                .CommandType = CommandType.StoredProcedure
                .CommandText = "sp_FilterPrintingHistory"
                With .Parameters
                    .Add(New SqlParameter("creation_date_from", dtFrom))
                    .Add(New SqlParameter("creation_date_to", dtTo))
                    .Add(New SqlParameter("criterion_personal", cmbCriterion.Text))
                    If cmbCriterion.Text = "Matricule" Then
                        .Add(New SqlParameter("criterion_personal_value", cmbValue.Text))
                    Else
                        .Add(New SqlParameter("criterion_personal_value", cmbValue.Text))
                    End If

                End With
            End With
            Dim adapter As New SqlDataAdapter(cmd)
            Dim table As New System.Data.DataTable
            adapter.Fill(table)
            DataGridView1.DataSource = table
            btnExporter.Enabled = True
        Catch ex As Exception
            MessageBox.Show("Erreur: " + ex.Message)
        End Try
    End Sub
    Private Sub cmbCriterionPeronel_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboFormatValeur.SelectedIndexChanged
        If cboFormatValeur.Text = "CSV" Then
            lblSep.Enabled = True
            cboFormatSeparateur.Enabled = True
        Else
            lblSep.Enabled = False
            cboFormatSeparateur.Enabled = False
        End If
    End Sub

    Private Sub btnExporter_Click(sender As Object, e As EventArgs) Handles btnFiltrer.Click
        Filter()
    End Sub

    Private Sub cmbCriterionLocation_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbCriterion.SelectedIndexChanged
        Dim query As String = ""
        'load values accprdingly
        If cmbCriterion.Text = "Grade" Then
            query = "Select 0 value, 'Select' display union  SELECT id_grade as value, description as display FROM [dbo].grade"
        ElseIf cmbCriterion.Text = "Fonction" Then
            query = "Select 0 value, 'Select' display union  SELECT id_fonction as value, description as display FROM [dbo].fonction"
        Else
            query = ""
            cmbValue.DataSource = Nothing
        End If
        If query <> "" Then
            loadComboBox(cmbValue, query)
        End If
    End Sub

    Private Sub btnAnnuler_Click(sender As Object, e As EventArgs) Handles btnAnnuler.Click
        Me.Close()
    End Sub

    Private Sub btnExporter_Click_1(sender As Object, e As EventArgs) Handles btnExporter.Click
        Dim exportFormat As String = cboFormatValeur.Text
        Me.Cursor = Cursors.WaitCursor
        Try
            If exportFormat = "Excel" Then
                exportExcel()
            ElseIf exportFormat = "CSV" Then
                Dim sep As String = cboFormatSeparateur.Text
                MessageBox.Show("Pas encore implementé")
                'exportCSV(sep)
            Else
                MessageBox.Show("Veuillez selectionner Excel ou CSV")
            End If
        Catch ex As Exception
            MessageBox.Show("Erreur d'exportation: " + ex.Message)
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub

    Private Sub exportExcel()
        Dim xlapp As Excel.Application
        Dim xlWorkBook As Excel.Workbook
        Dim xlWorkSheet As Excel.Worksheet
        Dim misValue As Object = System.Reflection.Missing.Value
        Dim i As Integer
        Dim j As Integer

        xlapp = New Excel.Application
        xlWorkBook = xlapp.Workbooks.Add(misValue)
        xlWorkSheet = CType(xlWorkBook.Sheets("Sheet1"), Excel.Worksheet)

        For k = 0 To DataGridView1.ColumnCount - 1
            'xlWorkSheet.Cells(1, k + 1).HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter
            xlWorkSheet.Cells(1, k + 1) = DataGridView1.Columns(k).Name
        Next
        For i = 0 To DataGridView1.RowCount - 2
            For j = 0 To DataGridView1.ColumnCount - 1
                'xlWorkSheet.Cells(i + 2, j + 1).HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter
                xlWorkSheet.Cells(i + 2, j + 1) = DataGridView1(j, i).Value.ToString()
            Next
        Next

        Dim SaveFileDialog1 As New SaveFileDialog()
        SaveFileDialog1.Filter = "Fichier Excel (*.xlsx)|*.xlsx"
        SaveFileDialog1.FilterIndex = 2
        SaveFileDialog1.RestoreDirectory = True
        If SaveFileDialog1.ShowDialog() = DialogResult.OK Then
            xlWorkSheet.SaveAs(SaveFileDialog1.FileName)
            MsgBox("Exportation effectué avec succes")
        Else
            Return
        End If
        xlWorkBook.Close()
        xlapp.Quit()
    End Sub

    Private Sub exportCSV(ByVal sep As String)
        Dim xlapp As Excel.Application
        Dim xlWorkBook As Excel.Workbook
        Dim xlWorkSheet As Excel.Worksheet
        Dim misValue As Object = System.Reflection.Missing.Value
        Dim i As Integer
        Dim j As Integer

        Dim fileName As String = System.IO.Path.GetTempPath() + Guid.NewGuid().ToString() + ".png"

        Dim configFile As String = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location) + "\" + "settings.json"
        Dim fileReader As New System.IO.StreamReader(configFile)


        xlapp = New Excel.Application
        xlWorkBook = xlapp.Workbooks.Add(misValue)
        xlWorkSheet = CType(xlWorkBook.Sheets("Sheet1"), Excel.Worksheet)


        For k = 0 To DataGridView1.ColumnCount - 1
            'xlWorkSheet.Cells(1, k + 1).HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter
            xlWorkSheet.Cells(1, k + 1) = DataGridView1.Columns(k).Name
        Next
        For i = 0 To DataGridView1.RowCount - 2
            For j = 0 To DataGridView1.ColumnCount - 1
                'xlWorkSheet.Cells(i + 2, j + 1).HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter
                xlWorkSheet.Cells(i + 2, j + 1) = DataGridView1(j, i).Value.ToString()
            Next
        Next

        Dim SaveFileDialog1 As New SaveFileDialog()
        SaveFileDialog1.Filter = "Fichier Excel (*.xlsx)|*.xlsx"
        SaveFileDialog1.FilterIndex = 2
        SaveFileDialog1.RestoreDirectory = True
        If SaveFileDialog1.ShowDialog() = DialogResult.OK Then

            MsgBox("Exportation effectué avec succes")
        Else
            Return
        End If
        xlWorkBook.Close()
        xlapp.Quit()
    End Sub

    Private Sub dtpFrom_ValueChanged(sender As Object, e As EventArgs) Handles dtpFrom.ValueChanged
        dtFrom = dtpFrom.Value
    End Sub

    Private Sub dtpTo_ValueChanged(sender As Object, e As EventArgs) Handles dtpTo.ValueChanged
        dtTo = dtpTo.Value
    End Sub
End Class