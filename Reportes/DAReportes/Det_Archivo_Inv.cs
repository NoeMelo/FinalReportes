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
    
    public partial class Det_Archivo_Inv
    {
        public int ID_ArchivoI { get; set; }
        public int ID_Usuario { get; set; }
        public string Rol { get; set; }
    
        public virtual Archivo_Investigacion Archivo_Investigacion { get; set; }
        public virtual Usuario Usuario { get; set; }
    }
}