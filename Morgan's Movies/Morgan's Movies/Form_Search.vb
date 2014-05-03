Public Class Form_Search

    Private Sub Form_Search_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Add.Click

        Form_Add.Show()
        Me.Close()

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_ShowAll.Click
        Keyword = ""
        Form_Results.Show()
        Me.Close()

    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_RecentlyAdded.Click

        Form_Results.Show()
        Me.Close()

    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Search.Click

        'Ensures there is something written in the keyword text box and a catagory is selected
        If Txtbox_Keyword.Text <> "" And Txtbox_Keyword.Text <> "Please Select A Catagory" Then
            Keyword = Txtbox_Keyword.Text.ToLower
            Form_Results.Show()
            Me.Close()
        Else
            Txtbox_Keyword.Text = "Please Select A Catagory"
        End If


    End Sub

    'Saves the users search catagory
    Private Sub RB_Title_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RB_Title.CheckedChanged
        SearchCatagory = "Title"
    End Sub

    Private Sub RB_Genre_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RB_Genre.CheckedChanged
        SearchCatagory = "Genre"
    End Sub

    Private Sub RB_Actor_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RB_Actor.CheckedChanged
        SearchCatagory = "Actor"
    End Sub

    Private Sub RB_Director_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RB_Director.CheckedChanged
        SearchCatagory = "Director"
    End Sub
    '------------------------------
End Class