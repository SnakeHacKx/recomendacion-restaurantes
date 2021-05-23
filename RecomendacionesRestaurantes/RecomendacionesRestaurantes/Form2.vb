Public Class Form2
    Private Sub Btn_Cerrar_Click(sender As Object, e As EventArgs) Handles Btn_Cerrar.Click
        Me.Hide()
    End Sub

    Private Sub Btn_Menu1_Click(sender As Object, e As EventArgs) Handles Btn_Menu1.Click
        Dim form4 As New Form4
        form4.imageWidth = Btn_Menu1.Image.Width
        form4.imageHeight = Btn_Menu1.Image.Height
        form4.Pic_ShowImage.Image = Btn_Menu1.Image
        form4.ShowDialog()
    End Sub

    Private Sub Btn_Menu2_Click(sender As Object, e As EventArgs) Handles Btn_Menu2.Click
        Dim form4 As New Form4
        form4.imageWidth = Btn_Menu2.Image.Width
        form4.imageHeight = Btn_Menu2.Image.Height
        form4.Pic_ShowImage.Image = Btn_Menu2.Image
        form4.ShowDialog()
    End Sub

    Private Sub Btn_Menu3_Click(sender As Object, e As EventArgs) Handles Btn_Menu3.Click
        Dim form4 As New Form4
        form4.imageWidth = Btn_Menu3.Image.Width
        form4.imageHeight = Btn_Menu3.Image.Height
        form4.Pic_ShowImage.Image = Btn_Menu3.Image
        form4.ShowDialog()
    End Sub
End Class