<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmCine
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.lblCodigo = New System.Windows.Forms.Label()
        Me.lblTitulo = New System.Windows.Forms.Label()
        Me.lblDirector = New System.Windows.Forms.Label()
        Me.lblTema = New System.Windows.Forms.Label()
        Me.lblPais = New System.Windows.Forms.Label()
        Me.lblyear = New System.Windows.Forms.Label()
        Me.lblProtagonistas = New System.Windows.Forms.Label()
        Me.lblArgumento = New System.Windows.Forms.Label()
        Me.txtCodigo = New System.Windows.Forms.TextBox()
        Me.txtTitulo = New System.Windows.Forms.TextBox()
        Me.txtDirector = New System.Windows.Forms.TextBox()
        Me.txtPais = New System.Windows.Forms.TextBox()
        Me.txtYear = New System.Windows.Forms.TextBox()
        Me.txtProtagonistas = New System.Windows.Forms.TextBox()
        Me.txtArgumento = New System.Windows.Forms.TextBox()
        Me.chkbColor = New System.Windows.Forms.CheckBox()
        Me.PanelOrden = New System.Windows.Forms.Panel()
        Me.rbDes = New System.Windows.Forms.RadioButton()
        Me.rbAsc = New System.Windows.Forms.RadioButton()
        Me.cbOrdenar = New System.Windows.Forms.ComboBox()
        Me.lblOrdenacion = New System.Windows.Forms.Label()
        Me.cbTema = New System.Windows.Forms.ComboBox()
        Me.btnRegPrim = New System.Windows.Forms.Button()
        Me.btnRegAnt = New System.Windows.Forms.Button()
        Me.btnRegSig = New System.Windows.Forms.Button()
        Me.btnRegUlt = New System.Windows.Forms.Button()
        Me.btnNuevo = New System.Windows.Forms.Button()
        Me.btnEditar = New System.Windows.Forms.Button()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.btnBorrar = New System.Windows.Forms.Button()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.PanelOrden.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblCodigo
        '
        Me.lblCodigo.AutoSize = True
        Me.lblCodigo.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCodigo.Location = New System.Drawing.Point(122, 34)
        Me.lblCodigo.Name = "lblCodigo"
        Me.lblCodigo.Size = New System.Drawing.Size(86, 21)
        Me.lblCodigo.TabIndex = 0
        Me.lblCodigo.Text = "Código: "
        '
        'lblTitulo
        '
        Me.lblTitulo.AutoSize = True
        Me.lblTitulo.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitulo.Location = New System.Drawing.Point(144, 96)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(64, 21)
        Me.lblTitulo.TabIndex = 1
        Me.lblTitulo.Text = "Título: "
        '
        'lblDirector
        '
        Me.lblDirector.AutoSize = True
        Me.lblDirector.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDirector.Location = New System.Drawing.Point(119, 158)
        Me.lblDirector.Name = "lblDirector"
        Me.lblDirector.Size = New System.Drawing.Size(89, 21)
        Me.lblDirector.TabIndex = 2
        Me.lblDirector.Text = "Director: "
        '
        'lblTema
        '
        Me.lblTema.AutoSize = True
        Me.lblTema.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTema.Location = New System.Drawing.Point(139, 220)
        Me.lblTema.Name = "lblTema"
        Me.lblTema.Size = New System.Drawing.Size(69, 21)
        Me.lblTema.TabIndex = 3
        Me.lblTema.Text = "Tema: "
        '
        'lblPais
        '
        Me.lblPais.AutoSize = True
        Me.lblPais.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPais.Location = New System.Drawing.Point(155, 282)
        Me.lblPais.Name = "lblPais"
        Me.lblPais.Size = New System.Drawing.Size(53, 21)
        Me.lblPais.TabIndex = 4
        Me.lblPais.Text = "País: "
        '
        'lblyear
        '
        Me.lblyear.AutoSize = True
        Me.lblyear.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblyear.Location = New System.Drawing.Point(150, 344)
        Me.lblyear.Name = "lblyear"
        Me.lblyear.Size = New System.Drawing.Size(58, 21)
        Me.lblyear.TabIndex = 5
        Me.lblyear.Text = "Año: "
        '
        'lblProtagonistas
        '
        Me.lblProtagonistas.AutoSize = True
        Me.lblProtagonistas.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProtagonistas.Location = New System.Drawing.Point(70, 406)
        Me.lblProtagonistas.Name = "lblProtagonistas"
        Me.lblProtagonistas.Size = New System.Drawing.Size(138, 21)
        Me.lblProtagonistas.TabIndex = 6
        Me.lblProtagonistas.Text = "Protagonistas: "
        '
        'lblArgumento
        '
        Me.lblArgumento.AutoSize = True
        Me.lblArgumento.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblArgumento.Location = New System.Drawing.Point(86, 521)
        Me.lblArgumento.Name = "lblArgumento"
        Me.lblArgumento.Size = New System.Drawing.Size(122, 21)
        Me.lblArgumento.TabIndex = 7
        Me.lblArgumento.Text = "Argumento: "
        '
        'txtCodigo
        '
        Me.txtCodigo.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCodigo.Location = New System.Drawing.Point(223, 31)
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.ReadOnly = True
        Me.txtCodigo.Size = New System.Drawing.Size(106, 30)
        Me.txtCodigo.TabIndex = 36
        Me.txtCodigo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtTitulo
        '
        Me.txtTitulo.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTitulo.Location = New System.Drawing.Point(223, 93)
        Me.txtTitulo.Name = "txtTitulo"
        Me.txtTitulo.ReadOnly = True
        Me.txtTitulo.Size = New System.Drawing.Size(542, 30)
        Me.txtTitulo.TabIndex = 9
        '
        'txtDirector
        '
        Me.txtDirector.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDirector.Location = New System.Drawing.Point(223, 155)
        Me.txtDirector.Name = "txtDirector"
        Me.txtDirector.ReadOnly = True
        Me.txtDirector.Size = New System.Drawing.Size(542, 30)
        Me.txtDirector.TabIndex = 10
        '
        'txtPais
        '
        Me.txtPais.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPais.Location = New System.Drawing.Point(223, 279)
        Me.txtPais.Name = "txtPais"
        Me.txtPais.ReadOnly = True
        Me.txtPais.Size = New System.Drawing.Size(270, 30)
        Me.txtPais.TabIndex = 11
        '
        'txtYear
        '
        Me.txtYear.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtYear.Location = New System.Drawing.Point(223, 341)
        Me.txtYear.Name = "txtYear"
        Me.txtYear.ReadOnly = True
        Me.txtYear.Size = New System.Drawing.Size(106, 30)
        Me.txtYear.TabIndex = 12
        Me.txtYear.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtProtagonistas
        '
        Me.txtProtagonistas.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtProtagonistas.Location = New System.Drawing.Point(223, 403)
        Me.txtProtagonistas.Multiline = True
        Me.txtProtagonistas.Name = "txtProtagonistas"
        Me.txtProtagonistas.ReadOnly = True
        Me.txtProtagonistas.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtProtagonistas.Size = New System.Drawing.Size(542, 84)
        Me.txtProtagonistas.TabIndex = 13
        '
        'txtArgumento
        '
        Me.txtArgumento.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtArgumento.Location = New System.Drawing.Point(223, 518)
        Me.txtArgumento.Multiline = True
        Me.txtArgumento.Name = "txtArgumento"
        Me.txtArgumento.ReadOnly = True
        Me.txtArgumento.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtArgumento.Size = New System.Drawing.Size(542, 206)
        Me.txtArgumento.TabIndex = 14
        '
        'chkbColor
        '
        Me.chkbColor.AutoSize = True
        Me.chkbColor.Enabled = False
        Me.chkbColor.Font = New System.Drawing.Font("Century Gothic", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkbColor.Location = New System.Drawing.Point(358, 343)
        Me.chkbColor.Name = "chkbColor"
        Me.chkbColor.Size = New System.Drawing.Size(77, 25)
        Me.chkbColor.TabIndex = 15
        Me.chkbColor.Text = "Color"
        Me.chkbColor.UseVisualStyleBackColor = True
        '
        'PanelOrden
        '
        Me.PanelOrden.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PanelOrden.Controls.Add(Me.rbDes)
        Me.PanelOrden.Controls.Add(Me.rbAsc)
        Me.PanelOrden.Controls.Add(Me.cbOrdenar)
        Me.PanelOrden.Location = New System.Drawing.Point(839, 31)
        Me.PanelOrden.Name = "PanelOrden"
        Me.PanelOrden.Size = New System.Drawing.Size(217, 148)
        Me.PanelOrden.TabIndex = 16
        '
        'rbDes
        '
        Me.rbDes.AutoSize = True
        Me.rbDes.Location = New System.Drawing.Point(35, 105)
        Me.rbDes.Name = "rbDes"
        Me.rbDes.Size = New System.Drawing.Size(130, 24)
        Me.rbDes.TabIndex = 20
        Me.rbDes.Text = "Descendente"
        Me.rbDes.UseVisualStyleBackColor = True
        '
        'rbAsc
        '
        Me.rbAsc.AutoSize = True
        Me.rbAsc.Checked = True
        Me.rbAsc.Font = New System.Drawing.Font("Century Gothic", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbAsc.Location = New System.Drawing.Point(35, 69)
        Me.rbAsc.Name = "rbAsc"
        Me.rbAsc.Size = New System.Drawing.Size(132, 25)
        Me.rbAsc.TabIndex = 19
        Me.rbAsc.TabStop = True
        Me.rbAsc.Text = "Ascendente"
        Me.rbAsc.UseVisualStyleBackColor = True
        '
        'cbOrdenar
        '
        Me.cbOrdenar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbOrdenar.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbOrdenar.FormattingEnabled = True
        Me.cbOrdenar.Items.AddRange(New Object() {"Año", "Código", "Director", "País", "Título"})
        Me.cbOrdenar.Location = New System.Drawing.Point(35, 28)
        Me.cbOrdenar.Name = "cbOrdenar"
        Me.cbOrdenar.Size = New System.Drawing.Size(165, 30)
        Me.cbOrdenar.TabIndex = 18
        '
        'lblOrdenacion
        '
        Me.lblOrdenacion.AutoSize = True
        Me.lblOrdenacion.Font = New System.Drawing.Font("Century Gothic", 8.0!)
        Me.lblOrdenacion.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblOrdenacion.Location = New System.Drawing.Point(857, 19)
        Me.lblOrdenacion.Name = "lblOrdenacion"
        Me.lblOrdenacion.Size = New System.Drawing.Size(104, 21)
        Me.lblOrdenacion.TabIndex = 1
        Me.lblOrdenacion.Text = "Ordenación"
        '
        'cbTema
        '
        Me.cbTema.Enabled = False
        Me.cbTema.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbTema.FormattingEnabled = True
        Me.cbTema.Location = New System.Drawing.Point(223, 212)
        Me.cbTema.Name = "cbTema"
        Me.cbTema.Size = New System.Drawing.Size(270, 29)
        Me.cbTema.TabIndex = 17
        '
        'btnRegPrim
        '
        Me.btnRegPrim.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRegPrim.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRegPrim.Location = New System.Drawing.Point(330, 751)
        Me.btnRegPrim.Name = "btnRegPrim"
        Me.btnRegPrim.Size = New System.Drawing.Size(65, 50)
        Me.btnRegPrim.TabIndex = 18
        Me.btnRegPrim.Text = "<<"
        Me.btnRegPrim.UseVisualStyleBackColor = True
        '
        'btnRegAnt
        '
        Me.btnRegAnt.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRegAnt.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRegAnt.Location = New System.Drawing.Point(416, 751)
        Me.btnRegAnt.Name = "btnRegAnt"
        Me.btnRegAnt.Size = New System.Drawing.Size(65, 50)
        Me.btnRegAnt.TabIndex = 19
        Me.btnRegAnt.Text = "<"
        Me.btnRegAnt.UseVisualStyleBackColor = True
        '
        'btnRegSig
        '
        Me.btnRegSig.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRegSig.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRegSig.Location = New System.Drawing.Point(502, 751)
        Me.btnRegSig.Name = "btnRegSig"
        Me.btnRegSig.Size = New System.Drawing.Size(65, 50)
        Me.btnRegSig.TabIndex = 20
        Me.btnRegSig.Text = ">"
        Me.btnRegSig.UseVisualStyleBackColor = True
        '
        'btnRegUlt
        '
        Me.btnRegUlt.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRegUlt.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRegUlt.Location = New System.Drawing.Point(588, 751)
        Me.btnRegUlt.Name = "btnRegUlt"
        Me.btnRegUlt.Size = New System.Drawing.Size(65, 50)
        Me.btnRegUlt.TabIndex = 21
        Me.btnRegUlt.Text = ">>"
        Me.btnRegUlt.UseVisualStyleBackColor = True
        '
        'btnNuevo
        '
        Me.btnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNuevo.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNuevo.Location = New System.Drawing.Point(900, 215)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(120, 50)
        Me.btnNuevo.TabIndex = 22
        Me.btnNuevo.Text = "Nuevo"
        Me.btnNuevo.UseVisualStyleBackColor = True
        '
        'btnEditar
        '
        Me.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEditar.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEditar.Location = New System.Drawing.Point(900, 303)
        Me.btnEditar.Name = "btnEditar"
        Me.btnEditar.Size = New System.Drawing.Size(120, 50)
        Me.btnEditar.TabIndex = 23
        Me.btnEditar.Text = "Editar"
        Me.btnEditar.UseVisualStyleBackColor = True
        '
        'btnGuardar
        '
        Me.btnGuardar.Enabled = False
        Me.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGuardar.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGuardar.Location = New System.Drawing.Point(900, 391)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(120, 50)
        Me.btnGuardar.TabIndex = 24
        Me.btnGuardar.Text = "Guardar"
        Me.btnGuardar.UseVisualStyleBackColor = True
        '
        'btnCancelar
        '
        Me.btnCancelar.Enabled = False
        Me.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancelar.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancelar.Location = New System.Drawing.Point(900, 476)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(120, 50)
        Me.btnCancelar.TabIndex = 25
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'btnBorrar
        '
        Me.btnBorrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBorrar.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBorrar.Location = New System.Drawing.Point(900, 564)
        Me.btnBorrar.Name = "btnBorrar"
        Me.btnBorrar.Size = New System.Drawing.Size(120, 50)
        Me.btnBorrar.TabIndex = 26
        Me.btnBorrar.Text = "Borrar"
        Me.btnBorrar.UseVisualStyleBackColor = True
        '
        'btnSalir
        '
        Me.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSalir.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSalir.Location = New System.Drawing.Point(900, 753)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(120, 50)
        Me.btnSalir.TabIndex = 27
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'frmCine
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(1083, 844)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnBorrar)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.btnEditar)
        Me.Controls.Add(Me.btnNuevo)
        Me.Controls.Add(Me.btnRegUlt)
        Me.Controls.Add(Me.btnRegSig)
        Me.Controls.Add(Me.btnRegAnt)
        Me.Controls.Add(Me.btnRegPrim)
        Me.Controls.Add(Me.cbTema)
        Me.Controls.Add(Me.lblOrdenacion)
        Me.Controls.Add(Me.PanelOrden)
        Me.Controls.Add(Me.chkbColor)
        Me.Controls.Add(Me.txtArgumento)
        Me.Controls.Add(Me.txtProtagonistas)
        Me.Controls.Add(Me.txtYear)
        Me.Controls.Add(Me.txtPais)
        Me.Controls.Add(Me.txtDirector)
        Me.Controls.Add(Me.txtTitulo)
        Me.Controls.Add(Me.txtCodigo)
        Me.Controls.Add(Me.lblArgumento)
        Me.Controls.Add(Me.lblProtagonistas)
        Me.Controls.Add(Me.lblyear)
        Me.Controls.Add(Me.lblPais)
        Me.Controls.Add(Me.lblTema)
        Me.Controls.Add(Me.lblDirector)
        Me.Controls.Add(Me.lblTitulo)
        Me.Controls.Add(Me.lblCodigo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "frmCine"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Películas"
        Me.PanelOrden.ResumeLayout(False)
        Me.PanelOrden.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblCodigo As Label
    Friend WithEvents lblTitulo As Label
    Friend WithEvents lblDirector As Label
    Friend WithEvents lblTema As Label
    Friend WithEvents lblPais As Label
    Friend WithEvents lblyear As Label
    Friend WithEvents lblProtagonistas As Label
    Friend WithEvents lblArgumento As Label
    Friend WithEvents txtCodigo As TextBox
    Friend WithEvents txtTitulo As TextBox
    Friend WithEvents txtDirector As TextBox
    Friend WithEvents txtPais As TextBox
    Friend WithEvents txtYear As TextBox
    Friend WithEvents txtProtagonistas As TextBox
    Friend WithEvents txtArgumento As TextBox
    Friend WithEvents chkbColor As CheckBox
    Friend WithEvents PanelOrden As Panel
    Friend WithEvents rbDes As RadioButton
    Friend WithEvents rbAsc As RadioButton
    Friend WithEvents cbOrdenar As ComboBox
    Friend WithEvents lblOrdenacion As Label
    Friend WithEvents cbTema As ComboBox
    Friend WithEvents btnRegPrim As Button
    Friend WithEvents btnRegAnt As Button
    Friend WithEvents btnRegSig As Button
    Friend WithEvents btnRegUlt As Button
    Friend WithEvents btnNuevo As Button
    Friend WithEvents btnEditar As Button
    Friend WithEvents btnGuardar As Button
    Friend WithEvents btnCancelar As Button
    Friend WithEvents btnBorrar As Button
    Friend WithEvents btnSalir As Button
End Class
