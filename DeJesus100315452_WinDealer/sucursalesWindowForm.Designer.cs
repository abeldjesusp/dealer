﻿namespace DeJesus100315452_WinDealer
{
    partial class sucursalesWindowForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(sucursalesWindowForm));
            this.dataGridSucursales = new System.Windows.Forms.DataGridView();
            this.idSucursal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreSucursal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estadoSucursal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaAperturaSucursal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridSucursales)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridSucursales
            // 
            this.dataGridSucursales.AllowUserToAddRows = false;
            this.dataGridSucursales.AllowUserToDeleteRows = false;
            this.dataGridSucursales.AllowUserToOrderColumns = true;
            this.dataGridSucursales.AllowUserToResizeColumns = false;
            this.dataGridSucursales.AllowUserToResizeRows = false;
            this.dataGridSucursales.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridSucursales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridSucursales.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idSucursal,
            this.nombreSucursal,
            this.estadoSucursal,
            this.fechaAperturaSucursal});
            this.dataGridSucursales.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridSucursales.Location = new System.Drawing.Point(0, 0);
            this.dataGridSucursales.Name = "dataGridSucursales";
            this.dataGridSucursales.ReadOnly = true;
            this.dataGridSucursales.ShowCellToolTips = false;
            this.dataGridSucursales.ShowEditingIcon = false;
            this.dataGridSucursales.Size = new System.Drawing.Size(523, 313);
            this.dataGridSucursales.TabIndex = 0;
            // 
            // idSucursal
            // 
            this.idSucursal.HeaderText = "ID";
            this.idSucursal.Name = "idSucursal";
            this.idSucursal.ReadOnly = true;
            // 
            // nombreSucursal
            // 
            this.nombreSucursal.HeaderText = "Nombre";
            this.nombreSucursal.Name = "nombreSucursal";
            this.nombreSucursal.ReadOnly = true;
            this.nombreSucursal.Width = 120;
            // 
            // estadoSucursal
            // 
            this.estadoSucursal.HeaderText = "Estado";
            this.estadoSucursal.Name = "estadoSucursal";
            this.estadoSucursal.ReadOnly = true;
            this.estadoSucursal.Width = 110;
            // 
            // fechaAperturaSucursal
            // 
            this.fechaAperturaSucursal.HeaderText = "Fecha apertura";
            this.fechaAperturaSucursal.Name = "fechaAperturaSucursal";
            this.fechaAperturaSucursal.ReadOnly = true;
            this.fechaAperturaSucursal.Width = 150;
            // 
            // sucursalesWindowForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(523, 313);
            this.Controls.Add(this.dataGridSucursales);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "sucursalesWindowForm";
            this.Text = "Sucursales";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridSucursales)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridSucursales;
        private System.Windows.Forms.DataGridViewTextBoxColumn idSucursal;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreSucursal;
        private System.Windows.Forms.DataGridViewTextBoxColumn estadoSucursal;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaAperturaSucursal;
    }
}