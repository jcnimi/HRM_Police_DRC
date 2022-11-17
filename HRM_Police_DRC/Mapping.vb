Public Class Mapping
    Public dbFieldName As String
    Public fileFieldName As String

    Public Sub New(ByVal dbField As String, ByVal fileField As String)
        dbFieldName = dbField
        fileFieldName = fileField
    End Sub

    Public Overrides Function ToString() As String
        'Return MyBase.ToString()
        Return $"{dbFieldName},{fileFieldName}"
    End Function
End Class
