using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace pryBaldovinoBdDatos2
{
    public partial class frmPrincipal : Form
    {
        //Creo la conexion de la base de datos
        public OleDbConnection ConexionBD;
        //
        public OleDbCommand ComandoBD;
        //Creo el lector de la base de datos
        public OleDbDataReader LectorBD;

        //Declaro la variable de la ruta de la base de datos
        public string RutaBD = "DEPORTE.accdb";

        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                //Con esto indico que la base de datos se conecto de manera exitosa
                sSInicio.BackColor = Color.Green;
            }
            catch (Exception Indicador)
            {
                //Con esto indico que no se pudo conectar con la base de datos
                sSInicio.BackColor = Color.Red;
            }
        }

        private void deportistasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRegistroDeportistas objvent = new frmRegistroDeportistas();
            objvent.ShowDialog();
        }

        private void deportistasToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmConsultaDeportistas frmConsultaDeportista = new frmConsultaDeportistas();
            frmConsultaDeportista.ShowDialog();
        }

        private void entrenadoresToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmConsultaEntrenadores frmConsultaEntrenador = new frmConsultaEntrenadores();
            frmConsultaEntrenador.ShowDialog();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void consultasToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void entrenadoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRegistroEntrenadores objvent = new frmRegistroEntrenadores();
            objvent.ShowDialog();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void deportistasToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            frmEliminarDeportista objvent = new frmEliminarDeportista();
            objvent.ShowDialog();
        }

        private void entrenadoresToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            frmEliminarEntrenador objvent = new frmEliminarEntrenador();
            objvent.ShowDialog();
        }

        private void deportistasToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            frmModificarDeportista objvent = new frmModificarDeportista();
            objvent.ShowDialog();
        }

        private void entrenadoresToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            frmModificarEntrenador objvent = new frmModificarEntrenador();
            objvent.ShowDialog();
        }
    }
}
