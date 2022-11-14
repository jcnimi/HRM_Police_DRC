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