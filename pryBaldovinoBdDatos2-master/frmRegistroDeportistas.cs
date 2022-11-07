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
    public partial class frmRegistroDeportistas : Form
    {
        public OleDbConnection ConexionBase;
        public OleDbCommand ComandoBase;
        public OleDbDataReader LectorBase;

        public string CadenaConexion = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + "DEPORTE.accdb";

        public frmRegistroDeportistas()
        {
            InitializeComponent();
        }

        private void cmdBorrar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void cmdRegistrar_Click(object sender, EventArgs e)
        {
            string CodigoDeportista = Convert.ToString(txtCodigo.Text);
            string Nombre = txtNombre.Text;
            string Apellido = txtApellido.Text;
            string Direccion = Convert.ToString(txtDireccion.Text);
            Int32 Telefono = Convert.ToInt32(mskTelefono.Text);
            Int32 Edad = Convert.ToInt32(mskEdad.Text);
            String Deporte = Convert.ToString(lstDeporte.SelectedItem);

            try
            {
                ConexionBase = new OleDbConnection(CadenaConexion);
                ConexionBase.Open();

                ComandoBase = new OleDbCommand();

                ComandoBase.Connection = ConexionBase;
                ComandoBase.CommandType = CommandType.Text;
                //Carga de la base de datos
                ComandoBase.CommandText = "INSERT INTO" + " DEPORTISTA ([CODIGO DEPORTISTA], [NOMBRE], [APELLIDO], [DIRECCION], [TELEFONO], [EDAD], [DEPORTE])" +
                " VALUES ('" + CodigoDeportista + "','" + Nombre + "','" + Apellido + "','" + Direccion + "','" + Telefono + "','" + Edad + "','" + Deporte + "')";

                ComandoBase.ExecuteNonQuery();

                MessageBox.Show("Datos cargados con exito");
            }
            catch (Exception)
            {
                MessageBox.Show("Error");
            }
            ConexionBase.Close();

            Limpiar();

            txtNombre.Focus();
        }

        private void cmdSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmRegistroDeportistas_Load(object sender, EventArgs e)
        {
            txtNombre.Focus();
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            verificacionBotones();
        }

        private void verificacionBotones()
        {
            if (txtCodigo.Text != "" && txtNombre.Text != "" && txtApellido.Text != "" && txtDireccion.Text != "" && mskTelefono.Text != "" && mskEdad.Text != "" && lstDeporte.SelectedIndex >= 0)
            {
                cmdRegistrar.Enabled = true;
            }
            else
            {
                cmdRegistrar.Enabled = false;
            }
        }

        private void txtApellido_TextChanged(object sender, EventArgs e)
        {
            verificacionBotones();
        }

        private void txtDireccion_TextChanged(object sender, EventArgs e)
        {
            verificacionBotones();
        }

        private void txtEdad_TextChanged(object sender, EventArgs e)
        {
            verificacionBotones();
        }

        private void txtTelefono_TextChanged(object sender, EventArgs e)
        {
            verificacionBotones();
        }

        private void txtCodigo_TextChanged(object sender, EventArgs e)
        {
            verificacionBotones();
        }

        private void lstDeporte_SelectedIndexChanged(object sender, EventArgs e)
        {
            verificacionBotones();
        }

        private void maskedTextBox1_TextChanged(object sender, EventArgs e)
        {
            verificacionBotones();
        }

        private void maskedTextBox2_TextChanged(object sender, EventArgs e)
        {
            verificacionBotones();
        }

        private void Limpiar()
        {
            txtApellido.Text = "";
            txtCodigo.Text = "";
            lstDeporte.SelectedIndex = -1;
            txtDireccion.Text = "";
            txtNombre.Text = "";
            mskEdad.Text = "";
            mskTelefono.Text = "";
        }

    }
}
