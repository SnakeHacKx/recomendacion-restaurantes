Public Class Form1
    ' Identificadores unicos de cada restaurante
    Dim mcDonaldsID As String = "mcd"
    Dim kfcID As String = "kfc"
    Dim terrazaSushiID As String = "ts"
    Dim ohtoroID As String = "oht"
    Dim estambulID As String = "est"
    Dim tioCaimanID As String = "tcai"
    Dim eventosCarolinaID As String = "eca"
    Dim subwayID As String = "sw"
    Dim miradorID As String = "mir"
    Dim salsaCarbonID As String = "syc"

    ' Lista de todos los restaurantes
    Dim listaRestaurantes As New List(Of Restaurante)

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Pn_SideMenu.Width = 46
        Me.Width = 1263
        Me.Height = 783
        CrearRestaurantes()
    End Sub

    Private Sub Btn_Cerrar_Click(sender As Object, e As EventArgs) Handles Btn_Cerrar.Click
        Application.Exit()
    End Sub

    ''' <summary>
    ''' Evento click del boton de menu
    ''' </summary>
    ''' <remarks>
    ''' Hace que se visualice el menu del lado izquierdo de la pantalla (filtros).
    ''' </remarks>
    Private Sub Btn_Menu_Click(sender As Object, e As EventArgs) Handles Btn_Menu.Click
        If Pn_SideMenu.Width = 46 Then
            Pn_Filtros.AutoScroll = True
            Pn_SideMenu.Visible = False

            CambiarVisibilidadMenuFiltros(True)

            Pn_SideMenu.Width = 345
            SideMenuAnimator.ShowSync(Pn_SideMenu)
            LogoMenuAnimator.ShowSync(Picture_Logo)
        Else
            SideMenuHideAnimator.HideSync(Pn_SideMenu)
            Pn_Filtros.AutoScroll = False

            CambiarVisibilidadMenuFiltros(False)

            Picture_Logo.Visible = False
            Pn_SideMenu.Visible = False
            Pn_SideMenu.Width = 46
            SideMenuAnimator2.ShowSync(Pn_SideMenu)
        End If
    End Sub

    ''' <summary>
    ''' Cambia la visibilidad de los controles
    ''' </summary>
    ''' <remarks>
    ''' Hace visible los controles que se encuentran en el menu del lado izq. de la pantalla
    ''' para que se muestren cuando esta abierto y se insibilicen cuando esta cerrado.
    ''' </remarks>
    ''' <param name="activo"> <para>True: se haran visible los controles. </para> 
    '''                       <para>False: se haran invisibles los controles. </para> </param>
    Private Sub CambiarVisibilidadMenuFiltros(activo As Boolean)
        Pn_TipoDeRestaurante.Visible = activo
        Pn_TipoDeDespacho.Visible = activo
        Pn_Presupuesto.Visible = activo
        Pn_Disponibilidad.Visible = activo
        Pn_ComidaDelDia.Visible = activo
        Pn_Especialidad.Visible = activo
        Pn_FormaDePago.Visible = activo
        Lbl_Filtro.Visible = activo
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

    Private Sub Slider_Presupuesto_ValueChanged(sender As Object, e As EventArgs) Handles Slider_Presupuesto.ValueChanged
        Lbl_ValorPresupuesto.Text = Str(Slider_Presupuesto.Value)
    End Sub

    ' **** Botones de los restaurantes ****

    Private Sub Pic_McDonalds_Click(sender As Object, e As EventArgs) Handles Pic_McDonalds.Click
        Dim form2 As New Form2
        form2.Lbl_TituloRestaurante.Text = Lbl_McDonalds.Text
        form2.Pic_Restaurante.Image = Pic_McDonalds.Image
        form2.DescripcionRestaurante.Text = "Texto de Prueba"
        form2.ShowDialog()
    End Sub

    Private Sub Pic_Kfc_Click(sender As Object, e As EventArgs) Handles Pic_Kfc.Click

    End Sub

    Private Sub CrearRestaurantes()
        CrearMcDonalds()
        CrearKfc()
        CrearlElMirador()
        CrearEventosCarolina()
        CrearEstambul()
        CrearOhtoro()
        CrearSubway()
        CrearTioCaiman()
        CrearTerrazaSushi()
        CrearSalsayCarbon()
    End Sub

    ' **** Crear Restaurantes ****

    Private Sub CrearMcDonalds()
        Dim restaurante As New Restaurante(mcDonaldsID)
        listaRestaurantes.Add(restaurante)
    End Sub

    Private Sub CrearKfc()
        Dim restaurante As New Restaurante(kfcID)
        listaRestaurantes.Add(restaurante)
    End Sub

    Private Sub CrearTerrazaSushi()
        Dim restaurante As New Restaurante(terrazaSushiID)
        listaRestaurantes.Add(restaurante)
    End Sub

    Private Sub CrearOhtoro()
        Dim restaurante As New Restaurante(ohtoroID)
    End Sub

    Private Sub CrearEstambul()
        Dim restaurante As New Restaurante(estambulID)
        listaRestaurantes.Add(restaurante)
    End Sub

    Private Sub CrearTioCaiman()
        Dim restaurante As New Restaurante(tioCaimanID)
        listaRestaurantes.Add(restaurante)
    End Sub

    Private Sub CrearEventosCarolina()
        Dim restaurante As New Restaurante(eventosCarolinaID)
        listaRestaurantes.Add(restaurante)
    End Sub

    Private Sub CrearSubway()
        Dim restaurante As New Restaurante(subwayID)
    End Sub

    Private Sub CrearlElMirador()
        Dim restaurante As New Restaurante(miradorID)
        listaRestaurantes.Add(restaurante)
    End Sub

    Private Sub CrearSalsayCarbon()
        Dim restaurante As New Restaurante(salsaCarbonID)
        listaRestaurantes.Add(restaurante)
    End Sub

    ' **** Agregar Informacion a Los Restaurantes ****
    Private Sub AgregarInfoRestaurantes()
        For Each r In listaRestaurantes
            If r.ID = mcDonaldsID Then
                ...
            End If
        Next
    End Sub
End Class
