using LinqToDB.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Estudiante
    {
        [Identity]
        public int IdEs { get; set; }
        [PrimaryKey]
        public string EstudianteNid { get; set; }
        public string NombreEstudiante { get; set; }
        public string ApellidoEstudiante { get; set; }   
        public DateTime FechNacEstudiante { get; set; }
        public string DirEstudiante {  get; set; }
        public string TelfEstudiante { get; set; }
        //public string EmailEstudiante { get; set; }

        public MailAddress EmailEstudiante { get; set; }
    }
}
