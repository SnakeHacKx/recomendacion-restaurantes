<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form4
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
        Me.Pic_ShowImage = New System.Windows.Forms.PictureBox()
        Me.BunifuElipse1 = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.Pn_header = New System.Windows.Forms.Panel()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.BunifuCustomLabel1 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.Btn_Minimizar = New Bunifu.Framework.UI.BunifuImageButton()
        Me.Btn_Maximizar = New Bunifu.Framework.UI.BunifuImageButton()
        Me.Btn_Cerrar = New Bunifu.Framework.UI.BunifuImageButton()
        Me.BunifuDragControl1 = New Bunifu.Framework.UI.BunifuDragControl(Me.components)
        CType(Me.Pic_ShowImage, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Pn_header.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Btn_Minimizar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Btn_Maximizar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Btn_Cerrar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Pic_ShowImage
        '
        Me.Pic_ShowImage.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Pic_ShowImage.Location = New System.Drawing.Point(0, 36)
        Me.Pic_ShowImage.Name = "Pic_ShowImage"
        Me.Pic_ShowImage.Size = New System.Drawing.Size(813, 487)
        Me.Pic_ShowImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Pic_ShowImage.TabIndex = 0
        Me.Pic_ShowImage.TabStop = False
        '
        'BunifuElipse1
        '
        Me.BunifuElipse1.ElipseRadius = 5
        Me.BunifuElipse1.TargetControl = Me
        '
        'Pn_header
        '
        Me.Pn_header.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.Pn_header.Controls.Add(Me.PictureBox2)
        Me.Pn_header.Controls.Add(Me.BunifuCustomLabel1)
        Me.Pn_header.Controls.Add(Me.Btn_Minimizar)
        Me.Pn_header.Controls.Add(Me.Btn_Maximizar)
        Me.Pn_header.Controls.Add(Me.Btn_Cerrar)
        Me.Pn_header.Dock = System.Windows.Forms.DockStyle.Top
        Me.Pn_header.Location = New System.Drawing.Point(0, 0)
        Me.Pn_header.Name = "Pn_header"
        Me.Pn_header.Size = New System.Drawing.Size(813, 36)
        Me.Pn_header.TabIndex = 1
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.RecomendacionesRestaurantes.My.Resources.Resources.ico_form2
        Me.PictureBox2.Location = New System.Drawing.Point(2, 2)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(32, 32)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 9
        Me.PictureBox2.TabStop = False
        '
        'BunifuCustomLabel1
        '
        Me.BunifuCustomLabel1.AutoSize = True
        Me.BunifuCustomLabel1.Font = New System.Drawing.Font("Open Sans", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(232, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.BunifuCustomLabel1.Location = New System.Drawing.Point(40, 4)
        Me.BunifuCustomLabel1.Name = "BunifuCustomLabel1"
        Me.BunifuCustomLabel1.Size = New System.Drawing.Size(211, 26)
        Me.BunifuCustomLabel1.TabIndex = 10
        Me.BunifuCustomLabel1.Text = "Come, visita y disfruta"
        '
        'Btn_Minimizar
        '
        Me.Btn_Minimizar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Btn_Minimizar.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.Btn_Minimizar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn_Minimizar.Image = Global.RecomendacionesRestaurantes.My.Resources.Resources.ico_minimizar
        Me.Btn_Minimizar.ImageActive = Nothing
        Me.Btn_Minimizar.Location = New System.Drawing.Point(696, 5)
        Me.Btn_Minimizar.Name = "Btn_Minimizar"
        Me.Btn_Minimizar.Size = New System.Drawing.Size(25, 25)
        Me.Btn_Minimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Btn_Minimizar.TabIndex = 8
        Me.Btn_Minimizar.TabStop = False
        Me.Btn_Minimizar.Zoom = 20
        '
        'Btn_Maximizar
        '
        Me.Btn_Maximizar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Btn_Maximizar.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.Btn_Maximizar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn_Maximizar.Image = Global.RecomendacionesRestaurantes.My.Resources.Resources.ico_maximizar
        Me.Btn_Maximizar.ImageActive = Nothing
        Me.Btn_Maximizar.Location = New System.Drawing.Point(736, 5)
        Me.Btn_Maximizar.Name = "Btn_Maximizar"
        Me.Btn_Maximizar.Size = New System.Drawing.Size(25, 25)
        Me.Btn_Maximizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Btn_Maximizar.TabIndex = 7
        Me.Btn_Maximizar.TabStop = False
        Me.Btn_Maximizar.Zoom = 20
        '
        'Btn_Cerrar
        '
        Me.Btn_Cerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Btn_Cerrar.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.Btn_Cerrar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn_Cerrar.Image = Global.RecomendacionesRestaurantes.My.Resources.Resources.ico_cerrar
        Me.Btn_Cerrar.ImageActive = Nothing
        Me.Btn_Cerrar.Location = New System.Drawing.Point(776, 5)
        Me.Btn_Cerrar.Name = "Btn_Cerrar"
        Me.Btn_Cerrar.Size = New System.Drawing.Size(25, 25)
        Me.Btn_Cerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Btn_Cerrar.TabIndex = 6
        Me.Btn_Cerrar.TabStop = False
        Me.Btn_Cerrar.Zoom = 20
        '
        'BunifuDragControl1
        '
        Me.BunifuDragControl1.Fixed = True
        Me.BunifuDragControl1.Horizontal = True
        Me.BunifuDragControl1.TargetControl = Me.Pn_header
        Me.BunifuDragControl1.Vertical = True
        '
        'Form4
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(31, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(813, 523)
        Me.Controls.Add(Me.Pic_ShowImage)
        Me.Controls.Add(Me.Pn_header)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form4"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Form4"
        CType(Me.Pic_ShowImage, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Pn_header.ResumeLayout(False)
        Me.Pn_header.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Btn_Minimizar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Btn_Maximizar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Btn_Cerrar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Pic_ShowImage As PictureBox
    Friend WithEvents BunifuElipse1 As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents Pn_header As Panel
    Friend WithEvents Btn_Minimizar As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents Btn_Maximizar As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents Btn_Cerrar As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents BunifuCustomLabel1 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BunifuDragControl1 As Bunifu.Framework.UI.BunifuDragControl
End Class
