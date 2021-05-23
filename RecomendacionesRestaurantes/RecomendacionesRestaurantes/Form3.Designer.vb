<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.BunifuElipse1 = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.Pn_header = New System.Windows.Forms.Panel()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Txt_NombreUsuario = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.Txt_Contrasena = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.Lbl_InicioSesion = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuDragControl1 = New Bunifu.Framework.UI.BunifuDragControl(Me.components)
        Me.BunifuDragControl2 = New Bunifu.Framework.UI.BunifuDragControl(Me.components)
        Me.BunifuFlatButton1 = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Btn_Cerrar = New Bunifu.Framework.UI.BunifuImageButton()
        Me.Pn_header.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Btn_Cerrar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BunifuElipse1
        '
        Me.BunifuElipse1.ElipseRadius = 5
        Me.BunifuElipse1.TargetControl = Me
        '
        'Pn_header
        '
        Me.Pn_header.BackColor = System.Drawing.Color.FromArgb(CType(CType(189, Byte), Integer), CType(CType(189, Byte), Integer), CType(CType(189, Byte), Integer))
        Me.Pn_header.Controls.Add(Me.PictureBox2)
        Me.Pn_header.Controls.Add(Me.Lbl_InicioSesion)
        Me.Pn_header.Controls.Add(Me.Btn_Cerrar)
        Me.Pn_header.Dock = System.Windows.Forms.DockStyle.Top
        Me.Pn_header.Location = New System.Drawing.Point(0, 0)
        Me.Pn_header.Name = "Pn_header"
        Me.Pn_header.Size = New System.Drawing.Size(291, 45)
        Me.Pn_header.TabIndex = 1
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.Txt_Contrasena, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.PictureBox1, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Txt_NombreUsuario, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.BunifuFlatButton1, 0, 3)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 45)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 4
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 74.5098!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.4902!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 66.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 79.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(291, 401)
        Me.TableLayoutPanel1.TabIndex = 2
        '
        'Txt_NombreUsuario
        '
        Me.Txt_NombreUsuario.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Txt_NombreUsuario.Font = New System.Drawing.Font("Open Sans", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_NombreUsuario.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Txt_NombreUsuario.HintForeColor = System.Drawing.Color.Empty
        Me.Txt_NombreUsuario.HintText = ""
        Me.Txt_NombreUsuario.isPassword = False
        Me.Txt_NombreUsuario.LineFocusedColor = System.Drawing.Color.Blue
        Me.Txt_NombreUsuario.LineIdleColor = System.Drawing.Color.Gray
        Me.Txt_NombreUsuario.LineMouseHoverColor = System.Drawing.Color.Blue
        Me.Txt_NombreUsuario.LineThickness = 5
        Me.Txt_NombreUsuario.Location = New System.Drawing.Point(4, 194)
        Me.Txt_NombreUsuario.Margin = New System.Windows.Forms.Padding(4)
        Me.Txt_NombreUsuario.Name = "Txt_NombreUsuario"
        Me.Txt_NombreUsuario.Size = New System.Drawing.Size(283, 57)
        Me.Txt_NombreUsuario.TabIndex = 1
        Me.Txt_NombreUsuario.Text = "Nombre de Usuario"
        Me.Txt_NombreUsuario.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Txt_Contrasena
        '
        Me.Txt_Contrasena.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Txt_Contrasena.Font = New System.Drawing.Font("Open Sans", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_Contrasena.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Txt_Contrasena.HintForeColor = System.Drawing.Color.Empty
        Me.Txt_Contrasena.HintText = ""
        Me.Txt_Contrasena.isPassword = False
        Me.Txt_Contrasena.LineFocusedColor = System.Drawing.Color.Blue
        Me.Txt_Contrasena.LineIdleColor = System.Drawing.Color.Gray
        Me.Txt_Contrasena.LineMouseHoverColor = System.Drawing.Color.Blue
        Me.Txt_Contrasena.LineThickness = 5
        Me.Txt_Contrasena.Location = New System.Drawing.Point(4, 259)
        Me.Txt_Contrasena.Margin = New System.Windows.Forms.Padding(4)
        Me.Txt_Contrasena.Name = "Txt_Contrasena"
        Me.Txt_Contrasena.Size = New System.Drawing.Size(283, 57)
        Me.Txt_Contrasena.TabIndex = 2
        Me.Txt_Contrasena.Text = "Contraseña"
        Me.Txt_Contrasena.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Lbl_InicioSesion
        '
        Me.Lbl_InicioSesion.AutoSize = True
        Me.Lbl_InicioSesion.BackColor = System.Drawing.Color.FromArgb(CType(CType(189, Byte), Integer), CType(CType(189, Byte), Integer), CType(CType(189, Byte), Integer))
        Me.Lbl_InicioSesion.Font = New System.Drawing.Font("Open Sans", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_InicioSesion.ForeColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(31, Byte), Integer))
        Me.Lbl_InicioSesion.Location = New System.Drawing.Point(43, 11)
        Me.Lbl_InicioSesion.Name = "Lbl_InicioSesion"
        Me.Lbl_InicioSesion.Size = New System.Drawing.Size(150, 26)
        Me.Lbl_InicioSesion.TabIndex = 5
        Me.Lbl_InicioSesion.Text = "Inicio de Sesión"
        '
        'BunifuDragControl1
        '
        Me.BunifuDragControl1.Fixed = True
        Me.BunifuDragControl1.Horizontal = True
        Me.BunifuDragControl1.TargetControl = Me.Pn_header
        Me.BunifuDragControl1.Vertical = True
        '
        'BunifuDragControl2
        '
        Me.BunifuDragControl2.Fixed = True
        Me.BunifuDragControl2.Horizontal = True
        Me.BunifuDragControl2.TargetControl = Me.Lbl_InicioSesion
        Me.BunifuDragControl2.Vertical = True
        '
        'BunifuFlatButton1
        '
        Me.BunifuFlatButton1.Activecolor = System.Drawing.Color.FromArgb(CType(CType(78, Byte), Integer), CType(CType(147, Byte), Integer), CType(CType(88, Byte), Integer))
        Me.BunifuFlatButton1.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.BunifuFlatButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BunifuFlatButton1.BorderRadius = 0
        Me.BunifuFlatButton1.ButtonText = "Iniciar Sesión"
        Me.BunifuFlatButton1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BunifuFlatButton1.DisabledColor = System.Drawing.Color.Gray
        Me.BunifuFlatButton1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(31, Byte), Integer))
        Me.BunifuFlatButton1.Iconcolor = System.Drawing.Color.Transparent
        Me.BunifuFlatButton1.Iconimage = Nothing
        Me.BunifuFlatButton1.Iconimage_right = Nothing
        Me.BunifuFlatButton1.Iconimage_right_Selected = Nothing
        Me.BunifuFlatButton1.Iconimage_Selected = Nothing
        Me.BunifuFlatButton1.IconMarginLeft = 0
        Me.BunifuFlatButton1.IconMarginRight = 0
        Me.BunifuFlatButton1.IconRightVisible = True
        Me.BunifuFlatButton1.IconRightZoom = 0R
        Me.BunifuFlatButton1.IconVisible = True
        Me.BunifuFlatButton1.IconZoom = 90.0R
        Me.BunifuFlatButton1.IsTab = False
        Me.BunifuFlatButton1.Location = New System.Drawing.Point(6, 327)
        Me.BunifuFlatButton1.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.BunifuFlatButton1.Name = "BunifuFlatButton1"
        Me.BunifuFlatButton1.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.BunifuFlatButton1.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.BunifuFlatButton1.OnHoverTextColor = System.Drawing.Color.White
        Me.BunifuFlatButton1.selected = False
        Me.BunifuFlatButton1.Size = New System.Drawing.Size(279, 68)
        Me.BunifuFlatButton1.TabIndex = 3
        Me.BunifuFlatButton1.Text = "Iniciar Sesión"
        Me.BunifuFlatButton1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.BunifuFlatButton1.Textcolor = System.Drawing.Color.White
        Me.BunifuFlatButton1.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.PictureBox1.Image = Global.RecomendacionesRestaurantes.My.Resources.Resources.ico_user
        Me.PictureBox1.Location = New System.Drawing.Point(45, 3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(200, 184)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.RecomendacionesRestaurantes.My.Resources.Resources.ico_form2
        Me.PictureBox2.Location = New System.Drawing.Point(5, 7)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(32, 32)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 6
        Me.PictureBox2.TabStop = False
        '
        'Btn_Cerrar
        '
        Me.Btn_Cerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Btn_Cerrar.BackColor = System.Drawing.Color.FromArgb(CType(CType(189, Byte), Integer), CType(CType(189, Byte), Integer), CType(CType(189, Byte), Integer))
        Me.Btn_Cerrar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn_Cerrar.Image = Global.RecomendacionesRestaurantes.My.Resources.Resources.ico_cerrar2
        Me.Btn_Cerrar.ImageActive = Nothing
        Me.Btn_Cerrar.Location = New System.Drawing.Point(254, 12)
        Me.Btn_Cerrar.Name = "Btn_Cerrar"
        Me.Btn_Cerrar.Size = New System.Drawing.Size(25, 25)
        Me.Btn_Cerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Btn_Cerrar.TabIndex = 4
        Me.Btn_Cerrar.TabStop = False
        Me.Btn_Cerrar.Zoom = 20
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(291, 446)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.Pn_header)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form3"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form3"
        Me.Pn_header.ResumeLayout(False)
        Me.Pn_header.PerformLayout()
        Me.TableLayoutPanel1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Btn_Cerrar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BunifuElipse1 As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents Pn_header As Panel
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Btn_Cerrar As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Txt_Contrasena As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents Txt_NombreUsuario As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents Lbl_InicioSesion As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BunifuDragControl1 As Bunifu.Framework.UI.BunifuDragControl
    Friend WithEvents BunifuDragControl2 As Bunifu.Framework.UI.BunifuDragControl
    Friend WithEvents BunifuFlatButton1 As Bunifu.Framework.UI.BunifuFlatButton
End Class
