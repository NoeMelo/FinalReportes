using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryDA
{
    public class DAevento
    {
        static public List<Evento> ListadoEvento()
        {
            List<Evento> evento = new List<Evento>();
            using (var data = new WEBEntities())
            {

             

                return data.Evento.ToList();
            }




        }
    }
}
