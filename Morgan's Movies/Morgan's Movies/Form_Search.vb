Public Class Form_Search

    Private Sub Form_Search_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Add.Click

        Form_Add.Show()
        Me.Close()

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_ShowAll.Click

        Form_Results.Show()
        Me.Close()

    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_RecentlyAdded.Click

        Form_Results.Show()
        Me.Close()

    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Search.Click

        If Txtbox_Keyword.Text <> "" And Txtbox_Keyword.Text <> "Please Select A Catagory" Then
            Keyword = Txtbox_Keyword.Text.ToLower
            Form_Results.Show()
            Me.Close()
        Else
            Txtbox_Keyword.Text = "Please Select A Catagory"
        End If


    End Sub

End Class