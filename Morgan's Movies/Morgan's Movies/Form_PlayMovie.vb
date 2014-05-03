Public Class Form_PlayMovie

    Dim Format As String

    Private Sub Form_PlayMovie_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load


        'Checks the file type of the movie 
        If System.IO.File.Exists("E:\Movies\" & SelectedMovie.ToLower & ".avi") Then

            Format = ".avi"

        ElseIf System.IO.File.Exists("E:\Movies\" & SelectedMovie.ToLower & ".mp4") Then

            Format = ".mp4"

        ElseIf System.IO.File.Exists("E:\Movies\" & SelectedMovie.ToLower & ".mkv") Then

            Format = ".mkv"

        Else

            MsgBox("File Does Not Exist")
            Form_Results.Show()
            Me.Close()

        End If

        'Plays the movie 
        AxWindowsMediaPlayer1.URL = "E:\Movies\" & SelectedMovie & Format
        AxWindowsMediaPlayer1.Ctlcontrols.play()

    End Sub
End Class