Public Class Playmovie



    Private Sub Playmovie_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        AxWindowsMediaPlayer1.URL = "D:\HDD Files\Movies\Bridesmaids (2011).mp4"
        AxWindowsMediaPlayer1.Ctlcontrols.play()
    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    End Sub
End Class