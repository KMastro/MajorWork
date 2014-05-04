Public Class Form_Results
    Dim Selected_Movie As String
    Dim Results As New List(Of String)

    Private Sub Btn_Edit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Edit.Click

        MsgBox("Not yet Created")
        Form_Search.Show()
        Me.Close()

    End Sub

    Private Sub Results_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load



        'This is the "Show All" function
        If Keyword = "" Then

            'Gets directory folder
            Dim Txtfiles As String() = System.IO.Directory.GetFiles("E:\School Work\Software\Major\Morgan's Movies\Morgan's Movies\bin\Debug\Movie Files\Titles")

            'Displays the name of each file in results box
            Dim file As String
            For Each file In Txtfiles
                FileOpen(1, file, OpenMode.Input)
                ListBox_Results.Items.Add(LineInput(1))
                FileClose(1)
            Next

        End If

        'Checks search catagory so it knows where to search for the right results
        'TITLE SEARCH

        If SearchCatagory = "Title" Then
            If IO.File.Exists("E:\School Work\Software\Major\Morgan's Movies\Morgan's Movies\bin\Debug\Movie Files\Titles\" & Keyword & ".txt") Then
                Dim location As String = "E:\School Work\Software\Major\Morgan's Movies\Morgan's Movies\bin\Debug\Movie Files\Titles\" & Keyword & ".txt"
                FileOpen(1, location, OpenMode.Input)
                Results.Add(LineInput(1))
                FileClose(1)
                'Adds the result to the listbox
                ListBox_Results.Items.Add(Results(0))
            End If
        End If

        'This is what happens when you select to search by genre
        'GENRE SEARCH
        If SearchCatagory = "Genre" Then
            If IO.File.Exists("E:\School Work\Software\Major\Morgan's Movies\Morgan's Movies\bin\Debug\Movie Files\Genre\" & Keyword & ".txt") Then
                Dim location As String = "E:\School Work\Software\Major\Morgan's Movies\Morgan's Movies\bin\Debug\Movie Files\Genre\" & Keyword & ".txt"

                'Gets the number of lines in the txt file
                Dim Lines = IO.File.ReadAllLines(location).Length
                Dim i As Integer = 0


                Dim reader As System.IO.StreamReader = New System.IO.StreamReader(location)

                'Adds each line to from txt file and places them into listbox
                Do

                    Results.Add(reader.ReadLine)

                    'Adds the result to the listbox
                    ListBox_Results.Items.Add(Results(i).ToString)
                    i += 1

                Loop Until i = Lines
            End If
        End If




        'This is what happens when you select to search by Director
        'DIRECTOR SEARCH
        If SearchCatagory = "Director" Then
            If IO.File.Exists("E:\School Work\Software\Major\Morgan's Movies\Morgan's Movies\bin\Debug\Movie Files\Director\" & Keyword & ".txt") Then
                Dim location As String = "E:\School Work\Software\Major\Morgan's Movies\Morgan's Movies\bin\Debug\Movie Files\Director\" & Keyword & ".txt"

                'Gets the number of lines in the txt file
                Dim Lines = IO.File.ReadAllLines(location).Length
                Dim i As Integer = 0


                Dim reader As System.IO.StreamReader = New System.IO.StreamReader(location)

                'Adds each line to from txt file and places them into listbox
                Do

                    Results.Add(reader.ReadLine)

                    'Adds the result to the listbox
                    ListBox_Results.Items.Add(Results(i).ToString)
                    i += 1

                Loop Until i = Lines
            End If
        End If


















        If SearchCatagory = "Actor" Then
            If IO.File.Exists("E:\School Work\Software\Major\Morgan's Movies\Morgan's Movies\bin\Debug\Movie Files\Actors\" & Keyword & ".txt") Then
                Dim location As String = "E:\School Work\Software\Major\Morgan's Movies\Morgan's Movies\bin\Debug\Movie Files\Actors\" & Keyword & ".txt"

                'Gets the number of lines in the txt file
                Dim Lines = IO.File.ReadAllLines(location).Length
                Dim i As Integer = 0


                Dim reader As System.IO.StreamReader = New System.IO.StreamReader(location)

                'Adds each line to from txt file and places them into listbox
                Do

                    Results.Add(reader.ReadLine)

                    'Adds the result to the listbox
                    ListBox_Results.Items.Add(Results(i).ToString)
                    i += 1

                Loop Until i = Lines
            End If
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

        Dim Location As String = ("E:\School Work\Software\Major\Morgan's Movies\Morgan's Movies\bin\Debug\Movie Files\Titles\" & ListBox_Results.SelectedItem.ToString & ".txt")
        Pic_MoviePoster.Load("E:\School Work\Software\Major\Morgan's Movies\Morgan's Movies\bin\Debug\Movie Files\Image Files\" & ListBox_Results.SelectedItem.ToString & ".jpg")



        Dim Line_Title As String
        Dim Line_Year As String
        Dim Line_Genre As String
        Dim Line_Director As String
        Dim Line_Actor As String
        Dim Line_Summary As String


        'Reads each line of file and assigns them into a string
        Using Reader As System.IO.StreamReader = New System.IO.StreamReader(Location)
            Line_Title = Reader.ReadLine
            Line_Year = Reader.ReadLine
            Line_Genre = Reader.ReadLine
            Line_Director = Reader.ReadLine
            Line_Actor = Reader.ReadLine
            Line_Summary = Reader.ReadLine
        End Using

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




        Lbl_Title.Show()
        Lbl_Year.Show()
        Lbl_Genre.Show()
        Lbl_Director.Show()
        Lbl_Actor1.Show()
        RichListBox_Summary.Show()
        Pic_MoviePoster.Show()

    End Sub
End Class