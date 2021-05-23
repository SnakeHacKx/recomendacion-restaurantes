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

    ' Comidas del dia
    Private _sirveDesayuno As Boolean = False
    Private _sirveAlmuerzo As Boolean = False
    Private _sirveCena As Boolean = False

    ' Formas de pago
    Private _aceptaTarjetaCredito As Boolean = False
    Private _aceptaEfectivo As Boolean = False
    Private _aceptaYappy As Boolean = False

    ' Tipo de despacho
    Private _entregaDomicilio As Boolean = False
    Private _entregaEnLocal As Boolean = False

    Public Sub New(id As String)
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

    Property SirveAmuerzo As Boolean
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

    Private Sub HacerDescripcion()
        Dim txt_descripcion As String
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

        ' Subtitulos
        Dim sub_general As String = "Generalidades"
        Dim sub_comidasDia As String = "Comidas del Día"
        Dim sub_metodosPago As String = "Métodos de Pago"
        Dim sub_tipoDespacho As String = "Tipo de Despacho"

        txt_tipo = String.Format("Tipo de Restaurante: {0}", _tipo)
        txt_direccion = String.Format("Dirección: {0}", _direccion)
        txt_especialidad = String.Format("Especialidad: {0}", _especialidad)
        txt_horario = String.Format("Horario: {0}", Str(_horario))
        txt_presupuestoMin = String.Format("Presupuesto Mínimo: {0}", Str(_presupuestoMinimo))

        txt_abierto = String.Format("Abierto en este momento: ")
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

        _descripcion &= sub_general & vbNewLine &
                        txt_tipo & vbNewLine &
                        txt_especialidad & vbNewLine &
                        txt_direccion & vbNewLine &
                        txt_presupuestoMin & vbNewLine &
                        txt_abierto & vbNewLine &
                        txt_horario & vbNewLine &



        _descripcion = txt_descripcion
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
