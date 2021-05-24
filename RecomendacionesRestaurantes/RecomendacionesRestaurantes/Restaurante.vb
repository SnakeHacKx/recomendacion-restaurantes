Public Class Restaurante
    Private _restauranteID As String

    ' Generales
    Private _descripcion As String = Nothing
    Private _direccion As String = Nothing
    Private _tipo As String = Nothing
    Private _especialidad As String = Nothing
    Private _horario As DateTime
    Private _abierto As Boolean = False
    Private _presupuestoMinimo As Integer = 0
    Private _telefono As String = Nothing

    ' Comidas del dia
    Private _sirveDesayuno As Boolean = False
    Private _sirveAlmuerzo As Boolean = False
    Private _sirveCena As Boolean = False

    ' Metodos de pago
    Private _aceptaTarjetaCredito As Boolean = False
    Private _aceptaEfectivo As Boolean = False
    Private _aceptaYappy As Boolean = False

    ' Tipo de despacho
    Private _entregaDomicilio As Boolean = False
    Private _entregaEnLocal As Boolean = False

    ' lista de etiquetas de tipo de restaurante
    Public tipoTags As New List(Of String)

    ' lista de etiquetas de las especialidades del restaurante
    Public especialidadTags As New List(Of String)

    ''' <summary>
    ''' Constructor de la clase Restaurante
    ''' </summary>
    ''' <param name="id">Identificador unico que le pertenece a cada restaurante</param>
    Public Sub New(id As String)
        ' Tener un identificador unico nos permitiria incluso poner varios restaurantes
        ' que se llamen igual (sucursales) y aun asi no tener problemas.
        Me._restauranteID = id
    End Sub

    Property ID As String
        Get
            Return _restauranteID
        End Get
        Set(value As String)
            _restauranteID = value
        End Set
    End Property

    Property Descripcion As String
        Get
            Return _descripcion
        End Get
        Set(value As String)
            _descripcion = value
        End Set
    End Property

    Property Direccion As String
        Get
            Return _direccion
        End Get
        Set(value As String)
            _direccion = value
        End Set
    End Property

    Property Telefono As String
        Get
            Return _telefono
        End Get
        Set(value As String)
            _telefono = value
        End Set
    End Property

    Property Tipo As String
        Get
            Return _tipo
        End Get
        Set(value As String)
            _tipo = value
        End Set
    End Property

    Property Especialidad As String
        Get
            Return _especialidad
        End Get
        Set(value As String)
            _especialidad = value
        End Set
    End Property

    Property Horario As DateTime
        Get
            Return _horario
        End Get
        Set(value As DateTime)
            _horario = value
        End Set
    End Property

    Property Abierto As Boolean
        Get
            Return _abierto
        End Get
        Set(value As Boolean)
            _abierto = value
        End Set
    End Property

    Property PresupuestoMinimo As Integer
        Get
            Return _presupuestoMinimo
        End Get
        Set(value As Integer)
            _presupuestoMinimo = value
        End Set
    End Property

    Property SirveDesayuno As Boolean
        Get
            Return _sirveDesayuno
        End Get
        Set(value As Boolean)
            _sirveDesayuno = value
        End Set
    End Property

    Property SirveAlmuerzo As Boolean
        Get
            Return _sirveAlmuerzo
        End Get
        Set(value As Boolean)
            _sirveAlmuerzo = value
        End Set
    End Property

    Property SirveCena As Boolean
        Get
            Return _sirveCena
        End Get
        Set(value As Boolean)
            _sirveCena = value
        End Set
    End Property

    Property AceptaTargetaCredito As Boolean
        Get
            Return _aceptaTarjetaCredito
        End Get
        Set(value As Boolean)
            _aceptaTarjetaCredito = value
        End Set
    End Property

    Property AceptaEfectivo As Boolean
        Get
            Return _aceptaEfectivo
        End Get
        Set(value As Boolean)
            _aceptaEfectivo = value
        End Set
    End Property

    Property AceptaYappy As Boolean
        Get
            Return _aceptaYappy
        End Get
        Set(value As Boolean)
            _aceptaYappy = value
        End Set
    End Property

    Property EntregaADomicilio As Boolean
        Get
            Return _entregaDomicilio
        End Get
        Set(value As Boolean)
            _entregaDomicilio = value
        End Set
    End Property

    Property EntregaEnLocal As Boolean
        Get
            Return _entregaEnLocal
        End Get
        Set(value As Boolean)
            _entregaEnLocal = value
        End Set
    End Property

    ''' <summary>
    ''' Agrega toda la informacion recogida en en el formulario 1,
    ''' a la propiedad <c>Descripcion</c>
    ''' </summary>
    Public Sub HacerDescripcion()
        Dim txt_tipo As String
        Dim txt_direccion As String
        Dim txt_especialidad As String
        Dim txt_horario As String
        Dim txt_abierto As String
        Dim txt_presupuestoMin As String
        Dim txt_sirveDesayuno As String
        Dim txt_sirveAlmuerzo As String
        Dim txt_sirveCena As String
        Dim txt_aceptaTCredito As String
        Dim txt_aceptaEfectivo As String
        Dim txt_aceptaYappy As String
        Dim txt_entregaADomicilio As String
        Dim txt_entregaEnLocal As String
        Dim txt_telefono As String

        ' Subtitulos
        Dim sub_general As String = "               *** Generalidades ***"
        Dim sub_comidasDia As String = "                *** Comidas del Día ***"
        Dim sub_metodosPago As String = "               *** Métodos de Pago ***"
        Dim sub_tipoDespacho As String = "              *** Tipo de Despacho ***"

        txt_tipo = String.Format("Tipo de Restaurante: {0}", _tipo)
        txt_direccion = String.Format("Dirección: {0}", _direccion)
        txt_especialidad = String.Format("Especialidad: {0}", _especialidad)
        'txt_horario = String.Format("Horario: {0}", Str(_horario))
        txt_presupuestoMin = String.Format("Presupuesto Mínimo: {0}", Str(_presupuestoMinimo))
        txt_telefono = String.Format("Teléfono: {0}", _telefono)

        ' Todo: Arreglar el abierto dependiendo del horario
        txt_abierto = String.Format("Abierto en este momento (Prueba): ")
        txt_abierto &= RespuestaBooleana(_abierto)

        txt_sirveDesayuno = String.Format("Sirve desayuno: ")
        txt_sirveDesayuno &= RespuestaBooleana(_sirveDesayuno)

        txt_sirveAlmuerzo = String.Format("Sirve almuerzo: ")
        txt_sirveAlmuerzo &= RespuestaBooleana(_sirveAlmuerzo)

        txt_sirveCena = String.Format("Sirve cena: ")
        txt_sirveCena &= RespuestaBooleana(_sirveCena)

        txt_aceptaTCredito = String.Format("Acepta tarjeta de crédito: ")
        txt_aceptaTCredito &= RespuestaBooleana(_aceptaTarjetaCredito)

        txt_aceptaEfectivo = String.Format("Acepta efectivo: ")
        txt_aceptaEfectivo &= RespuestaBooleana(_aceptaEfectivo)

        txt_aceptaYappy = String.Format("Acepta Yappy: ")
        txt_aceptaYappy &= RespuestaBooleana(_aceptaYappy)

        txt_entregaADomicilio = String.Format("Entrega a domicilio: ")
        txt_entregaADomicilio &= RespuestaBooleana2(_entregaDomicilio)

        txt_entregaEnLocal = String.Format("Entrega en local: ")
        txt_entregaEnLocal &= RespuestaBooleana2(_entregaEnLocal)

        'Todo: Agregar horario
        'txt_horario             & vbNewLine & 

        _descripcion = sub_general & vbNewLine &
                        txt_tipo & vbNewLine &
                        txt_especialidad & vbNewLine &
                        txt_direccion & vbNewLine &
                        txt_presupuestoMin & vbNewLine &
                        txt_telefono & vbNewLine &
                        txt_abierto & vbNewLine & vbNewLine &
                        sub_metodosPago & vbNewLine &
                        txt_aceptaTCredito & vbNewLine &
                        txt_aceptaEfectivo & vbNewLine &
                        txt_aceptaYappy & vbNewLine & vbNewLine &
                        sub_comidasDia & vbNewLine &
                        txt_sirveDesayuno & vbNewLine &
                        txt_sirveAlmuerzo & vbNewLine &
                        txt_sirveCena & vbNewLine & vbNewLine &
                        sub_tipoDespacho & vbNewLine &
                        txt_entregaADomicilio & vbNewLine &
                        txt_entregaEnLocal & vbNewLine
    End Sub

    Private Function RespuestaBooleana(esVerdadero As Boolean)
        If esVerdadero Then
            Return "Sí"
        Else
            Return "No"
        End If
    End Function

    Private Function RespuestaBooleana2(esVerdadero As Boolean)
        If esVerdadero Then
            Return "Disponible"
        Else
            Return "No Disponible"
        End If
    End Function
End Class
