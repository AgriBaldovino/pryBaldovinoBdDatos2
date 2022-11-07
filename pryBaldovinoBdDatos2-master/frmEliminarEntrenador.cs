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
    public partial class frmEliminarEntrenador : Form
    {
        public frmEliminarEntrenador()
        {
            InitializeComponent();
        }

        private void cmdSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmdBuscar_Click(object sender, EventArgs e)
        {
            string Codigo = txtCodigo.Text;
            clsEntrenador BuscarED = new clsEntrenador();
            BuscarED.Buscar(Codigo);

            if (BuscarED.CEntrenador != Codigo)
            {
                MessageBox.Show("El entrenador no se encuentra en la base de datos");

            }
            else
            {
                lblNombre.Text = BuscarED.Nombre;
                lblApellido.Text = BuscarED.Apellido;
                lblDireccion.Text = BuscarED.Direccion;
                lblProvincia.Text = BuscarED.Provincia;
                lblDeporte.Text = Convert.ToString(BuscarED.Deporte);
            }
        }

        private void cmdEliminar_Click(object sender, EventArgs e)
        {
            string CodigoEntrenador = txtCodigo.Text;

            clsEntrenador EliminarED = new clsEntrenador();

            EliminarED.Eliminar(CodigoEntrenador);
            MessageBox.Show("Datos borrados con exito");

            Limpiar();
            txtCodigo.Focus();
        }

        private void frmEliminarEntrenador_Load(object sender, EventArgs e)
        {
            txtCodigo.Focus();
        }

        private void txtCodigo_TextChanged(object sender, EventArgs e)
        {
            verificacionBoton();
        }
        private void Limpiar()
        {
            txtCodigo.Text = "";
            lblNombre.Text = "";
            lblApellido.Text = "";
            lblDireccion.Text = "";
            lblProvincia.Text = "";
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


    }
}
