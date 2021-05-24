Public Class Form1
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

    Private Function BuscarRestaurante(id As String)
        For Each restaurante In listaRestaurantes
            If restaurante.ID = id Then
                Return restaurante
            End If
        Next

        MsgBox("No se ha encontrado el restaurante solicitado!")
        Return Nothing
    End Function

    ' **** Botones de los restaurantes ****

    Private Sub Pic_McDonalds_Click(sender As Object, e As EventArgs) Handles Pic_McDonalds.Click
        Dim form2 As New Form2
        Dim r As Restaurante = BuscarRestaurante(mcDonaldsID)
        form2.Lbl_TituloRestaurante.Text = Lbl_McDonalds.Text
        form2.Pic_Restaurante.Image = Pic_McDonalds.Image
        form2.DescripcionRestaurante.Text = r.Descripcion
        form2.ShowDialog()
    End Sub

    Private Sub Pic_Kfc_Click(sender As Object, e As EventArgs) Handles Pic_Kfc.Click
        Dim form2 As New Form2
        Dim r As Restaurante = BuscarRestaurante(kfcID)
        form2.Lbl_TituloRestaurante.Text = Lbl_Kfc.Text
        form2.Pic_Restaurante.Image = Pic_Kfc.Image
        form2.DescripcionRestaurante.Text = r.Descripcion
        form2.ShowDialog()
    End Sub

    Private Sub Pic_TerrazaSushi_Click(sender As Object, e As EventArgs) Handles Pic_TerrazaSushi.Click
        Dim form2 As New Form2
        Dim r As Restaurante = BuscarRestaurante(terrazaSushiID)
        form2.Lbl_TituloRestaurante.Text = Lbl_TerrazaSushi.Text
        form2.Pic_Restaurante.Image = Pic_TerrazaSushi.Image
        form2.DescripcionRestaurante.Text = r.Descripcion
        form2.ShowDialog()
    End Sub

    Private Sub Pic_Ohtoro_Click(sender As Object, e As EventArgs) Handles Pic_Ohtoro.Click
        Dim form2 As New Form2
        Dim r As Restaurante = BuscarRestaurante(ohtoroID)
        form2.Lbl_TituloRestaurante.Text = Lbl_Ohtoro.Text
        form2.Pic_Restaurante.Image = Pic_Ohtoro.Image
        form2.DescripcionRestaurante.Text = r.Descripcion
        form2.ShowDialog()
    End Sub

    Private Sub Pic_Estambul_Click(sender As Object, e As EventArgs) Handles Pic_Estambul.Click
        Dim form2 As New Form2
        Dim r As Restaurante = BuscarRestaurante(estambulID)
        form2.Lbl_TituloRestaurante.Text = Lbl_Estambul.Text
        form2.Pic_Restaurante.Image = Pic_Estambul.Image
        form2.DescripcionRestaurante.Text = r.Descripcion
        form2.ShowDialog()
    End Sub

    Private Sub Pic_TioCaiman_Click(sender As Object, e As EventArgs) Handles Pic_TioCaiman.Click
        Dim form2 As New Form2
        Dim r As Restaurante = BuscarRestaurante(tioCaimanID)
        form2.Lbl_TituloRestaurante.Text = Lbl_TioCaiman.Text
        form2.Pic_Restaurante.Image = Pic_TioCaiman.Image
        form2.DescripcionRestaurante.Text = r.Descripcion
        form2.ShowDialog()
    End Sub

    Private Sub Pic_EventosCarolina_Click(sender As Object, e As EventArgs) Handles Pic_EventosCarolina.Click
        Dim form2 As New Form2
        Dim r As Restaurante = BuscarRestaurante(eventosCarolinaID)
        form2.Lbl_TituloRestaurante.Text = Lbl_EventosCarolina.Text
        form2.Pic_Restaurante.Image = Pic_EventosCarolina.Image
        form2.DescripcionRestaurante.Text = r.Descripcion
        form2.ShowDialog()
    End Sub

    Private Sub Pic_Subway_Click(sender As Object, e As EventArgs) Handles Pic_Subway.Click
        Dim form2 As New Form2
        Dim r As Restaurante = BuscarRestaurante(subwayID)
        form2.Lbl_TituloRestaurante.Text = Lbl_Subway.Text
        form2.Pic_Restaurante.Image = Pic_Subway.Image
        form2.DescripcionRestaurante.Text = r.Descripcion
        form2.ShowDialog()
    End Sub

    Private Sub Pic_ElMirador_Click(sender As Object, e As EventArgs) Handles Pic_ElMirador.Click
        Dim form2 As New Form2
        Dim r As Restaurante = BuscarRestaurante(miradorID)
        form2.Lbl_TituloRestaurante.Text = Lbl_Mirador.Text
        form2.Pic_Restaurante.Image = Pic_ElMirador.Image
        form2.DescripcionRestaurante.Text = r.Descripcion
        form2.ShowDialog()
    End Sub

    Private Sub Pic_SalsaCarbon_Click(sender As Object, e As EventArgs) Handles Pic_SalsaCarbon.Click
        Dim form2 As New Form2
        Dim r As Restaurante = BuscarRestaurante(salsaCarbonID)
        form2.Lbl_TituloRestaurante.Text = Lbl_SalsaCarbon.Text
        form2.Pic_Restaurante.Image = Pic_SalsaCarbon.Image
        form2.DescripcionRestaurante.Text = r.Descripcion
        form2.ShowDialog()
    End Sub

    ' **** Crear Restaurantes ****

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

        AgregarInfoRestaurantes()
    End Sub

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
        listaRestaurantes.Add(restaurante)
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
        listaRestaurantes.Add(restaurante)
    End Sub

    Private Sub CrearlElMirador()
        Dim restaurante As New Restaurante(miradorID)
        listaRestaurantes.Add(restaurante)
    End Sub

    Private Sub CrearSalsayCarbon()
        Dim restaurante As New Restaurante(salsaCarbonID)
        listaRestaurantes.Add(restaurante)
    End Sub

    ''' <summary>
    ''' Agrega la informacion de los restaurantes.
    ''' </summary>
    ''' <remarks>
    ''' Usa un bucle for each en donde recorre todos los restaurantes en memoria
    ''' y les pone sus propiedades, ademas de que al final de cada revision,
    ''' pone le agrega su descripcion
    ''' </remarks>
    Private Sub AgregarInfoRestaurantes()
        For Each r In listaRestaurantes
            If r.ID = mcDonaldsID Then
                ' Tipo de restaurante
                r.Tipo = "Comida Rápida y Familiar"
                r.tipoTags.Add(ttag_comidaRapida)
                r.tipoTags.Add(ttag_familiar)

                ' Especialidades
                r.Especialidad = "Hamburguesas"
                r.especialidadTags.Add(etag_hamburguesas)

                r.PresupuestoMinimo = 5
                r.Abierto = False
                r.Telefono = "no disponible"

                ' Comidas del dia
                r.SirveDesayuno = True
                r.SirveAlmuerzo = True
                r.SirveCena = False

                ' Metodos de pago
                r.AceptaTargetaCredito = True
                r.AceptaEfectivo = True
                r.AceptaYappy = False

                'Tipo de despacho
                r.EntregaADomicilio = False
                r.EntregaEnLocal = True

                r.HacerDescripcion()
            End If

            If r.ID = kfcID Then
                ' Tipo de restaurante
                r.Tipo = "Comida Rápida y Familiar"
                r.tipoTags.Add(ttag_comidaRapida)
                r.tipoTags.Add(ttag_familiar)

                ' Especialidades
                r.Especialidad = "Pollo"
                r.especialidadTags.Add(etag_pollo)

                r.PresupuestoMinimo = 5
                r.Abierto = False
                r.Telefono = "no disponible"

                ' Comidas del dia
                r.SirveDesayuno = True
                r.SirveAlmuerzo = True
                r.SirveCena = False

                ' Metodos de pago
                r.AceptaTargetaCredito = True
                r.AceptaEfectivo = True
                r.AceptaYappy = False

                'Tipo de despacho
                r.EntregaADomicilio = False
                r.EntregaEnLocal = True

                r.HacerDescripcion()
            End If

            If r.ID = miradorID Then
                ' Tipo de restaurante
                r.Tipo = "Familiar"
                r.tipoTags.Add(ttag_familiar)

                ' Especialidades
                r.Especialidad = "Mariscos"
                r.especialidadTags.Add(etag_mariscos)

                r.PresupuestoMinimo = 8
                r.Abierto = False
                r.Telefono = "6589-3753 y 974-4647"

                ' Comidas del dia
                r.SirveDesayuno = True
                r.SirveAlmuerzo = True
                r.SirveCena = False

                ' Metodos de pago
                r.AceptaTargetaCredito = True
                r.AceptaEfectivo = True
                r.AceptaYappy = False

                'Tipo de despacho
                r.EntregaADomicilio = False
                r.EntregaEnLocal = True

                r.HacerDescripcion()
            End If

            If r.ID = tioCaimanID Then
                ' Tipo de restaurante
                r.Tipo = "Familiar"
                r.tipoTags.Add(ttag_familiar)

                ' Especialidades
                r.Especialidad = "Mariscos"
                r.especialidadTags.Add(etag_mariscos)

                r.PresupuestoMinimo = 9
                r.Abierto = False
                r.Telefono = "996-8040"

                ' Comidas del dia
                r.SirveDesayuno = False
                r.SirveAlmuerzo = True
                r.SirveCena = True

                ' Metodos de pago
                r.AceptaTargetaCredito = True
                r.AceptaEfectivo = True
                r.AceptaYappy = False

                'Tipo de despacho
                r.EntregaADomicilio = True
                r.EntregaEnLocal = True

                r.HacerDescripcion()
            End If

            If r.ID = salsaCarbonID Then
                ' Tipo de restaurante
                r.Tipo = "Familiar"
                r.tipoTags.Add(ttag_familiar)

                ' Especialidades
                r.Especialidad = "Carnes"
                r.especialidadTags.Add(etag_carne)

                r.PresupuestoMinimo = 10
                r.Abierto = False
                r.Telefono = "6306-1316 y 996-6022"

                ' Comidas del dia
                r.SirveDesayuno = False
                r.SirveAlmuerzo = True
                r.SirveCena = True

                ' Metodos de pago
                r.AceptaTargetaCredito = True
                r.AceptaEfectivo = True
                r.AceptaYappy = True

                'Tipo de despacho
                r.EntregaADomicilio = True
                r.EntregaEnLocal = True

                r.HacerDescripcion()
            End If

            If r.ID = subwayID Then
                ' Tipo de restaurante
                r.Tipo = "Comida Rápida y Familiar"
                r.tipoTags.Add(ttag_comidaRapida)
                r.tipoTags.Add(ttag_familiar)

                ' Especialidades
                r.Especialidad = "Emparedados"
                r.especialidadTags.Add(etag_emparedados)

                r.PresupuestoMinimo = 5
                r.Abierto = False
                r.Telefono = "no disponible"

                ' Comidas del dia
                r.SirveDesayuno = True
                r.SirveAlmuerzo = True
                r.SirveCena = False

                ' Metodos de pago
                r.AceptaTargetaCredito = False
                r.AceptaEfectivo = True
                r.AceptaYappy = False

                'Tipo de despacho
                r.EntregaADomicilio = True
                r.EntregaEnLocal = False

                r.HacerDescripcion()
            End If

            If r.ID = ohtoroID Then
                ' Tipo de restaurante
                r.Tipo = "Temático y Familiar"
                r.tipoTags.Add(ttag_tematico)
                r.tipoTags.Add(ttag_familiar)

                ' Especialidades
                r.Especialidad = "Sushi"
                r.especialidadTags.Add(etag_sushi)

                r.PresupuestoMinimo = 12
                r.Abierto = False
                r.Telefono = "no disponible"

                ' Comidas del dia
                r.SirveDesayuno = False
                r.SirveAlmuerzo = False
                r.SirveCena = True

                ' Metodos de pago
                r.AceptaTargetaCredito = True
                r.AceptaEfectivo = True
                r.AceptaYappy = False

                'Tipo de despacho
                r.EntregaADomicilio = True
                r.EntregaEnLocal = True

                r.HacerDescripcion()
            End If

            If r.ID = terrazaSushiID Then
                ' Tipo de restaurante
                r.Tipo = "Temático y Familiar"
                r.tipoTags.Add(ttag_tematico)
                r.tipoTags.Add(ttag_familiar)

                ' Especialidades
                r.Especialidad = "Sushi"
                r.especialidadTags.Add(etag_sushi)

                r.PresupuestoMinimo = 8
                r.Abierto = False
                r.Telefono = "978-8508"

                ' Comidas del dia
                r.SirveDesayuno = False
                r.SirveAlmuerzo = False
                r.SirveCena = True

                ' Metodos de pago
                r.AceptaTargetaCredito = True
                r.AceptaEfectivo = True
                r.AceptaYappy = True

                'Tipo de despacho
                r.EntregaADomicilio = True
                r.EntregaEnLocal = True

                r.HacerDescripcion()
            End If

            If r.ID = estambulID Then
                ' Tipo de restaurante
                r.Tipo = "desconocido"
                r.tipoTags.Add(ttag_familiar)

                ' Especialidades
                r.Especialidad = "desconocido"

                r.PresupuestoMinimo = 8
                r.Abierto = False
                r.Telefono = "desconocido"

                ' Comidas del dia
                r.SirveDesayuno = False
                r.SirveAlmuerzo = False
                r.SirveCena = True

                ' Metodos de pago
                r.AceptaTargetaCredito = True
                r.AceptaEfectivo = True
                r.AceptaYappy = True

                'Tipo de despacho
                r.EntregaADomicilio = True
                r.EntregaEnLocal = True

                r.HacerDescripcion()
            End If

            If r.ID = eventosCarolinaID Then
                ' Tipo de restaurante
                r.Tipo = "desconocido"
                r.tipoTags.Add(ttag_familiar)

                ' Especialidades
                r.Especialidad = "desconocido"

                r.PresupuestoMinimo = 8
                r.Abierto = False
                r.Telefono = "desconocido"

                ' Comidas del dia
                r.SirveDesayuno = False
                r.SirveAlmuerzo = False
                r.SirveCena = True

                ' Metodos de pago
                r.AceptaTargetaCredito = True
                r.AceptaEfectivo = True
                r.AceptaYappy = True

                'Tipo de despacho
                r.EntregaADomicilio = True
                r.EntregaEnLocal = True

                r.HacerDescripcion()
            End If
        Next
    End Sub

    ' **** Declaraciones ****

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

    ' Tipos de restaurante (Tags) ttag = t: tipo de restaurante | tag: etiqueta
    Dim ttag_comidaRapida As String = "comida-rapida"
    Dim ttag_familiar As String = "familiar"
    Dim ttag_tematico As String = "tematico"

    ' Tipos de especialidad (Tags) etag = e: especialidad | tag: etiqueta
    Dim etag_mariscos As String = "mariscos"
    Dim etag_postres As String = "postres"
    Dim etag_carne As String = "carnes"
    Dim etag_pollo As String = "pollo"
    Dim etag_emparedados As String = "emparedados"
    Dim etag_hamburguesas As String = "hamburguesas"
    Dim etag_sushi As String = "sushi"
End Class
