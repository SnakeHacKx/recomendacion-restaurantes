<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim Animation2 As BunifuAnimatorNS.Animation = New BunifuAnimatorNS.Animation()
        Dim Animation3 As BunifuAnimatorNS.Animation = New BunifuAnimatorNS.Animation()
        Dim Animation1 As BunifuAnimatorNS.Animation = New BunifuAnimatorNS.Animation()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Dim Animation4 As BunifuAnimatorNS.Animation = New BunifuAnimatorNS.Animation()
        Me.Pn_SideMenu = New System.Windows.Forms.Panel()
        Me.Pn_Filtros = New System.Windows.Forms.TableLayoutPanel()
        Me.Pn_Especialidad = New System.Windows.Forms.Panel()
        Me.Cb_Sushi = New Bunifu.Framework.UI.BunifuCheckbox()
        Me.Cb_Hamburguesas = New Bunifu.Framework.UI.BunifuCheckbox()
        Me.Cb_Emparedados = New Bunifu.Framework.UI.BunifuCheckbox()
        Me.Cb_Pollo = New Bunifu.Framework.UI.BunifuCheckbox()
        Me.Cb_Mariscos = New Bunifu.Framework.UI.BunifuCheckbox()
        Me.Cb_Carnes = New Bunifu.Framework.UI.BunifuCheckbox()
        Me.Lbl_Sushi = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.Lbl_Hamburguesas = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.Lbl_Emparedados = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.Lbl_Pollo = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.Lbl_Carnes = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.Lbl_Mariscos = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuCustomLabel31 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.Pn_Disponibilidad = New System.Windows.Forms.Panel()
        Me.Lbl_Abierto2 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.Lbl_Abierto1 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.Cb_Abierto = New Bunifu.Framework.UI.BunifuCheckbox()
        Me.BunifuCustomLabel22 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.Pn_TipoDeRestaurante = New System.Windows.Forms.Panel()
        Me.Lbl_ComidaRapida = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.Cb_ComidaRapida = New Bunifu.Framework.UI.BunifuCheckbox()
        Me.Lbl_Familiar = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.Cb_Familiar = New Bunifu.Framework.UI.BunifuCheckbox()
        Me.Cb_Tematico = New Bunifu.Framework.UI.BunifuCheckbox()
        Me.BunifuCustomLabel9 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.Lbl_Tematico = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.Pn_Presupuesto = New System.Windows.Forms.Panel()
        Me.Lbl_ValorPresupuesto = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.Slider_Presupuesto = New Bunifu.Framework.UI.BunifuSlider()
        Me.BunifuCustomLabel18 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.Lbl_Presupuesto = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.Pn_TipoDeDespacho = New System.Windows.Forms.Panel()
        Me.Lbl_EntregaADomicilio = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.Cb_EntregaDomicilio = New Bunifu.Framework.UI.BunifuCheckbox()
        Me.Lbl_EntregaLocal = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.Cb_EntregaLocal = New Bunifu.Framework.UI.BunifuCheckbox()
        Me.BunifuCustomLabel19 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.Pn_FormaDePago = New System.Windows.Forms.Panel()
        Me.Lbl_TargetaCredito = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.Cb_TargetaCredito = New Bunifu.Framework.UI.BunifuCheckbox()
        Me.Lbl_Efectivo = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.Cb_Efectivo = New Bunifu.Framework.UI.BunifuCheckbox()
        Me.Lbl_FormasDePago = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.Pn_ComidaDelDia = New System.Windows.Forms.Panel()
        Me.Cb_Cena = New Bunifu.Framework.UI.BunifuCheckbox()
        Me.Lbl_Cena = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.Cb_Almuerzo = New Bunifu.Framework.UI.BunifuCheckbox()
        Me.Lbl_Almuerzo = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.Lbl_Desayuno = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuCheckbox8 = New Bunifu.Framework.UI.BunifuCheckbox()
        Me.BunifuCustomLabel28 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Btn_Menu = New Bunifu.Framework.UI.BunifuImageButton()
        Me.Picture_Logo = New System.Windows.Forms.PictureBox()
        Me.Lbl_Filtro = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuElipse1 = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.Pn_header = New System.Windows.Forms.Panel()
        Me.Btn_Minimizar = New Bunifu.Framework.UI.BunifuImageButton()
        Me.Btn_Maximizar = New Bunifu.Framework.UI.BunifuImageButton()
        Me.Btn_Cerrar = New Bunifu.Framework.UI.BunifuImageButton()
        Me.Pic_IconoVentana = New System.Windows.Forms.PictureBox()
        Me.Lbl_TituloVentana = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuDragControl1 = New Bunifu.Framework.UI.BunifuDragControl(Me.components)
        Me.SideMenuAnimator = New BunifuAnimatorNS.BunifuTransition(Me.components)
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Lbl_TituloBold = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.Lbl_Subtitulo = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.Lbl_Titulo = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.TableLayoutPanel6 = New System.Windows.Forms.TableLayoutPanel()
        Me.Lbl_TioCaiman = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.Pic_TioCaiman = New Bunifu.Framework.UI.BunifuImageButton()
        Me.TableLayoutPanel5 = New System.Windows.Forms.TableLayoutPanel()
        Me.Lbl_Estambul = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.Pic_Estambul = New Bunifu.Framework.UI.BunifuImageButton()
        Me.TableLayoutPanel4 = New System.Windows.Forms.TableLayoutPanel()
        Me.Lbl_Ohtoro = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.Pic_Ohtoro = New Bunifu.Framework.UI.BunifuImageButton()
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
        Me.Lbl_TerrazaSushi = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.Pic_TerrazaSushi = New Bunifu.Framework.UI.BunifuImageButton()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.Lbl_Kfc = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.Pic_Kfc = New Bunifu.Framework.UI.BunifuImageButton()
        Me.Pn_Restaurantes = New System.Windows.Forms.FlowLayoutPanel()
        Me.Pn_mcdonads = New System.Windows.Forms.TableLayoutPanel()
        Me.Lbl_McDonalds = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.Pic_McDonalds = New Bunifu.Framework.UI.BunifuImageButton()
        Me.TableLayoutPanel7 = New System.Windows.Forms.TableLayoutPanel()
        Me.Lbl_EventosCarolina = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.Pic_EventosCarolina = New Bunifu.Framework.UI.BunifuImageButton()
        Me.TableLayoutPanel8 = New System.Windows.Forms.TableLayoutPanel()
        Me.Lbl_Subway = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.Pic_Subway = New Bunifu.Framework.UI.BunifuImageButton()
        Me.TableLayoutPanel9 = New System.Windows.Forms.TableLayoutPanel()
        Me.Lbl_Mirador = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.Pic_ElMirador = New Bunifu.Framework.UI.BunifuImageButton()
        Me.TableLayoutPanel10 = New System.Windows.Forms.TableLayoutPanel()
        Me.Lbl_SalsaCarbon = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.Pic_SalsaCarbon = New Bunifu.Framework.UI.BunifuImageButton()
        Me.LogoMenuAnimator = New BunifuAnimatorNS.BunifuTransition(Me.components)
        Me.SideMenuAnimator2 = New BunifuAnimatorNS.BunifuTransition(Me.components)
        Me.SideMenuHideAnimator = New BunifuAnimatorNS.BunifuTransition(Me.components)
        Me.Pn_SideMenu.SuspendLayout()
        Me.Pn_Filtros.SuspendLayout()
        Me.Pn_Especialidad.SuspendLayout()
        Me.Pn_Disponibilidad.SuspendLayout()
        Me.Pn_TipoDeRestaurante.SuspendLayout()
        Me.Pn_Presupuesto.SuspendLayout()
        Me.Pn_TipoDeDespacho.SuspendLayout()
        Me.Pn_FormaDePago.SuspendLayout()
        Me.Pn_ComidaDelDia.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.Btn_Menu, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Picture_Logo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Pn_header.SuspendLayout()
        CType(Me.Btn_Minimizar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Btn_Maximizar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Btn_Cerrar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Pic_IconoVentana, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.TableLayoutPanel6.SuspendLayout()
        CType(Me.Pic_TioCaiman, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel5.SuspendLayout()
        CType(Me.Pic_Estambul, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel4.SuspendLayout()
        CType(Me.Pic_Ohtoro, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel3.SuspendLayout()
        CType(Me.Pic_TerrazaSushi, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel2.SuspendLayout()
        CType(Me.Pic_Kfc, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Pn_Restaurantes.SuspendLayout()
        Me.Pn_mcdonads.SuspendLayout()
        CType(Me.Pic_McDonalds, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel7.SuspendLayout()
        CType(Me.Pic_EventosCarolina, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel8.SuspendLayout()
        CType(Me.Pic_Subway, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel9.SuspendLayout()
        CType(Me.Pic_ElMirador, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel10.SuspendLayout()
        CType(Me.Pic_SalsaCarbon, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Pn_SideMenu
        '
        Me.Pn_SideMenu.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.Pn_SideMenu.Controls.Add(Me.Pn_Filtros)
        Me.Pn_SideMenu.Controls.Add(Me.Panel3)
        Me.SideMenuHideAnimator.SetDecoration(Me.Pn_SideMenu, BunifuAnimatorNS.DecorationType.None)
        Me.SideMenuAnimator.SetDecoration(Me.Pn_SideMenu, BunifuAnimatorNS.DecorationType.None)
        Me.LogoMenuAnimator.SetDecoration(Me.Pn_SideMenu, BunifuAnimatorNS.DecorationType.None)
        Me.SideMenuAnimator2.SetDecoration(Me.Pn_SideMenu, BunifuAnimatorNS.DecorationType.None)
        Me.Pn_SideMenu.Dock = System.Windows.Forms.DockStyle.Left
        Me.Pn_SideMenu.Location = New System.Drawing.Point(0, 45)
        Me.Pn_SideMenu.Name = "Pn_SideMenu"
        Me.Pn_SideMenu.Size = New System.Drawing.Size(358, 738)
        Me.Pn_SideMenu.TabIndex = 0
        '
        'Pn_Filtros
        '
        Me.Pn_Filtros.AutoScroll = True
        Me.Pn_Filtros.ColumnCount = 1
        Me.Pn_Filtros.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.Pn_Filtros.Controls.Add(Me.Pn_Especialidad, 0, 8)
        Me.Pn_Filtros.Controls.Add(Me.Pn_Disponibilidad, 0, 6)
        Me.Pn_Filtros.Controls.Add(Me.Pn_TipoDeRestaurante, 0, 1)
        Me.Pn_Filtros.Controls.Add(Me.Pn_Presupuesto, 0, 2)
        Me.Pn_Filtros.Controls.Add(Me.Pn_TipoDeDespacho, 0, 3)
        Me.Pn_Filtros.Controls.Add(Me.Pn_FormaDePago, 0, 5)
        Me.Pn_Filtros.Controls.Add(Me.Pn_ComidaDelDia, 0, 7)
        Me.SideMenuHideAnimator.SetDecoration(Me.Pn_Filtros, BunifuAnimatorNS.DecorationType.None)
        Me.SideMenuAnimator.SetDecoration(Me.Pn_Filtros, BunifuAnimatorNS.DecorationType.None)
        Me.LogoMenuAnimator.SetDecoration(Me.Pn_Filtros, BunifuAnimatorNS.DecorationType.None)
        Me.SideMenuAnimator2.SetDecoration(Me.Pn_Filtros, BunifuAnimatorNS.DecorationType.None)
        Me.Pn_Filtros.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Pn_Filtros.Location = New System.Drawing.Point(0, 113)
        Me.Pn_Filtros.Name = "Pn_Filtros"
        Me.Pn_Filtros.RowCount = 10
        Me.Pn_Filtros.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.Pn_Filtros.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.Pn_Filtros.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.Pn_Filtros.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.Pn_Filtros.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.Pn_Filtros.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.Pn_Filtros.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.Pn_Filtros.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.Pn_Filtros.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.Pn_Filtros.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 8.0!))
        Me.Pn_Filtros.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.Pn_Filtros.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.Pn_Filtros.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.Pn_Filtros.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.Pn_Filtros.Size = New System.Drawing.Size(358, 625)
        Me.Pn_Filtros.TabIndex = 26
        '
        'Pn_Especialidad
        '
        Me.Pn_Especialidad.AutoSize = True
        Me.Pn_Especialidad.Controls.Add(Me.Cb_Sushi)
        Me.Pn_Especialidad.Controls.Add(Me.Cb_Hamburguesas)
        Me.Pn_Especialidad.Controls.Add(Me.Cb_Emparedados)
        Me.Pn_Especialidad.Controls.Add(Me.Cb_Pollo)
        Me.Pn_Especialidad.Controls.Add(Me.Cb_Mariscos)
        Me.Pn_Especialidad.Controls.Add(Me.Cb_Carnes)
        Me.Pn_Especialidad.Controls.Add(Me.Lbl_Sushi)
        Me.Pn_Especialidad.Controls.Add(Me.Lbl_Hamburguesas)
        Me.Pn_Especialidad.Controls.Add(Me.Lbl_Emparedados)
        Me.Pn_Especialidad.Controls.Add(Me.Lbl_Pollo)
        Me.Pn_Especialidad.Controls.Add(Me.Lbl_Carnes)
        Me.Pn_Especialidad.Controls.Add(Me.Lbl_Mariscos)
        Me.Pn_Especialidad.Controls.Add(Me.BunifuCustomLabel31)
        Me.SideMenuHideAnimator.SetDecoration(Me.Pn_Especialidad, BunifuAnimatorNS.DecorationType.None)
        Me.SideMenuAnimator.SetDecoration(Me.Pn_Especialidad, BunifuAnimatorNS.DecorationType.None)
        Me.SideMenuAnimator2.SetDecoration(Me.Pn_Especialidad, BunifuAnimatorNS.DecorationType.None)
        Me.LogoMenuAnimator.SetDecoration(Me.Pn_Especialidad, BunifuAnimatorNS.DecorationType.None)
        Me.Pn_Especialidad.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Pn_Especialidad.Location = New System.Drawing.Point(3, 744)
        Me.Pn_Especialidad.Name = "Pn_Especialidad"
        Me.Pn_Especialidad.Padding = New System.Windows.Forms.Padding(0, 0, 0, 10)
        Me.Pn_Especialidad.Size = New System.Drawing.Size(352, 233)
        Me.Pn_Especialidad.TabIndex = 28
        Me.Pn_Especialidad.Visible = False
        '
        'Cb_Sushi
        '
        Me.Cb_Sushi.BackColor = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(135, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.Cb_Sushi.ChechedOffColor = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(135, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.Cb_Sushi.Checked = False
        Me.Cb_Sushi.CheckedOnColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.Cb_Sushi.Cursor = System.Windows.Forms.Cursors.Hand
        Me.SideMenuAnimator2.SetDecoration(Me.Cb_Sushi, BunifuAnimatorNS.DecorationType.None)
        Me.SideMenuAnimator.SetDecoration(Me.Cb_Sushi, BunifuAnimatorNS.DecorationType.None)
        Me.LogoMenuAnimator.SetDecoration(Me.Cb_Sushi, BunifuAnimatorNS.DecorationType.None)
        Me.SideMenuHideAnimator.SetDecoration(Me.Cb_Sushi, BunifuAnimatorNS.DecorationType.None)
        Me.Cb_Sushi.ForeColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(31, Byte), Integer))
        Me.Cb_Sushi.Location = New System.Drawing.Point(71, 199)
        Me.Cb_Sushi.Name = "Cb_Sushi"
        Me.Cb_Sushi.Size = New System.Drawing.Size(20, 20)
        Me.Cb_Sushi.TabIndex = 40
        '
        'Cb_Hamburguesas
        '
        Me.Cb_Hamburguesas.BackColor = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(135, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.Cb_Hamburguesas.ChechedOffColor = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(135, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.Cb_Hamburguesas.Checked = False
        Me.Cb_Hamburguesas.CheckedOnColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.Cb_Hamburguesas.Cursor = System.Windows.Forms.Cursors.Hand
        Me.SideMenuAnimator2.SetDecoration(Me.Cb_Hamburguesas, BunifuAnimatorNS.DecorationType.None)
        Me.SideMenuAnimator.SetDecoration(Me.Cb_Hamburguesas, BunifuAnimatorNS.DecorationType.None)
        Me.LogoMenuAnimator.SetDecoration(Me.Cb_Hamburguesas, BunifuAnimatorNS.DecorationType.None)
        Me.SideMenuHideAnimator.SetDecoration(Me.Cb_Hamburguesas, BunifuAnimatorNS.DecorationType.None)
        Me.Cb_Hamburguesas.ForeColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(31, Byte), Integer))
        Me.Cb_Hamburguesas.Location = New System.Drawing.Point(71, 169)
        Me.Cb_Hamburguesas.Name = "Cb_Hamburguesas"
        Me.Cb_Hamburguesas.Size = New System.Drawing.Size(20, 20)
        Me.Cb_Hamburguesas.TabIndex = 39
        '
        'Cb_Emparedados
        '
        Me.Cb_Emparedados.BackColor = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(135, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.Cb_Emparedados.ChechedOffColor = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(135, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.Cb_Emparedados.Checked = False
        Me.Cb_Emparedados.CheckedOnColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.Cb_Emparedados.Cursor = System.Windows.Forms.Cursors.Hand
        Me.SideMenuAnimator2.SetDecoration(Me.Cb_Emparedados, BunifuAnimatorNS.DecorationType.None)
        Me.SideMenuAnimator.SetDecoration(Me.Cb_Emparedados, BunifuAnimatorNS.DecorationType.None)
        Me.LogoMenuAnimator.SetDecoration(Me.Cb_Emparedados, BunifuAnimatorNS.DecorationType.None)
        Me.SideMenuHideAnimator.SetDecoration(Me.Cb_Emparedados, BunifuAnimatorNS.DecorationType.None)
        Me.Cb_Emparedados.ForeColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(31, Byte), Integer))
        Me.Cb_Emparedados.Location = New System.Drawing.Point(71, 139)
        Me.Cb_Emparedados.Name = "Cb_Emparedados"
        Me.Cb_Emparedados.Size = New System.Drawing.Size(20, 20)
        Me.Cb_Emparedados.TabIndex = 38
        '
        'Cb_Pollo
        '
        Me.Cb_Pollo.BackColor = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(135, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.Cb_Pollo.ChechedOffColor = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(135, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.Cb_Pollo.Checked = False
        Me.Cb_Pollo.CheckedOnColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.Cb_Pollo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.SideMenuAnimator2.SetDecoration(Me.Cb_Pollo, BunifuAnimatorNS.DecorationType.None)
        Me.SideMenuAnimator.SetDecoration(Me.Cb_Pollo, BunifuAnimatorNS.DecorationType.None)
        Me.LogoMenuAnimator.SetDecoration(Me.Cb_Pollo, BunifuAnimatorNS.DecorationType.None)
        Me.SideMenuHideAnimator.SetDecoration(Me.Cb_Pollo, BunifuAnimatorNS.DecorationType.None)
        Me.Cb_Pollo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(31, Byte), Integer))
        Me.Cb_Pollo.Location = New System.Drawing.Point(71, 109)
        Me.Cb_Pollo.Name = "Cb_Pollo"
        Me.Cb_Pollo.Size = New System.Drawing.Size(20, 20)
        Me.Cb_Pollo.TabIndex = 37
        '
        'Cb_Mariscos
        '
        Me.Cb_Mariscos.BackColor = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(135, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.Cb_Mariscos.ChechedOffColor = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(135, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.Cb_Mariscos.Checked = False
        Me.Cb_Mariscos.CheckedOnColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.Cb_Mariscos.Cursor = System.Windows.Forms.Cursors.Hand
        Me.SideMenuAnimator2.SetDecoration(Me.Cb_Mariscos, BunifuAnimatorNS.DecorationType.None)
        Me.SideMenuAnimator.SetDecoration(Me.Cb_Mariscos, BunifuAnimatorNS.DecorationType.None)
        Me.LogoMenuAnimator.SetDecoration(Me.Cb_Mariscos, BunifuAnimatorNS.DecorationType.None)
        Me.SideMenuHideAnimator.SetDecoration(Me.Cb_Mariscos, BunifuAnimatorNS.DecorationType.None)
        Me.Cb_Mariscos.ForeColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(31, Byte), Integer))
        Me.Cb_Mariscos.Location = New System.Drawing.Point(71, 49)
        Me.Cb_Mariscos.Name = "Cb_Mariscos"
        Me.Cb_Mariscos.Size = New System.Drawing.Size(20, 20)
        Me.Cb_Mariscos.TabIndex = 35
        '
        'Cb_Carnes
        '
        Me.Cb_Carnes.BackColor = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(135, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.Cb_Carnes.ChechedOffColor = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(135, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.Cb_Carnes.Checked = False
        Me.Cb_Carnes.CheckedOnColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.Cb_Carnes.Cursor = System.Windows.Forms.Cursors.Hand
        Me.SideMenuAnimator2.SetDecoration(Me.Cb_Carnes, BunifuAnimatorNS.DecorationType.None)
        Me.SideMenuAnimator.SetDecoration(Me.Cb_Carnes, BunifuAnimatorNS.DecorationType.None)
        Me.LogoMenuAnimator.SetDecoration(Me.Cb_Carnes, BunifuAnimatorNS.DecorationType.None)
        Me.SideMenuHideAnimator.SetDecoration(Me.Cb_Carnes, BunifuAnimatorNS.DecorationType.None)
        Me.Cb_Carnes.ForeColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(31, Byte), Integer))
        Me.Cb_Carnes.Location = New System.Drawing.Point(71, 79)
        Me.Cb_Carnes.Name = "Cb_Carnes"
        Me.Cb_Carnes.Size = New System.Drawing.Size(20, 20)
        Me.Cb_Carnes.TabIndex = 36
        '
        'Lbl_Sushi
        '
        Me.Lbl_Sushi.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Lbl_Sushi.AutoSize = True
        Me.SideMenuAnimator2.SetDecoration(Me.Lbl_Sushi, BunifuAnimatorNS.DecorationType.None)
        Me.SideMenuAnimator.SetDecoration(Me.Lbl_Sushi, BunifuAnimatorNS.DecorationType.None)
        Me.LogoMenuAnimator.SetDecoration(Me.Lbl_Sushi, BunifuAnimatorNS.DecorationType.None)
        Me.SideMenuHideAnimator.SetDecoration(Me.Lbl_Sushi, BunifuAnimatorNS.DecorationType.None)
        Me.Lbl_Sushi.Font = New System.Drawing.Font("Open Sans", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Sushi.ForeColor = System.Drawing.Color.FromArgb(CType(CType(232, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.Lbl_Sushi.Location = New System.Drawing.Point(123, 195)
        Me.Lbl_Sushi.Name = "Lbl_Sushi"
        Me.Lbl_Sushi.Size = New System.Drawing.Size(65, 28)
        Me.Lbl_Sushi.TabIndex = 33
        Me.Lbl_Sushi.Text = "Sushi"
        '
        'Lbl_Hamburguesas
        '
        Me.Lbl_Hamburguesas.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Lbl_Hamburguesas.AutoSize = True
        Me.SideMenuAnimator2.SetDecoration(Me.Lbl_Hamburguesas, BunifuAnimatorNS.DecorationType.None)
        Me.SideMenuAnimator.SetDecoration(Me.Lbl_Hamburguesas, BunifuAnimatorNS.DecorationType.None)
        Me.LogoMenuAnimator.SetDecoration(Me.Lbl_Hamburguesas, BunifuAnimatorNS.DecorationType.None)
        Me.SideMenuHideAnimator.SetDecoration(Me.Lbl_Hamburguesas, BunifuAnimatorNS.DecorationType.None)
        Me.Lbl_Hamburguesas.Font = New System.Drawing.Font("Open Sans", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Hamburguesas.ForeColor = System.Drawing.Color.FromArgb(CType(CType(232, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.Lbl_Hamburguesas.Location = New System.Drawing.Point(123, 165)
        Me.Lbl_Hamburguesas.Name = "Lbl_Hamburguesas"
        Me.Lbl_Hamburguesas.Size = New System.Drawing.Size(163, 28)
        Me.Lbl_Hamburguesas.TabIndex = 31
        Me.Lbl_Hamburguesas.Text = "Hamburguesas"
        '
        'Lbl_Emparedados
        '
        Me.Lbl_Emparedados.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Lbl_Emparedados.AutoSize = True
        Me.SideMenuAnimator2.SetDecoration(Me.Lbl_Emparedados, BunifuAnimatorNS.DecorationType.None)
        Me.SideMenuAnimator.SetDecoration(Me.Lbl_Emparedados, BunifuAnimatorNS.DecorationType.None)
        Me.LogoMenuAnimator.SetDecoration(Me.Lbl_Emparedados, BunifuAnimatorNS.DecorationType.None)
        Me.SideMenuHideAnimator.SetDecoration(Me.Lbl_Emparedados, BunifuAnimatorNS.DecorationType.None)
        Me.Lbl_Emparedados.Font = New System.Drawing.Font("Open Sans", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Emparedados.ForeColor = System.Drawing.Color.FromArgb(CType(CType(232, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.Lbl_Emparedados.Location = New System.Drawing.Point(123, 135)
        Me.Lbl_Emparedados.Name = "Lbl_Emparedados"
        Me.Lbl_Emparedados.Size = New System.Drawing.Size(151, 28)
        Me.Lbl_Emparedados.TabIndex = 29
        Me.Lbl_Emparedados.Text = "Emparedados"
        '
        'Lbl_Pollo
        '
        Me.Lbl_Pollo.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Lbl_Pollo.AutoSize = True
        Me.SideMenuAnimator2.SetDecoration(Me.Lbl_Pollo, BunifuAnimatorNS.DecorationType.None)
        Me.SideMenuAnimator.SetDecoration(Me.Lbl_Pollo, BunifuAnimatorNS.DecorationType.None)
        Me.LogoMenuAnimator.SetDecoration(Me.Lbl_Pollo, BunifuAnimatorNS.DecorationType.None)
        Me.SideMenuHideAnimator.SetDecoration(Me.Lbl_Pollo, BunifuAnimatorNS.DecorationType.None)
        Me.Lbl_Pollo.Font = New System.Drawing.Font("Open Sans", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Pollo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(232, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.Lbl_Pollo.Location = New System.Drawing.Point(123, 105)
        Me.Lbl_Pollo.Name = "Lbl_Pollo"
        Me.Lbl_Pollo.Size = New System.Drawing.Size(61, 28)
        Me.Lbl_Pollo.TabIndex = 27
        Me.Lbl_Pollo.Text = "Pollo"
        '
        'Lbl_Carnes
        '
        Me.Lbl_Carnes.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Lbl_Carnes.AutoSize = True
        Me.SideMenuAnimator2.SetDecoration(Me.Lbl_Carnes, BunifuAnimatorNS.DecorationType.None)
        Me.SideMenuAnimator.SetDecoration(Me.Lbl_Carnes, BunifuAnimatorNS.DecorationType.None)
        Me.LogoMenuAnimator.SetDecoration(Me.Lbl_Carnes, BunifuAnimatorNS.DecorationType.None)
        Me.SideMenuHideAnimator.SetDecoration(Me.Lbl_Carnes, BunifuAnimatorNS.DecorationType.None)
        Me.Lbl_Carnes.Font = New System.Drawing.Font("Open Sans", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Carnes.ForeColor = System.Drawing.Color.FromArgb(CType(CType(232, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.Lbl_Carnes.Location = New System.Drawing.Point(123, 75)
        Me.Lbl_Carnes.Name = "Lbl_Carnes"
        Me.Lbl_Carnes.Size = New System.Drawing.Size(81, 28)
        Me.Lbl_Carnes.TabIndex = 25
        Me.Lbl_Carnes.Text = "Carnes"
        '
        'Lbl_Mariscos
        '
        Me.Lbl_Mariscos.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Lbl_Mariscos.AutoSize = True
        Me.SideMenuAnimator2.SetDecoration(Me.Lbl_Mariscos, BunifuAnimatorNS.DecorationType.None)
        Me.SideMenuAnimator.SetDecoration(Me.Lbl_Mariscos, BunifuAnimatorNS.DecorationType.None)
        Me.LogoMenuAnimator.SetDecoration(Me.Lbl_Mariscos, BunifuAnimatorNS.DecorationType.None)
        Me.SideMenuHideAnimator.SetDecoration(Me.Lbl_Mariscos, BunifuAnimatorNS.DecorationType.None)
        Me.Lbl_Mariscos.Font = New System.Drawing.Font("Open Sans", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Mariscos.ForeColor = System.Drawing.Color.FromArgb(CType(CType(232, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.Lbl_Mariscos.Location = New System.Drawing.Point(123, 45)
        Me.Lbl_Mariscos.Name = "Lbl_Mariscos"
        Me.Lbl_Mariscos.Size = New System.Drawing.Size(100, 28)
        Me.Lbl_Mariscos.TabIndex = 23
        Me.Lbl_Mariscos.Text = "Mariscos"
        '
        'BunifuCustomLabel31
        '
        Me.BunifuCustomLabel31.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.BunifuCustomLabel31.AutoSize = True
        Me.SideMenuAnimator2.SetDecoration(Me.BunifuCustomLabel31, BunifuAnimatorNS.DecorationType.None)
        Me.SideMenuAnimator.SetDecoration(Me.BunifuCustomLabel31, BunifuAnimatorNS.DecorationType.None)
        Me.LogoMenuAnimator.SetDecoration(Me.BunifuCustomLabel31, BunifuAnimatorNS.DecorationType.None)
        Me.SideMenuHideAnimator.SetDecoration(Me.BunifuCustomLabel31, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuCustomLabel31.Font = New System.Drawing.Font("Open Sans Semibold", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel31.ForeColor = System.Drawing.Color.FromArgb(CType(CType(232, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.BunifuCustomLabel31.Location = New System.Drawing.Point(36, 3)
        Me.BunifuCustomLabel31.Name = "BunifuCustomLabel31"
        Me.BunifuCustomLabel31.Size = New System.Drawing.Size(143, 28)
        Me.BunifuCustomLabel31.TabIndex = 18
        Me.BunifuCustomLabel31.Text = "Especialidad:"
        '
        'Pn_Disponibilidad
        '
        Me.Pn_Disponibilidad.AutoSize = True
        Me.Pn_Disponibilidad.Controls.Add(Me.Lbl_Abierto2)
        Me.Pn_Disponibilidad.Controls.Add(Me.Lbl_Abierto1)
        Me.Pn_Disponibilidad.Controls.Add(Me.Cb_Abierto)
        Me.Pn_Disponibilidad.Controls.Add(Me.BunifuCustomLabel22)
        Me.SideMenuHideAnimator.SetDecoration(Me.Pn_Disponibilidad, BunifuAnimatorNS.DecorationType.None)
        Me.SideMenuAnimator.SetDecoration(Me.Pn_Disponibilidad, BunifuAnimatorNS.DecorationType.None)
        Me.SideMenuAnimator2.SetDecoration(Me.Pn_Disponibilidad, BunifuAnimatorNS.DecorationType.None)
        Me.LogoMenuAnimator.SetDecoration(Me.Pn_Disponibilidad, BunifuAnimatorNS.DecorationType.None)
        Me.Pn_Disponibilidad.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Pn_Disponibilidad.Location = New System.Drawing.Point(3, 492)
        Me.Pn_Disponibilidad.Name = "Pn_Disponibilidad"
        Me.Pn_Disponibilidad.Padding = New System.Windows.Forms.Padding(0, 0, 0, 10)
        Me.Pn_Disponibilidad.Size = New System.Drawing.Size(352, 105)
        Me.Pn_Disponibilidad.TabIndex = 26
        Me.Pn_Disponibilidad.Visible = False
        '
        'Lbl_Abierto2
        '
        Me.Lbl_Abierto2.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Lbl_Abierto2.AutoSize = True
        Me.SideMenuAnimator2.SetDecoration(Me.Lbl_Abierto2, BunifuAnimatorNS.DecorationType.None)
        Me.SideMenuAnimator.SetDecoration(Me.Lbl_Abierto2, BunifuAnimatorNS.DecorationType.None)
        Me.LogoMenuAnimator.SetDecoration(Me.Lbl_Abierto2, BunifuAnimatorNS.DecorationType.None)
        Me.SideMenuHideAnimator.SetDecoration(Me.Lbl_Abierto2, BunifuAnimatorNS.DecorationType.None)
        Me.Lbl_Abierto2.Font = New System.Drawing.Font("Open Sans", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Abierto2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(232, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.Lbl_Abierto2.Location = New System.Drawing.Point(122, 67)
        Me.Lbl_Abierto2.Name = "Lbl_Abierto2"
        Me.Lbl_Abierto2.Size = New System.Drawing.Size(110, 28)
        Me.Lbl_Abierto2.TabIndex = 19
        Me.Lbl_Abierto2.Text = "momento"
        '
        'Lbl_Abierto1
        '
        Me.Lbl_Abierto1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Lbl_Abierto1.AutoSize = True
        Me.SideMenuAnimator2.SetDecoration(Me.Lbl_Abierto1, BunifuAnimatorNS.DecorationType.None)
        Me.SideMenuAnimator.SetDecoration(Me.Lbl_Abierto1, BunifuAnimatorNS.DecorationType.None)
        Me.LogoMenuAnimator.SetDecoration(Me.Lbl_Abierto1, BunifuAnimatorNS.DecorationType.None)
        Me.SideMenuHideAnimator.SetDecoration(Me.Lbl_Abierto1, BunifuAnimatorNS.DecorationType.None)
        Me.Lbl_Abierto1.Font = New System.Drawing.Font("Open Sans", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Abierto1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(232, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.Lbl_Abierto1.Location = New System.Drawing.Point(121, 39)
        Me.Lbl_Abierto1.Name = "Lbl_Abierto1"
        Me.Lbl_Abierto1.Size = New System.Drawing.Size(160, 28)
        Me.Lbl_Abierto1.TabIndex = 10
        Me.Lbl_Abierto1.Text = "Abierto en este"
        '
        'Cb_Abierto
        '
        Me.Cb_Abierto.BackColor = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(135, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.Cb_Abierto.ChechedOffColor = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(135, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.Cb_Abierto.Checked = False
        Me.Cb_Abierto.CheckedOnColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.Cb_Abierto.Cursor = System.Windows.Forms.Cursors.Hand
        Me.SideMenuAnimator2.SetDecoration(Me.Cb_Abierto, BunifuAnimatorNS.DecorationType.None)
        Me.SideMenuAnimator.SetDecoration(Me.Cb_Abierto, BunifuAnimatorNS.DecorationType.None)
        Me.LogoMenuAnimator.SetDecoration(Me.Cb_Abierto, BunifuAnimatorNS.DecorationType.None)
        Me.SideMenuHideAnimator.SetDecoration(Me.Cb_Abierto, BunifuAnimatorNS.DecorationType.None)
        Me.Cb_Abierto.ForeColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(31, Byte), Integer))
        Me.Cb_Abierto.Location = New System.Drawing.Point(69, 45)
        Me.Cb_Abierto.Name = "Cb_Abierto"
        Me.Cb_Abierto.Size = New System.Drawing.Size(20, 20)
        Me.Cb_Abierto.TabIndex = 11
        '
        'BunifuCustomLabel22
        '
        Me.BunifuCustomLabel22.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.BunifuCustomLabel22.AutoSize = True
        Me.SideMenuAnimator2.SetDecoration(Me.BunifuCustomLabel22, BunifuAnimatorNS.DecorationType.None)
        Me.SideMenuAnimator.SetDecoration(Me.BunifuCustomLabel22, BunifuAnimatorNS.DecorationType.None)
        Me.LogoMenuAnimator.SetDecoration(Me.BunifuCustomLabel22, BunifuAnimatorNS.DecorationType.None)
        Me.SideMenuHideAnimator.SetDecoration(Me.BunifuCustomLabel22, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuCustomLabel22.Font = New System.Drawing.Font("Open Sans Semibold", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel22.ForeColor = System.Drawing.Color.FromArgb(CType(CType(232, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.BunifuCustomLabel22.Location = New System.Drawing.Point(36, 3)
        Me.BunifuCustomLabel22.Name = "BunifuCustomLabel22"
        Me.BunifuCustomLabel22.Size = New System.Drawing.Size(163, 28)
        Me.BunifuCustomLabel22.TabIndex = 18
        Me.BunifuCustomLabel22.Text = "Disponibilidad:"
        '
        'Pn_TipoDeRestaurante
        '
        Me.Pn_TipoDeRestaurante.AutoSize = True
        Me.Pn_TipoDeRestaurante.Controls.Add(Me.Lbl_ComidaRapida)
        Me.Pn_TipoDeRestaurante.Controls.Add(Me.Cb_ComidaRapida)
        Me.Pn_TipoDeRestaurante.Controls.Add(Me.Lbl_Familiar)
        Me.Pn_TipoDeRestaurante.Controls.Add(Me.Cb_Familiar)
        Me.Pn_TipoDeRestaurante.Controls.Add(Me.Cb_Tematico)
        Me.Pn_TipoDeRestaurante.Controls.Add(Me.BunifuCustomLabel9)
        Me.Pn_TipoDeRestaurante.Controls.Add(Me.Lbl_Tematico)
        Me.Pn_TipoDeRestaurante.Cursor = System.Windows.Forms.Cursors.Hand
        Me.SideMenuHideAnimator.SetDecoration(Me.Pn_TipoDeRestaurante, BunifuAnimatorNS.DecorationType.None)
        Me.SideMenuAnimator.SetDecoration(Me.Pn_TipoDeRestaurante, BunifuAnimatorNS.DecorationType.None)
        Me.SideMenuAnimator2.SetDecoration(Me.Pn_TipoDeRestaurante, BunifuAnimatorNS.DecorationType.None)
        Me.LogoMenuAnimator.SetDecoration(Me.Pn_TipoDeRestaurante, BunifuAnimatorNS.DecorationType.None)
        Me.Pn_TipoDeRestaurante.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Pn_TipoDeRestaurante.ForeColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(31, Byte), Integer))
        Me.Pn_TipoDeRestaurante.Location = New System.Drawing.Point(3, 3)
        Me.Pn_TipoDeRestaurante.Name = "Pn_TipoDeRestaurante"
        Me.Pn_TipoDeRestaurante.Padding = New System.Windows.Forms.Padding(0, 0, 0, 10)
        Me.Pn_TipoDeRestaurante.Size = New System.Drawing.Size(352, 135)
        Me.Pn_TipoDeRestaurante.TabIndex = 23
        Me.Pn_TipoDeRestaurante.Visible = False
        '
        'Lbl_ComidaRapida
        '
        Me.Lbl_ComidaRapida.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Lbl_ComidaRapida.AutoSize = True
        Me.SideMenuAnimator2.SetDecoration(Me.Lbl_ComidaRapida, BunifuAnimatorNS.DecorationType.None)
        Me.SideMenuAnimator.SetDecoration(Me.Lbl_ComidaRapida, BunifuAnimatorNS.DecorationType.None)
        Me.LogoMenuAnimator.SetDecoration(Me.Lbl_ComidaRapida, BunifuAnimatorNS.DecorationType.None)
        Me.SideMenuHideAnimator.SetDecoration(Me.Lbl_ComidaRapida, BunifuAnimatorNS.DecorationType.None)
        Me.Lbl_ComidaRapida.Font = New System.Drawing.Font("Open Sans", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_ComidaRapida.ForeColor = System.Drawing.Color.FromArgb(CType(CType(232, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.Lbl_ComidaRapida.Location = New System.Drawing.Point(121, 41)
        Me.Lbl_ComidaRapida.Name = "Lbl_ComidaRapida"
        Me.Lbl_ComidaRapida.Size = New System.Drawing.Size(161, 28)
        Me.Lbl_ComidaRapida.TabIndex = 10
        Me.Lbl_ComidaRapida.Text = "Comida Rápida"
        '
        'Cb_ComidaRapida
        '
        Me.Cb_ComidaRapida.BackColor = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(135, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.Cb_ComidaRapida.ChechedOffColor = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(135, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.Cb_ComidaRapida.Checked = False
        Me.Cb_ComidaRapida.CheckedOnColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.Cb_ComidaRapida.Cursor = System.Windows.Forms.Cursors.Hand
        Me.SideMenuAnimator2.SetDecoration(Me.Cb_ComidaRapida, BunifuAnimatorNS.DecorationType.None)
        Me.SideMenuAnimator.SetDecoration(Me.Cb_ComidaRapida, BunifuAnimatorNS.DecorationType.None)
        Me.LogoMenuAnimator.SetDecoration(Me.Cb_ComidaRapida, BunifuAnimatorNS.DecorationType.None)
        Me.SideMenuHideAnimator.SetDecoration(Me.Cb_ComidaRapida, BunifuAnimatorNS.DecorationType.None)
        Me.Cb_ComidaRapida.ForeColor = System.Drawing.Color.Black
        Me.Cb_ComidaRapida.Location = New System.Drawing.Point(69, 45)
        Me.Cb_ComidaRapida.Name = "Cb_ComidaRapida"
        Me.Cb_ComidaRapida.Size = New System.Drawing.Size(20, 20)
        Me.Cb_ComidaRapida.TabIndex = 11
        '
        'Lbl_Familiar
        '
        Me.Lbl_Familiar.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Lbl_Familiar.AutoSize = True
        Me.SideMenuAnimator2.SetDecoration(Me.Lbl_Familiar, BunifuAnimatorNS.DecorationType.None)
        Me.SideMenuAnimator.SetDecoration(Me.Lbl_Familiar, BunifuAnimatorNS.DecorationType.None)
        Me.LogoMenuAnimator.SetDecoration(Me.Lbl_Familiar, BunifuAnimatorNS.DecorationType.None)
        Me.SideMenuHideAnimator.SetDecoration(Me.Lbl_Familiar, BunifuAnimatorNS.DecorationType.None)
        Me.Lbl_Familiar.Font = New System.Drawing.Font("Open Sans", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Familiar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(232, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.Lbl_Familiar.Location = New System.Drawing.Point(122, 69)
        Me.Lbl_Familiar.Name = "Lbl_Familiar"
        Me.Lbl_Familiar.Size = New System.Drawing.Size(91, 28)
        Me.Lbl_Familiar.TabIndex = 12
        Me.Lbl_Familiar.Text = "Familiar"
        '
        'Cb_Familiar
        '
        Me.Cb_Familiar.BackColor = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(135, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.Cb_Familiar.ChechedOffColor = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(135, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.Cb_Familiar.Checked = False
        Me.Cb_Familiar.CheckedOnColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.Cb_Familiar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.SideMenuAnimator2.SetDecoration(Me.Cb_Familiar, BunifuAnimatorNS.DecorationType.None)
        Me.SideMenuAnimator.SetDecoration(Me.Cb_Familiar, BunifuAnimatorNS.DecorationType.None)
        Me.LogoMenuAnimator.SetDecoration(Me.Cb_Familiar, BunifuAnimatorNS.DecorationType.None)
        Me.SideMenuHideAnimator.SetDecoration(Me.Cb_Familiar, BunifuAnimatorNS.DecorationType.None)
        Me.Cb_Familiar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(31, Byte), Integer))
        Me.Cb_Familiar.Location = New System.Drawing.Point(69, 73)
        Me.Cb_Familiar.Name = "Cb_Familiar"
        Me.Cb_Familiar.Size = New System.Drawing.Size(20, 20)
        Me.Cb_Familiar.TabIndex = 13
        '
        'Cb_Tematico
        '
        Me.Cb_Tematico.BackColor = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(135, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.Cb_Tematico.ChechedOffColor = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(135, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.Cb_Tematico.Checked = False
        Me.Cb_Tematico.CheckedOnColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.Cb_Tematico.Cursor = System.Windows.Forms.Cursors.Hand
        Me.SideMenuAnimator2.SetDecoration(Me.Cb_Tematico, BunifuAnimatorNS.DecorationType.None)
        Me.SideMenuAnimator.SetDecoration(Me.Cb_Tematico, BunifuAnimatorNS.DecorationType.None)
        Me.LogoMenuAnimator.SetDecoration(Me.Cb_Tematico, BunifuAnimatorNS.DecorationType.None)
        Me.SideMenuHideAnimator.SetDecoration(Me.Cb_Tematico, BunifuAnimatorNS.DecorationType.None)
        Me.Cb_Tematico.ForeColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(31, Byte), Integer))
        Me.Cb_Tematico.Location = New System.Drawing.Point(69, 101)
        Me.Cb_Tematico.Name = "Cb_Tematico"
        Me.Cb_Tematico.Size = New System.Drawing.Size(20, 20)
        Me.Cb_Tematico.TabIndex = 20
        '
        'BunifuCustomLabel9
        '
        Me.BunifuCustomLabel9.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.BunifuCustomLabel9.AutoSize = True
        Me.SideMenuAnimator2.SetDecoration(Me.BunifuCustomLabel9, BunifuAnimatorNS.DecorationType.None)
        Me.SideMenuAnimator.SetDecoration(Me.BunifuCustomLabel9, BunifuAnimatorNS.DecorationType.None)
        Me.LogoMenuAnimator.SetDecoration(Me.BunifuCustomLabel9, BunifuAnimatorNS.DecorationType.None)
        Me.SideMenuHideAnimator.SetDecoration(Me.BunifuCustomLabel9, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuCustomLabel9.Font = New System.Drawing.Font("Open Sans Semibold", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(232, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.BunifuCustomLabel9.Location = New System.Drawing.Point(36, 3)
        Me.BunifuCustomLabel9.Name = "BunifuCustomLabel9"
        Me.BunifuCustomLabel9.Size = New System.Drawing.Size(219, 28)
        Me.BunifuCustomLabel9.TabIndex = 18
        Me.BunifuCustomLabel9.Text = "Tipo de Restaurante:"
        '
        'Lbl_Tematico
        '
        Me.Lbl_Tematico.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Lbl_Tematico.AutoSize = True
        Me.SideMenuAnimator2.SetDecoration(Me.Lbl_Tematico, BunifuAnimatorNS.DecorationType.None)
        Me.SideMenuAnimator.SetDecoration(Me.Lbl_Tematico, BunifuAnimatorNS.DecorationType.None)
        Me.LogoMenuAnimator.SetDecoration(Me.Lbl_Tematico, BunifuAnimatorNS.DecorationType.None)
        Me.SideMenuHideAnimator.SetDecoration(Me.Lbl_Tematico, BunifuAnimatorNS.DecorationType.None)
        Me.Lbl_Tematico.Font = New System.Drawing.Font("Open Sans", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Tematico.ForeColor = System.Drawing.Color.FromArgb(CType(CType(232, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.Lbl_Tematico.Location = New System.Drawing.Point(123, 97)
        Me.Lbl_Tematico.Name = "Lbl_Tematico"
        Me.Lbl_Tematico.Size = New System.Drawing.Size(103, 28)
        Me.Lbl_Tematico.TabIndex = 19
        Me.Lbl_Tematico.Text = "Temático"
        '
        'Pn_Presupuesto
        '
        Me.Pn_Presupuesto.AutoSize = True
        Me.Pn_Presupuesto.Controls.Add(Me.Lbl_ValorPresupuesto)
        Me.Pn_Presupuesto.Controls.Add(Me.Slider_Presupuesto)
        Me.Pn_Presupuesto.Controls.Add(Me.BunifuCustomLabel18)
        Me.Pn_Presupuesto.Controls.Add(Me.Lbl_Presupuesto)
        Me.SideMenuHideAnimator.SetDecoration(Me.Pn_Presupuesto, BunifuAnimatorNS.DecorationType.None)
        Me.SideMenuAnimator.SetDecoration(Me.Pn_Presupuesto, BunifuAnimatorNS.DecorationType.None)
        Me.SideMenuAnimator2.SetDecoration(Me.Pn_Presupuesto, BunifuAnimatorNS.DecorationType.None)
        Me.LogoMenuAnimator.SetDecoration(Me.Pn_Presupuesto, BunifuAnimatorNS.DecorationType.None)
        Me.Pn_Presupuesto.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Pn_Presupuesto.Location = New System.Drawing.Point(3, 144)
        Me.Pn_Presupuesto.Name = "Pn_Presupuesto"
        Me.Pn_Presupuesto.Padding = New System.Windows.Forms.Padding(0, 0, 0, 10)
        Me.Pn_Presupuesto.Size = New System.Drawing.Size(352, 116)
        Me.Pn_Presupuesto.TabIndex = 24
        Me.Pn_Presupuesto.Visible = False
        '
        'Lbl_ValorPresupuesto
        '
        Me.Lbl_ValorPresupuesto.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Lbl_ValorPresupuesto.AutoSize = True
        Me.SideMenuAnimator2.SetDecoration(Me.Lbl_ValorPresupuesto, BunifuAnimatorNS.DecorationType.None)
        Me.SideMenuAnimator.SetDecoration(Me.Lbl_ValorPresupuesto, BunifuAnimatorNS.DecorationType.None)
        Me.LogoMenuAnimator.SetDecoration(Me.Lbl_ValorPresupuesto, BunifuAnimatorNS.DecorationType.None)
        Me.SideMenuHideAnimator.SetDecoration(Me.Lbl_ValorPresupuesto, BunifuAnimatorNS.DecorationType.None)
        Me.Lbl_ValorPresupuesto.Font = New System.Drawing.Font("Open Sans", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_ValorPresupuesto.ForeColor = System.Drawing.Color.FromArgb(CType(CType(232, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.Lbl_ValorPresupuesto.Location = New System.Drawing.Point(95, 42)
        Me.Lbl_ValorPresupuesto.Name = "Lbl_ValorPresupuesto"
        Me.Lbl_ValorPresupuesto.Size = New System.Drawing.Size(24, 28)
        Me.Lbl_ValorPresupuesto.TabIndex = 21
        Me.Lbl_ValorPresupuesto.Text = "1"
        '
        'Slider_Presupuesto
        '
        Me.Slider_Presupuesto.BackColor = System.Drawing.Color.Transparent
        Me.Slider_Presupuesto.BackgroudColor = System.Drawing.Color.DarkGray
        Me.Slider_Presupuesto.BorderRadius = 0
        Me.Slider_Presupuesto.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LogoMenuAnimator.SetDecoration(Me.Slider_Presupuesto, BunifuAnimatorNS.DecorationType.None)
        Me.SideMenuAnimator.SetDecoration(Me.Slider_Presupuesto, BunifuAnimatorNS.DecorationType.None)
        Me.SideMenuHideAnimator.SetDecoration(Me.Slider_Presupuesto, BunifuAnimatorNS.DecorationType.None)
        Me.SideMenuAnimator2.SetDecoration(Me.Slider_Presupuesto, BunifuAnimatorNS.DecorationType.None)
        Me.Slider_Presupuesto.IndicatorColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.Slider_Presupuesto.Location = New System.Drawing.Point(69, 73)
        Me.Slider_Presupuesto.MaximumValue = 100
        Me.Slider_Presupuesto.Name = "Slider_Presupuesto"
        Me.Slider_Presupuesto.Size = New System.Drawing.Size(219, 30)
        Me.Slider_Presupuesto.TabIndex = 20
        Me.Slider_Presupuesto.Value = 1
        '
        'BunifuCustomLabel18
        '
        Me.BunifuCustomLabel18.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.BunifuCustomLabel18.AutoSize = True
        Me.SideMenuAnimator2.SetDecoration(Me.BunifuCustomLabel18, BunifuAnimatorNS.DecorationType.None)
        Me.SideMenuAnimator.SetDecoration(Me.BunifuCustomLabel18, BunifuAnimatorNS.DecorationType.None)
        Me.LogoMenuAnimator.SetDecoration(Me.BunifuCustomLabel18, BunifuAnimatorNS.DecorationType.None)
        Me.SideMenuHideAnimator.SetDecoration(Me.BunifuCustomLabel18, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuCustomLabel18.Font = New System.Drawing.Font("Open Sans", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel18.ForeColor = System.Drawing.Color.FromArgb(CType(CType(232, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.BunifuCustomLabel18.Location = New System.Drawing.Point(64, 42)
        Me.BunifuCustomLabel18.Name = "BunifuCustomLabel18"
        Me.BunifuCustomLabel18.Size = New System.Drawing.Size(40, 28)
        Me.BunifuCustomLabel18.TabIndex = 19
        Me.BunifuCustomLabel18.Text = "B/."
        '
        'Lbl_Presupuesto
        '
        Me.Lbl_Presupuesto.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Lbl_Presupuesto.AutoSize = True
        Me.SideMenuAnimator2.SetDecoration(Me.Lbl_Presupuesto, BunifuAnimatorNS.DecorationType.None)
        Me.SideMenuAnimator.SetDecoration(Me.Lbl_Presupuesto, BunifuAnimatorNS.DecorationType.None)
        Me.LogoMenuAnimator.SetDecoration(Me.Lbl_Presupuesto, BunifuAnimatorNS.DecorationType.None)
        Me.SideMenuHideAnimator.SetDecoration(Me.Lbl_Presupuesto, BunifuAnimatorNS.DecorationType.None)
        Me.Lbl_Presupuesto.Font = New System.Drawing.Font("Open Sans Semibold", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Presupuesto.ForeColor = System.Drawing.Color.FromArgb(CType(CType(232, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.Lbl_Presupuesto.Location = New System.Drawing.Point(36, 3)
        Me.Lbl_Presupuesto.Name = "Lbl_Presupuesto"
        Me.Lbl_Presupuesto.Size = New System.Drawing.Size(144, 28)
        Me.Lbl_Presupuesto.TabIndex = 18
        Me.Lbl_Presupuesto.Text = "Presupuesto:"
        '
        'Pn_TipoDeDespacho
        '
        Me.Pn_TipoDeDespacho.AutoSize = True
        Me.Pn_TipoDeDespacho.Controls.Add(Me.Lbl_EntregaADomicilio)
        Me.Pn_TipoDeDespacho.Controls.Add(Me.Cb_EntregaDomicilio)
        Me.Pn_TipoDeDespacho.Controls.Add(Me.Lbl_EntregaLocal)
        Me.Pn_TipoDeDespacho.Controls.Add(Me.Cb_EntregaLocal)
        Me.Pn_TipoDeDespacho.Controls.Add(Me.BunifuCustomLabel19)
        Me.Pn_TipoDeDespacho.Cursor = System.Windows.Forms.Cursors.Hand
        Me.SideMenuHideAnimator.SetDecoration(Me.Pn_TipoDeDespacho, BunifuAnimatorNS.DecorationType.None)
        Me.SideMenuAnimator.SetDecoration(Me.Pn_TipoDeDespacho, BunifuAnimatorNS.DecorationType.None)
        Me.SideMenuAnimator2.SetDecoration(Me.Pn_TipoDeDespacho, BunifuAnimatorNS.DecorationType.None)
        Me.LogoMenuAnimator.SetDecoration(Me.Pn_TipoDeDespacho, BunifuAnimatorNS.DecorationType.None)
        Me.Pn_TipoDeDespacho.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Pn_TipoDeDespacho.Location = New System.Drawing.Point(3, 266)
        Me.Pn_TipoDeDespacho.Name = "Pn_TipoDeDespacho"
        Me.Pn_TipoDeDespacho.Padding = New System.Windows.Forms.Padding(0, 0, 0, 10)
        Me.Pn_TipoDeDespacho.Size = New System.Drawing.Size(352, 107)
        Me.Pn_TipoDeDespacho.TabIndex = 24
        Me.Pn_TipoDeDespacho.Visible = False
        '
        'Lbl_EntregaADomicilio
        '
        Me.Lbl_EntregaADomicilio.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Lbl_EntregaADomicilio.AutoSize = True
        Me.SideMenuAnimator2.SetDecoration(Me.Lbl_EntregaADomicilio, BunifuAnimatorNS.DecorationType.None)
        Me.SideMenuAnimator.SetDecoration(Me.Lbl_EntregaADomicilio, BunifuAnimatorNS.DecorationType.None)
        Me.LogoMenuAnimator.SetDecoration(Me.Lbl_EntregaADomicilio, BunifuAnimatorNS.DecorationType.None)
        Me.SideMenuHideAnimator.SetDecoration(Me.Lbl_EntregaADomicilio, BunifuAnimatorNS.DecorationType.None)
        Me.Lbl_EntregaADomicilio.Font = New System.Drawing.Font("Open Sans", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_EntregaADomicilio.ForeColor = System.Drawing.Color.FromArgb(CType(CType(232, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.Lbl_EntregaADomicilio.Location = New System.Drawing.Point(121, 41)
        Me.Lbl_EntregaADomicilio.Name = "Lbl_EntregaADomicilio"
        Me.Lbl_EntregaADomicilio.Size = New System.Drawing.Size(200, 28)
        Me.Lbl_EntregaADomicilio.TabIndex = 10
        Me.Lbl_EntregaADomicilio.Text = "Entrega a domicilio"
        '
        'Cb_EntregaDomicilio
        '
        Me.Cb_EntregaDomicilio.BackColor = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(135, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.Cb_EntregaDomicilio.ChechedOffColor = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(135, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.Cb_EntregaDomicilio.Checked = False
        Me.Cb_EntregaDomicilio.CheckedOnColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.Cb_EntregaDomicilio.Cursor = System.Windows.Forms.Cursors.Hand
        Me.SideMenuAnimator2.SetDecoration(Me.Cb_EntregaDomicilio, BunifuAnimatorNS.DecorationType.None)
        Me.SideMenuAnimator.SetDecoration(Me.Cb_EntregaDomicilio, BunifuAnimatorNS.DecorationType.None)
        Me.LogoMenuAnimator.SetDecoration(Me.Cb_EntregaDomicilio, BunifuAnimatorNS.DecorationType.None)
        Me.SideMenuHideAnimator.SetDecoration(Me.Cb_EntregaDomicilio, BunifuAnimatorNS.DecorationType.None)
        Me.Cb_EntregaDomicilio.ForeColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(31, Byte), Integer))
        Me.Cb_EntregaDomicilio.Location = New System.Drawing.Point(69, 45)
        Me.Cb_EntregaDomicilio.Name = "Cb_EntregaDomicilio"
        Me.Cb_EntregaDomicilio.Size = New System.Drawing.Size(20, 20)
        Me.Cb_EntregaDomicilio.TabIndex = 11
        '
        'Lbl_EntregaLocal
        '
        Me.Lbl_EntregaLocal.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Lbl_EntregaLocal.AutoSize = True
        Me.SideMenuAnimator2.SetDecoration(Me.Lbl_EntregaLocal, BunifuAnimatorNS.DecorationType.None)
        Me.SideMenuAnimator.SetDecoration(Me.Lbl_EntregaLocal, BunifuAnimatorNS.DecorationType.None)
        Me.LogoMenuAnimator.SetDecoration(Me.Lbl_EntregaLocal, BunifuAnimatorNS.DecorationType.None)
        Me.SideMenuHideAnimator.SetDecoration(Me.Lbl_EntregaLocal, BunifuAnimatorNS.DecorationType.None)
        Me.Lbl_EntregaLocal.Font = New System.Drawing.Font("Open Sans", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_EntregaLocal.ForeColor = System.Drawing.Color.FromArgb(CType(CType(232, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.Lbl_EntregaLocal.Location = New System.Drawing.Point(122, 69)
        Me.Lbl_EntregaLocal.Name = "Lbl_EntregaLocal"
        Me.Lbl_EntregaLocal.Size = New System.Drawing.Size(173, 28)
        Me.Lbl_EntregaLocal.TabIndex = 12
        Me.Lbl_EntregaLocal.Text = "Retiro en el local"
        '
        'Cb_EntregaLocal
        '
        Me.Cb_EntregaLocal.BackColor = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(135, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.Cb_EntregaLocal.ChechedOffColor = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(135, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.Cb_EntregaLocal.Checked = False
        Me.Cb_EntregaLocal.CheckedOnColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.Cb_EntregaLocal.Cursor = System.Windows.Forms.Cursors.Hand
        Me.SideMenuAnimator2.SetDecoration(Me.Cb_EntregaLocal, BunifuAnimatorNS.DecorationType.None)
        Me.SideMenuAnimator.SetDecoration(Me.Cb_EntregaLocal, BunifuAnimatorNS.DecorationType.None)
        Me.LogoMenuAnimator.SetDecoration(Me.Cb_EntregaLocal, BunifuAnimatorNS.DecorationType.None)
        Me.SideMenuHideAnimator.SetDecoration(Me.Cb_EntregaLocal, BunifuAnimatorNS.DecorationType.None)
        Me.Cb_EntregaLocal.ForeColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(31, Byte), Integer))
        Me.Cb_EntregaLocal.Location = New System.Drawing.Point(69, 73)
        Me.Cb_EntregaLocal.Name = "Cb_EntregaLocal"
        Me.Cb_EntregaLocal.Size = New System.Drawing.Size(20, 20)
        Me.Cb_EntregaLocal.TabIndex = 13
        '
        'BunifuCustomLabel19
        '
        Me.BunifuCustomLabel19.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.BunifuCustomLabel19.AutoSize = True
        Me.SideMenuAnimator2.SetDecoration(Me.BunifuCustomLabel19, BunifuAnimatorNS.DecorationType.None)
        Me.SideMenuAnimator.SetDecoration(Me.BunifuCustomLabel19, BunifuAnimatorNS.DecorationType.None)
        Me.LogoMenuAnimator.SetDecoration(Me.BunifuCustomLabel19, BunifuAnimatorNS.DecorationType.None)
        Me.SideMenuHideAnimator.SetDecoration(Me.BunifuCustomLabel19, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuCustomLabel19.Font = New System.Drawing.Font("Open Sans Semibold", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel19.ForeColor = System.Drawing.Color.FromArgb(CType(CType(232, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.BunifuCustomLabel19.Location = New System.Drawing.Point(36, 0)
        Me.BunifuCustomLabel19.Name = "BunifuCustomLabel19"
        Me.BunifuCustomLabel19.Size = New System.Drawing.Size(195, 28)
        Me.BunifuCustomLabel19.TabIndex = 18
        Me.BunifuCustomLabel19.Text = "Tipo de Despacho:"
        '
        'Pn_FormaDePago
        '
        Me.Pn_FormaDePago.AutoSize = True
        Me.Pn_FormaDePago.Controls.Add(Me.Lbl_TargetaCredito)
        Me.Pn_FormaDePago.Controls.Add(Me.Cb_TargetaCredito)
        Me.Pn_FormaDePago.Controls.Add(Me.Lbl_Efectivo)
        Me.Pn_FormaDePago.Controls.Add(Me.Cb_Efectivo)
        Me.Pn_FormaDePago.Controls.Add(Me.Lbl_FormasDePago)
        Me.Pn_FormaDePago.Cursor = System.Windows.Forms.Cursors.Hand
        Me.SideMenuHideAnimator.SetDecoration(Me.Pn_FormaDePago, BunifuAnimatorNS.DecorationType.None)
        Me.SideMenuAnimator.SetDecoration(Me.Pn_FormaDePago, BunifuAnimatorNS.DecorationType.None)
        Me.SideMenuAnimator2.SetDecoration(Me.Pn_FormaDePago, BunifuAnimatorNS.DecorationType.None)
        Me.LogoMenuAnimator.SetDecoration(Me.Pn_FormaDePago, BunifuAnimatorNS.DecorationType.None)
        Me.Pn_FormaDePago.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Pn_FormaDePago.Location = New System.Drawing.Point(3, 379)
        Me.Pn_FormaDePago.Name = "Pn_FormaDePago"
        Me.Pn_FormaDePago.Padding = New System.Windows.Forms.Padding(0, 0, 0, 10)
        Me.Pn_FormaDePago.Size = New System.Drawing.Size(352, 107)
        Me.Pn_FormaDePago.TabIndex = 25
        Me.Pn_FormaDePago.Visible = False
        '
        'Lbl_TargetaCredito
        '
        Me.Lbl_TargetaCredito.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Lbl_TargetaCredito.AutoSize = True
        Me.SideMenuAnimator2.SetDecoration(Me.Lbl_TargetaCredito, BunifuAnimatorNS.DecorationType.None)
        Me.SideMenuAnimator.SetDecoration(Me.Lbl_TargetaCredito, BunifuAnimatorNS.DecorationType.None)
        Me.LogoMenuAnimator.SetDecoration(Me.Lbl_TargetaCredito, BunifuAnimatorNS.DecorationType.None)
        Me.SideMenuHideAnimator.SetDecoration(Me.Lbl_TargetaCredito, BunifuAnimatorNS.DecorationType.None)
        Me.Lbl_TargetaCredito.Font = New System.Drawing.Font("Open Sans", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_TargetaCredito.ForeColor = System.Drawing.Color.FromArgb(CType(CType(232, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.Lbl_TargetaCredito.Location = New System.Drawing.Point(121, 41)
        Me.Lbl_TargetaCredito.Name = "Lbl_TargetaCredito"
        Me.Lbl_TargetaCredito.Size = New System.Drawing.Size(188, 28)
        Me.Lbl_TargetaCredito.TabIndex = 10
        Me.Lbl_TargetaCredito.Text = "Tarjeta de Crédito"
        '
        'Cb_TargetaCredito
        '
        Me.Cb_TargetaCredito.BackColor = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(135, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.Cb_TargetaCredito.ChechedOffColor = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(135, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.Cb_TargetaCredito.Checked = False
        Me.Cb_TargetaCredito.CheckedOnColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.Cb_TargetaCredito.Cursor = System.Windows.Forms.Cursors.Hand
        Me.SideMenuAnimator2.SetDecoration(Me.Cb_TargetaCredito, BunifuAnimatorNS.DecorationType.None)
        Me.SideMenuAnimator.SetDecoration(Me.Cb_TargetaCredito, BunifuAnimatorNS.DecorationType.None)
        Me.LogoMenuAnimator.SetDecoration(Me.Cb_TargetaCredito, BunifuAnimatorNS.DecorationType.None)
        Me.SideMenuHideAnimator.SetDecoration(Me.Cb_TargetaCredito, BunifuAnimatorNS.DecorationType.None)
        Me.Cb_TargetaCredito.ForeColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(31, Byte), Integer))
        Me.Cb_TargetaCredito.Location = New System.Drawing.Point(69, 45)
        Me.Cb_TargetaCredito.Name = "Cb_TargetaCredito"
        Me.Cb_TargetaCredito.Size = New System.Drawing.Size(20, 20)
        Me.Cb_TargetaCredito.TabIndex = 11
        '
        'Lbl_Efectivo
        '
        Me.Lbl_Efectivo.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Lbl_Efectivo.AutoSize = True
        Me.SideMenuAnimator2.SetDecoration(Me.Lbl_Efectivo, BunifuAnimatorNS.DecorationType.None)
        Me.SideMenuAnimator.SetDecoration(Me.Lbl_Efectivo, BunifuAnimatorNS.DecorationType.None)
        Me.LogoMenuAnimator.SetDecoration(Me.Lbl_Efectivo, BunifuAnimatorNS.DecorationType.None)
        Me.SideMenuHideAnimator.SetDecoration(Me.Lbl_Efectivo, BunifuAnimatorNS.DecorationType.None)
        Me.Lbl_Efectivo.Font = New System.Drawing.Font("Open Sans", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Efectivo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(232, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.Lbl_Efectivo.Location = New System.Drawing.Point(122, 69)
        Me.Lbl_Efectivo.Name = "Lbl_Efectivo"
        Me.Lbl_Efectivo.Size = New System.Drawing.Size(89, 28)
        Me.Lbl_Efectivo.TabIndex = 12
        Me.Lbl_Efectivo.Text = "Efectivo"
        '
        'Cb_Efectivo
        '
        Me.Cb_Efectivo.BackColor = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(135, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.Cb_Efectivo.ChechedOffColor = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(135, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.Cb_Efectivo.Checked = False
        Me.Cb_Efectivo.CheckedOnColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.Cb_Efectivo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.SideMenuAnimator2.SetDecoration(Me.Cb_Efectivo, BunifuAnimatorNS.DecorationType.None)
        Me.SideMenuAnimator.SetDecoration(Me.Cb_Efectivo, BunifuAnimatorNS.DecorationType.None)
        Me.LogoMenuAnimator.SetDecoration(Me.Cb_Efectivo, BunifuAnimatorNS.DecorationType.None)
        Me.SideMenuHideAnimator.SetDecoration(Me.Cb_Efectivo, BunifuAnimatorNS.DecorationType.None)
        Me.Cb_Efectivo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(31, Byte), Integer))
        Me.Cb_Efectivo.Location = New System.Drawing.Point(69, 73)
        Me.Cb_Efectivo.Name = "Cb_Efectivo"
        Me.Cb_Efectivo.Size = New System.Drawing.Size(20, 20)
        Me.Cb_Efectivo.TabIndex = 13
        '
        'Lbl_FormasDePago
        '
        Me.Lbl_FormasDePago.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Lbl_FormasDePago.AutoSize = True
        Me.SideMenuAnimator2.SetDecoration(Me.Lbl_FormasDePago, BunifuAnimatorNS.DecorationType.None)
        Me.SideMenuAnimator.SetDecoration(Me.Lbl_FormasDePago, BunifuAnimatorNS.DecorationType.None)
        Me.LogoMenuAnimator.SetDecoration(Me.Lbl_FormasDePago, BunifuAnimatorNS.DecorationType.None)
        Me.SideMenuHideAnimator.SetDecoration(Me.Lbl_FormasDePago, BunifuAnimatorNS.DecorationType.None)
        Me.Lbl_FormasDePago.Font = New System.Drawing.Font("Open Sans Semibold", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_FormasDePago.ForeColor = System.Drawing.Color.FromArgb(CType(CType(232, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.Lbl_FormasDePago.Location = New System.Drawing.Point(36, 3)
        Me.Lbl_FormasDePago.Name = "Lbl_FormasDePago"
        Me.Lbl_FormasDePago.Size = New System.Drawing.Size(178, 28)
        Me.Lbl_FormasDePago.TabIndex = 18
        Me.Lbl_FormasDePago.Text = "Formas de Pago:"
        '
        'Pn_ComidaDelDia
        '
        Me.Pn_ComidaDelDia.AutoSize = True
        Me.Pn_ComidaDelDia.Controls.Add(Me.Cb_Cena)
        Me.Pn_ComidaDelDia.Controls.Add(Me.Lbl_Cena)
        Me.Pn_ComidaDelDia.Controls.Add(Me.Cb_Almuerzo)
        Me.Pn_ComidaDelDia.Controls.Add(Me.Lbl_Almuerzo)
        Me.Pn_ComidaDelDia.Controls.Add(Me.Lbl_Desayuno)
        Me.Pn_ComidaDelDia.Controls.Add(Me.BunifuCheckbox8)
        Me.Pn_ComidaDelDia.Controls.Add(Me.BunifuCustomLabel28)
        Me.Pn_ComidaDelDia.Cursor = System.Windows.Forms.Cursors.Hand
        Me.SideMenuHideAnimator.SetDecoration(Me.Pn_ComidaDelDia, BunifuAnimatorNS.DecorationType.None)
        Me.SideMenuAnimator.SetDecoration(Me.Pn_ComidaDelDia, BunifuAnimatorNS.DecorationType.None)
        Me.SideMenuAnimator2.SetDecoration(Me.Pn_ComidaDelDia, BunifuAnimatorNS.DecorationType.None)
        Me.LogoMenuAnimator.SetDecoration(Me.Pn_ComidaDelDia, BunifuAnimatorNS.DecorationType.None)
        Me.Pn_ComidaDelDia.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Pn_ComidaDelDia.Location = New System.Drawing.Point(3, 603)
        Me.Pn_ComidaDelDia.Name = "Pn_ComidaDelDia"
        Me.Pn_ComidaDelDia.Padding = New System.Windows.Forms.Padding(0, 0, 0, 10)
        Me.Pn_ComidaDelDia.Size = New System.Drawing.Size(352, 135)
        Me.Pn_ComidaDelDia.TabIndex = 27
        Me.Pn_ComidaDelDia.Visible = False
        '
        'Cb_Cena
        '
        Me.Cb_Cena.BackColor = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(135, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.Cb_Cena.ChechedOffColor = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(135, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.Cb_Cena.Checked = False
        Me.Cb_Cena.CheckedOnColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.Cb_Cena.Cursor = System.Windows.Forms.Cursors.Hand
        Me.SideMenuAnimator2.SetDecoration(Me.Cb_Cena, BunifuAnimatorNS.DecorationType.None)
        Me.SideMenuAnimator.SetDecoration(Me.Cb_Cena, BunifuAnimatorNS.DecorationType.None)
        Me.LogoMenuAnimator.SetDecoration(Me.Cb_Cena, BunifuAnimatorNS.DecorationType.None)
        Me.SideMenuHideAnimator.SetDecoration(Me.Cb_Cena, BunifuAnimatorNS.DecorationType.None)
        Me.Cb_Cena.ForeColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(31, Byte), Integer))
        Me.Cb_Cena.Location = New System.Drawing.Point(70, 101)
        Me.Cb_Cena.Name = "Cb_Cena"
        Me.Cb_Cena.Size = New System.Drawing.Size(20, 20)
        Me.Cb_Cena.TabIndex = 22
        '
        'Lbl_Cena
        '
        Me.Lbl_Cena.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Lbl_Cena.AutoSize = True
        Me.SideMenuAnimator2.SetDecoration(Me.Lbl_Cena, BunifuAnimatorNS.DecorationType.None)
        Me.SideMenuAnimator.SetDecoration(Me.Lbl_Cena, BunifuAnimatorNS.DecorationType.None)
        Me.LogoMenuAnimator.SetDecoration(Me.Lbl_Cena, BunifuAnimatorNS.DecorationType.None)
        Me.SideMenuHideAnimator.SetDecoration(Me.Lbl_Cena, BunifuAnimatorNS.DecorationType.None)
        Me.Lbl_Cena.Font = New System.Drawing.Font("Open Sans", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Cena.ForeColor = System.Drawing.Color.FromArgb(CType(CType(232, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.Lbl_Cena.Location = New System.Drawing.Point(122, 97)
        Me.Lbl_Cena.Name = "Lbl_Cena"
        Me.Lbl_Cena.Size = New System.Drawing.Size(62, 28)
        Me.Lbl_Cena.TabIndex = 21
        Me.Lbl_Cena.Text = "Cena"
        '
        'Cb_Almuerzo
        '
        Me.Cb_Almuerzo.BackColor = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(135, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.Cb_Almuerzo.ChechedOffColor = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(135, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.Cb_Almuerzo.Checked = False
        Me.Cb_Almuerzo.CheckedOnColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.Cb_Almuerzo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.SideMenuAnimator2.SetDecoration(Me.Cb_Almuerzo, BunifuAnimatorNS.DecorationType.None)
        Me.SideMenuAnimator.SetDecoration(Me.Cb_Almuerzo, BunifuAnimatorNS.DecorationType.None)
        Me.LogoMenuAnimator.SetDecoration(Me.Cb_Almuerzo, BunifuAnimatorNS.DecorationType.None)
        Me.SideMenuHideAnimator.SetDecoration(Me.Cb_Almuerzo, BunifuAnimatorNS.DecorationType.None)
        Me.Cb_Almuerzo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(31, Byte), Integer))
        Me.Cb_Almuerzo.Location = New System.Drawing.Point(70, 73)
        Me.Cb_Almuerzo.Name = "Cb_Almuerzo"
        Me.Cb_Almuerzo.Size = New System.Drawing.Size(20, 20)
        Me.Cb_Almuerzo.TabIndex = 20
        '
        'Lbl_Almuerzo
        '
        Me.Lbl_Almuerzo.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Lbl_Almuerzo.AutoSize = True
        Me.SideMenuAnimator2.SetDecoration(Me.Lbl_Almuerzo, BunifuAnimatorNS.DecorationType.None)
        Me.SideMenuAnimator.SetDecoration(Me.Lbl_Almuerzo, BunifuAnimatorNS.DecorationType.None)
        Me.LogoMenuAnimator.SetDecoration(Me.Lbl_Almuerzo, BunifuAnimatorNS.DecorationType.None)
        Me.SideMenuHideAnimator.SetDecoration(Me.Lbl_Almuerzo, BunifuAnimatorNS.DecorationType.None)
        Me.Lbl_Almuerzo.Font = New System.Drawing.Font("Open Sans", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Almuerzo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(232, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.Lbl_Almuerzo.Location = New System.Drawing.Point(122, 69)
        Me.Lbl_Almuerzo.Name = "Lbl_Almuerzo"
        Me.Lbl_Almuerzo.Size = New System.Drawing.Size(107, 28)
        Me.Lbl_Almuerzo.TabIndex = 19
        Me.Lbl_Almuerzo.Text = "Almuerzo"
        '
        'Lbl_Desayuno
        '
        Me.Lbl_Desayuno.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Lbl_Desayuno.AutoSize = True
        Me.SideMenuAnimator2.SetDecoration(Me.Lbl_Desayuno, BunifuAnimatorNS.DecorationType.None)
        Me.SideMenuAnimator.SetDecoration(Me.Lbl_Desayuno, BunifuAnimatorNS.DecorationType.None)
        Me.LogoMenuAnimator.SetDecoration(Me.Lbl_Desayuno, BunifuAnimatorNS.DecorationType.None)
        Me.SideMenuHideAnimator.SetDecoration(Me.Lbl_Desayuno, BunifuAnimatorNS.DecorationType.None)
        Me.Lbl_Desayuno.Font = New System.Drawing.Font("Open Sans", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Desayuno.ForeColor = System.Drawing.Color.FromArgb(CType(CType(232, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.Lbl_Desayuno.Location = New System.Drawing.Point(122, 41)
        Me.Lbl_Desayuno.Name = "Lbl_Desayuno"
        Me.Lbl_Desayuno.Size = New System.Drawing.Size(111, 28)
        Me.Lbl_Desayuno.TabIndex = 10
        Me.Lbl_Desayuno.Text = "Desayuno"
        '
        'BunifuCheckbox8
        '
        Me.BunifuCheckbox8.BackColor = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(135, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.BunifuCheckbox8.ChechedOffColor = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(135, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.BunifuCheckbox8.Checked = False
        Me.BunifuCheckbox8.CheckedOnColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.BunifuCheckbox8.Cursor = System.Windows.Forms.Cursors.Hand
        Me.SideMenuAnimator2.SetDecoration(Me.BunifuCheckbox8, BunifuAnimatorNS.DecorationType.None)
        Me.SideMenuAnimator.SetDecoration(Me.BunifuCheckbox8, BunifuAnimatorNS.DecorationType.None)
        Me.LogoMenuAnimator.SetDecoration(Me.BunifuCheckbox8, BunifuAnimatorNS.DecorationType.None)
        Me.SideMenuHideAnimator.SetDecoration(Me.BunifuCheckbox8, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuCheckbox8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(31, Byte), Integer))
        Me.BunifuCheckbox8.Location = New System.Drawing.Point(70, 45)
        Me.BunifuCheckbox8.Name = "BunifuCheckbox8"
        Me.BunifuCheckbox8.Size = New System.Drawing.Size(20, 20)
        Me.BunifuCheckbox8.TabIndex = 11
        '
        'BunifuCustomLabel28
        '
        Me.BunifuCustomLabel28.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.BunifuCustomLabel28.AutoSize = True
        Me.SideMenuAnimator2.SetDecoration(Me.BunifuCustomLabel28, BunifuAnimatorNS.DecorationType.None)
        Me.SideMenuAnimator.SetDecoration(Me.BunifuCustomLabel28, BunifuAnimatorNS.DecorationType.None)
        Me.LogoMenuAnimator.SetDecoration(Me.BunifuCustomLabel28, BunifuAnimatorNS.DecorationType.None)
        Me.SideMenuHideAnimator.SetDecoration(Me.BunifuCustomLabel28, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuCustomLabel28.Font = New System.Drawing.Font("Open Sans Semibold", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel28.ForeColor = System.Drawing.Color.FromArgb(CType(CType(232, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.BunifuCustomLabel28.Location = New System.Drawing.Point(36, 3)
        Me.BunifuCustomLabel28.Name = "BunifuCustomLabel28"
        Me.BunifuCustomLabel28.Size = New System.Drawing.Size(167, 28)
        Me.BunifuCustomLabel28.TabIndex = 18
        Me.BunifuCustomLabel28.Text = "Comida del día:"
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.Btn_Menu)
        Me.Panel3.Controls.Add(Me.Picture_Logo)
        Me.Panel3.Controls.Add(Me.Lbl_Filtro)
        Me.SideMenuHideAnimator.SetDecoration(Me.Panel3, BunifuAnimatorNS.DecorationType.None)
        Me.SideMenuAnimator.SetDecoration(Me.Panel3, BunifuAnimatorNS.DecorationType.None)
        Me.LogoMenuAnimator.SetDecoration(Me.Panel3, BunifuAnimatorNS.DecorationType.None)
        Me.SideMenuAnimator2.SetDecoration(Me.Panel3, BunifuAnimatorNS.DecorationType.None)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(358, 113)
        Me.Panel3.TabIndex = 27
        '
        'Btn_Menu
        '
        Me.Btn_Menu.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Btn_Menu.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.Btn_Menu.Cursor = System.Windows.Forms.Cursors.Hand
        Me.SideMenuHideAnimator.SetDecoration(Me.Btn_Menu, BunifuAnimatorNS.DecorationType.None)
        Me.LogoMenuAnimator.SetDecoration(Me.Btn_Menu, BunifuAnimatorNS.DecorationType.None)
        Me.SideMenuAnimator.SetDecoration(Me.Btn_Menu, BunifuAnimatorNS.DecorationType.None)
        Me.SideMenuAnimator2.SetDecoration(Me.Btn_Menu, BunifuAnimatorNS.DecorationType.None)
        Me.Btn_Menu.Image = Global.RecomendacionesRestaurantes.My.Resources.Resources.ico_menu
        Me.Btn_Menu.ImageActive = Nothing
        Me.Btn_Menu.Location = New System.Drawing.Point(320, 6)
        Me.Btn_Menu.Name = "Btn_Menu"
        Me.Btn_Menu.Size = New System.Drawing.Size(32, 32)
        Me.Btn_Menu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Btn_Menu.TabIndex = 1
        Me.Btn_Menu.TabStop = False
        Me.Btn_Menu.Zoom = 10
        '
        'Picture_Logo
        '
        Me.SideMenuAnimator2.SetDecoration(Me.Picture_Logo, BunifuAnimatorNS.DecorationType.None)
        Me.SideMenuHideAnimator.SetDecoration(Me.Picture_Logo, BunifuAnimatorNS.DecorationType.None)
        Me.SideMenuAnimator.SetDecoration(Me.Picture_Logo, BunifuAnimatorNS.DecorationType.None)
        Me.LogoMenuAnimator.SetDecoration(Me.Picture_Logo, BunifuAnimatorNS.DecorationType.None)
        Me.Picture_Logo.Image = Global.RecomendacionesRestaurantes.My.Resources.Resources.ico_app2
        Me.Picture_Logo.Location = New System.Drawing.Point(6, 0)
        Me.Picture_Logo.Name = "Picture_Logo"
        Me.Picture_Logo.Size = New System.Drawing.Size(118, 104)
        Me.Picture_Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Picture_Logo.TabIndex = 0
        Me.Picture_Logo.TabStop = False
        Me.Picture_Logo.Visible = False
        '
        'Lbl_Filtro
        '
        Me.Lbl_Filtro.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Lbl_Filtro.AutoSize = True
        Me.SideMenuAnimator2.SetDecoration(Me.Lbl_Filtro, BunifuAnimatorNS.DecorationType.None)
        Me.SideMenuAnimator.SetDecoration(Me.Lbl_Filtro, BunifuAnimatorNS.DecorationType.None)
        Me.LogoMenuAnimator.SetDecoration(Me.Lbl_Filtro, BunifuAnimatorNS.DecorationType.None)
        Me.SideMenuHideAnimator.SetDecoration(Me.Lbl_Filtro, BunifuAnimatorNS.DecorationType.None)
        Me.Lbl_Filtro.Font = New System.Drawing.Font("PT Sans", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Filtro.ForeColor = System.Drawing.Color.FromArgb(CType(CType(232, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.Lbl_Filtro.Location = New System.Drawing.Point(141, 56)
        Me.Lbl_Filtro.Name = "Lbl_Filtro"
        Me.Lbl_Filtro.Size = New System.Drawing.Size(211, 34)
        Me.Lbl_Filtro.TabIndex = 9
        Me.Lbl_Filtro.Text = "Filtre Sus Gustos"
        Me.Lbl_Filtro.Visible = False
        '
        'BunifuElipse1
        '
        Me.BunifuElipse1.ElipseRadius = 5
        Me.BunifuElipse1.TargetControl = Me
        '
        'Pn_header
        '
        Me.Pn_header.BackColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.Pn_header.Controls.Add(Me.Btn_Minimizar)
        Me.Pn_header.Controls.Add(Me.Btn_Maximizar)
        Me.Pn_header.Controls.Add(Me.Btn_Cerrar)
        Me.Pn_header.Controls.Add(Me.Pic_IconoVentana)
        Me.Pn_header.Controls.Add(Me.Lbl_TituloVentana)
        Me.SideMenuHideAnimator.SetDecoration(Me.Pn_header, BunifuAnimatorNS.DecorationType.None)
        Me.SideMenuAnimator.SetDecoration(Me.Pn_header, BunifuAnimatorNS.DecorationType.None)
        Me.LogoMenuAnimator.SetDecoration(Me.Pn_header, BunifuAnimatorNS.DecorationType.None)
        Me.SideMenuAnimator2.SetDecoration(Me.Pn_header, BunifuAnimatorNS.DecorationType.None)
        Me.Pn_header.Dock = System.Windows.Forms.DockStyle.Top
        Me.Pn_header.Location = New System.Drawing.Point(0, 0)
        Me.Pn_header.Name = "Pn_header"
        Me.Pn_header.Size = New System.Drawing.Size(1263, 45)
        Me.Pn_header.TabIndex = 2
        '
        'Btn_Minimizar
        '
        Me.Btn_Minimizar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Btn_Minimizar.BackColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.Btn_Minimizar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.SideMenuHideAnimator.SetDecoration(Me.Btn_Minimizar, BunifuAnimatorNS.DecorationType.None)
        Me.LogoMenuAnimator.SetDecoration(Me.Btn_Minimizar, BunifuAnimatorNS.DecorationType.None)
        Me.SideMenuAnimator.SetDecoration(Me.Btn_Minimizar, BunifuAnimatorNS.DecorationType.None)
        Me.SideMenuAnimator2.SetDecoration(Me.Btn_Minimizar, BunifuAnimatorNS.DecorationType.None)
        Me.Btn_Minimizar.Image = Global.RecomendacionesRestaurantes.My.Resources.Resources.ico_minimizar
        Me.Btn_Minimizar.ImageActive = Nothing
        Me.Btn_Minimizar.Location = New System.Drawing.Point(1145, 9)
        Me.Btn_Minimizar.Name = "Btn_Minimizar"
        Me.Btn_Minimizar.Size = New System.Drawing.Size(25, 25)
        Me.Btn_Minimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Btn_Minimizar.TabIndex = 5
        Me.Btn_Minimizar.TabStop = False
        Me.Btn_Minimizar.Zoom = 20
        '
        'Btn_Maximizar
        '
        Me.Btn_Maximizar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Btn_Maximizar.BackColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.Btn_Maximizar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.SideMenuHideAnimator.SetDecoration(Me.Btn_Maximizar, BunifuAnimatorNS.DecorationType.None)
        Me.LogoMenuAnimator.SetDecoration(Me.Btn_Maximizar, BunifuAnimatorNS.DecorationType.None)
        Me.SideMenuAnimator.SetDecoration(Me.Btn_Maximizar, BunifuAnimatorNS.DecorationType.None)
        Me.SideMenuAnimator2.SetDecoration(Me.Btn_Maximizar, BunifuAnimatorNS.DecorationType.None)
        Me.Btn_Maximizar.Image = Global.RecomendacionesRestaurantes.My.Resources.Resources.ico_maximizar
        Me.Btn_Maximizar.ImageActive = Nothing
        Me.Btn_Maximizar.Location = New System.Drawing.Point(1185, 9)
        Me.Btn_Maximizar.Name = "Btn_Maximizar"
        Me.Btn_Maximizar.Size = New System.Drawing.Size(25, 25)
        Me.Btn_Maximizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Btn_Maximizar.TabIndex = 4
        Me.Btn_Maximizar.TabStop = False
        Me.Btn_Maximizar.Zoom = 20
        '
        'Btn_Cerrar
        '
        Me.Btn_Cerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Btn_Cerrar.BackColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.Btn_Cerrar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.SideMenuHideAnimator.SetDecoration(Me.Btn_Cerrar, BunifuAnimatorNS.DecorationType.None)
        Me.LogoMenuAnimator.SetDecoration(Me.Btn_Cerrar, BunifuAnimatorNS.DecorationType.None)
        Me.SideMenuAnimator.SetDecoration(Me.Btn_Cerrar, BunifuAnimatorNS.DecorationType.None)
        Me.SideMenuAnimator2.SetDecoration(Me.Btn_Cerrar, BunifuAnimatorNS.DecorationType.None)
        Me.Btn_Cerrar.Image = Global.RecomendacionesRestaurantes.My.Resources.Resources.ico_cerrar
        Me.Btn_Cerrar.ImageActive = Nothing
        Me.Btn_Cerrar.Location = New System.Drawing.Point(1225, 9)
        Me.Btn_Cerrar.Name = "Btn_Cerrar"
        Me.Btn_Cerrar.Size = New System.Drawing.Size(25, 25)
        Me.Btn_Cerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Btn_Cerrar.TabIndex = 3
        Me.Btn_Cerrar.TabStop = False
        Me.Btn_Cerrar.Zoom = 20
        '
        'Pic_IconoVentana
        '
        Me.SideMenuAnimator2.SetDecoration(Me.Pic_IconoVentana, BunifuAnimatorNS.DecorationType.None)
        Me.SideMenuHideAnimator.SetDecoration(Me.Pic_IconoVentana, BunifuAnimatorNS.DecorationType.None)
        Me.SideMenuAnimator.SetDecoration(Me.Pic_IconoVentana, BunifuAnimatorNS.DecorationType.None)
        Me.LogoMenuAnimator.SetDecoration(Me.Pic_IconoVentana, BunifuAnimatorNS.DecorationType.None)
        Me.Pic_IconoVentana.Image = Global.RecomendacionesRestaurantes.My.Resources.Resources.ico_form2
        Me.Pic_IconoVentana.Location = New System.Drawing.Point(7, 7)
        Me.Pic_IconoVentana.Name = "Pic_IconoVentana"
        Me.Pic_IconoVentana.Size = New System.Drawing.Size(32, 32)
        Me.Pic_IconoVentana.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Pic_IconoVentana.TabIndex = 3
        Me.Pic_IconoVentana.TabStop = False
        '
        'Lbl_TituloVentana
        '
        Me.Lbl_TituloVentana.AutoSize = True
        Me.SideMenuAnimator2.SetDecoration(Me.Lbl_TituloVentana, BunifuAnimatorNS.DecorationType.None)
        Me.SideMenuAnimator.SetDecoration(Me.Lbl_TituloVentana, BunifuAnimatorNS.DecorationType.None)
        Me.LogoMenuAnimator.SetDecoration(Me.Lbl_TituloVentana, BunifuAnimatorNS.DecorationType.None)
        Me.SideMenuHideAnimator.SetDecoration(Me.Lbl_TituloVentana, BunifuAnimatorNS.DecorationType.None)
        Me.Lbl_TituloVentana.Font = New System.Drawing.Font("Open Sans", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_TituloVentana.ForeColor = System.Drawing.Color.FromArgb(CType(CType(232, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.Lbl_TituloVentana.Location = New System.Drawing.Point(45, 9)
        Me.Lbl_TituloVentana.Name = "Lbl_TituloVentana"
        Me.Lbl_TituloVentana.Size = New System.Drawing.Size(211, 26)
        Me.Lbl_TituloVentana.TabIndex = 3
        Me.Lbl_TituloVentana.Text = "Come, visita y disfruta"
        '
        'BunifuDragControl1
        '
        Me.BunifuDragControl1.Fixed = True
        Me.BunifuDragControl1.Horizontal = True
        Me.BunifuDragControl1.TargetControl = Me.Pn_header
        Me.BunifuDragControl1.Vertical = True
        '
        'SideMenuAnimator
        '
        Me.SideMenuAnimator.AnimationType = BunifuAnimatorNS.AnimationType.HorizSlide
        Me.SideMenuAnimator.Cursor = Nothing
        Animation2.AnimateOnlyDifferences = True
        Animation2.BlindCoeff = CType(resources.GetObject("Animation2.BlindCoeff"), System.Drawing.PointF)
        Animation2.LeafCoeff = 0!
        Animation2.MaxTime = 1.0!
        Animation2.MinTime = 0!
        Animation2.MosaicCoeff = CType(resources.GetObject("Animation2.MosaicCoeff"), System.Drawing.PointF)
        Animation2.MosaicShift = CType(resources.GetObject("Animation2.MosaicShift"), System.Drawing.PointF)
        Animation2.MosaicSize = 0
        Animation2.Padding = New System.Windows.Forms.Padding(0)
        Animation2.RotateCoeff = 0!
        Animation2.RotateLimit = 0!
        Animation2.ScaleCoeff = CType(resources.GetObject("Animation2.ScaleCoeff"), System.Drawing.PointF)
        Animation2.SlideCoeff = CType(resources.GetObject("Animation2.SlideCoeff"), System.Drawing.PointF)
        Animation2.TimeCoeff = 0!
        Animation2.TransparencyCoeff = 0!
        Me.SideMenuAnimator.DefaultAnimation = Animation2
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Lbl_TituloBold)
        Me.Panel1.Controls.Add(Me.Lbl_Subtitulo)
        Me.Panel1.Controls.Add(Me.Lbl_Titulo)
        Me.SideMenuHideAnimator.SetDecoration(Me.Panel1, BunifuAnimatorNS.DecorationType.None)
        Me.SideMenuAnimator.SetDecoration(Me.Panel1, BunifuAnimatorNS.DecorationType.None)
        Me.LogoMenuAnimator.SetDecoration(Me.Panel1, BunifuAnimatorNS.DecorationType.None)
        Me.SideMenuAnimator2.SetDecoration(Me.Panel1, BunifuAnimatorNS.DecorationType.None)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(358, 45)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(905, 119)
        Me.Panel1.TabIndex = 3
        '
        'Lbl_TituloBold
        '
        Me.Lbl_TituloBold.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Lbl_TituloBold.AutoSize = True
        Me.SideMenuAnimator2.SetDecoration(Me.Lbl_TituloBold, BunifuAnimatorNS.DecorationType.None)
        Me.SideMenuAnimator.SetDecoration(Me.Lbl_TituloBold, BunifuAnimatorNS.DecorationType.None)
        Me.LogoMenuAnimator.SetDecoration(Me.Lbl_TituloBold, BunifuAnimatorNS.DecorationType.None)
        Me.SideMenuHideAnimator.SetDecoration(Me.Lbl_TituloBold, BunifuAnimatorNS.DecorationType.None)
        Me.Lbl_TituloBold.Font = New System.Drawing.Font("PT Sans", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_TituloBold.ForeColor = System.Drawing.Color.FromArgb(CType(CType(232, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.Lbl_TituloBold.Location = New System.Drawing.Point(368, 15)
        Me.Lbl_TituloBold.Name = "Lbl_TituloBold"
        Me.Lbl_TituloBold.Size = New System.Drawing.Size(93, 42)
        Me.Lbl_TituloBold.TabIndex = 8
        Me.Lbl_TituloBold.Text = "Visita"
        '
        'Lbl_Subtitulo
        '
        Me.Lbl_Subtitulo.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Lbl_Subtitulo.AutoSize = True
        Me.SideMenuAnimator2.SetDecoration(Me.Lbl_Subtitulo, BunifuAnimatorNS.DecorationType.None)
        Me.SideMenuAnimator.SetDecoration(Me.Lbl_Subtitulo, BunifuAnimatorNS.DecorationType.None)
        Me.LogoMenuAnimator.SetDecoration(Me.Lbl_Subtitulo, BunifuAnimatorNS.DecorationType.None)
        Me.SideMenuHideAnimator.SetDecoration(Me.Lbl_Subtitulo, BunifuAnimatorNS.DecorationType.None)
        Me.Lbl_Subtitulo.Font = New System.Drawing.Font("Open Sans", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Subtitulo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(232, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.Lbl_Subtitulo.Location = New System.Drawing.Point(218, 63)
        Me.Lbl_Subtitulo.Name = "Lbl_Subtitulo"
        Me.Lbl_Subtitulo.Size = New System.Drawing.Size(408, 26)
        Me.Lbl_Subtitulo.TabIndex = 7
        Me.Lbl_Subtitulo.Text = "¡Te Ayudamos a Elegir Tu Restaurante Ideal!"
        '
        'Lbl_Titulo
        '
        Me.Lbl_Titulo.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Lbl_Titulo.AutoSize = True
        Me.SideMenuAnimator2.SetDecoration(Me.Lbl_Titulo, BunifuAnimatorNS.DecorationType.None)
        Me.SideMenuAnimator.SetDecoration(Me.Lbl_Titulo, BunifuAnimatorNS.DecorationType.None)
        Me.LogoMenuAnimator.SetDecoration(Me.Lbl_Titulo, BunifuAnimatorNS.DecorationType.None)
        Me.SideMenuHideAnimator.SetDecoration(Me.Lbl_Titulo, BunifuAnimatorNS.DecorationType.None)
        Me.Lbl_Titulo.Font = New System.Drawing.Font("PT Sans", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Titulo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(232, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.Lbl_Titulo.Location = New System.Drawing.Point(280, 15)
        Me.Lbl_Titulo.Name = "Lbl_Titulo"
        Me.Lbl_Titulo.Size = New System.Drawing.Size(301, 42)
        Me.Lbl_Titulo.TabIndex = 6
        Me.Lbl_Titulo.Text = "Come           Disfruta"
        '
        'TableLayoutPanel6
        '
        Me.TableLayoutPanel6.ColumnCount = 1
        Me.TableLayoutPanel6.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel6.Controls.Add(Me.Lbl_TioCaiman, 0, 1)
        Me.TableLayoutPanel6.Controls.Add(Me.Pic_TioCaiman, 0, 0)
        Me.SideMenuHideAnimator.SetDecoration(Me.TableLayoutPanel6, BunifuAnimatorNS.DecorationType.None)
        Me.SideMenuAnimator.SetDecoration(Me.TableLayoutPanel6, BunifuAnimatorNS.DecorationType.None)
        Me.LogoMenuAnimator.SetDecoration(Me.TableLayoutPanel6, BunifuAnimatorNS.DecorationType.None)
        Me.SideMenuAnimator2.SetDecoration(Me.TableLayoutPanel6, BunifuAnimatorNS.DecorationType.None)
        Me.TableLayoutPanel6.Location = New System.Drawing.Point(228, 259)
        Me.TableLayoutPanel6.Name = "TableLayoutPanel6"
        Me.TableLayoutPanel6.RowCount = 2
        Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 85.2!))
        Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.8!))
        Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel6.Size = New System.Drawing.Size(219, 250)
        Me.TableLayoutPanel6.TabIndex = 6
        '
        'Lbl_TioCaiman
        '
        Me.Lbl_TioCaiman.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Lbl_TioCaiman.AutoSize = True
        Me.SideMenuHideAnimator.SetDecoration(Me.Lbl_TioCaiman, BunifuAnimatorNS.DecorationType.None)
        Me.LogoMenuAnimator.SetDecoration(Me.Lbl_TioCaiman, BunifuAnimatorNS.DecorationType.None)
        Me.SideMenuAnimator.SetDecoration(Me.Lbl_TioCaiman, BunifuAnimatorNS.DecorationType.None)
        Me.SideMenuAnimator2.SetDecoration(Me.Lbl_TioCaiman, BunifuAnimatorNS.DecorationType.None)
        Me.Lbl_TioCaiman.Font = New System.Drawing.Font("Open Sans", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_TioCaiman.ForeColor = System.Drawing.Color.FromArgb(CType(CType(232, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.Lbl_TioCaiman.Location = New System.Drawing.Point(48, 217)
        Me.Lbl_TioCaiman.Name = "Lbl_TioCaiman"
        Me.Lbl_TioCaiman.Size = New System.Drawing.Size(122, 28)
        Me.Lbl_TioCaiman.TabIndex = 1
        Me.Lbl_TioCaiman.Text = "Tío Caimán"
        '
        'Pic_TioCaiman
        '
        Me.Pic_TioCaiman.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Pic_TioCaiman.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.Pic_TioCaiman.Cursor = System.Windows.Forms.Cursors.Hand
        Me.SideMenuHideAnimator.SetDecoration(Me.Pic_TioCaiman, BunifuAnimatorNS.DecorationType.None)
        Me.LogoMenuAnimator.SetDecoration(Me.Pic_TioCaiman, BunifuAnimatorNS.DecorationType.None)
        Me.SideMenuAnimator.SetDecoration(Me.Pic_TioCaiman, BunifuAnimatorNS.DecorationType.None)
        Me.SideMenuAnimator2.SetDecoration(Me.Pic_TioCaiman, BunifuAnimatorNS.DecorationType.None)
        Me.Pic_TioCaiman.Image = Global.RecomendacionesRestaurantes.My.Resources.Resources.ico_tiocaiman
        Me.Pic_TioCaiman.ImageActive = Nothing
        Me.Pic_TioCaiman.Location = New System.Drawing.Point(10, 11)
        Me.Pic_TioCaiman.Name = "Pic_TioCaiman"
        Me.Pic_TioCaiman.Padding = New System.Windows.Forms.Padding(5)
        Me.Pic_TioCaiman.Size = New System.Drawing.Size(199, 189)
        Me.Pic_TioCaiman.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Pic_TioCaiman.TabIndex = 2
        Me.Pic_TioCaiman.TabStop = False
        Me.Pic_TioCaiman.Zoom = 30
        '
        'TableLayoutPanel5
        '
        Me.TableLayoutPanel5.ColumnCount = 1
        Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel5.Controls.Add(Me.Lbl_Estambul, 0, 1)
        Me.TableLayoutPanel5.Controls.Add(Me.Pic_Estambul, 0, 0)
        Me.SideMenuHideAnimator.SetDecoration(Me.TableLayoutPanel5, BunifuAnimatorNS.DecorationType.None)
        Me.SideMenuAnimator.SetDecoration(Me.TableLayoutPanel5, BunifuAnimatorNS.DecorationType.None)
        Me.LogoMenuAnimator.SetDecoration(Me.TableLayoutPanel5, BunifuAnimatorNS.DecorationType.None)
        Me.SideMenuAnimator2.SetDecoration(Me.TableLayoutPanel5, BunifuAnimatorNS.DecorationType.None)
        Me.TableLayoutPanel5.Location = New System.Drawing.Point(3, 259)
        Me.TableLayoutPanel5.Name = "TableLayoutPanel5"
        Me.TableLayoutPanel5.RowCount = 2
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 85.2!))
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.8!))
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel5.Size = New System.Drawing.Size(219, 250)
        Me.TableLayoutPanel5.TabIndex = 5
        '
        'Lbl_Estambul
        '
        Me.Lbl_Estambul.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Lbl_Estambul.AutoSize = True
        Me.SideMenuHideAnimator.SetDecoration(Me.Lbl_Estambul, BunifuAnimatorNS.DecorationType.None)
        Me.LogoMenuAnimator.SetDecoration(Me.Lbl_Estambul, BunifuAnimatorNS.DecorationType.None)
        Me.SideMenuAnimator.SetDecoration(Me.Lbl_Estambul, BunifuAnimatorNS.DecorationType.None)
        Me.SideMenuAnimator2.SetDecoration(Me.Lbl_Estambul, BunifuAnimatorNS.DecorationType.None)
        Me.Lbl_Estambul.Font = New System.Drawing.Font("Open Sans", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Estambul.ForeColor = System.Drawing.Color.FromArgb(CType(CType(232, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.Lbl_Estambul.Location = New System.Drawing.Point(8, 218)
        Me.Lbl_Estambul.Name = "Lbl_Estambul"
        Me.Lbl_Estambul.Size = New System.Drawing.Size(202, 26)
        Me.Lbl_Estambul.TabIndex = 1
        Me.Lbl_Estambul.Text = "Estambul Restaurant"
        '
        'Pic_Estambul
        '
        Me.Pic_Estambul.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Pic_Estambul.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.Pic_Estambul.Cursor = System.Windows.Forms.Cursors.Hand
        Me.SideMenuHideAnimator.SetDecoration(Me.Pic_Estambul, BunifuAnimatorNS.DecorationType.None)
        Me.LogoMenuAnimator.SetDecoration(Me.Pic_Estambul, BunifuAnimatorNS.DecorationType.None)
        Me.SideMenuAnimator.SetDecoration(Me.Pic_Estambul, BunifuAnimatorNS.DecorationType.None)
        Me.SideMenuAnimator2.SetDecoration(Me.Pic_Estambul, BunifuAnimatorNS.DecorationType.None)
        Me.Pic_Estambul.Image = Global.RecomendacionesRestaurantes.My.Resources.Resources.ico_estambul
        Me.Pic_Estambul.ImageActive = Nothing
        Me.Pic_Estambul.Location = New System.Drawing.Point(10, 11)
        Me.Pic_Estambul.Name = "Pic_Estambul"
        Me.Pic_Estambul.Padding = New System.Windows.Forms.Padding(5)
        Me.Pic_Estambul.Size = New System.Drawing.Size(199, 189)
        Me.Pic_Estambul.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Pic_Estambul.TabIndex = 2
        Me.Pic_Estambul.TabStop = False
        Me.Pic_Estambul.Zoom = 30
        '
        'TableLayoutPanel4
        '
        Me.TableLayoutPanel4.ColumnCount = 1
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel4.Controls.Add(Me.Lbl_Ohtoro, 0, 1)
        Me.TableLayoutPanel4.Controls.Add(Me.Pic_Ohtoro, 0, 0)
        Me.SideMenuHideAnimator.SetDecoration(Me.TableLayoutPanel4, BunifuAnimatorNS.DecorationType.None)
        Me.SideMenuAnimator.SetDecoration(Me.TableLayoutPanel4, BunifuAnimatorNS.DecorationType.None)
        Me.LogoMenuAnimator.SetDecoration(Me.TableLayoutPanel4, BunifuAnimatorNS.DecorationType.None)
        Me.SideMenuAnimator2.SetDecoration(Me.TableLayoutPanel4, BunifuAnimatorNS.DecorationType.None)
        Me.TableLayoutPanel4.Location = New System.Drawing.Point(678, 3)
        Me.TableLayoutPanel4.Name = "TableLayoutPanel4"
        Me.TableLayoutPanel4.RowCount = 2
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 85.2!))
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.8!))
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel4.Size = New System.Drawing.Size(219, 250)
        Me.TableLayoutPanel4.TabIndex = 4
        '
        'Lbl_Ohtoro
        '
        Me.Lbl_Ohtoro.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Lbl_Ohtoro.AutoSize = True
        Me.SideMenuHideAnimator.SetDecoration(Me.Lbl_Ohtoro, BunifuAnimatorNS.DecorationType.None)
        Me.LogoMenuAnimator.SetDecoration(Me.Lbl_Ohtoro, BunifuAnimatorNS.DecorationType.None)
        Me.SideMenuAnimator.SetDecoration(Me.Lbl_Ohtoro, BunifuAnimatorNS.DecorationType.None)
        Me.SideMenuAnimator2.SetDecoration(Me.Lbl_Ohtoro, BunifuAnimatorNS.DecorationType.None)
        Me.Lbl_Ohtoro.Font = New System.Drawing.Font("Open Sans", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Ohtoro.ForeColor = System.Drawing.Color.FromArgb(CType(CType(232, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.Lbl_Ohtoro.Location = New System.Drawing.Point(68, 217)
        Me.Lbl_Ohtoro.Name = "Lbl_Ohtoro"
        Me.Lbl_Ohtoro.Size = New System.Drawing.Size(83, 28)
        Me.Lbl_Ohtoro.TabIndex = 1
        Me.Lbl_Ohtoro.Text = "Ohtoro"
        '
        'Pic_Ohtoro
        '
        Me.Pic_Ohtoro.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Pic_Ohtoro.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.Pic_Ohtoro.Cursor = System.Windows.Forms.Cursors.Hand
        Me.SideMenuHideAnimator.SetDecoration(Me.Pic_Ohtoro, BunifuAnimatorNS.DecorationType.None)
        Me.LogoMenuAnimator.SetDecoration(Me.Pic_Ohtoro, BunifuAnimatorNS.DecorationType.None)
        Me.SideMenuAnimator.SetDecoration(Me.Pic_Ohtoro, BunifuAnimatorNS.DecorationType.None)
        Me.SideMenuAnimator2.SetDecoration(Me.Pic_Ohtoro, BunifuAnimatorNS.DecorationType.None)
        Me.Pic_Ohtoro.Image = Global.RecomendacionesRestaurantes.My.Resources.Resources.ico_ohtoro
        Me.Pic_Ohtoro.ImageActive = Nothing
        Me.Pic_Ohtoro.Location = New System.Drawing.Point(10, 11)
        Me.Pic_Ohtoro.Name = "Pic_Ohtoro"
        Me.Pic_Ohtoro.Padding = New System.Windows.Forms.Padding(5)
        Me.Pic_Ohtoro.Size = New System.Drawing.Size(199, 189)
        Me.Pic_Ohtoro.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Pic_Ohtoro.TabIndex = 2
        Me.Pic_Ohtoro.TabStop = False
        Me.Pic_Ohtoro.Zoom = 30
        '
        'TableLayoutPanel3
        '
        Me.TableLayoutPanel3.ColumnCount = 1
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel3.Controls.Add(Me.Lbl_TerrazaSushi, 0, 1)
        Me.TableLayoutPanel3.Controls.Add(Me.Pic_TerrazaSushi, 0, 0)
        Me.SideMenuHideAnimator.SetDecoration(Me.TableLayoutPanel3, BunifuAnimatorNS.DecorationType.None)
        Me.SideMenuAnimator.SetDecoration(Me.TableLayoutPanel3, BunifuAnimatorNS.DecorationType.None)
        Me.LogoMenuAnimator.SetDecoration(Me.TableLayoutPanel3, BunifuAnimatorNS.DecorationType.None)
        Me.SideMenuAnimator2.SetDecoration(Me.TableLayoutPanel3, BunifuAnimatorNS.DecorationType.None)
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(453, 3)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RowCount = 2
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 85.2!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.8!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(219, 250)
        Me.TableLayoutPanel3.TabIndex = 3
        '
        'Lbl_TerrazaSushi
        '
        Me.Lbl_TerrazaSushi.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Lbl_TerrazaSushi.AutoSize = True
        Me.SideMenuHideAnimator.SetDecoration(Me.Lbl_TerrazaSushi, BunifuAnimatorNS.DecorationType.None)
        Me.LogoMenuAnimator.SetDecoration(Me.Lbl_TerrazaSushi, BunifuAnimatorNS.DecorationType.None)
        Me.SideMenuAnimator.SetDecoration(Me.Lbl_TerrazaSushi, BunifuAnimatorNS.DecorationType.None)
        Me.SideMenuAnimator2.SetDecoration(Me.Lbl_TerrazaSushi, BunifuAnimatorNS.DecorationType.None)
        Me.Lbl_TerrazaSushi.Font = New System.Drawing.Font("Open Sans", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_TerrazaSushi.ForeColor = System.Drawing.Color.FromArgb(CType(CType(232, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.Lbl_TerrazaSushi.Location = New System.Drawing.Point(36, 217)
        Me.Lbl_TerrazaSushi.Name = "Lbl_TerrazaSushi"
        Me.Lbl_TerrazaSushi.Size = New System.Drawing.Size(146, 28)
        Me.Lbl_TerrazaSushi.TabIndex = 1
        Me.Lbl_TerrazaSushi.Text = "Terraza Sushi"
        '
        'Pic_TerrazaSushi
        '
        Me.Pic_TerrazaSushi.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Pic_TerrazaSushi.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.Pic_TerrazaSushi.Cursor = System.Windows.Forms.Cursors.Hand
        Me.SideMenuHideAnimator.SetDecoration(Me.Pic_TerrazaSushi, BunifuAnimatorNS.DecorationType.None)
        Me.LogoMenuAnimator.SetDecoration(Me.Pic_TerrazaSushi, BunifuAnimatorNS.DecorationType.None)
        Me.SideMenuAnimator.SetDecoration(Me.Pic_TerrazaSushi, BunifuAnimatorNS.DecorationType.None)
        Me.SideMenuAnimator2.SetDecoration(Me.Pic_TerrazaSushi, BunifuAnimatorNS.DecorationType.None)
        Me.Pic_TerrazaSushi.Image = Global.RecomendacionesRestaurantes.My.Resources.Resources.ico_terrazasushi
        Me.Pic_TerrazaSushi.ImageActive = Nothing
        Me.Pic_TerrazaSushi.Location = New System.Drawing.Point(10, 11)
        Me.Pic_TerrazaSushi.Name = "Pic_TerrazaSushi"
        Me.Pic_TerrazaSushi.Padding = New System.Windows.Forms.Padding(5)
        Me.Pic_TerrazaSushi.Size = New System.Drawing.Size(199, 189)
        Me.Pic_TerrazaSushi.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Pic_TerrazaSushi.TabIndex = 2
        Me.Pic_TerrazaSushi.TabStop = False
        Me.Pic_TerrazaSushi.Zoom = 30
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 1
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.Lbl_Kfc, 0, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.Pic_Kfc, 0, 0)
        Me.SideMenuHideAnimator.SetDecoration(Me.TableLayoutPanel2, BunifuAnimatorNS.DecorationType.None)
        Me.SideMenuAnimator.SetDecoration(Me.TableLayoutPanel2, BunifuAnimatorNS.DecorationType.None)
        Me.LogoMenuAnimator.SetDecoration(Me.TableLayoutPanel2, BunifuAnimatorNS.DecorationType.None)
        Me.SideMenuAnimator2.SetDecoration(Me.TableLayoutPanel2, BunifuAnimatorNS.DecorationType.None)
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(228, 3)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 2
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 85.2!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.8!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(219, 250)
        Me.TableLayoutPanel2.TabIndex = 2
        '
        'Lbl_Kfc
        '
        Me.Lbl_Kfc.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Lbl_Kfc.AutoSize = True
        Me.SideMenuHideAnimator.SetDecoration(Me.Lbl_Kfc, BunifuAnimatorNS.DecorationType.None)
        Me.LogoMenuAnimator.SetDecoration(Me.Lbl_Kfc, BunifuAnimatorNS.DecorationType.None)
        Me.SideMenuAnimator.SetDecoration(Me.Lbl_Kfc, BunifuAnimatorNS.DecorationType.None)
        Me.SideMenuAnimator2.SetDecoration(Me.Lbl_Kfc, BunifuAnimatorNS.DecorationType.None)
        Me.Lbl_Kfc.Font = New System.Drawing.Font("Open Sans", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Kfc.ForeColor = System.Drawing.Color.FromArgb(CType(CType(232, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.Lbl_Kfc.Location = New System.Drawing.Point(85, 217)
        Me.Lbl_Kfc.Name = "Lbl_Kfc"
        Me.Lbl_Kfc.Size = New System.Drawing.Size(49, 28)
        Me.Lbl_Kfc.TabIndex = 1
        Me.Lbl_Kfc.Text = "KFC"
        '
        'Pic_Kfc
        '
        Me.Pic_Kfc.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Pic_Kfc.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.Pic_Kfc.Cursor = System.Windows.Forms.Cursors.Hand
        Me.SideMenuHideAnimator.SetDecoration(Me.Pic_Kfc, BunifuAnimatorNS.DecorationType.None)
        Me.LogoMenuAnimator.SetDecoration(Me.Pic_Kfc, BunifuAnimatorNS.DecorationType.None)
        Me.SideMenuAnimator.SetDecoration(Me.Pic_Kfc, BunifuAnimatorNS.DecorationType.None)
        Me.SideMenuAnimator2.SetDecoration(Me.Pic_Kfc, BunifuAnimatorNS.DecorationType.None)
        Me.Pic_Kfc.Image = Global.RecomendacionesRestaurantes.My.Resources.Resources.ico_kfc
        Me.Pic_Kfc.ImageActive = Nothing
        Me.Pic_Kfc.Location = New System.Drawing.Point(10, 11)
        Me.Pic_Kfc.Name = "Pic_Kfc"
        Me.Pic_Kfc.Padding = New System.Windows.Forms.Padding(5)
        Me.Pic_Kfc.Size = New System.Drawing.Size(199, 189)
        Me.Pic_Kfc.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Pic_Kfc.TabIndex = 2
        Me.Pic_Kfc.TabStop = False
        Me.Pic_Kfc.Zoom = 30
        '
        'Pn_Restaurantes
        '
        Me.Pn_Restaurantes.AutoScroll = True
        Me.Pn_Restaurantes.Controls.Add(Me.Pn_mcdonads)
        Me.Pn_Restaurantes.Controls.Add(Me.TableLayoutPanel2)
        Me.Pn_Restaurantes.Controls.Add(Me.TableLayoutPanel3)
        Me.Pn_Restaurantes.Controls.Add(Me.TableLayoutPanel4)
        Me.Pn_Restaurantes.Controls.Add(Me.TableLayoutPanel5)
        Me.Pn_Restaurantes.Controls.Add(Me.TableLayoutPanel6)
        Me.Pn_Restaurantes.Controls.Add(Me.TableLayoutPanel7)
        Me.Pn_Restaurantes.Controls.Add(Me.TableLayoutPanel8)
        Me.Pn_Restaurantes.Controls.Add(Me.TableLayoutPanel9)
        Me.Pn_Restaurantes.Controls.Add(Me.TableLayoutPanel10)
        Me.LogoMenuAnimator.SetDecoration(Me.Pn_Restaurantes, BunifuAnimatorNS.DecorationType.None)
        Me.SideMenuAnimator.SetDecoration(Me.Pn_Restaurantes, BunifuAnimatorNS.DecorationType.None)
        Me.SideMenuHideAnimator.SetDecoration(Me.Pn_Restaurantes, BunifuAnimatorNS.DecorationType.None)
        Me.SideMenuAnimator2.SetDecoration(Me.Pn_Restaurantes, BunifuAnimatorNS.DecorationType.None)
        Me.Pn_Restaurantes.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Pn_Restaurantes.Location = New System.Drawing.Point(358, 164)
        Me.Pn_Restaurantes.Name = "Pn_Restaurantes"
        Me.Pn_Restaurantes.Size = New System.Drawing.Size(905, 619)
        Me.Pn_Restaurantes.TabIndex = 4
        '
        'Pn_mcdonads
        '
        Me.Pn_mcdonads.ColumnCount = 1
        Me.Pn_mcdonads.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.Pn_mcdonads.Controls.Add(Me.Lbl_McDonalds, 0, 1)
        Me.Pn_mcdonads.Controls.Add(Me.Pic_McDonalds, 0, 0)
        Me.SideMenuHideAnimator.SetDecoration(Me.Pn_mcdonads, BunifuAnimatorNS.DecorationType.None)
        Me.SideMenuAnimator.SetDecoration(Me.Pn_mcdonads, BunifuAnimatorNS.DecorationType.None)
        Me.LogoMenuAnimator.SetDecoration(Me.Pn_mcdonads, BunifuAnimatorNS.DecorationType.None)
        Me.SideMenuAnimator2.SetDecoration(Me.Pn_mcdonads, BunifuAnimatorNS.DecorationType.None)
        Me.Pn_mcdonads.Location = New System.Drawing.Point(3, 3)
        Me.Pn_mcdonads.Name = "Pn_mcdonads"
        Me.Pn_mcdonads.RowCount = 2
        Me.Pn_mcdonads.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 85.2!))
        Me.Pn_mcdonads.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.8!))
        Me.Pn_mcdonads.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.Pn_mcdonads.Size = New System.Drawing.Size(219, 250)
        Me.Pn_mcdonads.TabIndex = 1
        '
        'Lbl_McDonalds
        '
        Me.Lbl_McDonalds.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Lbl_McDonalds.AutoSize = True
        Me.SideMenuHideAnimator.SetDecoration(Me.Lbl_McDonalds, BunifuAnimatorNS.DecorationType.None)
        Me.LogoMenuAnimator.SetDecoration(Me.Lbl_McDonalds, BunifuAnimatorNS.DecorationType.None)
        Me.SideMenuAnimator.SetDecoration(Me.Lbl_McDonalds, BunifuAnimatorNS.DecorationType.None)
        Me.SideMenuAnimator2.SetDecoration(Me.Lbl_McDonalds, BunifuAnimatorNS.DecorationType.None)
        Me.Lbl_McDonalds.Font = New System.Drawing.Font("Open Sans", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_McDonalds.ForeColor = System.Drawing.Color.FromArgb(CType(CType(232, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.Lbl_McDonalds.Location = New System.Drawing.Point(46, 217)
        Me.Lbl_McDonalds.Name = "Lbl_McDonalds"
        Me.Lbl_McDonalds.Size = New System.Drawing.Size(127, 28)
        Me.Lbl_McDonalds.TabIndex = 1
        Me.Lbl_McDonalds.Text = "McDonald's"
        '
        'Pic_McDonalds
        '
        Me.Pic_McDonalds.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Pic_McDonalds.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.Pic_McDonalds.Cursor = System.Windows.Forms.Cursors.Hand
        Me.SideMenuHideAnimator.SetDecoration(Me.Pic_McDonalds, BunifuAnimatorNS.DecorationType.None)
        Me.LogoMenuAnimator.SetDecoration(Me.Pic_McDonalds, BunifuAnimatorNS.DecorationType.None)
        Me.SideMenuAnimator.SetDecoration(Me.Pic_McDonalds, BunifuAnimatorNS.DecorationType.None)
        Me.SideMenuAnimator2.SetDecoration(Me.Pic_McDonalds, BunifuAnimatorNS.DecorationType.None)
        Me.Pic_McDonalds.Image = Global.RecomendacionesRestaurantes.My.Resources.Resources.ico_mcdonalds
        Me.Pic_McDonalds.ImageActive = Nothing
        Me.Pic_McDonalds.Location = New System.Drawing.Point(10, 11)
        Me.Pic_McDonalds.Name = "Pic_McDonalds"
        Me.Pic_McDonalds.Padding = New System.Windows.Forms.Padding(5)
        Me.Pic_McDonalds.Size = New System.Drawing.Size(199, 189)
        Me.Pic_McDonalds.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Pic_McDonalds.TabIndex = 2
        Me.Pic_McDonalds.TabStop = False
        Me.Pic_McDonalds.Zoom = 30
        '
        'TableLayoutPanel7
        '
        Me.TableLayoutPanel7.ColumnCount = 1
        Me.TableLayoutPanel7.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel7.Controls.Add(Me.Lbl_EventosCarolina, 0, 1)
        Me.TableLayoutPanel7.Controls.Add(Me.Pic_EventosCarolina, 0, 0)
        Me.TableLayoutPanel7.Cursor = System.Windows.Forms.Cursors.Hand
        Me.SideMenuHideAnimator.SetDecoration(Me.TableLayoutPanel7, BunifuAnimatorNS.DecorationType.None)
        Me.SideMenuAnimator.SetDecoration(Me.TableLayoutPanel7, BunifuAnimatorNS.DecorationType.None)
        Me.LogoMenuAnimator.SetDecoration(Me.TableLayoutPanel7, BunifuAnimatorNS.DecorationType.None)
        Me.SideMenuAnimator2.SetDecoration(Me.TableLayoutPanel7, BunifuAnimatorNS.DecorationType.None)
        Me.TableLayoutPanel7.Location = New System.Drawing.Point(453, 259)
        Me.TableLayoutPanel7.Name = "TableLayoutPanel7"
        Me.TableLayoutPanel7.RowCount = 2
        Me.TableLayoutPanel7.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 85.2!))
        Me.TableLayoutPanel7.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.8!))
        Me.TableLayoutPanel7.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel7.Size = New System.Drawing.Size(219, 250)
        Me.TableLayoutPanel7.TabIndex = 7
        '
        'Lbl_EventosCarolina
        '
        Me.Lbl_EventosCarolina.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Lbl_EventosCarolina.AutoSize = True
        Me.SideMenuHideAnimator.SetDecoration(Me.Lbl_EventosCarolina, BunifuAnimatorNS.DecorationType.None)
        Me.LogoMenuAnimator.SetDecoration(Me.Lbl_EventosCarolina, BunifuAnimatorNS.DecorationType.None)
        Me.SideMenuAnimator.SetDecoration(Me.Lbl_EventosCarolina, BunifuAnimatorNS.DecorationType.None)
        Me.SideMenuAnimator2.SetDecoration(Me.Lbl_EventosCarolina, BunifuAnimatorNS.DecorationType.None)
        Me.Lbl_EventosCarolina.Font = New System.Drawing.Font("Open Sans", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_EventosCarolina.ForeColor = System.Drawing.Color.FromArgb(CType(CType(232, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.Lbl_EventosCarolina.Location = New System.Drawing.Point(21, 217)
        Me.Lbl_EventosCarolina.Name = "Lbl_EventosCarolina"
        Me.Lbl_EventosCarolina.Size = New System.Drawing.Size(177, 28)
        Me.Lbl_EventosCarolina.TabIndex = 1
        Me.Lbl_EventosCarolina.Text = "Eventos Carolina"
        '
        'Pic_EventosCarolina
        '
        Me.Pic_EventosCarolina.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Pic_EventosCarolina.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.SideMenuHideAnimator.SetDecoration(Me.Pic_EventosCarolina, BunifuAnimatorNS.DecorationType.None)
        Me.LogoMenuAnimator.SetDecoration(Me.Pic_EventosCarolina, BunifuAnimatorNS.DecorationType.None)
        Me.SideMenuAnimator.SetDecoration(Me.Pic_EventosCarolina, BunifuAnimatorNS.DecorationType.None)
        Me.SideMenuAnimator2.SetDecoration(Me.Pic_EventosCarolina, BunifuAnimatorNS.DecorationType.None)
        Me.Pic_EventosCarolina.Image = Global.RecomendacionesRestaurantes.My.Resources.Resources.ico_eventoscarolina2_jpg
        Me.Pic_EventosCarolina.ImageActive = Nothing
        Me.Pic_EventosCarolina.Location = New System.Drawing.Point(10, 11)
        Me.Pic_EventosCarolina.Name = "Pic_EventosCarolina"
        Me.Pic_EventosCarolina.Padding = New System.Windows.Forms.Padding(5)
        Me.Pic_EventosCarolina.Size = New System.Drawing.Size(199, 189)
        Me.Pic_EventosCarolina.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Pic_EventosCarolina.TabIndex = 2
        Me.Pic_EventosCarolina.TabStop = False
        Me.Pic_EventosCarolina.Zoom = 30
        '
        'TableLayoutPanel8
        '
        Me.TableLayoutPanel8.ColumnCount = 1
        Me.TableLayoutPanel8.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel8.Controls.Add(Me.Lbl_Subway, 0, 1)
        Me.TableLayoutPanel8.Controls.Add(Me.Pic_Subway, 0, 0)
        Me.SideMenuHideAnimator.SetDecoration(Me.TableLayoutPanel8, BunifuAnimatorNS.DecorationType.None)
        Me.SideMenuAnimator.SetDecoration(Me.TableLayoutPanel8, BunifuAnimatorNS.DecorationType.None)
        Me.LogoMenuAnimator.SetDecoration(Me.TableLayoutPanel8, BunifuAnimatorNS.DecorationType.None)
        Me.SideMenuAnimator2.SetDecoration(Me.TableLayoutPanel8, BunifuAnimatorNS.DecorationType.None)
        Me.TableLayoutPanel8.Location = New System.Drawing.Point(678, 259)
        Me.TableLayoutPanel8.Name = "TableLayoutPanel8"
        Me.TableLayoutPanel8.RowCount = 2
        Me.TableLayoutPanel8.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 85.2!))
        Me.TableLayoutPanel8.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.8!))
        Me.TableLayoutPanel8.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel8.Size = New System.Drawing.Size(219, 250)
        Me.TableLayoutPanel8.TabIndex = 8
        '
        'Lbl_Subway
        '
        Me.Lbl_Subway.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Lbl_Subway.AutoSize = True
        Me.SideMenuHideAnimator.SetDecoration(Me.Lbl_Subway, BunifuAnimatorNS.DecorationType.None)
        Me.LogoMenuAnimator.SetDecoration(Me.Lbl_Subway, BunifuAnimatorNS.DecorationType.None)
        Me.SideMenuAnimator.SetDecoration(Me.Lbl_Subway, BunifuAnimatorNS.DecorationType.None)
        Me.SideMenuAnimator2.SetDecoration(Me.Lbl_Subway, BunifuAnimatorNS.DecorationType.None)
        Me.Lbl_Subway.Font = New System.Drawing.Font("Open Sans", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Subway.ForeColor = System.Drawing.Color.FromArgb(CType(CType(232, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.Lbl_Subway.Location = New System.Drawing.Point(65, 217)
        Me.Lbl_Subway.Name = "Lbl_Subway"
        Me.Lbl_Subway.Size = New System.Drawing.Size(89, 28)
        Me.Lbl_Subway.TabIndex = 1
        Me.Lbl_Subway.Text = "Subway"
        '
        'Pic_Subway
        '
        Me.Pic_Subway.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Pic_Subway.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.Pic_Subway.Cursor = System.Windows.Forms.Cursors.Hand
        Me.SideMenuHideAnimator.SetDecoration(Me.Pic_Subway, BunifuAnimatorNS.DecorationType.None)
        Me.LogoMenuAnimator.SetDecoration(Me.Pic_Subway, BunifuAnimatorNS.DecorationType.None)
        Me.SideMenuAnimator.SetDecoration(Me.Pic_Subway, BunifuAnimatorNS.DecorationType.None)
        Me.SideMenuAnimator2.SetDecoration(Me.Pic_Subway, BunifuAnimatorNS.DecorationType.None)
        Me.Pic_Subway.Image = Global.RecomendacionesRestaurantes.My.Resources.Resources.ico_subway
        Me.Pic_Subway.ImageActive = Nothing
        Me.Pic_Subway.Location = New System.Drawing.Point(10, 11)
        Me.Pic_Subway.Name = "Pic_Subway"
        Me.Pic_Subway.Padding = New System.Windows.Forms.Padding(5)
        Me.Pic_Subway.Size = New System.Drawing.Size(199, 189)
        Me.Pic_Subway.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Pic_Subway.TabIndex = 2
        Me.Pic_Subway.TabStop = False
        Me.Pic_Subway.Zoom = 30
        '
        'TableLayoutPanel9
        '
        Me.TableLayoutPanel9.ColumnCount = 1
        Me.TableLayoutPanel9.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel9.Controls.Add(Me.Lbl_Mirador, 0, 1)
        Me.TableLayoutPanel9.Controls.Add(Me.Pic_ElMirador, 0, 0)
        Me.SideMenuHideAnimator.SetDecoration(Me.TableLayoutPanel9, BunifuAnimatorNS.DecorationType.None)
        Me.SideMenuAnimator.SetDecoration(Me.TableLayoutPanel9, BunifuAnimatorNS.DecorationType.None)
        Me.LogoMenuAnimator.SetDecoration(Me.TableLayoutPanel9, BunifuAnimatorNS.DecorationType.None)
        Me.SideMenuAnimator2.SetDecoration(Me.TableLayoutPanel9, BunifuAnimatorNS.DecorationType.None)
        Me.TableLayoutPanel9.Location = New System.Drawing.Point(3, 515)
        Me.TableLayoutPanel9.Name = "TableLayoutPanel9"
        Me.TableLayoutPanel9.RowCount = 2
        Me.TableLayoutPanel9.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 85.2!))
        Me.TableLayoutPanel9.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.8!))
        Me.TableLayoutPanel9.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel9.Size = New System.Drawing.Size(219, 250)
        Me.TableLayoutPanel9.TabIndex = 9
        '
        'Lbl_Mirador
        '
        Me.Lbl_Mirador.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Lbl_Mirador.AutoSize = True
        Me.SideMenuHideAnimator.SetDecoration(Me.Lbl_Mirador, BunifuAnimatorNS.DecorationType.None)
        Me.LogoMenuAnimator.SetDecoration(Me.Lbl_Mirador, BunifuAnimatorNS.DecorationType.None)
        Me.SideMenuAnimator.SetDecoration(Me.Lbl_Mirador, BunifuAnimatorNS.DecorationType.None)
        Me.SideMenuAnimator2.SetDecoration(Me.Lbl_Mirador, BunifuAnimatorNS.DecorationType.None)
        Me.Lbl_Mirador.Font = New System.Drawing.Font("Open Sans", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Mirador.ForeColor = System.Drawing.Color.FromArgb(CType(CType(232, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.Lbl_Mirador.Location = New System.Drawing.Point(52, 217)
        Me.Lbl_Mirador.Name = "Lbl_Mirador"
        Me.Lbl_Mirador.Size = New System.Drawing.Size(114, 28)
        Me.Lbl_Mirador.TabIndex = 1
        Me.Lbl_Mirador.Text = "El Mirador"
        '
        'Pic_ElMirador
        '
        Me.Pic_ElMirador.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Pic_ElMirador.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.Pic_ElMirador.Cursor = System.Windows.Forms.Cursors.Hand
        Me.SideMenuHideAnimator.SetDecoration(Me.Pic_ElMirador, BunifuAnimatorNS.DecorationType.None)
        Me.LogoMenuAnimator.SetDecoration(Me.Pic_ElMirador, BunifuAnimatorNS.DecorationType.None)
        Me.SideMenuAnimator.SetDecoration(Me.Pic_ElMirador, BunifuAnimatorNS.DecorationType.None)
        Me.SideMenuAnimator2.SetDecoration(Me.Pic_ElMirador, BunifuAnimatorNS.DecorationType.None)
        Me.Pic_ElMirador.Image = CType(resources.GetObject("Pic_ElMirador.Image"), System.Drawing.Image)
        Me.Pic_ElMirador.ImageActive = Nothing
        Me.Pic_ElMirador.Location = New System.Drawing.Point(10, 11)
        Me.Pic_ElMirador.Name = "Pic_ElMirador"
        Me.Pic_ElMirador.Padding = New System.Windows.Forms.Padding(5)
        Me.Pic_ElMirador.Size = New System.Drawing.Size(199, 189)
        Me.Pic_ElMirador.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Pic_ElMirador.TabIndex = 2
        Me.Pic_ElMirador.TabStop = False
        Me.Pic_ElMirador.Zoom = 30
        '
        'TableLayoutPanel10
        '
        Me.TableLayoutPanel10.ColumnCount = 1
        Me.TableLayoutPanel10.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel10.Controls.Add(Me.Lbl_SalsaCarbon, 0, 1)
        Me.TableLayoutPanel10.Controls.Add(Me.Pic_SalsaCarbon, 0, 0)
        Me.SideMenuHideAnimator.SetDecoration(Me.TableLayoutPanel10, BunifuAnimatorNS.DecorationType.None)
        Me.SideMenuAnimator.SetDecoration(Me.TableLayoutPanel10, BunifuAnimatorNS.DecorationType.None)
        Me.LogoMenuAnimator.SetDecoration(Me.TableLayoutPanel10, BunifuAnimatorNS.DecorationType.None)
        Me.SideMenuAnimator2.SetDecoration(Me.TableLayoutPanel10, BunifuAnimatorNS.DecorationType.None)
        Me.TableLayoutPanel10.Location = New System.Drawing.Point(228, 515)
        Me.TableLayoutPanel10.Name = "TableLayoutPanel10"
        Me.TableLayoutPanel10.RowCount = 2
        Me.TableLayoutPanel10.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 85.2!))
        Me.TableLayoutPanel10.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.8!))
        Me.TableLayoutPanel10.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel10.Size = New System.Drawing.Size(219, 250)
        Me.TableLayoutPanel10.TabIndex = 10
        '
        'Lbl_SalsaCarbon
        '
        Me.Lbl_SalsaCarbon.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Lbl_SalsaCarbon.AutoSize = True
        Me.SideMenuHideAnimator.SetDecoration(Me.Lbl_SalsaCarbon, BunifuAnimatorNS.DecorationType.None)
        Me.LogoMenuAnimator.SetDecoration(Me.Lbl_SalsaCarbon, BunifuAnimatorNS.DecorationType.None)
        Me.SideMenuAnimator.SetDecoration(Me.Lbl_SalsaCarbon, BunifuAnimatorNS.DecorationType.None)
        Me.SideMenuAnimator2.SetDecoration(Me.Lbl_SalsaCarbon, BunifuAnimatorNS.DecorationType.None)
        Me.Lbl_SalsaCarbon.Font = New System.Drawing.Font("Open Sans", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_SalsaCarbon.ForeColor = System.Drawing.Color.FromArgb(CType(CType(232, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.Lbl_SalsaCarbon.Location = New System.Drawing.Point(31, 217)
        Me.Lbl_SalsaCarbon.Name = "Lbl_SalsaCarbon"
        Me.Lbl_SalsaCarbon.Size = New System.Drawing.Size(157, 28)
        Me.Lbl_SalsaCarbon.TabIndex = 1
        Me.Lbl_SalsaCarbon.Text = "Salsa y Carbón"
        '
        'Pic_SalsaCarbon
        '
        Me.Pic_SalsaCarbon.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Pic_SalsaCarbon.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.Pic_SalsaCarbon.Cursor = System.Windows.Forms.Cursors.Hand
        Me.SideMenuHideAnimator.SetDecoration(Me.Pic_SalsaCarbon, BunifuAnimatorNS.DecorationType.None)
        Me.LogoMenuAnimator.SetDecoration(Me.Pic_SalsaCarbon, BunifuAnimatorNS.DecorationType.None)
        Me.SideMenuAnimator.SetDecoration(Me.Pic_SalsaCarbon, BunifuAnimatorNS.DecorationType.None)
        Me.SideMenuAnimator2.SetDecoration(Me.Pic_SalsaCarbon, BunifuAnimatorNS.DecorationType.None)
        Me.Pic_SalsaCarbon.Image = Global.RecomendacionesRestaurantes.My.Resources.Resources.ico_salsacarbon
        Me.Pic_SalsaCarbon.ImageActive = Nothing
        Me.Pic_SalsaCarbon.Location = New System.Drawing.Point(10, 11)
        Me.Pic_SalsaCarbon.Name = "Pic_SalsaCarbon"
        Me.Pic_SalsaCarbon.Padding = New System.Windows.Forms.Padding(5)
        Me.Pic_SalsaCarbon.Size = New System.Drawing.Size(199, 189)
        Me.Pic_SalsaCarbon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Pic_SalsaCarbon.TabIndex = 2
        Me.Pic_SalsaCarbon.TabStop = False
        Me.Pic_SalsaCarbon.Zoom = 30
        '
        'LogoMenuAnimator
        '
        Me.LogoMenuAnimator.AnimationType = BunifuAnimatorNS.AnimationType.ScaleAndRotate
        Me.LogoMenuAnimator.Cursor = Nothing
        Animation3.AnimateOnlyDifferences = True
        Animation3.BlindCoeff = CType(resources.GetObject("Animation3.BlindCoeff"), System.Drawing.PointF)
        Animation3.LeafCoeff = 0!
        Animation3.MaxTime = 1.0!
        Animation3.MinTime = 0!
        Animation3.MosaicCoeff = CType(resources.GetObject("Animation3.MosaicCoeff"), System.Drawing.PointF)
        Animation3.MosaicShift = CType(resources.GetObject("Animation3.MosaicShift"), System.Drawing.PointF)
        Animation3.MosaicSize = 0
        Animation3.Padding = New System.Windows.Forms.Padding(30)
        Animation3.RotateCoeff = 0.5!
        Animation3.RotateLimit = 0.2!
        Animation3.ScaleCoeff = CType(resources.GetObject("Animation3.ScaleCoeff"), System.Drawing.PointF)
        Animation3.SlideCoeff = CType(resources.GetObject("Animation3.SlideCoeff"), System.Drawing.PointF)
        Animation3.TimeCoeff = 0!
        Animation3.TransparencyCoeff = 0!
        Me.LogoMenuAnimator.DefaultAnimation = Animation3
        '
        'SideMenuAnimator2
        '
        Me.SideMenuAnimator2.AnimationType = BunifuAnimatorNS.AnimationType.Particles
        Me.SideMenuAnimator2.Cursor = Nothing
        Animation1.AnimateOnlyDifferences = True
        Animation1.BlindCoeff = CType(resources.GetObject("Animation1.BlindCoeff"), System.Drawing.PointF)
        Animation1.LeafCoeff = 0!
        Animation1.MaxTime = 1.0!
        Animation1.MinTime = 0!
        Animation1.MosaicCoeff = CType(resources.GetObject("Animation1.MosaicCoeff"), System.Drawing.PointF)
        Animation1.MosaicShift = CType(resources.GetObject("Animation1.MosaicShift"), System.Drawing.PointF)
        Animation1.MosaicSize = 1
        Animation1.Padding = New System.Windows.Forms.Padding(100, 50, 100, 150)
        Animation1.RotateCoeff = 0!
        Animation1.RotateLimit = 0!
        Animation1.ScaleCoeff = CType(resources.GetObject("Animation1.ScaleCoeff"), System.Drawing.PointF)
        Animation1.SlideCoeff = CType(resources.GetObject("Animation1.SlideCoeff"), System.Drawing.PointF)
        Animation1.TimeCoeff = 2.0!
        Animation1.TransparencyCoeff = 0!
        Me.SideMenuAnimator2.DefaultAnimation = Animation1
        '
        'SideMenuHideAnimator
        '
        Me.SideMenuHideAnimator.AnimationType = BunifuAnimatorNS.AnimationType.Leaf
        Me.SideMenuHideAnimator.Cursor = Nothing
        Animation4.AnimateOnlyDifferences = True
        Animation4.BlindCoeff = CType(resources.GetObject("Animation4.BlindCoeff"), System.Drawing.PointF)
        Animation4.LeafCoeff = 1.0!
        Animation4.MaxTime = 1.0!
        Animation4.MinTime = 0!
        Animation4.MosaicCoeff = CType(resources.GetObject("Animation4.MosaicCoeff"), System.Drawing.PointF)
        Animation4.MosaicShift = CType(resources.GetObject("Animation4.MosaicShift"), System.Drawing.PointF)
        Animation4.MosaicSize = 0
        Animation4.Padding = New System.Windows.Forms.Padding(0)
        Animation4.RotateCoeff = 0!
        Animation4.RotateLimit = 0!
        Animation4.ScaleCoeff = CType(resources.GetObject("Animation4.ScaleCoeff"), System.Drawing.PointF)
        Animation4.SlideCoeff = CType(resources.GetObject("Animation4.SlideCoeff"), System.Drawing.PointF)
        Animation4.TimeCoeff = 0!
        Animation4.TransparencyCoeff = 0!
        Me.SideMenuHideAnimator.DefaultAnimation = Animation4
        Me.SideMenuHideAnimator.Interval = 5
        Me.SideMenuHideAnimator.MaxAnimationTime = 20
        Me.SideMenuHideAnimator.TimeStep = 0.001!
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1263, 783)
        Me.Controls.Add(Me.Pn_Restaurantes)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Pn_SideMenu)
        Me.Controls.Add(Me.Pn_header)
        Me.LogoMenuAnimator.SetDecoration(Me, BunifuAnimatorNS.DecorationType.None)
        Me.SideMenuAnimator.SetDecoration(Me, BunifuAnimatorNS.DecorationType.None)
        Me.SideMenuHideAnimator.SetDecoration(Me, BunifuAnimatorNS.DecorationType.None)
        Me.SideMenuAnimator2.SetDecoration(Me, BunifuAnimatorNS.DecorationType.None)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MinimumSize = New System.Drawing.Size(1263, 783)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = " "
        Me.Pn_SideMenu.ResumeLayout(False)
        Me.Pn_Filtros.ResumeLayout(False)
        Me.Pn_Filtros.PerformLayout()
        Me.Pn_Especialidad.ResumeLayout(False)
        Me.Pn_Especialidad.PerformLayout()
        Me.Pn_Disponibilidad.ResumeLayout(False)
        Me.Pn_Disponibilidad.PerformLayout()
        Me.Pn_TipoDeRestaurante.ResumeLayout(False)
        Me.Pn_TipoDeRestaurante.PerformLayout()
        Me.Pn_Presupuesto.ResumeLayout(False)
        Me.Pn_Presupuesto.PerformLayout()
        Me.Pn_TipoDeDespacho.ResumeLayout(False)
        Me.Pn_TipoDeDespacho.PerformLayout()
        Me.Pn_FormaDePago.ResumeLayout(False)
        Me.Pn_FormaDePago.PerformLayout()
        Me.Pn_ComidaDelDia.ResumeLayout(False)
        Me.Pn_ComidaDelDia.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.Btn_Menu, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Picture_Logo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Pn_header.ResumeLayout(False)
        Me.Pn_header.PerformLayout()
        CType(Me.Btn_Minimizar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Btn_Maximizar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Btn_Cerrar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Pic_IconoVentana, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.TableLayoutPanel6.ResumeLayout(False)
        Me.TableLayoutPanel6.PerformLayout()
        CType(Me.Pic_TioCaiman, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel5.ResumeLayout(False)
        Me.TableLayoutPanel5.PerformLayout()
        CType(Me.Pic_Estambul, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel4.ResumeLayout(False)
        Me.TableLayoutPanel4.PerformLayout()
        CType(Me.Pic_Ohtoro, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel3.ResumeLayout(False)
        Me.TableLayoutPanel3.PerformLayout()
        CType(Me.Pic_TerrazaSushi, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel2.PerformLayout()
        CType(Me.Pic_Kfc, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Pn_Restaurantes.ResumeLayout(False)
        Me.Pn_mcdonads.ResumeLayout(False)
        Me.Pn_mcdonads.PerformLayout()
        CType(Me.Pic_McDonalds, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel7.ResumeLayout(False)
        Me.TableLayoutPanel7.PerformLayout()
        CType(Me.Pic_EventosCarolina, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel8.ResumeLayout(False)
        Me.TableLayoutPanel8.PerformLayout()
        CType(Me.Pic_Subway, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel9.ResumeLayout(False)
        Me.TableLayoutPanel9.PerformLayout()
        CType(Me.Pic_ElMirador, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel10.ResumeLayout(False)
        Me.TableLayoutPanel10.PerformLayout()
        CType(Me.Pic_SalsaCarbon, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Pn_SideMenu As Panel
    Friend WithEvents BunifuElipse1 As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents Picture_Logo As PictureBox
    Friend WithEvents Pn_header As Panel
    Friend WithEvents Btn_Menu As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents Pic_IconoVentana As PictureBox
    Friend WithEvents Lbl_TituloVentana As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BunifuDragControl1 As Bunifu.Framework.UI.BunifuDragControl
    Friend WithEvents Btn_Cerrar As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents Btn_Minimizar As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents Btn_Maximizar As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents Panel1 As Panel
    Private WithEvents LogoMenuAnimator As BunifuAnimatorNS.BunifuTransition
    Private WithEvents SideMenuAnimator As BunifuAnimatorNS.BunifuTransition
    Friend WithEvents Lbl_Subtitulo As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents Lbl_Titulo As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents Lbl_TituloBold As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents Cb_Tematico As Bunifu.Framework.UI.BunifuCheckbox
    Friend WithEvents Lbl_Tematico As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BunifuCustomLabel9 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents Cb_Familiar As Bunifu.Framework.UI.BunifuCheckbox
    Friend WithEvents Lbl_Familiar As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents Cb_ComidaRapida As Bunifu.Framework.UI.BunifuCheckbox
    Friend WithEvents Lbl_ComidaRapida As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents Pn_TipoDeRestaurante As Panel
    Friend WithEvents Lbl_Filtro As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents Pn_TipoDeDespacho As Panel
    Friend WithEvents Lbl_EntregaADomicilio As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents Cb_EntregaDomicilio As Bunifu.Framework.UI.BunifuCheckbox
    Friend WithEvents Lbl_EntregaLocal As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents Cb_EntregaLocal As Bunifu.Framework.UI.BunifuCheckbox
    Friend WithEvents BunifuCustomLabel19 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents Pn_Presupuesto As Panel
    Friend WithEvents Lbl_Presupuesto As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents Slider_Presupuesto As Bunifu.Framework.UI.BunifuSlider
    Friend WithEvents BunifuCustomLabel18 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents Lbl_ValorPresupuesto As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents Pn_Restaurantes As FlowLayoutPanel
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents Lbl_Kfc As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents Pic_Kfc As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents TableLayoutPanel3 As TableLayoutPanel
    Friend WithEvents Lbl_TerrazaSushi As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents Pic_TerrazaSushi As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents TableLayoutPanel4 As TableLayoutPanel
    Friend WithEvents Lbl_Ohtoro As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents Pic_Ohtoro As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents TableLayoutPanel5 As TableLayoutPanel
    Friend WithEvents Lbl_Estambul As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents Pic_Estambul As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents TableLayoutPanel6 As TableLayoutPanel
    Friend WithEvents Lbl_TioCaiman As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents Pic_TioCaiman As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents TableLayoutPanel7 As TableLayoutPanel
    Friend WithEvents Lbl_EventosCarolina As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents Pic_EventosCarolina As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents TableLayoutPanel8 As TableLayoutPanel
    Friend WithEvents Lbl_Subway As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents Pic_Subway As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents Pn_Filtros As TableLayoutPanel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Pn_FormaDePago As Panel
    Friend WithEvents Lbl_TargetaCredito As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents Cb_TargetaCredito As Bunifu.Framework.UI.BunifuCheckbox
    Friend WithEvents Lbl_Efectivo As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents Cb_Efectivo As Bunifu.Framework.UI.BunifuCheckbox
    Friend WithEvents Lbl_FormasDePago As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents Pn_Disponibilidad As Panel
    Friend WithEvents Lbl_Abierto1 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents Cb_Abierto As Bunifu.Framework.UI.BunifuCheckbox
    Friend WithEvents BunifuCustomLabel22 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents Pn_ComidaDelDia As Panel
    Friend WithEvents Lbl_Desayuno As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BunifuCheckbox8 As Bunifu.Framework.UI.BunifuCheckbox
    Friend WithEvents BunifuCustomLabel28 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents Lbl_Abierto2 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents Pn_Especialidad As Panel
    Friend WithEvents BunifuCustomLabel31 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents Cb_Cena As Bunifu.Framework.UI.BunifuCheckbox
    Friend WithEvents Lbl_Cena As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents Cb_Almuerzo As Bunifu.Framework.UI.BunifuCheckbox
    Friend WithEvents Lbl_Almuerzo As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents TableLayoutPanel9 As TableLayoutPanel
    Friend WithEvents Lbl_Mirador As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents Pic_ElMirador As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents Lbl_Sushi As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents Lbl_Hamburguesas As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents Lbl_Emparedados As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents Lbl_Pollo As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents Lbl_Carnes As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents Lbl_Mariscos As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents Cb_Sushi As Bunifu.Framework.UI.BunifuCheckbox
    Friend WithEvents Cb_Hamburguesas As Bunifu.Framework.UI.BunifuCheckbox
    Friend WithEvents Cb_Emparedados As Bunifu.Framework.UI.BunifuCheckbox
    Friend WithEvents Cb_Pollo As Bunifu.Framework.UI.BunifuCheckbox
    Friend WithEvents Cb_Mariscos As Bunifu.Framework.UI.BunifuCheckbox
    Friend WithEvents Cb_Carnes As Bunifu.Framework.UI.BunifuCheckbox
    Friend WithEvents TableLayoutPanel10 As TableLayoutPanel
    Friend WithEvents Lbl_SalsaCarbon As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents Pic_SalsaCarbon As Bunifu.Framework.UI.BunifuImageButton
    Private WithEvents SideMenuHideAnimator As BunifuAnimatorNS.BunifuTransition
    Private WithEvents SideMenuAnimator2 As BunifuAnimatorNS.BunifuTransition
    Friend WithEvents Pn_mcdonads As TableLayoutPanel
    Friend WithEvents Lbl_McDonalds As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents Pic_McDonalds As Bunifu.Framework.UI.BunifuImageButton
End Class
