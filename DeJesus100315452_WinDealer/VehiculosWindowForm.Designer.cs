namespace DeJesus100315452_WinDealer
{
    partial class VehiculosWindowForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VehiculosWindowForm));
            this.dataGridVehiculos = new System.Windows.Forms.DataGridView();
            this.idVehiculo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.marcaVehiculo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modeloVehiculo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoVehiculo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estadoVehiculo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaVehiculo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridVehiculos)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridVehiculos
            // 
            this.dataGridVehiculos.AllowUserToAddRows = false;
            this.dataGridVehiculos.AllowUserToDeleteRows = false;
            this.dataGridVehiculos.AllowUserToResizeColumns = false;
            this.dataGridVehiculos.AllowUserToResizeRows = false;
            this.dataGridVehiculos.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridVehiculos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridVehiculos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idVehiculo,
            this.marcaVehiculo,
            this.modeloVehiculo,
            this.tipoVehiculo,
            this.estadoVehiculo,
            this.fechaVehiculo});
            this.dataGridVehiculos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridVehiculos.Location = new System.Drawing.Point(0, 0);
            this.dataGridVehiculos.Name = "dataGridVehiculos";
            this.dataGridVehiculos.Size = new System.Drawing.Size(733, 402);
            this.dataGridVehiculos.TabIndex = 0;
            // 
            // idVehiculo
            // 
            this.idVehiculo.HeaderText = "ID";
            this.idVehiculo.Name = "idVehiculo";
            // 
            // marcaVehiculo
            // 
            this.marcaVehiculo.HeaderText = "Marca";
            this.marcaVehiculo.Name = "marcaVehiculo";
            // 
            // modeloVehiculo
            // 
            this.modeloVehiculo.HeaderText = "Modelo";
            this.modeloVehiculo.Name = "modeloVehiculo";
            // 
            // tipoVehiculo
            // 
            this.tipoVehiculo.HeaderText = "Tipo de vehiculo";
            this.tipoVehiculo.Name = "tipoVehiculo";
            this.tipoVehiculo.Width = 130;
            // 
            // estadoVehiculo
            // 
            this.estadoVehiculo.HeaderText = "Estado del vehiculo";
            this.estadoVehiculo.Name = "estadoVehiculo";
            this.estadoVehiculo.Width = 130;
            // 
            // fechaVehiculo
            // 
            this.fechaVehiculo.HeaderText = "Fecha de registro";
            this.fechaVehiculo.Name = "fechaVehiculo";
            this.fechaVehiculo.Width = 130;
            // 
            // VehiculosWindowForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(733, 402);
            this.Controls.Add(this.dataGridVehiculos);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "VehiculosWindowForm";
            this.Text = "Cátalogo de vehiculos";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridVehiculos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridVehiculos;
        private System.Windows.Forms.DataGridViewTextBoxColumn idVehiculo;
        private System.Windows.Forms.DataGridViewTextBoxColumn marcaVehiculo;
        private System.Windows.Forms.DataGridViewTextBoxColumn modeloVehiculo;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoVehiculo;
        private System.Windows.Forms.DataGridViewTextBoxColumn estadoVehiculo;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaVehiculo;
    }
}