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
    
    public partial class DEPARTAMENTO
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DEPARTAMENTO()
        {
            this.ARRIENDOes = new HashSet<ARRIENDO>();
            this.DEPARTAMENTO_FOTOS = new HashSet<DEPARTAMENTO_FOTOS>();
            this.DEPARTAMENTO_INVENTARIO = new HashSet<DEPARTAMENTO_INVENTARIO>();
            this.HABITACIONES = new HashSet<HABITACIONE>();
            this.MANTENCIONs = new HashSet<MANTENCION>();
        }
    
        public decimal ID { get; set; }
        public string DIRECCION { get; set; }
        public decimal MAX_PERSONA { get; set; }
        public string COMENTARIO { get; set; }
        public decimal NUMERO { get; set; }
        public Nullable<decimal> PRECIO { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ARRIENDO> ARRIENDOes { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DEPARTAMENTO_FOTOS> DEPARTAMENTO_FOTOS { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DEPARTAMENTO_INVENTARIO> DEPARTAMENTO_INVENTARIO { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HABITACIONE> HABITACIONES { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MANTENCION> MANTENCIONs { get; set; }
    }
}