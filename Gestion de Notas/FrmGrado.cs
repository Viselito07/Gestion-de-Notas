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

namespace Gestion_de_Notas
{
    public partial class FrmGrado : Form
    {

        SqlConnection conn;
        GradoService gradoService;
        public FrmGrado()
        {
            InitializeComponent();
            gradoService = new GradoService(ConfigConnection.connectionString);
            dataGridView1.DataSource = gradoService.Consultar();
        }

        private void btn_cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            Grado grado = new Grado();
            grado.IdG = Convert.ToInt32(txt_idG.Text);
            grado.NombreG = txt_nombreG.Text;
            string mensaje = gradoService.GuardarGrado(grado);
            MessageBox.Show(mensaje, "Mensaje De Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            gradoService = new GradoService(ConfigConnection.connectionString);
            dataGridView1.DataSource = gradoService.Consultar();
            Limpiar();
        }

        private void Limpiar()
        {
            txt_idG.Text = "";
            txt_nombreG.Text = "";
        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            string id = txt_idG.Text;
            if (id != "")
            {

                Grado grado = gradoService.Buscar(id);
                if (grado != null)
                {
                    var respuestaa = MessageBox.Show("Esta seguro que desea eliminar?", "", MessageBoxButtons.YesNo);
                    if (respuestaa == DialogResult.Yes)
                    {
                        string mensaje = gradoService.EliminarGrado(id);
                        MessageBox.Show(mensaje, "Mesaje de Eliminacion", MessageBoxButtons.OKCancel);
                        gradoService = new GradoService(ConfigConnection.connectionString);
                        dataGridView1.DataSource = gradoService.Consultar();
                        Limpiar();

                    }
                    else 
                    {
                        MessageBox.Show($" la identificacion {id} no esta en el sistema");

                    }                    

                }
                else
                {
                    MessageBox.Show($" Digite la identificacion por favor ");
                    txt_idG.Focus();
                }

            }
        }
    }
}
