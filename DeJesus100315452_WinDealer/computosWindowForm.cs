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
    public partial class computosWindowForm : Form
    {
        private DeJesus100315452_LibDealer.Computos objComputos = new DeJesus100315452_LibDealer.Computos();
        static string nombre = "computos.txt";
        static string ruta = ConfigurationManager.AppSettings["RootDirKey"];
        private StreamReader archivo = new StreamReader(ruta + "\\" + nombre);
        private int n;
        private string linea = "";
        public computosWindowForm()
        {
            InitializeComponent();

            if (objComputos.Leer())
            {
                while (!archivo.EndOfStream)
                {
                    n = dataGridComputos.Rows.Add();
                    linea = archivo.ReadLine();
                    string[] campos = linea.Split('|');
                    dataGridComputos.Rows[n].Cells[0].Value = campos[0];
                    dataGridComputos.Rows[n].Cells[1].Value = campos[1];
                    dataGridComputos.Rows[n].Cells[2].Value = campos[2];
                    dataGridComputos.Rows[n].Cells[3].Value = campos[3];
                    dataGridComputos.Rows[n].Cells[4].Value = campos[4];
                    dataGridComputos.Rows[n].Cells[5].Value = campos[5];
                }
                archivo.Close();
                archivo.Dispose();
            }
            else
            {
                MessageBox.Show("Error {0}", objComputos.getMensaje());
                archivo.Close();
                archivo.Dispose();
            }
        }
    }
}
