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
    public partial class frmRegistroEntrenadores : Form
    {
        
        public OleDbConnection ConexionBD;
        public OleDbCommand ComandoBD;
        
        public OleDbDataReader LectorBD;

        public string RutaBD = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source= " + "DEPORTE.accdb";

        public frmRegistroEntrenadores()
        {
            InitializeComponent();
        }

        private void cmdSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmdBorrar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void cmdRegistrar_Click(object sender, EventArgs e)
        {
            string CodigoEntrenadores = Convert.ToString(lstCodigo.Text);
            string Nombre = txtNombre.Text;
            string Apellido = txtApellido.Text;
            string Direccion = Convert.ToString(txtDireccion.Text);
            string Provincia = txtProvincia.Text;
            string Deporte = Convert.ToString(lstDeporte.SelectedItem);

            try
            {
                ConexionBD = new OleDbConnection(RutaBD);
                ConexionBD.Open();

                ComandoBD = new OleDbCommand();

                ComandoBD.Connection = ConexionBD;
                ComandoBD.CommandType = CommandType.Text;

                //Carga de la base de datos
                ComandoBD.CommandText = "INSERT INTO" + " ENTRENADORES ([CODIGO DEPORTISTA], [NOMBRE], [APELLIDO], [DIRECCION], [PROVINCIA], [DEPORTE])" +
                    " VALUES ('" + CodigoEntrenadores + "','" + Nombre + "','" + Apellido + "','" + Direccion + "','" + Provincia + "','" + Deporte + "')";

                ComandoBD.ExecuteNonQuery();
                MessageBox.Show("Datos almacenados con exito");
            }
            catch (Exception)
            {
                MessageBox.Show("No se pudieron almacenar los datos");
            }
            ConexionBD.Close();

            Limpiar();

            txtNombre.Focus();
        }

        private void frmRegistroEntrenadores_Load(object sender, EventArgs e)
        {
            txtNombre.Focus();
            
            //Lleno las lst con la info que hay en los add
            clsDeportista CompletarLstCodigo = new clsDeportista();
            CompletarLstCodigo.llenarLst(lstCodigo);
            

        }
        private void verificacionBotones()
        {
            if (lstCodigo.SelectedIndex >= 0 && txtNombre.Text != "" && txtApellido.Text != "" && txtDireccion.Text != "" && txtProvincia.Text != "" && lstDeporte.SelectedIndex >= 0)
            {
                cmdRegistrar.Enabled = true;
            }
            else
            {
                cmdRegistrar.Enabled = false;
            }
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            verificacionBotones();
        }

        private void txtApellido_TextChanged(object sender, EventArgs e)
        {
            verificacionBotones();
        }

        private void txtDireccion_TextChanged(object sender, EventArgs e)
        {
            verificacionBotones();
        }

        private void txtProvincia_TextChanged(object sender, EventArgs e)
        {
            verificacionBotones();
        }

        private void lstDeporte_SelectedIndexChanged(object sender, EventArgs e)
        {
            verificacionBotones();
        }

        private void txtCodigo_TextChanged(object sender, EventArgs e)
        {
            verificacionBotones();
        }
        private void Limpiar()
        {
            txtApellido.Text = "";
            lstCodigo.SelectedIndex = -1;
            lstDeporte.SelectedIndex = -1;
            txtDireccion.Text = "";
            txtNombre.Text = "";
            txtProvincia.Text = "";
        }

       


    }
}
