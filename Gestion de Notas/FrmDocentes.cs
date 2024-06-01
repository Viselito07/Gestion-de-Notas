using BLL;
using Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestion_de_Notas
{
    public partial class FrmDocentes : Form
    {

        SqlConnection conn;
        DocenteService docenteService;
        public FrmDocentes()
        {
            InitializeComponent();
            docenteService = new DocenteService(ConfigConnection.connectionString);
            dataGridView1.DataSource = docenteService.Consultar();

        }

        private void btn_cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_buscarD_Click(object sender, EventArgs e)
        {
            DocenteService docenteServi = new DocenteService(ConfigConnection.connectionString);
            dataGridView1.DataSource = docenteServi.Consultar();
        }

        private void btn_guardarD_Click(object sender, EventArgs e)
        {
            Docente docente = new Docente();
            docente.DocenteNid = txt_nidD.Text;
            docente.NombresDocente = txt_nombreD.Text;
            docente.ApellidosDocente = txt_apellidosD.Text;
            docente.FechaNacDocente = Convert.ToDateTime(dtpFechNac.Text.ToString());
            docente.DirDocente = txt_direccionD.Text;
            docente.Especialidad = txt_Especialidad.Text;
            docente.TelfDocente = txt_telefonoD.Text;
            string mensaje = docenteService.GuardarDocente(docente);
            MessageBox.Show(mensaje, "Mensaje De Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            docenteService = new DocenteService(ConfigConnection.connectionString);
            dataGridView1.DataSource = docenteService.Consultar();
            Limpiar();
        }


        private void Limpiar()
        {
            txt_nidD.Text = "";
            txt_nombreD.Text = "";
            txt_apellidosD.Text = "";
            dtpFechNac.Text = "";
            txt_direccionD.Text = "";
            txt_Especialidad.Text = "";
            txt_telefonoD.Text = "";
            
        }

        private void btn_eliminarD_Click(object sender, EventArgs e)
        {
            string identificacion = txt_nidD.Text;
            if (identificacion != "")
            {

                Docente estudiante = docenteService.Buscar(identificacion);
                if (estudiante != null)
                {
                    var respuestaa = MessageBox.Show("Esta seguro que desea eliminar esta persona?", "", MessageBoxButtons.YesNo);
                    if (respuestaa == DialogResult.Yes)
                    {
                        string mensaje = docenteService.EliminarDocente(identificacion);
                        MessageBox.Show(mensaje, "Mesaje de Eliminacion", MessageBoxButtons.OKCancel);
                        docenteService = new DocenteService(ConfigConnection.connectionString);
                        dataGridView1.DataSource = docenteService.Consultar();
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
                    txt_nidD.Focus();
                }
            }
        }

        private void btn_modificarD_Click(object sender, EventArgs e)
        {
            string id = txt_nidD.Text;
            if (id != "")
            {
                Docente docente = docenteService.Buscar(id);
                if (docente != null)
                {
                    docente.NombresDocente = txt_nombreD.Text;
                    docente.ApellidosDocente = txt_apellidosD.Text;
                    docente.FechaNacDocente = Convert.ToDateTime(dtpFechNac.Text.ToString());
                    docente.DirDocente = txt_direccionD.Text;
                    docente.Especialidad = txt_Especialidad.Text;
                    docente.TelfDocente = txt_telefonoD.Text;
                    var respuesta = MessageBox.Show("Esta seguro que desea modificar al cliente?", "", MessageBoxButtons.YesNo);
                    if (respuesta == DialogResult.Yes)
                    {
                        string mensaje = docenteService.ModificarDocente(docente);
                        MessageBox.Show(mensaje, "Mensaje de Modificacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        docenteService = new DocenteService(ConfigConnection.connectionString);
                        dataGridView1.DataSource = docenteService.Consultar();
                        Limpiar();
                    }
                }
            }
        }
    }
}
