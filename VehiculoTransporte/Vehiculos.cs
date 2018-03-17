using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Configuration;

namespace Dealer
{
    public class Vehiculos:iPersistencia
    {
          private int id;
        private string marca;
        private string modelo;
        private string tipov;
        private string entrega;
        private DateTime fecha;
        private string mensaje;

        public List<Vehiculos> objVehiculo;
        public Vehiculos()
        {
            llenar("","","", "");
        }
        public Vehiculos ( string _marca, string _modelo,string _tipov, string _entrega)
        {
            llenar(_marca, _modelo, _tipov, _entrega);
        }
        private void llenar (string _marca,string _modelo,string _tipov, string _entrega)
        {
            
            id = new Random().Next();
            marca = _marca;
            modelo = _modelo;
            tipov = _tipov;
            entrega = _entrega;
            fecha = DateTime.Now;
        }
        public int getId()
        { return id; }
        public string getMarca ()
        {
            return marca;
        }
        public string getModelo()
        {
            return modelo;
        }

        public string getEntrega()
        {
            return entrega;
        }
        public DateTime getFecha()
        {
            return fecha;
        }
        public string getTipov()
        {
            return tipov;
        }

        public bool Grabar ()
        {
            try
            {
                if (id == 0)
                {
                    mensaje = "Dato invalido";
                    return false;
                }
                string nombreFichero = "vehiculos.txt";
                string ruta = ConfigurationManager.AppSettings["RootDirKey"];
                StreamWriter Archivo = new StreamWriter(ruta + "\\" + nombreFichero, true);
                string linea = id + " | " + marca + " | " + modelo + " | " + tipov + " |  " + entrega + " |" + fecha.ToString();
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
                string nombre = "vehiculos.txt";
                string ruta = ConfigurationManager.AppSettings["RootDirKey"];
                string linea = "";
                StreamReader archivo = new StreamReader(ruta + "\\" + nombre);
                objVehiculo = new List<Vehiculos>();
                while (!archivo.EndOfStream)
                {
                    linea = archivo.ReadLine();
                    string[] campos = linea.Split('|');
                    id = int.Parse(campos[0]);
                    marca = campos[1];
                    modelo = campos[2];
                    tipov = campos[3];
                    entrega = campos[4];
                    fecha = DateTime.Parse(campos[5]);
                    Vehiculos lineaEst = (Vehiculos)this.MemberwiseClone();
                    objVehiculo.Add(lineaEst);
                }
                archivo.Close();
                archivo.Dispose();
                return true;
            }
            catch(Exception e)
            {
                mensaje = e.Message;
                return false;
            }
        }

        public string getMensaje()
        {
            return mensaje;
        }
        public List<Vehiculos> getVehiculo ()
        {
            return objVehiculo;
        }
        
        public string todoString()
        {
            if (objVehiculo == null)
                Leer();
            StringBuilder str_texto = new StringBuilder();
            int no = 0;
            foreach (Vehiculos unVehiculo in objVehiculo)
            {
                no++;
                
                str_texto.Append("\n" + unVehiculo.ToString());
                

            }
            return str_texto.ToString();
        }
       
        public string AllString()
        {
            if (objVehiculo == null)
                Leer();
            StringBuilder str_texto = new StringBuilder();
            string texto = "--";
            int no = 0;
            

            foreach (Vehiculos unVehiculo in objVehiculo)
            {
                no++;
                texto += "Su ID es:" + id;
                texto += "\n --La marca es: " + getMarca();
                texto += "\n --El modelo es: " + getModelo();
                texto += "\n --El tipo es: " + getTipov();
                texto += "\n --El estado de entrega es: " + getEntrega();
                texto += "\n --Fecha" + fecha.ToString();
                texto += " \n ";
                str_texto.Append("\n " + texto);


            }
            return str_texto.ToString();
        }
        public string AlltableString()
        {
            if (objVehiculo == null)
                Leer();
            StringBuilder str_texto = new StringBuilder();
            string linea = "";
            int no = 0;
            str_texto.Append("ID    |Marca   |Modelo    |Tipo de vehiculo |Estado del vehiculo  |Fecha & Hora de ingreso");
            str_texto.Append("\n-----|-------|----------|--------|------");

            foreach (Vehiculos unVehiculo in objVehiculo)
            {
                no++;
                linea = no.ToString();
                linea += "|" + unVehiculo.getId();
                linea += "|" + unVehiculo.getMarca();
                linea += "|" + unVehiculo.getModelo();
                linea += "|" + unVehiculo.getTipov();
                linea += "|" + unVehiculo.getEntrega();
                linea += "|" + unVehiculo.getFecha();

                str_texto.Append("\n" + linea);
                str_texto.Append("\n---|--------|--------------");
            }
            return str_texto.ToString();
        }
        public bool buscar (int p_Id)
        {
            if (objVehiculo == null)
                Leer();
            bool linea_existe = false;
            foreach (Vehiculos unVehiculo in objVehiculo)
            {
                if (unVehiculo.getId() == p_Id)
                {
                    linea_existe = true;

                    id = unVehiculo.getId();
                    marca = unVehiculo.getMarca();
                    modelo = unVehiculo.getModelo();
                    tipov = unVehiculo.getTipov();
                    entrega = unVehiculo.getEntrega();
                    fecha = unVehiculo.getFecha();
                    break;
                }
            }
            return linea_existe;
        }
    }
}
