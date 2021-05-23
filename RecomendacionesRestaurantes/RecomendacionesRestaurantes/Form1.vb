Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Btn_Cerrar_Click(sender As Object, e As EventArgs) Handles Btn_Cerrar.Click
        Application.Exit()
    End Sub

    Private Sub Btn_Menu_Click(sender As Object, e As EventArgs) Handles Btn_Menu.Click
        If Pn_SideMenu.Width = 46 Then
            Pn_SideMenu.Visible = False
            Pn_SideMenu.Width = 345
            SideMenuAnimator.ShowSync(Pn_SideMenu)
            LogoMenuAnimator.ShowSync(Picture_Logo)
        Else
            'LogoMenuAnimator.Hide(Picture_Logo)
            Picture_Logo.Visible = False
            Pn_SideMenu.Visible = False
            Pn_SideMenu.Width = 46
            SideMenuAnimator2.ShowSync(Pn_SideMenu)
        End If
    End Sub

    Private Sub Btn_Maximizar_Click(sender As Object, e As EventArgs) Handles Btn_Maximizar.Click
        If Me.WindowState = FormWindowState.Maximized Then
            Me.WindowState = FormWindowState.Normal
        Else
            Me.WindowState = FormWindowState.Maximized
        End If
    End Sub

    Private Sub Btn_Minimizar_Click(sender As Object, e As EventArgs) Handles Btn_Minimizar.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub Pic_McDonalds_Click(sender As Object, e As EventArgs) Handles Pic_McDonalds.Click
        Dim form2 As New Form2
        form2.ShowDialog()
    End Sub
End Class
