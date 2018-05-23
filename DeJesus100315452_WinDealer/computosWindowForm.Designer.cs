namespace DeJesus100315452_WinDealer
{
    partial class computosWindowForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(computosWindowForm));
            this.dataGridComputos = new System.Windows.Forms.DataGridView();
            this.idComputos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalDinero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comisionComputos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dineroRangoFecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.marcaMasVendidaComputos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaComputos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridComputos)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridComputos
            // 
            this.dataGridComputos.AllowUserToAddRows = false;
            this.dataGridComputos.AllowUserToDeleteRows = false;
            this.dataGridComputos.AllowUserToResizeColumns = false;
            this.dataGridComputos.AllowUserToResizeRows = false;
            this.dataGridComputos.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridComputos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridComputos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idComputos,
            this.totalDinero,
            this.comisionComputos,
            this.dineroRangoFecha,
            this.marcaMasVendidaComputos,
            this.fechaComputos});
            this.dataGridComputos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridComputos.Location = new System.Drawing.Point(0, 0);
            this.dataGridComputos.Name = "dataGridComputos";
            this.dataGridComputos.ReadOnly = true;
            this.dataGridComputos.Size = new System.Drawing.Size(774, 336);
            this.dataGridComputos.TabIndex = 0;
            // 
            // idComputos
            // 
            this.idComputos.HeaderText = "ID";
            this.idComputos.Name = "idComputos";
            this.idComputos.ReadOnly = true;
            // 
            // totalDinero
            // 
            this.totalDinero.HeaderText = "Total del dinero";
            this.totalDinero.Name = "totalDinero";
            this.totalDinero.ReadOnly = true;
            this.totalDinero.Width = 120;
            // 
            // comisionComputos
            // 
            this.comisionComputos.HeaderText = "Comisión a empleados";
            this.comisionComputos.Name = "comisionComputos";
            this.comisionComputos.ReadOnly = true;
            this.comisionComputos.Width = 130;
            // 
            // dineroRangoFecha
            // 
            this.dineroRangoFecha.HeaderText = "Dinero en un rango de fecha";
            this.dineroRangoFecha.Name = "dineroRangoFecha";
            this.dineroRangoFecha.ReadOnly = true;
            this.dineroRangoFecha.Width = 150;
            // 
            // marcaMasVendidaComputos
            // 
            this.marcaMasVendidaComputos.HeaderText = "Marca mas vendida";
            this.marcaMasVendidaComputos.Name = "marcaMasVendidaComputos";
            this.marcaMasVendidaComputos.ReadOnly = true;
            // 
            // fechaComputos
            // 
            this.fechaComputos.HeaderText = "Fecha";
            this.fechaComputos.Name = "fechaComputos";
            this.fechaComputos.ReadOnly = true;
            this.fechaComputos.Width = 130;
            // 
            // computosWindowForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(774, 336);
            this.Controls.Add(this.dataGridComputos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "computosWindowForm";
            this.Text = "Computos";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridComputos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridComputos;
        private System.Windows.Forms.DataGridViewTextBoxColumn idComputos;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalDinero;
        private System.Windows.Forms.DataGridViewTextBoxColumn comisionComputos;
        private System.Windows.Forms.DataGridViewTextBoxColumn dineroRangoFecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn marcaMasVendidaComputos;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaComputos;
    }
}