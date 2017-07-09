using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryDA
{
    public class DAalumno
    {
        static public List<Alumno> ListadoAlumno()
        {
            
            List<Alumno> alumno = new List<Alumno>();
            using (var data = new WEBEntities())
            {
                return data.Alumno.ToList();
            }
        }


















    }
}
