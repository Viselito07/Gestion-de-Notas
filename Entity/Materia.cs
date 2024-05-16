using System;
using System.Collections.Generic;
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
    }
}
