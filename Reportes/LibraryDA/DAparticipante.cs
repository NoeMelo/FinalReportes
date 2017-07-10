using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryDA
{
    public class DAparticipante
    {
        static public List<Participantes> ListadoParticipante()
        {
            List<Participantes> evento = new List<Participantes>();
            using (var data = new WEBEntities())
            {
                return data.Participantes.ToList();
            }
        }
    }
}
