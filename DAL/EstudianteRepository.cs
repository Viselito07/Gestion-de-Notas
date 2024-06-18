using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Entity;
using System.Data;
using System.Net.Mail;


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

        public void GuardarEstudiante(Estudiante estudiante)
        {
            using (var comando = conn.CreateCommand())
            {
                comando.CommandText = "sp_crud_estudiante ";
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@intProceso", 2);
                comando.Parameters.AddWithValue("@EstudianteNid", estudiante.EstudianteNid);
                comando.Parameters.AddWithValue("@NombreEstudiante", estudiante.NombreEstudiante);
                comando.Parameters.AddWithValue("@ApellidoEstudiante", estudiante.ApellidoEstudiante);
                comando.Parameters.AddWithValue("@FechNacEstudiante", estudiante.FechNacEstudiante);
                comando.Parameters.AddWithValue("@DirEstudiante", estudiante.DirEstudiante);
                comando.Parameters.AddWithValue("@TelfEstudiante", estudiante.TelfEstudiante);
                //comando.Parameters.AddWithValue("@EmailEstudiante", estudiante.EmailEstudiante);
                comando.Parameters.AddWithValue("@EmailEstudiante", estudiante.EmailEstudiante.Address);
                comando.ExecuteNonQuery();
            }
        }


        public void Eliminar(string identificacion)
        {
            using (var comando = conn.CreateCommand())
            {
                comando.CommandText = "sp_crud_estudiante ";
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@intProceso", 4);
                comando.Parameters.AddWithValue("@EstudianteNid", identificacion);
                comando.Parameters.AddWithValue("@NombreEstudiante", DBNull.Value);
                comando.Parameters.AddWithValue("@ApellidoEstudiante", DBNull.Value);
                comando.Parameters.AddWithValue("@FechNacEstudiante", DBNull.Value);
                comando.Parameters.AddWithValue("@DirEstudiante", DBNull.Value);
                comando.Parameters.AddWithValue("@TelfEstudiante", DBNull.Value);
                comando.Parameters.AddWithValue("@EmailEstudiante", DBNull.Value);
                comando.ExecuteNonQuery();
            }

        }


        public void ModificarEstudiante(Estudiante estudiante)
        {
            using (var comando = conn.CreateCommand())
            {
                comando.CommandText = "sp_crud_estudiante ";
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@intProceso", 3);
                comando.Parameters.AddWithValue("@EstudianteNid", estudiante.EstudianteNid);
                comando.Parameters.AddWithValue("@NombreEstudiante", estudiante.NombreEstudiante);
                comando.Parameters.AddWithValue("@ApellidoEstudiante", estudiante.ApellidoEstudiante);
                comando.Parameters.AddWithValue("@FechNacEstudiante", estudiante.FechNacEstudiante);
                comando.Parameters.AddWithValue("@DirEstudiante", estudiante.DirEstudiante);
                comando.Parameters.AddWithValue("@TelfEstudiante", estudiante.TelfEstudiante);
                comando.Parameters.AddWithValue("@EmailEstudiante", estudiante.EmailEstudiante.Address);
                comando.ExecuteNonQuery();
            }
        }



        public Estudiante Buscar(string identificacion)
        {
            using (var comando = conn.CreateCommand())
            {
                comando.CommandText = "sp_crud_estudiante ";
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@intProceso", 5);
                comando.Parameters.AddWithValue("@EstudianteNid", identificacion);
                comando.Parameters.AddWithValue("@NombreEstudiante", DBNull.Value);
                comando.Parameters.AddWithValue("@ApellidoEstudiante", DBNull.Value);
                comando.Parameters.AddWithValue("@FechNacEstudiante", DBNull.Value);
                comando.Parameters.AddWithValue("@DirEstudiante", DBNull.Value);
                comando.Parameters.AddWithValue("@TelfEstudiante", DBNull.Value);
                comando.Parameters.AddWithValue("@EmailEstudiante", DBNull.Value);
                var Reader = comando.ExecuteReader();
                if (Reader.HasRows)
                {
                    while (Reader.Read())
                    {
                        Estudiante estudiante = new Estudiante();
                        estudiante = Mapear(Reader);
                        return estudiante;
                    }
                }
            }
            return null;
        }

        public List<Estudiante> Consultar()
        {
            estudiantes.Clear();
            using(var comando = conn.CreateCommand())
            {
                comando.CommandText = "sp_crud_estudiante ";
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@intProceso", 1);
                comando.Parameters.AddWithValue("@EstudianteNid", DBNull.Value);
                comando.Parameters.AddWithValue("@NombreEstudiante", DBNull.Value);
                comando.Parameters.AddWithValue("@ApellidoEstudiante", DBNull.Value);
                comando.Parameters.AddWithValue("@FechNacEstudiante", DBNull.Value);
                comando.Parameters.AddWithValue("@DirEstudiante", DBNull.Value);
                comando.Parameters.AddWithValue("@TelfEstudiante", DBNull.Value);
                comando.Parameters.AddWithValue("@EmailEstudiante", DBNull.Value);
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
            estudiante.FechNacEstudiante = Convert.ToDateTime((string)reader["FechNacEstudiante"]);
            estudiante.DirEstudiante = (string)reader["DirEstudiante"];
            estudiante.TelfEstudiante = (string)reader["TelfEstudiante"];
            //estudiante.EmailEstudiante = (string)reader["EmailEstudiante"];
            estudiante.EmailEstudiante = new MailAddress((string)reader["EmailEstudiante"]);

            return estudiante;
        }
    }
}
