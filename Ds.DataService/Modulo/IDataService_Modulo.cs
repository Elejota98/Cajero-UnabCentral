﻿using Ds.BusinessService.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ds.DataService
{
    public partial interface IDataService
    {
        ResultadoOperacion ObtenerInformacionModulo(Modulo oModulo);

        ResultadoOperacion ObtenerInformacionPartesModulo(Modulo oModulo);

        ResultadoOperacion ObtenerInformacionPartesF56(Modulo oModulo, int Tipo);

        ResultadoOperacion ObtenerParametrosModulo(Modulo oModulo);

        ResultadoOperacion ValidarSaldosMinimos(Modulo oModulo);

        ResultadoOperacion RegistrarOperacion(Operacion oOperacion);

        ResultadoOperacion RegistrarArqueo(Arqueo oArqueo);

        ResultadoOperacion RegistrarCarga(Carga oCarga);

        ResultadoOperacion RegistrarMovimiento(Movimiento oMovimiento);

        ResultadoOperacion ObtenerSaldoPartes(Modulo oModulo);

        ResultadoOperacion ConfirmarOperacion(Operacion oOperacion);

        ResultadoOperacion ConfirmarOperacionFE(Operacion oOperacion);

        ResultadoOperacion ObtenerUsuario(Usuario oUsuario);

        ResultadoOperacion ValidarClave(long Identificacion, string clave);

        ResultadoOperacion GenerarClave(Modulo oModulo, Usuario oUsuario);

        ResultadoOperacion ValidarSegundaClave(Modulo oModulo, string clave);

        ResultadoOperacion CrearAlarma(Alarma oAlarma);

        ResultadoOperacion SolucionarTodasAlarmas(Modulo oModulo);

        ResultadoOperacion InsertarLogWS(LogWS oLogWS);

        ResultadoOperacion ObtenerIdTransacciones(Transaccion oTransaccion);


        ResultadoOperacion ObtenerTransaccionesOfflineModulo(Modulo oModulo);
        ResultadoOperacion ObtenerPagosOffline(Transaccion oTransaccion);
        ResultadoOperacion ObtenerMovimientoOffline(Pago oPago);
        ResultadoOperacion ActualizarRegistro(Pago oPago);

        ResultadoOperacion ObtenerDetalleArqueo(Arqueo oArqueo);
        ResultadoOperacion RegistrarTransaccion(Transaccion oTransaccion);
        ResultadoOperacion RegistrarTransaccionFE(Transaccion oTransaccion, int identificacion);

        ResultadoOperacion ObtenerInformacionFactura(Modulo oModulo);

        ResultadoOperacion GenerarToken();
        ResultadoOperacion Monitoreo(string IdModulo, string Estado);

        ResultadoOperacion RegistrarCliente(string Celular, string Email);
        ResultadoOperacion ValidarCliente(string Celular);
        ResultadoOperacion ObtenerDatosConvenio(long IdConvenio);

        ResultadoOperacion RegistrarConvenioValidado(string Consecutivo, string CodigoCompleto, string IdModulo);

        ResultadoOperacion ValidarConvenio(string Codigo);

        ResultadoOperacion ObtenerInfoAutorizado(Autorizado oAutorizado);

        ResultadoOperacion ValidarTransaccion(long IdTransaccion);
        ResultadoOperacion RegistrarTransaccionEntrada(Transaccion oTransaccion);

        ResultadoOperacion ObtenerFecha();

        ResultadoOperacion RegistrarConvenioAplicado(long idTransaccion, int Convenio);

        ResultadoOperacion ObtenerFechaConvenio(long idTransaccion);

        ResultadoOperacion ObtenerTarjetas(long IdEstacionamiento);
        ResultadoOperacion ObtenerInfoCliente(int identificacion);
    }
}
