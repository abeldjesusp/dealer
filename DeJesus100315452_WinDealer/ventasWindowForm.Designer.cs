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
            this.tbBuscarVentas = new System.Windows.Forms.TextBox();
            this.btnBuscarVentas = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
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
            this.dataGridVentas.Location = new System.Drawing.Point(-5, -3);
            this.dataGridVentas.Name = "dataGridVentas";
            this.dataGridVentas.ReadOnly = true;
            this.dataGridVentas.ShowEditingIcon = false;
            this.dataGridVentas.ShowRowErrors = false;
            this.dataGridVentas.Size = new System.Drawing.Size(672, 269);
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
            // tbBuscarVentas
            // 
            this.tbBuscarVentas.Location = new System.Drawing.Point(12, 308);
            this.tbBuscarVentas.Name = "tbBuscarVentas";
            this.tbBuscarVentas.Size = new System.Drawing.Size(124, 20);
            this.tbBuscarVentas.TabIndex = 1;
            // 
            // btnBuscarVentas
            // 
            this.btnBuscarVentas.Location = new System.Drawing.Point(144, 308);
            this.btnBuscarVentas.Name = "btnBuscarVentas";
            this.btnBuscarVentas.Size = new System.Drawing.Size(75, 23);
            this.btnBuscarVentas.TabIndex = 2;
            this.btnBuscarVentas.Text = "Buscar";
            this.btnBuscarVentas.UseVisualStyleBackColor = true;
            this.btnBuscarVentas.Click += new System.EventHandler(this.btnBuscarVentas_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 282);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Buscar por ID";
            // 
            // ventasWindowForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(664, 350);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnBuscarVentas);
            this.Controls.Add(this.tbBuscarVentas);
            this.Controls.Add(this.dataGridVentas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ventasWindowForm";
            this.Text = "Ventas";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridVentas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridVentas;
        private System.Windows.Forms.DataGridViewTextBoxColumn idVentas;
        private System.Windows.Forms.DataGridViewTextBoxColumn vehiculoVentas;
        private System.Windows.Forms.DataGridViewTextBoxColumn vendedorVentas;
        private System.Windows.Forms.DataGridViewTextBoxColumn compradorVentas;
        private System.Windows.Forms.DataGridViewTextBoxColumn precioVentas;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha;
        private System.Windows.Forms.TextBox tbBuscarVentas;
        private System.Windows.Forms.Button btnBuscarVentas;
        private System.Windows.Forms.Label label1;
    }
}