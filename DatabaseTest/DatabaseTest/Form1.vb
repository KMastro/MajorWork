Public Class Form1



    Private Sub AddNewColumn(ByRef table As DataTable, _
   ByVal columnType As String, ByVal columnName As String)
        Dim column As DataColumn = _
         table.Columns.Add(columnName, Type.GetType(columnType))
    End Sub



    Private Sub AddNewRow(ByRef table As DataTable, ByRef id As Integer, ByRef title As String, ByRef year As Integer, ByRef director As String, ByRef genre As String, ByRef actors As String, ByRef summary As String)
        Dim newrow As DataRow = table.NewRow()
        newrow("Movie Num") = id
        newrow("Title") = title
        newrow("Year Released") = year
        newrow("Genre") = genre
        newrow("Director") = director
        newrow("Actors") = actors
        newrow("Summary") = summary
        table.Rows.Add(newrow)
    End Sub
    Private Sub Button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Button1.Click
        Dim ds As New DataSet
        ds = CreateDataSet()
        DataGridView1.DataSource = ds.Tables("Movies")
    End Sub

    Private Function CreateDataSet() As DataSet
        'creating a DataSet object for tables
        Dim dataset As DataSet = New DataSet()
        ' creating the student table
        Dim Movies As DataTable = AddMovie()
        dataset.Tables.Add(Movies)
        Return dataset
    End Function
    Private Function AddMovie() As DataTable
        Dim Movies As DataTable
        Movies = New DataTable("Movies")
        ' adding columns
        AddNewColumn(Movies, "System.Int32", "Movie Num")
        AddNewColumn(Movies, "System.String", "Title")
        AddNewColumn(Movies, "System.String", "Year Released")
        AddNewColumn(Movies, "System.String", "Genre")
        AddNewColumn(Movies, "System.Int32", "Director")
        AddNewColumn(Movies, "System.String", "Actors")
        AddNewColumn(Movies, "System.String", "Summary")
        ' adding rows
        AddNewRow(Movies, 1, TextBox1.Text, TextBox2.Text, TextBox3.Text, TextBox4.Text, TextBox7.Text, TextBox8.Text)

        Return Movies
    End Function

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class
