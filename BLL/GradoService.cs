using DAL;
using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class GradoService
    {
        private ConnectionManager conexion;
        private GradoRepository gradoRepository;
        List<Grado> gradolista;
        Grado grado;

        public GradoService(string connectionString) 
        {
            conexion = new ConnectionManager(connectionString);
            gradoRepository = new GradoRepository(conexion);
        }


        public string GuardarGrado(Grado grado)
        {

            try
            {
                conexion.Open();
                bool validarnombregrado = gradoRepository.ValidarNombreGrado(grado.NombreG);
                if (validarnombregrado)
                {
                    return $"Los datos del Grado  {grado.NombreG} ya se encuentra registrado";
                }
                gradoRepository.GuardarGrado(grado);

                return $"Los datos del Grado  {grado.NombreG} han sido guardados satiafactoriamente";
            }
            catch (Exception e)
            {
                return $"Error de base de datos: {e.Message}";
            }
            finally
            {
                conexion.Close();
            }

        }


        public string EliminarGrado(string id)
        {

            try
            {
                conexion.Open();
                gradoRepository.EliminarGrado(id);

                return $"Los datos han sido eliminados satiafactoriamente";
            }
            catch (Exception e)
            {
                return $"Error de base de datos: {e.Message}";
            }
            finally
            {
                conexion.Close();
            }

        }

        public string Modificargrado(Grado grado)
        {
            try
            {
                conexion.Open();
                gradoRepository.ModificarGrado(grado);


                return "Registro Modificado correctamente";
            }
            catch (Exception e)
            {

                return $"Error de base de datos {e.Message.ToString()}";
            }
            finally
            {
                conexion.Close();
            }

        }


        public Grado Buscar(string id)
        {

            try
            {
                conexion.Open();
                grado = new Grado();
                grado = gradoRepository.Buscar(id);
                conexion.Close();
                return grado;
            }
            catch (Exception e)
            {


                string Mensaje = "error de datos" + e.Message.ToString();
            }
            return null;
        }


        public List<Grado> Consultar()
        {
            try
            {
                gradolista = new List<Grado>();
                conexion.Open();
                gradolista = gradoRepository.Consultar();
                return gradolista;

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
