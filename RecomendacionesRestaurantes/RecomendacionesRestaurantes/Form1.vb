Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Pn_SideMenu.Width = 46
        Me.Width = 1263
        Me.Height = 783
    End Sub

    Private Sub Btn_Cerrar_Click(sender As Object, e As EventArgs) Handles Btn_Cerrar.Click
        Application.Exit()
    End Sub

    Private Sub Btn_Menu_Click(sender As Object, e As EventArgs) Handles Btn_Menu.Click
        If Pn_SideMenu.Width = 46 Then
            Pn_SideMenu.AutoScroll = True
            Pn_SideMenu.Visible = False

            Pn_Restaurantes.Visible = True
            Pn_TipoDeComida.Visible = True
            Pn_TipoDeDespacho.Visible = True
            Pn_Presupuesto.Visible = True
            Pn_CantidadDePersonas.Visible = True
            Lbl_Filtro.Visible = True

            Pn_SideMenu.Width = 345
            SideMenuAnimator.ShowSync(Pn_SideMenu)
            LogoMenuAnimator.ShowSync(Picture_Logo)
        Else
            'LogoMenuAnimator.Hide(Picture_Logo)
            Pn_SideMenu.AutoScroll = False

            Pn_Restaurantes.Visible = False
            Pn_TipoDeComida.Visible = False
            Pn_TipoDeDespacho.Visible = False
            Pn_Presupuesto.Visible = False
            Pn_CantidadDePersonas.Visible = False
            Lbl_Filtro.Visible = False

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

    Private Sub Slider_Presupuesto_ValueChanged(sender As Object, e As EventArgs) Handles Slider_Presupuesto.ValueChanged
        Lbl_ValorPresupuesto.Text = Str(Slider_Presupuesto.Value)
    End Sub

    Private Sub Cb_Grupo_OnChange(sender As Object, e As EventArgs) Handles Cb_Grupo.OnChange
        If Cb_Grupo.Checked Then
            Lbl_2Personas.Visible = True
            Lbl_4Personas.Visible = True
            Cb_2Personas.Visible = True
            Cb_4Personas.Visible = True
        Else
            Lbl_2Personas.Visible = False
            Lbl_4Personas.Visible = False
            Cb_2Personas.Visible = False
            Cb_4Personas.Visible = False
        End If
    End Sub
End Class
