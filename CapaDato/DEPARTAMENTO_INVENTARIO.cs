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
    
    public partial class DEPARTAMENTO_INVENTARIO
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DEPARTAMENTO_INVENTARIO()
        {
            this.INCIDENTES = new HashSet<INCIDENTE>();
        }
    
        public decimal ID { get; set; }
        public decimal ID_INVENTARIO { get; set; }
        public decimal ID_DEPARTAMENTO { get; set; }
        public decimal CANTIDAD { get; set; }
        public string COMENTARIO { get; set; }
        public string IMAGEN { get; set; }
    
        public virtual DEPARTAMENTO DEPARTAMENTO { get; set; }
        public virtual INVENTARIO INVENTARIO { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<INCIDENTE> INCIDENTES { get; set; }
    }
}
