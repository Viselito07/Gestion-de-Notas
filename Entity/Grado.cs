using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LinqToDB.Mapping;

namespace Entity
{
    public class Grado
    {
        [PrimaryKey, Identity]
        public int IdG { get; set; }
        public string NombreG { get; set; }

    }
}
