using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Configuration;

namespace Dealer
{
   public class Personas:iPersistencia
    {
        private int id;
        private string nnombre;
        private string funcion;
        private int codigo;
        private int salario;
        private string ingreso;
        private DateTime fecha;
        private string mensaje;

        public List<Personas> objPersona;
        
        public Personas()
        {
            llenar("","", 0, 0, "" );
        }
        public Personas(string _nnombre, string _funcion, int _codigo, int _salario, string _ingreso)
        {
            llenar(_nnombre, _funcion, _codigo, _salario, _ingreso);
        }
        public void llenar(string _nnombre, string _funcion, int _codigo, int _salario, string _ingreso)
        {
            id = new Random().Next();
            nnombre = _nnombre;
            funcion = _funcion;
            codigo = _codigo;
            salario = _salario;
            ingreso = _ingreso;
            fecha = DateTime.Now;
        }

        public int getId()
        {
            return id;
        }
        public string getNnombre()
        {
            return nnombre;
        }
        public string getFuncion()
        {
            return funcion;

        }

        public int getCodigo()
        {
            return codigo;
        }

        public int getSalario()
        {
            return salario;
        }

        public string getIngreso()
        {
            return ingreso;

        }
        public DateTime getFecha()
        {
            return fecha;
        }
        public string getMensaje ()
        {
            return mensaje;
        }

        public bool Grabar ()
        {
            try
            {
                if (id == 0)
                {
                    mensaje = "Dato Invalido";
                    return false;
                }
                string nombreFichero = "personas.txt";
                string ruta = ConfigurationManager.AppSettings["RootDirKey"];
                StreamWriter Archivo = new StreamWriter(ruta + "\\" + nombreFichero, true);
                string grabarLinea = id + " | " + nnombre + " | " + funcion + " | " + codigo + " | " + salario + " | " + ingreso + " | " + fecha.ToString();
               Archivo.WriteLine(grabarLinea);
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
        public bool Leer ()
        {
            try
            {
                string nombre = "personas.txt";
                string ruta = ConfigurationManager.AppSettings["RootDirKey"];
                string linea = "";
                StreamReader archivo = new StreamReader(ruta + "\\" + nombre);
                objPersona = new List<Personas>();
                while (!archivo.EndOfStream)
                {
                    linea = archivo.ReadLine();
                    string[] campos = linea.Split('|');
                    id = int.Parse(campos[0]);
                    nnombre = campos[1];
                    funcion = campos[2];
                    codigo = int.Parse(campos[3]);
                    salario = int.Parse(campos[4]);
                        ingreso = campos[5];
                    fecha = DateTime.Parse(campos[6]);
                    Personas lin = (Personas)this.MemberwiseClone();
                    objPersona.Add(lin);
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

        public List<Personas> getPersona()
        {
            return objPersona;
        }

        public string AllString()
        {
            if (objPersona == null)
                Leer();
            StringBuilder str_texto = new StringBuilder();
            string texto = "--";
            int no = 0;


            foreach (Personas unaPersona in objPersona)
            {
                no++;
                texto += "Su ID es:" + id;
                texto += "\n --El nombre es: " + getNnombre();
                texto += "\n --Su funcion es: " + getFuncion();
                texto += "\n --Su codigo es(Solo vendedor): " + getCodigo();
                texto += "\n --Su salario es(Solo vendedor): " + getSalario();
                texto += "\n --Su fecha de ingreso es(Solo vendedor): " + getIngreso();
                texto += "\n --Fecha" + fecha.ToString();
                texto += " \n ";
                str_texto.Append("\n " + texto);


            }
            return str_texto.ToString();
        }

        public string AlltableString ()
        {
            if (objPersona == null)
                Leer();
            StringBuilder str_texto = new StringBuilder();
            int no = 0;
            string linea = "";
            str_texto.Append("ID    |Nombre     |Funcion   |Codigo de empleado   |Salario   |Fecha de ingreso    |Fecha & Hora de ingreso");
            str_texto.Append("------------------------------------");

            foreach (Personas unaPersona in objPersona)
            {
                no++;
                linea = no.ToString();
                linea += " | " + unaPersona.getNnombre();
                linea += " | " + unaPersona.getFuncion();
                linea += " | " + unaPersona.getCodigo();
                linea += " | " + unaPersona.getSalario();
                linea += " | " + unaPersona.getIngreso();
                linea += " | " + unaPersona.getFecha();

                str_texto.Append("\n" + linea);
                str_texto.Append("\n----------|------------------|-------------------|-------------");

            }
            return str_texto.ToString();
        }

        public string todoString()
        {
            if (objPersona == null)
                Leer();
            StringBuilder str_texto = new StringBuilder();
            int no = 0;
            foreach (Personas unaPersona in objPersona)
            {
                no++;

                str_texto.Append("\n" + unaPersona.ToString());


            }
            return str_texto.ToString();
        }

        public bool buscar(int p_Id)
        {
            if (objPersona == null)
                Leer();
            bool linea_existe = false;
            foreach (Personas unaPersona in objPersona)
            {
                if (unaPersona.getId() == p_Id)
                {
                    linea_existe = true;

                    id = unaPersona.getId();
                    nnombre = unaPersona.getNnombre();
                    funcion = unaPersona.getFuncion();
                    codigo = unaPersona.getCodigo();
                    salario = unaPersona.getSalario();
                    ingreso = unaPersona.getIngreso();

                    fecha = unaPersona.getFecha();
                    break;
                }
            }
            return linea_existe;
        }
    }
}      