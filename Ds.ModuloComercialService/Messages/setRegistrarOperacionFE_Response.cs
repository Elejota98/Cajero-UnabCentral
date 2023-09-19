using Ds.BaseService.MessageBase;
using Ds.BusinessService.DataTransferObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Ds.ModuloService.Messages
{
    [DataContract(Namespace = "http://www.dsystem.co/types/")]
    public class setRegistrarOperacionFE_Response : ResponseBase
    {
        [DataMember]
        public DtoOperacion oDtoOperacion;

        [DataMember]
        public DtoArqueo oDtoArqueo;

        [DataMember]
        public DtoCarga oDtoCarga;

        [DataMember]
        public string IdTransaccion;

        [DataMember]
        public bool bInsercionExitosa;
    }
}
