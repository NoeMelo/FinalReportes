using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryDA
{
    public class DAempresa
    {
        static public List<Empresa> ListadoEmpresa()
        {
            List<Empresa> empresa = new List<Empresa>();
            using (var data = new WEBEntities())
            {
                return data.Empresa.ToList();
            }
           
        }
    }
}
