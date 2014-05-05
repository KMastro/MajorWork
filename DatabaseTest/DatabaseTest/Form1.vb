Public Class Form1

    Sub Refreshrows()
        ListBox1.Items.Clear()

        For Each r As MorgansMoviesDataSet.tblMoviesRow In TblMoviesTableAdapter.GetData

            ListBox1.Items.Add(r.Title)

        Next
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'MorgansMoviesDataSet.tblMovies' table. You can move, or remove it, as needed.
        Me.TblMoviesTableAdapter.Fill(Me.MorgansMoviesDataSet.tblMovies)
        Refreshrows()

    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        TblMoviesTableAdapter.Insert(TextBox1.Text, "2001", "Derp")
        Refreshrows()
    End Sub
End Class
