namespace DeJesus100315452_WinDealer
{
    partial class ventasWindowForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ventasWindowForm));
            this.dataGridVentas = new System.Windows.Forms.DataGridView();
            this.idVentas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vehiculoVentas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vendedorVentas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.compradorVentas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precioVentas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridVentas)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridVentas
            // 
            this.dataGridVentas.AllowUserToAddRows = false;
            this.dataGridVentas.AllowUserToDeleteRows = false;
            this.dataGridVentas.AllowUserToResizeColumns = false;
            this.dataGridVentas.AllowUserToResizeRows = false;
            this.dataGridVentas.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridVentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridVentas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idVentas,
            this.vehiculoVentas,
            this.vendedorVentas,
            this.compradorVentas,
            this.precioVentas,
            this.Fecha});
            this.dataGridVentas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridVentas.Location = new System.Drawing.Point(0, 0);
            this.dataGridVentas.Name = "dataGridVentas";
            this.dataGridVentas.ReadOnly = true;
            this.dataGridVentas.ShowEditingIcon = false;
            this.dataGridVentas.ShowRowErrors = false;
            this.dataGridVentas.Size = new System.Drawing.Size(664, 350);
            this.dataGridVentas.TabIndex = 0;
            // 
            // idVentas
            // 
            this.idVentas.HeaderText = "ID";
            this.idVentas.Name = "idVentas";
            this.idVentas.ReadOnly = true;
            // 
            // vehiculoVentas
            // 
            this.vehiculoVentas.HeaderText = "Vehiculos";
            this.vehiculoVentas.Name = "vehiculoVentas";
            this.vehiculoVentas.ReadOnly = true;
            // 
            // vendedorVentas
            // 
            this.vendedorVentas.HeaderText = "Vendedor";
            this.vendedorVentas.Name = "vendedorVentas";
            this.vendedorVentas.ReadOnly = true;
            // 
            // compradorVentas
            // 
            this.compradorVentas.HeaderText = "Comprador";
            this.compradorVentas.Name = "compradorVentas";
            this.compradorVentas.ReadOnly = true;
            // 
            // precioVentas
            // 
            this.precioVentas.HeaderText = "Precio";
            this.precioVentas.Name = "precioVentas";
            this.precioVentas.ReadOnly = true;
            // 
            // Fecha
            // 
            this.Fecha.HeaderText = "Fecha de venta";
            this.Fecha.Name = "Fecha";
            this.Fecha.ReadOnly = true;
            this.Fecha.Width = 120;
            // 
            // ventasWindowForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(664, 350);
            this.Controls.Add(this.dataGridVentas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ventasWindowForm";
            this.Text = "Ventas";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridVentas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridVentas;
        private System.Windows.Forms.DataGridViewTextBoxColumn idVentas;
        private System.Windows.Forms.DataGridViewTextBoxColumn vehiculoVentas;
        private System.Windows.Forms.DataGridViewTextBoxColumn vendedorVentas;
        private System.Windows.Forms.DataGridViewTextBoxColumn compradorVentas;
        private System.Windows.Forms.DataGridViewTextBoxColumn precioVentas;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha;
    }
}