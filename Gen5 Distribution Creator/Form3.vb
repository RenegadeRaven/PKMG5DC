Public Class Form3
#Region "Variables"
    Dim pid As String
    Dim dex As String
    Dim item As String
    Dim tid As String
    Dim sid As String
    Dim exp As String
    Dim fsp As String
    Dim abl As String
    Dim mark As String
    Dim lang As String
    Dim ev As String
    Dim moves As String
#End Region
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        OpenFileDialog1.Filter = "Gen 5 PKM Files (*.pk5)|*.pk5|All files (*.*)|*.*"
        OpenFileDialog1.ShowDialog()
        Dim myFile As String = OpenFileDialog1.FileName
        Dim Fn() As String = myFile.Split("\")
        Dim fn2 As String = Fn(UBound(Fn))
        Label2.Text = fn2
        RichTextBox1.Text = RichTextBox1.Text.Remove(8, 408)

        Dim myBytes As Byte() = My.Computer.FileSystem.ReadAllBytes(myFile)
        Dim txtTemp As New System.Text.StringBuilder()
        For Each myByte As Byte In myBytes
            txtTemp.Append(myByte.ToString("X2"))
        Next
        RichTextBox1.Text = RichTextBox1.Text.Insert(8, txtTemp.ToString())
        RichTextBox1.Text = RichTextBox1.Text.Remove(352, 8)
        RichTextBox1.Text = RichTextBox1.Text.Insert(352, "00000000")
    End Sub
End Class