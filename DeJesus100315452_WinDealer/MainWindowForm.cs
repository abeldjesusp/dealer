using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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

        public MainWindowForm()
        {
            InitializeComponent();
        }

        private void marcaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void acecaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void acercaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("  Dealer Abel S.R.L Copyright 2018  ");
        }

        private void treeViewMenu_AfterSelect(object sender, TreeViewEventArgs e)
        {
            
        }

        private void libreriaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void vehiculosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            panelPersonal.Visible = false;
            panelComputos.Visible = false;
            panelSucursales.Visible = false;
            panelVentas.Visible = false;
            panelCatalogoVehiculos.Visible = true;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void catalogoVehiculos_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void agregar_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

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
        }

        private void panelCatalogoVehiculos_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void tituloSucursales_Click(object sender, EventArgs e)
        {

        }

        private void subtituloComputos_Click(object sender, EventArgs e)
        {

        }

        private void ventasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panelPersonal.Visible = false;
            panelComputos.Visible = false;
            panelSucursales.Visible = false;
            panelCatalogoVehiculos.Visible = false;
            panelVentas.Visible = true;
            
        }

        private void computosGeneralesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panelPersonal.Visible = false;
            panelVentas.Visible = false;            
            panelSucursales.Visible = false;
            panelCatalogoVehiculos.Visible = false;
            panelComputos.Visible = true;
        }

        private void informaciónDeSucursalesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panelPersonal.Visible = false;
            panelVentas.Visible = false;
            panelComputos.Visible = false;
            panelCatalogoVehiculos.Visible = false;            
            panelSucursales.Visible = true;
        }

        private void personalToolStripMenuItem_Click(object sender, EventArgs e)
        {            
            panelVentas.Visible = false;
            panelComputos.Visible = false;
            panelCatalogoVehiculos.Visible = false;
            panelSucursales.Visible = false;
            panelPersonal.Visible = true;
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
    }
}
