using DAReportes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAReportes
{
    public class DAAlumno
    {
        static public List<Alumno> listadoAlumno()
        {
            List<Alumno> listado = new List<Alumno>();
            using (var data = new WEBEntities())
            {
                return data.Alumno.ToList();
            }
        }
    }
}
