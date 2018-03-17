using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Configuration;

namespace Dealer
{
    public class Ventas : iPersistencia
    {
        private int id;
        private string vehiculo;
        private string vendedor;
        private string comprador;
        private int precio;
        private string mensaje;
        private DateTime fecha;

        public List<Ventas> objVentas;

        public Ventas()
        {
            llenar("", "","", 0);
        }
        public Ventas(string _vehiculo, string _vendedor, string _comprador, int _precio)
        {
            llenar(_vehiculo, _vendedor, _comprador, _precio);
        }
        public void llenar(string _vehiculo, string _vendedor, string _comprador, int _precio)
        {
            id = new Random().Next();
            vehiculo = _vehiculo;
            vendedor = _vendedor;
            comprador = _comprador;
            precio = _precio;
            fecha = DateTime.Now;
        }
        public int getId()
        {
            return id;
        }
        public string getVehiculo()
        {
            return vehiculo;
        }
        public string getVendedor()
        {
            return vendedor;
        }
        public string getComprador()
        {
            return comprador;
        }
        public int getPrecio()
        {
            return precio;
        }
        public string getMensaje()
        {
            return mensaje;
        }
        public DateTime getFecha()
        {
            return fecha;
        }
        public List<Ventas> getVentas()
        {
            return objVentas;
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
                string nombreFichero = "ventas.txt";
                string ruta = ConfigurationManager.AppSettings["RootDirKey"];
                StreamWriter Archivo = new StreamWriter(ruta + "\\" + nombreFichero, true);
                string linea = id + " | " + vehiculo + " | " + vendedor + " | " + comprador + " |" + precio + " | " + fecha.ToString();
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
                string nombre = "ventas.txt";
                string ruta = ConfigurationManager.AppSettings["RootDirKey"];
                string linea = "";
                StreamReader archivo = new StreamReader(ruta + "\\" + nombre);
                objVentas = new List<Ventas>();
                while (!archivo.EndOfStream)
                {
                    linea = archivo.ReadLine();
                    string[] campos = linea.Split('|');
                    id = int.Parse(campos[0]);
                    vehiculo = campos[1];
                    vendedor = campos[2];
                    comprador = campos[3];
                    precio = int.Parse(campos[4]);
                    fecha = DateTime.Parse(campos[5]);
                    Ventas lineaEst = (Ventas)this.MemberwiseClone();
                    objVentas.Add(lineaEst);
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
            if (objVentas == null)
                Leer();
            StringBuilder str_texto = new StringBuilder();
            int no = 0;
            foreach (Ventas unaVenta in objVentas)
            {
                no++;

                str_texto.Append("\n" + unaVenta.ToString());


            }
            return str_texto.ToString();
        }
        public string AllString()
        {
            if (objVentas == null)
                Leer();
            StringBuilder str_texto = new StringBuilder();
            string texto = "--";
            int no = 0;


            foreach (Ventas unaVenta in objVentas)
            {
                no++;
                texto += "Su ID es:" + id;
                texto += "\n --El vehiculo es: " + getVehiculo();
                texto += "\n --El vendedor es: " + getVendedor();
                texto += "\n --El comprador es: " + getComprador();
                texto += "\n --El precio es: " + getPrecio();
               
                texto += "\n --Fecha" + fecha.ToString();
                texto += " \n ";
                str_texto.Append("\n " + texto);


            }
            return str_texto.ToString();
        }
        public string AlltableString()
        {
            if (objVentas == null)
                Leer();
            StringBuilder str_texto = new StringBuilder();
            string linea = "";
            int no = 0;
            str_texto.Append("ID    |Vehiculo   |Vendedor    |Comprador    |Precio    |Fecha de venta");
            str_texto.Append("\n-----|-------|----------|--------|------");

            foreach (Ventas unaVenta in objVentas)
            {
                no++;
                linea = no.ToString();
                linea += "|" + unaVenta.getId();
                linea += "|" + unaVenta.getVehiculo();
                linea += "|" + unaVenta.getVendedor();
                linea += "|" + unaVenta.getComprador();
                linea += "|" + unaVenta.getPrecio();
                linea += "|" + unaVenta.getFecha();

                str_texto.Append("\n" + linea);
                str_texto.Append("\n---|--------|--------------");
            }
            return str_texto.ToString();
        }
        public bool buscar(int p_Id)
        {
            if (objVentas == null)
                Leer();
            bool linea_existe = false;
            foreach (Ventas unaVenta in objVentas)
            {
                if (unaVenta.getId() == p_Id)
                {
                    linea_existe = true;

                    id = unaVenta.getId();
                    vehiculo = unaVenta.getVehiculo();
                    vendedor = unaVenta.getVendedor();
                    comprador = unaVenta.getComprador();
                    precio = unaVenta.getPrecio();
                    fecha = unaVenta.getFecha();
                    break;
                }
            }
            return linea_existe;
        }
    }
}
