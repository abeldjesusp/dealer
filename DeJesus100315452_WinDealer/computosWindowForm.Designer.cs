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
            this.label1 = new System.Windows.Forms.Label();
            this.tbBuscarIDComputo = new System.Windows.Forms.TextBox();
            this.btnBuscarComputo = new System.Windows.Forms.Button();
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
            this.dataGridComputos.Location = new System.Drawing.Point(0, 0);
            this.dataGridComputos.Name = "dataGridComputos";
            this.dataGridComputos.ReadOnly = true;
            this.dataGridComputos.Size = new System.Drawing.Size(774, 292);
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 306);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Buscar computo por ID";
            // 
            // tbBuscarIDComputo
            // 
            this.tbBuscarIDComputo.Location = new System.Drawing.Point(26, 336);
            this.tbBuscarIDComputo.Name = "tbBuscarIDComputo";
            this.tbBuscarIDComputo.Size = new System.Drawing.Size(113, 20);
            this.tbBuscarIDComputo.TabIndex = 2;
            // 
            // btnBuscarComputo
            // 
            this.btnBuscarComputo.Location = new System.Drawing.Point(156, 336);
            this.btnBuscarComputo.Name = "btnBuscarComputo";
            this.btnBuscarComputo.Size = new System.Drawing.Size(75, 23);
            this.btnBuscarComputo.TabIndex = 3;
            this.btnBuscarComputo.Text = "Buscar";
            this.btnBuscarComputo.UseVisualStyleBackColor = true;
            this.btnBuscarComputo.Click += new System.EventHandler(this.btnBuscarComputo_Click);
            // 
            // computosWindowForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(774, 368);
            this.Controls.Add(this.btnBuscarComputo);
            this.Controls.Add(this.tbBuscarIDComputo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridComputos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "computosWindowForm";
            this.Text = "Computos";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridComputos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridComputos;
        private System.Windows.Forms.DataGridViewTextBoxColumn idComputos;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalDinero;
        private System.Windows.Forms.DataGridViewTextBoxColumn comisionComputos;
        private System.Windows.Forms.DataGridViewTextBoxColumn dineroRangoFecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn marcaMasVendidaComputos;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaComputos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbBuscarIDComputo;
        private System.Windows.Forms.Button btnBuscarComputo;
    }
}