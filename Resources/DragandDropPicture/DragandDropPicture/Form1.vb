Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        PictureBox1.AllowDrop = True
    End Sub

    Private Sub pb_DragDrop(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles PictureBox1.DragDrop
        Try
            PictureBox1.Image = Image.FromFile(CType(e.Data.GetData(DataFormats.FileDrop), Array).GetValue(0).ToString)
        Catch ex As Exception
            MessageBox.Show("Error Doing Drag/Drop")
        End Try
    End Sub

    Private Sub pb_DragEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles PictureBox1.DragEnter
        If (e.Data.GetDataPresent(DataFormats.FileDrop)) Then
            e.Effect = DragDropEffects.Copy
        End If
    End Sub
End Class
