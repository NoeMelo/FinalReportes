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
    
    public partial class Hoja_Vida
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Hoja_Vida()
        {
            this.Historial_Hoja_Vida = new HashSet<Historial_Hoja_Vida>();
        }
    
        public int ID_HojaVida { get; set; }
        public Nullable<int> ID_Alumno { get; set; }
        public string Foto { get; set; }
        public string Desc_perfil { get; set; }
        public string Conoc_adic { get; set; }
        public string Logro_pers { get; set; }
    
        public virtual Alumno Alumno { get; set; }
        public virtual Det_Certificado Det_Certificado { get; set; }
        public virtual Det_Exp_Laboral Det_Exp_Laboral { get; set; }
        public virtual Det_Form_Acad Det_Form_Acad { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Historial_Hoja_Vida> Historial_Hoja_Vida { get; set; }
    }
}
