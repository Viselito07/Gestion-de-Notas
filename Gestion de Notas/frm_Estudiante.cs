using BLL;
using Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;

namespace Gestion_de_Notas
{
    public partial class Frm_Estudiante : Form
    {
        SqlConnection conn;
        EstudianteService estudianteService;
        public Frm_Estudiante()
        {
            InitializeComponent();
            estudianteService = new EstudianteService(ConfigConnection.connectionString);
            dataGridView1.DataSource = estudianteService.Consultar();
        }

        private void btn_cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            EstudianteService estudianteservi = new EstudianteService(ConfigConnection.connectionString);
            dataGridView1.DataSource = estudianteservi.Consultar();
        }

        private void btn_agregar_Click(object sender, EventArgs e)
        {

            Estudiante estudiante = new Estudiante();
            estudiante.EstudianteNid = txt_nid.Text;
            estudiante.NombreEstudiante = txt_nombre.Text;
            estudiante.ApellidoEstudiante = txt_apellido.Text;
            estudiante.FechNacEstudiante = Convert.ToDateTime(dtp_fechNacE.Text.ToString());
            estudiante.DirEstudiante = txt_direccion.Text;
            estudiante.TelfEstudiante = txt_telefono.Text;
            //estudiante.EmailEstudiante = (txt_email.Text);
            estudiante.EmailEstudiante = new MailAddress(txt_email.Text.Trim());
            string mensaje = estudianteService.GuardarEstudiante(estudiante);
            MessageBox.Show(mensaje, "Mensaje De Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            estudianteService = new EstudianteService(ConfigConnection.connectionString);
            dataGridView1.DataSource = estudianteService.Consultar();
            Limpiar();
        }

        
        private void Limpiar()
        {
            txt_nid.Text = "";
            txt_nombre.Text = "";
            txt_apellido.Text = "";
            dtp_fechNacE.Text = "";
            txt_direccion.Text = "";
            txt_telefono.Text = "";
            txt_email.Text = "";
        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            string identificacion = txt_nid.Text;
            if (identificacion != "")
            {

                Estudiante estudiante = estudianteService.Buscar(identificacion);
                if (estudiante != null)
                {
                    var respuestaa = MessageBox.Show("Esta seguro que desea eliminar?", " ", MessageBoxButtons.YesNo);
                    if (respuestaa == DialogResult.Yes)
                    {
                        string mensaje = estudianteService.Eliminar(identificacion);
                        MessageBox.Show(mensaje, "Mesaje de Eliminacion", MessageBoxButtons.OKCancel);
                        estudianteService = new EstudianteService(ConfigConnection.connectionString);
                        dataGridView1.DataSource = estudianteService.Consultar();
                        Limpiar();

                    }
                    else
                    {
                        MessageBox.Show($" la identificacion {identificacion} no esta en el sistema");
                    }

                }
                else
                {
                    MessageBox.Show($" Digite la identificacion por favor ");
                    txt_nid.Focus();
                }
            }
        }

        private void btn_actualizar_Click(object sender, EventArgs e)
        {
            string id = txt_nid.Text;
            if (id != "")
            {
                Estudiante estudiante = estudianteService.Buscar(id);
                if (estudiante != null)
                {
                    estudiante.NombreEstudiante = txt_nombre.Text;
                    estudiante.ApellidoEstudiante = txt_apellido.Text;
                    estudiante.FechNacEstudiante = Convert.ToDateTime(dtp_fechNacE.Text.ToString());
                    estudiante.DirEstudiante = txt_direccion.Text;
                    estudiante.TelfEstudiante = txt_telefono.Text;                   
                    estudiante.EmailEstudiante = new MailAddress(txt_email.Text.ToString());
                    var respuesta = MessageBox.Show("Esta seguro que desea modificar al cliente?", "", MessageBoxButtons.YesNo);
                    if (respuesta == DialogResult.Yes)
                    {
                        string mensaje = estudianteService.Modificar(estudiante);
                        MessageBox.Show(mensaje, "Mensaje de Modificacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        estudianteService = new EstudianteService(ConfigConnection.connectionString);
                        dataGridView1.DataSource = estudianteService.Consultar();
                        Limpiar();
                    }
                }
            }
        }
    }
}
