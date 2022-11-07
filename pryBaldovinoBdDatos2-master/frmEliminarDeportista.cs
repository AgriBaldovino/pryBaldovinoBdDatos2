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
    public partial class frmEliminarDeportista : Form
    {
        public frmEliminarDeportista()
        {
            InitializeComponent();
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
                lblNombre.Text = BuscarED.Nombre;
                lblApellido.Text = BuscarED.Apellido;
                lblDireccion.Text = BuscarED.Direccion;
                lblTelefono.Text = Convert.ToString(BuscarED.Telefono);
                lblEdad.Text = Convert.ToString(BuscarED.Edad);
                lblDeporte.Text = Convert.ToString(BuscarED.Deportes);
            }
        }

        private void frmEliminarDeportista_Load(object sender, EventArgs e)
        {
            txtCodigo.Focus();
        }

        private void cmdEliminar_Click(object sender, EventArgs e)
        {
            string CodigoDeportista = txtCodigo.Text;

            clsDeportista EliminarED = new clsDeportista();

            EliminarED.Eliminar(CodigoDeportista);
            MessageBox.Show("Datos borrados con éxito");

            Limpiar();
            txtCodigo.Focus();
        }

        private void Limpiar()
        {
            txtCodigo.Text = "";
            lblNombre.Text = "";
            lblApellido.Text = "";
            lblDireccion.Text = "";
            lblTelefono.Text = "";
            lblEdad.Text = "";
            lblDeporte.Text = "";
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

        private void txtCodigo_TextChanged(object sender, EventArgs e)
        {
            verificacionBoton();
        }
    }
}
