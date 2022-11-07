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
    public partial class frmConsultaDeportistas : Form
    {
        public OleDbConnection ConexionBD;
        public OleDbCommand ComandoBD;
        public OleDbDataReader LectorBD;

        public string RutaBD = "DEPORTE.accdb";


        public frmConsultaDeportistas()
        {
            InitializeComponent();
        }

        private void frmConsultaDeportistas_Load(object sender, EventArgs e)
        {
            
        }

        private void cmdListar_Click(object sender, EventArgs e)
        {
            dgvDeportistas.Rows.Clear();
            try
            {
                ConexionBD = new OleDbConnection("Provider = Microsoft.ACE.OLEDB.12.0;Data source=" + RutaBD);
                ConexionBD.Open();

                ComandoBD = new OleDbCommand();

                ComandoBD.Connection = ConexionBD;
                ComandoBD.CommandType = CommandType.TableDirect;
                ComandoBD.CommandText = "DEPORTISTA";

                LectorBD = ComandoBD.ExecuteReader();

                while (LectorBD.Read())
                {
                    dgvDeportistas.Rows.Add(LectorBD["Codigo deportista"], LectorBD["Nombre"], LectorBD["Apellido"], LectorBD["Direccion"], LectorBD["Telefono"], LectorBD["Edad"], LectorBD["Deporte"]);
                }
                LectorBD.Close();
                ConexionBD.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Error");
            }

            //dgvDeportistas.Rows.Clear();
        }

        private void dgvDeportistas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void cmdSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
