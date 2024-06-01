using Entity;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DocenteRepository
    {
        SqlConnection conn;
        List<Docente> docentes;

        public DocenteRepository(ConnectionManager Connection)
        {
            conn = Connection.connection;
            docentes = new List<Docente>();
        }

        public void GuardarDocente(Docente docente)
        {
            using (var comando = conn.CreateCommand())
            {
                comando.CommandText = "sp_crud_docente";
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@intProceso", 2);
                comando.Parameters.AddWithValue("@DocenteNid", docente.DocenteNid);
                comando.Parameters.AddWithValue("@NombresDocente", docente.NombresDocente);
                comando.Parameters.AddWithValue("@ApellidosDocente", docente.ApellidosDocente);
                comando.Parameters.AddWithValue("@FechaNacDocente", docente.FechaNacDocente);
                comando.Parameters.AddWithValue("@DirDocente", docente.DirDocente);
                comando.Parameters.AddWithValue("@Especialidad", docente.Especialidad);
                comando.Parameters.AddWithValue("@TelfDocente", docente.TelfDocente);
                comando.ExecuteNonQuery();
            }
        }


        public void EliminarDocente(string identificacion)
        {
            using (var comando = conn.CreateCommand())
            {
                comando.CommandText = "sp_crud_docente";
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@intProceso", 4);
                comando.Parameters.AddWithValue("@DocenteNid", identificacion);
                comando.Parameters.AddWithValue("@NombresDocente", DBNull.Value);
                comando.Parameters.AddWithValue("@ApellidosDocente", DBNull.Value);
                comando.Parameters.AddWithValue("@FechaNacDocente", DBNull.Value);
                comando.Parameters.AddWithValue("@DirDocente", DBNull.Value);
                comando.Parameters.AddWithValue("@Especialidad", DBNull.Value);
                comando.Parameters.AddWithValue("@TelfDocente", DBNull.Value);
                comando.ExecuteNonQuery();
            }

        }


        public void ModificarDocente(Docente docente)
        {
            using (var comando = conn.CreateCommand())
            {
                comando.CommandText = "sp_crud_docente";
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@intProceso", 3);
                comando.Parameters.AddWithValue("@DocenteNid", docente.DocenteNid);
                comando.Parameters.AddWithValue("@NombresDocente", docente.NombresDocente);
                comando.Parameters.AddWithValue("@ApellidosDocente", docente.ApellidosDocente);
                comando.Parameters.AddWithValue("@FechaNacDocente", docente.FechaNacDocente);
                comando.Parameters.AddWithValue("@DirDocente", docente.DirDocente);
                comando.Parameters.AddWithValue("@Especialidad", docente.Especialidad);
                comando.Parameters.AddWithValue("@TelfDocente", docente.TelfDocente);
                comando.ExecuteNonQuery();
            }
        }



        public Docente Buscar(string identificacion)
        {
            using (var comando = conn.CreateCommand())
            {
                comando.CommandText = "sp_crud_docente";
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@intProceso", 5);
                comando.Parameters.AddWithValue("@DocenteNid", identificacion);
                comando.Parameters.AddWithValue("@NombresDocente", DBNull.Value);
                comando.Parameters.AddWithValue("@ApellidosDocente", DBNull.Value);
                comando.Parameters.AddWithValue("@FechaNacDocente", DBNull.Value);
                comando.Parameters.AddWithValue("@DirDocente", DBNull.Value);
                comando.Parameters.AddWithValue("@Especialidad", DBNull.Value);
                comando.Parameters.AddWithValue("@TelfDocente", DBNull.Value);
                var Reader = comando.ExecuteReader();
                if (Reader.HasRows)
                {
                    while (Reader.Read())
                    {
                        Docente docente = new Docente();
                        docente = Mapear(Reader);
                        return docente;
                    }
                }
            }
            return null;
        }

        public List<Docente> Consultar()
        {
            docentes.Clear();
            using (var comando = conn.CreateCommand())
            {
                comando.CommandText = "sp_crud_docente";
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@intProceso", 1);
                comando.Parameters.AddWithValue("@DocenteNid", DBNull.Value);
                comando.Parameters.AddWithValue("@NombresDocente", DBNull.Value);
                comando.Parameters.AddWithValue("@ApellidosDocente", DBNull.Value);
                comando.Parameters.AddWithValue("@FechaNacDocente", DBNull.Value);
                comando.Parameters.AddWithValue("@DirDocente", DBNull.Value);
                comando.Parameters.AddWithValue("@Especialidad", DBNull.Value);
                comando.Parameters.AddWithValue("@TelfDocente", DBNull.Value);
                var Reader = comando.ExecuteReader();
                while (Reader.Read())
                {
                    Docente docente = new Docente();
                    docente = Mapear(Reader);
                    docentes.Add(docente);
                }
            }

            return docentes;
        }

        public Docente Mapear(SqlDataReader reader)
        {
            Docente docente = new Docente();
            docente.IdDoc = Convert.ToInt32(reader["IdDoc"]);
            docente.DocenteNid = (string)reader["DocenteNid"];
            docente.NombresDocente = (string)reader["NombresDocente"];
            docente.ApellidosDocente = (string)reader["ApellidosDocente"];
            docente.FechaNacDocente = Convert.ToDateTime((string)reader["FechaNacDocente"]);
            docente.DirDocente = (string)reader["DirDocente"];
            docente.Especialidad = (string)reader["Especialidad"];
            docente.TelfDocente = (string)reader["TelfDocente"];

            return docente;
        }
    }
}

