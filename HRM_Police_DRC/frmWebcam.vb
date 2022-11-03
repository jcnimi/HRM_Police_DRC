Imports Emgu.CV
Imports Emgu.CV.Structure
Public Class frmWebcam

    Dim vcapture As VideoCapture
    Dim img As Image(Of Bgr, Byte)

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnStart.Click
        Timer1.Enabled = True
        vcapture = New VideoCapture(0)
        img = vcapture.QueryFrame().ToImage(Of Bgr, Byte)
        PictureBox1.Image = img.ToBitmap()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles btnStop.Click
        Timer1.Enabled = False
        vcapture.Dispose()
    End Sub

    Private Sub timer1_tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        img = vcapture.QueryFrame().ToImage(Of Bgr, Byte)
        PictureBox1.Image = img.ToBitmap()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim path As String
        With SaveFileDialog1
            .Filter = "PNG Image (.png) | *.png"
            .Title = "Enregistrer l'image"
            .ShowDialog()
        End With
        path = SaveFileDialog1.FileName
        If path <> "" Then
            PictureBox1.Image.Save(path, Imaging.ImageFormat.Png)
        End If

    End Sub
End Class