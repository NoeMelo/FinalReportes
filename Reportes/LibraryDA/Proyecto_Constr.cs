//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LibraryDA
{
    using System;
    using System.Collections.Generic;
    
    public partial class Proyecto_Constr
    {
        public int ID_Proyecto { get; set; }
        public int ID_Pers_Contr { get; set; }
        public Nullable<int> ID_Pers_Sup { get; set; }
        public string Comentario { get; set; }
        public string Link_file { get; set; }
        public Nullable<System.DateTime> Fecha_Carga { get; set; }
        public Nullable<int> Estado { get; set; }
        public string Foto { get; set; }
        public string Referencia { get; set; }
    
        public virtual Proyecto Proyecto { get; set; }
        public virtual Usuario Usuario { get; set; }
        public virtual Usuario Usuario1 { get; set; }
    }
}
