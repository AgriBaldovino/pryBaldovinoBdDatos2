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
    public partial class frmConsultaEntrenadores : Form
    {
        
        public OleDbConnection ConexionBD;
        public OleDbCommand ComandoBD;
        public OleDbDataReader LectorBD;
        public string RutaBD = "DEPORTE.accdb";

        public frmConsultaEntrenadores()
        {
            InitializeComponent();
        }

        private void frmConsultaEntrenadores_Load(object sender, EventArgs e)
        {
           
        }

        private void cmdSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmdListar_Click(object sender, EventArgs e)
        {
            dgvEntrenadores.Rows.Clear();
            try
            {
                ConexionBD = new OleDbConnection("Provider = Microsoft.ACE.OLEDB.12.0;Data source=" + RutaBD);
                ConexionBD.Open();

               
                ComandoBD = new OleDbCommand();

                ComandoBD.Connection = ConexionBD;
                ComandoBD.CommandType = CommandType.TableDirect;
                ComandoBD.CommandText = "ENTRENADORES";

                LectorBD = ComandoBD.ExecuteReader();

                while (LectorBD.Read())
                {
                    dgvEntrenadores.Rows.Add(LectorBD[0], LectorBD[1], LectorBD[2], LectorBD[3], LectorBD[4], LectorBD[5]);
                }
                LectorBD.Close();
                ConexionBD.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Error");
            }
        }
    }
}
