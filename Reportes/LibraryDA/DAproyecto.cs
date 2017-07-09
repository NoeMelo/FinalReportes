using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryDA
{
    public class DAproyecto
    {
        List<Proyecto> ListadoProyecto()
        {
            List<Proyecto> evento = new List<Proyecto>();
            using (var data = new WEBEntities())
            {
                return data.Proyecto.ToList();
            }
        }
    }
}
