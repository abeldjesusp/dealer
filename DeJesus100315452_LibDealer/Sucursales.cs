using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Configuration;

namespace DeJesus100315452_LibDealer
{
    public class Sucursales:iPersistencia
    {
        private int id;
        private string sucursal;
        private string estado;
        private string fechaap;
        private string mensaje;
        private DateTime fecha;

        public List<Sucursales> objSucursal;

        public Sucursales()
        {
            llenar("", "", "");
        }

        public string AllString()
        {
            if (objSucursal == null)
                Leer();
            StringBuilder str_texto = new StringBuilder();
            string texto = "--";
            int no = 0;


            foreach (Sucursales unaSucursal in objSucursal)
            {
                no++;
                texto += "Su ID es:" + id;
                texto += "\n --La sucursal es: " + getSucursal();
                texto += "\n --El estado es: " + getEstado();
                texto += "\n --La fecha de apertura es: " + getFechaap();
               
                texto += "\n --Fecha" + fecha.ToString();
                texto += " \n ";
                str_texto.Append("\n " + texto);


            }
            return str_texto.ToString();
        }

        public string AllTableString()
        {
            if (objSucursal == null)
                Leer();
            StringBuilder str_texto = new StringBuilder();
            int no = 0;
            string linea = "";
            str_texto.Append("Id    |Sucursal     |Estado      |Fecha de inauguracion |Fecha");
            str_texto.Append("------------------------------------");

            foreach (Sucursales unaSucursal in objSucursal)
            {
                no++;
                linea = no.ToString();
                linea += " | " + unaSucursal.getSucursal();
                linea += " | " + unaSucursal.getEstado();
                linea += " | " + unaSucursal.getFechaap();
                linea += " | " + unaSucursal.getFecha();

                str_texto.Append("\n" + linea);
                str_texto.Append("\n----------|------------------|-------------------|-------------");

            }
            return str_texto.ToString();
        }

        public Sucursales(string _sucursal, string _estado, string _fechaap)
        {
            llenar(_sucursal, _estado, _fechaap);
        }
        public void llenar(string _sucursal, string _estado, string _fechaap)
        {
            id = new Random().Next();
            sucursal = _sucursal;
            estado = _estado;
            fechaap = _fechaap;
            fecha = DateTime.Now;
        }
        public int getId()
        {
            return id;
        }
        public string getSucursal()
        {
            return sucursal;
        }
        public string getEstado()
        {
            return estado;
        }
        public string getFechaap()
        {
            return fechaap;
        }
        public string getMensaje()
        {
            return mensaje;
        }
        public DateTime getFecha()
        {
            return fecha;
        }
        public List<Sucursales> getSucursales()
        {
            return objSucursal;
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
                string nombreFichero = "sucursales.txt";
                string ruta = ConfigurationManager.AppSettings["RootDirKey"];
                StreamWriter Archivo = new StreamWriter(ruta + "\\" + nombreFichero, true);
                string linea = id + " | " + sucursal + " | " + estado + " | " + fechaap + " | " + fecha.ToString();
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
                string nombre = "sucursales.txt";
                string ruta = ConfigurationManager.AppSettings["RootDirKey"];
                string linea = "";
                StreamReader archivo = new StreamReader(ruta + "\\" + nombre);
                objSucursal = new List<Sucursales>();
                while (!archivo.EndOfStream)
                {
                    linea = archivo.ReadLine();
                    string[] campos = linea.Split('|');
                    id = int.Parse(campos[0]);
                    sucursal = campos[1];
                    estado = campos[2];
                    fechaap = campos[3];
                    fecha = DateTime.Parse(campos[4]);
                    Sucursales lineaEst = (Sucursales)this.MemberwiseClone();
                    objSucursal.Add(lineaEst);
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
            if (objSucursal == null)
                Leer();
            StringBuilder str_texto = new StringBuilder();
            int no = 0;
            foreach (Sucursales unaSucursal in objSucursal)
            {
                no++;
                
                str_texto.Append("\n" + unaSucursal.ToString());
                

            }
            return str_texto.ToString();
        }

        public string AlltableString()
        {
            if (objSucursal == null)
                Leer();
            StringBuilder str_texto = new StringBuilder();
            string linea = "";
            int no = 0;
            str_texto.Append("ID    |Sucursal   |Estado    |Fecha de inauguracion   |Fecha & Hora de ingreso");
            str_texto.Append("\n-----|-------|----------|--------|------");

                foreach (Sucursales unaSucursal in objSucursal)
                {
                    no++;
                    linea = no.ToString();
                    linea += "|" + unaSucursal.getId();
                    linea += "|" + unaSucursal.getSucursal();
                    linea += "|" + unaSucursal.getEstado();
                    linea += "|" + unaSucursal.getFechaap();
                    linea += "|" + unaSucursal.getFecha();

                    str_texto.Append("\n" + linea);
                    str_texto.Append("\n---|--------|--------------");
                }
                return str_texto.ToString();
            }
            public bool buscar(int p_Id)
            {
                if (objSucursal == null)
                    Leer();
                bool linea_existe = false;
                foreach (Sucursales unaSucursal in objSucursal)
            {
                if (unaSucursal.getId() == p_Id)
                {
                    linea_existe = true;

                    id = unaSucursal.getId();
                    sucursal = unaSucursal.getSucursal();
                    estado = unaSucursal.getEstado();
                    fechaap = unaSucursal.getFechaap();
                    fecha = unaSucursal.getFecha();
                    break;
                }
            }
            return linea_existe;
        }
    }
}
