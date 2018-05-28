using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;

namespace DeJesus100315452_WinDealer
{
    public partial class VehiculosWindowForm : Form
    {
        private DeJesus100315452_LibDealer.Vehiculos objVehiculos = new DeJesus100315452_LibDealer.Vehiculos();
        static string nombre = "vehiculos.txt";
        static string ruta = ConfigurationManager.AppSettings["RootDirKey"];
        private StreamReader archivo = new StreamReader(ruta + "\\" + nombre);
        private int n;
        private string linea = "";
        public VehiculosWindowForm()
        {
            InitializeComponent();
            
            if (objVehiculos.Leer())
            {
                while (!archivo.EndOfStream)
                {
                    n = dataGridVehiculos.Rows.Add();
                    linea = archivo.ReadLine();
                    string[] campos = linea.Split('|');
                    dataGridVehiculos.Rows[n].Cells[0].Value = campos[0];
                    dataGridVehiculos.Rows[n].Cells[1].Value = campos[1];
                    dataGridVehiculos.Rows[n].Cells[2].Value = campos[2]; 
                    dataGridVehiculos.Rows[n].Cells[3].Value = campos[3];
                    dataGridVehiculos.Rows[n].Cells[4].Value = campos[4];
                    dataGridVehiculos.Rows[n].Cells[5].Value = campos[5];                    
                }
                archivo.Close();
                archivo.Dispose();
            }
            else
            {
                MessageBox.Show("Error {0}", objVehiculos.getMensaje());
                archivo.Close();
                archivo.Dispose();
            }
            
        }

        private void btnBuscarVehiculo_Click(object sender, EventArgs e)
        {
            int idVenta = Convert.ToInt32(tbBuscarIdVehiculo.Text);
            if (objVehiculos.buscar(idVenta))
                MessageBox.Show(objVehiculos.AllString());
            else
                MessageBox.Show("El vehiculo no se encuentra registrado");

            tbBuscarIdVehiculo.Text = "";
        }
    }
}
