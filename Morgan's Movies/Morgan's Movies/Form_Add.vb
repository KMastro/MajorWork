Public Class Form_Add

    Dim File_Name As String
    Dim Image_Location As String
    Dim i As Integer = 0




    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Cancel.Click

        Form_Search.Show()
        Me.Close()

    End Sub


    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Finish.Click

        Add_Year = TxtBox_Year.Text
        Add_Genre = TxtBox_Genre.Text
        Add_Director = TxtBox_Director.Text
        Add_Actor1 = TxtBox_Actor1.Text
        Add_Actor2 = TxtBox_Actor2.Text
        Add_Actor3 = TxtBox_Actor3.Text





        'Keeps count of correct fields
        Dim _EntryCount As Integer = 0



        'All this just checks to make sure the user has added something into the text boxes

        If TxtBox_Title.Text = "" Or TxtBox_Title.Text.ToLower = "enter title" Then
            TxtBox_Title.Text = "Enter Title"
            _EntryCount -= 1
        Else
            _EntryCount += 1
        End If

        If TxtBox_Year.Text = "" Or TxtBox_Year.Text.ToLower = "enter year" Then
            TxtBox_Year.Text = "Enter Year"
            _EntryCount -= 1
        Else
            _EntryCount += 1
        End If

        If TxtBox_Genre.Text = "" Or TxtBox_Genre.Text.ToLower = "enter genre" Then
            TxtBox_Genre.Text = "Enter Genre"
            _EntryCount -= 1
        Else
            _EntryCount += 1
        End If

        If TxtBox_Director.Text = "" Or TxtBox_Director.Text.ToLower = "enter director" Then
            TxtBox_Director.Text = "Enter Director"
            _EntryCount -= 1
        Else
            _EntryCount += 1
        End If

        If TxtBox_Actor1.Text = "" Or TxtBox_Actor1.Text.ToLower = "enter actor" Then
            TxtBox_Actor1.Text = "Enter Actor"
            _EntryCount -= 1
        Else
            _EntryCount += 1
        End If

        If TxtBox_Actor2.Text = "" Or TxtBox_Actor2.Text.ToLower = "enter actor" Then
            TxtBox_Actor2.Text = "Enter Actor"
            _EntryCount -= 1
        Else
            _EntryCount += 1
        End If

        If TxtBox_Actor3.Text = "" Or TxtBox_Actor3.Text.ToLower = "enter actor" Then
            TxtBox_Actor3.Text = "Enter Actor"
            _EntryCount -= 1
        Else
            _EntryCount += 1
        End If

        If RichTxt_Summary.Text = "" Or RichTxt_Summary.Text.ToLower = "enter movie summary" Then
            RichTxt_Summary.Text = "Enter Movie Summary"
            _EntryCount -= 1
        Else
            _EntryCount += 1
        End If





        'If all areas are filled out then the user can continue 
        If _EntryCount = 8 And i = 1 Then











            '
            Dim Year_Location As String = ("E:\School Work\Software\Major\Morgan's Movies\Morgan's Movies\bin\Debug\Movie Files\Year\" & Add_Year.ToLower & ".txt")

            Dim Genre_Location As String = ("E:\School Work\Software\Major\Morgan's Movies\Morgan's Movies\bin\Debug\Movie Files\Genre\" & Add_Genre.ToLower & ".txt")

            Dim Director_Location As String = ("E:\School Work\Software\Major\Morgan's Movies\Morgan's Movies\bin\Debug\Movie Files\Director\" & Add_Director.ToLower & ".txt")

            Dim Actor1_Location As String = ("E:\School Work\Software\Major\Morgan's Movies\Morgan's Movies\bin\Debug\Movie Files\Actors\" & Add_Actor1.ToLower & ".txt")

            Dim Actor2_Location As String = ("E:\School Work\Software\Major\Morgan's Movies\Morgan's Movies\bin\Debug\Movie Files\Actors\" & Add_Actor2.ToLower & ".txt")

            Dim Actor3_Location As String = ("E:\School Work\Software\Major\Morgan's Movies\Morgan's Movies\bin\Debug\Movie Files\Actors\" & Add_Actor3.ToLower & ".txt")

            'Writes the title of the newly added movie to each txt file 
            FileOpen(1, Year_Location, OpenMode.Append)
            PrintLine(1, TxtBox_Title.Text.ToLower)
            FileClose(1)

            FileOpen(2, Genre_Location, OpenMode.Append)
            PrintLine(2, TxtBox_Title.Text.ToLower)
            FileClose(2)

            FileOpen(3, Director_Location, OpenMode.Append)
            PrintLine(3, TxtBox_Title.Text.ToLower)
            FileClose(3)

            FileOpen(4, Actor1_Location, OpenMode.Append)
            PrintLine(4, TxtBox_Title.Text.ToLower)
            FileClose(4)

            FileOpen(5, Actor2_Location, OpenMode.Append)
            PrintLine(5, TxtBox_Title.Text.ToLower)
            FileClose(5)

            FileOpen(6, Actor3_Location, OpenMode.Append)
            PrintLine(6, TxtBox_Title.Text.ToLower)
            FileClose(6)


            'This was how i was going to do it 
            '    Dim YearWriter As New System.IO.StreamWriter(Year_Location)
            '    If System.IO.File.Exists(Year_Location) = True Then
            '        YearWriter.WriteLine(TxtBox_Title.Text.ToLower)
            '        YearWriter.Close()

            '        Dim GenreWriter As New System.IO.StreamWriter(Genre_Location)
            '        If System.IO.File.Exists(Genre_Location) = True Then
            '            GenreWriter.WriteLine(TxtBox_Title.Text.ToLower)
            '            GenreWriter.Close()

            '            Dim DirectorWriter As New System.IO.StreamWriter(Year_Location)
            '            If System.IO.File.Exists(Director_Location) = True Then
            '                DirectorWriter.WriteLine(TxtBox_Title.Text.ToLower)
            '                DirectorWriter.Close()


            '            End If
            '        End If
            '    End If
            '    MsgBox("Failed to add")
            'End If






            'Locations of where the information file is to go
            File_Name = ("E:\School Work\Software\Major\Morgan's Movies\Morgan's Movies\bin\Debug\Movie Files\Titles\" & TxtBox_Title.Text.ToLower & ".txt")
            Image_Location = ("E:\School Work\Software\Major\Morgan's Movies\Morgan's Movies\bin\Debug\Movie Files\Image Files\" & TxtBox_Title.Text.ToLower & ".jpg")


            Dim FileWriter As New System.IO.StreamWriter(File_Name)



            If System.IO.File.Exists(File_Name) = True Then

                'Saves picture to the desired folder for later access
                Pic_MoviePoster.Image.Save(Image_Location, System.Drawing.Imaging.ImageFormat.Jpeg)


                ''Writes all information to a txt file
                'FileWriter.WriteLine(TxtBox_Title.Text.ToLower)
                'FileWriter.WriteLine(TxtBox_Year.Text.ToLower)
                'FileWriter.WriteLine(TxtBox_Genre.Text.ToLower)
                'FileWriter.WriteLine(TxtBox_Director.Text.ToLower)
                'FileWriter.WriteLine(TxtBox_Actor1.Text.ToLower & "." & TxtBox_Actor2.Text.ToLower & "." & TxtBox_Actor3.Text.ToLower)
                'FileWriter.WriteLine(RichTxt_Summary.Text.ToLower)
                'FileWriter.WriteLine(Image_Location)
                'FileWriter.Close()

                'Lets user know that they have successfully added
                MsgBox("Successfully Added")

            Else
                MsgBox("Failed to add")
            End If

            Form_Search.Show()
            Me.Close()

        End If

    End Sub

    Private Sub Form_Add_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'MorgansMoviesDataSet.tblMovies' table. You can move, or remove it, as needed.
        Me.TblMoviesTableAdapter.Fill(Me.MorgansMoviesDataSet.tblMovies)

        'loads the initial image that instructs the user to Drag & Drop an image
        Pic_MoviePoster.Load("E:\School Work\Software\Major\Morgan's Movies\Morgan's Movies\bin\Debug\Movie Files\Image Files\DragNDrop.jpg")

        'Allows the user to Drag & Drop
        Pic_MoviePoster.AllowDrop = True

    End Sub

    Private Sub pb_DragDrop(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles Pic_MoviePoster.DragDrop

        Try

            Pic_MoviePoster.Image = Image.FromFile(CType(e.Data.GetData(DataFormats.FileDrop), Array).GetValue(0).ToString)

            'Makes sure the user has dropped in an image, if they haven't they cannot continue
            i += 1

        Catch ex As Exception

            MessageBox.Show("Error occured, please try again")

        End Try

    End Sub


    Private Sub pb_DragEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles Pic_MoviePoster.DragEnter

        'Gets the data of the dropped image
        If (e.Data.GetDataPresent(DataFormats.FileDrop)) Then

            e.Effect = DragDropEffects.Copy

        End If

    End Sub

    Private Sub TblMoviesBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TblMoviesBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.TblMoviesBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.MorgansMoviesDataSet)

    End Sub
End Class