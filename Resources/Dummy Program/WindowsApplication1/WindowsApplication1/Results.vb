Public Class Results

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        MsgBox("Not yet Created")
        Search.Show()
        Me.Close()
    End Sub

    Private Sub ListBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListBox1.SelectedIndexChanged

        If ListBox1.CanSelect = True Then
            PictureBox1.Show()
            Label2.Show()
            Label3.Show()
            Label4.Show()
            Label5.Show()
            Label6.Show()
            Label7.Show()
            RichTextBox1.Show()
        End If

    End Sub

    Private Sub Results_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        PictureBox1.Hide()
        Label2.Hide()
        Label3.Hide()
        Label4.Hide()
        Label5.Hide()
        Label6.Hide()
        Label7.Hide()
        RichTextBox1.Hide()

    End Sub





    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If ListBox1.SelectedIndex = 0 Then
            Playmovie.Show()
        End If
    End Sub
End Class