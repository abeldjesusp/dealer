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
    public partial class sucursalesWindowForm : Form
    {
        private DeJesus100315452_LibDealer.Sucursales objSucursales = new DeJesus100315452_LibDealer.Sucursales();
        static string nombre = "sucursales.txt";
        static string ruta = ConfigurationManager.AppSettings["RootDirKey"];
        private StreamReader archivo = new StreamReader(ruta + "\\" + nombre);
        private int n;
        private string linea = "";
        public sucursalesWindowForm()
        {
            InitializeComponent();

            if (objSucursales.Leer())
            {
                while (!archivo.EndOfStream)
                {
                    n = dataGridSucursales.Rows.Add();
                    linea = archivo.ReadLine();
                    string[] campos = linea.Split('|');
                    dataGridSucursales.Rows[n].Cells[0].Value = campos[0];
                    dataGridSucursales.Rows[n].Cells[1].Value = campos[1];
                    dataGridSucursales.Rows[n].Cells[2].Value = campos[2];
                    dataGridSucursales.Rows[n].Cells[3].Value = campos[3];
                }
                archivo.Close();
                archivo.Dispose();
            }
            else
            {
                MessageBox.Show("Error {0}", objSucursales.getMensaje());
                archivo.Close();
                archivo.Dispose();
            }
        }
    }
}
