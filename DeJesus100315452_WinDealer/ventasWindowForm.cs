using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DeJesus100315452_WinDealer
{
    public partial class ventasWindowForm : Form
    {
        private DeJesus100315452_LibDealer.Ventas objVentas = new DeJesus100315452_LibDealer.Ventas();
        static string nombre = "ventas.txt";
        static string ruta = ConfigurationManager.AppSettings["RootDirKey"];
        private StreamReader archivo = new StreamReader(ruta + "\\" + nombre);
        private int n;
        private string linea = "";
        public ventasWindowForm()
        {
            InitializeComponent();

            if (objVentas.Leer())
            {
                while (!archivo.EndOfStream)
                {
                    n = dataGridVentas.Rows.Add();
                    linea = archivo.ReadLine();
                    string[] campos = linea.Split('|');
                    dataGridVentas.Rows[n].Cells[0].Value = campos[0];
                    dataGridVentas.Rows[n].Cells[1].Value = campos[1];
                    dataGridVentas.Rows[n].Cells[2].Value = campos[2];
                    dataGridVentas.Rows[n].Cells[3].Value = campos[3];
                    dataGridVentas.Rows[n].Cells[4].Value = campos[4];
                    dataGridVentas.Rows[n].Cells[5].Value = campos[5];
                }
                archivo.Close();
                archivo.Dispose();
            }
            else
            {
                MessageBox.Show("Error {0}", objVentas.getMensaje());
                archivo.Close();
                archivo.Dispose();
            }

        }

        private void btnBuscarVentas_Click(object sender, EventArgs e)
        {
            int idVenta = Convert.ToInt32(tbBuscarVentas.Text);
            if (objVentas.buscar(idVenta))        
                MessageBox.Show(objVentas.AllString());
            else
                MessageBox.Show("La venta no se encuentra registrada");

            tbBuscarVentas.Text = "";
        }
    }
}
