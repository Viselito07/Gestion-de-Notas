using LinqToDB.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Estudiante
    {
        [Identity]
        public int IdEs { get; set; }
        public string NombreEstudiante { get; set; }
        public string ApellidoEstudiante { get; set; }
        [PrimaryKey]
        public string EstudianteNid { get; set; }
        public string FechNacEstudiante { get; set; }
        public string DirEstudiante {  get; set; }
        public string TelfEstudiante { get; set; }
    }
}
