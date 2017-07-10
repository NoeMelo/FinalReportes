using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryDA
{
    public class DAclic
    {

        static public List<Clic> ListadoAlumno()
        {
            List<Clic> evento = new List<Clic>();
            using (var data = new WEBEntities())
            {
                return data.Clic.ToList();
            }
        }
    }
}
