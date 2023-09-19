namespace ATM.WinForm.FrontEnd
{
    partial class frmPrincipal
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            DevComponents.DotNetBar.Keyboard.VirtualKeyboardColorTable virtualKeyboardColorTable31 = new DevComponents.DotNetBar.Keyboard.VirtualKeyboardColorTable();
            DevComponents.DotNetBar.Keyboard.FlatStyleRenderer flatStyleRenderer31 = new DevComponents.DotNetBar.Keyboard.FlatStyleRenderer();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle301 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle302 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle303 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle304 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle305 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle306 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle307 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle308 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle309 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle310 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle311 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle312 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle313 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle314 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle315 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle316 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle317 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle318 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle319 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle320 = new System.Windows.Forms.DataGridViewCellStyle();
            DevComponents.DotNetBar.Keyboard.VirtualKeyboardColorTable virtualKeyboardColorTable32 = new DevComponents.DotNetBar.Keyboard.VirtualKeyboardColorTable();
            DevComponents.DotNetBar.Keyboard.FlatStyleRenderer flatStyleRenderer32 = new DevComponents.DotNetBar.Keyboard.FlatStyleRenderer();
            this.tmrReset = new System.Windows.Forms.Timer(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.TabControlPrincipal = new Ds.Utilidades.CustomTabControl();
            this.tabInicio = new System.Windows.Forms.TabPage();
            this.tabPrincipal = new System.Windows.Forms.TabPage();
            this.tabProcesando = new System.Windows.Forms.TabPage();
            this.Imagen_Procesando = new System.Windows.Forms.Panel();
            this.pPublicidadProcesando = new System.Windows.Forms.PictureBox();
            this.tabTarjetaMensual = new System.Windows.Forms.TabPage();
            this.tabSeleccionPago = new System.Windows.Forms.TabPage();
            this.Imagen_SeleccionPago = new System.Windows.Forms.Panel();
            this.pPublicidadSeleccionPago = new System.Windows.Forms.Panel();
            this.btn_Efectivo = new CustomButton.CustomButton();
            this.btn_Datafono = new CustomButton.CustomButton();
            this.tabTipoCuenta = new System.Windows.Forms.TabPage();
            this.Imagen_TipoCuenta = new System.Windows.Forms.Panel();
            this.btn_CancelarTipoCuenta = new CustomButton.CustomButton();
            this.btn_Credito = new CustomButton.CustomButton();
            this.pPublicidadTipoCuenta = new System.Windows.Forms.Panel();
            this.btn_Ahorros = new CustomButton.CustomButton();
            this.btn_Corriente = new CustomButton.CustomButton();
            this.tabDigiteCredito = new System.Windows.Forms.TabPage();
            this.Imagen_DigiteCredito = new System.Windows.Forms.Panel();
            this.pPublicidadCredito = new System.Windows.Forms.Panel();
            this.btn_CancelarCredito = new CustomButton.CustomButton();
            this.btn_okCredito = new CustomButton.CustomButton();
            this.btn_BorrarCredito = new CustomButton.CustomButton();
            this.btn_0Credito = new CustomButton.CustomButton();
            this.btn_3Credito = new CustomButton.CustomButton();
            this.btn_2Credito = new CustomButton.CustomButton();
            this.btn_1Credito = new CustomButton.CustomButton();
            this.btn_6Credito = new CustomButton.CustomButton();
            this.btn_5Credito = new CustomButton.CustomButton();
            this.btn_4Credito = new CustomButton.CustomButton();
            this.btn_9Credito = new CustomButton.CustomButton();
            this.btn_8Credito = new CustomButton.CustomButton();
            this.btn_7Credito = new CustomButton.CustomButton();
            this.lblDigitosCredito = new System.Windows.Forms.Label();
            this.tabDetallePagoDatafono = new System.Windows.Forms.TabPage();
            this.Imagen_DetallePagoDatafono = new System.Windows.Forms.Panel();
            this.btn_ConfirmarDetalle = new CustomButton.CustomButton();
            this.pPublicidadDetalleDatafono = new System.Windows.Forms.PictureBox();
            this.lblPermanenciaDetalle = new System.Windows.Forms.Label();
            this.lblFechaDetalle = new System.Windows.Forms.Label();
            this.lblTipoVehiculoDetalle = new System.Windows.Forms.Label();
            this.lblValorPagarEfectivoDetalle = new System.Windows.Forms.Label();
            this.lblConvenioDetalle = new System.Windows.Forms.Label();
            this.btn_CancelarDetalle = new CustomButton.CustomButton();
            this.tabDetallePago = new System.Windows.Forms.TabPage();
            this.Imagen_DetallePago = new System.Windows.Forms.Panel();
            this.tbCodigo = new System.Windows.Forms.TextBox();
            this.pPublicidadDetalle = new System.Windows.Forms.PictureBox();
            this.lblCambio = new System.Windows.Forms.Label();
            this.lblValorRecibido = new System.Windows.Forms.Label();
            this.lblPermanencia = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblTipoVehiculo = new System.Windows.Forms.Label();
            this.lblValorPagarEfectivo = new System.Windows.Forms.Label();
            this.lblConvenio = new System.Windows.Forms.Label();
            this.btn_CancelarPagoEfectivo = new CustomButton.CustomButton();
            this.tabInserteTarjetaDatafono = new System.Windows.Forms.TabPage();
            this.Imagen_InserteTarjetaDatafono = new System.Windows.Forms.Panel();
            this.btn_Volver2 = new CustomButton.CustomButton();
            this.btn_PagoQR = new CustomButton.CustomButton();
            this.pPublicidadInsertaDatafono = new System.Windows.Forms.Panel();
            this.btn_PagoMovil = new CustomButton.CustomButton();
            this.btn_PagoNormal = new CustomButton.CustomButton();
            this.tabNumeroCuotas = new System.Windows.Forms.TabPage();
            this.Imagen_NumeroCuotas = new System.Windows.Forms.Panel();
            this.pPublicidadCuotas = new System.Windows.Forms.Panel();
            this.btn_CancelarCuotas = new CustomButton.CustomButton();
            this.btn_okCuotas = new CustomButton.CustomButton();
            this.btn_BorrarCuotas = new CustomButton.CustomButton();
            this.btn_0Cuotas = new CustomButton.CustomButton();
            this.btn_3Cuotas = new CustomButton.CustomButton();
            this.btn_2Cuotas = new CustomButton.CustomButton();
            this.btn_1Cuotas = new CustomButton.CustomButton();
            this.btn_6Cuotas = new CustomButton.CustomButton();
            this.btn_5Cuotas = new CustomButton.CustomButton();
            this.btn_4Cuotas = new CustomButton.CustomButton();
            this.btn_9Cuotas = new CustomButton.CustomButton();
            this.btn_8Cuotas = new CustomButton.CustomButton();
            this.btn_7Cuotas = new CustomButton.CustomButton();
            this.lblCuotas = new System.Windows.Forms.Label();
            this.tabConsultaFallida = new System.Windows.Forms.TabPage();
            this.Imagen_ConsultaFallida = new System.Windows.Forms.Panel();
            this.customButton1 = new CustomButton.CustomButton();
            this.customButton2 = new CustomButton.CustomButton();
            this.tabPuedeSalir = new System.Windows.Forms.TabPage();
            this.imagen_PuedeSalir = new System.Windows.Forms.Panel();
            this.lblTiempoSalida = new System.Windows.Forms.Label();
            this.pPublicidadPuedeSalir = new System.Windows.Forms.Panel();
            this.tabPagoParcial = new System.Windows.Forms.TabPage();
            this.Imagen_PagoParcial = new System.Windows.Forms.Panel();
            this.btn_ConfirmarPagoFE = new CustomButton.CustomButton();
            this.btn_AnularPagoParcial = new CustomButton.CustomButton();
            this.btn_ConfirmarPagoParcial = new CustomButton.CustomButton();
            this.lblTipoVehiculoP = new System.Windows.Forms.Label();
            this.lblPermanenciaP = new System.Windows.Forms.Label();
            this.lblFechaEntradaP = new System.Windows.Forms.Label();
            this.lblValorP = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pPublicidadPagoParcial = new System.Windows.Forms.Panel();
            this.tabNitCliente = new System.Windows.Forms.TabPage();
            this.Imagen_DigiteNitCliente = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblNitCliente = new System.Windows.Forms.Label();
            this.Panel_TecladoNitCliente = new System.Windows.Forms.Panel();
            this.btn_NitCliente0 = new CustomButton.CustomButton();
            this.btn_NitCliente9 = new CustomButton.CustomButton();
            this.btn_NitCliente8 = new CustomButton.CustomButton();
            this.btn_NitCliente7 = new CustomButton.CustomButton();
            this.btn_NitCliente6 = new CustomButton.CustomButton();
            this.btn_NitCliente5 = new CustomButton.CustomButton();
            this.btn_NitCliente4 = new CustomButton.CustomButton();
            this.btn_NitCliente3 = new CustomButton.CustomButton();
            this.btn_NitCliente2 = new CustomButton.CustomButton();
            this.btn_NitCliente1 = new CustomButton.CustomButton();
            this.btn_BorrarNitCliente = new CustomButton.CustomButton();
            this.btn_OkNitCliente = new CustomButton.CustomButton();
            this.tabAtasco = new System.Windows.Forms.TabPage();
            this.Imagen_Atasco = new System.Windows.Forms.Panel();
            this.capaAtasco = new TransparentControl.TransparentControl();
            this.tabDetallePagoMensual = new System.Windows.Forms.TabPage();
            this.Imagen_DetallePagoMensual = new System.Windows.Forms.Panel();
            this.pPublicidadPagoAuto = new System.Windows.Forms.PictureBox();
            this.lblValorCambioAuto = new System.Windows.Forms.Label();
            this.lblValorRecibidoAuto = new System.Windows.Forms.Label();
            this.lblNombreAuto = new System.Windows.Forms.Label();
            this.lblDocumentoAuto = new System.Windows.Forms.Label();
            this.lblValorPagarAuto = new System.Windows.Forms.Label();
            this.lblFechaFinAuto = new System.Windows.Forms.Label();
            this.btn_CancelarPagoAuto = new CustomButton.CustomButton();
            this.tabTransaccionCancelada = new System.Windows.Forms.TabPage();
            this.Imagen_TransaccionCancelada = new System.Windows.Forms.Panel();
            this.pPublicidadCancelada = new System.Windows.Forms.Panel();
            this.tabTarjetaNoGeneraPago = new System.Windows.Forms.TabPage();
            this.Imagen_NoGeneraPago = new System.Windows.Forms.Panel();
            this.pPublicidadNoPago = new System.Windows.Forms.Panel();
            this.tabTarjetaSinEntrada = new System.Windows.Forms.TabPage();
            this.Imagen_TarjetaSinEntrada = new System.Windows.Forms.Panel();
            this.pPublicidadSinEntrada = new System.Windows.Forms.Panel();
            this.tabTransaccionCanceladaPago = new System.Windows.Forms.TabPage();
            this.Imagen_TransaccionCanceladaPago = new System.Windows.Forms.Panel();
            this.pPublicidadCanceladaPago = new System.Windows.Forms.Panel();
            this.tabPagoCelular = new System.Windows.Forms.TabPage();
            this.Imagen_PagoCelular = new System.Windows.Forms.Panel();
            this.btn_ContinuarCelular = new CustomButton.CustomButton();
            this.lblCodigoPago = new System.Windows.Forms.Label();
            this.lblCodigoParqueo = new System.Windows.Forms.Label();
            this.lblValorPagarCelular = new System.Windows.Forms.Label();
            this.btn_VolverMedioCelular = new CustomButton.CustomButton();
            this.btn_CancelarCelular = new CustomButton.CustomButton();
            this.pCelular = new System.Windows.Forms.PictureBox();
            this.tabPagoEfectivo = new System.Windows.Forms.TabPage();
            this.Imagen_PagoEfectivo = new System.Windows.Forms.Panel();
            this.btn_VolverMedios = new CustomButton.CustomButton();
            this.pPagoEfectivo = new System.Windows.Forms.PictureBox();
            this.tabPagoPrepago = new System.Windows.Forms.TabPage();
            this.Imagen_Prepago = new System.Windows.Forms.Panel();
            this.btn_MediosPrepago = new CustomButton.CustomButton();
            this.lblValorPagarPrepago = new System.Windows.Forms.Label();
            this.btn_CancelarPrepago = new CustomButton.CustomButton();
            this.pPrepago = new System.Windows.Forms.PictureBox();
            this.tabPagoDatafono = new System.Windows.Forms.TabPage();
            this.Imagen_PagoDatafono = new System.Windows.Forms.Panel();
            this.lblValorPagarDatafono = new System.Windows.Forms.Label();
            this.btn_MedioDatafono = new CustomButton.CustomButton();
            this.btn_CancelarDatafono = new CustomButton.CustomButton();
            this.pDatafono = new System.Windows.Forms.PictureBox();
            this.tabImprimirFactura = new System.Windows.Forms.TabPage();
            this.Imagen_ImprimirFactura = new System.Windows.Forms.Panel();
            this.pPublicidadImprimir = new System.Windows.Forms.Panel();
            this.btnPrintSI = new CustomButton.CustomButton();
            this.btnPrintNO = new CustomButton.CustomButton();
            this.tabGraciasPago = new System.Windows.Forms.TabPage();
            this.Imagen_GraciasPago = new System.Windows.Forms.Panel();
            this.pPublicidadGracias = new System.Windows.Forms.Panel();
            this.tabContrasenaInvalida = new System.Windows.Forms.TabPage();
            this.Imagen_ContraseñaInvalida = new System.Windows.Forms.Panel();
            this.tabIngresoPass = new System.Windows.Forms.TabPage();
            this.Imagen_IngresoPass = new System.Windows.Forms.Panel();
            this.CapaUsuario = new TransparentControl.TransparentControl();
            this.CapaPass = new TransparentControl.TransparentControl();
            this.kbUsuarioPass = new DevComponents.DotNetBar.Keyboard.KeyboardControl();
            this.lblPassword = new System.Windows.Forms.Label();
            this.btn_Cancelar = new CustomButton.CustomButton();
            this.btn_Aceptar = new CustomButton.CustomButton();
            this.btn_MostrarTecladoPass = new CustomButton.CustomButton();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.tabSegundoPass = new System.Windows.Forms.TabPage();
            this.Imagen_SegundaPass = new System.Windows.Forms.Panel();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.lblUsuarioSegunda = new System.Windows.Forms.Label();
            this.btn_CancelarSegunda = new CustomButton.CustomButton();
            this.btn_AceptarSegunda = new CustomButton.CustomButton();
            this.btn_MostrarTecladoSegunda = new CustomButton.CustomButton();
            this.tabMantenimiento = new System.Windows.Forms.TabPage();
            this.Imagen_Mantenimiento = new System.Windows.Forms.Panel();
            this.CapaMantenimientoCaleto = new TransparentControl.TransparentControl();
            this.tabArqueo = new System.Windows.Forms.TabPage();
            this.Imagen_Arqueo = new System.Windows.Forms.Panel();
            this.btn_ArqueoTotal = new CustomButton.CustomButton();
            this.btn_Volver = new CustomButton.CustomButton();
            this.btn_ArqueoParcial = new CustomButton.CustomButton();
            this.tabCarga = new System.Windows.Forms.TabPage();
            this.Imagen_Carga = new System.Windows.Forms.Panel();
            this.btn_CargaMonedas = new CustomButton.CustomButton();
            this.btn_VolverCarga = new CustomButton.CustomButton();
            this.btn_CargaBilletes = new CustomButton.CustomButton();
            this.tabCargaBilletes = new System.Windows.Forms.TabPage();
            this.Imagen_CargaBilletes = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_ConfirmarCargaF56 = new CustomButton.CustomButton();
            this.grvCargaActualBilletesF56 = new System.Windows.Forms.DataGridView();
            this.grvCargaTotalBilletesF56 = new System.Windows.Forms.DataGridView();
            this.tabCargaMonedas = new System.Windows.Forms.TabPage();
            this.Imagen_CargaMonedas = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnHopper4 = new CustomButton.CustomButton();
            this.btn_Hopper3 = new CustomButton.CustomButton();
            this.btn_ConfirmarCargaMonedas = new CustomButton.CustomButton();
            this.btn_okCarga = new CustomButton.CustomButton();
            this.btn_BorrarCarga = new CustomButton.CustomButton();
            this.btn_0Carga = new CustomButton.CustomButton();
            this.btn_3Carga = new CustomButton.CustomButton();
            this.btn_2Carga = new CustomButton.CustomButton();
            this.btn_1Carga = new CustomButton.CustomButton();
            this.btn_6Carga = new CustomButton.CustomButton();
            this.btn_5Carga = new CustomButton.CustomButton();
            this.btn_4Carga = new CustomButton.CustomButton();
            this.btn_9Carga = new CustomButton.CustomButton();
            this.btn_8Carga = new CustomButton.CustomButton();
            this.btn_7Carga = new CustomButton.CustomButton();
            this.lblKeyboard_Carga = new System.Windows.Forms.Label();
            this.grvCargaActualMonedas = new System.Windows.Forms.DataGridView();
            this.grvCargaTotalMonedas = new System.Windows.Forms.DataGridView();
            this.btnHopper2 = new CustomButton.CustomButton();
            this.btnHopper1 = new CustomButton.CustomButton();
            this.tabMenuSistemas = new System.Windows.Forms.TabPage();
            this.Imagen_MenuSistema = new System.Windows.Forms.Panel();
            this.lblFechaActual = new System.Windows.Forms.Label();
            this.btn_Carga = new CustomButton.CustomButton();
            this.btn_Salir = new CustomButton.CustomButton();
            this.btn_Iniciar = new CustomButton.CustomButton();
            this.btn_Mantenimiento = new CustomButton.CustomButton();
            this.btn_Log = new CustomButton.CustomButton();
            this.btn_Arqueo = new CustomButton.CustomButton();
            this.tabCerrarOperacion = new System.Windows.Forms.TabPage();
            this.Imagen_CerrarOperacion = new System.Windows.Forms.Panel();
            this.pPublicidadCerrar = new System.Windows.Forms.Panel();
            this.tabSistemaSuspendido = new System.Windows.Forms.TabPage();
            this.Imagen_SistemaSupendido = new System.Windows.Forms.Panel();
            this.pPublicidadSuspendido = new System.Windows.Forms.Panel();
            this.CapaSuspendidoCaleto = new TransparentControl.TransparentControl();
            this.tabTarjetaInvalida = new System.Windows.Forms.TabPage();
            this.Imagen_TarjetaInvalida = new System.Windows.Forms.Panel();
            this.pPublicidadInvalida = new System.Windows.Forms.Panel();
            this.tabArqueoParcial = new System.Windows.Forms.TabPage();
            this.Imagen_ArqueoParcial = new System.Windows.Forms.Panel();
            this.Animacion_RetireBox = new System.Windows.Forms.PictureBox();
            this.btn_ConfirmarArqueo = new CustomButton.CustomButton();
            this.tabArqueoTotal = new System.Windows.Forms.TabPage();
            this.Imagen_ArqueoTotal = new System.Windows.Forms.Panel();
            this.AnimacionBoxTotal = new System.Windows.Forms.PictureBox();
            this.btn_ConfirmarArqueoTotal = new CustomButton.CustomButton();
            this.tabDescargando = new System.Windows.Forms.TabPage();
            this.Imagen_Descargando = new System.Windows.Forms.Panel();
            this.pInicio = new System.Windows.Forms.PictureBox();
            this.Imagen_Inicio = new System.Windows.Forms.Panel();
            this.Imagen_Principal = new System.Windows.Forms.Panel();
            this.btn_InserteTarjeta = new CustomButton.CustomButton();
            this.btn_Placa = new CustomButton.CustomButton();
            this.Animacion_InserteTarjeta = new System.Windows.Forms.PictureBox();
            this.pPublicidad = new System.Windows.Forms.PictureBox();
            this.CapaMenuPrincipal = new TransparentControl.TransparentControl();
            this.tabTarjetaVisitante = new System.Windows.Forms.TabPage();
            this.Imagen_TarjetaVisitante = new System.Windows.Forms.Panel();
            this.Animacion_Inserte = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.tabDigitePlaca = new System.Windows.Forms.TabPage();
            this.Imagen_DigitePlaca = new System.Windows.Forms.Panel();
            this.btn_AceptarPlaca = new CustomButton.CustomButton();
            this.btn_CancelarPlaca = new CustomButton.CustomButton();
            this.lblPlaca = new System.Windows.Forms.Label();
            this.kbPlaca = new DevComponents.DotNetBar.Keyboard.KeyboardControl();
            this.tabNoMensual = new System.Windows.Forms.TabPage();
            this.Imagen_NoMensual = new System.Windows.Forms.Panel();
            this.Imagen_TarjetaMensual = new System.Windows.Forms.Panel();
            this.btn_ConfirmarPagoMensualFE = new CustomButton.CustomButton();
            this.btn_AnularPagoMensualParcial = new CustomButton.CustomButton();
            this.btn_ConfirmarPagoMensual = new CustomButton.CustomButton();
            this.lblNombreAutoN = new System.Windows.Forms.Label();
            this.lblValorPagarAutoN = new System.Windows.Forms.Label();
            this.lblFechaFinAutoN = new System.Windows.Forms.Label();
            this.pPublicidadMensul = new System.Windows.Forms.Panel();
            this.btn_SiMensual = new CustomButton.CustomButton();
            this.btn_NoMensual = new CustomButton.CustomButton();
            this.TabControlPrincipal.SuspendLayout();
            this.tabInicio.SuspendLayout();
            this.tabPrincipal.SuspendLayout();
            this.tabProcesando.SuspendLayout();
            this.Imagen_Procesando.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pPublicidadProcesando)).BeginInit();
            this.tabTarjetaMensual.SuspendLayout();
            this.tabSeleccionPago.SuspendLayout();
            this.Imagen_SeleccionPago.SuspendLayout();
            this.tabTipoCuenta.SuspendLayout();
            this.Imagen_TipoCuenta.SuspendLayout();
            this.tabDigiteCredito.SuspendLayout();
            this.Imagen_DigiteCredito.SuspendLayout();
            this.tabDetallePagoDatafono.SuspendLayout();
            this.Imagen_DetallePagoDatafono.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pPublicidadDetalleDatafono)).BeginInit();
            this.tabDetallePago.SuspendLayout();
            this.Imagen_DetallePago.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pPublicidadDetalle)).BeginInit();
            this.tabInserteTarjetaDatafono.SuspendLayout();
            this.Imagen_InserteTarjetaDatafono.SuspendLayout();
            this.tabNumeroCuotas.SuspendLayout();
            this.Imagen_NumeroCuotas.SuspendLayout();
            this.tabConsultaFallida.SuspendLayout();
            this.Imagen_ConsultaFallida.SuspendLayout();
            this.tabPuedeSalir.SuspendLayout();
            this.imagen_PuedeSalir.SuspendLayout();
            this.tabPagoParcial.SuspendLayout();
            this.Imagen_PagoParcial.SuspendLayout();
            this.tabNitCliente.SuspendLayout();
            this.Imagen_DigiteNitCliente.SuspendLayout();
            this.Panel_TecladoNitCliente.SuspendLayout();
            this.tabAtasco.SuspendLayout();
            this.Imagen_Atasco.SuspendLayout();
            this.tabDetallePagoMensual.SuspendLayout();
            this.Imagen_DetallePagoMensual.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pPublicidadPagoAuto)).BeginInit();
            this.tabTransaccionCancelada.SuspendLayout();
            this.Imagen_TransaccionCancelada.SuspendLayout();
            this.tabTarjetaNoGeneraPago.SuspendLayout();
            this.Imagen_NoGeneraPago.SuspendLayout();
            this.tabTarjetaSinEntrada.SuspendLayout();
            this.Imagen_TarjetaSinEntrada.SuspendLayout();
            this.tabTransaccionCanceladaPago.SuspendLayout();
            this.Imagen_TransaccionCanceladaPago.SuspendLayout();
            this.tabPagoCelular.SuspendLayout();
            this.Imagen_PagoCelular.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pCelular)).BeginInit();
            this.tabPagoEfectivo.SuspendLayout();
            this.Imagen_PagoEfectivo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pPagoEfectivo)).BeginInit();
            this.tabPagoPrepago.SuspendLayout();
            this.Imagen_Prepago.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pPrepago)).BeginInit();
            this.tabPagoDatafono.SuspendLayout();
            this.Imagen_PagoDatafono.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pDatafono)).BeginInit();
            this.tabImprimirFactura.SuspendLayout();
            this.Imagen_ImprimirFactura.SuspendLayout();
            this.tabGraciasPago.SuspendLayout();
            this.Imagen_GraciasPago.SuspendLayout();
            this.tabContrasenaInvalida.SuspendLayout();
            this.tabIngresoPass.SuspendLayout();
            this.Imagen_IngresoPass.SuspendLayout();
            this.tabSegundoPass.SuspendLayout();
            this.Imagen_SegundaPass.SuspendLayout();
            this.tabMantenimiento.SuspendLayout();
            this.Imagen_Mantenimiento.SuspendLayout();
            this.tabArqueo.SuspendLayout();
            this.Imagen_Arqueo.SuspendLayout();
            this.tabCarga.SuspendLayout();
            this.Imagen_Carga.SuspendLayout();
            this.tabCargaBilletes.SuspendLayout();
            this.Imagen_CargaBilletes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grvCargaActualBilletesF56)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvCargaTotalBilletesF56)).BeginInit();
            this.tabCargaMonedas.SuspendLayout();
            this.Imagen_CargaMonedas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grvCargaActualMonedas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvCargaTotalMonedas)).BeginInit();
            this.tabMenuSistemas.SuspendLayout();
            this.Imagen_MenuSistema.SuspendLayout();
            this.tabCerrarOperacion.SuspendLayout();
            this.Imagen_CerrarOperacion.SuspendLayout();
            this.tabSistemaSuspendido.SuspendLayout();
            this.Imagen_SistemaSupendido.SuspendLayout();
            this.tabTarjetaInvalida.SuspendLayout();
            this.Imagen_TarjetaInvalida.SuspendLayout();
            this.tabArqueoParcial.SuspendLayout();
            this.Imagen_ArqueoParcial.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Animacion_RetireBox)).BeginInit();
            this.tabArqueoTotal.SuspendLayout();
            this.Imagen_ArqueoTotal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AnimacionBoxTotal)).BeginInit();
            this.tabDescargando.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pInicio)).BeginInit();
            this.Imagen_Inicio.SuspendLayout();
            this.Imagen_Principal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Animacion_InserteTarjeta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pPublicidad)).BeginInit();
            this.tabTarjetaVisitante.SuspendLayout();
            this.Imagen_TarjetaVisitante.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Animacion_Inserte)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.tabDigitePlaca.SuspendLayout();
            this.Imagen_DigitePlaca.SuspendLayout();
            this.tabNoMensual.SuspendLayout();
            this.Imagen_TarjetaMensual.SuspendLayout();
            this.SuspendLayout();
            // 
            // tmrReset
            // 
            this.tmrReset.Enabled = true;
            this.tmrReset.Interval = 1000;
            this.tmrReset.Tick += new System.EventHandler(this.tmrReset_Tick);
            // 
            // timer1
            // 
            this.timer1.Interval = 250;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // TabControlPrincipal
            // 
            this.TabControlPrincipal.Controls.Add(this.tabInicio);
            this.TabControlPrincipal.Controls.Add(this.tabPrincipal);
            this.TabControlPrincipal.Controls.Add(this.tabTarjetaVisitante);
            this.TabControlPrincipal.Controls.Add(this.tabProcesando);
            this.TabControlPrincipal.Controls.Add(this.tabTarjetaMensual);
            this.TabControlPrincipal.Controls.Add(this.tabSeleccionPago);
            this.TabControlPrincipal.Controls.Add(this.tabTipoCuenta);
            this.TabControlPrincipal.Controls.Add(this.tabDigiteCredito);
            this.TabControlPrincipal.Controls.Add(this.tabDetallePagoDatafono);
            this.TabControlPrincipal.Controls.Add(this.tabDetallePago);
            this.TabControlPrincipal.Controls.Add(this.tabDigitePlaca);
            this.TabControlPrincipal.Controls.Add(this.tabNoMensual);
            this.TabControlPrincipal.Controls.Add(this.tabInserteTarjetaDatafono);
            this.TabControlPrincipal.Controls.Add(this.tabNumeroCuotas);
            this.TabControlPrincipal.Controls.Add(this.tabConsultaFallida);
            this.TabControlPrincipal.Controls.Add(this.tabPuedeSalir);
            this.TabControlPrincipal.Controls.Add(this.tabPagoParcial);
            this.TabControlPrincipal.Controls.Add(this.tabNitCliente);
            this.TabControlPrincipal.Controls.Add(this.tabAtasco);
            this.TabControlPrincipal.Controls.Add(this.tabDetallePagoMensual);
            this.TabControlPrincipal.Controls.Add(this.tabTransaccionCancelada);
            this.TabControlPrincipal.Controls.Add(this.tabTarjetaNoGeneraPago);
            this.TabControlPrincipal.Controls.Add(this.tabTarjetaSinEntrada);
            this.TabControlPrincipal.Controls.Add(this.tabTransaccionCanceladaPago);
            this.TabControlPrincipal.Controls.Add(this.tabPagoCelular);
            this.TabControlPrincipal.Controls.Add(this.tabPagoEfectivo);
            this.TabControlPrincipal.Controls.Add(this.tabPagoPrepago);
            this.TabControlPrincipal.Controls.Add(this.tabPagoDatafono);
            this.TabControlPrincipal.Controls.Add(this.tabImprimirFactura);
            this.TabControlPrincipal.Controls.Add(this.tabGraciasPago);
            this.TabControlPrincipal.Controls.Add(this.tabContrasenaInvalida);
            this.TabControlPrincipal.Controls.Add(this.tabIngresoPass);
            this.TabControlPrincipal.Controls.Add(this.tabSegundoPass);
            this.TabControlPrincipal.Controls.Add(this.tabMantenimiento);
            this.TabControlPrincipal.Controls.Add(this.tabArqueo);
            this.TabControlPrincipal.Controls.Add(this.tabCarga);
            this.TabControlPrincipal.Controls.Add(this.tabCargaBilletes);
            this.TabControlPrincipal.Controls.Add(this.tabCargaMonedas);
            this.TabControlPrincipal.Controls.Add(this.tabMenuSistemas);
            this.TabControlPrincipal.Controls.Add(this.tabCerrarOperacion);
            this.TabControlPrincipal.Controls.Add(this.tabSistemaSuspendido);
            this.TabControlPrincipal.Controls.Add(this.tabTarjetaInvalida);
            this.TabControlPrincipal.Controls.Add(this.tabArqueoParcial);
            this.TabControlPrincipal.Controls.Add(this.tabArqueoTotal);
            this.TabControlPrincipal.Controls.Add(this.tabDescargando);
            this.TabControlPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TabControlPrincipal.Location = new System.Drawing.Point(0, 0);
            this.TabControlPrincipal.Name = "TabControlPrincipal";
            this.TabControlPrincipal.SelectedIndex = 0;
            this.TabControlPrincipal.Size = new System.Drawing.Size(1278, 878);
            this.TabControlPrincipal.TabIndex = 5031;
            // 
            // tabInicio
            // 
            this.tabInicio.Controls.Add(this.Imagen_Inicio);
            this.tabInicio.Location = new System.Drawing.Point(4, 22);
            this.tabInicio.Name = "tabInicio";
            this.tabInicio.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tabInicio.Size = new System.Drawing.Size(1270, 852);
            this.tabInicio.TabIndex = 45;
            this.tabInicio.Text = "Inicio";
            this.tabInicio.UseVisualStyleBackColor = true;
            // 
            // tabPrincipal
            // 
            this.tabPrincipal.Controls.Add(this.Imagen_Principal);
            this.tabPrincipal.Location = new System.Drawing.Point(4, 22);
            this.tabPrincipal.Name = "tabPrincipal";
            this.tabPrincipal.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tabPrincipal.Size = new System.Drawing.Size(1270, 852);
            this.tabPrincipal.TabIndex = 46;
            this.tabPrincipal.Text = "Principal";
            this.tabPrincipal.UseVisualStyleBackColor = true;
            // 
            // tabProcesando
            // 
            this.tabProcesando.Controls.Add(this.Imagen_Procesando);
            this.tabProcesando.Location = new System.Drawing.Point(4, 22);
            this.tabProcesando.Name = "tabProcesando";
            this.tabProcesando.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tabProcesando.Size = new System.Drawing.Size(1270, 852);
            this.tabProcesando.TabIndex = 57;
            this.tabProcesando.Text = "Procesando";
            this.tabProcesando.UseVisualStyleBackColor = true;
            // 
            // Imagen_Procesando
            // 
            this.Imagen_Procesando.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Imagen_Procesando.Controls.Add(this.pPublicidadProcesando);
            this.Imagen_Procesando.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Imagen_Procesando.Location = new System.Drawing.Point(3, 3);
            this.Imagen_Procesando.Name = "Imagen_Procesando";
            this.Imagen_Procesando.Size = new System.Drawing.Size(1264, 846);
            this.Imagen_Procesando.TabIndex = 5023;
            // 
            // pPublicidadProcesando
            // 
            this.pPublicidadProcesando.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pPublicidadProcesando.Location = new System.Drawing.Point(5, 0);
            this.pPublicidadProcesando.Name = "pPublicidadProcesando";
            this.pPublicidadProcesando.Size = new System.Drawing.Size(1258, 417);
            this.pPublicidadProcesando.TabIndex = 5025;
            this.pPublicidadProcesando.TabStop = false;
            // 
            // tabTarjetaMensual
            // 
            this.tabTarjetaMensual.Controls.Add(this.Imagen_TarjetaMensual);
            this.tabTarjetaMensual.Location = new System.Drawing.Point(4, 22);
            this.tabTarjetaMensual.Name = "tabTarjetaMensual";
            this.tabTarjetaMensual.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tabTarjetaMensual.Size = new System.Drawing.Size(1270, 852);
            this.tabTarjetaMensual.TabIndex = 65;
            this.tabTarjetaMensual.Text = "TarjetaMensual";
            this.tabTarjetaMensual.UseVisualStyleBackColor = true;
            // 
            // tabSeleccionPago
            // 
            this.tabSeleccionPago.Controls.Add(this.Imagen_SeleccionPago);
            this.tabSeleccionPago.Location = new System.Drawing.Point(4, 22);
            this.tabSeleccionPago.Name = "tabSeleccionPago";
            this.tabSeleccionPago.Size = new System.Drawing.Size(1270, 852);
            this.tabSeleccionPago.TabIndex = 70;
            this.tabSeleccionPago.Text = "SeleccionPago";
            this.tabSeleccionPago.UseVisualStyleBackColor = true;
            // 
            // Imagen_SeleccionPago
            // 
            this.Imagen_SeleccionPago.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Imagen_SeleccionPago.Controls.Add(this.pPublicidadSeleccionPago);
            this.Imagen_SeleccionPago.Controls.Add(this.btn_Efectivo);
            this.Imagen_SeleccionPago.Controls.Add(this.btn_Datafono);
            this.Imagen_SeleccionPago.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Imagen_SeleccionPago.Location = new System.Drawing.Point(0, 0);
            this.Imagen_SeleccionPago.Name = "Imagen_SeleccionPago";
            this.Imagen_SeleccionPago.Size = new System.Drawing.Size(1270, 852);
            this.Imagen_SeleccionPago.TabIndex = 5024;
            // 
            // pPublicidadSeleccionPago
            // 
            this.pPublicidadSeleccionPago.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pPublicidadSeleccionPago.Location = new System.Drawing.Point(5, 0);
            this.pPublicidadSeleccionPago.Name = "pPublicidadSeleccionPago";
            this.pPublicidadSeleccionPago.Size = new System.Drawing.Size(1258, 417);
            this.pPublicidadSeleccionPago.TabIndex = 5070;
            // 
            // btn_Efectivo
            // 
            this.btn_Efectivo.AutoSize = true;
            this.btn_Efectivo.BackColor = System.Drawing.Color.Transparent;
            this.btn_Efectivo.FlatAppearance.BorderSize = 0;
            this.btn_Efectivo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_Efectivo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_Efectivo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Efectivo.Location = new System.Drawing.Point(282, 695);
            this.btn_Efectivo.LockPush = true;
            this.btn_Efectivo.Name = "btn_Efectivo";
            this.btn_Efectivo.Size = new System.Drawing.Size(88, 95);
            this.btn_Efectivo.TabIndex = 5069;
            this.btn_Efectivo.Text = "EFECTIVO";
            this.btn_Efectivo.UseVisualStyleBackColor = false;
            this.btn_Efectivo.Click += new System.EventHandler(this.btn_Efectivo_Click_1);
            // 
            // btn_Datafono
            // 
            this.btn_Datafono.AutoSize = true;
            this.btn_Datafono.BackColor = System.Drawing.Color.Transparent;
            this.btn_Datafono.FlatAppearance.BorderSize = 0;
            this.btn_Datafono.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_Datafono.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_Datafono.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Datafono.Location = new System.Drawing.Point(814, 695);
            this.btn_Datafono.LockPush = true;
            this.btn_Datafono.Name = "btn_Datafono";
            this.btn_Datafono.Size = new System.Drawing.Size(92, 95);
            this.btn_Datafono.TabIndex = 5068;
            this.btn_Datafono.Text = "DATAFONO";
            this.btn_Datafono.UseVisualStyleBackColor = false;
            this.btn_Datafono.Click += new System.EventHandler(this.btn_Datafono_Click_1);
            // 
            // tabTipoCuenta
            // 
            this.tabTipoCuenta.Controls.Add(this.Imagen_TipoCuenta);
            this.tabTipoCuenta.Location = new System.Drawing.Point(4, 22);
            this.tabTipoCuenta.Name = "tabTipoCuenta";
            this.tabTipoCuenta.Size = new System.Drawing.Size(1270, 852);
            this.tabTipoCuenta.TabIndex = 73;
            this.tabTipoCuenta.Text = "TipoCuenta";
            this.tabTipoCuenta.UseVisualStyleBackColor = true;
            // 
            // Imagen_TipoCuenta
            // 
            this.Imagen_TipoCuenta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Imagen_TipoCuenta.Controls.Add(this.btn_CancelarTipoCuenta);
            this.Imagen_TipoCuenta.Controls.Add(this.btn_Credito);
            this.Imagen_TipoCuenta.Controls.Add(this.pPublicidadTipoCuenta);
            this.Imagen_TipoCuenta.Controls.Add(this.btn_Ahorros);
            this.Imagen_TipoCuenta.Controls.Add(this.btn_Corriente);
            this.Imagen_TipoCuenta.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Imagen_TipoCuenta.Location = new System.Drawing.Point(0, 0);
            this.Imagen_TipoCuenta.Name = "Imagen_TipoCuenta";
            this.Imagen_TipoCuenta.Size = new System.Drawing.Size(1270, 852);
            this.Imagen_TipoCuenta.TabIndex = 5025;
            // 
            // btn_CancelarTipoCuenta
            // 
            this.btn_CancelarTipoCuenta.AutoSize = true;
            this.btn_CancelarTipoCuenta.BackColor = System.Drawing.Color.Transparent;
            this.btn_CancelarTipoCuenta.FlatAppearance.BorderSize = 0;
            this.btn_CancelarTipoCuenta.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_CancelarTipoCuenta.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_CancelarTipoCuenta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_CancelarTipoCuenta.Location = new System.Drawing.Point(1047, 870);
            this.btn_CancelarTipoCuenta.LockPush = true;
            this.btn_CancelarTipoCuenta.Name = "btn_CancelarTipoCuenta";
            this.btn_CancelarTipoCuenta.Size = new System.Drawing.Size(136, 42);
            this.btn_CancelarTipoCuenta.TabIndex = 5072;
            this.btn_CancelarTipoCuenta.Text = "CANCELAR";
            this.btn_CancelarTipoCuenta.UseVisualStyleBackColor = false;
            this.btn_CancelarTipoCuenta.Click += new System.EventHandler(this.btn_CancelarTipoCuenta_Click);
            // 
            // btn_Credito
            // 
            this.btn_Credito.AutoSize = true;
            this.btn_Credito.BackColor = System.Drawing.Color.Transparent;
            this.btn_Credito.FlatAppearance.BorderSize = 0;
            this.btn_Credito.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_Credito.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_Credito.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Credito.Location = new System.Drawing.Point(995, 660);
            this.btn_Credito.LockPush = true;
            this.btn_Credito.Name = "btn_Credito";
            this.btn_Credito.Size = new System.Drawing.Size(88, 95);
            this.btn_Credito.TabIndex = 5071;
            this.btn_Credito.Text = "CREDITO";
            this.btn_Credito.UseVisualStyleBackColor = false;
            this.btn_Credito.Click += new System.EventHandler(this.btn_Credito_Click);
            // 
            // pPublicidadTipoCuenta
            // 
            this.pPublicidadTipoCuenta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pPublicidadTipoCuenta.Location = new System.Drawing.Point(5, 0);
            this.pPublicidadTipoCuenta.Name = "pPublicidadTipoCuenta";
            this.pPublicidadTipoCuenta.Size = new System.Drawing.Size(1258, 417);
            this.pPublicidadTipoCuenta.TabIndex = 5070;
            // 
            // btn_Ahorros
            // 
            this.btn_Ahorros.AutoSize = true;
            this.btn_Ahorros.BackColor = System.Drawing.Color.Transparent;
            this.btn_Ahorros.FlatAppearance.BorderSize = 0;
            this.btn_Ahorros.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_Ahorros.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_Ahorros.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Ahorros.Location = new System.Drawing.Point(157, 660);
            this.btn_Ahorros.LockPush = true;
            this.btn_Ahorros.Name = "btn_Ahorros";
            this.btn_Ahorros.Size = new System.Drawing.Size(88, 95);
            this.btn_Ahorros.TabIndex = 5069;
            this.btn_Ahorros.Text = "AHORROS";
            this.btn_Ahorros.UseVisualStyleBackColor = false;
            this.btn_Ahorros.Click += new System.EventHandler(this.btn_Ahorros_Click);
            // 
            // btn_Corriente
            // 
            this.btn_Corriente.AutoSize = true;
            this.btn_Corriente.BackColor = System.Drawing.Color.Transparent;
            this.btn_Corriente.FlatAppearance.BorderSize = 0;
            this.btn_Corriente.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_Corriente.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_Corriente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Corriente.Location = new System.Drawing.Point(573, 660);
            this.btn_Corriente.LockPush = true;
            this.btn_Corriente.Name = "btn_Corriente";
            this.btn_Corriente.Size = new System.Drawing.Size(96, 95);
            this.btn_Corriente.TabIndex = 5068;
            this.btn_Corriente.Text = "CORRIENTE";
            this.btn_Corriente.UseVisualStyleBackColor = false;
            this.btn_Corriente.Click += new System.EventHandler(this.btn_Corriente_Click);
            // 
            // tabDigiteCredito
            // 
            this.tabDigiteCredito.Controls.Add(this.Imagen_DigiteCredito);
            this.tabDigiteCredito.Location = new System.Drawing.Point(4, 22);
            this.tabDigiteCredito.Name = "tabDigiteCredito";
            this.tabDigiteCredito.Size = new System.Drawing.Size(1270, 852);
            this.tabDigiteCredito.TabIndex = 74;
            this.tabDigiteCredito.Text = "DigiteCredito";
            this.tabDigiteCredito.UseVisualStyleBackColor = true;
            // 
            // Imagen_DigiteCredito
            // 
            this.Imagen_DigiteCredito.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Imagen_DigiteCredito.Controls.Add(this.pPublicidadCredito);
            this.Imagen_DigiteCredito.Controls.Add(this.btn_CancelarCredito);
            this.Imagen_DigiteCredito.Controls.Add(this.btn_okCredito);
            this.Imagen_DigiteCredito.Controls.Add(this.btn_BorrarCredito);
            this.Imagen_DigiteCredito.Controls.Add(this.btn_0Credito);
            this.Imagen_DigiteCredito.Controls.Add(this.btn_3Credito);
            this.Imagen_DigiteCredito.Controls.Add(this.btn_2Credito);
            this.Imagen_DigiteCredito.Controls.Add(this.btn_1Credito);
            this.Imagen_DigiteCredito.Controls.Add(this.btn_6Credito);
            this.Imagen_DigiteCredito.Controls.Add(this.btn_5Credito);
            this.Imagen_DigiteCredito.Controls.Add(this.btn_4Credito);
            this.Imagen_DigiteCredito.Controls.Add(this.btn_9Credito);
            this.Imagen_DigiteCredito.Controls.Add(this.btn_8Credito);
            this.Imagen_DigiteCredito.Controls.Add(this.btn_7Credito);
            this.Imagen_DigiteCredito.Controls.Add(this.lblDigitosCredito);
            this.Imagen_DigiteCredito.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Imagen_DigiteCredito.Location = new System.Drawing.Point(0, 0);
            this.Imagen_DigiteCredito.Name = "Imagen_DigiteCredito";
            this.Imagen_DigiteCredito.Size = new System.Drawing.Size(1270, 852);
            this.Imagen_DigiteCredito.TabIndex = 5026;
            // 
            // pPublicidadCredito
            // 
            this.pPublicidadCredito.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pPublicidadCredito.Location = new System.Drawing.Point(5, 0);
            this.pPublicidadCredito.Name = "pPublicidadCredito";
            this.pPublicidadCredito.Size = new System.Drawing.Size(1258, 417);
            this.pPublicidadCredito.TabIndex = 5028;
            // 
            // btn_CancelarCredito
            // 
            this.btn_CancelarCredito.AutoSize = true;
            this.btn_CancelarCredito.BackColor = System.Drawing.Color.Transparent;
            this.btn_CancelarCredito.FlatAppearance.BorderSize = 0;
            this.btn_CancelarCredito.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_CancelarCredito.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_CancelarCredito.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_CancelarCredito.Location = new System.Drawing.Point(548, 821);
            this.btn_CancelarCredito.LockPush = true;
            this.btn_CancelarCredito.Name = "btn_CancelarCredito";
            this.btn_CancelarCredito.Size = new System.Drawing.Size(136, 42);
            this.btn_CancelarCredito.TabIndex = 207;
            this.btn_CancelarCredito.Text = "borrar";
            this.btn_CancelarCredito.UseVisualStyleBackColor = false;
            this.btn_CancelarCredito.Click += new System.EventHandler(this.btn_CancelarCredito_Click);
            // 
            // btn_okCredito
            // 
            this.btn_okCredito.AutoSize = true;
            this.btn_okCredito.BackColor = System.Drawing.Color.Transparent;
            this.btn_okCredito.FlatAppearance.BorderSize = 0;
            this.btn_okCredito.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_okCredito.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_okCredito.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_okCredito.Location = new System.Drawing.Point(832, 812);
            this.btn_okCredito.LockPush = true;
            this.btn_okCredito.Name = "btn_okCredito";
            this.btn_okCredito.Size = new System.Drawing.Size(97, 92);
            this.btn_okCredito.TabIndex = 205;
            this.btn_okCredito.Text = "ok";
            this.btn_okCredito.UseVisualStyleBackColor = false;
            this.btn_okCredito.Click += new System.EventHandler(this.btn_okCredito_Click);
            // 
            // btn_BorrarCredito
            // 
            this.btn_BorrarCredito.AutoSize = true;
            this.btn_BorrarCredito.BackColor = System.Drawing.Color.Transparent;
            this.btn_BorrarCredito.FlatAppearance.BorderSize = 0;
            this.btn_BorrarCredito.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_BorrarCredito.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_BorrarCredito.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_BorrarCredito.Location = new System.Drawing.Point(1065, 812);
            this.btn_BorrarCredito.LockPush = true;
            this.btn_BorrarCredito.Name = "btn_BorrarCredito";
            this.btn_BorrarCredito.Size = new System.Drawing.Size(97, 92);
            this.btn_BorrarCredito.TabIndex = 204;
            this.btn_BorrarCredito.Text = "borrar";
            this.btn_BorrarCredito.UseVisualStyleBackColor = false;
            this.btn_BorrarCredito.Click += new System.EventHandler(this.btn_BorrarCredito_Click);
            // 
            // btn_0Credito
            // 
            this.btn_0Credito.AutoSize = true;
            this.btn_0Credito.BackColor = System.Drawing.Color.Transparent;
            this.btn_0Credito.FlatAppearance.BorderSize = 0;
            this.btn_0Credito.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_0Credito.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_0Credito.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_0Credito.Location = new System.Drawing.Point(959, 823);
            this.btn_0Credito.LockPush = true;
            this.btn_0Credito.Name = "btn_0Credito";
            this.btn_0Credito.Size = new System.Drawing.Size(97, 92);
            this.btn_0Credito.TabIndex = 203;
            this.btn_0Credito.Text = "0";
            this.btn_0Credito.UseVisualStyleBackColor = false;
            this.btn_0Credito.Click += new System.EventHandler(this.btn_0Credito_Click);
            // 
            // btn_3Credito
            // 
            this.btn_3Credito.AutoSize = true;
            this.btn_3Credito.BackColor = System.Drawing.Color.Transparent;
            this.btn_3Credito.FlatAppearance.BorderSize = 0;
            this.btn_3Credito.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_3Credito.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_3Credito.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_3Credito.Location = new System.Drawing.Point(1078, 707);
            this.btn_3Credito.LockPush = true;
            this.btn_3Credito.Name = "btn_3Credito";
            this.btn_3Credito.Size = new System.Drawing.Size(97, 92);
            this.btn_3Credito.TabIndex = 202;
            this.btn_3Credito.Text = "3";
            this.btn_3Credito.UseVisualStyleBackColor = false;
            this.btn_3Credito.Click += new System.EventHandler(this.btn_3Credito_Click);
            // 
            // btn_2Credito
            // 
            this.btn_2Credito.AutoSize = true;
            this.btn_2Credito.BackColor = System.Drawing.Color.Transparent;
            this.btn_2Credito.FlatAppearance.BorderSize = 0;
            this.btn_2Credito.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_2Credito.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_2Credito.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_2Credito.Location = new System.Drawing.Point(959, 707);
            this.btn_2Credito.LockPush = true;
            this.btn_2Credito.Name = "btn_2Credito";
            this.btn_2Credito.Size = new System.Drawing.Size(97, 92);
            this.btn_2Credito.TabIndex = 201;
            this.btn_2Credito.Text = "2";
            this.btn_2Credito.UseVisualStyleBackColor = false;
            this.btn_2Credito.Click += new System.EventHandler(this.btn_2Credito_Click);
            // 
            // btn_1Credito
            // 
            this.btn_1Credito.AutoSize = true;
            this.btn_1Credito.BackColor = System.Drawing.Color.Transparent;
            this.btn_1Credito.FlatAppearance.BorderSize = 0;
            this.btn_1Credito.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_1Credito.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_1Credito.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_1Credito.Location = new System.Drawing.Point(842, 707);
            this.btn_1Credito.LockPush = true;
            this.btn_1Credito.Name = "btn_1Credito";
            this.btn_1Credito.Size = new System.Drawing.Size(97, 92);
            this.btn_1Credito.TabIndex = 200;
            this.btn_1Credito.Text = "1";
            this.btn_1Credito.UseVisualStyleBackColor = false;
            this.btn_1Credito.Click += new System.EventHandler(this.btn_1Credito_Click);
            // 
            // btn_6Credito
            // 
            this.btn_6Credito.AutoSize = true;
            this.btn_6Credito.BackColor = System.Drawing.Color.Transparent;
            this.btn_6Credito.FlatAppearance.BorderSize = 0;
            this.btn_6Credito.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_6Credito.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_6Credito.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_6Credito.Location = new System.Drawing.Point(1078, 594);
            this.btn_6Credito.LockPush = true;
            this.btn_6Credito.Name = "btn_6Credito";
            this.btn_6Credito.Size = new System.Drawing.Size(97, 92);
            this.btn_6Credito.TabIndex = 199;
            this.btn_6Credito.Text = "6";
            this.btn_6Credito.UseVisualStyleBackColor = false;
            this.btn_6Credito.Click += new System.EventHandler(this.btn_6Credito_Click);
            // 
            // btn_5Credito
            // 
            this.btn_5Credito.AutoSize = true;
            this.btn_5Credito.BackColor = System.Drawing.Color.Transparent;
            this.btn_5Credito.FlatAppearance.BorderSize = 0;
            this.btn_5Credito.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_5Credito.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_5Credito.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_5Credito.Location = new System.Drawing.Point(959, 594);
            this.btn_5Credito.LockPush = true;
            this.btn_5Credito.Name = "btn_5Credito";
            this.btn_5Credito.Size = new System.Drawing.Size(97, 92);
            this.btn_5Credito.TabIndex = 198;
            this.btn_5Credito.Text = "5";
            this.btn_5Credito.UseVisualStyleBackColor = false;
            this.btn_5Credito.Click += new System.EventHandler(this.btn_5Credito_Click);
            // 
            // btn_4Credito
            // 
            this.btn_4Credito.AutoSize = true;
            this.btn_4Credito.BackColor = System.Drawing.Color.Transparent;
            this.btn_4Credito.FlatAppearance.BorderSize = 0;
            this.btn_4Credito.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_4Credito.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_4Credito.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_4Credito.Location = new System.Drawing.Point(842, 594);
            this.btn_4Credito.LockPush = true;
            this.btn_4Credito.Name = "btn_4Credito";
            this.btn_4Credito.Size = new System.Drawing.Size(97, 92);
            this.btn_4Credito.TabIndex = 197;
            this.btn_4Credito.Text = "4";
            this.btn_4Credito.UseVisualStyleBackColor = false;
            this.btn_4Credito.Click += new System.EventHandler(this.btn_4Credito_Click);
            // 
            // btn_9Credito
            // 
            this.btn_9Credito.AutoSize = true;
            this.btn_9Credito.BackColor = System.Drawing.Color.Transparent;
            this.btn_9Credito.FlatAppearance.BorderSize = 0;
            this.btn_9Credito.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_9Credito.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_9Credito.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_9Credito.Location = new System.Drawing.Point(1078, 484);
            this.btn_9Credito.LockPush = true;
            this.btn_9Credito.Name = "btn_9Credito";
            this.btn_9Credito.Size = new System.Drawing.Size(97, 92);
            this.btn_9Credito.TabIndex = 196;
            this.btn_9Credito.Text = "9";
            this.btn_9Credito.UseVisualStyleBackColor = false;
            this.btn_9Credito.Click += new System.EventHandler(this.btn_9Credito_Click);
            // 
            // btn_8Credito
            // 
            this.btn_8Credito.AutoSize = true;
            this.btn_8Credito.BackColor = System.Drawing.Color.Transparent;
            this.btn_8Credito.FlatAppearance.BorderSize = 0;
            this.btn_8Credito.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_8Credito.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_8Credito.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_8Credito.Location = new System.Drawing.Point(959, 484);
            this.btn_8Credito.LockPush = true;
            this.btn_8Credito.Name = "btn_8Credito";
            this.btn_8Credito.Size = new System.Drawing.Size(97, 92);
            this.btn_8Credito.TabIndex = 195;
            this.btn_8Credito.Text = "8";
            this.btn_8Credito.UseVisualStyleBackColor = false;
            this.btn_8Credito.Click += new System.EventHandler(this.btn_8Credito_Click);
            // 
            // btn_7Credito
            // 
            this.btn_7Credito.AutoSize = true;
            this.btn_7Credito.BackColor = System.Drawing.Color.Transparent;
            this.btn_7Credito.FlatAppearance.BorderSize = 0;
            this.btn_7Credito.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_7Credito.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_7Credito.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_7Credito.Location = new System.Drawing.Point(842, 484);
            this.btn_7Credito.LockPush = true;
            this.btn_7Credito.Name = "btn_7Credito";
            this.btn_7Credito.Size = new System.Drawing.Size(97, 92);
            this.btn_7Credito.TabIndex = 194;
            this.btn_7Credito.Text = "7";
            this.btn_7Credito.UseVisualStyleBackColor = false;
            this.btn_7Credito.Click += new System.EventHandler(this.btn_7Credito_Click);
            // 
            // lblDigitosCredito
            // 
            this.lblDigitosCredito.BackColor = System.Drawing.Color.Transparent;
            this.lblDigitosCredito.Font = new System.Drawing.Font("Microsoft Sans Serif", 45F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDigitosCredito.ForeColor = System.Drawing.Color.Black;
            this.lblDigitosCredito.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.lblDigitosCredito.Location = new System.Drawing.Point(230, 806);
            this.lblDigitosCredito.Name = "lblDigitosCredito";
            this.lblDigitosCredito.Size = new System.Drawing.Size(245, 82);
            this.lblDigitosCredito.TabIndex = 193;
            this.lblDigitosCredito.Text = "1234";
            this.lblDigitosCredito.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tabDetallePagoDatafono
            // 
            this.tabDetallePagoDatafono.Controls.Add(this.Imagen_DetallePagoDatafono);
            this.tabDetallePagoDatafono.Location = new System.Drawing.Point(4, 22);
            this.tabDetallePagoDatafono.Name = "tabDetallePagoDatafono";
            this.tabDetallePagoDatafono.Size = new System.Drawing.Size(1270, 852);
            this.tabDetallePagoDatafono.TabIndex = 75;
            this.tabDetallePagoDatafono.Text = "DetallePagoDatafono";
            this.tabDetallePagoDatafono.UseVisualStyleBackColor = true;
            // 
            // Imagen_DetallePagoDatafono
            // 
            this.Imagen_DetallePagoDatafono.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Imagen_DetallePagoDatafono.Controls.Add(this.btn_ConfirmarDetalle);
            this.Imagen_DetallePagoDatafono.Controls.Add(this.pPublicidadDetalleDatafono);
            this.Imagen_DetallePagoDatafono.Controls.Add(this.lblPermanenciaDetalle);
            this.Imagen_DetallePagoDatafono.Controls.Add(this.lblFechaDetalle);
            this.Imagen_DetallePagoDatafono.Controls.Add(this.lblTipoVehiculoDetalle);
            this.Imagen_DetallePagoDatafono.Controls.Add(this.lblValorPagarEfectivoDetalle);
            this.Imagen_DetallePagoDatafono.Controls.Add(this.lblConvenioDetalle);
            this.Imagen_DetallePagoDatafono.Controls.Add(this.btn_CancelarDetalle);
            this.Imagen_DetallePagoDatafono.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Imagen_DetallePagoDatafono.Location = new System.Drawing.Point(0, 0);
            this.Imagen_DetallePagoDatafono.Name = "Imagen_DetallePagoDatafono";
            this.Imagen_DetallePagoDatafono.Size = new System.Drawing.Size(1270, 852);
            this.Imagen_DetallePagoDatafono.TabIndex = 5023;
            // 
            // btn_ConfirmarDetalle
            // 
            this.btn_ConfirmarDetalle.AutoSize = true;
            this.btn_ConfirmarDetalle.BackColor = System.Drawing.Color.Transparent;
            this.btn_ConfirmarDetalle.FlatAppearance.BorderSize = 0;
            this.btn_ConfirmarDetalle.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_ConfirmarDetalle.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_ConfirmarDetalle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ConfirmarDetalle.Location = new System.Drawing.Point(702, 759);
            this.btn_ConfirmarDetalle.LockPush = true;
            this.btn_ConfirmarDetalle.Name = "btn_ConfirmarDetalle";
            this.btn_ConfirmarDetalle.Size = new System.Drawing.Size(176, 66);
            this.btn_ConfirmarDetalle.TabIndex = 5026;
            this.btn_ConfirmarDetalle.Text = "Confirmar";
            this.btn_ConfirmarDetalle.UseVisualStyleBackColor = false;
            this.btn_ConfirmarDetalle.Click += new System.EventHandler(this.btn_ConfirmarDetalle_Click);
            // 
            // pPublicidadDetalleDatafono
            // 
            this.pPublicidadDetalleDatafono.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pPublicidadDetalleDatafono.Location = new System.Drawing.Point(3, 0);
            this.pPublicidadDetalleDatafono.Name = "pPublicidadDetalleDatafono";
            this.pPublicidadDetalleDatafono.Size = new System.Drawing.Size(1258, 417);
            this.pPublicidadDetalleDatafono.TabIndex = 5025;
            this.pPublicidadDetalleDatafono.TabStop = false;
            // 
            // lblPermanenciaDetalle
            // 
            this.lblPermanenciaDetalle.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPermanenciaDetalle.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblPermanenciaDetalle.Location = new System.Drawing.Point(705, 551);
            this.lblPermanenciaDetalle.Name = "lblPermanenciaDetalle";
            this.lblPermanenciaDetalle.Size = new System.Drawing.Size(186, 32);
            this.lblPermanenciaDetalle.TabIndex = 1;
            this.lblPermanenciaDetalle.Text = "3 horas 59 min 59 seg";
            this.lblPermanenciaDetalle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblFechaDetalle
            // 
            this.lblFechaDetalle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaDetalle.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblFechaDetalle.Location = new System.Drawing.Point(260, 554);
            this.lblFechaDetalle.Name = "lblFechaDetalle";
            this.lblFechaDetalle.Size = new System.Drawing.Size(140, 35);
            this.lblFechaDetalle.TabIndex = 1129;
            this.lblFechaDetalle.Text = "2019/08/24 20:50:00";
            this.lblFechaDetalle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTipoVehiculoDetalle
            // 
            this.lblTipoVehiculoDetalle.BackColor = System.Drawing.Color.Transparent;
            this.lblTipoVehiculoDetalle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoVehiculoDetalle.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblTipoVehiculoDetalle.Location = new System.Drawing.Point(258, 678);
            this.lblTipoVehiculoDetalle.Name = "lblTipoVehiculoDetalle";
            this.lblTipoVehiculoDetalle.Size = new System.Drawing.Size(151, 38);
            this.lblTipoVehiculoDetalle.TabIndex = 1139;
            this.lblTipoVehiculoDetalle.Text = "CARRO";
            this.lblTipoVehiculoDetalle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblValorPagarEfectivoDetalle
            // 
            this.lblValorPagarEfectivoDetalle.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblValorPagarEfectivoDetalle.BackColor = System.Drawing.Color.Transparent;
            this.lblValorPagarEfectivoDetalle.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValorPagarEfectivoDetalle.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblValorPagarEfectivoDetalle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblValorPagarEfectivoDetalle.Location = new System.Drawing.Point(108, 745);
            this.lblValorPagarEfectivoDetalle.Name = "lblValorPagarEfectivoDetalle";
            this.lblValorPagarEfectivoDetalle.Size = new System.Drawing.Size(152, 60);
            this.lblValorPagarEfectivoDetalle.TabIndex = 1131;
            this.lblValorPagarEfectivoDetalle.Text = "$27.000";
            this.lblValorPagarEfectivoDetalle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblConvenioDetalle
            // 
            this.lblConvenioDetalle.BackColor = System.Drawing.Color.Transparent;
            this.lblConvenioDetalle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConvenioDetalle.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblConvenioDetalle.Location = new System.Drawing.Point(701, 676);
            this.lblConvenioDetalle.Name = "lblConvenioDetalle";
            this.lblConvenioDetalle.Size = new System.Drawing.Size(177, 30);
            this.lblConvenioDetalle.TabIndex = 1136;
            this.lblConvenioDetalle.Text = "COMPRADOR";
            this.lblConvenioDetalle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_CancelarDetalle
            // 
            this.btn_CancelarDetalle.AutoSize = true;
            this.btn_CancelarDetalle.BackColor = System.Drawing.Color.Transparent;
            this.btn_CancelarDetalle.FlatAppearance.BorderSize = 0;
            this.btn_CancelarDetalle.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_CancelarDetalle.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_CancelarDetalle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_CancelarDetalle.Location = new System.Drawing.Point(1053, 753);
            this.btn_CancelarDetalle.LockPush = true;
            this.btn_CancelarDetalle.Name = "btn_CancelarDetalle";
            this.btn_CancelarDetalle.Size = new System.Drawing.Size(176, 66);
            this.btn_CancelarDetalle.TabIndex = 1122;
            this.btn_CancelarDetalle.Text = "Cancelar";
            this.btn_CancelarDetalle.UseVisualStyleBackColor = false;
            this.btn_CancelarDetalle.Click += new System.EventHandler(this.btn_CancelarDetalle_Click);
            // 
            // tabDetallePago
            // 
            this.tabDetallePago.Controls.Add(this.Imagen_DetallePago);
            this.tabDetallePago.Location = new System.Drawing.Point(4, 22);
            this.tabDetallePago.Name = "tabDetallePago";
            this.tabDetallePago.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tabDetallePago.Size = new System.Drawing.Size(1270, 852);
            this.tabDetallePago.TabIndex = 47;
            this.tabDetallePago.Text = "DetallePago";
            this.tabDetallePago.UseVisualStyleBackColor = true;
            // 
            // Imagen_DetallePago
            // 
            this.Imagen_DetallePago.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Imagen_DetallePago.Controls.Add(this.tbCodigo);
            this.Imagen_DetallePago.Controls.Add(this.pPublicidadDetalle);
            this.Imagen_DetallePago.Controls.Add(this.lblCambio);
            this.Imagen_DetallePago.Controls.Add(this.lblValorRecibido);
            this.Imagen_DetallePago.Controls.Add(this.lblPermanencia);
            this.Imagen_DetallePago.Controls.Add(this.lblFecha);
            this.Imagen_DetallePago.Controls.Add(this.lblTipoVehiculo);
            this.Imagen_DetallePago.Controls.Add(this.lblValorPagarEfectivo);
            this.Imagen_DetallePago.Controls.Add(this.lblConvenio);
            this.Imagen_DetallePago.Controls.Add(this.btn_CancelarPagoEfectivo);
            this.Imagen_DetallePago.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Imagen_DetallePago.Location = new System.Drawing.Point(3, 3);
            this.Imagen_DetallePago.Name = "Imagen_DetallePago";
            this.Imagen_DetallePago.Size = new System.Drawing.Size(1264, 846);
            this.Imagen_DetallePago.TabIndex = 5022;
            // 
            // tbCodigo
            // 
            this.tbCodigo.AcceptsTab = true;
            this.tbCodigo.Location = new System.Drawing.Point(-7, 14);
            this.tbCodigo.MaxLength = 10;
            this.tbCodigo.Multiline = true;
            this.tbCodigo.Name = "tbCodigo";
            this.tbCodigo.Size = new System.Drawing.Size(205, 28);
            this.tbCodigo.TabIndex = 5026;
            this.tbCodigo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbCodigo_KeyPress);
            // 
            // pPublicidadDetalle
            // 
            this.pPublicidadDetalle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pPublicidadDetalle.Location = new System.Drawing.Point(3, 0);
            this.pPublicidadDetalle.Name = "pPublicidadDetalle";
            this.pPublicidadDetalle.Size = new System.Drawing.Size(1258, 417);
            this.pPublicidadDetalle.TabIndex = 5025;
            this.pPublicidadDetalle.TabStop = false;
            // 
            // lblCambio
            // 
            this.lblCambio.BackColor = System.Drawing.Color.Transparent;
            this.lblCambio.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCambio.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblCambio.Location = new System.Drawing.Point(697, 820);
            this.lblCambio.Name = "lblCambio";
            this.lblCambio.Size = new System.Drawing.Size(182, 52);
            this.lblCambio.TabIndex = 1142;
            this.lblCambio.Text = "$27.000";
            this.lblCambio.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblValorRecibido
            // 
            this.lblValorRecibido.BackColor = System.Drawing.Color.Transparent;
            this.lblValorRecibido.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValorRecibido.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblValorRecibido.Location = new System.Drawing.Point(391, 815);
            this.lblValorRecibido.Name = "lblValorRecibido";
            this.lblValorRecibido.Size = new System.Drawing.Size(180, 63);
            this.lblValorRecibido.TabIndex = 1141;
            this.lblValorRecibido.Text = "$27.000";
            this.lblValorRecibido.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPermanencia
            // 
            this.lblPermanencia.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPermanencia.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblPermanencia.Location = new System.Drawing.Point(705, 551);
            this.lblPermanencia.Name = "lblPermanencia";
            this.lblPermanencia.Size = new System.Drawing.Size(186, 32);
            this.lblPermanencia.TabIndex = 1;
            this.lblPermanencia.Text = "3 horas 59 min 59 seg";
            this.lblPermanencia.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblFecha
            // 
            this.lblFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblFecha.Location = new System.Drawing.Point(260, 554);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(140, 35);
            this.lblFecha.TabIndex = 1129;
            this.lblFecha.Text = "2019/08/24 20:50:00";
            this.lblFecha.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTipoVehiculo
            // 
            this.lblTipoVehiculo.BackColor = System.Drawing.Color.Transparent;
            this.lblTipoVehiculo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoVehiculo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblTipoVehiculo.Location = new System.Drawing.Point(258, 678);
            this.lblTipoVehiculo.Name = "lblTipoVehiculo";
            this.lblTipoVehiculo.Size = new System.Drawing.Size(151, 38);
            this.lblTipoVehiculo.TabIndex = 1139;
            this.lblTipoVehiculo.Text = "CARRO";
            this.lblTipoVehiculo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblValorPagarEfectivo
            // 
            this.lblValorPagarEfectivo.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblValorPagarEfectivo.BackColor = System.Drawing.Color.Transparent;
            this.lblValorPagarEfectivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValorPagarEfectivo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblValorPagarEfectivo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblValorPagarEfectivo.Location = new System.Drawing.Point(108, 741);
            this.lblValorPagarEfectivo.Name = "lblValorPagarEfectivo";
            this.lblValorPagarEfectivo.Size = new System.Drawing.Size(152, 60);
            this.lblValorPagarEfectivo.TabIndex = 1131;
            this.lblValorPagarEfectivo.Text = "$27.000";
            this.lblValorPagarEfectivo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblConvenio
            // 
            this.lblConvenio.BackColor = System.Drawing.Color.Transparent;
            this.lblConvenio.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConvenio.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblConvenio.Location = new System.Drawing.Point(701, 676);
            this.lblConvenio.Name = "lblConvenio";
            this.lblConvenio.Size = new System.Drawing.Size(177, 30);
            this.lblConvenio.TabIndex = 1136;
            this.lblConvenio.Text = "COMPRADOR";
            this.lblConvenio.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_CancelarPagoEfectivo
            // 
            this.btn_CancelarPagoEfectivo.AutoSize = true;
            this.btn_CancelarPagoEfectivo.BackColor = System.Drawing.Color.Transparent;
            this.btn_CancelarPagoEfectivo.FlatAppearance.BorderSize = 0;
            this.btn_CancelarPagoEfectivo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_CancelarPagoEfectivo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_CancelarPagoEfectivo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_CancelarPagoEfectivo.Location = new System.Drawing.Point(980, 666);
            this.btn_CancelarPagoEfectivo.LockPush = true;
            this.btn_CancelarPagoEfectivo.Name = "btn_CancelarPagoEfectivo";
            this.btn_CancelarPagoEfectivo.Size = new System.Drawing.Size(176, 66);
            this.btn_CancelarPagoEfectivo.TabIndex = 1122;
            this.btn_CancelarPagoEfectivo.Text = "Cancelar";
            this.btn_CancelarPagoEfectivo.UseVisualStyleBackColor = false;
            this.btn_CancelarPagoEfectivo.Click += new System.EventHandler(this.btn_CancelarPagoEfectivo_Click);
            // 
            // tabInserteTarjetaDatafono
            // 
            this.tabInserteTarjetaDatafono.Controls.Add(this.Imagen_InserteTarjetaDatafono);
            this.tabInserteTarjetaDatafono.Location = new System.Drawing.Point(4, 22);
            this.tabInserteTarjetaDatafono.Name = "tabInserteTarjetaDatafono";
            this.tabInserteTarjetaDatafono.Size = new System.Drawing.Size(1270, 852);
            this.tabInserteTarjetaDatafono.TabIndex = 71;
            this.tabInserteTarjetaDatafono.Text = "InserteTarjetaDatafono";
            this.tabInserteTarjetaDatafono.UseVisualStyleBackColor = true;
            // 
            // Imagen_InserteTarjetaDatafono
            // 
            this.Imagen_InserteTarjetaDatafono.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Imagen_InserteTarjetaDatafono.Controls.Add(this.btn_Volver2);
            this.Imagen_InserteTarjetaDatafono.Controls.Add(this.btn_PagoQR);
            this.Imagen_InserteTarjetaDatafono.Controls.Add(this.pPublicidadInsertaDatafono);
            this.Imagen_InserteTarjetaDatafono.Controls.Add(this.btn_PagoMovil);
            this.Imagen_InserteTarjetaDatafono.Controls.Add(this.btn_PagoNormal);
            this.Imagen_InserteTarjetaDatafono.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Imagen_InserteTarjetaDatafono.Location = new System.Drawing.Point(0, 0);
            this.Imagen_InserteTarjetaDatafono.Name = "Imagen_InserteTarjetaDatafono";
            this.Imagen_InserteTarjetaDatafono.Size = new System.Drawing.Size(1270, 852);
            this.Imagen_InserteTarjetaDatafono.TabIndex = 5025;
            // 
            // btn_Volver2
            // 
            this.btn_Volver2.AutoSize = true;
            this.btn_Volver2.BackColor = System.Drawing.Color.Transparent;
            this.btn_Volver2.FlatAppearance.BorderSize = 0;
            this.btn_Volver2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_Volver2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_Volver2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Volver2.Location = new System.Drawing.Point(1045, 856);
            this.btn_Volver2.LockPush = true;
            this.btn_Volver2.Name = "btn_Volver2";
            this.btn_Volver2.Size = new System.Drawing.Size(80, 28);
            this.btn_Volver2.TabIndex = 5072;
            this.btn_Volver2.Text = "vOLVER";
            this.btn_Volver2.UseVisualStyleBackColor = false;
            this.btn_Volver2.Visible = false;
            this.btn_Volver2.Click += new System.EventHandler(this.btn_Volver2_Click);
            // 
            // btn_PagoQR
            // 
            this.btn_PagoQR.AutoSize = true;
            this.btn_PagoQR.BackColor = System.Drawing.Color.Transparent;
            this.btn_PagoQR.FlatAppearance.BorderSize = 0;
            this.btn_PagoQR.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_PagoQR.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_PagoQR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_PagoQR.Location = new System.Drawing.Point(558, 670);
            this.btn_PagoQR.LockPush = true;
            this.btn_PagoQR.Name = "btn_PagoQR";
            this.btn_PagoQR.Size = new System.Drawing.Size(88, 95);
            this.btn_PagoQR.TabIndex = 5071;
            this.btn_PagoQR.Text = "QR";
            this.btn_PagoQR.UseVisualStyleBackColor = false;
            this.btn_PagoQR.Visible = false;
            this.btn_PagoQR.Click += new System.EventHandler(this.btn_PagoQR_Click);
            // 
            // pPublicidadInsertaDatafono
            // 
            this.pPublicidadInsertaDatafono.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pPublicidadInsertaDatafono.Location = new System.Drawing.Point(5, 0);
            this.pPublicidadInsertaDatafono.Name = "pPublicidadInsertaDatafono";
            this.pPublicidadInsertaDatafono.Size = new System.Drawing.Size(1258, 417);
            this.pPublicidadInsertaDatafono.TabIndex = 5070;
            // 
            // btn_PagoMovil
            // 
            this.btn_PagoMovil.AutoSize = true;
            this.btn_PagoMovil.BackColor = System.Drawing.Color.Transparent;
            this.btn_PagoMovil.FlatAppearance.BorderSize = 0;
            this.btn_PagoMovil.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_PagoMovil.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_PagoMovil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_PagoMovil.Location = new System.Drawing.Point(287, 670);
            this.btn_PagoMovil.LockPush = true;
            this.btn_PagoMovil.Name = "btn_PagoMovil";
            this.btn_PagoMovil.Size = new System.Drawing.Size(88, 95);
            this.btn_PagoMovil.TabIndex = 5069;
            this.btn_PagoMovil.Text = "PagoMovil";
            this.btn_PagoMovil.UseVisualStyleBackColor = false;
            this.btn_PagoMovil.Visible = false;
            this.btn_PagoMovil.Click += new System.EventHandler(this.btn_PagoMovil_Click);
            // 
            // btn_PagoNormal
            // 
            this.btn_PagoNormal.AutoSize = true;
            this.btn_PagoNormal.BackColor = System.Drawing.Color.Transparent;
            this.btn_PagoNormal.FlatAppearance.BorderSize = 0;
            this.btn_PagoNormal.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_PagoNormal.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_PagoNormal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_PagoNormal.Location = new System.Drawing.Point(834, 670);
            this.btn_PagoNormal.LockPush = true;
            this.btn_PagoNormal.Name = "btn_PagoNormal";
            this.btn_PagoNormal.Size = new System.Drawing.Size(88, 95);
            this.btn_PagoNormal.TabIndex = 5068;
            this.btn_PagoNormal.Text = "nORMAL";
            this.btn_PagoNormal.UseVisualStyleBackColor = false;
            this.btn_PagoNormal.Visible = false;
            this.btn_PagoNormal.Click += new System.EventHandler(this.btn_PagoNormal_Click);
            // 
            // tabNumeroCuotas
            // 
            this.tabNumeroCuotas.Controls.Add(this.Imagen_NumeroCuotas);
            this.tabNumeroCuotas.Location = new System.Drawing.Point(4, 22);
            this.tabNumeroCuotas.Name = "tabNumeroCuotas";
            this.tabNumeroCuotas.Size = new System.Drawing.Size(1270, 852);
            this.tabNumeroCuotas.TabIndex = 72;
            this.tabNumeroCuotas.Text = "NumeroCuotas";
            this.tabNumeroCuotas.UseVisualStyleBackColor = true;
            // 
            // Imagen_NumeroCuotas
            // 
            this.Imagen_NumeroCuotas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Imagen_NumeroCuotas.Controls.Add(this.pPublicidadCuotas);
            this.Imagen_NumeroCuotas.Controls.Add(this.btn_CancelarCuotas);
            this.Imagen_NumeroCuotas.Controls.Add(this.btn_okCuotas);
            this.Imagen_NumeroCuotas.Controls.Add(this.btn_BorrarCuotas);
            this.Imagen_NumeroCuotas.Controls.Add(this.btn_0Cuotas);
            this.Imagen_NumeroCuotas.Controls.Add(this.btn_3Cuotas);
            this.Imagen_NumeroCuotas.Controls.Add(this.btn_2Cuotas);
            this.Imagen_NumeroCuotas.Controls.Add(this.btn_1Cuotas);
            this.Imagen_NumeroCuotas.Controls.Add(this.btn_6Cuotas);
            this.Imagen_NumeroCuotas.Controls.Add(this.btn_5Cuotas);
            this.Imagen_NumeroCuotas.Controls.Add(this.btn_4Cuotas);
            this.Imagen_NumeroCuotas.Controls.Add(this.btn_9Cuotas);
            this.Imagen_NumeroCuotas.Controls.Add(this.btn_8Cuotas);
            this.Imagen_NumeroCuotas.Controls.Add(this.btn_7Cuotas);
            this.Imagen_NumeroCuotas.Controls.Add(this.lblCuotas);
            this.Imagen_NumeroCuotas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Imagen_NumeroCuotas.Location = new System.Drawing.Point(0, 0);
            this.Imagen_NumeroCuotas.Name = "Imagen_NumeroCuotas";
            this.Imagen_NumeroCuotas.Size = new System.Drawing.Size(1270, 852);
            this.Imagen_NumeroCuotas.TabIndex = 5027;
            // 
            // pPublicidadCuotas
            // 
            this.pPublicidadCuotas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pPublicidadCuotas.Location = new System.Drawing.Point(5, 0);
            this.pPublicidadCuotas.Name = "pPublicidadCuotas";
            this.pPublicidadCuotas.Size = new System.Drawing.Size(1258, 417);
            this.pPublicidadCuotas.TabIndex = 5027;
            // 
            // btn_CancelarCuotas
            // 
            this.btn_CancelarCuotas.AutoSize = true;
            this.btn_CancelarCuotas.BackColor = System.Drawing.Color.Transparent;
            this.btn_CancelarCuotas.FlatAppearance.BorderSize = 0;
            this.btn_CancelarCuotas.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_CancelarCuotas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_CancelarCuotas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_CancelarCuotas.Location = new System.Drawing.Point(548, 821);
            this.btn_CancelarCuotas.LockPush = true;
            this.btn_CancelarCuotas.Name = "btn_CancelarCuotas";
            this.btn_CancelarCuotas.Size = new System.Drawing.Size(136, 42);
            this.btn_CancelarCuotas.TabIndex = 206;
            this.btn_CancelarCuotas.Text = "borrar";
            this.btn_CancelarCuotas.UseVisualStyleBackColor = false;
            this.btn_CancelarCuotas.Click += new System.EventHandler(this.btn_CancelarCuotas_Click);
            // 
            // btn_okCuotas
            // 
            this.btn_okCuotas.AutoSize = true;
            this.btn_okCuotas.BackColor = System.Drawing.Color.Transparent;
            this.btn_okCuotas.FlatAppearance.BorderSize = 0;
            this.btn_okCuotas.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_okCuotas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_okCuotas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_okCuotas.Location = new System.Drawing.Point(839, 831);
            this.btn_okCuotas.LockPush = true;
            this.btn_okCuotas.Name = "btn_okCuotas";
            this.btn_okCuotas.Size = new System.Drawing.Size(97, 92);
            this.btn_okCuotas.TabIndex = 205;
            this.btn_okCuotas.Text = "ok";
            this.btn_okCuotas.UseVisualStyleBackColor = false;
            this.btn_okCuotas.Click += new System.EventHandler(this.btn_okCuotas_Click);
            // 
            // btn_BorrarCuotas
            // 
            this.btn_BorrarCuotas.AutoSize = true;
            this.btn_BorrarCuotas.BackColor = System.Drawing.Color.Transparent;
            this.btn_BorrarCuotas.FlatAppearance.BorderSize = 0;
            this.btn_BorrarCuotas.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_BorrarCuotas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_BorrarCuotas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_BorrarCuotas.Location = new System.Drawing.Point(1072, 831);
            this.btn_BorrarCuotas.LockPush = true;
            this.btn_BorrarCuotas.Name = "btn_BorrarCuotas";
            this.btn_BorrarCuotas.Size = new System.Drawing.Size(97, 92);
            this.btn_BorrarCuotas.TabIndex = 204;
            this.btn_BorrarCuotas.Text = "borrar";
            this.btn_BorrarCuotas.UseVisualStyleBackColor = false;
            this.btn_BorrarCuotas.Click += new System.EventHandler(this.btn_BorrarCuotas_Click);
            // 
            // btn_0Cuotas
            // 
            this.btn_0Cuotas.AutoSize = true;
            this.btn_0Cuotas.BackColor = System.Drawing.Color.Transparent;
            this.btn_0Cuotas.FlatAppearance.BorderSize = 0;
            this.btn_0Cuotas.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_0Cuotas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_0Cuotas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_0Cuotas.Location = new System.Drawing.Point(966, 842);
            this.btn_0Cuotas.LockPush = true;
            this.btn_0Cuotas.Name = "btn_0Cuotas";
            this.btn_0Cuotas.Size = new System.Drawing.Size(97, 92);
            this.btn_0Cuotas.TabIndex = 203;
            this.btn_0Cuotas.Text = "0";
            this.btn_0Cuotas.UseVisualStyleBackColor = false;
            this.btn_0Cuotas.Click += new System.EventHandler(this.btn_0Cuotas_Click);
            // 
            // btn_3Cuotas
            // 
            this.btn_3Cuotas.AutoSize = true;
            this.btn_3Cuotas.BackColor = System.Drawing.Color.Transparent;
            this.btn_3Cuotas.FlatAppearance.BorderSize = 0;
            this.btn_3Cuotas.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_3Cuotas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_3Cuotas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_3Cuotas.Location = new System.Drawing.Point(1085, 726);
            this.btn_3Cuotas.LockPush = true;
            this.btn_3Cuotas.Name = "btn_3Cuotas";
            this.btn_3Cuotas.Size = new System.Drawing.Size(97, 92);
            this.btn_3Cuotas.TabIndex = 202;
            this.btn_3Cuotas.Text = "3";
            this.btn_3Cuotas.UseVisualStyleBackColor = false;
            this.btn_3Cuotas.Click += new System.EventHandler(this.btn_3Cuotas_Click);
            // 
            // btn_2Cuotas
            // 
            this.btn_2Cuotas.AutoSize = true;
            this.btn_2Cuotas.BackColor = System.Drawing.Color.Transparent;
            this.btn_2Cuotas.FlatAppearance.BorderSize = 0;
            this.btn_2Cuotas.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_2Cuotas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_2Cuotas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_2Cuotas.Location = new System.Drawing.Point(966, 726);
            this.btn_2Cuotas.LockPush = true;
            this.btn_2Cuotas.Name = "btn_2Cuotas";
            this.btn_2Cuotas.Size = new System.Drawing.Size(97, 92);
            this.btn_2Cuotas.TabIndex = 201;
            this.btn_2Cuotas.Text = "2";
            this.btn_2Cuotas.UseVisualStyleBackColor = false;
            this.btn_2Cuotas.Click += new System.EventHandler(this.btn_2Cuotas_Click);
            // 
            // btn_1Cuotas
            // 
            this.btn_1Cuotas.AutoSize = true;
            this.btn_1Cuotas.BackColor = System.Drawing.Color.Transparent;
            this.btn_1Cuotas.FlatAppearance.BorderSize = 0;
            this.btn_1Cuotas.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_1Cuotas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_1Cuotas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_1Cuotas.Location = new System.Drawing.Point(849, 726);
            this.btn_1Cuotas.LockPush = true;
            this.btn_1Cuotas.Name = "btn_1Cuotas";
            this.btn_1Cuotas.Size = new System.Drawing.Size(97, 92);
            this.btn_1Cuotas.TabIndex = 200;
            this.btn_1Cuotas.Text = "1";
            this.btn_1Cuotas.UseVisualStyleBackColor = false;
            this.btn_1Cuotas.Click += new System.EventHandler(this.btn_1Cuotas_Click);
            // 
            // btn_6Cuotas
            // 
            this.btn_6Cuotas.AutoSize = true;
            this.btn_6Cuotas.BackColor = System.Drawing.Color.Transparent;
            this.btn_6Cuotas.FlatAppearance.BorderSize = 0;
            this.btn_6Cuotas.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_6Cuotas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_6Cuotas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_6Cuotas.Location = new System.Drawing.Point(1085, 613);
            this.btn_6Cuotas.LockPush = true;
            this.btn_6Cuotas.Name = "btn_6Cuotas";
            this.btn_6Cuotas.Size = new System.Drawing.Size(97, 92);
            this.btn_6Cuotas.TabIndex = 199;
            this.btn_6Cuotas.Text = "6";
            this.btn_6Cuotas.UseVisualStyleBackColor = false;
            this.btn_6Cuotas.Click += new System.EventHandler(this.btn_6Cuotas_Click);
            // 
            // btn_5Cuotas
            // 
            this.btn_5Cuotas.AutoSize = true;
            this.btn_5Cuotas.BackColor = System.Drawing.Color.Transparent;
            this.btn_5Cuotas.FlatAppearance.BorderSize = 0;
            this.btn_5Cuotas.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_5Cuotas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_5Cuotas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_5Cuotas.Location = new System.Drawing.Point(966, 613);
            this.btn_5Cuotas.LockPush = true;
            this.btn_5Cuotas.Name = "btn_5Cuotas";
            this.btn_5Cuotas.Size = new System.Drawing.Size(97, 92);
            this.btn_5Cuotas.TabIndex = 198;
            this.btn_5Cuotas.Text = "5";
            this.btn_5Cuotas.UseVisualStyleBackColor = false;
            this.btn_5Cuotas.Click += new System.EventHandler(this.btn_5Cuotas_Click);
            // 
            // btn_4Cuotas
            // 
            this.btn_4Cuotas.AutoSize = true;
            this.btn_4Cuotas.BackColor = System.Drawing.Color.Transparent;
            this.btn_4Cuotas.FlatAppearance.BorderSize = 0;
            this.btn_4Cuotas.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_4Cuotas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_4Cuotas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_4Cuotas.Location = new System.Drawing.Point(849, 613);
            this.btn_4Cuotas.LockPush = true;
            this.btn_4Cuotas.Name = "btn_4Cuotas";
            this.btn_4Cuotas.Size = new System.Drawing.Size(97, 92);
            this.btn_4Cuotas.TabIndex = 197;
            this.btn_4Cuotas.Text = "4";
            this.btn_4Cuotas.UseVisualStyleBackColor = false;
            this.btn_4Cuotas.Click += new System.EventHandler(this.btn_4Cuotas_Click);
            // 
            // btn_9Cuotas
            // 
            this.btn_9Cuotas.AutoSize = true;
            this.btn_9Cuotas.BackColor = System.Drawing.Color.Transparent;
            this.btn_9Cuotas.FlatAppearance.BorderSize = 0;
            this.btn_9Cuotas.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_9Cuotas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_9Cuotas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_9Cuotas.Location = new System.Drawing.Point(1085, 503);
            this.btn_9Cuotas.LockPush = true;
            this.btn_9Cuotas.Name = "btn_9Cuotas";
            this.btn_9Cuotas.Size = new System.Drawing.Size(97, 92);
            this.btn_9Cuotas.TabIndex = 196;
            this.btn_9Cuotas.Text = "9";
            this.btn_9Cuotas.UseVisualStyleBackColor = false;
            this.btn_9Cuotas.Click += new System.EventHandler(this.btn_9Cuotas_Click);
            // 
            // btn_8Cuotas
            // 
            this.btn_8Cuotas.AutoSize = true;
            this.btn_8Cuotas.BackColor = System.Drawing.Color.Transparent;
            this.btn_8Cuotas.FlatAppearance.BorderSize = 0;
            this.btn_8Cuotas.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_8Cuotas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_8Cuotas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_8Cuotas.Location = new System.Drawing.Point(966, 503);
            this.btn_8Cuotas.LockPush = true;
            this.btn_8Cuotas.Name = "btn_8Cuotas";
            this.btn_8Cuotas.Size = new System.Drawing.Size(97, 92);
            this.btn_8Cuotas.TabIndex = 195;
            this.btn_8Cuotas.Text = "8";
            this.btn_8Cuotas.UseVisualStyleBackColor = false;
            this.btn_8Cuotas.Click += new System.EventHandler(this.btn_8Cuotas_Click);
            // 
            // btn_7Cuotas
            // 
            this.btn_7Cuotas.AutoSize = true;
            this.btn_7Cuotas.BackColor = System.Drawing.Color.Transparent;
            this.btn_7Cuotas.FlatAppearance.BorderSize = 0;
            this.btn_7Cuotas.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_7Cuotas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_7Cuotas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_7Cuotas.Location = new System.Drawing.Point(849, 503);
            this.btn_7Cuotas.LockPush = true;
            this.btn_7Cuotas.Name = "btn_7Cuotas";
            this.btn_7Cuotas.Size = new System.Drawing.Size(97, 92);
            this.btn_7Cuotas.TabIndex = 194;
            this.btn_7Cuotas.Text = "7";
            this.btn_7Cuotas.UseVisualStyleBackColor = false;
            this.btn_7Cuotas.Click += new System.EventHandler(this.btn_7Cuotas_Click);
            // 
            // lblCuotas
            // 
            this.lblCuotas.BackColor = System.Drawing.Color.Transparent;
            this.lblCuotas.Font = new System.Drawing.Font("Microsoft Sans Serif", 45F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCuotas.ForeColor = System.Drawing.Color.Black;
            this.lblCuotas.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.lblCuotas.Location = new System.Drawing.Point(230, 806);
            this.lblCuotas.Name = "lblCuotas";
            this.lblCuotas.Size = new System.Drawing.Size(246, 82);
            this.lblCuotas.TabIndex = 193;
            this.lblCuotas.Text = "1234";
            this.lblCuotas.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tabConsultaFallida
            // 
            this.tabConsultaFallida.Controls.Add(this.Imagen_ConsultaFallida);
            this.tabConsultaFallida.Location = new System.Drawing.Point(4, 22);
            this.tabConsultaFallida.Name = "tabConsultaFallida";
            this.tabConsultaFallida.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tabConsultaFallida.Size = new System.Drawing.Size(1270, 852);
            this.tabConsultaFallida.TabIndex = 69;
            this.tabConsultaFallida.Text = "ConsultaFallida";
            this.tabConsultaFallida.UseVisualStyleBackColor = true;
            // 
            // Imagen_ConsultaFallida
            // 
            this.Imagen_ConsultaFallida.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Imagen_ConsultaFallida.Controls.Add(this.customButton1);
            this.Imagen_ConsultaFallida.Controls.Add(this.customButton2);
            this.Imagen_ConsultaFallida.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Imagen_ConsultaFallida.Location = new System.Drawing.Point(3, 3);
            this.Imagen_ConsultaFallida.Name = "Imagen_ConsultaFallida";
            this.Imagen_ConsultaFallida.Size = new System.Drawing.Size(1264, 846);
            this.Imagen_ConsultaFallida.TabIndex = 5025;
            // 
            // customButton1
            // 
            this.customButton1.AutoSize = true;
            this.customButton1.BackColor = System.Drawing.Color.Transparent;
            this.customButton1.FlatAppearance.BorderSize = 0;
            this.customButton1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.customButton1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.customButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.customButton1.Location = new System.Drawing.Point(286, 743);
            this.customButton1.LockPush = true;
            this.customButton1.Name = "customButton1";
            this.customButton1.Size = new System.Drawing.Size(143, 68);
            this.customButton1.TabIndex = 5025;
            this.customButton1.Text = "SI";
            this.customButton1.UseVisualStyleBackColor = false;
            // 
            // customButton2
            // 
            this.customButton2.AutoSize = true;
            this.customButton2.BackColor = System.Drawing.Color.Transparent;
            this.customButton2.FlatAppearance.BorderSize = 0;
            this.customButton2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.customButton2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.customButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.customButton2.Location = new System.Drawing.Point(712, 743);
            this.customButton2.LockPush = true;
            this.customButton2.Name = "customButton2";
            this.customButton2.Size = new System.Drawing.Size(143, 68);
            this.customButton2.TabIndex = 1144;
            this.customButton2.Text = "NO";
            this.customButton2.UseVisualStyleBackColor = false;
            // 
            // tabPuedeSalir
            // 
            this.tabPuedeSalir.Controls.Add(this.imagen_PuedeSalir);
            this.tabPuedeSalir.Location = new System.Drawing.Point(4, 22);
            this.tabPuedeSalir.Name = "tabPuedeSalir";
            this.tabPuedeSalir.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tabPuedeSalir.Size = new System.Drawing.Size(1270, 852);
            this.tabPuedeSalir.TabIndex = 68;
            this.tabPuedeSalir.Text = "PuedeSalir";
            this.tabPuedeSalir.UseVisualStyleBackColor = true;
            // 
            // imagen_PuedeSalir
            // 
            this.imagen_PuedeSalir.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("imagen_PuedeSalir.BackgroundImage")));
            this.imagen_PuedeSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.imagen_PuedeSalir.Controls.Add(this.lblTiempoSalida);
            this.imagen_PuedeSalir.Controls.Add(this.pPublicidadPuedeSalir);
            this.imagen_PuedeSalir.Dock = System.Windows.Forms.DockStyle.Fill;
            this.imagen_PuedeSalir.Location = new System.Drawing.Point(3, 3);
            this.imagen_PuedeSalir.Name = "imagen_PuedeSalir";
            this.imagen_PuedeSalir.Size = new System.Drawing.Size(1264, 846);
            this.imagen_PuedeSalir.TabIndex = 5022;
            // 
            // lblTiempoSalida
            // 
            this.lblTiempoSalida.AutoSize = true;
            this.lblTiempoSalida.Font = new System.Drawing.Font("Microsoft Sans Serif", 60F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTiempoSalida.Location = new System.Drawing.Point(355, 614);
            this.lblTiempoSalida.Name = "lblTiempoSalida";
            this.lblTiempoSalida.Size = new System.Drawing.Size(127, 91);
            this.lblTiempoSalida.TabIndex = 1;
            this.lblTiempoSalida.Text = "15";
            // 
            // pPublicidadPuedeSalir
            // 
            this.pPublicidadPuedeSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pPublicidadPuedeSalir.Location = new System.Drawing.Point(5, 0);
            this.pPublicidadPuedeSalir.Name = "pPublicidadPuedeSalir";
            this.pPublicidadPuedeSalir.Size = new System.Drawing.Size(1258, 417);
            this.pPublicidadPuedeSalir.TabIndex = 0;
            // 
            // tabPagoParcial
            // 
            this.tabPagoParcial.Controls.Add(this.Imagen_PagoParcial);
            this.tabPagoParcial.Controls.Add(this.pPublicidadPagoParcial);
            this.tabPagoParcial.Location = new System.Drawing.Point(4, 22);
            this.tabPagoParcial.Name = "tabPagoParcial";
            this.tabPagoParcial.Size = new System.Drawing.Size(1270, 852);
            this.tabPagoParcial.TabIndex = 76;
            this.tabPagoParcial.Text = "PagoParcial";
            this.tabPagoParcial.UseVisualStyleBackColor = true;
            // 
            // Imagen_PagoParcial
            // 
            this.Imagen_PagoParcial.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Imagen_PagoParcial.Controls.Add(this.btn_ConfirmarPagoFE);
            this.Imagen_PagoParcial.Controls.Add(this.btn_AnularPagoParcial);
            this.Imagen_PagoParcial.Controls.Add(this.btn_ConfirmarPagoParcial);
            this.Imagen_PagoParcial.Controls.Add(this.lblTipoVehiculoP);
            this.Imagen_PagoParcial.Controls.Add(this.lblPermanenciaP);
            this.Imagen_PagoParcial.Controls.Add(this.lblFechaEntradaP);
            this.Imagen_PagoParcial.Controls.Add(this.lblValorP);
            this.Imagen_PagoParcial.Controls.Add(this.panel1);
            this.Imagen_PagoParcial.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Imagen_PagoParcial.Location = new System.Drawing.Point(0, 0);
            this.Imagen_PagoParcial.Name = "Imagen_PagoParcial";
            this.Imagen_PagoParcial.Size = new System.Drawing.Size(1270, 852);
            this.Imagen_PagoParcial.TabIndex = 5072;
            // 
            // btn_ConfirmarPagoFE
            // 
            this.btn_ConfirmarPagoFE.AutoSize = true;
            this.btn_ConfirmarPagoFE.BackColor = System.Drawing.Color.Transparent;
            this.btn_ConfirmarPagoFE.FlatAppearance.BorderSize = 0;
            this.btn_ConfirmarPagoFE.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_ConfirmarPagoFE.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_ConfirmarPagoFE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ConfirmarPagoFE.Location = new System.Drawing.Point(963, 722);
            this.btn_ConfirmarPagoFE.LockPush = true;
            this.btn_ConfirmarPagoFE.Name = "btn_ConfirmarPagoFE";
            this.btn_ConfirmarPagoFE.Size = new System.Drawing.Size(149, 95);
            this.btn_ConfirmarPagoFE.TabIndex = 5077;
            this.btn_ConfirmarPagoFE.Text = "ConfirmarPagoFE";
            this.btn_ConfirmarPagoFE.UseVisualStyleBackColor = false;
            this.btn_ConfirmarPagoFE.Click += new System.EventHandler(this.btn_ConfirmarPagoFE_Click);
            // 
            // btn_AnularPagoParcial
            // 
            this.btn_AnularPagoParcial.AutoSize = true;
            this.btn_AnularPagoParcial.BackColor = System.Drawing.Color.Transparent;
            this.btn_AnularPagoParcial.FlatAppearance.BorderSize = 0;
            this.btn_AnularPagoParcial.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_AnularPagoParcial.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_AnularPagoParcial.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_AnularPagoParcial.Location = new System.Drawing.Point(462, 722);
            this.btn_AnularPagoParcial.LockPush = true;
            this.btn_AnularPagoParcial.Name = "btn_AnularPagoParcial";
            this.btn_AnularPagoParcial.Size = new System.Drawing.Size(88, 95);
            this.btn_AnularPagoParcial.TabIndex = 5076;
            this.btn_AnularPagoParcial.Text = "ANULAR";
            this.btn_AnularPagoParcial.UseVisualStyleBackColor = false;
            this.btn_AnularPagoParcial.Click += new System.EventHandler(this.btn_AnularPagoParcial_Click);
            // 
            // btn_ConfirmarPagoParcial
            // 
            this.btn_ConfirmarPagoParcial.AutoSize = true;
            this.btn_ConfirmarPagoParcial.BackColor = System.Drawing.Color.Transparent;
            this.btn_ConfirmarPagoParcial.FlatAppearance.BorderSize = 0;
            this.btn_ConfirmarPagoParcial.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_ConfirmarPagoParcial.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_ConfirmarPagoParcial.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ConfirmarPagoParcial.Location = new System.Drawing.Point(689, 722);
            this.btn_ConfirmarPagoParcial.LockPush = true;
            this.btn_ConfirmarPagoParcial.Name = "btn_ConfirmarPagoParcial";
            this.btn_ConfirmarPagoParcial.Size = new System.Drawing.Size(149, 95);
            this.btn_ConfirmarPagoParcial.TabIndex = 5075;
            this.btn_ConfirmarPagoParcial.Text = "ConfirmarPagoParcial";
            this.btn_ConfirmarPagoParcial.UseVisualStyleBackColor = false;
            this.btn_ConfirmarPagoParcial.Click += new System.EventHandler(this.btn_ConfirmarPagoParcial_Click);
            // 
            // lblTipoVehiculoP
            // 
            this.lblTipoVehiculoP.BackColor = System.Drawing.Color.Transparent;
            this.lblTipoVehiculoP.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoVehiculoP.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblTipoVehiculoP.Location = new System.Drawing.Point(1060, 648);
            this.lblTipoVehiculoP.Name = "lblTipoVehiculoP";
            this.lblTipoVehiculoP.Size = new System.Drawing.Size(151, 38);
            this.lblTipoVehiculoP.TabIndex = 5074;
            this.lblTipoVehiculoP.Text = "CARRO";
            this.lblTipoVehiculoP.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPermanenciaP
            // 
            this.lblPermanenciaP.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPermanenciaP.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblPermanenciaP.Location = new System.Drawing.Point(660, 653);
            this.lblPermanenciaP.Name = "lblPermanenciaP";
            this.lblPermanenciaP.Size = new System.Drawing.Size(186, 32);
            this.lblPermanenciaP.TabIndex = 5073;
            this.lblPermanenciaP.Text = "3 horas 59 min 59 seg";
            this.lblPermanenciaP.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblFechaEntradaP
            // 
            this.lblFechaEntradaP.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaEntradaP.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblFechaEntradaP.Location = new System.Drawing.Point(250, 653);
            this.lblFechaEntradaP.Name = "lblFechaEntradaP";
            this.lblFechaEntradaP.Size = new System.Drawing.Size(140, 35);
            this.lblFechaEntradaP.TabIndex = 5072;
            this.lblFechaEntradaP.Text = "2019/08/24 20:50:00";
            this.lblFechaEntradaP.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblValorP
            // 
            this.lblValorP.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblValorP.BackColor = System.Drawing.Color.Transparent;
            this.lblValorP.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValorP.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblValorP.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblValorP.Location = new System.Drawing.Point(98, 741);
            this.lblValorP.Name = "lblValorP";
            this.lblValorP.Size = new System.Drawing.Size(152, 60);
            this.lblValorP.TabIndex = 5071;
            this.lblValorP.Text = "$27.000";
            this.lblValorP.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Location = new System.Drawing.Point(5, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1258, 417);
            this.panel1.TabIndex = 5070;
            // 
            // pPublicidadPagoParcial
            // 
            this.pPublicidadPagoParcial.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pPublicidadPagoParcial.Location = new System.Drawing.Point(5, 0);
            this.pPublicidadPagoParcial.Name = "pPublicidadPagoParcial";
            this.pPublicidadPagoParcial.Size = new System.Drawing.Size(1258, 417);
            this.pPublicidadPagoParcial.TabIndex = 5071;
            // 
            // tabNitCliente
            // 
            this.tabNitCliente.Controls.Add(this.Imagen_DigiteNitCliente);
            this.tabNitCliente.Location = new System.Drawing.Point(4, 22);
            this.tabNitCliente.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabNitCliente.Name = "tabNitCliente";
            this.tabNitCliente.Size = new System.Drawing.Size(1270, 852);
            this.tabNitCliente.TabIndex = 77;
            this.tabNitCliente.Text = "NitCliente";
            this.tabNitCliente.UseVisualStyleBackColor = true;
            // 
            // Imagen_DigiteNitCliente
            // 
            this.Imagen_DigiteNitCliente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Imagen_DigiteNitCliente.Controls.Add(this.panel2);
            this.Imagen_DigiteNitCliente.Controls.Add(this.lblNitCliente);
            this.Imagen_DigiteNitCliente.Controls.Add(this.Panel_TecladoNitCliente);
            this.Imagen_DigiteNitCliente.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Imagen_DigiteNitCliente.Location = new System.Drawing.Point(0, 0);
            this.Imagen_DigiteNitCliente.Name = "Imagen_DigiteNitCliente";
            this.Imagen_DigiteNitCliente.Size = new System.Drawing.Size(1270, 852);
            this.Imagen_DigiteNitCliente.TabIndex = 5021;
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(186, 457);
            this.panel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(952, 366);
            this.panel2.TabIndex = 195;
            // 
            // lblNitCliente
            // 
            this.lblNitCliente.BackColor = System.Drawing.Color.Transparent;
            this.lblNitCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 45F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNitCliente.ForeColor = System.Drawing.Color.Black;
            this.lblNitCliente.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.lblNitCliente.Location = new System.Drawing.Point(218, 146);
            this.lblNitCliente.Name = "lblNitCliente";
            this.lblNitCliente.Size = new System.Drawing.Size(246, 82);
            this.lblNitCliente.TabIndex = 194;
            this.lblNitCliente.Text = "1234";
            this.lblNitCliente.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Panel_TecladoNitCliente
            // 
            this.Panel_TecladoNitCliente.Controls.Add(this.btn_NitCliente0);
            this.Panel_TecladoNitCliente.Controls.Add(this.btn_NitCliente9);
            this.Panel_TecladoNitCliente.Controls.Add(this.btn_NitCliente8);
            this.Panel_TecladoNitCliente.Controls.Add(this.btn_NitCliente7);
            this.Panel_TecladoNitCliente.Controls.Add(this.btn_NitCliente6);
            this.Panel_TecladoNitCliente.Controls.Add(this.btn_NitCliente5);
            this.Panel_TecladoNitCliente.Controls.Add(this.btn_NitCliente4);
            this.Panel_TecladoNitCliente.Controls.Add(this.btn_NitCliente3);
            this.Panel_TecladoNitCliente.Controls.Add(this.btn_NitCliente2);
            this.Panel_TecladoNitCliente.Controls.Add(this.btn_NitCliente1);
            this.Panel_TecladoNitCliente.Controls.Add(this.btn_BorrarNitCliente);
            this.Panel_TecladoNitCliente.Controls.Add(this.btn_OkNitCliente);
            this.Panel_TecladoNitCliente.Location = new System.Drawing.Point(866, 49);
            this.Panel_TecladoNitCliente.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Panel_TecladoNitCliente.Name = "Panel_TecladoNitCliente";
            this.Panel_TecladoNitCliente.Size = new System.Drawing.Size(378, 392);
            this.Panel_TecladoNitCliente.TabIndex = 0;
            // 
            // btn_NitCliente0
            // 
            this.btn_NitCliente0.AutoSize = true;
            this.btn_NitCliente0.BackColor = System.Drawing.Color.Transparent;
            this.btn_NitCliente0.FlatAppearance.BorderSize = 0;
            this.btn_NitCliente0.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_NitCliente0.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_NitCliente0.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_NitCliente0.Location = new System.Drawing.Point(138, 303);
            this.btn_NitCliente0.LockPush = true;
            this.btn_NitCliente0.Name = "btn_NitCliente0";
            this.btn_NitCliente0.Size = new System.Drawing.Size(70, 70);
            this.btn_NitCliente0.TabIndex = 5081;
            this.btn_NitCliente0.Text = "0";
            this.btn_NitCliente0.UseVisualStyleBackColor = false;
            this.btn_NitCliente0.Click += new System.EventHandler(this.btn_NitCliente0_Click);
            // 
            // btn_NitCliente9
            // 
            this.btn_NitCliente9.AutoSize = true;
            this.btn_NitCliente9.BackColor = System.Drawing.Color.Transparent;
            this.btn_NitCliente9.FlatAppearance.BorderSize = 0;
            this.btn_NitCliente9.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_NitCliente9.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_NitCliente9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_NitCliente9.Location = new System.Drawing.Point(246, 203);
            this.btn_NitCliente9.LockPush = true;
            this.btn_NitCliente9.Name = "btn_NitCliente9";
            this.btn_NitCliente9.Size = new System.Drawing.Size(70, 70);
            this.btn_NitCliente9.TabIndex = 5080;
            this.btn_NitCliente9.Text = "9";
            this.btn_NitCliente9.UseVisualStyleBackColor = false;
            this.btn_NitCliente9.Click += new System.EventHandler(this.btn_NitCliente9_Click);
            // 
            // btn_NitCliente8
            // 
            this.btn_NitCliente8.AutoSize = true;
            this.btn_NitCliente8.BackColor = System.Drawing.Color.Transparent;
            this.btn_NitCliente8.FlatAppearance.BorderSize = 0;
            this.btn_NitCliente8.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_NitCliente8.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_NitCliente8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_NitCliente8.Location = new System.Drawing.Point(138, 203);
            this.btn_NitCliente8.LockPush = true;
            this.btn_NitCliente8.Name = "btn_NitCliente8";
            this.btn_NitCliente8.Size = new System.Drawing.Size(70, 70);
            this.btn_NitCliente8.TabIndex = 5079;
            this.btn_NitCliente8.Text = "8";
            this.btn_NitCliente8.UseVisualStyleBackColor = false;
            this.btn_NitCliente8.Click += new System.EventHandler(this.btn_NitCliente8_Click);
            // 
            // btn_NitCliente7
            // 
            this.btn_NitCliente7.AutoSize = true;
            this.btn_NitCliente7.BackColor = System.Drawing.Color.Transparent;
            this.btn_NitCliente7.FlatAppearance.BorderSize = 0;
            this.btn_NitCliente7.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_NitCliente7.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_NitCliente7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_NitCliente7.Location = new System.Drawing.Point(39, 203);
            this.btn_NitCliente7.LockPush = true;
            this.btn_NitCliente7.Name = "btn_NitCliente7";
            this.btn_NitCliente7.Size = new System.Drawing.Size(70, 70);
            this.btn_NitCliente7.TabIndex = 5078;
            this.btn_NitCliente7.Text = "7";
            this.btn_NitCliente7.UseVisualStyleBackColor = false;
            this.btn_NitCliente7.Click += new System.EventHandler(this.btn_NitCliente7_Click);
            // 
            // btn_NitCliente6
            // 
            this.btn_NitCliente6.AutoSize = true;
            this.btn_NitCliente6.BackColor = System.Drawing.Color.Transparent;
            this.btn_NitCliente6.FlatAppearance.BorderSize = 0;
            this.btn_NitCliente6.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_NitCliente6.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_NitCliente6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_NitCliente6.Location = new System.Drawing.Point(246, 109);
            this.btn_NitCliente6.LockPush = true;
            this.btn_NitCliente6.Name = "btn_NitCliente6";
            this.btn_NitCliente6.Size = new System.Drawing.Size(70, 70);
            this.btn_NitCliente6.TabIndex = 5077;
            this.btn_NitCliente6.Text = "6";
            this.btn_NitCliente6.UseVisualStyleBackColor = false;
            this.btn_NitCliente6.Click += new System.EventHandler(this.btn_NitCliente6_Click);
            // 
            // btn_NitCliente5
            // 
            this.btn_NitCliente5.AutoSize = true;
            this.btn_NitCliente5.BackColor = System.Drawing.Color.Transparent;
            this.btn_NitCliente5.FlatAppearance.BorderSize = 0;
            this.btn_NitCliente5.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_NitCliente5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_NitCliente5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_NitCliente5.Location = new System.Drawing.Point(138, 109);
            this.btn_NitCliente5.LockPush = true;
            this.btn_NitCliente5.Name = "btn_NitCliente5";
            this.btn_NitCliente5.Size = new System.Drawing.Size(70, 70);
            this.btn_NitCliente5.TabIndex = 5076;
            this.btn_NitCliente5.Text = "5";
            this.btn_NitCliente5.UseVisualStyleBackColor = false;
            this.btn_NitCliente5.Click += new System.EventHandler(this.btn_NitCliente5_Click);
            // 
            // btn_NitCliente4
            // 
            this.btn_NitCliente4.AutoSize = true;
            this.btn_NitCliente4.BackColor = System.Drawing.Color.Transparent;
            this.btn_NitCliente4.FlatAppearance.BorderSize = 0;
            this.btn_NitCliente4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_NitCliente4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_NitCliente4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_NitCliente4.Location = new System.Drawing.Point(39, 109);
            this.btn_NitCliente4.LockPush = true;
            this.btn_NitCliente4.Name = "btn_NitCliente4";
            this.btn_NitCliente4.Size = new System.Drawing.Size(70, 70);
            this.btn_NitCliente4.TabIndex = 5075;
            this.btn_NitCliente4.Text = "4";
            this.btn_NitCliente4.UseVisualStyleBackColor = false;
            this.btn_NitCliente4.Click += new System.EventHandler(this.btn_NitCliente4_Click);
            // 
            // btn_NitCliente3
            // 
            this.btn_NitCliente3.AutoSize = true;
            this.btn_NitCliente3.BackColor = System.Drawing.Color.Transparent;
            this.btn_NitCliente3.FlatAppearance.BorderSize = 0;
            this.btn_NitCliente3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_NitCliente3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_NitCliente3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_NitCliente3.Location = new System.Drawing.Point(246, 20);
            this.btn_NitCliente3.LockPush = true;
            this.btn_NitCliente3.Name = "btn_NitCliente3";
            this.btn_NitCliente3.Size = new System.Drawing.Size(70, 70);
            this.btn_NitCliente3.TabIndex = 5074;
            this.btn_NitCliente3.Text = "3";
            this.btn_NitCliente3.UseVisualStyleBackColor = false;
            this.btn_NitCliente3.Click += new System.EventHandler(this.btn_NitCliente3_Click);
            // 
            // btn_NitCliente2
            // 
            this.btn_NitCliente2.AutoSize = true;
            this.btn_NitCliente2.BackColor = System.Drawing.Color.Transparent;
            this.btn_NitCliente2.FlatAppearance.BorderSize = 0;
            this.btn_NitCliente2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_NitCliente2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_NitCliente2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_NitCliente2.Location = new System.Drawing.Point(138, 20);
            this.btn_NitCliente2.LockPush = true;
            this.btn_NitCliente2.Name = "btn_NitCliente2";
            this.btn_NitCliente2.Size = new System.Drawing.Size(70, 70);
            this.btn_NitCliente2.TabIndex = 5073;
            this.btn_NitCliente2.Text = "2";
            this.btn_NitCliente2.UseVisualStyleBackColor = false;
            this.btn_NitCliente2.Click += new System.EventHandler(this.btn_NitCliente2_Click);
            // 
            // btn_NitCliente1
            // 
            this.btn_NitCliente1.AutoSize = true;
            this.btn_NitCliente1.BackColor = System.Drawing.Color.Transparent;
            this.btn_NitCliente1.FlatAppearance.BorderSize = 0;
            this.btn_NitCliente1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_NitCliente1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_NitCliente1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_NitCliente1.Location = new System.Drawing.Point(39, 20);
            this.btn_NitCliente1.LockPush = true;
            this.btn_NitCliente1.Name = "btn_NitCliente1";
            this.btn_NitCliente1.Size = new System.Drawing.Size(70, 70);
            this.btn_NitCliente1.TabIndex = 5072;
            this.btn_NitCliente1.Text = "1";
            this.btn_NitCliente1.UseVisualStyleBackColor = false;
            this.btn_NitCliente1.Click += new System.EventHandler(this.btn_NitCliente1_Click);
            // 
            // btn_BorrarNitCliente
            // 
            this.btn_BorrarNitCliente.AutoSize = true;
            this.btn_BorrarNitCliente.BackColor = System.Drawing.Color.Transparent;
            this.btn_BorrarNitCliente.FlatAppearance.BorderSize = 0;
            this.btn_BorrarNitCliente.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_BorrarNitCliente.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_BorrarNitCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_BorrarNitCliente.Location = new System.Drawing.Point(39, 303);
            this.btn_BorrarNitCliente.LockPush = true;
            this.btn_BorrarNitCliente.Name = "btn_BorrarNitCliente";
            this.btn_BorrarNitCliente.Size = new System.Drawing.Size(66, 72);
            this.btn_BorrarNitCliente.TabIndex = 5071;
            this.btn_BorrarNitCliente.Text = "Borrar";
            this.btn_BorrarNitCliente.UseVisualStyleBackColor = false;
            this.btn_BorrarNitCliente.Click += new System.EventHandler(this.btn_BorrarNitCliente_Click);
            // 
            // btn_OkNitCliente
            // 
            this.btn_OkNitCliente.AutoSize = true;
            this.btn_OkNitCliente.BackColor = System.Drawing.Color.Transparent;
            this.btn_OkNitCliente.FlatAppearance.BorderSize = 0;
            this.btn_OkNitCliente.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_OkNitCliente.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_OkNitCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_OkNitCliente.Location = new System.Drawing.Point(246, 303);
            this.btn_OkNitCliente.LockPush = true;
            this.btn_OkNitCliente.Name = "btn_OkNitCliente";
            this.btn_OkNitCliente.Size = new System.Drawing.Size(74, 72);
            this.btn_OkNitCliente.TabIndex = 5070;
            this.btn_OkNitCliente.Text = "Confirmar";
            this.btn_OkNitCliente.UseVisualStyleBackColor = false;
            this.btn_OkNitCliente.Click += new System.EventHandler(this.btn_OkNitCliente_Click);
            // 
            // tabAtasco
            // 
            this.tabAtasco.Controls.Add(this.Imagen_Atasco);
            this.tabAtasco.Location = new System.Drawing.Point(4, 22);
            this.tabAtasco.Name = "tabAtasco";
            this.tabAtasco.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tabAtasco.Size = new System.Drawing.Size(1270, 852);
            this.tabAtasco.TabIndex = 67;
            this.tabAtasco.Text = "Atasco";
            this.tabAtasco.UseVisualStyleBackColor = true;
            // 
            // Imagen_Atasco
            // 
            this.Imagen_Atasco.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Imagen_Atasco.Controls.Add(this.capaAtasco);
            this.Imagen_Atasco.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Imagen_Atasco.Location = new System.Drawing.Point(3, 3);
            this.Imagen_Atasco.Name = "Imagen_Atasco";
            this.Imagen_Atasco.Size = new System.Drawing.Size(1264, 846);
            this.Imagen_Atasco.TabIndex = 5022;
            // 
            // capaAtasco
            // 
            this.capaAtasco.Location = new System.Drawing.Point(525, 928);
            this.capaAtasco.Name = "capaAtasco";
            this.capaAtasco.Size = new System.Drawing.Size(145, 79);
            this.capaAtasco.TabIndex = 5022;
            this.capaAtasco.Text = "CAPA";
            this.capaAtasco.Click += new System.EventHandler(this.capaAtasco_Click);
            // 
            // tabDetallePagoMensual
            // 
            this.tabDetallePagoMensual.Controls.Add(this.Imagen_DetallePagoMensual);
            this.tabDetallePagoMensual.Location = new System.Drawing.Point(4, 22);
            this.tabDetallePagoMensual.Name = "tabDetallePagoMensual";
            this.tabDetallePagoMensual.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tabDetallePagoMensual.Size = new System.Drawing.Size(1270, 852);
            this.tabDetallePagoMensual.TabIndex = 66;
            this.tabDetallePagoMensual.Text = "DetallePagoMensual";
            this.tabDetallePagoMensual.UseVisualStyleBackColor = true;
            // 
            // Imagen_DetallePagoMensual
            // 
            this.Imagen_DetallePagoMensual.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Imagen_DetallePagoMensual.Controls.Add(this.pPublicidadPagoAuto);
            this.Imagen_DetallePagoMensual.Controls.Add(this.lblValorCambioAuto);
            this.Imagen_DetallePagoMensual.Controls.Add(this.lblValorRecibidoAuto);
            this.Imagen_DetallePagoMensual.Controls.Add(this.lblNombreAuto);
            this.Imagen_DetallePagoMensual.Controls.Add(this.lblDocumentoAuto);
            this.Imagen_DetallePagoMensual.Controls.Add(this.lblValorPagarAuto);
            this.Imagen_DetallePagoMensual.Controls.Add(this.lblFechaFinAuto);
            this.Imagen_DetallePagoMensual.Controls.Add(this.btn_CancelarPagoAuto);
            this.Imagen_DetallePagoMensual.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Imagen_DetallePagoMensual.Location = new System.Drawing.Point(3, 3);
            this.Imagen_DetallePagoMensual.Name = "Imagen_DetallePagoMensual";
            this.Imagen_DetallePagoMensual.Size = new System.Drawing.Size(1264, 846);
            this.Imagen_DetallePagoMensual.TabIndex = 5023;
            // 
            // pPublicidadPagoAuto
            // 
            this.pPublicidadPagoAuto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pPublicidadPagoAuto.Location = new System.Drawing.Point(3, 0);
            this.pPublicidadPagoAuto.Name = "pPublicidadPagoAuto";
            this.pPublicidadPagoAuto.Size = new System.Drawing.Size(1258, 417);
            this.pPublicidadPagoAuto.TabIndex = 5025;
            this.pPublicidadPagoAuto.TabStop = false;
            // 
            // lblValorCambioAuto
            // 
            this.lblValorCambioAuto.BackColor = System.Drawing.Color.Transparent;
            this.lblValorCambioAuto.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValorCambioAuto.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblValorCambioAuto.Location = new System.Drawing.Point(719, 796);
            this.lblValorCambioAuto.Name = "lblValorCambioAuto";
            this.lblValorCambioAuto.Size = new System.Drawing.Size(182, 52);
            this.lblValorCambioAuto.TabIndex = 1142;
            this.lblValorCambioAuto.Text = "$27.000";
            this.lblValorCambioAuto.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblValorRecibidoAuto
            // 
            this.lblValorRecibidoAuto.BackColor = System.Drawing.Color.Transparent;
            this.lblValorRecibidoAuto.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValorRecibidoAuto.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblValorRecibidoAuto.Location = new System.Drawing.Point(413, 791);
            this.lblValorRecibidoAuto.Name = "lblValorRecibidoAuto";
            this.lblValorRecibidoAuto.Size = new System.Drawing.Size(180, 63);
            this.lblValorRecibidoAuto.TabIndex = 1141;
            this.lblValorRecibidoAuto.Text = "$27.000";
            this.lblValorRecibidoAuto.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblNombreAuto
            // 
            this.lblNombreAuto.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreAuto.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblNombreAuto.Location = new System.Drawing.Point(457, 542);
            this.lblNombreAuto.Name = "lblNombreAuto";
            this.lblNombreAuto.Size = new System.Drawing.Size(640, 35);
            this.lblNombreAuto.TabIndex = 1129;
            this.lblNombreAuto.Text = "JOHN HELLI HILLON DE LAS CASAS";
            this.lblNombreAuto.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDocumentoAuto
            // 
            this.lblDocumentoAuto.BackColor = System.Drawing.Color.Transparent;
            this.lblDocumentoAuto.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDocumentoAuto.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblDocumentoAuto.Location = new System.Drawing.Point(364, 654);
            this.lblDocumentoAuto.Name = "lblDocumentoAuto";
            this.lblDocumentoAuto.Size = new System.Drawing.Size(247, 38);
            this.lblDocumentoAuto.TabIndex = 1139;
            this.lblDocumentoAuto.Text = "1030555789";
            this.lblDocumentoAuto.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblValorPagarAuto
            // 
            this.lblValorPagarAuto.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblValorPagarAuto.BackColor = System.Drawing.Color.Transparent;
            this.lblValorPagarAuto.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValorPagarAuto.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblValorPagarAuto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblValorPagarAuto.Location = new System.Drawing.Point(130, 717);
            this.lblValorPagarAuto.Name = "lblValorPagarAuto";
            this.lblValorPagarAuto.Size = new System.Drawing.Size(152, 60);
            this.lblValorPagarAuto.TabIndex = 1131;
            this.lblValorPagarAuto.Text = "$27.000";
            this.lblValorPagarAuto.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblFechaFinAuto
            // 
            this.lblFechaFinAuto.BackColor = System.Drawing.Color.Transparent;
            this.lblFechaFinAuto.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaFinAuto.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblFechaFinAuto.Location = new System.Drawing.Point(899, 657);
            this.lblFechaFinAuto.Name = "lblFechaFinAuto";
            this.lblFechaFinAuto.Size = new System.Drawing.Size(215, 30);
            this.lblFechaFinAuto.TabIndex = 1136;
            this.lblFechaFinAuto.Text = "2020/10/30";
            this.lblFechaFinAuto.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_CancelarPagoAuto
            // 
            this.btn_CancelarPagoAuto.AutoSize = true;
            this.btn_CancelarPagoAuto.BackColor = System.Drawing.Color.Transparent;
            this.btn_CancelarPagoAuto.FlatAppearance.BorderSize = 0;
            this.btn_CancelarPagoAuto.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_CancelarPagoAuto.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_CancelarPagoAuto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_CancelarPagoAuto.Location = new System.Drawing.Point(989, 758);
            this.btn_CancelarPagoAuto.LockPush = true;
            this.btn_CancelarPagoAuto.Name = "btn_CancelarPagoAuto";
            this.btn_CancelarPagoAuto.Size = new System.Drawing.Size(176, 66);
            this.btn_CancelarPagoAuto.TabIndex = 1122;
            this.btn_CancelarPagoAuto.Text = "Cancelar";
            this.btn_CancelarPagoAuto.UseVisualStyleBackColor = false;
            this.btn_CancelarPagoAuto.Click += new System.EventHandler(this.btn_CancelarPagoAuto_Click);
            // 
            // tabTransaccionCancelada
            // 
            this.tabTransaccionCancelada.Controls.Add(this.Imagen_TransaccionCancelada);
            this.tabTransaccionCancelada.Location = new System.Drawing.Point(4, 22);
            this.tabTransaccionCancelada.Name = "tabTransaccionCancelada";
            this.tabTransaccionCancelada.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tabTransaccionCancelada.Size = new System.Drawing.Size(1270, 852);
            this.tabTransaccionCancelada.TabIndex = 51;
            this.tabTransaccionCancelada.Text = "TransaccionCancelada";
            this.tabTransaccionCancelada.UseVisualStyleBackColor = true;
            // 
            // Imagen_TransaccionCancelada
            // 
            this.Imagen_TransaccionCancelada.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Imagen_TransaccionCancelada.Controls.Add(this.pPublicidadCancelada);
            this.Imagen_TransaccionCancelada.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Imagen_TransaccionCancelada.Location = new System.Drawing.Point(3, 3);
            this.Imagen_TransaccionCancelada.Name = "Imagen_TransaccionCancelada";
            this.Imagen_TransaccionCancelada.Size = new System.Drawing.Size(1264, 846);
            this.Imagen_TransaccionCancelada.TabIndex = 5021;
            // 
            // pPublicidadCancelada
            // 
            this.pPublicidadCancelada.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pPublicidadCancelada.Location = new System.Drawing.Point(5, 0);
            this.pPublicidadCancelada.Name = "pPublicidadCancelada";
            this.pPublicidadCancelada.Size = new System.Drawing.Size(1258, 417);
            this.pPublicidadCancelada.TabIndex = 0;
            // 
            // tabTarjetaNoGeneraPago
            // 
            this.tabTarjetaNoGeneraPago.Controls.Add(this.Imagen_NoGeneraPago);
            this.tabTarjetaNoGeneraPago.Location = new System.Drawing.Point(4, 22);
            this.tabTarjetaNoGeneraPago.Name = "tabTarjetaNoGeneraPago";
            this.tabTarjetaNoGeneraPago.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tabTarjetaNoGeneraPago.Size = new System.Drawing.Size(1270, 852);
            this.tabTarjetaNoGeneraPago.TabIndex = 60;
            this.tabTarjetaNoGeneraPago.Text = "TarjetaNoGeneraPago";
            this.tabTarjetaNoGeneraPago.UseVisualStyleBackColor = true;
            // 
            // Imagen_NoGeneraPago
            // 
            this.Imagen_NoGeneraPago.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Imagen_NoGeneraPago.Controls.Add(this.pPublicidadNoPago);
            this.Imagen_NoGeneraPago.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Imagen_NoGeneraPago.Location = new System.Drawing.Point(3, 3);
            this.Imagen_NoGeneraPago.Name = "Imagen_NoGeneraPago";
            this.Imagen_NoGeneraPago.Size = new System.Drawing.Size(1264, 846);
            this.Imagen_NoGeneraPago.TabIndex = 5022;
            // 
            // pPublicidadNoPago
            // 
            this.pPublicidadNoPago.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pPublicidadNoPago.Location = new System.Drawing.Point(5, 0);
            this.pPublicidadNoPago.Name = "pPublicidadNoPago";
            this.pPublicidadNoPago.Size = new System.Drawing.Size(1258, 417);
            this.pPublicidadNoPago.TabIndex = 0;
            // 
            // tabTarjetaSinEntrada
            // 
            this.tabTarjetaSinEntrada.Controls.Add(this.Imagen_TarjetaSinEntrada);
            this.tabTarjetaSinEntrada.Location = new System.Drawing.Point(4, 22);
            this.tabTarjetaSinEntrada.Name = "tabTarjetaSinEntrada";
            this.tabTarjetaSinEntrada.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tabTarjetaSinEntrada.Size = new System.Drawing.Size(1270, 852);
            this.tabTarjetaSinEntrada.TabIndex = 61;
            this.tabTarjetaSinEntrada.Text = "TarjetaSinEntrada";
            this.tabTarjetaSinEntrada.UseVisualStyleBackColor = true;
            // 
            // Imagen_TarjetaSinEntrada
            // 
            this.Imagen_TarjetaSinEntrada.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Imagen_TarjetaSinEntrada.Controls.Add(this.pPublicidadSinEntrada);
            this.Imagen_TarjetaSinEntrada.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Imagen_TarjetaSinEntrada.Location = new System.Drawing.Point(3, 3);
            this.Imagen_TarjetaSinEntrada.Name = "Imagen_TarjetaSinEntrada";
            this.Imagen_TarjetaSinEntrada.Size = new System.Drawing.Size(1264, 846);
            this.Imagen_TarjetaSinEntrada.TabIndex = 5023;
            // 
            // pPublicidadSinEntrada
            // 
            this.pPublicidadSinEntrada.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pPublicidadSinEntrada.Location = new System.Drawing.Point(5, 0);
            this.pPublicidadSinEntrada.Name = "pPublicidadSinEntrada";
            this.pPublicidadSinEntrada.Size = new System.Drawing.Size(1258, 417);
            this.pPublicidadSinEntrada.TabIndex = 0;
            // 
            // tabTransaccionCanceladaPago
            // 
            this.tabTransaccionCanceladaPago.Controls.Add(this.Imagen_TransaccionCanceladaPago);
            this.tabTransaccionCanceladaPago.Location = new System.Drawing.Point(4, 22);
            this.tabTransaccionCanceladaPago.Name = "tabTransaccionCanceladaPago";
            this.tabTransaccionCanceladaPago.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tabTransaccionCanceladaPago.Size = new System.Drawing.Size(1270, 852);
            this.tabTransaccionCanceladaPago.TabIndex = 59;
            this.tabTransaccionCanceladaPago.Text = "TransaccionCanceladaPago";
            this.tabTransaccionCanceladaPago.UseVisualStyleBackColor = true;
            // 
            // Imagen_TransaccionCanceladaPago
            // 
            this.Imagen_TransaccionCanceladaPago.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Imagen_TransaccionCanceladaPago.Controls.Add(this.pPublicidadCanceladaPago);
            this.Imagen_TransaccionCanceladaPago.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Imagen_TransaccionCanceladaPago.Location = new System.Drawing.Point(3, 3);
            this.Imagen_TransaccionCanceladaPago.Name = "Imagen_TransaccionCanceladaPago";
            this.Imagen_TransaccionCanceladaPago.Size = new System.Drawing.Size(1264, 846);
            this.Imagen_TransaccionCanceladaPago.TabIndex = 5022;
            // 
            // pPublicidadCanceladaPago
            // 
            this.pPublicidadCanceladaPago.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pPublicidadCanceladaPago.Location = new System.Drawing.Point(5, 0);
            this.pPublicidadCanceladaPago.Name = "pPublicidadCanceladaPago";
            this.pPublicidadCanceladaPago.Size = new System.Drawing.Size(1258, 417);
            this.pPublicidadCanceladaPago.TabIndex = 0;
            // 
            // tabPagoCelular
            // 
            this.tabPagoCelular.Controls.Add(this.Imagen_PagoCelular);
            this.tabPagoCelular.Location = new System.Drawing.Point(4, 22);
            this.tabPagoCelular.Name = "tabPagoCelular";
            this.tabPagoCelular.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tabPagoCelular.Size = new System.Drawing.Size(1270, 852);
            this.tabPagoCelular.TabIndex = 53;
            this.tabPagoCelular.Text = "PagoCelular";
            this.tabPagoCelular.UseVisualStyleBackColor = true;
            // 
            // Imagen_PagoCelular
            // 
            this.Imagen_PagoCelular.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Imagen_PagoCelular.Controls.Add(this.btn_ContinuarCelular);
            this.Imagen_PagoCelular.Controls.Add(this.lblCodigoPago);
            this.Imagen_PagoCelular.Controls.Add(this.lblCodigoParqueo);
            this.Imagen_PagoCelular.Controls.Add(this.lblValorPagarCelular);
            this.Imagen_PagoCelular.Controls.Add(this.btn_VolverMedioCelular);
            this.Imagen_PagoCelular.Controls.Add(this.btn_CancelarCelular);
            this.Imagen_PagoCelular.Controls.Add(this.pCelular);
            this.Imagen_PagoCelular.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Imagen_PagoCelular.Location = new System.Drawing.Point(3, 3);
            this.Imagen_PagoCelular.Name = "Imagen_PagoCelular";
            this.Imagen_PagoCelular.Size = new System.Drawing.Size(1264, 846);
            this.Imagen_PagoCelular.TabIndex = 5023;
            // 
            // btn_ContinuarCelular
            // 
            this.btn_ContinuarCelular.AutoSize = true;
            this.btn_ContinuarCelular.BackColor = System.Drawing.Color.Transparent;
            this.btn_ContinuarCelular.FlatAppearance.BorderSize = 0;
            this.btn_ContinuarCelular.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_ContinuarCelular.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_ContinuarCelular.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ContinuarCelular.Location = new System.Drawing.Point(83, 868);
            this.btn_ContinuarCelular.LockPush = true;
            this.btn_ContinuarCelular.Name = "btn_ContinuarCelular";
            this.btn_ContinuarCelular.Size = new System.Drawing.Size(469, 68);
            this.btn_ContinuarCelular.TabIndex = 1139;
            this.btn_ContinuarCelular.Text = "Continuar";
            this.btn_ContinuarCelular.UseVisualStyleBackColor = false;
            this.btn_ContinuarCelular.Click += new System.EventHandler(this.btn_ContinuarCelular_Click);
            // 
            // lblCodigoPago
            // 
            this.lblCodigoPago.BackColor = System.Drawing.Color.Transparent;
            this.lblCodigoPago.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigoPago.ForeColor = System.Drawing.Color.Navy;
            this.lblCodigoPago.Location = new System.Drawing.Point(107, 764);
            this.lblCodigoPago.Name = "lblCodigoPago";
            this.lblCodigoPago.Size = new System.Drawing.Size(407, 46);
            this.lblCodigoPago.TabIndex = 1138;
            this.lblCodigoPago.Text = "123456";
            this.lblCodigoPago.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblCodigoParqueo
            // 
            this.lblCodigoParqueo.BackColor = System.Drawing.Color.Transparent;
            this.lblCodigoParqueo.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigoParqueo.ForeColor = System.Drawing.Color.Navy;
            this.lblCodigoParqueo.Location = new System.Drawing.Point(107, 630);
            this.lblCodigoParqueo.Name = "lblCodigoParqueo";
            this.lblCodigoParqueo.Size = new System.Drawing.Size(407, 46);
            this.lblCodigoParqueo.TabIndex = 1137;
            this.lblCodigoParqueo.Text = "247";
            this.lblCodigoParqueo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblValorPagarCelular
            // 
            this.lblValorPagarCelular.BackColor = System.Drawing.Color.Transparent;
            this.lblValorPagarCelular.Font = new System.Drawing.Font("Microsoft Sans Serif", 65F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValorPagarCelular.ForeColor = System.Drawing.Color.Navy;
            this.lblValorPagarCelular.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblValorPagarCelular.Location = new System.Drawing.Point(98, 386);
            this.lblValorPagarCelular.Name = "lblValorPagarCelular";
            this.lblValorPagarCelular.Size = new System.Drawing.Size(453, 98);
            this.lblValorPagarCelular.TabIndex = 1136;
            this.lblValorPagarCelular.Text = "$27.000";
            this.lblValorPagarCelular.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btn_VolverMedioCelular
            // 
            this.btn_VolverMedioCelular.AutoSize = true;
            this.btn_VolverMedioCelular.BackColor = System.Drawing.Color.Transparent;
            this.btn_VolverMedioCelular.FlatAppearance.BorderSize = 0;
            this.btn_VolverMedioCelular.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_VolverMedioCelular.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_VolverMedioCelular.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_VolverMedioCelular.Location = new System.Drawing.Point(740, 884);
            this.btn_VolverMedioCelular.LockPush = true;
            this.btn_VolverMedioCelular.Name = "btn_VolverMedioCelular";
            this.btn_VolverMedioCelular.Size = new System.Drawing.Size(176, 66);
            this.btn_VolverMedioCelular.TabIndex = 1135;
            this.btn_VolverMedioCelular.Text = "Volver";
            this.btn_VolverMedioCelular.UseVisualStyleBackColor = false;
            this.btn_VolverMedioCelular.Click += new System.EventHandler(this.btn_VolverMedioCelular_Click);
            // 
            // btn_CancelarCelular
            // 
            this.btn_CancelarCelular.AutoSize = true;
            this.btn_CancelarCelular.BackColor = System.Drawing.Color.Transparent;
            this.btn_CancelarCelular.FlatAppearance.BorderSize = 0;
            this.btn_CancelarCelular.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_CancelarCelular.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_CancelarCelular.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_CancelarCelular.Location = new System.Drawing.Point(1044, 881);
            this.btn_CancelarCelular.LockPush = true;
            this.btn_CancelarCelular.Name = "btn_CancelarCelular";
            this.btn_CancelarCelular.Size = new System.Drawing.Size(176, 64);
            this.btn_CancelarCelular.TabIndex = 1122;
            this.btn_CancelarCelular.Text = "Cancelar";
            this.btn_CancelarCelular.UseVisualStyleBackColor = false;
            this.btn_CancelarCelular.Click += new System.EventHandler(this.btn_CancelarCelular_Click);
            // 
            // pCelular
            // 
            this.pCelular.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pCelular.Location = new System.Drawing.Point(0, 0);
            this.pCelular.Name = "pCelular";
            this.pCelular.Size = new System.Drawing.Size(1264, 846);
            this.pCelular.TabIndex = 1140;
            this.pCelular.TabStop = false;
            // 
            // tabPagoEfectivo
            // 
            this.tabPagoEfectivo.Controls.Add(this.Imagen_PagoEfectivo);
            this.tabPagoEfectivo.Location = new System.Drawing.Point(4, 22);
            this.tabPagoEfectivo.Name = "tabPagoEfectivo";
            this.tabPagoEfectivo.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tabPagoEfectivo.Size = new System.Drawing.Size(1270, 852);
            this.tabPagoEfectivo.TabIndex = 54;
            this.tabPagoEfectivo.Text = "PagoEfectivo";
            this.tabPagoEfectivo.UseVisualStyleBackColor = true;
            // 
            // Imagen_PagoEfectivo
            // 
            this.Imagen_PagoEfectivo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Imagen_PagoEfectivo.Controls.Add(this.btn_VolverMedios);
            this.Imagen_PagoEfectivo.Controls.Add(this.pPagoEfectivo);
            this.Imagen_PagoEfectivo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Imagen_PagoEfectivo.Location = new System.Drawing.Point(3, 3);
            this.Imagen_PagoEfectivo.Name = "Imagen_PagoEfectivo";
            this.Imagen_PagoEfectivo.Size = new System.Drawing.Size(1264, 846);
            this.Imagen_PagoEfectivo.TabIndex = 5023;
            // 
            // btn_VolverMedios
            // 
            this.btn_VolverMedios.AutoSize = true;
            this.btn_VolverMedios.BackColor = System.Drawing.Color.Transparent;
            this.btn_VolverMedios.FlatAppearance.BorderSize = 0;
            this.btn_VolverMedios.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_VolverMedios.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_VolverMedios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_VolverMedios.Location = new System.Drawing.Point(734, 874);
            this.btn_VolverMedios.LockPush = true;
            this.btn_VolverMedios.Name = "btn_VolverMedios";
            this.btn_VolverMedios.Size = new System.Drawing.Size(176, 66);
            this.btn_VolverMedios.TabIndex = 1134;
            this.btn_VolverMedios.Text = "Volver";
            this.btn_VolverMedios.UseVisualStyleBackColor = false;
            this.btn_VolverMedios.Click += new System.EventHandler(this.btn_VolverMedios_Click);
            // 
            // pPagoEfectivo
            // 
            this.pPagoEfectivo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pPagoEfectivo.Location = new System.Drawing.Point(0, 0);
            this.pPagoEfectivo.Name = "pPagoEfectivo";
            this.pPagoEfectivo.Size = new System.Drawing.Size(1264, 846);
            this.pPagoEfectivo.TabIndex = 1136;
            this.pPagoEfectivo.TabStop = false;
            // 
            // tabPagoPrepago
            // 
            this.tabPagoPrepago.Controls.Add(this.Imagen_Prepago);
            this.tabPagoPrepago.Location = new System.Drawing.Point(4, 22);
            this.tabPagoPrepago.Name = "tabPagoPrepago";
            this.tabPagoPrepago.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tabPagoPrepago.Size = new System.Drawing.Size(1270, 852);
            this.tabPagoPrepago.TabIndex = 55;
            this.tabPagoPrepago.Text = "PagoPrepago";
            this.tabPagoPrepago.UseVisualStyleBackColor = true;
            // 
            // Imagen_Prepago
            // 
            this.Imagen_Prepago.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Imagen_Prepago.Controls.Add(this.btn_MediosPrepago);
            this.Imagen_Prepago.Controls.Add(this.lblValorPagarPrepago);
            this.Imagen_Prepago.Controls.Add(this.btn_CancelarPrepago);
            this.Imagen_Prepago.Controls.Add(this.pPrepago);
            this.Imagen_Prepago.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Imagen_Prepago.Location = new System.Drawing.Point(3, 3);
            this.Imagen_Prepago.Name = "Imagen_Prepago";
            this.Imagen_Prepago.Size = new System.Drawing.Size(1264, 846);
            this.Imagen_Prepago.TabIndex = 5024;
            // 
            // btn_MediosPrepago
            // 
            this.btn_MediosPrepago.AutoSize = true;
            this.btn_MediosPrepago.BackColor = System.Drawing.Color.Transparent;
            this.btn_MediosPrepago.FlatAppearance.BorderSize = 0;
            this.btn_MediosPrepago.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_MediosPrepago.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_MediosPrepago.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_MediosPrepago.Location = new System.Drawing.Point(739, 880);
            this.btn_MediosPrepago.LockPush = true;
            this.btn_MediosPrepago.Name = "btn_MediosPrepago";
            this.btn_MediosPrepago.Size = new System.Drawing.Size(176, 66);
            this.btn_MediosPrepago.TabIndex = 1134;
            this.btn_MediosPrepago.Text = "Volver";
            this.btn_MediosPrepago.UseVisualStyleBackColor = false;
            this.btn_MediosPrepago.Click += new System.EventHandler(this.btn_MediosPrepago_Click);
            // 
            // lblValorPagarPrepago
            // 
            this.lblValorPagarPrepago.BackColor = System.Drawing.Color.Transparent;
            this.lblValorPagarPrepago.Font = new System.Drawing.Font("Microsoft Sans Serif", 70F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValorPagarPrepago.ForeColor = System.Drawing.Color.Navy;
            this.lblValorPagarPrepago.Location = new System.Drawing.Point(106, 550);
            this.lblValorPagarPrepago.Name = "lblValorPagarPrepago";
            this.lblValorPagarPrepago.Size = new System.Drawing.Size(454, 107);
            this.lblValorPagarPrepago.TabIndex = 1132;
            this.lblValorPagarPrepago.Text = "$27.000";
            // 
            // btn_CancelarPrepago
            // 
            this.btn_CancelarPrepago.AutoSize = true;
            this.btn_CancelarPrepago.BackColor = System.Drawing.Color.Transparent;
            this.btn_CancelarPrepago.FlatAppearance.BorderSize = 0;
            this.btn_CancelarPrepago.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_CancelarPrepago.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_CancelarPrepago.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_CancelarPrepago.Location = new System.Drawing.Point(1041, 877);
            this.btn_CancelarPrepago.LockPush = true;
            this.btn_CancelarPrepago.Name = "btn_CancelarPrepago";
            this.btn_CancelarPrepago.Size = new System.Drawing.Size(176, 66);
            this.btn_CancelarPrepago.TabIndex = 1122;
            this.btn_CancelarPrepago.Text = "Cancelar";
            this.btn_CancelarPrepago.UseVisualStyleBackColor = false;
            this.btn_CancelarPrepago.Click += new System.EventHandler(this.btn_CancelarPrepago_Click);
            // 
            // pPrepago
            // 
            this.pPrepago.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pPrepago.Location = new System.Drawing.Point(0, 0);
            this.pPrepago.Name = "pPrepago";
            this.pPrepago.Size = new System.Drawing.Size(1264, 846);
            this.pPrepago.TabIndex = 1135;
            this.pPrepago.TabStop = false;
            // 
            // tabPagoDatafono
            // 
            this.tabPagoDatafono.Controls.Add(this.Imagen_PagoDatafono);
            this.tabPagoDatafono.Location = new System.Drawing.Point(4, 22);
            this.tabPagoDatafono.Name = "tabPagoDatafono";
            this.tabPagoDatafono.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tabPagoDatafono.Size = new System.Drawing.Size(1270, 852);
            this.tabPagoDatafono.TabIndex = 56;
            this.tabPagoDatafono.Text = "PagoDatafono";
            this.tabPagoDatafono.UseVisualStyleBackColor = true;
            // 
            // Imagen_PagoDatafono
            // 
            this.Imagen_PagoDatafono.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Imagen_PagoDatafono.Controls.Add(this.lblValorPagarDatafono);
            this.Imagen_PagoDatafono.Controls.Add(this.btn_MedioDatafono);
            this.Imagen_PagoDatafono.Controls.Add(this.btn_CancelarDatafono);
            this.Imagen_PagoDatafono.Controls.Add(this.pDatafono);
            this.Imagen_PagoDatafono.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Imagen_PagoDatafono.Location = new System.Drawing.Point(3, 3);
            this.Imagen_PagoDatafono.Name = "Imagen_PagoDatafono";
            this.Imagen_PagoDatafono.Size = new System.Drawing.Size(1264, 846);
            this.Imagen_PagoDatafono.TabIndex = 5024;
            // 
            // lblValorPagarDatafono
            // 
            this.lblValorPagarDatafono.AutoSize = true;
            this.lblValorPagarDatafono.BackColor = System.Drawing.Color.Transparent;
            this.lblValorPagarDatafono.Font = new System.Drawing.Font("Microsoft Sans Serif", 65F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValorPagarDatafono.ForeColor = System.Drawing.Color.Navy;
            this.lblValorPagarDatafono.Location = new System.Drawing.Point(135, 553);
            this.lblValorPagarDatafono.Name = "lblValorPagarDatafono";
            this.lblValorPagarDatafono.Size = new System.Drawing.Size(361, 98);
            this.lblValorPagarDatafono.TabIndex = 1136;
            this.lblValorPagarDatafono.Text = "$27.000";
            // 
            // btn_MedioDatafono
            // 
            this.btn_MedioDatafono.AutoSize = true;
            this.btn_MedioDatafono.BackColor = System.Drawing.Color.Transparent;
            this.btn_MedioDatafono.FlatAppearance.BorderSize = 0;
            this.btn_MedioDatafono.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_MedioDatafono.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_MedioDatafono.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_MedioDatafono.Location = new System.Drawing.Point(748, 905);
            this.btn_MedioDatafono.LockPush = true;
            this.btn_MedioDatafono.Name = "btn_MedioDatafono";
            this.btn_MedioDatafono.Size = new System.Drawing.Size(274, 73);
            this.btn_MedioDatafono.TabIndex = 1135;
            this.btn_MedioDatafono.Text = "Volver";
            this.btn_MedioDatafono.UseVisualStyleBackColor = false;
            this.btn_MedioDatafono.Visible = false;
            this.btn_MedioDatafono.Click += new System.EventHandler(this.btn_MedioDatafono_Click);
            // 
            // btn_CancelarDatafono
            // 
            this.btn_CancelarDatafono.AutoSize = true;
            this.btn_CancelarDatafono.BackColor = System.Drawing.Color.Transparent;
            this.btn_CancelarDatafono.FlatAppearance.BorderSize = 0;
            this.btn_CancelarDatafono.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_CancelarDatafono.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_CancelarDatafono.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_CancelarDatafono.Location = new System.Drawing.Point(1044, 902);
            this.btn_CancelarDatafono.LockPush = true;
            this.btn_CancelarDatafono.Name = "btn_CancelarDatafono";
            this.btn_CancelarDatafono.Size = new System.Drawing.Size(196, 69);
            this.btn_CancelarDatafono.TabIndex = 1122;
            this.btn_CancelarDatafono.Text = "Cancelar";
            this.btn_CancelarDatafono.UseVisualStyleBackColor = false;
            this.btn_CancelarDatafono.Visible = false;
            this.btn_CancelarDatafono.Click += new System.EventHandler(this.btn_CancelarDatafono_Click);
            // 
            // pDatafono
            // 
            this.pDatafono.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pDatafono.Location = new System.Drawing.Point(0, 0);
            this.pDatafono.Name = "pDatafono";
            this.pDatafono.Size = new System.Drawing.Size(1264, 846);
            this.pDatafono.TabIndex = 1137;
            this.pDatafono.TabStop = false;
            // 
            // tabImprimirFactura
            // 
            this.tabImprimirFactura.Controls.Add(this.Imagen_ImprimirFactura);
            this.tabImprimirFactura.Location = new System.Drawing.Point(4, 22);
            this.tabImprimirFactura.Name = "tabImprimirFactura";
            this.tabImprimirFactura.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tabImprimirFactura.Size = new System.Drawing.Size(1270, 852);
            this.tabImprimirFactura.TabIndex = 50;
            this.tabImprimirFactura.Text = "ImprimirFactura";
            this.tabImprimirFactura.UseVisualStyleBackColor = true;
            // 
            // Imagen_ImprimirFactura
            // 
            this.Imagen_ImprimirFactura.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Imagen_ImprimirFactura.Controls.Add(this.pPublicidadImprimir);
            this.Imagen_ImprimirFactura.Controls.Add(this.btnPrintSI);
            this.Imagen_ImprimirFactura.Controls.Add(this.btnPrintNO);
            this.Imagen_ImprimirFactura.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Imagen_ImprimirFactura.Location = new System.Drawing.Point(3, 3);
            this.Imagen_ImprimirFactura.Name = "Imagen_ImprimirFactura";
            this.Imagen_ImprimirFactura.Size = new System.Drawing.Size(1264, 846);
            this.Imagen_ImprimirFactura.TabIndex = 5023;
            // 
            // pPublicidadImprimir
            // 
            this.pPublicidadImprimir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pPublicidadImprimir.Location = new System.Drawing.Point(5, 0);
            this.pPublicidadImprimir.Name = "pPublicidadImprimir";
            this.pPublicidadImprimir.Size = new System.Drawing.Size(1258, 417);
            this.pPublicidadImprimir.TabIndex = 5026;
            // 
            // btnPrintSI
            // 
            this.btnPrintSI.AutoSize = true;
            this.btnPrintSI.BackColor = System.Drawing.Color.Transparent;
            this.btnPrintSI.FlatAppearance.BorderSize = 0;
            this.btnPrintSI.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnPrintSI.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnPrintSI.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrintSI.Location = new System.Drawing.Point(286, 743);
            this.btnPrintSI.LockPush = true;
            this.btnPrintSI.Name = "btnPrintSI";
            this.btnPrintSI.Size = new System.Drawing.Size(143, 68);
            this.btnPrintSI.TabIndex = 5025;
            this.btnPrintSI.Text = "SI";
            this.btnPrintSI.UseVisualStyleBackColor = false;
            this.btnPrintSI.Click += new System.EventHandler(this.btnPrintSI_Click);
            // 
            // btnPrintNO
            // 
            this.btnPrintNO.AutoSize = true;
            this.btnPrintNO.BackColor = System.Drawing.Color.Transparent;
            this.btnPrintNO.FlatAppearance.BorderSize = 0;
            this.btnPrintNO.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnPrintNO.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnPrintNO.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrintNO.Location = new System.Drawing.Point(712, 743);
            this.btnPrintNO.LockPush = true;
            this.btnPrintNO.Name = "btnPrintNO";
            this.btnPrintNO.Size = new System.Drawing.Size(143, 68);
            this.btnPrintNO.TabIndex = 1144;
            this.btnPrintNO.Text = "NO";
            this.btnPrintNO.UseVisualStyleBackColor = false;
            this.btnPrintNO.Click += new System.EventHandler(this.btn_NoPrint_Click);
            // 
            // tabGraciasPago
            // 
            this.tabGraciasPago.Controls.Add(this.Imagen_GraciasPago);
            this.tabGraciasPago.Location = new System.Drawing.Point(4, 22);
            this.tabGraciasPago.Name = "tabGraciasPago";
            this.tabGraciasPago.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tabGraciasPago.Size = new System.Drawing.Size(1270, 852);
            this.tabGraciasPago.TabIndex = 49;
            this.tabGraciasPago.Text = "GraciasPago";
            this.tabGraciasPago.UseVisualStyleBackColor = true;
            // 
            // Imagen_GraciasPago
            // 
            this.Imagen_GraciasPago.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Imagen_GraciasPago.Controls.Add(this.pPublicidadGracias);
            this.Imagen_GraciasPago.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Imagen_GraciasPago.Location = new System.Drawing.Point(3, 3);
            this.Imagen_GraciasPago.Name = "Imagen_GraciasPago";
            this.Imagen_GraciasPago.Size = new System.Drawing.Size(1264, 846);
            this.Imagen_GraciasPago.TabIndex = 5022;
            // 
            // pPublicidadGracias
            // 
            this.pPublicidadGracias.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pPublicidadGracias.Location = new System.Drawing.Point(5, 0);
            this.pPublicidadGracias.Name = "pPublicidadGracias";
            this.pPublicidadGracias.Size = new System.Drawing.Size(1258, 417);
            this.pPublicidadGracias.TabIndex = 5024;
            // 
            // tabContrasenaInvalida
            // 
            this.tabContrasenaInvalida.Controls.Add(this.Imagen_ContraseñaInvalida);
            this.tabContrasenaInvalida.Location = new System.Drawing.Point(4, 22);
            this.tabContrasenaInvalida.Name = "tabContrasenaInvalida";
            this.tabContrasenaInvalida.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tabContrasenaInvalida.Size = new System.Drawing.Size(1270, 852);
            this.tabContrasenaInvalida.TabIndex = 7;
            this.tabContrasenaInvalida.Text = "ContrasenaInvalida";
            this.tabContrasenaInvalida.UseVisualStyleBackColor = true;
            // 
            // Imagen_ContraseñaInvalida
            // 
            this.Imagen_ContraseñaInvalida.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Imagen_ContraseñaInvalida.Location = new System.Drawing.Point(3, 3);
            this.Imagen_ContraseñaInvalida.Name = "Imagen_ContraseñaInvalida";
            this.Imagen_ContraseñaInvalida.Size = new System.Drawing.Size(1264, 846);
            this.Imagen_ContraseñaInvalida.TabIndex = 5019;
            // 
            // tabIngresoPass
            // 
            this.tabIngresoPass.Controls.Add(this.Imagen_IngresoPass);
            this.tabIngresoPass.Location = new System.Drawing.Point(4, 22);
            this.tabIngresoPass.Name = "tabIngresoPass";
            this.tabIngresoPass.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tabIngresoPass.Size = new System.Drawing.Size(1270, 852);
            this.tabIngresoPass.TabIndex = 9;
            this.tabIngresoPass.Text = "IngresoPass";
            this.tabIngresoPass.UseVisualStyleBackColor = true;
            // 
            // Imagen_IngresoPass
            // 
            this.Imagen_IngresoPass.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Imagen_IngresoPass.Controls.Add(this.CapaUsuario);
            this.Imagen_IngresoPass.Controls.Add(this.CapaPass);
            this.Imagen_IngresoPass.Controls.Add(this.kbUsuarioPass);
            this.Imagen_IngresoPass.Controls.Add(this.lblPassword);
            this.Imagen_IngresoPass.Controls.Add(this.btn_Cancelar);
            this.Imagen_IngresoPass.Controls.Add(this.btn_Aceptar);
            this.Imagen_IngresoPass.Controls.Add(this.btn_MostrarTecladoPass);
            this.Imagen_IngresoPass.Controls.Add(this.lblUsuario);
            this.Imagen_IngresoPass.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Imagen_IngresoPass.Location = new System.Drawing.Point(3, 3);
            this.Imagen_IngresoPass.Name = "Imagen_IngresoPass";
            this.Imagen_IngresoPass.Size = new System.Drawing.Size(1264, 846);
            this.Imagen_IngresoPass.TabIndex = 5020;
            // 
            // CapaUsuario
            // 
            this.CapaUsuario.Location = new System.Drawing.Point(366, 275);
            this.CapaUsuario.Name = "CapaUsuario";
            this.CapaUsuario.Size = new System.Drawing.Size(531, 67);
            this.CapaUsuario.TabIndex = 1138;
            this.CapaUsuario.Text = "user";
            this.CapaUsuario.Click += new System.EventHandler(this.CapaUsuario_Click);
            // 
            // CapaPass
            // 
            this.CapaPass.Location = new System.Drawing.Point(366, 360);
            this.CapaPass.Name = "CapaPass";
            this.CapaPass.Size = new System.Drawing.Size(531, 85);
            this.CapaPass.TabIndex = 1139;
            this.CapaPass.Text = "pass";
            this.CapaPass.Click += new System.EventHandler(this.CapaPass_Click);
            // 
            // kbUsuarioPass
            // 
            this.kbUsuarioPass.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.kbUsuarioPass.BackColor = System.Drawing.Color.White;
            virtualKeyboardColorTable31.BackgroundColor = System.Drawing.Color.Black;
            virtualKeyboardColorTable31.DarkKeysColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(28)))), ((int)(((byte)(33)))));
            virtualKeyboardColorTable31.DownKeysColor = System.Drawing.Color.White;
            virtualKeyboardColorTable31.DownTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            virtualKeyboardColorTable31.KeysColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(47)))), ((int)(((byte)(55)))));
            virtualKeyboardColorTable31.LightKeysColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(68)))), ((int)(((byte)(76)))));
            virtualKeyboardColorTable31.PressedKeysColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(161)))), ((int)(((byte)(81)))));
            virtualKeyboardColorTable31.TextColor = System.Drawing.Color.White;
            virtualKeyboardColorTable31.ToggleTextColor = System.Drawing.Color.Green;
            virtualKeyboardColorTable31.TopBarTextColor = System.Drawing.Color.White;
            this.kbUsuarioPass.ColorTable = virtualKeyboardColorTable31;
            this.kbUsuarioPass.ForeColor = System.Drawing.Color.White;
            this.kbUsuarioPass.Location = new System.Drawing.Point(268, 595);
            this.kbUsuarioPass.Name = "kbUsuarioPass";
            flatStyleRenderer31.ColorTable = virtualKeyboardColorTable31;
            flatStyleRenderer31.ForceAntiAlias = false;
            this.kbUsuarioPass.Renderer = flatStyleRenderer31;
            this.kbUsuarioPass.Size = new System.Drawing.Size(804, 140);
            this.kbUsuarioPass.TabIndex = 5064;
            // 
            // lblPassword
            // 
            this.lblPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.Location = new System.Drawing.Point(589, 390);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(280, 62);
            this.lblPassword.TabIndex = 1137;
            this.lblPassword.Text = "**********";
            this.lblPassword.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_Cancelar
            // 
            this.btn_Cancelar.AutoSize = true;
            this.btn_Cancelar.BackColor = System.Drawing.Color.Transparent;
            this.btn_Cancelar.FlatAppearance.BorderSize = 0;
            this.btn_Cancelar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_Cancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_Cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Cancelar.Location = new System.Drawing.Point(957, 265);
            this.btn_Cancelar.LockPush = true;
            this.btn_Cancelar.Name = "btn_Cancelar";
            this.btn_Cancelar.Size = new System.Drawing.Size(88, 95);
            this.btn_Cancelar.TabIndex = 1121;
            this.btn_Cancelar.Text = "Cancelar";
            this.btn_Cancelar.UseVisualStyleBackColor = false;
            this.btn_Cancelar.Click += new System.EventHandler(this.btn_Cancelar_Click);
            // 
            // btn_Aceptar
            // 
            this.btn_Aceptar.AutoSize = true;
            this.btn_Aceptar.BackColor = System.Drawing.Color.Transparent;
            this.btn_Aceptar.FlatAppearance.BorderSize = 0;
            this.btn_Aceptar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_Aceptar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_Aceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Aceptar.Location = new System.Drawing.Point(88, 235);
            this.btn_Aceptar.LockPush = true;
            this.btn_Aceptar.Name = "btn_Aceptar";
            this.btn_Aceptar.Size = new System.Drawing.Size(88, 95);
            this.btn_Aceptar.TabIndex = 1120;
            this.btn_Aceptar.Text = "Aceptar";
            this.btn_Aceptar.UseVisualStyleBackColor = false;
            this.btn_Aceptar.Click += new System.EventHandler(this.btn_Aceptar_Click);
            // 
            // btn_MostrarTecladoPass
            // 
            this.btn_MostrarTecladoPass.AutoSize = true;
            this.btn_MostrarTecladoPass.BackColor = System.Drawing.Color.Transparent;
            this.btn_MostrarTecladoPass.FlatAppearance.BorderSize = 0;
            this.btn_MostrarTecladoPass.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_MostrarTecladoPass.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_MostrarTecladoPass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_MostrarTecladoPass.Location = new System.Drawing.Point(58, 868);
            this.btn_MostrarTecladoPass.LockPush = true;
            this.btn_MostrarTecladoPass.Name = "btn_MostrarTecladoPass";
            this.btn_MostrarTecladoPass.Size = new System.Drawing.Size(88, 95);
            this.btn_MostrarTecladoPass.TabIndex = 1119;
            this.btn_MostrarTecladoPass.Text = "keyboard";
            this.btn_MostrarTecladoPass.UseVisualStyleBackColor = false;
            this.btn_MostrarTecladoPass.Click += new System.EventHandler(this.btn_MostrarTecladoPass_Click);
            // 
            // lblUsuario
            // 
            this.lblUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.Location = new System.Drawing.Point(586, 285);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(280, 62);
            this.lblUsuario.TabIndex = 1136;
            this.lblUsuario.Text = "1030532017";
            this.lblUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tabSegundoPass
            // 
            this.tabSegundoPass.Controls.Add(this.Imagen_SegundaPass);
            this.tabSegundoPass.Location = new System.Drawing.Point(4, 22);
            this.tabSegundoPass.Name = "tabSegundoPass";
            this.tabSegundoPass.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tabSegundoPass.Size = new System.Drawing.Size(1270, 852);
            this.tabSegundoPass.TabIndex = 10;
            this.tabSegundoPass.Text = "SegundoPass";
            this.tabSegundoPass.UseVisualStyleBackColor = true;
            // 
            // Imagen_SegundaPass
            // 
            this.Imagen_SegundaPass.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Imagen_SegundaPass.Controls.Add(this.lblCodigo);
            this.Imagen_SegundaPass.Controls.Add(this.lblUsuarioSegunda);
            this.Imagen_SegundaPass.Controls.Add(this.btn_CancelarSegunda);
            this.Imagen_SegundaPass.Controls.Add(this.btn_AceptarSegunda);
            this.Imagen_SegundaPass.Controls.Add(this.btn_MostrarTecladoSegunda);
            this.Imagen_SegundaPass.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Imagen_SegundaPass.Location = new System.Drawing.Point(3, 3);
            this.Imagen_SegundaPass.Name = "Imagen_SegundaPass";
            this.Imagen_SegundaPass.Size = new System.Drawing.Size(1264, 846);
            this.Imagen_SegundaPass.TabIndex = 5021;
            // 
            // lblCodigo
            // 
            this.lblCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigo.Location = new System.Drawing.Point(496, 245);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(280, 62);
            this.lblCodigo.TabIndex = 1146;
            this.lblCodigo.Text = "1030532017";
            this.lblCodigo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblUsuarioSegunda
            // 
            this.lblUsuarioSegunda.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuarioSegunda.Location = new System.Drawing.Point(491, 143);
            this.lblUsuarioSegunda.Name = "lblUsuarioSegunda";
            this.lblUsuarioSegunda.Size = new System.Drawing.Size(280, 62);
            this.lblUsuarioSegunda.TabIndex = 1142;
            this.lblUsuarioSegunda.Text = "1030532017";
            this.lblUsuarioSegunda.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_CancelarSegunda
            // 
            this.btn_CancelarSegunda.AutoSize = true;
            this.btn_CancelarSegunda.BackColor = System.Drawing.Color.Transparent;
            this.btn_CancelarSegunda.FlatAppearance.BorderSize = 0;
            this.btn_CancelarSegunda.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_CancelarSegunda.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_CancelarSegunda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_CancelarSegunda.Location = new System.Drawing.Point(1012, 235);
            this.btn_CancelarSegunda.LockPush = true;
            this.btn_CancelarSegunda.Name = "btn_CancelarSegunda";
            this.btn_CancelarSegunda.Size = new System.Drawing.Size(88, 95);
            this.btn_CancelarSegunda.TabIndex = 1141;
            this.btn_CancelarSegunda.Text = "Cancelar";
            this.btn_CancelarSegunda.UseVisualStyleBackColor = false;
            // 
            // btn_AceptarSegunda
            // 
            this.btn_AceptarSegunda.AutoSize = true;
            this.btn_AceptarSegunda.BackColor = System.Drawing.Color.Transparent;
            this.btn_AceptarSegunda.FlatAppearance.BorderSize = 0;
            this.btn_AceptarSegunda.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_AceptarSegunda.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_AceptarSegunda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_AceptarSegunda.Location = new System.Drawing.Point(60, 235);
            this.btn_AceptarSegunda.LockPush = true;
            this.btn_AceptarSegunda.Name = "btn_AceptarSegunda";
            this.btn_AceptarSegunda.Size = new System.Drawing.Size(88, 95);
            this.btn_AceptarSegunda.TabIndex = 1140;
            this.btn_AceptarSegunda.Text = "Aceptar";
            this.btn_AceptarSegunda.UseVisualStyleBackColor = false;
            // 
            // btn_MostrarTecladoSegunda
            // 
            this.btn_MostrarTecladoSegunda.AutoSize = true;
            this.btn_MostrarTecladoSegunda.BackColor = System.Drawing.Color.Transparent;
            this.btn_MostrarTecladoSegunda.FlatAppearance.BorderSize = 0;
            this.btn_MostrarTecladoSegunda.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_MostrarTecladoSegunda.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_MostrarTecladoSegunda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_MostrarTecladoSegunda.Location = new System.Drawing.Point(5, 867);
            this.btn_MostrarTecladoSegunda.LockPush = true;
            this.btn_MostrarTecladoSegunda.Name = "btn_MostrarTecladoSegunda";
            this.btn_MostrarTecladoSegunda.Size = new System.Drawing.Size(88, 95);
            this.btn_MostrarTecladoSegunda.TabIndex = 1119;
            this.btn_MostrarTecladoSegunda.Text = "keyboard";
            this.btn_MostrarTecladoSegunda.UseVisualStyleBackColor = false;
            // 
            // tabMantenimiento
            // 
            this.tabMantenimiento.Controls.Add(this.Imagen_Mantenimiento);
            this.tabMantenimiento.Location = new System.Drawing.Point(4, 22);
            this.tabMantenimiento.Name = "tabMantenimiento";
            this.tabMantenimiento.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tabMantenimiento.Size = new System.Drawing.Size(1270, 852);
            this.tabMantenimiento.TabIndex = 11;
            this.tabMantenimiento.Text = "Mantenimiento";
            this.tabMantenimiento.UseVisualStyleBackColor = true;
            // 
            // Imagen_Mantenimiento
            // 
            this.Imagen_Mantenimiento.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Imagen_Mantenimiento.Controls.Add(this.CapaMantenimientoCaleto);
            this.Imagen_Mantenimiento.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Imagen_Mantenimiento.Location = new System.Drawing.Point(3, 3);
            this.Imagen_Mantenimiento.Name = "Imagen_Mantenimiento";
            this.Imagen_Mantenimiento.Size = new System.Drawing.Size(1264, 846);
            this.Imagen_Mantenimiento.TabIndex = 5020;
            // 
            // CapaMantenimientoCaleto
            // 
            this.CapaMantenimientoCaleto.Location = new System.Drawing.Point(525, 928);
            this.CapaMantenimientoCaleto.Name = "CapaMantenimientoCaleto";
            this.CapaMantenimientoCaleto.Size = new System.Drawing.Size(145, 79);
            this.CapaMantenimientoCaleto.TabIndex = 5022;
            this.CapaMantenimientoCaleto.Text = "CAPA";
            this.CapaMantenimientoCaleto.Click += new System.EventHandler(this.CapaMantenimientoCaleto_Click);
            // 
            // tabArqueo
            // 
            this.tabArqueo.Controls.Add(this.Imagen_Arqueo);
            this.tabArqueo.Location = new System.Drawing.Point(4, 22);
            this.tabArqueo.Name = "tabArqueo";
            this.tabArqueo.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tabArqueo.Size = new System.Drawing.Size(1270, 852);
            this.tabArqueo.TabIndex = 12;
            this.tabArqueo.Text = "Arqueo";
            this.tabArqueo.UseVisualStyleBackColor = true;
            // 
            // Imagen_Arqueo
            // 
            this.Imagen_Arqueo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Imagen_Arqueo.Controls.Add(this.btn_ArqueoTotal);
            this.Imagen_Arqueo.Controls.Add(this.btn_Volver);
            this.Imagen_Arqueo.Controls.Add(this.btn_ArqueoParcial);
            this.Imagen_Arqueo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Imagen_Arqueo.Location = new System.Drawing.Point(3, 3);
            this.Imagen_Arqueo.Name = "Imagen_Arqueo";
            this.Imagen_Arqueo.Size = new System.Drawing.Size(1264, 846);
            this.Imagen_Arqueo.TabIndex = 5020;
            // 
            // btn_ArqueoTotal
            // 
            this.btn_ArqueoTotal.AutoSize = true;
            this.btn_ArqueoTotal.BackColor = System.Drawing.Color.Transparent;
            this.btn_ArqueoTotal.FlatAppearance.BorderSize = 0;
            this.btn_ArqueoTotal.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_ArqueoTotal.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_ArqueoTotal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ArqueoTotal.Location = new System.Drawing.Point(723, 366);
            this.btn_ArqueoTotal.LockPush = true;
            this.btn_ArqueoTotal.Name = "btn_ArqueoTotal";
            this.btn_ArqueoTotal.Size = new System.Drawing.Size(181, 152);
            this.btn_ArqueoTotal.TabIndex = 1142;
            this.btn_ArqueoTotal.Text = "ARQUEO TOTAL";
            this.btn_ArqueoTotal.UseVisualStyleBackColor = false;
            this.btn_ArqueoTotal.Click += new System.EventHandler(this.btn_ArqueoTotal_Click);
            // 
            // btn_Volver
            // 
            this.btn_Volver.AutoSize = true;
            this.btn_Volver.BackColor = System.Drawing.Color.Transparent;
            this.btn_Volver.FlatAppearance.BorderSize = 0;
            this.btn_Volver.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_Volver.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_Volver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Volver.Location = new System.Drawing.Point(969, 763);
            this.btn_Volver.LockPush = true;
            this.btn_Volver.Name = "btn_Volver";
            this.btn_Volver.Size = new System.Drawing.Size(181, 152);
            this.btn_Volver.TabIndex = 1134;
            this.btn_Volver.Text = "VOLVER";
            this.btn_Volver.UseVisualStyleBackColor = false;
            this.btn_Volver.Click += new System.EventHandler(this.btn_Volver_Click);
            // 
            // btn_ArqueoParcial
            // 
            this.btn_ArqueoParcial.AutoSize = true;
            this.btn_ArqueoParcial.BackColor = System.Drawing.Color.Transparent;
            this.btn_ArqueoParcial.FlatAppearance.BorderSize = 0;
            this.btn_ArqueoParcial.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_ArqueoParcial.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_ArqueoParcial.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ArqueoParcial.Location = new System.Drawing.Point(162, 366);
            this.btn_ArqueoParcial.LockPush = true;
            this.btn_ArqueoParcial.Name = "btn_ArqueoParcial";
            this.btn_ArqueoParcial.Size = new System.Drawing.Size(181, 152);
            this.btn_ArqueoParcial.TabIndex = 1133;
            this.btn_ArqueoParcial.Text = "ARQUEO PARCIAL";
            this.btn_ArqueoParcial.UseVisualStyleBackColor = false;
            this.btn_ArqueoParcial.Click += new System.EventHandler(this.btn_ArqueoParcial_Click);
            // 
            // tabCarga
            // 
            this.tabCarga.Controls.Add(this.Imagen_Carga);
            this.tabCarga.Location = new System.Drawing.Point(4, 22);
            this.tabCarga.Name = "tabCarga";
            this.tabCarga.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tabCarga.Size = new System.Drawing.Size(1270, 852);
            this.tabCarga.TabIndex = 13;
            this.tabCarga.Text = "Carga";
            this.tabCarga.UseVisualStyleBackColor = true;
            // 
            // Imagen_Carga
            // 
            this.Imagen_Carga.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Imagen_Carga.Controls.Add(this.btn_CargaMonedas);
            this.Imagen_Carga.Controls.Add(this.btn_VolverCarga);
            this.Imagen_Carga.Controls.Add(this.btn_CargaBilletes);
            this.Imagen_Carga.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Imagen_Carga.Location = new System.Drawing.Point(3, 3);
            this.Imagen_Carga.Name = "Imagen_Carga";
            this.Imagen_Carga.Size = new System.Drawing.Size(1264, 846);
            this.Imagen_Carga.TabIndex = 5021;
            // 
            // btn_CargaMonedas
            // 
            this.btn_CargaMonedas.AutoSize = true;
            this.btn_CargaMonedas.BackColor = System.Drawing.Color.Transparent;
            this.btn_CargaMonedas.FlatAppearance.BorderSize = 0;
            this.btn_CargaMonedas.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_CargaMonedas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_CargaMonedas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_CargaMonedas.Location = new System.Drawing.Point(723, 366);
            this.btn_CargaMonedas.LockPush = true;
            this.btn_CargaMonedas.Name = "btn_CargaMonedas";
            this.btn_CargaMonedas.Size = new System.Drawing.Size(181, 152);
            this.btn_CargaMonedas.TabIndex = 1142;
            this.btn_CargaMonedas.Text = "CARGA MONEDAS";
            this.btn_CargaMonedas.UseVisualStyleBackColor = false;
            this.btn_CargaMonedas.Click += new System.EventHandler(this.btn_CargaMonedas_Click);
            // 
            // btn_VolverCarga
            // 
            this.btn_VolverCarga.AutoSize = true;
            this.btn_VolverCarga.BackColor = System.Drawing.Color.Transparent;
            this.btn_VolverCarga.FlatAppearance.BorderSize = 0;
            this.btn_VolverCarga.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_VolverCarga.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_VolverCarga.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_VolverCarga.Location = new System.Drawing.Point(969, 763);
            this.btn_VolverCarga.LockPush = true;
            this.btn_VolverCarga.Name = "btn_VolverCarga";
            this.btn_VolverCarga.Size = new System.Drawing.Size(181, 152);
            this.btn_VolverCarga.TabIndex = 1134;
            this.btn_VolverCarga.Text = "VOLVER";
            this.btn_VolverCarga.UseVisualStyleBackColor = false;
            this.btn_VolverCarga.Click += new System.EventHandler(this.btn_VolverCarga_Click);
            // 
            // btn_CargaBilletes
            // 
            this.btn_CargaBilletes.AutoSize = true;
            this.btn_CargaBilletes.BackColor = System.Drawing.Color.Transparent;
            this.btn_CargaBilletes.FlatAppearance.BorderSize = 0;
            this.btn_CargaBilletes.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_CargaBilletes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_CargaBilletes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_CargaBilletes.Location = new System.Drawing.Point(162, 366);
            this.btn_CargaBilletes.LockPush = true;
            this.btn_CargaBilletes.Name = "btn_CargaBilletes";
            this.btn_CargaBilletes.Size = new System.Drawing.Size(181, 152);
            this.btn_CargaBilletes.TabIndex = 1133;
            this.btn_CargaBilletes.Text = "CARGA BILLETES";
            this.btn_CargaBilletes.UseVisualStyleBackColor = false;
            this.btn_CargaBilletes.Click += new System.EventHandler(this.btn_CargaBilletes_Click);
            // 
            // tabCargaBilletes
            // 
            this.tabCargaBilletes.Controls.Add(this.Imagen_CargaBilletes);
            this.tabCargaBilletes.Location = new System.Drawing.Point(4, 22);
            this.tabCargaBilletes.Name = "tabCargaBilletes";
            this.tabCargaBilletes.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tabCargaBilletes.Size = new System.Drawing.Size(1270, 852);
            this.tabCargaBilletes.TabIndex = 14;
            this.tabCargaBilletes.Text = "CargaBilletes";
            this.tabCargaBilletes.UseVisualStyleBackColor = true;
            // 
            // Imagen_CargaBilletes
            // 
            this.Imagen_CargaBilletes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Imagen_CargaBilletes.Controls.Add(this.label1);
            this.Imagen_CargaBilletes.Controls.Add(this.label4);
            this.Imagen_CargaBilletes.Controls.Add(this.btn_ConfirmarCargaF56);
            this.Imagen_CargaBilletes.Controls.Add(this.grvCargaActualBilletesF56);
            this.Imagen_CargaBilletes.Controls.Add(this.grvCargaTotalBilletesF56);
            this.Imagen_CargaBilletes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Imagen_CargaBilletes.Location = new System.Drawing.Point(3, 3);
            this.Imagen_CargaBilletes.Name = "Imagen_CargaBilletes";
            this.Imagen_CargaBilletes.Size = new System.Drawing.Size(1264, 846);
            this.Imagen_CargaBilletes.TabIndex = 5026;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(562, 627);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(206, 31);
            this.label1.TabIndex = 201;
            this.label1.Text = "CARGA TOTAL";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(149, 627);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(226, 31);
            this.label4.TabIndex = 200;
            this.label4.Text = "CARGA ACTUAL";
            // 
            // btn_ConfirmarCargaF56
            // 
            this.btn_ConfirmarCargaF56.AutoSize = true;
            this.btn_ConfirmarCargaF56.BackColor = System.Drawing.Color.Transparent;
            this.btn_ConfirmarCargaF56.FlatAppearance.BorderSize = 0;
            this.btn_ConfirmarCargaF56.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_ConfirmarCargaF56.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_ConfirmarCargaF56.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ConfirmarCargaF56.Location = new System.Drawing.Point(925, 730);
            this.btn_ConfirmarCargaF56.LockPush = false;
            this.btn_ConfirmarCargaF56.Name = "btn_ConfirmarCargaF56";
            this.btn_ConfirmarCargaF56.Size = new System.Drawing.Size(189, 85);
            this.btn_ConfirmarCargaF56.TabIndex = 193;
            this.btn_ConfirmarCargaF56.Text = "ok";
            this.btn_ConfirmarCargaF56.UseVisualStyleBackColor = false;
            this.btn_ConfirmarCargaF56.Click += new System.EventHandler(this.btn_ConfirmarCargaF56_Click);
            // 
            // grvCargaActualBilletesF56
            // 
            this.grvCargaActualBilletesF56.AllowUserToAddRows = false;
            this.grvCargaActualBilletesF56.AllowUserToDeleteRows = false;
            this.grvCargaActualBilletesF56.AllowUserToResizeColumns = false;
            this.grvCargaActualBilletesF56.AllowUserToResizeRows = false;
            dataGridViewCellStyle301.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.grvCargaActualBilletesF56.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle301;
            this.grvCargaActualBilletesF56.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle302.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle302.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle302.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle302.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle302.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle302.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle302.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grvCargaActualBilletesF56.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle302;
            this.grvCargaActualBilletesF56.ColumnHeadersHeight = 22;
            this.grvCargaActualBilletesF56.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle303.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle303.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle303.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle303.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle303.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle303.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle303.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grvCargaActualBilletesF56.DefaultCellStyle = dataGridViewCellStyle303;
            this.grvCargaActualBilletesF56.Location = new System.Drawing.Point(109, 661);
            this.grvCargaActualBilletesF56.MultiSelect = false;
            this.grvCargaActualBilletesF56.Name = "grvCargaActualBilletesF56";
            this.grvCargaActualBilletesF56.ReadOnly = true;
            dataGridViewCellStyle304.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle304.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle304.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle304.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle304.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle304.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle304.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grvCargaActualBilletesF56.RowHeadersDefaultCellStyle = dataGridViewCellStyle304;
            this.grvCargaActualBilletesF56.RowHeadersVisible = false;
            this.grvCargaActualBilletesF56.RowHeadersWidth = 25;
            this.grvCargaActualBilletesF56.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle305.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.grvCargaActualBilletesF56.RowsDefaultCellStyle = dataGridViewCellStyle305;
            this.grvCargaActualBilletesF56.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.grvCargaActualBilletesF56.Size = new System.Drawing.Size(327, 232);
            this.grvCargaActualBilletesF56.TabIndex = 154;
            // 
            // grvCargaTotalBilletesF56
            // 
            this.grvCargaTotalBilletesF56.AllowUserToAddRows = false;
            this.grvCargaTotalBilletesF56.AllowUserToDeleteRows = false;
            this.grvCargaTotalBilletesF56.AllowUserToResizeColumns = false;
            this.grvCargaTotalBilletesF56.AllowUserToResizeRows = false;
            dataGridViewCellStyle306.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.grvCargaTotalBilletesF56.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle306;
            this.grvCargaTotalBilletesF56.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle307.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle307.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle307.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle307.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle307.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle307.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle307.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grvCargaTotalBilletesF56.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle307;
            this.grvCargaTotalBilletesF56.ColumnHeadersHeight = 22;
            this.grvCargaTotalBilletesF56.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle308.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle308.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle308.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle308.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle308.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle308.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle308.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grvCargaTotalBilletesF56.DefaultCellStyle = dataGridViewCellStyle308;
            this.grvCargaTotalBilletesF56.Location = new System.Drawing.Point(506, 661);
            this.grvCargaTotalBilletesF56.Name = "grvCargaTotalBilletesF56";
            this.grvCargaTotalBilletesF56.ReadOnly = true;
            dataGridViewCellStyle309.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle309.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle309.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle309.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle309.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle309.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle309.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grvCargaTotalBilletesF56.RowHeadersDefaultCellStyle = dataGridViewCellStyle309;
            this.grvCargaTotalBilletesF56.RowHeadersVisible = false;
            this.grvCargaTotalBilletesF56.RowHeadersWidth = 25;
            this.grvCargaTotalBilletesF56.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle310.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.grvCargaTotalBilletesF56.RowsDefaultCellStyle = dataGridViewCellStyle310;
            this.grvCargaTotalBilletesF56.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.grvCargaTotalBilletesF56.Size = new System.Drawing.Size(327, 232);
            this.grvCargaTotalBilletesF56.TabIndex = 153;
            // 
            // tabCargaMonedas
            // 
            this.tabCargaMonedas.Controls.Add(this.Imagen_CargaMonedas);
            this.tabCargaMonedas.Location = new System.Drawing.Point(4, 22);
            this.tabCargaMonedas.Name = "tabCargaMonedas";
            this.tabCargaMonedas.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tabCargaMonedas.Size = new System.Drawing.Size(1270, 852);
            this.tabCargaMonedas.TabIndex = 15;
            this.tabCargaMonedas.Text = "CargaMonedas";
            this.tabCargaMonedas.UseVisualStyleBackColor = true;
            // 
            // Imagen_CargaMonedas
            // 
            this.Imagen_CargaMonedas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Imagen_CargaMonedas.Controls.Add(this.label3);
            this.Imagen_CargaMonedas.Controls.Add(this.label2);
            this.Imagen_CargaMonedas.Controls.Add(this.btnHopper4);
            this.Imagen_CargaMonedas.Controls.Add(this.btn_Hopper3);
            this.Imagen_CargaMonedas.Controls.Add(this.btn_ConfirmarCargaMonedas);
            this.Imagen_CargaMonedas.Controls.Add(this.btn_okCarga);
            this.Imagen_CargaMonedas.Controls.Add(this.btn_BorrarCarga);
            this.Imagen_CargaMonedas.Controls.Add(this.btn_0Carga);
            this.Imagen_CargaMonedas.Controls.Add(this.btn_3Carga);
            this.Imagen_CargaMonedas.Controls.Add(this.btn_2Carga);
            this.Imagen_CargaMonedas.Controls.Add(this.btn_1Carga);
            this.Imagen_CargaMonedas.Controls.Add(this.btn_6Carga);
            this.Imagen_CargaMonedas.Controls.Add(this.btn_5Carga);
            this.Imagen_CargaMonedas.Controls.Add(this.btn_4Carga);
            this.Imagen_CargaMonedas.Controls.Add(this.btn_9Carga);
            this.Imagen_CargaMonedas.Controls.Add(this.btn_8Carga);
            this.Imagen_CargaMonedas.Controls.Add(this.btn_7Carga);
            this.Imagen_CargaMonedas.Controls.Add(this.lblKeyboard_Carga);
            this.Imagen_CargaMonedas.Controls.Add(this.grvCargaActualMonedas);
            this.Imagen_CargaMonedas.Controls.Add(this.grvCargaTotalMonedas);
            this.Imagen_CargaMonedas.Controls.Add(this.btnHopper2);
            this.Imagen_CargaMonedas.Controls.Add(this.btnHopper1);
            this.Imagen_CargaMonedas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Imagen_CargaMonedas.Location = new System.Drawing.Point(3, 3);
            this.Imagen_CargaMonedas.Name = "Imagen_CargaMonedas";
            this.Imagen_CargaMonedas.Size = new System.Drawing.Size(1264, 846);
            this.Imagen_CargaMonedas.TabIndex = 5027;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(495, 725);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(206, 31);
            this.label3.TabIndex = 199;
            this.label3.Text = "CARGA TOTAL";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(110, 725);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(226, 31);
            this.label2.TabIndex = 198;
            this.label2.Text = "CARGA ACTUAL";
            // 
            // btnHopper4
            // 
            this.btnHopper4.AutoSize = true;
            this.btnHopper4.BackColor = System.Drawing.Color.Transparent;
            this.btnHopper4.FlatAppearance.BorderSize = 0;
            this.btnHopper4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnHopper4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnHopper4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHopper4.Location = new System.Drawing.Point(431, 434);
            this.btnHopper4.LockPush = true;
            this.btnHopper4.Name = "btnHopper4";
            this.btnHopper4.Size = new System.Drawing.Size(222, 85);
            this.btnHopper4.TabIndex = 195;
            this.btnHopper4.Text = "Hopper4";
            this.btnHopper4.UseVisualStyleBackColor = false;
            this.btnHopper4.Click += new System.EventHandler(this.btnHopper4_Click);
            // 
            // btn_Hopper3
            // 
            this.btn_Hopper3.AutoSize = true;
            this.btn_Hopper3.BackColor = System.Drawing.Color.Transparent;
            this.btn_Hopper3.FlatAppearance.BorderSize = 0;
            this.btn_Hopper3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_Hopper3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_Hopper3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Hopper3.Location = new System.Drawing.Point(142, 434);
            this.btn_Hopper3.LockPush = true;
            this.btn_Hopper3.Name = "btn_Hopper3";
            this.btn_Hopper3.Size = new System.Drawing.Size(222, 85);
            this.btn_Hopper3.TabIndex = 194;
            this.btn_Hopper3.Text = "Hopper3";
            this.btn_Hopper3.UseVisualStyleBackColor = false;
            this.btn_Hopper3.Click += new System.EventHandler(this.btn_Hopper3_Click);
            // 
            // btn_ConfirmarCargaMonedas
            // 
            this.btn_ConfirmarCargaMonedas.AutoSize = true;
            this.btn_ConfirmarCargaMonedas.BackColor = System.Drawing.Color.Transparent;
            this.btn_ConfirmarCargaMonedas.FlatAppearance.BorderSize = 0;
            this.btn_ConfirmarCargaMonedas.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_ConfirmarCargaMonedas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_ConfirmarCargaMonedas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ConfirmarCargaMonedas.Location = new System.Drawing.Point(918, 757);
            this.btn_ConfirmarCargaMonedas.LockPush = false;
            this.btn_ConfirmarCargaMonedas.Name = "btn_ConfirmarCargaMonedas";
            this.btn_ConfirmarCargaMonedas.Size = new System.Drawing.Size(189, 85);
            this.btn_ConfirmarCargaMonedas.TabIndex = 193;
            this.btn_ConfirmarCargaMonedas.Text = "ok";
            this.btn_ConfirmarCargaMonedas.UseVisualStyleBackColor = false;
            this.btn_ConfirmarCargaMonedas.Click += new System.EventHandler(this.btn_ConfirmarCargaMonedas_Click);
            // 
            // btn_okCarga
            // 
            this.btn_okCarga.AutoSize = true;
            this.btn_okCarga.BackColor = System.Drawing.Color.Transparent;
            this.btn_okCarga.FlatAppearance.BorderSize = 0;
            this.btn_okCarga.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_okCarga.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_okCarga.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_okCarga.Location = new System.Drawing.Point(853, 637);
            this.btn_okCarga.LockPush = true;
            this.btn_okCarga.Name = "btn_okCarga";
            this.btn_okCarga.Size = new System.Drawing.Size(97, 92);
            this.btn_okCarga.TabIndex = 192;
            this.btn_okCarga.Text = "ok";
            this.btn_okCarga.UseVisualStyleBackColor = false;
            this.btn_okCarga.Click += new System.EventHandler(this.btn_okCarga_Click);
            // 
            // btn_BorrarCarga
            // 
            this.btn_BorrarCarga.AutoSize = true;
            this.btn_BorrarCarga.BackColor = System.Drawing.Color.Transparent;
            this.btn_BorrarCarga.FlatAppearance.BorderSize = 0;
            this.btn_BorrarCarga.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_BorrarCarga.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_BorrarCarga.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_BorrarCarga.Location = new System.Drawing.Point(1086, 637);
            this.btn_BorrarCarga.LockPush = true;
            this.btn_BorrarCarga.Name = "btn_BorrarCarga";
            this.btn_BorrarCarga.Size = new System.Drawing.Size(97, 92);
            this.btn_BorrarCarga.TabIndex = 191;
            this.btn_BorrarCarga.Text = "borrar";
            this.btn_BorrarCarga.UseVisualStyleBackColor = false;
            this.btn_BorrarCarga.Click += new System.EventHandler(this.btn_BorrarCarga_Click);
            // 
            // btn_0Carga
            // 
            this.btn_0Carga.AutoSize = true;
            this.btn_0Carga.BackColor = System.Drawing.Color.Transparent;
            this.btn_0Carga.FlatAppearance.BorderSize = 0;
            this.btn_0Carga.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_0Carga.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_0Carga.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_0Carga.Location = new System.Drawing.Point(980, 648);
            this.btn_0Carga.LockPush = true;
            this.btn_0Carga.Name = "btn_0Carga";
            this.btn_0Carga.Size = new System.Drawing.Size(97, 92);
            this.btn_0Carga.TabIndex = 189;
            this.btn_0Carga.Text = "0";
            this.btn_0Carga.UseVisualStyleBackColor = false;
            this.btn_0Carga.Click += new System.EventHandler(this.btn_0Carga_Click);
            // 
            // btn_3Carga
            // 
            this.btn_3Carga.AutoSize = true;
            this.btn_3Carga.BackColor = System.Drawing.Color.Transparent;
            this.btn_3Carga.FlatAppearance.BorderSize = 0;
            this.btn_3Carga.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_3Carga.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_3Carga.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_3Carga.Location = new System.Drawing.Point(1099, 532);
            this.btn_3Carga.LockPush = true;
            this.btn_3Carga.Name = "btn_3Carga";
            this.btn_3Carga.Size = new System.Drawing.Size(97, 92);
            this.btn_3Carga.TabIndex = 188;
            this.btn_3Carga.Text = "3";
            this.btn_3Carga.UseVisualStyleBackColor = false;
            this.btn_3Carga.Click += new System.EventHandler(this.btn_3Carga_Click);
            // 
            // btn_2Carga
            // 
            this.btn_2Carga.AutoSize = true;
            this.btn_2Carga.BackColor = System.Drawing.Color.Transparent;
            this.btn_2Carga.FlatAppearance.BorderSize = 0;
            this.btn_2Carga.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_2Carga.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_2Carga.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_2Carga.Location = new System.Drawing.Point(980, 532);
            this.btn_2Carga.LockPush = true;
            this.btn_2Carga.Name = "btn_2Carga";
            this.btn_2Carga.Size = new System.Drawing.Size(97, 92);
            this.btn_2Carga.TabIndex = 187;
            this.btn_2Carga.Text = "2";
            this.btn_2Carga.UseVisualStyleBackColor = false;
            this.btn_2Carga.Click += new System.EventHandler(this.btn_2Carga_Click);
            // 
            // btn_1Carga
            // 
            this.btn_1Carga.AutoSize = true;
            this.btn_1Carga.BackColor = System.Drawing.Color.Transparent;
            this.btn_1Carga.FlatAppearance.BorderSize = 0;
            this.btn_1Carga.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_1Carga.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_1Carga.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_1Carga.Location = new System.Drawing.Point(863, 532);
            this.btn_1Carga.LockPush = true;
            this.btn_1Carga.Name = "btn_1Carga";
            this.btn_1Carga.Size = new System.Drawing.Size(97, 92);
            this.btn_1Carga.TabIndex = 186;
            this.btn_1Carga.Text = "1";
            this.btn_1Carga.UseVisualStyleBackColor = false;
            this.btn_1Carga.Click += new System.EventHandler(this.btn_1Carga_Click);
            // 
            // btn_6Carga
            // 
            this.btn_6Carga.AutoSize = true;
            this.btn_6Carga.BackColor = System.Drawing.Color.Transparent;
            this.btn_6Carga.FlatAppearance.BorderSize = 0;
            this.btn_6Carga.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_6Carga.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_6Carga.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_6Carga.Location = new System.Drawing.Point(1099, 419);
            this.btn_6Carga.LockPush = true;
            this.btn_6Carga.Name = "btn_6Carga";
            this.btn_6Carga.Size = new System.Drawing.Size(97, 92);
            this.btn_6Carga.TabIndex = 185;
            this.btn_6Carga.Text = "6";
            this.btn_6Carga.UseVisualStyleBackColor = false;
            this.btn_6Carga.Click += new System.EventHandler(this.btn_6Carga_Click);
            // 
            // btn_5Carga
            // 
            this.btn_5Carga.AutoSize = true;
            this.btn_5Carga.BackColor = System.Drawing.Color.Transparent;
            this.btn_5Carga.FlatAppearance.BorderSize = 0;
            this.btn_5Carga.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_5Carga.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_5Carga.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_5Carga.Location = new System.Drawing.Point(980, 419);
            this.btn_5Carga.LockPush = true;
            this.btn_5Carga.Name = "btn_5Carga";
            this.btn_5Carga.Size = new System.Drawing.Size(97, 92);
            this.btn_5Carga.TabIndex = 184;
            this.btn_5Carga.Text = "5";
            this.btn_5Carga.UseVisualStyleBackColor = false;
            this.btn_5Carga.Click += new System.EventHandler(this.btn_5Carga_Click);
            // 
            // btn_4Carga
            // 
            this.btn_4Carga.AutoSize = true;
            this.btn_4Carga.BackColor = System.Drawing.Color.Transparent;
            this.btn_4Carga.FlatAppearance.BorderSize = 0;
            this.btn_4Carga.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_4Carga.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_4Carga.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_4Carga.Location = new System.Drawing.Point(863, 419);
            this.btn_4Carga.LockPush = true;
            this.btn_4Carga.Name = "btn_4Carga";
            this.btn_4Carga.Size = new System.Drawing.Size(97, 92);
            this.btn_4Carga.TabIndex = 183;
            this.btn_4Carga.Text = "4";
            this.btn_4Carga.UseVisualStyleBackColor = false;
            this.btn_4Carga.Click += new System.EventHandler(this.btn_4Carga_Click);
            // 
            // btn_9Carga
            // 
            this.btn_9Carga.AutoSize = true;
            this.btn_9Carga.BackColor = System.Drawing.Color.Transparent;
            this.btn_9Carga.FlatAppearance.BorderSize = 0;
            this.btn_9Carga.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_9Carga.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_9Carga.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_9Carga.Location = new System.Drawing.Point(1099, 309);
            this.btn_9Carga.LockPush = true;
            this.btn_9Carga.Name = "btn_9Carga";
            this.btn_9Carga.Size = new System.Drawing.Size(97, 92);
            this.btn_9Carga.TabIndex = 182;
            this.btn_9Carga.Text = "9";
            this.btn_9Carga.UseVisualStyleBackColor = false;
            this.btn_9Carga.Click += new System.EventHandler(this.btn_9Carga_Click);
            // 
            // btn_8Carga
            // 
            this.btn_8Carga.AutoSize = true;
            this.btn_8Carga.BackColor = System.Drawing.Color.Transparent;
            this.btn_8Carga.FlatAppearance.BorderSize = 0;
            this.btn_8Carga.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_8Carga.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_8Carga.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_8Carga.Location = new System.Drawing.Point(980, 309);
            this.btn_8Carga.LockPush = true;
            this.btn_8Carga.Name = "btn_8Carga";
            this.btn_8Carga.Size = new System.Drawing.Size(97, 92);
            this.btn_8Carga.TabIndex = 181;
            this.btn_8Carga.Text = "8";
            this.btn_8Carga.UseVisualStyleBackColor = false;
            this.btn_8Carga.Click += new System.EventHandler(this.btn_8Carga_Click);
            // 
            // btn_7Carga
            // 
            this.btn_7Carga.AutoSize = true;
            this.btn_7Carga.BackColor = System.Drawing.Color.Transparent;
            this.btn_7Carga.FlatAppearance.BorderSize = 0;
            this.btn_7Carga.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_7Carga.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_7Carga.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_7Carga.Location = new System.Drawing.Point(863, 309);
            this.btn_7Carga.LockPush = true;
            this.btn_7Carga.Name = "btn_7Carga";
            this.btn_7Carga.Size = new System.Drawing.Size(97, 92);
            this.btn_7Carga.TabIndex = 180;
            this.btn_7Carga.Text = "7";
            this.btn_7Carga.UseVisualStyleBackColor = false;
            this.btn_7Carga.Click += new System.EventHandler(this.btn_7Carga_Click);
            // 
            // lblKeyboard_Carga
            // 
            this.lblKeyboard_Carga.BackColor = System.Drawing.Color.Transparent;
            this.lblKeyboard_Carga.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKeyboard_Carga.ForeColor = System.Drawing.Color.Indigo;
            this.lblKeyboard_Carga.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.lblKeyboard_Carga.Location = new System.Drawing.Point(850, 210);
            this.lblKeyboard_Carga.Name = "lblKeyboard_Carga";
            this.lblKeyboard_Carga.Size = new System.Drawing.Size(353, 82);
            this.lblKeyboard_Carga.TabIndex = 165;
            this.lblKeyboard_Carga.Text = "123";
            this.lblKeyboard_Carga.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // grvCargaActualMonedas
            // 
            this.grvCargaActualMonedas.AllowUserToAddRows = false;
            this.grvCargaActualMonedas.AllowUserToDeleteRows = false;
            this.grvCargaActualMonedas.AllowUserToResizeColumns = false;
            this.grvCargaActualMonedas.AllowUserToResizeRows = false;
            dataGridViewCellStyle311.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.grvCargaActualMonedas.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle311;
            this.grvCargaActualMonedas.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle312.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle312.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle312.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle312.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle312.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle312.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle312.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grvCargaActualMonedas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle312;
            this.grvCargaActualMonedas.ColumnHeadersHeight = 22;
            this.grvCargaActualMonedas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle313.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle313.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle313.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle313.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle313.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle313.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle313.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grvCargaActualMonedas.DefaultCellStyle = dataGridViewCellStyle313;
            this.grvCargaActualMonedas.Location = new System.Drawing.Point(43, 759);
            this.grvCargaActualMonedas.MultiSelect = false;
            this.grvCargaActualMonedas.Name = "grvCargaActualMonedas";
            this.grvCargaActualMonedas.ReadOnly = true;
            dataGridViewCellStyle314.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle314.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle314.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle314.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle314.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle314.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle314.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grvCargaActualMonedas.RowHeadersDefaultCellStyle = dataGridViewCellStyle314;
            this.grvCargaActualMonedas.RowHeadersVisible = false;
            this.grvCargaActualMonedas.RowHeadersWidth = 25;
            this.grvCargaActualMonedas.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle315.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.grvCargaActualMonedas.RowsDefaultCellStyle = dataGridViewCellStyle315;
            this.grvCargaActualMonedas.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.grvCargaActualMonedas.Size = new System.Drawing.Size(326, 108);
            this.grvCargaActualMonedas.TabIndex = 154;
            // 
            // grvCargaTotalMonedas
            // 
            this.grvCargaTotalMonedas.AllowUserToAddRows = false;
            this.grvCargaTotalMonedas.AllowUserToDeleteRows = false;
            this.grvCargaTotalMonedas.AllowUserToResizeColumns = false;
            this.grvCargaTotalMonedas.AllowUserToResizeRows = false;
            dataGridViewCellStyle316.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.grvCargaTotalMonedas.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle316;
            this.grvCargaTotalMonedas.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle317.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle317.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle317.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle317.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle317.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle317.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle317.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grvCargaTotalMonedas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle317;
            this.grvCargaTotalMonedas.ColumnHeadersHeight = 22;
            this.grvCargaTotalMonedas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle318.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle318.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle318.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle318.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle318.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle318.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle318.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grvCargaTotalMonedas.DefaultCellStyle = dataGridViewCellStyle318;
            this.grvCargaTotalMonedas.Location = new System.Drawing.Point(429, 759);
            this.grvCargaTotalMonedas.Name = "grvCargaTotalMonedas";
            this.grvCargaTotalMonedas.ReadOnly = true;
            dataGridViewCellStyle319.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle319.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle319.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle319.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle319.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle319.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle319.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grvCargaTotalMonedas.RowHeadersDefaultCellStyle = dataGridViewCellStyle319;
            this.grvCargaTotalMonedas.RowHeadersVisible = false;
            this.grvCargaTotalMonedas.RowHeadersWidth = 25;
            this.grvCargaTotalMonedas.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle320.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.grvCargaTotalMonedas.RowsDefaultCellStyle = dataGridViewCellStyle320;
            this.grvCargaTotalMonedas.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.grvCargaTotalMonedas.Size = new System.Drawing.Size(326, 108);
            this.grvCargaTotalMonedas.TabIndex = 153;
            // 
            // btnHopper2
            // 
            this.btnHopper2.AutoSize = true;
            this.btnHopper2.BackColor = System.Drawing.Color.Transparent;
            this.btnHopper2.FlatAppearance.BorderSize = 0;
            this.btnHopper2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnHopper2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnHopper2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHopper2.Location = new System.Drawing.Point(431, 297);
            this.btnHopper2.LockPush = true;
            this.btnHopper2.Name = "btnHopper2";
            this.btnHopper2.Size = new System.Drawing.Size(222, 85);
            this.btnHopper2.TabIndex = 150;
            this.btnHopper2.Text = "Hopper2";
            this.btnHopper2.UseVisualStyleBackColor = false;
            this.btnHopper2.Click += new System.EventHandler(this.btnHopper2_Click);
            // 
            // btnHopper1
            // 
            this.btnHopper1.AutoSize = true;
            this.btnHopper1.BackColor = System.Drawing.Color.Transparent;
            this.btnHopper1.FlatAppearance.BorderSize = 0;
            this.btnHopper1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnHopper1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnHopper1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHopper1.Location = new System.Drawing.Point(142, 297);
            this.btnHopper1.LockPush = true;
            this.btnHopper1.Name = "btnHopper1";
            this.btnHopper1.Size = new System.Drawing.Size(222, 85);
            this.btnHopper1.TabIndex = 149;
            this.btnHopper1.Text = "Hopper1";
            this.btnHopper1.UseVisualStyleBackColor = false;
            this.btnHopper1.Click += new System.EventHandler(this.btnHopper1_Click);
            // 
            // tabMenuSistemas
            // 
            this.tabMenuSistemas.Controls.Add(this.Imagen_MenuSistema);
            this.tabMenuSistemas.Location = new System.Drawing.Point(4, 22);
            this.tabMenuSistemas.Name = "tabMenuSistemas";
            this.tabMenuSistemas.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tabMenuSistemas.Size = new System.Drawing.Size(1270, 852);
            this.tabMenuSistemas.TabIndex = 17;
            this.tabMenuSistemas.Text = "MenuSistemas";
            this.tabMenuSistemas.UseVisualStyleBackColor = true;
            // 
            // Imagen_MenuSistema
            // 
            this.Imagen_MenuSistema.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Imagen_MenuSistema.Controls.Add(this.lblFechaActual);
            this.Imagen_MenuSistema.Controls.Add(this.btn_Carga);
            this.Imagen_MenuSistema.Controls.Add(this.btn_Salir);
            this.Imagen_MenuSistema.Controls.Add(this.btn_Iniciar);
            this.Imagen_MenuSistema.Controls.Add(this.btn_Mantenimiento);
            this.Imagen_MenuSistema.Controls.Add(this.btn_Log);
            this.Imagen_MenuSistema.Controls.Add(this.btn_Arqueo);
            this.Imagen_MenuSistema.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Imagen_MenuSistema.Location = new System.Drawing.Point(3, 3);
            this.Imagen_MenuSistema.Name = "Imagen_MenuSistema";
            this.Imagen_MenuSistema.Size = new System.Drawing.Size(1264, 846);
            this.Imagen_MenuSistema.TabIndex = 5019;
            // 
            // lblFechaActual
            // 
            this.lblFechaActual.AutoSize = true;
            this.lblFechaActual.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaActual.ForeColor = System.Drawing.Color.White;
            this.lblFechaActual.Location = new System.Drawing.Point(46, 899);
            this.lblFechaActual.Name = "lblFechaActual";
            this.lblFechaActual.Size = new System.Drawing.Size(383, 46);
            this.lblFechaActual.TabIndex = 1167;
            this.lblFechaActual.Text = "2019/01/30 12:53:50";
            // 
            // btn_Carga
            // 
            this.btn_Carga.AutoSize = true;
            this.btn_Carga.BackColor = System.Drawing.Color.Transparent;
            this.btn_Carga.FlatAppearance.BorderSize = 0;
            this.btn_Carga.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_Carga.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_Carga.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Carga.Location = new System.Drawing.Point(469, 308);
            this.btn_Carga.LockPush = true;
            this.btn_Carga.Name = "btn_Carga";
            this.btn_Carga.Size = new System.Drawing.Size(220, 220);
            this.btn_Carga.TabIndex = 1142;
            this.btn_Carga.Text = "CARGA";
            this.btn_Carga.UseVisualStyleBackColor = false;
            this.btn_Carga.Click += new System.EventHandler(this.btn_Carga_Click);
            // 
            // btn_Salir
            // 
            this.btn_Salir.AutoSize = true;
            this.btn_Salir.BackColor = System.Drawing.Color.Transparent;
            this.btn_Salir.FlatAppearance.BorderSize = 0;
            this.btn_Salir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_Salir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_Salir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Salir.Location = new System.Drawing.Point(1087, 12);
            this.btn_Salir.LockPush = true;
            this.btn_Salir.Name = "btn_Salir";
            this.btn_Salir.Size = new System.Drawing.Size(181, 152);
            this.btn_Salir.TabIndex = 1137;
            this.btn_Salir.Text = "SALIR";
            this.btn_Salir.UseVisualStyleBackColor = false;
            this.btn_Salir.Click += new System.EventHandler(this.btn_Salir_Click);
            // 
            // btn_Iniciar
            // 
            this.btn_Iniciar.AutoSize = true;
            this.btn_Iniciar.BackColor = System.Drawing.Color.Transparent;
            this.btn_Iniciar.FlatAppearance.BorderSize = 0;
            this.btn_Iniciar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_Iniciar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_Iniciar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Iniciar.Location = new System.Drawing.Point(872, 308);
            this.btn_Iniciar.LockPush = true;
            this.btn_Iniciar.Name = "btn_Iniciar";
            this.btn_Iniciar.Size = new System.Drawing.Size(220, 220);
            this.btn_Iniciar.TabIndex = 1136;
            this.btn_Iniciar.Text = "INICIAR";
            this.btn_Iniciar.UseVisualStyleBackColor = false;
            this.btn_Iniciar.Click += new System.EventHandler(this.btn_Iniciar_Click);
            // 
            // btn_Mantenimiento
            // 
            this.btn_Mantenimiento.AutoSize = true;
            this.btn_Mantenimiento.BackColor = System.Drawing.Color.Transparent;
            this.btn_Mantenimiento.FlatAppearance.BorderSize = 0;
            this.btn_Mantenimiento.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_Mantenimiento.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_Mantenimiento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Mantenimiento.Location = new System.Drawing.Point(246, 611);
            this.btn_Mantenimiento.LockPush = true;
            this.btn_Mantenimiento.Name = "btn_Mantenimiento";
            this.btn_Mantenimiento.Size = new System.Drawing.Size(220, 220);
            this.btn_Mantenimiento.TabIndex = 1135;
            this.btn_Mantenimiento.Text = "MANTENIMIENTO";
            this.btn_Mantenimiento.UseVisualStyleBackColor = false;
            this.btn_Mantenimiento.Click += new System.EventHandler(this.btn_Mantenimiento_Click);
            // 
            // btn_Log
            // 
            this.btn_Log.AutoSize = true;
            this.btn_Log.BackColor = System.Drawing.Color.Transparent;
            this.btn_Log.FlatAppearance.BorderSize = 0;
            this.btn_Log.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_Log.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_Log.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Log.Location = new System.Drawing.Point(707, 611);
            this.btn_Log.LockPush = true;
            this.btn_Log.Name = "btn_Log";
            this.btn_Log.Size = new System.Drawing.Size(220, 220);
            this.btn_Log.TabIndex = 1134;
            this.btn_Log.Text = "LOG";
            this.btn_Log.UseVisualStyleBackColor = false;
            this.btn_Log.Click += new System.EventHandler(this.btn_Log_Click);
            // 
            // btn_Arqueo
            // 
            this.btn_Arqueo.AutoSize = true;
            this.btn_Arqueo.BackColor = System.Drawing.Color.Transparent;
            this.btn_Arqueo.FlatAppearance.BorderSize = 0;
            this.btn_Arqueo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_Arqueo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_Arqueo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Arqueo.Location = new System.Drawing.Point(91, 308);
            this.btn_Arqueo.LockPush = true;
            this.btn_Arqueo.Name = "btn_Arqueo";
            this.btn_Arqueo.Size = new System.Drawing.Size(220, 220);
            this.btn_Arqueo.TabIndex = 1133;
            this.btn_Arqueo.Text = "ARQUEO";
            this.btn_Arqueo.UseVisualStyleBackColor = false;
            this.btn_Arqueo.Click += new System.EventHandler(this.btn_Arqueo_Click);
            // 
            // tabCerrarOperacion
            // 
            this.tabCerrarOperacion.Controls.Add(this.Imagen_CerrarOperacion);
            this.tabCerrarOperacion.Location = new System.Drawing.Point(4, 22);
            this.tabCerrarOperacion.Name = "tabCerrarOperacion";
            this.tabCerrarOperacion.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tabCerrarOperacion.Size = new System.Drawing.Size(1270, 852);
            this.tabCerrarOperacion.TabIndex = 44;
            this.tabCerrarOperacion.Text = "CerrarOperacion";
            this.tabCerrarOperacion.UseVisualStyleBackColor = true;
            // 
            // Imagen_CerrarOperacion
            // 
            this.Imagen_CerrarOperacion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Imagen_CerrarOperacion.Controls.Add(this.pPublicidadCerrar);
            this.Imagen_CerrarOperacion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Imagen_CerrarOperacion.Location = new System.Drawing.Point(3, 3);
            this.Imagen_CerrarOperacion.Name = "Imagen_CerrarOperacion";
            this.Imagen_CerrarOperacion.Size = new System.Drawing.Size(1264, 846);
            this.Imagen_CerrarOperacion.TabIndex = 5021;
            // 
            // pPublicidadCerrar
            // 
            this.pPublicidadCerrar.Location = new System.Drawing.Point(3, 3);
            this.pPublicidadCerrar.Name = "pPublicidadCerrar";
            this.pPublicidadCerrar.Size = new System.Drawing.Size(696, 1014);
            this.pPublicidadCerrar.TabIndex = 5024;
            // 
            // tabSistemaSuspendido
            // 
            this.tabSistemaSuspendido.Controls.Add(this.Imagen_SistemaSupendido);
            this.tabSistemaSuspendido.Location = new System.Drawing.Point(4, 22);
            this.tabSistemaSuspendido.Name = "tabSistemaSuspendido";
            this.tabSistemaSuspendido.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tabSistemaSuspendido.Size = new System.Drawing.Size(1270, 852);
            this.tabSistemaSuspendido.TabIndex = 48;
            this.tabSistemaSuspendido.Text = "SistemaSuspendido";
            this.tabSistemaSuspendido.UseVisualStyleBackColor = true;
            // 
            // Imagen_SistemaSupendido
            // 
            this.Imagen_SistemaSupendido.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Imagen_SistemaSupendido.Controls.Add(this.pPublicidadSuspendido);
            this.Imagen_SistemaSupendido.Controls.Add(this.CapaSuspendidoCaleto);
            this.Imagen_SistemaSupendido.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Imagen_SistemaSupendido.Location = new System.Drawing.Point(3, 3);
            this.Imagen_SistemaSupendido.Name = "Imagen_SistemaSupendido";
            this.Imagen_SistemaSupendido.Size = new System.Drawing.Size(1264, 846);
            this.Imagen_SistemaSupendido.TabIndex = 5021;
            // 
            // pPublicidadSuspendido
            // 
            this.pPublicidadSuspendido.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pPublicidadSuspendido.Location = new System.Drawing.Point(5, 0);
            this.pPublicidadSuspendido.Name = "pPublicidadSuspendido";
            this.pPublicidadSuspendido.Size = new System.Drawing.Size(1258, 417);
            this.pPublicidadSuspendido.TabIndex = 5024;
            // 
            // CapaSuspendidoCaleto
            // 
            this.CapaSuspendidoCaleto.Location = new System.Drawing.Point(525, 928);
            this.CapaSuspendidoCaleto.Name = "CapaSuspendidoCaleto";
            this.CapaSuspendidoCaleto.Size = new System.Drawing.Size(145, 79);
            this.CapaSuspendidoCaleto.TabIndex = 5022;
            this.CapaSuspendidoCaleto.Text = "CAPA";
            this.CapaSuspendidoCaleto.Click += new System.EventHandler(this.CapaSuspendidoCaleto_Click);
            // 
            // tabTarjetaInvalida
            // 
            this.tabTarjetaInvalida.Controls.Add(this.Imagen_TarjetaInvalida);
            this.tabTarjetaInvalida.Location = new System.Drawing.Point(4, 22);
            this.tabTarjetaInvalida.Name = "tabTarjetaInvalida";
            this.tabTarjetaInvalida.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tabTarjetaInvalida.Size = new System.Drawing.Size(1270, 852);
            this.tabTarjetaInvalida.TabIndex = 58;
            this.tabTarjetaInvalida.Text = "TarjetaInvalida";
            this.tabTarjetaInvalida.UseVisualStyleBackColor = true;
            // 
            // Imagen_TarjetaInvalida
            // 
            this.Imagen_TarjetaInvalida.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Imagen_TarjetaInvalida.Controls.Add(this.pPublicidadInvalida);
            this.Imagen_TarjetaInvalida.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Imagen_TarjetaInvalida.Location = new System.Drawing.Point(3, 3);
            this.Imagen_TarjetaInvalida.Name = "Imagen_TarjetaInvalida";
            this.Imagen_TarjetaInvalida.Size = new System.Drawing.Size(1264, 846);
            this.Imagen_TarjetaInvalida.TabIndex = 5022;
            // 
            // pPublicidadInvalida
            // 
            this.pPublicidadInvalida.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pPublicidadInvalida.Location = new System.Drawing.Point(5, 0);
            this.pPublicidadInvalida.Name = "pPublicidadInvalida";
            this.pPublicidadInvalida.Size = new System.Drawing.Size(1258, 417);
            this.pPublicidadInvalida.TabIndex = 5023;
            // 
            // tabArqueoParcial
            // 
            this.tabArqueoParcial.Controls.Add(this.Imagen_ArqueoParcial);
            this.tabArqueoParcial.Location = new System.Drawing.Point(4, 22);
            this.tabArqueoParcial.Name = "tabArqueoParcial";
            this.tabArqueoParcial.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tabArqueoParcial.Size = new System.Drawing.Size(1270, 852);
            this.tabArqueoParcial.TabIndex = 62;
            this.tabArqueoParcial.Text = "ArqueoParcial";
            this.tabArqueoParcial.UseVisualStyleBackColor = true;
            // 
            // Imagen_ArqueoParcial
            // 
            this.Imagen_ArqueoParcial.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Imagen_ArqueoParcial.Controls.Add(this.Animacion_RetireBox);
            this.Imagen_ArqueoParcial.Controls.Add(this.btn_ConfirmarArqueo);
            this.Imagen_ArqueoParcial.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Imagen_ArqueoParcial.Location = new System.Drawing.Point(3, 3);
            this.Imagen_ArqueoParcial.Name = "Imagen_ArqueoParcial";
            this.Imagen_ArqueoParcial.Size = new System.Drawing.Size(1264, 846);
            this.Imagen_ArqueoParcial.TabIndex = 5021;
            // 
            // Animacion_RetireBox
            // 
            this.Animacion_RetireBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Animacion_RetireBox.Location = new System.Drawing.Point(59, 283);
            this.Animacion_RetireBox.Name = "Animacion_RetireBox";
            this.Animacion_RetireBox.Size = new System.Drawing.Size(1041, 551);
            this.Animacion_RetireBox.TabIndex = 5027;
            this.Animacion_RetireBox.TabStop = false;
            // 
            // btn_ConfirmarArqueo
            // 
            this.btn_ConfirmarArqueo.AutoSize = true;
            this.btn_ConfirmarArqueo.BackColor = System.Drawing.Color.Transparent;
            this.btn_ConfirmarArqueo.FlatAppearance.BorderSize = 0;
            this.btn_ConfirmarArqueo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_ConfirmarArqueo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_ConfirmarArqueo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ConfirmarArqueo.Location = new System.Drawing.Point(953, 711);
            this.btn_ConfirmarArqueo.LockPush = true;
            this.btn_ConfirmarArqueo.Name = "btn_ConfirmarArqueo";
            this.btn_ConfirmarArqueo.Size = new System.Drawing.Size(181, 152);
            this.btn_ConfirmarArqueo.TabIndex = 1134;
            this.btn_ConfirmarArqueo.Text = "VOLVER";
            this.btn_ConfirmarArqueo.UseVisualStyleBackColor = false;
            this.btn_ConfirmarArqueo.Click += new System.EventHandler(this.btn_ConfirmarArqueo_Click);
            // 
            // tabArqueoTotal
            // 
            this.tabArqueoTotal.Controls.Add(this.Imagen_ArqueoTotal);
            this.tabArqueoTotal.Location = new System.Drawing.Point(4, 22);
            this.tabArqueoTotal.Name = "tabArqueoTotal";
            this.tabArqueoTotal.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tabArqueoTotal.Size = new System.Drawing.Size(1270, 852);
            this.tabArqueoTotal.TabIndex = 63;
            this.tabArqueoTotal.Text = "ArqueoTotal";
            this.tabArqueoTotal.UseVisualStyleBackColor = true;
            // 
            // Imagen_ArqueoTotal
            // 
            this.Imagen_ArqueoTotal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Imagen_ArqueoTotal.Controls.Add(this.AnimacionBoxTotal);
            this.Imagen_ArqueoTotal.Controls.Add(this.btn_ConfirmarArqueoTotal);
            this.Imagen_ArqueoTotal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Imagen_ArqueoTotal.Location = new System.Drawing.Point(3, 3);
            this.Imagen_ArqueoTotal.Name = "Imagen_ArqueoTotal";
            this.Imagen_ArqueoTotal.Size = new System.Drawing.Size(1264, 846);
            this.Imagen_ArqueoTotal.TabIndex = 5022;
            // 
            // AnimacionBoxTotal
            // 
            this.AnimacionBoxTotal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.AnimacionBoxTotal.Location = new System.Drawing.Point(59, 283);
            this.AnimacionBoxTotal.Name = "AnimacionBoxTotal";
            this.AnimacionBoxTotal.Size = new System.Drawing.Size(654, 551);
            this.AnimacionBoxTotal.TabIndex = 5028;
            this.AnimacionBoxTotal.TabStop = false;
            // 
            // btn_ConfirmarArqueoTotal
            // 
            this.btn_ConfirmarArqueoTotal.AutoSize = true;
            this.btn_ConfirmarArqueoTotal.BackColor = System.Drawing.Color.Transparent;
            this.btn_ConfirmarArqueoTotal.FlatAppearance.BorderSize = 0;
            this.btn_ConfirmarArqueoTotal.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_ConfirmarArqueoTotal.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_ConfirmarArqueoTotal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ConfirmarArqueoTotal.Location = new System.Drawing.Point(953, 711);
            this.btn_ConfirmarArqueoTotal.LockPush = true;
            this.btn_ConfirmarArqueoTotal.Name = "btn_ConfirmarArqueoTotal";
            this.btn_ConfirmarArqueoTotal.Size = new System.Drawing.Size(181, 152);
            this.btn_ConfirmarArqueoTotal.TabIndex = 1134;
            this.btn_ConfirmarArqueoTotal.Text = "VOLVER";
            this.btn_ConfirmarArqueoTotal.UseVisualStyleBackColor = false;
            this.btn_ConfirmarArqueoTotal.Click += new System.EventHandler(this.btn_ConfirmarArqueoTotal_Click);
            // 
            // tabDescargando
            // 
            this.tabDescargando.Controls.Add(this.Imagen_Descargando);
            this.tabDescargando.Location = new System.Drawing.Point(4, 22);
            this.tabDescargando.Name = "tabDescargando";
            this.tabDescargando.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tabDescargando.Size = new System.Drawing.Size(1270, 852);
            this.tabDescargando.TabIndex = 64;
            this.tabDescargando.Text = "Descargando";
            this.tabDescargando.UseVisualStyleBackColor = true;
            // 
            // Imagen_Descargando
            // 
            this.Imagen_Descargando.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Imagen_Descargando.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Imagen_Descargando.Location = new System.Drawing.Point(3, 3);
            this.Imagen_Descargando.Name = "Imagen_Descargando";
            this.Imagen_Descargando.Size = new System.Drawing.Size(1264, 846);
            this.Imagen_Descargando.TabIndex = 5023;
            // 
            // pInicio
            // 
            this.pInicio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pInicio.Location = new System.Drawing.Point(158, 462);
            this.pInicio.Name = "pInicio";
            this.pInicio.Size = new System.Drawing.Size(804, 512);
            this.pInicio.TabIndex = 2;
            this.pInicio.TabStop = false;
            // 
            // Imagen_Inicio
            // 
            this.Imagen_Inicio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Imagen_Inicio.Controls.Add(this.pInicio);
            this.Imagen_Inicio.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Imagen_Inicio.Location = new System.Drawing.Point(3, 3);
            this.Imagen_Inicio.Name = "Imagen_Inicio";
            this.Imagen_Inicio.Size = new System.Drawing.Size(1264, 846);
            this.Imagen_Inicio.TabIndex = 5020;
            // 
            // Imagen_Principal
            // 
            this.Imagen_Principal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Imagen_Principal.Controls.Add(this.btn_InserteTarjeta);
            this.Imagen_Principal.Controls.Add(this.btn_Placa);
            this.Imagen_Principal.Controls.Add(this.Animacion_InserteTarjeta);
            this.Imagen_Principal.Controls.Add(this.pPublicidad);
            this.Imagen_Principal.Controls.Add(this.CapaMenuPrincipal);
            this.Imagen_Principal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Imagen_Principal.Location = new System.Drawing.Point(3, 3);
            this.Imagen_Principal.Name = "Imagen_Principal";
            this.Imagen_Principal.Size = new System.Drawing.Size(1264, 846);
            this.Imagen_Principal.TabIndex = 5022;
            // 
            // btn_InserteTarjeta
            // 
            this.btn_InserteTarjeta.AutoSize = true;
            this.btn_InserteTarjeta.BackColor = System.Drawing.Color.Transparent;
            this.btn_InserteTarjeta.FlatAppearance.BorderSize = 0;
            this.btn_InserteTarjeta.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_InserteTarjeta.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_InserteTarjeta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_InserteTarjeta.Location = new System.Drawing.Point(747, 664);
            this.btn_InserteTarjeta.LockPush = true;
            this.btn_InserteTarjeta.Name = "btn_InserteTarjeta";
            this.btn_InserteTarjeta.Size = new System.Drawing.Size(176, 66);
            this.btn_InserteTarjeta.TabIndex = 5029;
            this.btn_InserteTarjeta.Text = "PLACA";
            this.btn_InserteTarjeta.UseVisualStyleBackColor = false;
            this.btn_InserteTarjeta.Click += new System.EventHandler(this.btn_InserteTarjeta_Click);
            // 
            // btn_Placa
            // 
            this.btn_Placa.AutoSize = true;
            this.btn_Placa.BackColor = System.Drawing.Color.Transparent;
            this.btn_Placa.FlatAppearance.BorderSize = 0;
            this.btn_Placa.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_Placa.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_Placa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Placa.Location = new System.Drawing.Point(161, 664);
            this.btn_Placa.LockPush = true;
            this.btn_Placa.Name = "btn_Placa";
            this.btn_Placa.Size = new System.Drawing.Size(176, 66);
            this.btn_Placa.TabIndex = 5028;
            this.btn_Placa.Text = "PLACA";
            this.btn_Placa.UseVisualStyleBackColor = false;
            this.btn_Placa.Click += new System.EventHandler(this.btn_Placa_Click);
            // 
            // Animacion_InserteTarjeta
            // 
            this.Animacion_InserteTarjeta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Animacion_InserteTarjeta.Location = new System.Drawing.Point(3, 413);
            this.Animacion_InserteTarjeta.Name = "Animacion_InserteTarjeta";
            this.Animacion_InserteTarjeta.Size = new System.Drawing.Size(44, 27);
            this.Animacion_InserteTarjeta.TabIndex = 5026;
            this.Animacion_InserteTarjeta.TabStop = false;
            // 
            // pPublicidad
            // 
            this.pPublicidad.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pPublicidad.Location = new System.Drawing.Point(5, 0);
            this.pPublicidad.Name = "pPublicidad";
            this.pPublicidad.Size = new System.Drawing.Size(1258, 417);
            this.pPublicidad.TabIndex = 5024;
            this.pPublicidad.TabStop = false;
            // 
            // CapaMenuPrincipal
            // 
            this.CapaMenuPrincipal.Location = new System.Drawing.Point(408, 900);
            this.CapaMenuPrincipal.Name = "CapaMenuPrincipal";
            this.CapaMenuPrincipal.Size = new System.Drawing.Size(145, 79);
            this.CapaMenuPrincipal.TabIndex = 5023;
            this.CapaMenuPrincipal.Text = "CAPA";
            // 
            // tabTarjetaVisitante
            // 
            this.tabTarjetaVisitante.Controls.Add(this.Imagen_TarjetaVisitante);
            this.tabTarjetaVisitante.Location = new System.Drawing.Point(4, 22);
            this.tabTarjetaVisitante.Name = "tabTarjetaVisitante";
            this.tabTarjetaVisitante.Size = new System.Drawing.Size(1270, 852);
            this.tabTarjetaVisitante.TabIndex = 78;
            this.tabTarjetaVisitante.Text = "TarjetaVisitante";
            this.tabTarjetaVisitante.UseVisualStyleBackColor = true;
            // 
            // Imagen_TarjetaVisitante
            // 
            this.Imagen_TarjetaVisitante.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Imagen_TarjetaVisitante.Controls.Add(this.Animacion_Inserte);
            this.Imagen_TarjetaVisitante.Controls.Add(this.pictureBox2);
            this.Imagen_TarjetaVisitante.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Imagen_TarjetaVisitante.Location = new System.Drawing.Point(0, 0);
            this.Imagen_TarjetaVisitante.Name = "Imagen_TarjetaVisitante";
            this.Imagen_TarjetaVisitante.Size = new System.Drawing.Size(1270, 852);
            this.Imagen_TarjetaVisitante.TabIndex = 5029;
            // 
            // Animacion_Inserte
            // 
            this.Animacion_Inserte.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Animacion_Inserte.Location = new System.Drawing.Point(121, 384);
            this.Animacion_Inserte.Name = "Animacion_Inserte";
            this.Animacion_Inserte.Size = new System.Drawing.Size(918, 512);
            this.Animacion_Inserte.TabIndex = 5027;
            this.Animacion_Inserte.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(-4, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(1293, 417);
            this.pictureBox2.TabIndex = 5025;
            this.pictureBox2.TabStop = false;
            // 
            // tabDigitePlaca
            // 
            this.tabDigitePlaca.Controls.Add(this.Imagen_DigitePlaca);
            this.tabDigitePlaca.Location = new System.Drawing.Point(4, 22);
            this.tabDigitePlaca.Name = "tabDigitePlaca";
            this.tabDigitePlaca.Size = new System.Drawing.Size(1270, 852);
            this.tabDigitePlaca.TabIndex = 79;
            this.tabDigitePlaca.Text = "DigitePlaca";
            this.tabDigitePlaca.UseVisualStyleBackColor = true;
            // 
            // Imagen_DigitePlaca
            // 
            this.Imagen_DigitePlaca.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Imagen_DigitePlaca.Controls.Add(this.lblPlaca);
            this.Imagen_DigitePlaca.Controls.Add(this.kbPlaca);
            this.Imagen_DigitePlaca.Controls.Add(this.btn_AceptarPlaca);
            this.Imagen_DigitePlaca.Controls.Add(this.btn_CancelarPlaca);
            this.Imagen_DigitePlaca.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Imagen_DigitePlaca.Location = new System.Drawing.Point(0, 0);
            this.Imagen_DigitePlaca.Name = "Imagen_DigitePlaca";
            this.Imagen_DigitePlaca.Size = new System.Drawing.Size(1270, 852);
            this.Imagen_DigitePlaca.TabIndex = 5076;
            // 
            // btn_AceptarPlaca
            // 
            this.btn_AceptarPlaca.AutoSize = true;
            this.btn_AceptarPlaca.BackColor = System.Drawing.Color.Transparent;
            this.btn_AceptarPlaca.FlatAppearance.BorderSize = 0;
            this.btn_AceptarPlaca.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_AceptarPlaca.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_AceptarPlaca.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_AceptarPlaca.Location = new System.Drawing.Point(1073, 108);
            this.btn_AceptarPlaca.LockPush = true;
            this.btn_AceptarPlaca.Name = "btn_AceptarPlaca";
            this.btn_AceptarPlaca.Size = new System.Drawing.Size(88, 95);
            this.btn_AceptarPlaca.TabIndex = 5071;
            this.btn_AceptarPlaca.Text = "Aceptar";
            this.btn_AceptarPlaca.UseVisualStyleBackColor = false;
            this.btn_AceptarPlaca.Click += new System.EventHandler(this.btn_AceptarPlaca_Click);
            // 
            // btn_CancelarPlaca
            // 
            this.btn_CancelarPlaca.AutoSize = true;
            this.btn_CancelarPlaca.BackColor = System.Drawing.Color.Transparent;
            this.btn_CancelarPlaca.FlatAppearance.BorderSize = 0;
            this.btn_CancelarPlaca.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_CancelarPlaca.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_CancelarPlaca.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_CancelarPlaca.Location = new System.Drawing.Point(60, 126);
            this.btn_CancelarPlaca.LockPush = true;
            this.btn_CancelarPlaca.Name = "btn_CancelarPlaca";
            this.btn_CancelarPlaca.Size = new System.Drawing.Size(88, 95);
            this.btn_CancelarPlaca.TabIndex = 5072;
            this.btn_CancelarPlaca.Text = "Cancelar";
            this.btn_CancelarPlaca.UseVisualStyleBackColor = false;
            this.btn_CancelarPlaca.Click += new System.EventHandler(this.btn_CancelarPlaca_Click);
            // 
            // lblPlaca
            // 
            this.lblPlaca.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(222)))), ((int)(((byte)(98)))));
            this.lblPlaca.Font = new System.Drawing.Font("Microsoft Sans Serif", 60F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.lblPlaca.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblPlaca.Location = new System.Drawing.Point(401, 108);
            this.lblPlaca.Name = "lblPlaca";
            this.lblPlaca.Size = new System.Drawing.Size(447, 102);
            this.lblPlaca.TabIndex = 5074;
            this.lblPlaca.Text = "ABC123";
            this.lblPlaca.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // kbPlaca
            // 
            this.kbPlaca.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.kbPlaca.BackColor = System.Drawing.Color.White;
            virtualKeyboardColorTable32.BackgroundColor = System.Drawing.Color.Black;
            virtualKeyboardColorTable32.DarkKeysColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(28)))), ((int)(((byte)(33)))));
            virtualKeyboardColorTable32.DownKeysColor = System.Drawing.Color.White;
            virtualKeyboardColorTable32.DownTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            virtualKeyboardColorTable32.KeysColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(47)))), ((int)(((byte)(55)))));
            virtualKeyboardColorTable32.LightKeysColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(68)))), ((int)(((byte)(76)))));
            virtualKeyboardColorTable32.PressedKeysColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(161)))), ((int)(((byte)(81)))));
            virtualKeyboardColorTable32.TextColor = System.Drawing.Color.White;
            virtualKeyboardColorTable32.ToggleTextColor = System.Drawing.Color.Green;
            virtualKeyboardColorTable32.TopBarTextColor = System.Drawing.Color.White;
            this.kbPlaca.ColorTable = virtualKeyboardColorTable32;
            this.kbPlaca.ForeColor = System.Drawing.Color.White;
            this.kbPlaca.Location = new System.Drawing.Point(192, 255);
            this.kbPlaca.Name = "kbPlaca";
            flatStyleRenderer32.ColorTable = virtualKeyboardColorTable32;
            flatStyleRenderer32.ForceAntiAlias = false;
            this.kbPlaca.Renderer = flatStyleRenderer32;
            this.kbPlaca.Size = new System.Drawing.Size(848, 483);
            this.kbPlaca.TabIndex = 5075;
            // 
            // tabNoMensual
            // 
            this.tabNoMensual.Controls.Add(this.Imagen_NoMensual);
            this.tabNoMensual.Location = new System.Drawing.Point(4, 22);
            this.tabNoMensual.Name = "tabNoMensual";
            this.tabNoMensual.Size = new System.Drawing.Size(1270, 852);
            this.tabNoMensual.TabIndex = 80;
            this.tabNoMensual.Text = "NoMensual";
            this.tabNoMensual.UseVisualStyleBackColor = true;
            // 
            // Imagen_NoMensual
            // 
            this.Imagen_NoMensual.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Imagen_NoMensual.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Imagen_NoMensual.Location = new System.Drawing.Point(0, 0);
            this.Imagen_NoMensual.Name = "Imagen_NoMensual";
            this.Imagen_NoMensual.Size = new System.Drawing.Size(1270, 852);
            this.Imagen_NoMensual.TabIndex = 5026;
            // 
            // Imagen_TarjetaMensual
            // 
            this.Imagen_TarjetaMensual.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Imagen_TarjetaMensual.Controls.Add(this.btn_ConfirmarPagoMensualFE);
            this.Imagen_TarjetaMensual.Controls.Add(this.btn_AnularPagoMensualParcial);
            this.Imagen_TarjetaMensual.Controls.Add(this.btn_ConfirmarPagoMensual);
            this.Imagen_TarjetaMensual.Controls.Add(this.lblNombreAutoN);
            this.Imagen_TarjetaMensual.Controls.Add(this.lblValorPagarAutoN);
            this.Imagen_TarjetaMensual.Controls.Add(this.lblFechaFinAutoN);
            this.Imagen_TarjetaMensual.Controls.Add(this.pPublicidadMensul);
            this.Imagen_TarjetaMensual.Controls.Add(this.btn_SiMensual);
            this.Imagen_TarjetaMensual.Controls.Add(this.btn_NoMensual);
            this.Imagen_TarjetaMensual.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Imagen_TarjetaMensual.Location = new System.Drawing.Point(3, 3);
            this.Imagen_TarjetaMensual.Name = "Imagen_TarjetaMensual";
            this.Imagen_TarjetaMensual.Size = new System.Drawing.Size(1264, 846);
            this.Imagen_TarjetaMensual.TabIndex = 5025;
            // 
            // btn_ConfirmarPagoMensualFE
            // 
            this.btn_ConfirmarPagoMensualFE.AutoSize = true;
            this.btn_ConfirmarPagoMensualFE.BackColor = System.Drawing.Color.Transparent;
            this.btn_ConfirmarPagoMensualFE.FlatAppearance.BorderSize = 0;
            this.btn_ConfirmarPagoMensualFE.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_ConfirmarPagoMensualFE.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_ConfirmarPagoMensualFE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ConfirmarPagoMensualFE.Location = new System.Drawing.Point(650, 513);
            this.btn_ConfirmarPagoMensualFE.LockPush = true;
            this.btn_ConfirmarPagoMensualFE.Name = "btn_ConfirmarPagoMensualFE";
            this.btn_ConfirmarPagoMensualFE.Size = new System.Drawing.Size(240, 238);
            this.btn_ConfirmarPagoMensualFE.TabIndex = 5081;
            this.btn_ConfirmarPagoMensualFE.Text = "ConfirmarPagoFE";
            this.btn_ConfirmarPagoMensualFE.UseVisualStyleBackColor = false;
            this.btn_ConfirmarPagoMensualFE.Click += new System.EventHandler(this.btn_ConfirmarPagoMensualFE_Click);
            // 
            // btn_AnularPagoMensualParcial
            // 
            this.btn_AnularPagoMensualParcial.AutoSize = true;
            this.btn_AnularPagoMensualParcial.BackColor = System.Drawing.Color.Transparent;
            this.btn_AnularPagoMensualParcial.FlatAppearance.BorderSize = 0;
            this.btn_AnularPagoMensualParcial.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_AnularPagoMensualParcial.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_AnularPagoMensualParcial.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_AnularPagoMensualParcial.Location = new System.Drawing.Point(929, 513);
            this.btn_AnularPagoMensualParcial.LockPush = true;
            this.btn_AnularPagoMensualParcial.Name = "btn_AnularPagoMensualParcial";
            this.btn_AnularPagoMensualParcial.Size = new System.Drawing.Size(240, 238);
            this.btn_AnularPagoMensualParcial.TabIndex = 5080;
            this.btn_AnularPagoMensualParcial.Text = "ANULAR";
            this.btn_AnularPagoMensualParcial.UseVisualStyleBackColor = false;
            this.btn_AnularPagoMensualParcial.Click += new System.EventHandler(this.btn_AnularPagoMensualParcial_Click);
            // 
            // btn_ConfirmarPagoMensual
            // 
            this.btn_ConfirmarPagoMensual.AutoSize = true;
            this.btn_ConfirmarPagoMensual.BackColor = System.Drawing.Color.Transparent;
            this.btn_ConfirmarPagoMensual.FlatAppearance.BorderSize = 0;
            this.btn_ConfirmarPagoMensual.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_ConfirmarPagoMensual.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_ConfirmarPagoMensual.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ConfirmarPagoMensual.Location = new System.Drawing.Point(369, 513);
            this.btn_ConfirmarPagoMensual.LockPush = true;
            this.btn_ConfirmarPagoMensual.Name = "btn_ConfirmarPagoMensual";
            this.btn_ConfirmarPagoMensual.Size = new System.Drawing.Size(240, 238);
            this.btn_ConfirmarPagoMensual.TabIndex = 5079;
            this.btn_ConfirmarPagoMensual.Text = "ConfirmarPagoParcial";
            this.btn_ConfirmarPagoMensual.UseVisualStyleBackColor = false;
            this.btn_ConfirmarPagoMensual.Click += new System.EventHandler(this.btn_ConfirmarPagoMensual_Click);
            // 
            // lblNombreAutoN
            // 
            this.lblNombreAutoN.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreAutoN.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblNombreAutoN.Location = new System.Drawing.Point(66, 513);
            this.lblNombreAutoN.Name = "lblNombreAutoN";
            this.lblNombreAutoN.Size = new System.Drawing.Size(248, 99);
            this.lblNombreAutoN.TabIndex = 5027;
            this.lblNombreAutoN.Text = "JOHN HELLI HILLON DE LAS CASAS";
            this.lblNombreAutoN.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblValorPagarAutoN
            // 
            this.lblValorPagarAutoN.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblValorPagarAutoN.BackColor = System.Drawing.Color.Transparent;
            this.lblValorPagarAutoN.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValorPagarAutoN.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblValorPagarAutoN.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblValorPagarAutoN.Location = new System.Drawing.Point(133, 630);
            this.lblValorPagarAutoN.Name = "lblValorPagarAutoN";
            this.lblValorPagarAutoN.Size = new System.Drawing.Size(152, 60);
            this.lblValorPagarAutoN.TabIndex = 5028;
            this.lblValorPagarAutoN.Text = "$27.000";
            this.lblValorPagarAutoN.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblFechaFinAutoN
            // 
            this.lblFechaFinAutoN.BackColor = System.Drawing.Color.Transparent;
            this.lblFechaFinAutoN.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaFinAutoN.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblFechaFinAutoN.Location = new System.Drawing.Point(77, 854);
            this.lblFechaFinAutoN.Name = "lblFechaFinAutoN";
            this.lblFechaFinAutoN.Size = new System.Drawing.Size(215, 30);
            this.lblFechaFinAutoN.TabIndex = 5029;
            this.lblFechaFinAutoN.Text = "2020/10/30";
            this.lblFechaFinAutoN.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pPublicidadMensul
            // 
            this.pPublicidadMensul.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pPublicidadMensul.Location = new System.Drawing.Point(5, 0);
            this.pPublicidadMensul.Name = "pPublicidadMensul";
            this.pPublicidadMensul.Size = new System.Drawing.Size(1258, 417);
            this.pPublicidadMensul.TabIndex = 5026;
            // 
            // btn_SiMensual
            // 
            this.btn_SiMensual.AutoSize = true;
            this.btn_SiMensual.BackColor = System.Drawing.Color.Transparent;
            this.btn_SiMensual.FlatAppearance.BorderSize = 0;
            this.btn_SiMensual.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_SiMensual.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_SiMensual.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_SiMensual.Location = new System.Drawing.Point(294, 713);
            this.btn_SiMensual.LockPush = true;
            this.btn_SiMensual.Name = "btn_SiMensual";
            this.btn_SiMensual.Size = new System.Drawing.Size(143, 68);
            this.btn_SiMensual.TabIndex = 5025;
            this.btn_SiMensual.Text = "SI";
            this.btn_SiMensual.UseVisualStyleBackColor = false;
            this.btn_SiMensual.Visible = false;
            // 
            // btn_NoMensual
            // 
            this.btn_NoMensual.AutoSize = true;
            this.btn_NoMensual.BackColor = System.Drawing.Color.Transparent;
            this.btn_NoMensual.FlatAppearance.BorderSize = 0;
            this.btn_NoMensual.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_NoMensual.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_NoMensual.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_NoMensual.Location = new System.Drawing.Point(720, 713);
            this.btn_NoMensual.LockPush = true;
            this.btn_NoMensual.Name = "btn_NoMensual";
            this.btn_NoMensual.Size = new System.Drawing.Size(143, 68);
            this.btn_NoMensual.TabIndex = 1144;
            this.btn_NoMensual.Text = "NO";
            this.btn_NoMensual.UseVisualStyleBackColor = false;
            this.btn_NoMensual.Visible = false;
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.CausesValidation = false;
            this.ClientSize = new System.Drawing.Size(1278, 878);
            this.ControlBox = false;
            this.Controls.Add(this.TabControlPrincipal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmPrincipal";
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.frmPrincipal_KeyUp);
            this.TabControlPrincipal.ResumeLayout(false);
            this.tabInicio.ResumeLayout(false);
            this.tabPrincipal.ResumeLayout(false);
            this.tabProcesando.ResumeLayout(false);
            this.Imagen_Procesando.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pPublicidadProcesando)).EndInit();
            this.tabTarjetaMensual.ResumeLayout(false);
            this.tabSeleccionPago.ResumeLayout(false);
            this.Imagen_SeleccionPago.ResumeLayout(false);
            this.Imagen_SeleccionPago.PerformLayout();
            this.tabTipoCuenta.ResumeLayout(false);
            this.Imagen_TipoCuenta.ResumeLayout(false);
            this.Imagen_TipoCuenta.PerformLayout();
            this.tabDigiteCredito.ResumeLayout(false);
            this.Imagen_DigiteCredito.ResumeLayout(false);
            this.Imagen_DigiteCredito.PerformLayout();
            this.tabDetallePagoDatafono.ResumeLayout(false);
            this.Imagen_DetallePagoDatafono.ResumeLayout(false);
            this.Imagen_DetallePagoDatafono.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pPublicidadDetalleDatafono)).EndInit();
            this.tabDetallePago.ResumeLayout(false);
            this.Imagen_DetallePago.ResumeLayout(false);
            this.Imagen_DetallePago.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pPublicidadDetalle)).EndInit();
            this.tabInserteTarjetaDatafono.ResumeLayout(false);
            this.Imagen_InserteTarjetaDatafono.ResumeLayout(false);
            this.Imagen_InserteTarjetaDatafono.PerformLayout();
            this.tabNumeroCuotas.ResumeLayout(false);
            this.Imagen_NumeroCuotas.ResumeLayout(false);
            this.Imagen_NumeroCuotas.PerformLayout();
            this.tabConsultaFallida.ResumeLayout(false);
            this.Imagen_ConsultaFallida.ResumeLayout(false);
            this.Imagen_ConsultaFallida.PerformLayout();
            this.tabPuedeSalir.ResumeLayout(false);
            this.imagen_PuedeSalir.ResumeLayout(false);
            this.imagen_PuedeSalir.PerformLayout();
            this.tabPagoParcial.ResumeLayout(false);
            this.Imagen_PagoParcial.ResumeLayout(false);
            this.Imagen_PagoParcial.PerformLayout();
            this.tabNitCliente.ResumeLayout(false);
            this.Imagen_DigiteNitCliente.ResumeLayout(false);
            this.Panel_TecladoNitCliente.ResumeLayout(false);
            this.Panel_TecladoNitCliente.PerformLayout();
            this.tabAtasco.ResumeLayout(false);
            this.Imagen_Atasco.ResumeLayout(false);
            this.tabDetallePagoMensual.ResumeLayout(false);
            this.Imagen_DetallePagoMensual.ResumeLayout(false);
            this.Imagen_DetallePagoMensual.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pPublicidadPagoAuto)).EndInit();
            this.tabTransaccionCancelada.ResumeLayout(false);
            this.Imagen_TransaccionCancelada.ResumeLayout(false);
            this.tabTarjetaNoGeneraPago.ResumeLayout(false);
            this.Imagen_NoGeneraPago.ResumeLayout(false);
            this.tabTarjetaSinEntrada.ResumeLayout(false);
            this.Imagen_TarjetaSinEntrada.ResumeLayout(false);
            this.tabTransaccionCanceladaPago.ResumeLayout(false);
            this.Imagen_TransaccionCanceladaPago.ResumeLayout(false);
            this.tabPagoCelular.ResumeLayout(false);
            this.Imagen_PagoCelular.ResumeLayout(false);
            this.Imagen_PagoCelular.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pCelular)).EndInit();
            this.tabPagoEfectivo.ResumeLayout(false);
            this.Imagen_PagoEfectivo.ResumeLayout(false);
            this.Imagen_PagoEfectivo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pPagoEfectivo)).EndInit();
            this.tabPagoPrepago.ResumeLayout(false);
            this.Imagen_Prepago.ResumeLayout(false);
            this.Imagen_Prepago.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pPrepago)).EndInit();
            this.tabPagoDatafono.ResumeLayout(false);
            this.Imagen_PagoDatafono.ResumeLayout(false);
            this.Imagen_PagoDatafono.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pDatafono)).EndInit();
            this.tabImprimirFactura.ResumeLayout(false);
            this.Imagen_ImprimirFactura.ResumeLayout(false);
            this.Imagen_ImprimirFactura.PerformLayout();
            this.tabGraciasPago.ResumeLayout(false);
            this.Imagen_GraciasPago.ResumeLayout(false);
            this.tabContrasenaInvalida.ResumeLayout(false);
            this.tabIngresoPass.ResumeLayout(false);
            this.Imagen_IngresoPass.ResumeLayout(false);
            this.Imagen_IngresoPass.PerformLayout();
            this.tabSegundoPass.ResumeLayout(false);
            this.Imagen_SegundaPass.ResumeLayout(false);
            this.Imagen_SegundaPass.PerformLayout();
            this.tabMantenimiento.ResumeLayout(false);
            this.Imagen_Mantenimiento.ResumeLayout(false);
            this.tabArqueo.ResumeLayout(false);
            this.Imagen_Arqueo.ResumeLayout(false);
            this.Imagen_Arqueo.PerformLayout();
            this.tabCarga.ResumeLayout(false);
            this.Imagen_Carga.ResumeLayout(false);
            this.Imagen_Carga.PerformLayout();
            this.tabCargaBilletes.ResumeLayout(false);
            this.Imagen_CargaBilletes.ResumeLayout(false);
            this.Imagen_CargaBilletes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grvCargaActualBilletesF56)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvCargaTotalBilletesF56)).EndInit();
            this.tabCargaMonedas.ResumeLayout(false);
            this.Imagen_CargaMonedas.ResumeLayout(false);
            this.Imagen_CargaMonedas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grvCargaActualMonedas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvCargaTotalMonedas)).EndInit();
            this.tabMenuSistemas.ResumeLayout(false);
            this.Imagen_MenuSistema.ResumeLayout(false);
            this.Imagen_MenuSistema.PerformLayout();
            this.tabCerrarOperacion.ResumeLayout(false);
            this.Imagen_CerrarOperacion.ResumeLayout(false);
            this.tabSistemaSuspendido.ResumeLayout(false);
            this.Imagen_SistemaSupendido.ResumeLayout(false);
            this.tabTarjetaInvalida.ResumeLayout(false);
            this.Imagen_TarjetaInvalida.ResumeLayout(false);
            this.tabArqueoParcial.ResumeLayout(false);
            this.Imagen_ArqueoParcial.ResumeLayout(false);
            this.Imagen_ArqueoParcial.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Animacion_RetireBox)).EndInit();
            this.tabArqueoTotal.ResumeLayout(false);
            this.Imagen_ArqueoTotal.ResumeLayout(false);
            this.Imagen_ArqueoTotal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AnimacionBoxTotal)).EndInit();
            this.tabDescargando.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pInicio)).EndInit();
            this.Imagen_Inicio.ResumeLayout(false);
            this.Imagen_Principal.ResumeLayout(false);
            this.Imagen_Principal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Animacion_InserteTarjeta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pPublicidad)).EndInit();
            this.tabTarjetaVisitante.ResumeLayout(false);
            this.Imagen_TarjetaVisitante.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Animacion_Inserte)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.tabDigitePlaca.ResumeLayout(false);
            this.Imagen_DigitePlaca.ResumeLayout(false);
            this.Imagen_DigitePlaca.PerformLayout();
            this.tabNoMensual.ResumeLayout(false);
            this.Imagen_TarjetaMensual.ResumeLayout(false);
            this.Imagen_TarjetaMensual.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer tmrReset;
        private System.Windows.Forms.TabPage tabSistemaSuspendido;
        private System.Windows.Forms.Panel Imagen_SistemaSupendido;
        private TransparentControl.TransparentControl CapaSuspendidoCaleto;
        private System.Windows.Forms.TabPage tabCerrarOperacion;
        private System.Windows.Forms.Panel Imagen_CerrarOperacion;
        private System.Windows.Forms.TabPage tabMenuSistemas;
        private System.Windows.Forms.Panel Imagen_MenuSistema;
        private System.Windows.Forms.Label lblFechaActual;
        private CustomButton.CustomButton btn_Carga;
        private CustomButton.CustomButton btn_Salir;
        private CustomButton.CustomButton btn_Iniciar;
        private CustomButton.CustomButton btn_Mantenimiento;
        private CustomButton.CustomButton btn_Log;
        private CustomButton.CustomButton btn_Arqueo;
        private System.Windows.Forms.TabPage tabCargaMonedas;
        private System.Windows.Forms.Panel Imagen_CargaMonedas;
        private CustomButton.CustomButton btnHopper4;
        private CustomButton.CustomButton btn_Hopper3;
        private CustomButton.CustomButton btn_ConfirmarCargaMonedas;
        private CustomButton.CustomButton btn_okCarga;
        private CustomButton.CustomButton btn_BorrarCarga;
        private CustomButton.CustomButton btn_0Carga;
        private CustomButton.CustomButton btn_3Carga;
        private CustomButton.CustomButton btn_2Carga;
        private CustomButton.CustomButton btn_1Carga;
        private CustomButton.CustomButton btn_6Carga;
        private CustomButton.CustomButton btn_5Carga;
        private CustomButton.CustomButton btn_4Carga;
        private CustomButton.CustomButton btn_9Carga;
        private CustomButton.CustomButton btn_8Carga;
        private CustomButton.CustomButton btn_7Carga;
        private System.Windows.Forms.Label lblKeyboard_Carga;
        private System.Windows.Forms.DataGridView grvCargaActualMonedas;
        private System.Windows.Forms.DataGridView grvCargaTotalMonedas;
        private CustomButton.CustomButton btnHopper2;
        private CustomButton.CustomButton btnHopper1;
        private System.Windows.Forms.TabPage tabCargaBilletes;
        private System.Windows.Forms.Panel Imagen_CargaBilletes;
        private CustomButton.CustomButton btn_ConfirmarCargaF56;
        private System.Windows.Forms.DataGridView grvCargaActualBilletesF56;
        private System.Windows.Forms.DataGridView grvCargaTotalBilletesF56;
        private System.Windows.Forms.TabPage tabCarga;
        private System.Windows.Forms.Panel Imagen_Carga;
        private CustomButton.CustomButton btn_CargaMonedas;
        private CustomButton.CustomButton btn_VolverCarga;
        private CustomButton.CustomButton btn_CargaBilletes;
        private System.Windows.Forms.TabPage tabArqueo;
        private System.Windows.Forms.Panel Imagen_Arqueo;
        private CustomButton.CustomButton btn_ArqueoTotal;
        private CustomButton.CustomButton btn_Volver;
        private CustomButton.CustomButton btn_ArqueoParcial;
        private System.Windows.Forms.TabPage tabMantenimiento;
        private System.Windows.Forms.Panel Imagen_Mantenimiento;
        private TransparentControl.TransparentControl CapaMantenimientoCaleto;
        private System.Windows.Forms.TabPage tabSegundoPass;
        private System.Windows.Forms.Panel Imagen_SegundaPass;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Label lblUsuarioSegunda;
        private CustomButton.CustomButton btn_CancelarSegunda;
        private CustomButton.CustomButton btn_AceptarSegunda;
        private CustomButton.CustomButton btn_MostrarTecladoSegunda;
        private System.Windows.Forms.TabPage tabIngresoPass;
        private System.Windows.Forms.Panel Imagen_IngresoPass;
        private TransparentControl.TransparentControl CapaPass;
        private TransparentControl.TransparentControl CapaUsuario;
        private DevComponents.DotNetBar.Keyboard.KeyboardControl kbUsuarioPass;
        private System.Windows.Forms.Label lblPassword;
        private CustomButton.CustomButton btn_Cancelar;
        private CustomButton.CustomButton btn_Aceptar;
        private CustomButton.CustomButton btn_MostrarTecladoPass;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.TabPage tabContrasenaInvalida;
        private System.Windows.Forms.Panel Imagen_ContraseñaInvalida;
        private System.Windows.Forms.TabPage tabGraciasPago;
        private System.Windows.Forms.Panel Imagen_GraciasPago;
        private System.Windows.Forms.TabPage tabImprimirFactura;
        private System.Windows.Forms.Panel Imagen_ImprimirFactura;
        private CustomButton.CustomButton btnPrintNO;
        private System.Windows.Forms.TabPage tabPagoCelular;
        private System.Windows.Forms.Panel Imagen_PagoCelular;
        private CustomButton.CustomButton btn_CancelarCelular;
        private System.Windows.Forms.TabPage tabTransaccionCancelada;
        private System.Windows.Forms.Panel Imagen_TransaccionCancelada;
        private System.Windows.Forms.TabPage tabDetallePago;
        private System.Windows.Forms.TabPage tabPrincipal;
        private System.Windows.Forms.TabPage tabInicio;
        private Ds.Utilidades.CustomTabControl TabControlPrincipal;
        private System.Windows.Forms.TabPage tabPagoEfectivo;
        private System.Windows.Forms.Panel Imagen_PagoEfectivo;
        private System.Windows.Forms.TabPage tabPagoPrepago;
        private System.Windows.Forms.TabPage tabPagoDatafono;
        private CustomButton.CustomButton btn_VolverMedios;
        private System.Windows.Forms.TabPage tabProcesando;
        private System.Windows.Forms.Panel Imagen_Procesando;
        private CustomButton.CustomButton btn_VolverMedioCelular;
        private System.Windows.Forms.Label lblCodigoPago;
        private System.Windows.Forms.Label lblCodigoParqueo;
        private System.Windows.Forms.Label lblValorPagarCelular;
        private CustomButton.CustomButton btn_ContinuarCelular;
        private System.Windows.Forms.Panel Imagen_DetallePago;
        private System.Windows.Forms.Label lblPermanencia;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label lblTipoVehiculo;
        private System.Windows.Forms.Label lblValorPagarEfectivo;
        private System.Windows.Forms.Label lblConvenio;
        private CustomButton.CustomButton btn_CancelarPagoEfectivo;
        private System.Windows.Forms.Panel Imagen_Prepago;
        private CustomButton.CustomButton btn_MediosPrepago;
        private System.Windows.Forms.Label lblValorPagarPrepago;
        private CustomButton.CustomButton btn_CancelarPrepago;
        private System.Windows.Forms.Panel pPublicidadCancelada;
        private System.Windows.Forms.Panel pPublicidadGracias;
        private System.Windows.Forms.Panel pPublicidadCerrar;
        private System.Windows.Forms.Panel Imagen_PagoDatafono;
        private System.Windows.Forms.Label lblValorPagarDatafono;
        private CustomButton.CustomButton btn_MedioDatafono;
        private CustomButton.CustomButton btn_CancelarDatafono;
        private System.Windows.Forms.PictureBox pDatafono;
        private System.Windows.Forms.PictureBox pPagoEfectivo;
        private System.Windows.Forms.PictureBox pPrepago;
        private System.Windows.Forms.PictureBox pCelular;
        private System.Windows.Forms.TabPage tabTarjetaInvalida;
        private System.Windows.Forms.Panel Imagen_TarjetaInvalida;
        private System.Windows.Forms.Panel pPublicidadInvalida;
        private CustomButton.CustomButton btnPrintSI;
        private System.Windows.Forms.TabPage tabTransaccionCanceladaPago;
        private System.Windows.Forms.Panel Imagen_TransaccionCanceladaPago;
        private System.Windows.Forms.Panel pPublicidadCanceladaPago;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TabPage tabTarjetaNoGeneraPago;
        private System.Windows.Forms.Panel Imagen_NoGeneraPago;
        private System.Windows.Forms.Panel pPublicidadNoPago;
        private System.Windows.Forms.TabPage tabTarjetaSinEntrada;
        private System.Windows.Forms.Panel Imagen_TarjetaSinEntrada;
        private System.Windows.Forms.Panel pPublicidadSinEntrada;
        private System.Windows.Forms.Label lblCambio;
        private System.Windows.Forms.Label lblValorRecibido;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TabPage tabArqueoParcial;
        private System.Windows.Forms.Panel Imagen_ArqueoParcial;
        private CustomButton.CustomButton btn_ConfirmarArqueo;
        private System.Windows.Forms.TabPage tabArqueoTotal;
        private System.Windows.Forms.Panel Imagen_ArqueoTotal;
        private CustomButton.CustomButton btn_ConfirmarArqueoTotal;
        private System.Windows.Forms.TabPage tabDescargando;
        private System.Windows.Forms.Panel Imagen_Descargando;
        private System.Windows.Forms.PictureBox pPublicidadDetalle;
        private System.Windows.Forms.PictureBox pPublicidadProcesando;
        private System.Windows.Forms.Panel pPublicidadImprimir;
        private System.Windows.Forms.Panel pPublicidadSuspendido;
        private System.Windows.Forms.TextBox tbCodigo;
        private System.Windows.Forms.TabPage tabTarjetaMensual;
        private System.Windows.Forms.TabPage tabDetallePagoMensual;
        private System.Windows.Forms.Panel Imagen_DetallePagoMensual;
        private System.Windows.Forms.PictureBox pPublicidadPagoAuto;
        private System.Windows.Forms.Label lblValorCambioAuto;
        private System.Windows.Forms.Label lblValorRecibidoAuto;
        private System.Windows.Forms.Label lblNombreAuto;
        private System.Windows.Forms.Label lblDocumentoAuto;
        private System.Windows.Forms.Label lblValorPagarAuto;
        private System.Windows.Forms.Label lblFechaFinAuto;
        private CustomButton.CustomButton btn_CancelarPagoAuto;
        private System.Windows.Forms.TabPage tabAtasco;
        private System.Windows.Forms.Panel Imagen_Atasco;
        private TransparentControl.TransparentControl capaAtasco;
        private System.Windows.Forms.TabPage tabPuedeSalir;
        private System.Windows.Forms.Panel imagen_PuedeSalir;
        private System.Windows.Forms.Panel pPublicidadPuedeSalir;
        private System.Windows.Forms.Label lblTiempoSalida;
        private System.Windows.Forms.TabPage tabConsultaFallida;
        private System.Windows.Forms.Panel Imagen_ConsultaFallida;
        private CustomButton.CustomButton customButton1;
        private CustomButton.CustomButton customButton2;
        private System.Windows.Forms.PictureBox Animacion_RetireBox;
        private System.Windows.Forms.PictureBox AnimacionBoxTotal;
        private System.Windows.Forms.TabPage tabSeleccionPago;
        private System.Windows.Forms.Panel Imagen_SeleccionPago;
        private CustomButton.CustomButton btn_Efectivo;
        private CustomButton.CustomButton btn_Datafono;
        private System.Windows.Forms.Panel pPublicidadSeleccionPago;
        private System.Windows.Forms.TabPage tabInserteTarjetaDatafono;
        private System.Windows.Forms.Panel Imagen_InserteTarjetaDatafono;
        private CustomButton.CustomButton btn_Volver2;
        private CustomButton.CustomButton btn_PagoQR;
        private System.Windows.Forms.Panel pPublicidadInsertaDatafono;
        private CustomButton.CustomButton btn_PagoMovil;
        private CustomButton.CustomButton btn_PagoNormal;
        private System.Windows.Forms.TabPage tabNumeroCuotas;
        private System.Windows.Forms.Panel Imagen_NumeroCuotas;
        private System.Windows.Forms.Panel pPublicidadCuotas;
        private CustomButton.CustomButton btn_CancelarCuotas;
        private CustomButton.CustomButton btn_okCuotas;
        private CustomButton.CustomButton btn_BorrarCuotas;
        private CustomButton.CustomButton btn_0Cuotas;
        private CustomButton.CustomButton btn_3Cuotas;
        private CustomButton.CustomButton btn_2Cuotas;
        private CustomButton.CustomButton btn_1Cuotas;
        private CustomButton.CustomButton btn_6Cuotas;
        private CustomButton.CustomButton btn_5Cuotas;
        private CustomButton.CustomButton btn_4Cuotas;
        private CustomButton.CustomButton btn_9Cuotas;
        private CustomButton.CustomButton btn_8Cuotas;
        private CustomButton.CustomButton btn_7Cuotas;
        private System.Windows.Forms.Label lblCuotas;
        private System.Windows.Forms.TabPage tabTipoCuenta;
        private System.Windows.Forms.Panel Imagen_TipoCuenta;
        private CustomButton.CustomButton btn_CancelarTipoCuenta;
        private CustomButton.CustomButton btn_Credito;
        private System.Windows.Forms.Panel pPublicidadTipoCuenta;
        private CustomButton.CustomButton btn_Ahorros;
        private CustomButton.CustomButton btn_Corriente;
        private System.Windows.Forms.TabPage tabDigiteCredito;
        private System.Windows.Forms.Panel Imagen_DigiteCredito;
        private System.Windows.Forms.Panel pPublicidadCredito;
        private CustomButton.CustomButton btn_CancelarCredito;
        private CustomButton.CustomButton btn_okCredito;
        private CustomButton.CustomButton btn_BorrarCredito;
        private CustomButton.CustomButton btn_0Credito;
        private CustomButton.CustomButton btn_3Credito;
        private CustomButton.CustomButton btn_2Credito;
        private CustomButton.CustomButton btn_1Credito;
        private CustomButton.CustomButton btn_6Credito;
        private CustomButton.CustomButton btn_5Credito;
        private CustomButton.CustomButton btn_4Credito;
        private CustomButton.CustomButton btn_9Credito;
        private CustomButton.CustomButton btn_8Credito;
        private CustomButton.CustomButton btn_7Credito;
        private System.Windows.Forms.Label lblDigitosCredito;
        private System.Windows.Forms.TabPage tabDetallePagoDatafono;
        private System.Windows.Forms.Panel Imagen_DetallePagoDatafono;
        private System.Windows.Forms.PictureBox pPublicidadDetalleDatafono;
        private System.Windows.Forms.Label lblPermanenciaDetalle;
        private System.Windows.Forms.Label lblFechaDetalle;
        private System.Windows.Forms.Label lblTipoVehiculoDetalle;
        private System.Windows.Forms.Label lblValorPagarEfectivoDetalle;
        private System.Windows.Forms.Label lblConvenioDetalle;
        private CustomButton.CustomButton btn_CancelarDetalle;
        private CustomButton.CustomButton btn_ConfirmarDetalle;
        private System.Windows.Forms.TabPage tabPagoParcial;
        private System.Windows.Forms.Panel pPublicidadPagoParcial;
        private System.Windows.Forms.Panel Imagen_PagoParcial;
        private CustomButton.CustomButton btn_AnularPagoParcial;
        private CustomButton.CustomButton btn_ConfirmarPagoParcial;
        private System.Windows.Forms.Label lblTipoVehiculoP;
        private System.Windows.Forms.Label lblPermanenciaP;
        private System.Windows.Forms.Label lblFechaEntradaP;
        private System.Windows.Forms.Label lblValorP;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TabPage tabNitCliente;
        private System.Windows.Forms.Panel Imagen_DigiteNitCliente;
        private System.Windows.Forms.Panel Panel_TecladoNitCliente;
        private CustomButton.CustomButton btn_NitCliente0;
        private CustomButton.CustomButton btn_NitCliente9;
        private CustomButton.CustomButton btn_NitCliente8;
        private CustomButton.CustomButton btn_NitCliente7;
        private CustomButton.CustomButton btn_NitCliente6;
        private CustomButton.CustomButton btn_NitCliente5;
        private CustomButton.CustomButton btn_NitCliente4;
        private CustomButton.CustomButton btn_NitCliente3;
        private CustomButton.CustomButton btn_NitCliente2;
        private CustomButton.CustomButton btn_NitCliente1;
        private CustomButton.CustomButton btn_BorrarNitCliente;
        private CustomButton.CustomButton btn_OkNitCliente;
        private System.Windows.Forms.Label lblNitCliente;
        private System.Windows.Forms.Panel panel2;
        private CustomButton.CustomButton btn_ConfirmarPagoFE;
        private System.Windows.Forms.Panel Imagen_Inicio;
        private System.Windows.Forms.PictureBox pInicio;
        private System.Windows.Forms.Panel Imagen_Principal;
        private CustomButton.CustomButton btn_InserteTarjeta;
        private CustomButton.CustomButton btn_Placa;
        private System.Windows.Forms.PictureBox Animacion_InserteTarjeta;
        private System.Windows.Forms.PictureBox pPublicidad;
        private TransparentControl.TransparentControl CapaMenuPrincipal;
        private System.Windows.Forms.TabPage tabTarjetaVisitante;
        private System.Windows.Forms.Panel Imagen_TarjetaVisitante;
        private System.Windows.Forms.PictureBox Animacion_Inserte;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TabPage tabDigitePlaca;
        private System.Windows.Forms.Panel Imagen_DigitePlaca;
        private System.Windows.Forms.Label lblPlaca;
        private DevComponents.DotNetBar.Keyboard.KeyboardControl kbPlaca;
        private CustomButton.CustomButton btn_AceptarPlaca;
        private CustomButton.CustomButton btn_CancelarPlaca;
        private System.Windows.Forms.TabPage tabNoMensual;
        private System.Windows.Forms.Panel Imagen_NoMensual;
        private System.Windows.Forms.Panel Imagen_TarjetaMensual;
        private CustomButton.CustomButton btn_ConfirmarPagoMensualFE;
        private CustomButton.CustomButton btn_AnularPagoMensualParcial;
        private CustomButton.CustomButton btn_ConfirmarPagoMensual;
        private System.Windows.Forms.Label lblNombreAutoN;
        private System.Windows.Forms.Label lblValorPagarAutoN;
        private System.Windows.Forms.Label lblFechaFinAutoN;
        private System.Windows.Forms.Panel pPublicidadMensul;
        private CustomButton.CustomButton btn_SiMensual;
        private CustomButton.CustomButton btn_NoMensual;
    }
}

