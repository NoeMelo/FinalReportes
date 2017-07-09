using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryDA
{
    public class DAarchivo
    {
       static public List<Archivo_Investigacion> ListaArchivo()
        {
            List<Archivo_Investigacion> evento = new List<Archivo_Investigacion>();
            using (var data = new WEBEntities())
            {
                return data.Archivo_Investigacion.ToList();
            }
        }
    }
}
