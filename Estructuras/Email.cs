using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace Estructuras
{
    public class Email
    {
        private MailMessage email;
        private SmtpClient smtp;
        public Email()
        {

            smtp = new SmtpClient();

        }


        private void ConfigurarEmail(Estudiante estudiante)
        {
            email = new MailMessage();
            email.To.Add(estudiante.EmailEstudiante);
            email.From = new MailAddress(estudiante.EmailEstudiante.ToString());
            email.Subject = "Registro de Usuario a nuestro sistema Gestion Notas  " +
                DateTime.Now.ToString("dd/MMM/YY hh:mm:ss");
            email.Body = $"<b>Sr {estudiante.NombreEstudiante}</b> <br " +
            $" > se ha realizado su registro Sartisfactoriamente";
            email.IsBodyHtml = true;
            email.Priority = MailPriority.Normal;
        }
        private void ConfigurarEmailReporte(string correo, string ruta)
        {
            email = new MailMessage();
            email.To.Add(correo);
            email.From = new MailAddress(correo);
            email.Subject = "Registro de Usuario " +
                DateTime.Now.ToString("dd/MMM/YY hh:mm:ss");
            email.Body = $"<b>Sr {correo}</b> <br " +
            $" > Envio De Reporte";
            System.Net.Mail.Attachment adjunto = new System.Net.Mail.Attachment(ruta);
            email.Attachments.Add(adjunto);
            email.IsBodyHtml = true;
            email.Priority = MailPriority.Normal;
        }

        public string EnviarEmail(Estudiante estudiante)
        {
            try
            {
                ConfigurarStmp();
                ConfigurarEmail(estudiante);
                smtp.Send(email);
                return ("Correo enviado satisfactoriamente");
            }
            catch (Exception e)
            {

                return ("error al enviar correo" + e.Message);
            }
            finally
            {
                email.Dispose();
            }
        }
        public string EnviarEmailReporte(string correo, string ruta)
        {
            try
            {
                ConfigurarStmp();
                ConfigurarEmailReporte(correo, ruta);
                smtp.Send(email);
                return ("Correo enviado satisfactoriamente");
            }
            catch (Exception e)
            {

                return ("error al enviar correo" + e.Message);
            }
            finally
            {
                email.Dispose();
            }
        }



        private void ConfigurarStmp()
        {
            smtp.Host = "smtp.gmail.com";
            smtp.Port = 587;
            smtp.EnableSsl = true;
            smtp.UseDefaultCredentials = false;
            smtp.Credentials =
                new System.Net.NetworkCredential(" baadgis@gmail.com", "familia05");

        }
    }
}
