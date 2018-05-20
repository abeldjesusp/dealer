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
   
    public partial class PersonalWindowForm : Form
    {
        private DeJesus100315452_LibDealer.Personas objPersonas = new DeJesus100315452_LibDealer.Personas();
        static string nombre = "personas.txt";
        static string ruta = ConfigurationManager.AppSettings["RootDirKey"];
        private StreamReader archivo = new StreamReader(ruta + "\\" + nombre);
        private int n;
        private string linea = "";

        public PersonalWindowForm()
        {
            InitializeComponent();

            if (objPersonas.Leer())
            {
                while (!archivo.EndOfStream)
                {
                    n = dataGridPersonal.Rows.Add();
                    linea = archivo.ReadLine();
                    string[] campos = linea.Split('|');
                    dataGridPersonal.Rows[n].Cells[0].Value = campos[0];
                    dataGridPersonal.Rows[n].Cells[1].Value = campos[1];
                    dataGridPersonal.Rows[n].Cells[2].Value = campos[2];
                    dataGridPersonal.Rows[n].Cells[3].Value = campos[3];
                    dataGridPersonal.Rows[n].Cells[4].Value = campos[4];
                    dataGridPersonal.Rows[n].Cells[5].Value = campos[5];
                }
                archivo.Close();
                archivo.Dispose();
            }
            else
            {
                MessageBox.Show("Error {0}", objPersonas.getMensaje());
                archivo.Close();
                archivo.Dispose();
            }
        }
    }
}
