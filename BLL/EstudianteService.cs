using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Entity;

namespace BLL
{
    public class EstudianteService
    {
        private ConnectionManager conexion;
        private EstudianteRepository estudianteRepository;
        List<Estudiante> estudianteLista;
        Estudiante estudiante;


        public EstudianteService(string connectionString)
        {
            conexion = new ConnectionManager(connectionString);

            estudianteRepository = new EstudianteRepository(conexion);
        }


        public List<Estudiante> Consultar()
        {
            try
            {
                estudianteLista = new List<Estudiante>();
                conexion.Open();
                estudianteLista = estudianteRepository.Consultar();
                return estudianteLista;

            }
            catch (Exception e)
            {

                string Mensaje = $"error de datos" + e.Message.ToString();


            }
            finally
            {
                conexion.Close();
            }
            return null;
        }
    }
}
