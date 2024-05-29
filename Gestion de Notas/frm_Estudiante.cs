using BLL;
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
    public partial class Frm_Estudiante : Form
    {
        SqlConnection conn;
        public Frm_Estudiante()
        {
            InitializeComponent();
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


       
    }
}
