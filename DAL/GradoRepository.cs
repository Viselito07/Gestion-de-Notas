using Entity;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class GradoRepository
    {
        SqlConnection conn;
        List<Grado> grados;


        public GradoRepository(ConnectionManager Connection)
        {
            conn = Connection.connection;
            grados = new List<Grado>();
        }


        public void GuardarGrado(Grado grado)
        {
            using (var comando = conn.CreateCommand())
            {
                comando.CommandText = "sp_crud_grado";
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@intProceso", 2);
                comando.Parameters.AddWithValue("@Idg", grado.IdG);
                comando.Parameters.AddWithValue("@NombreG", grado.NombreG);
                comando.ExecuteNonQuery();
            }
        }

        public bool ValidarNombreGrado(string nombreG)
        {
            Grado grado = null;

            using (var comando = conn.CreateCommand())
            {
                comando.CommandText = "sp_crud_grado";
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@intProceso", 6);
                comando.Parameters.AddWithValue("@NombreG", nombreG);
                var Reader = comando.ExecuteReader();
                if (Reader.HasRows)
                {
                    while (Reader.Read())
                    {
                        grado = new Grado();
                        grado = Mapear(Reader);
                        if (grado != null)
                        {
                            return true;
                        }
                    }
                }
                Reader.Close();

            }
            return false;
        }
        public void EliminarGrado(string identificacion)
        {
            using (var comando = conn.CreateCommand())
            {
                comando.CommandText = "sp_crud_grado";
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@intProceso", 4);
                comando.Parameters.AddWithValue("@Idg", identificacion);
                comando.Parameters.AddWithValue("@NombreG", DBNull.Value);
                comando.ExecuteNonQuery();
            }
        }


        public void ModificarGrado(Grado grado)
        {
            using (var comando = conn.CreateCommand())
            {
                comando.CommandText = "sp_crud_grado";
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@intProceso", 3);
                comando.Parameters.AddWithValue("@Idg", grado.IdG);
                comando.Parameters.AddWithValue("@NombreG", grado.NombreG);
                comando.ExecuteNonQuery();
            }
        }


        public Grado Buscar(string identificacion)
        {
            using (var comando = conn.CreateCommand())
            {
                comando.CommandText = "sp_crud_grado";
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@intProceso", 5);
                comando.Parameters.AddWithValue("@Idg", identificacion);
                comando.Parameters.AddWithValue("@NombreG", DBNull.Value);
                var Reader = comando.ExecuteReader();
                if (Reader.HasRows)
                {
                    while (Reader.Read())
                    {
                        Grado grado = new Grado();
                        grado = Mapear(Reader);
                        return grado;
                    }
                }
            }
            return null;
        }



        public List<Grado> Consultar()
        {
            grados.Clear();
            using (var comando = conn.CreateCommand())
            {
                comando.CommandText = "sp_crud_grado";
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@intProceso", 1);
                comando.Parameters.AddWithValue("@Idg", DBNull.Value);
                comando.Parameters.AddWithValue("@NombreG", DBNull.Value);
                var Reader = comando.ExecuteReader();
                while (Reader.Read())
                {
                    Grado grado = new Grado();
                    grado = Mapear(Reader);
                    grados.Add(grado);
                }
            }

            return grados;
        }


        public Grado Mapear(SqlDataReader reader)
        {
            Grado grado = new Grado();
            grado.IdG = Convert.ToInt32(reader["Idg"]);
            grado.NombreG = (string)reader["NombreG"];

            return grado;
        }
    }
}
