using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryDA
{
   public class DAusuario
    {
        static public List<Usuario> ListadoUsuario()
        {
            List<Usuario> alumno = new List<Usuario>();
            using (var data = new WEBEntities())
            {
                return data.Usuario.ToList();
            }
        }
    }
}
