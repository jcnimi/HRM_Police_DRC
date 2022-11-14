Imports SourceAFIS
Imports SourceAFIS.Engine
Imports System.Drawing
Public Class ImageMatcher
    Public Function loadCandidates() As List(Of Subject)
        Dim _Candidates As List(Of Subject) = New List(Of Subject)()
        Dim query As String = "
          SELECT [id_agent]
          ,[matricule]
          ,[nom] + ' ' + [postnom] + ' ' + [prenom] as nom
          ,[empreinte_gauche_template]
          FROM [hrm_police].[dbo].[agent]
          where empreinte_gauche_template is not null
        "
        Using queryresults As SqlDataReader = getData(query)
            While queryresults.Read()
                Dim id As String = queryresults("id_agent")
                Dim name As String = queryresults("nom")
                Dim matric As String = queryresults("matricule")
                Dim serialFingerPrintTempl As Byte() = queryresults("empreinte_gauche_template")
                Dim templ As FingerprintTemplate = New FingerprintTemplate(serialFingerPrintTempl)
                Dim candidate As Subject
                candidate = New Subject(id, name, matric, templ)
                _Candidates.Add(candidate)
            End While
        End Using
        Return _Candidates
    End Function

    Public Function encodeFingerPrintImage(ByRef img As Image) As SourceAFIS.FingerprintImage
        Dim converter As New ImageConverter
        Dim bytArray As Byte() = converter.ConvertTo(img, GetType(Byte()))
        Dim decoded = New FingerprintImage(bytArray)
        Return decoded
    End Function

    Public Function getTemplate(ByRef fingerImg As FingerprintImage) As FingerprintTemplate
        Return New FingerprintTemplate(fingerImg)
    End Function

    Public Function matchFingerPrints(ByRef img1 As Image, ByRef img2 As Image) As Double
        Dim probe = getTemplate(encodeFingerPrintImage(img1))
        Dim candidate = getTemplate(encodeFingerPrintImage(img2))
        Dim matcher = New FingerprintMatcher(probe)
        Dim similarity As Double = matcher.Match(candidate)
        Return similarity
    End Function

    Public Function Identify(ByRef probe As FingerprintTemplate, ByRef Candidates As List(Of Subject)) As Subject
        Dim matcher = New FingerprintMatcher(probe)
        Dim match As Subject = Nothing
        Dim max As Double = Double.NegativeInfinity
        For Each candidate In Candidates
            Dim similarity As Double = matcher.Match(candidate.Template)
            If similarity > max Then
                max = similarity
                match = candidate
            End If
        Next
        Dim threshold As Double = 40
        Return If((max >= threshold), match, Nothing)
    End Function
End Class
