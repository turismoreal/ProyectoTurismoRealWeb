//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CapaDato
{
    using System;
    using System.Collections.Generic;
    
    public partial class PAGO
    {
        public decimal ID { get; set; }
        public decimal MONTO_TOTAL { get; set; }
        public System.DateTime FECHA { get; set; }
        public System.DateTime HORA { get; set; }
        public decimal ID_TIPO_PAGO { get; set; }
        public decimal ID_ESTADO { get; set; }
        public decimal ID_ARRIENDO { get; set; }
    
        public virtual ARRIENDO ARRIENDO { get; set; }
        public virtual ESTADO ESTADO { get; set; }
        public virtual TIPO_PAGO TIPO_PAGO { get; set; }
    }
}
