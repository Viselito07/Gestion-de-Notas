using DAL;
using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class DocenteService
    {
        private ConnectionManager conexion;
        private DocenteRepository docenteRepository;
        List<Docente> docenteLista;
        Docente docente;

        public DocenteService(string connectionString)
        {
            conexion = new ConnectionManager(connectionString);

            docenteRepository = new DocenteRepository(conexion);
        }

        public string GuardarDocente(Docente docente)
        {
            
            try
            {
                conexion.Open();
                docenteRepository.GuardarDocente(docente);

                return $"Los datos del Docente  {docente.NombresDocente} han sido guardados satiafactoriamente";
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


        public string EliminarDocente(string identificacion)
        {
            try
            {
                conexion.Open();
                docenteRepository.EliminarDocente(identificacion);
                return $"Los datos del Docente han sido eliminados satiafactoriamente";


            }
            catch (Exception e)
            {
                return $"Error de la aplicacion: {e.Message}";
            }
            finally
            {
                conexion.Close();
            }
        }


        public string ModificarDocente(Docente docente)

        {
            try
            {
                conexion.Open();
                docenteRepository.ModificarDocente(docente);


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


        public Docente Buscar(string identificacion)
        {

            try
            {
                conexion.Open();
                docente = new Docente();
                docente = docenteRepository.Buscar(identificacion);
                conexion.Close();
                return docente;
            }
            catch (Exception e)
            {


                string Mensaje = "error de datos" + e.Message.ToString();
            }
            return null;
        }


        public List<Docente> Consultar()
        {
            try
            {
                docenteLista = new List<Docente>();
                conexion.Open();
                docenteLista = docenteRepository.Consultar();
                return docenteLista;

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

