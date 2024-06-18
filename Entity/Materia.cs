using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;
using LinqToDB;
using LinqToDB.Mapping;

namespace Entity
{
    public class Materia
    {
        [PrimaryKey, Identity]
        public int IdM { get; set; }
        public string Nombre { get; set; }

        [ForeignKey("Docente")]
        public string DocenteNid { get; set; }

        [ForeignKey("Grado")]
        public int Idg { get; set; }
    }
}
