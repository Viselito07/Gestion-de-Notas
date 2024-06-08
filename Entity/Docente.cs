using LinqToDB.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Docente
    {
               /// <summary>
               /// hola mundo
               /// </summary>
        [Identity]
        public int IdDoc { get; set; }
        [PrimaryKey]
        public string DocenteNid { get; set; }
        public string NombresDocente { get; set; }
        public string ApellidosDocente { get; set; }
        public DateTime FechaNacDocente { get; set; }
        public string DirDocente { get; set; }
        public string Especialidad { get; set; }
        public string TelfDocente { get; set; }
        public string NombreDocente { get;set; }
    }
}
