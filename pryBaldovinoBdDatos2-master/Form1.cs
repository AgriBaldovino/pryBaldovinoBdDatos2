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
    public partial class Form1 : Form
    {
        //declaracion de variables y objetos globales
        //utilizaremos las variables publicas para usarlas en todo el proyecto
        public OleDbConnection conexionBase;
        public OleDbConnection queQuieroDeLaBase;
        public OleDbConnection lectorDeConsultas;
        public string varRutaDeBaseDeDatos = "DEPORTE.accdb";

        

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                lblFechaActual.Text = DateTime.Now.ToString();
                conexionBase = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + varRutaDeBaseDeDatos);
                conexionBase.Open();
                lblEstado.Text = "Conectado:" + conexionBase.ConnectionString;
                statusStrip1.BackColor = Color.GreenYellow;
            }
            catch (Exception mensajito)
            {
                lblEstado.Text = mensajito.Message;
                statusStrip1.BackColor = Color.Red;


                // throw;
            }
        }

        private void deportistasToolStripMenuItem_Click(object sender, EventArgs e)
        {

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
    }
}
