Public Class Form_Results
    Dim Selected_Movie As String
    Dim Results As New List(Of String)

    Private Sub Btn_Edit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Edit.Click

        MsgBox("Not yet Created")
        Form_Search.Show()
        Me.Close()

    End Sub

    Private Sub Results_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Dim Location As String = "E:\School Work\Software\Major\Morgan's Movies\Morgan's Movies\bin\Debug\Movie Files\Titles\" & Keyword & ".txt"

        If IO.File.Exists("E:\School Work\Software\Major\Morgan's Movies\Morgan's Movies\bin\Debug\Movie Files\Titles\" & Keyword & ".txt") Then

            FileOpen(1, Location, OpenMode.Input)
            Results.Add(LineInput(1))
            FileClose(1)



            Dim Line_Title As String
            Dim Line_Year As String
            Dim Line_Genre As String
            Dim Line_Director As String
            Dim Line_Actor As String
            Dim Line_Summary As String


            'Reads each line of file and assigns them 
            Using Reader As System.IO.StreamReader = New System.IO.StreamReader(Location)
                Line_Title = Reader.ReadLine
                Line_Year = Reader.ReadLine
                Line_Genre = Reader.ReadLine
                Line_Director = Reader.ReadLine
                Line_Actor = Reader.ReadLine
                Line_Summary = Reader.ReadLine
            End Using

            ListBox_Results.Items.Add(Results(0))


            Lbl_Title.Text = Line_Title
            Lbl_Title.Text = Globalization.CultureInfo.CurrentCulture.TextInfo.ToTitleCase(Lbl_Title.Text)
            Lbl_Year.Text = Line_Year
            Lbl_Year.Text = Globalization.CultureInfo.CurrentCulture.TextInfo.ToTitleCase(Lbl_Year.Text)
            Lbl_Genre.Text = Line_Genre
            Lbl_Genre.Text = Globalization.CultureInfo.CurrentCulture.TextInfo.ToTitleCase(Lbl_Genre.Text)
            Lbl_Director.Text = Line_Director
            Lbl_Director.Text = Globalization.CultureInfo.CurrentCulture.TextInfo.ToTitleCase(Lbl_Director.Text)
            Lbl_Actor1.Text = Line_Actor
            Lbl_Actor1.Text = Globalization.CultureInfo.CurrentCulture.TextInfo.ToTitleCase(Lbl_Actor1.Text)
            RichListBox_Summary.Text = Line_Summary
            RichListBox_Summary.Text = Globalization.CultureInfo.CurrentCulture.TextInfo.ToTitleCase(RichListBox_Summary.Text)

        End If
        Pic_MoviePoster.Hide()
        Lbl_Title.Hide()
        Lbl_Actor2.Hide()
        Lbl_Actor1.Hide()
        Lbl_Genre.Hide()
        Lbl_Director.Hide()
        Lbl_Year.Hide()
        RichListBox_Summary.Hide()

    End Sub

    Private Sub Btn_Watch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Watch.Click

        Form_PlayMovie.Show()

    End Sub

    Private Sub Btn_Back_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Back.Click

        Form_Search.Show()
        Me.Close()

    End Sub

    Private Sub ListBox_Results_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListBox_Results.SelectedIndexChanged

        'This is where the Selected movie information is shown

        SelectedMovie = ListBox_Results.SelectedItem.ToString
        Pic_MoviePoster.Load("E:\School Work\Software\Major\Morgan's Movies\Morgan's Movies\bin\Debug\Movie Files\Image Files\" & ListBox_Results.SelectedItem.ToString & ".jpg")

        Lbl_Title.Show()
        Lbl_Year.Show()
        Lbl_Genre.Show()
        Lbl_Director.Show()
        Lbl_Actor1.Show()
        RichListBox_Summary.Show()
        Pic_MoviePoster.Show()

    End Sub
End Class