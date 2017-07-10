using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryDA
{
    public class DAdet_Partic_Proyecto
    {
        static public List<Det_Partic_Proyecto> ListaDet_participante()
        {
            List<Det_Partic_Proyecto> evento = new List<Det_Partic_Proyecto>();
            using (var data = new WEBEntities())
            {
                return data.Det_Partic_Proyecto.ToList();
            }
        }



    }
}

