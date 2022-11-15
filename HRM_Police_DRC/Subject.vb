Imports SourceAFIS

Public Class Subject
    Public Id As String
    Public Name As String
    Public Matric As String
    Public Template As FingerprintTemplate
    Public TemplateR As FingerprintTemplate

    Public Sub New(ByVal _id As String, ByVal _name As String, ByVal _matric As String, ByRef _templ As FingerprintTemplate, Optional ByRef _templR As FingerprintTemplate = Nothing)
        Id = _id
        Name = _name
        Matric = _matric
        Template = _templ
        TemplateR = _templR
    End Sub
End Class
