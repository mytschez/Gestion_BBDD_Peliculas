Imports System.Data.SqlClient

Public Class frmCine
    'VARIABLES
    Dim registro As Integer = 0
    Dim longtabla As Integer 'para recoger el tamaño de la tabla
    'Declaramos una variable de tipo sqlConnection para la cadena de conexión
    Dim cnn As New SqlConnection("Data Source=.;Initial Catalog=Cine;Integrated Security=True")
    Dim dt As New DataTable() 'Tabla virtual
    Dim nuevoReg As Boolean = False ' para saber si tengo que guardar un nuevo registro o actualizar uno existente

    'LOAD
    Private Sub frmCine_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'el combo ordenación aparece marcado por defecto código
        cbOrdenar.SelectedIndex = 1
        'cargar el combo de temas
        cargarComboTemas()
        'cargar la tabla 
        cargarTabla()
        'comprobar si la tabla tiene registros, si no los tienen habilitar la opción de crear uno nuevo
        If longtabla = -1 Then
            Nuevo()
        Else
            'cargar los campos del formulario rellenados con los datos de bbdd
            cargarCamposForm(registro)
        End If
    End Sub

    'SALIR
    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Application.Exit()
    End Sub

    'SIGUIENTE
    Private Sub btnRegSig_Click(sender As Object, e As EventArgs) Handles btnRegSig.Click
        AntSigRegistro("siguiente")
    End Sub

    'ANTERIOR
    Private Sub btnRegAnt_Click(sender As Object, e As EventArgs) Handles btnRegAnt.Click
        AntSigRegistro("anterior")
    End Sub

    'ULTIMO REGISTRO
    Private Sub btnRegUlt_Click(sender As Object, e As EventArgs) Handles btnRegUlt.Click
        registro = longtabla
        cargarCamposForm(registro)
    End Sub

    'PRIMER REGISTO
    Private Sub btnRegPrim_Click(sender As Object, e As EventArgs) Handles btnRegPrim.Click
        registro = 0
        cargarCamposForm(registro)
    End Sub

    'NUEVO
    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        'habilitar sólo los botones de guardar y cancelar
        btnsGuardarCancel()
        Nuevo()
        nuevoReg = True
    End Sub

    'EDITAR
    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click
        'habilitar sólo los botones de guardar y cancelar
        btnsGuardarCancel()
        Editar()
        nuevoReg = False
    End Sub

    'GUARDAR
    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        'comprobar si tiene que guardar un nuevo registro(INSERT) o actualizar (UPDATE)
        If nuevoReg Then
            GuardarNuevoReg()
        Else
            EditarReg()
        End If
    End Sub

    'CANCELAR
    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        cargarComboTemas()
        cargarTabla()
        cargarCamposForm(registro)
        btnPordeft()
    End Sub

    'BORRAR
    Private Sub btnBorrar_Click(sender As Object, e As EventArgs) Handles btnBorrar.Click
        Dim result As DialogResult
        result = MessageBox.Show("¿Quiere borrar la película '" & txtTitulo.Text & "'?", "Borrar", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)
        If result = DialogResult.Yes Then
            BorrarReg()
        Else
            Me.Show()
        End If

    End Sub

    'ORDENAR
    Private Sub cbOrdenar_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbOrdenar.SelectedIndexChanged
        Ordenar()
    End Sub

    Private Sub rbDes_Click(sender As Object, e As EventArgs) Handles rbDes.Click
        Ordenar()
    End Sub

    Private Sub rbAsc_Click(sender As Object, e As EventArgs) Handles rbAsc.Click
        Ordenar()
    End Sub

#Region "Procedimientos"
    Private Sub cargarTabla()
        dt.Clear()
        Dim Consulta As New SqlCommand("SELECT * FROM Peliculas", cnn)
        Dim da As New SqlDataAdapter(Consulta)
        'cargamos los datos de la tabla de sql en nuestra tabla virtual (.fill)
        da.Fill(dt)

        'tamaño de la tabla
        longtabla = dt.Rows.Count - 1
    End Sub

    Private Sub cargarCamposForm(i As Integer)
        txtCodigo.Text = dt.Rows(i)("Ref").ToString()
        txtTitulo.Text = dt.Rows(i)("Titulo")

        If dt.Rows(i)("Director") Is DBNull.Value Then
            txtDirector.Text = ""
        Else
            txtDirector.Text = dt.Rows(i)("Director")
        End If
        If dt.Rows(i)("Tema") Is DBNull.Value Then
            cbTema.SelectedValue = ""
        Else
            cbTema.SelectedValue = dt.Rows(i)("Tema")
        End If
        If dt.Rows(i)("País") Is DBNull.Value Then
            txtPais.Text = ""
        Else
            txtPais.Text = dt.Rows(i)("País")
        End If
        If dt.Rows(i)("Año") Is DBNull.Value Then
            txtYear.Text = ""
        Else
            txtYear.Text = dt.Rows(i)("Año").ToString()
        End If
        If dt.Rows(i)("Protagonistas") Is DBNull.Value Then
            txtProtagonistas.Text = ""
        Else
            txtProtagonistas.Text = dt.Rows(i)("Protagonistas")
        End If
        If dt.Rows(i)("Argumento") Is DBNull.Value Then
            txtArgumento.Text = ""
        Else
            txtArgumento.Text = dt.Rows(i)("Argumento")
        End If

        If dt.Rows(i)("Color") Is DBNull.Value Then
            chkbColor.Checked = True
        ElseIf dt.Rows(i)("Color") = True Then
            chkbColor.Checked = True
        ElseIf dt.Rows(i)("Color") = False Then
            chkbColor.Checked = False
        End If
    End Sub

    Private Sub cargarComboTemas()
        'variable
        Dim dt_tema As New DataTable()

        'consulta de la bbdd para rellenar el combo de temas
        Dim ConsultaTema As New SqlCommand("SELECT DISTINCT Tema FROM Peliculas WHERE Tema IS NOT NULL ORDER BY Tema", cnn)
        'adaptador para cargar los datos de la tabla de sql
        Dim da As New SqlDataAdapter(ConsultaTema)
        'cargamos los datos de la tabla de sql en nuestra tabla virtual (.fill)
        da.Fill(dt_tema)

        'cargamos el combobox con los datos de la columna tema en la tabla peliculas
        cbTema.DataSource = dt_tema
        cbTema.ValueMember = "Tema"
        cbTema.DisplayMember = "Tema"

    End Sub

    'procedimiento para rellenar el formulario con una nueva película
    Private Sub Nuevo()
        'código no visible
        lblCodigo.Hide()
        txtCodigo.Hide()

        'focus en el título
        txtTitulo.Focus()

        'limpiar y habilitar campos
        txtTitulo.Clear()
        txtTitulo.ReadOnly = False

        txtDirector.Clear()
        txtDirector.ReadOnly = False

        cargarComboTemas()
        cbTema.Enabled = True
        cbTema.SelectedValue = ""

        txtPais.Clear()
        txtPais.ReadOnly = False

        txtYear.Clear()
        txtYear.ReadOnly = False

        txtProtagonistas.Clear()
        txtProtagonistas.ReadOnly = False

        chkbColor.Checked = True
        chkbColor.Enabled = True

        txtArgumento.Clear()
        txtArgumento.ReadOnly = False
    End Sub

    'procedimiento para editar 
    Private Sub Editar()
        'habilitar campos
        txtTitulo.ReadOnly = False
        txtDirector.ReadOnly = False
        cbTema.Enabled = True
        txtPais.ReadOnly = False
        txtYear.ReadOnly = False
        txtProtagonistas.ReadOnly = False
        chkbColor.Enabled = True
        txtArgumento.ReadOnly = False
    End Sub

    'procedimiento para crear un nuevo registro
    Private Sub GuardarNuevoReg()
        Try
            Dim cmdconsulta As String
            cmdconsulta = "INSERT INTO Peliculas (Titulo, Director, Tema, País, Año, Protagonistas, Color, Argumento) VALUES('"

            If txtTitulo.Text = "" Then
                MessageBox.Show("El título de la película no puede estar vacío")
            Else
                cmdconsulta = cmdconsulta & txtTitulo.Text & "', "
            End If
            If txtDirector.Text = "" Then
                cmdconsulta = cmdconsulta & "NULL, "
            Else
                cmdconsulta = cmdconsulta & "'" & txtDirector.Text & "', "
            End If
            If cbTema.Text = "" Then
                cmdconsulta = cmdconsulta & "NULL, "
            Else
                cmdconsulta = cmdconsulta & "'" & cbTema.Text & "', "
            End If
            If txtPais.Text = "" Then
                cmdconsulta = cmdconsulta & "NULL, "
            Else
                cmdconsulta = cmdconsulta & "'" & txtPais.Text & "', "
            End If
            If txtYear.Text = "" Then
                cmdconsulta = cmdconsulta & "NULL, "
            Else
                Dim AAAA As Integer
                Try
                    AAAA = Integer.Parse(txtYear.Text)
                    cmdconsulta = cmdconsulta & txtYear.Text & ", "
                Catch ex As Exception
                    MessageBox.Show("Debe introducir un número entero de 4 dígitos")
                End Try
            End If
            If txtProtagonistas.Text = "" Then
                cmdconsulta = cmdconsulta & "NULL, "
            Else
                cmdconsulta = cmdconsulta & "'" & txtProtagonistas.Text & "', "
            End If
            If chkbColor.Checked Then
                cmdconsulta = cmdconsulta & 1 & ", "
            Else
                cmdconsulta = cmdconsulta & 0 & ", "
            End If
            If txtArgumento.Text = "" Then
                cmdconsulta = cmdconsulta & "NULL)"
            Else
                cmdconsulta = cmdconsulta & "'" & txtArgumento.Text & "')"
            End If


            cnn.Open()
            Dim ConsultaNuevo As New SqlCommand(cmdconsulta, cnn)
            ConsultaNuevo.ExecuteNonQuery()
            cnn.Close()

            lblCodigo.Show()
            txtCodigo.Show()

            cargarComboTemas()
            cargarTabla()
            registro = longtabla
            cargarCamposForm(registro)

            btnPordeft()
        Catch ex As Exception
            MessageBox.Show("El registro no se ha podido guardar")
        End Try

    End Sub

    'procedimiento para editar un registro
    Private Sub EditarReg()
        Try
            Dim cmdconsulta As String
            cmdconsulta = "UPDATE Peliculas SET Titulo = "

            If txtTitulo.Text = "" Then
                MessageBox.Show("El título de la película no puede estar vacío")
            Else
                cmdconsulta = cmdconsulta & "'" & txtTitulo.Text & "', "
            End If

            If txtDirector.Text = "" Then
                cmdconsulta = cmdconsulta & "Director = NULL, "
            Else
                cmdconsulta = cmdconsulta & "Director = '" & txtDirector.Text & "', "
            End If
            If cbTema.Text = "" Then
                cmdconsulta = cmdconsulta & "Tema = NULL, "
            Else
                cmdconsulta = cmdconsulta & "Tema = '" & cbTema.Text & "', "
            End If
            If txtPais.Text = "" Then
                cmdconsulta = cmdconsulta & "País = NULL, "
            Else
                cmdconsulta = cmdconsulta & "País = '" & txtPais.Text & "', "
            End If
            If txtYear.Text = "" Then
                cmdconsulta = cmdconsulta & "Año = NULL, "
            Else
                Dim AAAA As Integer
                Try
                    AAAA = Integer.Parse(txtYear.Text)
                    cmdconsulta = cmdconsulta & "Año = " & txtYear.Text & ", "
                Catch ex As Exception
                    MessageBox.Show("El año debe ser un número entero de 4 dígitos")
                End Try
            End If
            If txtProtagonistas.Text = "" Then
                cmdconsulta = cmdconsulta & "Protagonistas = NULL, "
            Else
                cmdconsulta = cmdconsulta & "Protagonistas = '" & txtProtagonistas.Text & "', "
            End If
            If chkbColor.Checked Then
                cmdconsulta = cmdconsulta & "Color = " & 1 & ", "
            Else
                cmdconsulta = cmdconsulta & "Color = " & 0 & ", "
            End If
            If txtArgumento.Text = "" Then
                cmdconsulta = cmdconsulta & "Argumento = NULL "
            Else
                cmdconsulta = cmdconsulta & "Argumento = '" & txtArgumento.Text & "' "
            End If
            cmdconsulta = cmdconsulta & "WHERE Ref = " & txtCodigo.Text

            cnn.Open()
            Dim ConsultaEditar As New SqlCommand(cmdconsulta, cnn)
            ConsultaEditar.ExecuteNonQuery()
            cnn.Close()

            
            cargarComboTemas()
            cargarTabla()
            cargarCamposForm(registro)

            btnPordeft()
        Catch ex As Exception
            MessageBox.Show("El registro no se ha podido actualizar")
        End Try
    End Sub

    'procedimiento para borrar un registro 
    Private Sub BorrarReg()
        Try
            Dim cmdBorrar As String
            cmdBorrar = "DELETE FROM Peliculas WHERE Ref = " & txtCodigo.Text

            cnn.Open()
            Dim ConsultaBorrar As New SqlCommand(cmdBorrar, cnn)
            ConsultaBorrar.ExecuteNonQuery()
            cnn.Close()

            cargarComboTemas()
            cargarTabla()
            AntSigRegistro("anterior")
        Catch ex As Exception
            MessageBox.Show("El registro no se ha podido borrar")
        End Try

    End Sub

    'procedimiento para ordenar en función de las opciones seleccionadas en el panel
    Private Sub Ordenar()
        Dim cmdconsulta As String = "SELECT * FROM Peliculas ORDER BY "
        'ordenar en función de la opción elegida en el combobox

        Select Case cbOrdenar.SelectedIndex
            Case 0
                cmdconsulta = cmdconsulta & "Año"
            Case 1
                cmdconsulta = cmdconsulta & "Ref"
            Case 2
                cmdconsulta = cmdconsulta & "Director"
            Case 3
                cmdconsulta = cmdconsulta & "País"
            Case 4
                cmdconsulta = cmdconsulta & "Titulo"
        End Select

        If rbDes.Checked Then
            cmdconsulta = cmdconsulta & " DESC"
        End If

        dt.Clear()
        Dim ConsultaOrdenar As New SqlCommand(cmdconsulta, cnn)
        Dim da As New SqlDataAdapter(ConsultaOrdenar)
        da.Fill(dt)

        registro = 0
        cargarCamposForm(registro)
    End Sub


    'procedimiento para cambiar de registro hacia delante y hacia atrás
    Private Sub AntSigRegistro(pasar As String)
        If pasar = "siguiente" Then
            'si es el último resgistro vuelve al primero
            If registro = longtabla Then
                registro = 0
                cargarCamposForm(registro)
            Else
                registro += 1
                cargarCamposForm(registro)
            End If
        Else
            If pasar = "anterior" Then
                'si es el primer registro vuelve a mostrar el último
                If registro = 0 Then
                    registro = longtabla
                    cargarCamposForm(registro)
                Else
                    registro -= 1
                    cargarCamposForm(registro)
                End If
            End If
        End If
    End Sub


    'botones deshabilitados
    Private Sub btnsGuardarCancel()
        'deshabilitar los botones nuevo, editar, borrar
        btnNuevo.Enabled = False
        btnEditar.Enabled = False
        btnBorrar.Enabled = False
        'deshabilitar los botones para cambiar de registro
        btnRegPrim.Enabled = False
        btnRegAnt.Enabled = False
        btnRegSig.Enabled = False
        btnRegUlt.Enabled = False
        'deshabilitar el panel completo de ordenación
        cbOrdenar.Enabled = False
        rbAsc.Enabled = False
        rbDes.Enabled = False
        'habilitar los botones guardar y cancelar
        btnGuardar.Enabled = True
        btnCancelar.Enabled = True
    End Sub

    'botones por defecto
    Private Sub btnPordeft()
        txtTitulo.ReadOnly = True
        txtDirector.ReadOnly = True
        cbTema.Enabled = False
        txtPais.ReadOnly = True
        txtYear.ReadOnly = True
        chkbColor.Enabled = False
        txtProtagonistas.ReadOnly = True
        txtArgumento.ReadOnly = True

        lblCodigo.Show()
        txtCodigo.Show()

        btnRegSig.Enabled = True
        btnRegUlt.Enabled = True
        btnRegAnt.Enabled = True
        btnRegPrim.Enabled = True

        btnNuevo.Enabled = True
        btnEditar.Enabled = True
        btnGuardar.Enabled = False
        btnCancelar.Enabled = False
        btnBorrar.Enabled = True

        cbOrdenar.Enabled = True
        rbAsc.Enabled = True
        rbDes.Enabled = True
        cbOrdenar.SelectedIndex = 1
        rbAsc.Checked = True
    End Sub

#End Region

End Class
