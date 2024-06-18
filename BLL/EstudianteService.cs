﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Entity;
using Estructuras;

namespace BLL
{
    public class EstudianteService
    {
        private ConnectionManager conexion;
        private EstudianteRepository estudianteRepository;
        List<Estudiante> estudianteLista;
        Estudiante estudiante;
        //Email email = new Email();


        public EstudianteService(string connectionString)
        {
            conexion = new ConnectionManager(connectionString);

            estudianteRepository = new EstudianteRepository(conexion);
        }

        public string GuardarEstudiante(Estudiante estudiante)
        {
            //Email email = new Email();
            //string mensajeEmail = string.Empty;
            try
            {
                conexion.Open();
                estudianteRepository.GuardarEstudiante(estudiante);
                //mensajeEmail = email.EnviarEmail(estudiante);
                

                return $"Los datos del estudiante  {estudiante.NombreEstudiante} han sido guardados satiafactoriamente";
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


        public string Eliminar(string identificacion)
        {
            try
            {
                conexion.Open();
                estudianteRepository.Eliminar(identificacion);
                return $"Los datos del cliente han sido eliminados satiafactoriamente";


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


        public string Modificar(Estudiante estudiante)

        {
            try
            {
                conexion.Open();
                estudianteRepository.ModificarEstudiante(estudiante);


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


        public Estudiante Buscar(string identificacion)
        {

            try
            {
                conexion.Open();
                estudiante = new Estudiante();
                estudiante = estudianteRepository.Buscar(identificacion);
                conexion.Close();
                return estudiante;
            }
            catch (Exception e)
            {


                string Mensaje = "error de datos" + e.Message.ToString();
            }
            return null;
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
