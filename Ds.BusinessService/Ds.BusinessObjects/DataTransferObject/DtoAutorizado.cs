﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ds.BusinessObjects.DataTransferObject
{
    public class DtoAutorizado
    {
        private string _Documento;
        private long _IdAutorizacion;
        private bool _Estado;
        private bool _EstadoAutorizacion;
        private string _IdTarjeta;
        private string _NombresAutorizado;
        private DateTime? _FechaInicial;
        private DateTime? _FechaFinal;
        private long _IdEstacionamiento;
        private string _NIT;
        public string NIT
        {
            get { return _NIT; }
            set { _NIT = value; }
        }
        private string _NombreEmpresa;
        public string NombreEmpresa
        {
            get { return _NombreEmpresa; }
            set { _NombreEmpresa = value; }
        }

        private string _NombreAutorizacion;

        public string NombreAutorizacion
        {
            get { return _NombreAutorizacion; }
            set { _NombreAutorizacion = value; }
        }

        public string Documento
        {
            get { return _Documento; }
            set { _Documento = value; }
        }

        public long IdAutorizacion
        {
            get { return _IdAutorizacion; }
            set { _IdAutorizacion = value; }
        }

        public bool Estado
        {
            get { return _Estado; }
            set { _Estado = value; }
        }

        public bool EstadoAutorizacion
        {
            get { return _EstadoAutorizacion; }
            set { _EstadoAutorizacion = value; }
        }

        public string IdTarjeta
        {
            get { return _IdTarjeta; }
            set { _IdTarjeta = value; }
        }

        public string NombresAutorizado
        {
            get { return _NombresAutorizado; }
            set { _NombresAutorizado = value; }
        }

        public DateTime? FechaInicial
        {
            get { return _FechaInicial; }
            set { _FechaInicial = value; }
        }


        public DateTime? FechaFinal
        {
            get { return _FechaFinal; }
            set { _FechaFinal = value; }
        }


        public long IdEstacionamiento
        {
            get { return _IdEstacionamiento; }
            set { _IdEstacionamiento = value; }
        }
    }
}
