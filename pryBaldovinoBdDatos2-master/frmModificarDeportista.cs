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
    public partial class frmModificarDeportista : Form
    {
        public frmModificarDeportista()
        {
            InitializeComponent();
        }

        private void frmModificarDeportista_Load(object sender, EventArgs e)
        {
            txtCodigo.Focus();
        }

        private void cmdModificar_Click(object sender, EventArgs e)
        {
            string CodigoD = txtCodigo.Text;

            clsDeportista Modificar = new clsDeportista();

            Modificar.Modificar(CodigoD);
            MessageBox.Show("Datos guardados con exito");

            Limpiar();
            txtCodigo.Focus();

        }

        private void cmdBuscar_Click(object sender, EventArgs e)
        {
            string Codigo = txtCodigo.Text;
            clsDeportista BuscarED = new clsDeportista();
            BuscarED.Buscar(Codigo);

            if (BuscarED.CDeportista != Codigo)
            {
                MessageBox.Show("El deportista no se encuentra en la base de datos");
            }
            else
            {
                txtNombre.Text = BuscarED.Nombre;
                txtApellido.Text = BuscarED.Apellido;
                txtDireccion.Text = BuscarED.Direccion;
                mskTelefono.Text = Convert.ToString(BuscarED.Telefono);
                mskEdad.Text = Convert.ToString(BuscarED.Edad);
                lstDeporte.Text = Convert.ToString(BuscarED.Deportes);
            }
        }

        private void verificacionBotones()
        {
            if (txtNombre.Text != "" && txtApellido.Text != "" && txtDireccion.Text != "" && mskTelefono.Text != "" && mskEdad.Text != "" && lstDeporte.SelectedIndex >= 0)
            {
                cmdGuardar.Enabled = true;
            }
            else
            {
                cmdGuardar.Enabled = false;
            }
        }

        private void verificacionBoton()
        {
            if (txtCodigo.Text != "")
            {
                cmdBuscar.Enabled = true;
            }
            else
            {
                cmdBuscar.Enabled = false;
            }
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

        private void txtCodigo_TextChanged(object sender, EventArgs e)
        {
            verificacionBoton();
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

        private void mskTelefono_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            verificacionBotones();
        }

        private void mskEdad_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            verificacionBotones();
        }

        private void lstDeporte_SelectedIndexChanged(object sender, EventArgs e)
        {
            verificacionBotones();
        }
    }
}
