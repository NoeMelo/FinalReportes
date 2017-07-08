//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DAReportes
{
    using System;
    using System.Collections.Generic;
    
    public partial class Proyecto
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Proyecto()
        {
            this.Archivo_Investigacion = new HashSet<Archivo_Investigacion>();
            this.Det_Partic_Proyecto = new HashSet<Det_Partic_Proyecto>();
            this.Proyecto_Constr = new HashSet<Proyecto_Constr>();
            this.Archivo_Investigacion1 = new HashSet<Archivo_Investigacion>();
        }
    
        public int ID_Proyecto { get; set; }
        public string Titulo { get; set; }
        public string Abstract { get; set; }
        public string Keywords { get; set; }
        public string Fecha_pub { get; set; }
        public string Tipo { get; set; }
        public Nullable<System.DateTime> Fecha_ini { get; set; }
        public Nullable<System.DateTime> Fecha_fin { get; set; }
        public string Link_file { get; set; }
        public Nullable<int> Estado { get; set; }
        public Nullable<int> ID_Usuario_crea { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Archivo_Investigacion> Archivo_Investigacion { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Det_Partic_Proyecto> Det_Partic_Proyecto { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Proyecto_Constr> Proyecto_Constr { get; set; }
        public virtual Usuario Usuario { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Archivo_Investigacion> Archivo_Investigacion1 { get; set; }
    }
}