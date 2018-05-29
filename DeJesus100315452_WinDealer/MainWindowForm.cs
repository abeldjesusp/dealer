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
    public partial class MainWindowForm : Form
    {
        DeJesus100315452_LibDealer.Vehiculos objVehiculo;
        DeJesus100315452_LibDealer.Personas objPersona;
        DeJesus100315452_LibDealer.Sucursales objSucursales;
        DeJesus100315452_LibDealer.Ventas objVentas;
        DeJesus100315452_LibDealer.Computos objComputos;

        public MainWindowForm()
        {
            InitializeComponent();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void acercaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("  Dealer Abel S.R.L Copyright 2018  ");
        }

        private void MainWindowForm_Load(object sender, EventArgs e)
        {
            Font titulos = new Font("Arial", 22.0f);
            Font subtitulos = new Font("Arial", 18.0f);

            titutloCatalogoV.Font = titulos;
            subtituloCatalogoV.Font = subtitulos;
            tituloSucursales.Font = titulos;
            subtituloSucursal.Font = subtitulos;
            tituloPersonal.Font = titulos;
            subtituloPersonal.Font = subtitulos;
            tituloVentas.Font = titulos;
            subtituloVentas.Font = subtitulos;
            tituloComputos.Font = titulos;
            subtituloComputos.Font = subtitulos;
            tituloLibros.Font = titulos;
            subtituloLibros.Font = subtitulos;

            string nombreVehiculo = "vehiculos.txt";
            string nombrePersona = "personas.txt";
            string rutaVehiculo = ConfigurationManager.AppSettings["RootDirKey"];
            string rutaPersona = ConfigurationManager.AppSettings["RootDirKey"];
            objVehiculo = new DeJesus100315452_LibDealer.Vehiculos();
            objPersona = new DeJesus100315452_LibDealer.Personas();
            StreamReader archivoVehiculo = new StreamReader(rutaVehiculo + "\\" + nombreVehiculo);
            StreamReader archivoPersona = new StreamReader(rutaPersona + "\\" + nombrePersona);
            string linea = "";

            if (objVehiculo.Leer())
            {
                while (!archivoVehiculo.EndOfStream)
                {
                    linea = archivoVehiculo.ReadLine();
                    string[] campos = linea.Split('|');
                    cbVehiculoVentas.Items.Add(campos[1] + campos[2]);
                    cbMarcaComputos01.Items.Add(campos[1] + campos[2]);
                }
                archivoVehiculo.Close();
                archivoVehiculo.Dispose();

            }

            if (objPersona.Leer())
            {
                while (!archivoPersona.EndOfStream)
                {
                    linea = archivoPersona.ReadLine();
                    string[] campos = linea.Split('|');
                    cbVendedorVentas.Items.Add(campos[1]);
                }
                archivoPersona.Close();
                archivoPersona.Dispose();

            }

            llenarNodes();


        }

        private void llenarNodes()
        {
            string nombreVehiculo = "vehiculos.txt",
                   nombreVentas = "ventas.txt",
                   nombreComputos = "computos.txt",
                   nombrePersona = "personas.txt",
                   nombreSucursales = "sucursales.txt",
                   nombrePersonas = "personas.txt",
                   rutaVehiculo = ConfigurationManager.AppSettings["RootDirKey"],
                   rutaVentas = ConfigurationManager.AppSettings["RootDirKey"],
                   rutaComputos = ConfigurationManager.AppSettings["RootDirKey"],
                   rutaPersona = ConfigurationManager.AppSettings["RootDirKey"],
                   rutaSucursales = ConfigurationManager.AppSettings["RootDirKey"],
                   rutaPersonas = ConfigurationManager.AppSettings["RootDirKey"];

            objVehiculo = new DeJesus100315452_LibDealer.Vehiculos();
            objPersona = new DeJesus100315452_LibDealer.Personas();
            objVentas = new DeJesus100315452_LibDealer.Ventas();
            objComputos = new DeJesus100315452_LibDealer.Computos();
            objSucursales = new DeJesus100315452_LibDealer.Sucursales();
            StreamReader archivoVehiculo = new StreamReader(rutaVehiculo + "\\" + nombreVehiculo),
                         archivoVentas = new StreamReader(rutaVentas + "\\" + nombreVentas),
                         archivoComputos = new StreamReader(rutaVehiculo + "\\" + nombreComputos),
                         archivoPersona = new StreamReader(rutaPersona + "\\" + nombrePersona),
                         archivoSucursales = new StreamReader(rutaSucursales + "\\" + nombreSucursales),
                         archivoPersonas = new StreamReader(rutaPersonas + "\\" + nombrePersonas);
            string linea = "";

            //Primer node
            tvmMain.Nodes.Add("Vehiculos");
            tvmMain.Nodes[0].Nodes.Add("Cátalogo de vehiculos");
            if (objVehiculo.Leer())
            {  
                while (!archivoVehiculo.EndOfStream)
                {
                    linea = archivoVehiculo.ReadLine();
                    string[] campos = linea.Split('|');
                    tvmMain.Nodes[0].Nodes[0].Nodes.Add(campos[1] + campos[2]);
                }
                archivoVehiculo.Close();
                archivoVehiculo.Dispose();

            }
            tvmMain.Nodes[0].Nodes.Add("Ventas");
            if (objVentas.Leer())
            {                
                while (!archivoVentas.EndOfStream)
                {
                    linea = archivoVentas.ReadLine();
                    string[] campos = linea.Split('|');
                    tvmMain.Nodes[0].Nodes[1].Nodes.Add(campos[1] + "-->" + campos[2] + "-->" + campos[3]);
                }
                archivoVentas.Close();
                archivoVentas.Dispose();

            }            
            tvmMain.Nodes[0].Nodes.Add("Computos");
            if (objComputos.Leer())
            {
                while (!archivoComputos.EndOfStream)
                {
                    linea = archivoComputos.ReadLine();
                    string[] campos = linea.Split('|');
                    tvmMain.Nodes[0].Nodes[2].Nodes.Add("$"+ campos[1] + "-->" + campos[4]);
                }
                archivoComputos.Close();
                archivoComputos.Dispose();

            }

            //segundo node
            tvmMain.Nodes.Add("Sucursales");
            tvmMain.Nodes[1].Nodes.Add("Información de sucursales");
            if (objSucursales.Leer())
            {
                while (!archivoSucursales.EndOfStream)
                {
                    linea = archivoSucursales.ReadLine();
                    string[] campos = linea.Split('|');
                    tvmMain.Nodes[1].Nodes[0].Nodes.Add(campos[1] + campos[2]);
                }
                archivoSucursales.Close();
                archivoSucursales.Dispose();

            }
            
            tvmMain.Nodes[1].Nodes.Add("Personal");
            if (objPersona.Leer())
            {
                while (!archivoPersona.EndOfStream)
                {
                    linea = archivoPersona.ReadLine();
                    string[] campos = linea.Split('|');
                    tvmMain.Nodes[1].Nodes[1].Nodes.Add(campos[1] + campos[2]);
                }
                archivoPersona.Close();
                archivoPersona.Dispose();

            }
            tvmMain.Nodes.Add("Tienda de libros");



            objVehiculo = null;
            objPersona = null;
            objVentas = null;
            objComputos = null;
            objSucursales = null;

        }

        private void vehiculosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            panelLibros.Visible = false;
            panelPersonal.Visible = false;
            panelComputos.Visible = false;
            panelSucursales.Visible = false;
            panelVentas.Visible = false;
            panelCatalogoVehiculos.Visible = true;
        }

        private void ventasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panelLibros.Visible = false;
            panelPersonal.Visible = false;
            panelComputos.Visible = false;
            panelSucursales.Visible = false;
            panelCatalogoVehiculos.Visible = false;
            panelVentas.Visible = true;            
        }

        private void computosGeneralesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panelLibros.Visible = false;
            panelPersonal.Visible = false;
            panelVentas.Visible = false;            
            panelSucursales.Visible = false;
            panelCatalogoVehiculos.Visible = false;
            panelComputos.Visible = true;
        }

        private void informaciónDeSucursalesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panelLibros.Visible = false;
            panelPersonal.Visible = false;
            panelVentas.Visible = false;
            panelComputos.Visible = false;
            panelCatalogoVehiculos.Visible = false;            
            panelSucursales.Visible = true;
        }

        private void personalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panelLibros.Visible = false;
            panelVentas.Visible = false;
            panelComputos.Visible = false;
            panelCatalogoVehiculos.Visible = false;
            panelSucursales.Visible = false;
            panelPersonal.Visible = true;
        }

        private void librosToolStripMenuItem_Click(object sender, EventArgs e)
        {            
            panelVentas.Visible = false;
            panelComputos.Visible = false;
            panelCatalogoVehiculos.Visible = false;
            panelSucursales.Visible = false;
            panelPersonal.Visible = false;
            panelLibros.Visible = true;
        }

        private void btnRegistrarVehiculo_Click(object sender, EventArgs e)
        {
            string marca, modelo, tipo, estado;

            marca = marcaVehiculo.Text;
            modelo = modeloVehiculo.Text;
            tipo = tipoVehiculo.Text;
            estado = estadoVehiculo.Text;            

            objVehiculo = new DeJesus100315452_LibDealer.Vehiculos(marca,modelo,tipo,estado);
            DialogResult dialogResult =  MessageBox.Show("¿Desea guardarlo?","Guardar...", MessageBoxButtons.YesNo);

            if (dialogResult == DialogResult.Yes)
            {
                if(objVehiculo.Grabar())                
                    MessageBox.Show("Se ha guardado existosamente :D");
                else
                    MessageBox.Show("Error {0}", objVehiculo.getMensaje());
            }
            else if(dialogResult == DialogResult.No)
            {
                MessageBox.Show("Trate nuevamente :(");
            }

            objVehiculo = null;
            marcaVehiculo.Text = "";
            modeloVehiculo.Text = "";
            tipoVehiculo.Text = "";
            estadoVehiculo.Text = "";
            
        }

        private void btnLimpiarCatalogo_Click(object sender, EventArgs e)
        {            
            marcaVehiculo.Text = "";
            modeloVehiculo.Text = "";
            tipoVehiculo.Text = "";
            estadoVehiculo.Text = "";
        }

        private void btnVerCatalogo_Click(object sender, EventArgs e)
        {
            VehiculosWindowForm objVentanaVehiculo = new VehiculosWindowForm();
            objVentanaVehiculo.Show();
            
        }

        private void btnAtrasVehiculo_Click(object sender, EventArgs e)
        {
            panelCatalogoVehiculos.Visible = false;
        }

        private void btnRegistrarPersonal_Click(object sender, EventArgs e)
        {
            string nombre, cargo, fecha;
            int codigo, salario;

            nombre = nombreEmpleado.Text;
            cargo = cargoEmpleado.Text;
            codigo = Convert.ToInt32(codigoEmpleado.Text);
            salario = Convert.ToInt32(salarioEmpleado.Text);
            fecha = fechaIngresoEmpleado.Text;

            objPersona = new DeJesus100315452_LibDealer.Personas(nombre, cargo, codigo,salario,fecha);
            DialogResult dialogResult = MessageBox.Show("¿Desea guardarlo?", "Guardar...", MessageBoxButtons.YesNo);

            if (dialogResult == DialogResult.Yes)
            {
                if (objPersona.Grabar())
                    MessageBox.Show("Se ha guardado existosamente :D");
                else
                    MessageBox.Show("Error {0}", objPersona.getMensaje());
            }
            else if (dialogResult == DialogResult.No)
            {
                MessageBox.Show("Trate nuevamente :(");
            }

            objPersona = null;
            nombreEmpleado.Text = "";
            cargoEmpleado.Text = "";
            codigoEmpleado.Text = "";
            salarioEmpleado.Text = "";
            fechaIngresoEmpleado.Text = "";
        }

        private void btnLimpiarPersonal_Click(object sender, EventArgs e)
        {
            nombreEmpleado.Text = "";
            cargoEmpleado.Text = "";
            codigoEmpleado.Text = "";
            salarioEmpleado.Text = "";
            fechaIngresoEmpleado.Text = "";
        }

        private void btnAtrasPersonal_Click(object sender, EventArgs e)
        {
            panelPersonal.Visible = false;
        }

        private void btnVerEmpleados_Click(object sender, EventArgs e)
        {
            PersonalWindowForm objPersonalWindow = new PersonalWindowForm();
            objPersonalWindow.Show();
        }

        private void btnAtrasSucursal_Click(object sender, EventArgs e)
        {
            panelSucursales.Visible = false;
        }

        private void btnRegistrarSucursal_Click(object sender, EventArgs e)
        {
            string nombre, estado, apertura;

            nombre = nombreSucursal.Text;
            estado = estadoSucursal.Text;
            apertura = fechaAperturaSucursal.Text;

            objSucursales = new DeJesus100315452_LibDealer.Sucursales(nombre, estado, apertura);

            DialogResult dialogResult = MessageBox.Show("¿Desea guardarlo?", "Guardar...", MessageBoxButtons.YesNo);

            if (dialogResult == DialogResult.Yes)
            {
                if (objSucursales.Grabar())
                    MessageBox.Show("Se ha guardado existosamente :D");
                else
                    MessageBox.Show("Error {0}", objSucursales.getMensaje());
            }
            else if (dialogResult == DialogResult.No)
            {
                MessageBox.Show("Trate nuevamente :(");
            }
            objSucursales = null;
            nombreSucursal.Text = "";
            estadoSucursal.Text = "";
            fechaAperturaSucursal.Text = "";
        }

        private void btnLimpiarSucursales_Click(object sender, EventArgs e)
        {
            nombreSucursal.Text = "";
            estadoSucursal.Text = "";
            fechaAperturaSucursal.Text = "";
        }

        private void btnVerSucursales_Click(object sender, EventArgs e)
        {
            sucursalesWindowForm objSucursalesWindow = new sucursalesWindowForm();
            objSucursalesWindow.Show();
        }

        private void btnAtrasVentas_Click(object sender, EventArgs e)
        {
            panelVentas.Visible = false;
        }

        private void btnVerVentas_Click(object sender, EventArgs e)
        {
            ventasWindowForm objVentasWindow = new ventasWindowForm();
            objVentasWindow.Show();
        }

        private void btnRegistrarVenta_Click(object sender, EventArgs e)
        {
            string vehiculo, vendedor, comprador;
            int precio;

            vehiculo = cbVehiculoVentas.Text;
            vendedor = cbVendedorVentas.Text;
            comprador = tbCompradorVentas.Text;
            precio = Convert.ToInt32(tbPrecioVentas.Text);
            


            objVentas = new DeJesus100315452_LibDealer.Ventas(vehiculo, vendedor, comprador, precio);
            DialogResult dialogResult = MessageBox.Show("¿Desea guardarlo?", "Guardar...", MessageBoxButtons.YesNo);

            if (dialogResult == DialogResult.Yes)
            {
                if (objVentas.Grabar())
                    MessageBox.Show("Se ha guardado existosamente :D");
                else
                    MessageBox.Show("Error {0}", objVentas.getMensaje());
            }
            else if (dialogResult == DialogResult.No)
            {
                MessageBox.Show("Trate nuevamente :(");
            }

            objVentas = null;
            cbVehiculoVentas.Text = "";
            cbVendedorVentas.Text = "";
            tbCompradorVentas.Text = "";
            tbPrecioVentas.Text = "";
        }

        private void btnLimpiarVentas_Click(object sender, EventArgs e)
        {
            cbVehiculoVentas.Text = "";
            cbVendedorVentas.Text = "";
            tbCompradorVentas.Text = "";
            tbPrecioVentas.Text = "";
        }

        private void btnAtrasComputos_Click(object sender, EventArgs e)
        {
            panelComputos.Visible = false;
        }

        private void btnRegistrarComputos_Click(object sender, EventArgs e)
        {
            int totalDinero, totalComision;
            string totalDineroRangoFecha, marcaMasVendida;

            totalDinero = Convert.ToInt32(tbTotalDineroComputos.Text);
            totalComision = Convert.ToInt32(tbTotalComision.Text);
            totalDineroRangoFecha = tbTotalDineroRangoFecha.Text;
            marcaMasVendida = cbMarcaComputos01.Text;
            objComputos = new DeJesus100315452_LibDealer.Computos(totalDinero, totalComision, totalDineroRangoFecha, marcaMasVendida);
            DialogResult dialogResult = MessageBox.Show("¿Desea guardarlo?", "Guardar...", MessageBoxButtons.YesNo);

            if (dialogResult == DialogResult.Yes)
            {
                if (objComputos.Grabar())
                    MessageBox.Show("Se ha guardado existosamente :D");
                else
                    MessageBox.Show("Error {0}", objComputos.getMensaje());
            }
            else if (dialogResult == DialogResult.No)
            {
                MessageBox.Show("Trate nuevamente :(");
            }

            objComputos = null;
            tbTotalDineroComputos.Text = "";
            tbTotalComision.Text = "";
            tbTotalDineroRangoFecha.Text = "";
            cbMarcaComputos01.Text = "";
        }

        private void btnLimpiarComputos_Click(object sender, EventArgs e)
        {
            tbTotalDineroComputos.Text = "";
            tbTotalComision.Text = "";
            tbTotalDineroRangoFecha.Text = "";
            cbMarcaComputos01.Text = "";
        }

        private void btnVerComputos_Click(object sender, EventArgs e)
        {
            computosWindowForm objVentanaComputos = new computosWindowForm();
            objVentanaComputos.Show();
        }

        
    }
}
