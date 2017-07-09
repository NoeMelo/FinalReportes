using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryDA
{
    public class DAinvitado
    {
        static public List<Invitado> ListadoInvitado()
        {
            List<Invitado> invitado = new List<Invitado>();
            using (var data = new WEBEntities())
            {
                return data.Invitado.ToList();
            }
        }
    }
}
