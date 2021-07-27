<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form2
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
        Me.BunifuElipse1 = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.Pn_header = New System.Windows.Forms.Panel()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.BunifuCustomLabel1 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.Btn_Cerrar = New Bunifu.Framework.UI.BunifuImageButton()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Lbl_TituloRestaurante = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
        Me.Pic_Restaurante = New System.Windows.Forms.PictureBox()
        Me.DescripcionRestaurante = New System.Windows.Forms.RichTextBox()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.Btn_Menu1 = New Bunifu.Framework.UI.BunifuImageButton()
        Me.Btn_Menu2 = New Bunifu.Framework.UI.BunifuImageButton()
        Me.Btn_Menu3 = New Bunifu.Framework.UI.BunifuImageButton()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.BunifuCustomLabel2 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuRating1 = New Bunifu.Framework.UI.BunifuRating()
        Me.Btn_Favorito = New Bunifu.Framework.UI.BunifuImageButton()
        Me.BunifuDragControl1 = New Bunifu.Framework.UI.BunifuDragControl(Me.components)
        Me.Pn_header.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Btn_Cerrar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.TableLayoutPanel3.SuspendLayout()
        CType(Me.Pic_Restaurante, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FlowLayoutPanel1.SuspendLayout()
        CType(Me.Btn_Menu1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Btn_Menu2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Btn_Menu3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel2.SuspendLayout()
        CType(Me.Btn_Favorito, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.Pn_header.Controls.Add(Me.BunifuCustomLabel1)
        Me.Pn_header.Controls.Add(Me.Btn_Cerrar)
        Me.Pn_header.Dock = System.Windows.Forms.DockStyle.Top
        Me.Pn_header.Location = New System.Drawing.Point(0, 0)
        Me.Pn_header.Name = "Pn_header"
        Me.Pn_header.Size = New System.Drawing.Size(936, 45)
        Me.Pn_header.TabIndex = 0
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
        'BunifuCustomLabel1
        '
        Me.BunifuCustomLabel1.AutoSize = True
        Me.BunifuCustomLabel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(189, Byte), Integer), CType(CType(189, Byte), Integer), CType(CType(189, Byte), Integer))
        Me.BunifuCustomLabel1.Font = New System.Drawing.Font("Open Sans", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(31, Byte), Integer))
        Me.BunifuCustomLabel1.Location = New System.Drawing.Point(43, 11)
        Me.BunifuCustomLabel1.Name = "BunifuCustomLabel1"
        Me.BunifuCustomLabel1.Size = New System.Drawing.Size(269, 26)
        Me.BunifuCustomLabel1.TabIndex = 5
        Me.BunifuCustomLabel1.Text = "Información del Restaurante"
        '
        'Btn_Cerrar
        '
        Me.Btn_Cerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Btn_Cerrar.BackColor = System.Drawing.Color.FromArgb(CType(CType(189, Byte), Integer), CType(CType(189, Byte), Integer), CType(CType(189, Byte), Integer))
        Me.Btn_Cerrar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn_Cerrar.Image = Global.RecomendacionesRestaurantes.My.Resources.Resources.ico_cerrar2
        Me.Btn_Cerrar.ImageActive = Nothing
        Me.Btn_Cerrar.Location = New System.Drawing.Point(899, 12)
        Me.Btn_Cerrar.Name = "Btn_Cerrar"
        Me.Btn_Cerrar.Size = New System.Drawing.Size(25, 25)
        Me.Btn_Cerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Btn_Cerrar.TabIndex = 4
        Me.Btn_Cerrar.TabStop = False
        Me.Btn_Cerrar.Zoom = 20
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.Lbl_TituloRestaurante, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel3, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.FlowLayoutPanel1, 0, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel2, 0, 2)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 45)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 4
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.45833!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 88.54166!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 56.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 297.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(936, 906)
        Me.TableLayoutPanel1.TabIndex = 1
        '
        'Lbl_TituloRestaurante
        '
        Me.Lbl_TituloRestaurante.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Lbl_TituloRestaurante.AutoSize = True
        Me.Lbl_TituloRestaurante.Font = New System.Drawing.Font("PT Sans", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_TituloRestaurante.ForeColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(31, Byte), Integer))
        Me.Lbl_TituloRestaurante.Location = New System.Drawing.Point(308, 10)
        Me.Lbl_TituloRestaurante.Name = "Lbl_TituloRestaurante"
        Me.Lbl_TituloRestaurante.Size = New System.Drawing.Size(319, 42)
        Me.Lbl_TituloRestaurante.TabIndex = 7
        Me.Lbl_TituloRestaurante.Text = "Título del Restaurante"
        '
        'TableLayoutPanel3
        '
        Me.TableLayoutPanel3.ColumnCount = 2
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel3.Controls.Add(Me.Pic_Restaurante, 0, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.DescripcionRestaurante, 1, 0)
        Me.TableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(3, 66)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RowCount = 1
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(930, 483)
        Me.TableLayoutPanel3.TabIndex = 10
        '
        'Pic_Restaurante
        '
        Me.Pic_Restaurante.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Pic_Restaurante.Image = Global.RecomendacionesRestaurantes.My.Resources.Resources.ico_mcdonalds
        Me.Pic_Restaurante.Location = New System.Drawing.Point(3, 3)
        Me.Pic_Restaurante.Name = "Pic_Restaurante"
        Me.Pic_Restaurante.Size = New System.Drawing.Size(459, 477)
        Me.Pic_Restaurante.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Pic_Restaurante.TabIndex = 10
        Me.Pic_Restaurante.TabStop = False
        '
        'DescripcionRestaurante
        '
        Me.DescripcionRestaurante.BackColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.DescripcionRestaurante.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DescripcionRestaurante.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DescripcionRestaurante.Font = New System.Drawing.Font("Open Sans", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DescripcionRestaurante.Location = New System.Drawing.Point(468, 3)
        Me.DescripcionRestaurante.Name = "DescripcionRestaurante"
        Me.DescripcionRestaurante.ReadOnly = True
        Me.DescripcionRestaurante.Size = New System.Drawing.Size(459, 477)
        Me.DescripcionRestaurante.TabIndex = 11
        Me.DescripcionRestaurante.Text = "Descripción"
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.AutoScroll = True
        Me.FlowLayoutPanel1.Controls.Add(Me.Btn_Menu1)
        Me.FlowLayoutPanel1.Controls.Add(Me.Btn_Menu2)
        Me.FlowLayoutPanel1.Controls.Add(Me.Btn_Menu3)
        Me.FlowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(3, 611)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Padding = New System.Windows.Forms.Padding(10)
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(930, 292)
        Me.FlowLayoutPanel1.TabIndex = 11
        '
        'Btn_Menu1
        '
        Me.Btn_Menu1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Btn_Menu1.BackColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.Btn_Menu1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn_Menu1.Image = Global.RecomendacionesRestaurantes.My.Resources.Resources.menu1
        Me.Btn_Menu1.ImageActive = Nothing
        Me.Btn_Menu1.Location = New System.Drawing.Point(13, 60)
        Me.Btn_Menu1.Name = "Btn_Menu1"
        Me.Btn_Menu1.Size = New System.Drawing.Size(350, 350)
        Me.Btn_Menu1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Btn_Menu1.TabIndex = 0
        Me.Btn_Menu1.TabStop = False
        Me.Btn_Menu1.Zoom = 0
        '
        'Btn_Menu2
        '
        Me.Btn_Menu2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Btn_Menu2.BackColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.Btn_Menu2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn_Menu2.Image = Global.RecomendacionesRestaurantes.My.Resources.Resources.menu2
        Me.Btn_Menu2.ImageActive = Nothing
        Me.Btn_Menu2.Location = New System.Drawing.Point(369, 13)
        Me.Btn_Menu2.Name = "Btn_Menu2"
        Me.Btn_Menu2.Size = New System.Drawing.Size(522, 445)
        Me.Btn_Menu2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Btn_Menu2.TabIndex = 1
        Me.Btn_Menu2.TabStop = False
        Me.Btn_Menu2.Zoom = 0
        '
        'Btn_Menu3
        '
        Me.Btn_Menu3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Btn_Menu3.BackColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.Btn_Menu3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn_Menu3.Image = Global.RecomendacionesRestaurantes.My.Resources.Resources.menu3
        Me.Btn_Menu3.ImageActive = Nothing
        Me.Btn_Menu3.Location = New System.Drawing.Point(13, 464)
        Me.Btn_Menu3.Name = "Btn_Menu3"
        Me.Btn_Menu3.Size = New System.Drawing.Size(895, 350)
        Me.Btn_Menu3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Btn_Menu3.TabIndex = 2
        Me.Btn_Menu3.TabStop = False
        Me.Btn_Menu3.Zoom = 0
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TableLayoutPanel2.ColumnCount = 3
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 292.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 340.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.BunifuCustomLabel2, 1, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.BunifuRating1, 2, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.Btn_Favorito, 0, 0)
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(113, 555)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 1
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(710, 50)
        Me.TableLayoutPanel2.TabIndex = 5
        '
        'BunifuCustomLabel2
        '
        Me.BunifuCustomLabel2.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.BunifuCustomLabel2.AutoSize = True
        Me.BunifuCustomLabel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.BunifuCustomLabel2.Font = New System.Drawing.Font("Open Sans", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(31, Byte), Integer))
        Me.BunifuCustomLabel2.Location = New System.Drawing.Point(81, 12)
        Me.BunifuCustomLabel2.Name = "BunifuCustomLabel2"
        Me.BunifuCustomLabel2.Size = New System.Drawing.Size(175, 26)
        Me.BunifuCustomLabel2.TabIndex = 4
        Me.BunifuCustomLabel2.Text = "Añadir a Favoritos"
        '
        'BunifuRating1
        '
        Me.BunifuRating1.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.BunifuRating1.BackColor = System.Drawing.Color.Transparent
        Me.BunifuRating1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BunifuRating1.ForeColor = System.Drawing.Color.SeaGreen
        Me.BunifuRating1.Location = New System.Drawing.Point(373, 3)
        Me.BunifuRating1.Name = "BunifuRating1"
        Me.BunifuRating1.Size = New System.Drawing.Size(316, 44)
        Me.BunifuRating1.TabIndex = 5
        Me.BunifuRating1.Value = 0
        '
        'Btn_Favorito
        '
        Me.Btn_Favorito.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Btn_Favorito.BackColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.Btn_Favorito.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn_Favorito.Image = Global.RecomendacionesRestaurantes.My.Resources.Resources.ico_corazonvacio
        Me.Btn_Favorito.ImageActive = Nothing
        Me.Btn_Favorito.Location = New System.Drawing.Point(7, 3)
        Me.Btn_Favorito.Name = "Btn_Favorito"
        Me.Btn_Favorito.Size = New System.Drawing.Size(64, 44)
        Me.Btn_Favorito.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Btn_Favorito.TabIndex = 6
        Me.Btn_Favorito.TabStop = False
        Me.Btn_Favorito.Zoom = 20
        '
        'BunifuDragControl1
        '
        Me.BunifuDragControl1.Fixed = True
        Me.BunifuDragControl1.Horizontal = True
        Me.BunifuDragControl1.TargetControl = Me.Pn_header
        Me.BunifuDragControl1.Vertical = True
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(936, 951)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.Pn_header)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form2"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Form2"
        Me.Pn_header.ResumeLayout(False)
        Me.Pn_header.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Btn_Cerrar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.TableLayoutPanel3.ResumeLayout(False)
        CType(Me.Pic_Restaurante, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FlowLayoutPanel1.ResumeLayout(False)
        CType(Me.Btn_Menu1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Btn_Menu2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Btn_Menu3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel2.PerformLayout()
        CType(Me.Btn_Favorito, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BunifuElipse1 As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents Pn_header As Panel
    Friend WithEvents Btn_Cerrar As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents BunifuCustomLabel1 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents Lbl_TituloRestaurante As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents TableLayoutPanel3 As TableLayoutPanel
    Friend WithEvents Pic_Restaurante As PictureBox
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents BunifuDragControl1 As Bunifu.Framework.UI.BunifuDragControl
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents BunifuCustomLabel2 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BunifuRating1 As Bunifu.Framework.UI.BunifuRating
    Friend WithEvents Btn_Favorito As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents Btn_Menu1 As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents Btn_Menu2 As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents Btn_Menu3 As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents DescripcionRestaurante As RichTextBox
End Class
