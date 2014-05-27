Public Class Form1

    Dim AllInfo(5) As Object


    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        'Gets input from user
        AllInfo(0) = Txt_Title.Text
        AllInfo(1) = Txt_Year.Text
        AllInfo(2) = Txt_Genre.Text
        AllInfo(3) = Txt_Director.Text
        AllInfo(4) = Txt_Actors.Text
        AllInfo(5) = Txt_Summary.Text

        Dim DR As DataRow

        'Loads the names of the columns
        Dim DT As DataTable = New DataTable
        DT.Columns.Add("Title", GetType(String))
        DT.Columns.Add("Year Realeased", GetType(Integer))
        DT.Columns.Add("Genre", GetType(String))
        DT.Columns.Add("Director", GetType(String))
        DT.Columns.Add("Actors", GetType(String))
        DT.Columns.Add("Summary", GetType(String))

        'Enters users input into a row
        DR = DT.NewRow()
        DR.Table.Rows.Add(AllInfo(0).ToString, AllInfo(1).ToString, AllInfo(2).ToString, AllInfo(3).ToString, AllInfo(4).ToString, AllInfo(5).ToString)

        DataGridView1.DataSource = DT


    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        DataGridView1.DataSource = 0
    End Sub
End Class


