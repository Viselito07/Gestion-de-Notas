using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Entity;
using System.Data;


namespace DAL
{
    public class EstudianteRepository
    {
        SqlConnection conn;
        List<Estudiante> estudiantes;

        public EstudianteRepository(ConnectionManager Connection)
        {
            conn = Connection.connection;
            estudiantes = new List<Estudiante>();
        }

        public List<Estudiante> Consultar()
        {
            estudiantes.Clear();
            using(var comando = conn.CreateCommand())
            {
                comando.CommandText = "Select * From Estudiante";
                var Reader = comando.ExecuteReader();
                while (Reader.Read())
                {
                    Estudiante estudiante = new Estudiante();
                    estudiante = Mapear(Reader);
                    estudiantes.Add(estudiante);
                }
            }

            return estudiantes;
        }

        public Estudiante Mapear(SqlDataReader reader)
        {
            Estudiante estudiante = new Estudiante();
            estudiante.IdEs = Convert.ToInt32(reader["IdEs"]);
            estudiante.EstudianteNid = (string)reader["EstudianteNid"];
            estudiante.NombreEstudiante = (string)reader["NombreEstudiante"];
            estudiante.ApellidoEstudiante = (string)reader["ApellidoEstudiante"];
            estudiante.FechNacEstudiante = (string)reader["FechNacEstudiante"];
            estudiante.DirEstudiante = (string)reader["DirEstudiante"];
            estudiante.TelfEstudiante = (string)reader["TelfEstudiante"];
            estudiante.EmailEstudiante = (string)reader["EmailEstudiante"];

            return estudiante;
        }
    }
}
