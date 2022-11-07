using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace pryBaldovinoBdDatos2
{
    internal class clsDeportista
    {
        private OleDbConnection Conexion = new OleDbConnection();
        private OleDbCommand Comando = new OleDbCommand();
        private OleDbDataAdapter Adaptador = new OleDbDataAdapter();
        private string Ruta = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source= " + "DEPORTE.accdb";
        private string Tabla = "DEPORTISTA";


        private string CodigoDeportista;
        private string NombreDeportista;
        private string ApellidoDeportista;
        private string DireccionDeportista;
        private Int32 TelefonoDeportista;
        private Int32 EdadDeportista;
        private string Deporte;

        public string CDeportista
        {
            get { return CodigoDeportista; }
            set { CodigoDeportista = value; }
        }
        public string Nombre
        {
            get { return NombreDeportista; }
            set { NombreDeportista = value; }
        }
        public string Apellido
        {
            get { return ApellidoDeportista; }
            set { ApellidoDeportista = value; }
        }
        public string Direccion
        {
            get { return DireccionDeportista; }
            set { DireccionDeportista = value; }
        }
        public Int32 Telefono
        {
            get { return TelefonoDeportista; }
            set { TelefonoDeportista = value; }
        }
        public Int32 Edad
        {
            get { return EdadDeportista; }
            set { EdadDeportista = value; }
        }
        public string Deportes
        {
            get { return Deporte; }
            set { Deporte = value; }
        }

        public void Buscar(string Codigo)
        {
            try
            {
                //Conecto la base de datos
                Conexion.ConnectionString = Ruta;
                Conexion.Open();

                //El comando toma la conexion
                Comando.Connection = Conexion;
                //Este comando me trae la tabla del access
                Comando.CommandType = CommandType.TableDirect;
                //Selecciona la tabla
                Comando.CommandText = Tabla;
                //Recibo el contenido de la tabla
                OleDbDataReader Lector = Comando.ExecuteReader();
                //Si hay registros ingresa
                if (Lector.HasRows)
                {
                    //Mientras tenga datos en la tabla, esto lo va a leer
                    while (Lector.Read())
                    {
                        if (Lector.GetString(0) == Codigo)
                        {
                            CodigoDeportista = Lector.GetString(0);
                            NombreDeportista = Lector.GetString(1);
                            ApellidoDeportista = Lector.GetString(2);
                            DireccionDeportista = Lector.GetString(3);
                            TelefonoDeportista = int.Parse(Lector.GetString(4));
                            EdadDeportista = Lector.GetInt32(5);
                            Deporte = Lector.GetString(6);
                        }
                    }
                }
                Conexion.Close();
            }
            catch (Exception)
            {
            }
        }

        public void Modificar(string CDeportista)
        {
            try
            {
                string Sql = "UPDATE DEPORTISTA SET ([DIRECCION], [TELEFONO], [EDAD], [DEPORTE]) WHERE ('" + CodigoDeportista + "'= [CODIGO DEPORTISTA])";
                
                Conexion.ConnectionString = Ruta;
                Conexion.Open();

                Comando.Connection = Conexion;
                
                Comando.CommandType = CommandType.Text;
                
                Comando.CommandText = Sql;
                Comando.ExecuteNonQuery();


                Conexion.Close();
            }
            catch (Exception)
            {
            }
        }


        public void Eliminar(string CodigoDeportista)
        {
            try
            {
                Conexion.ConnectionString = Ruta;
                Conexion.Open();

                string Sql = "DELETE FROM DEPORTISTA WHERE ('" + CodigoDeportista + "'= [CODIGO DEPORTISTA])";
                
                Comando.Connection = Conexion;
                Comando.CommandType = CommandType.Text;
                Comando.CommandText = Sql;
                Comando.ExecuteNonQuery();

               
            }
            catch (Exception)
            {
                MessageBox.Show("Error al eliminar deportista");
            }
            Conexion.Close();
        }

        public void Agregar()
        {
            try
            {
                string Sql = "INSERT INTO DEPORTISTA ([CODIGO DEPORTISTA], [NOMBRE], [APELLIDO], [DIRECCION], [TELEFONO], [EDAD], [DEPORTE])" +
                    "VALUES ('" + CodigoDeportista + "','" + Nombre + "','" + Apellido + "','" + Direccion + "','" + Telefono + "','" + Edad + "','" + Deporte + "')";
                Conexion.ConnectionString = Ruta;
                Conexion.Open();

                Comando.Connection = Conexion;
                Comando.CommandType = CommandType.Text;
                Comando.CommandText = Sql;
                Comando.ExecuteNonQuery();


                Conexion.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("No se ha podido registrar el dato");
            }
        }
        public void llenarLst(ComboBox lstCodigo)
        {
            Conexion.ConnectionString = Ruta;
            Conexion.Open();
            Comando.Connection = Conexion;
            Comando.CommandType = CommandType.TableDirect;
            Comando.CommandText = Tabla;
            //Adaptador se conecta con la base y trae los datos y se suben los datos a una tabla "virtual"(dataset)
            Adaptador = new OleDbDataAdapter(Comando);
            //Tabla virtual
            DataSet DataConsulta = new DataSet();
            Adaptador.Fill(DataConsulta);
            lstCodigo.DataSource = DataConsulta.Tables[0];
            //Los datos que queremos que se vean en la lst
            lstCodigo.DisplayMember = "CODIGO DEPORTISTA";


            Conexion.Close();
        }
    }
}
