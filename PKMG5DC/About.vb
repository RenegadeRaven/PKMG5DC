Public Class About
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lb_AppVersion.Text = Application.ProductVersion
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
End Class