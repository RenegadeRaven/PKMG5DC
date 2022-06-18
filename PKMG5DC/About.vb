Public Class About
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Me.Close()
    End Sub
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()
    End Sub
    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lklb_Ndstool.LinkClicked
        Process.Start("https://gbatemp.net/download/nintendo-ds-rom-tool-ndstool.29352/")
    End Sub
    Private Sub LinkLabel2_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lklb_armips.LinkClicked
        Process.Start("http://aerie.wingdreams.net/?page_id=6")
    End Sub
    Private Sub LinkLabel3_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lklb_12distro.LinkClicked
        Process.Start("https://gbatemp.net/threads/pokemon-duodecuple-distribution-hack.285080/")
    End Sub
    Private Sub LinkLabel4_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lklb_Source.LinkClicked
        Process.Start("https://github.com/PlasticJustice/PKMG5DC")
    End Sub
    Private Sub LinkLabel5_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lklb_SourceCHS.LinkClicked
        Process.Start("https://github.com/Wokann/PKMG5DC_CHS")
    End Sub
End Class