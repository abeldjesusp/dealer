using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Configuration;

namespace DeJesus100315452_LibDealer
{
    public class Computos : iPersistencia
    {
        private int id;
        private int dinerov;
        private int comision;
        private string dineroxf;
        private string masv;
        private string mensaje;
        private DateTime fecha;

        public List<Computos> objComputo;

        public Computos()
        {
            llenar(0, 0, "", "");
        }
        public Computos(int _dinerov, int _comision, string _dineroxf, string _masv)
        {
            llenar(_dinerov, _comision, _dineroxf, _masv);
        }
        public void llenar(int _dinerov, int _comision, string _dineroxf, string _masv)
        {
            id = new Random().Next();
           dinerov = _dinerov;
               comision = _comision;
               dineroxf = _dineroxf;
                       masv = _masv;
            fecha = DateTime.Now;
        }
        public int getId()
        {
            return id;
        }
        public int getDinerov()
        {
            return dinerov;
        }
        public int getComision()
        {
            return comision;
        }
        public string getDineroxf()
        {
            return dineroxf;
        }
        public string getMasv()
        {
            return masv;
        }
      
        public string getMensaje()
        {
            return mensaje;
        }
        public DateTime getFecha()
        {
            return fecha;
        }
        public List<Computos> getComputo()
        {
            return objComputo;
        }

        public bool Grabar()
        {
            try
            {
                if (id == 0)
                {
                    mensaje = "Dato invalido";
                    return false;
                }
                string nombreFichero = "computos.txt";
                string ruta = ConfigurationManager.AppSettings["RootDirKey"];
                StreamWriter Archivo = new StreamWriter(ruta + "\\" + nombreFichero, true);
                string linea = id + " | " + dinerov + " | " + comision + " | " + dineroxf + " |" + masv + " | " + fecha.ToString();
                Archivo.WriteLine(linea);
                Archivo.Close();
                Archivo.Dispose();
                return true;
            }
            catch (Exception e)
            {
                mensaje = e.Message;
                return false;
            }
        }
        public bool Leer()
        {
            try
            {
                string nombre = "computos.txt";
                string ruta = ConfigurationManager.AppSettings["RootDirKey"];
                string linea = "";
                StreamReader archivo = new StreamReader(ruta + "\\" + nombre);
                objComputo = new List<Computos>();
                while (!archivo.EndOfStream)
                {
                    linea = archivo.ReadLine();
                    string[] campos = linea.Split('|');
                    id = int.Parse(campos[0]);
                    dinerov = int.Parse(campos[1]);
                    comision = int.Parse(campos[2]);
                    dineroxf = campos[3];
                    masv = campos[4];
                    fecha = DateTime.Parse(campos[5]);
                    Computos lineaEst = (Computos)this.MemberwiseClone();
                    objComputo.Add(lineaEst);
                }
                archivo.Close();
                archivo.Dispose();
                return true;
            }
            catch (Exception e)
            {
                mensaje = e.Message;
                return false;
            }
        }


        public string todoString()
        {
            if (objComputo == null)
                Leer();
            StringBuilder str_texto = new StringBuilder();
            int no = 0;
            foreach (Computos unComputo in objComputo)
            {
                no++;

                str_texto.Append("\n" + unComputo.ToString());
            }
            return str_texto.ToString();
        }
        public string AllString()
        {
            if (objComputo == null)
                Leer();
            StringBuilder str_texto = new StringBuilder();
            string texto = "--";
            int no = 0;


            foreach (Computos unComputo in objComputo)
            {
                no++;
                texto += "Su ID es:" + id;
                texto += "\n --El dinero total de las ventas es: " + getDinerov();
                texto += "\n --El dinero total de la comision es: " + getComision();
                texto += "\n --El dinero total es: " + getDineroxf();
                texto += "\n --Las 3 marcas mas vendidas son: " + getMasv();

                texto += "\n --Fecha" + fecha.ToString();
                texto += " \n ";
                str_texto.Append("\n " + texto);


            }
            return str_texto.ToString();
        }
        public string AlltableString()
        {
            if (objComputo == null)
                Leer();
            StringBuilder str_texto = new StringBuilder();
            string linea = "";
            int no = 0;
            str_texto.Append("ID    |Total de dinero por ventas   |Total de dinero de comision    |Total de dinero en un rango de fecha    |Las 3 marcas mas vendidas   |Fecha de ingreso");
            str_texto.Append("\n-----|-------|----------|--------|------");

            foreach (Computos unComputo in objComputo)
            {
                no++;
                linea = no.ToString();
                linea += "|" + unComputo.getId();
                linea += "|" + unComputo.getDinerov();
                linea += "|" + unComputo.getComision();
                linea += "|" + unComputo.getDineroxf();
                linea += "|" + unComputo.getMasv();
                linea += "|" + unComputo.getFecha();

                str_texto.Append("\n" + linea);
                str_texto.Append("\n---|--------|--------------");
            }
            return str_texto.ToString();
        }
        public bool buscar(int p_Id)
        {
            if (objComputo == null)
                Leer();
            bool linea_existe = false;
            foreach (Computos unComputo in objComputo)
            {
                if (unComputo.getId() == p_Id)
                {
                    linea_existe = true;

                    id = unComputo.getId();
                    dinerov = unComputo.getDinerov();
                    comision = unComputo.getComision();
                    dineroxf = unComputo.getDineroxf();
                    masv = unComputo.getMasv();
                    fecha = unComputo.getFecha();
                    break;
                }
            }
            return linea_existe;
        }
    }
}