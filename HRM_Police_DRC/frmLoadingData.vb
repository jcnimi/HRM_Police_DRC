Imports Newtonsoft.Json.Linq

Public Class frmLoadingData
    Private Sub frmLoadingData_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ProgressBar1.Minimum = 0
        ProgressBar1.Maximum = 100
        Timer1.Interval = 500
        Timer1.Enabled = True

        'loading list of candidates
        Dim matcherObj As ImageMatcher = New ImageMatcher()
        Candidates = matcherObj.loadCandidates()
        Application.DoEvents()

        'loading data in the village dataset
        Dim queryString As String = "Select 0 value, 'Select' display 
                                union  
                                SELECT id_village as value, description as display 
                                FROM [dbo].village
                                "
        Dim adapter As New SqlDataAdapter()
        dsVillage = New DataSet()
        Try
            Using cmd As New SqlCommand(queryString, conn)
                adapter.SelectCommand = cmd
                adapter.Fill(dsVillage)
                adapter.Dispose()
            End Using
        Catch ex As Exception
            MessageBox.Show("Error: " + ex.Message)
        End Try
        Application.DoEvents()

        Timer1.Enabled = False
        Me.Close()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Dim value As Integer = 0
        For i As Integer = 0 To 100 Step 10
            ProgressBar1.Value = value
            value += 10
        Next
    End Sub
End Class