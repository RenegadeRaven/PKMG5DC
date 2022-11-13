'https://www.codeproject.com/Articles/17161/A-NET-Class-for-Creating-Reading-Editing-INI-Files

Imports System.IO
Imports System.Security
Imports System.Security.Cryptography
Imports System.Text
Public Class IniFile

    Private _strFileName As String
    Private _strIniArgumentsBegins As String = "[Settings]"
    Private _strPrefix As String
    Private _dt As DataTable
    Private _ds As DataSet
    Private _dv As DataView
    Private _dr As DataRow
    Private TmpStringInhaltKomplett As New StringBuilder
    Private StringIniFile As String

    Public Property Filename() As String
        Get
            Return _strFileName
        End Get
        Set(ByVal Value As String)
            _strFileName = Value
        End Set
    End Property
    Public Property Prefix() As String
        Get
            Return _strPrefix
        End Get
        Set(ByVal Value As String)
            _strPrefix = Value
        End Set
    End Property
    Public Sub New()
        _ds = New DataSet
        _dt = New DataTable
        _dv = New DataView

        _dt.Columns.Add("Key")
        _dt.Columns.Add("Value")

        _ds.Tables.Add(_dt)
        _dv.Table = _ds.Tables(0)
    End Sub
    Public Function OpenIniFile() As Boolean
        Try
            Dim tmpStringLine As String
            Dim tmpStringArguments() As String
            Dim tmpBool As Boolean = False
            If Not File.Exists(Filename) Then
                Return False
            End If
            Dim ssr As StreamReader = New StreamReader(Filename)
            _ds = New DataSet
            _dt = New DataTable
            _dv = New DataView
            _dt.Columns.Add("Key")
            _dt.Columns.Add("Value")

            _ds.Tables.Add(_dt)
            _dv.Table = _ds.Tables(0)
            Do
                tmpStringLine = ssr.ReadLine()
                If tmpStringLine Is Nothing Then Exit Do
                If tmpBool Then
                    Try
                        tmpStringArguments = tmpStringLine.Split("=")
                        _dr = _ds.Tables(0).NewRow
                        _dr("Key") = tmpStringArguments(LBound(tmpStringArguments))
                        _dr("Value") = tmpStringArguments(UBound(tmpStringArguments))
                        If _dr("Key") <> "" Then _ds.Tables(0).Rows.Add(_dr)
                    Catch ex As Exception
                    End Try
                End If
                If tmpStringLine.StartsWith(_strIniArgumentsBegins) Then
                    tmpBool = True
                    _strPrefix = TmpStringInhaltKomplett.ToString
                End If
                TmpStringInhaltKomplett.Append(tmpStringLine & Environment.NewLine)
            Loop Until tmpStringLine Is Nothing
            ssr.Close()
            StringIniFile = TmpStringInhaltKomplett.ToString
            Return True
            _ds.AcceptChanges()
        Catch ex As Exception
            Return False
        End Try
    End Function
    Public Function GetValue(ByVal Key As String) As String
        _dv.RowFilter = "Key = '" & Key & "'"
        If _dv.Count > 0 Then
            Return _dv.Item(0).Item("Value")
        Else
            Return "NOTHING"
        End If
    End Function
    Public Function SetValue(ByVal Key As String, ByVal Value As String) As Boolean
        _dv.RowFilter = "Key = '" & Key & "'"
        If _dv.Count > 0 Then
            _dv.Item(0).Item("Value") = Value
        Else
            _dr = _ds.Tables(0).NewRow
            _dr("Key") = Key
            _dr("Value") = Value
            _ds.Tables(0).Rows.Add(_dr)
        End If
        Return Nothing
    End Function
    Public Function SaveIni() As Boolean
        If Not IsNothing(_ds.GetChanges) Then
            'SetValue("_LastSaveOfIniFile", Date.Now.ToLongDateString)
            Try
                _dv.RowFilter = ""
                _dv.Sort = "KEY ASC"
                Dim StringIni As New StringBuilder
                'StringIni.Append(_strPrefix & Environment.NewLine)
                StringIni.Append(_strIniArgumentsBegins & Environment.NewLine)
                Dim i As Integer
                For i = 0 To _dv.Count - 1
                    StringIni.Append(_dv.Item(i).Item("Key") & "=" &
                                     _dv.Item(i).Item("Value") & Environment.NewLine)
                Next
                If File.Exists(_strFileName) Then File.Delete(_strFileName)
                Dim ssw As New StreamWriter(_strFileName)
                ssw.WriteLine(StringIni.ToString)
                ssw.Close()
                _ds.AcceptChanges()
                Return True
            Catch ex As Exception
                Return False
            End Try
        Else
            Return True
        End If
    End Function
End Class
