Public Class Form_Add

    Dim File_Name As String
    Dim Image_Location As String
    Dim i As Integer = 0




    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Cancel.Click

        Form_Search.Show()
        Me.Close()

    End Sub


    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Finish.Click

        'Trying to save
        Me.Validate()
        Me.TblMoviesBindingSource.EndEdit()
        Me.TableAdapterManager2.UpdateAll(Me.MorgansMoviesDataSet2)
       



        MsgBox(BindingNavigatorPositionItem.Text & " " & TitleTextBox.Text & " " & Year_ReleasedTextBox.Text & " " & DirectorsTextBox.Text & " " & Actor1TextBox.Text & " " & Actor2TextBox.Text & " " & Actor3TextBox.Text & vbNewLine & SummaryRichTextBox.Text)


    End Sub

    Private Sub Form_Add_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'MorgansMoviesDataSet2.tblActors' table. You can move, or remove it, as needed.
        Me.TblActorsTableAdapter.Fill(Me.MorgansMoviesDataSet2.tblActors)
        'TODO: This line of code loads data into the 'MorgansMoviesDataSet2.tblGenres' table. You can move, or remove it, as needed.
        Me.TblGenresTableAdapter1.Fill(Me.MorgansMoviesDataSet2.tblGenres)
        'TODO: This line of code loads data into the 'MorgansMoviesDataSet2.tblMovies' table. You can move, or remove it, as needed.
        Me.TblMoviesTableAdapter1.Fill(Me.MorgansMoviesDataSet2.tblMovies)
        'TODO: This line of code loads data into the 'MorgansMoviesDataSet2.tblMovies' table. You can move, or remove it, as needed.
        Me.TblMoviesTableAdapter.Fill(Me.MorgansMoviesDataSet2.tblMovies)
        'TODO: This line of code loads data into the 'MorgansMoviesDataSet2.tblActors' table. You can move, or remove it, as needed.
        Me.TblActorsTableAdapter.Fill(Me.MorgansMoviesDataSet2.tblActors)
        'TODO: This line of code loads data into the 'MorgansMoviesDataSet1.tblGenres' table. You can move, or remove it, as needed.
        Me.TblGenresTableAdapter.Fill(Me.MorgansMoviesDataSet2.tblGenres)
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

    Private Sub TblMoviesBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.TblMoviesBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.MorgansMoviesDataSet)

    End Sub

    Private Sub BindingNavigatorAddNewItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub TblMoviesBindingNavigatorSaveItem_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TblMoviesBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.TblMoviesBindingSource.EndEdit()
        Me.TableAdapterManager2.UpdateAll(Me.MorgansMoviesDataSet2)

    End Sub

    Private Sub BindingNavigatorAddNewItem_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BindingNavigatorAddNewItem.Click

    End Sub

    Private Sub BindingNavigatorDeleteItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BindingNavigatorDeleteItem.Click

    End Sub
End Class