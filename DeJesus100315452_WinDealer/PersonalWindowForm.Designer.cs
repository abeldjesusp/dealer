namespace DeJesus100315452_WinDealer
{
    partial class PersonalWindowForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PersonalWindowForm));
            this.dataGridPersonal = new System.Windows.Forms.DataGridView();
            this.idPersonal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombrePersonal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cargoPersonal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codioEmpleado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salarioPersonal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fehaIngresoEmpleado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.tbBuscarIdPersonal = new System.Windows.Forms.TextBox();
            this.btnBuscarPersonal = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridPersonal)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridPersonal
            // 
            this.dataGridPersonal.AllowUserToAddRows = false;
            this.dataGridPersonal.AllowUserToDeleteRows = false;
            this.dataGridPersonal.AllowUserToResizeColumns = false;
            this.dataGridPersonal.AllowUserToResizeRows = false;
            this.dataGridPersonal.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridPersonal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridPersonal.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idPersonal,
            this.nombrePersonal,
            this.cargoPersonal,
            this.codioEmpleado,
            this.salarioPersonal,
            this.fehaIngresoEmpleado});
            this.dataGridPersonal.Location = new System.Drawing.Point(0, 0);
            this.dataGridPersonal.Name = "dataGridPersonal";
            this.dataGridPersonal.ReadOnly = true;
            this.dataGridPersonal.Size = new System.Drawing.Size(757, 278);
            this.dataGridPersonal.TabIndex = 0;
            // 
            // idPersonal
            // 
            this.idPersonal.HeaderText = "ID";
            this.idPersonal.Name = "idPersonal";
            this.idPersonal.ReadOnly = true;
            // 
            // nombrePersonal
            // 
            this.nombrePersonal.HeaderText = "Nombre";
            this.nombrePersonal.Name = "nombrePersonal";
            this.nombrePersonal.ReadOnly = true;
            // 
            // cargoPersonal
            // 
            this.cargoPersonal.HeaderText = "Cargo que ocupa";
            this.cargoPersonal.Name = "cargoPersonal";
            this.cargoPersonal.ReadOnly = true;
            this.cargoPersonal.Width = 130;
            // 
            // codioEmpleado
            // 
            this.codioEmpleado.HeaderText = "Código de empleado";
            this.codioEmpleado.Name = "codioEmpleado";
            this.codioEmpleado.ReadOnly = true;
            this.codioEmpleado.Width = 130;
            // 
            // salarioPersonal
            // 
            this.salarioPersonal.HeaderText = "Salario";
            this.salarioPersonal.Name = "salarioPersonal";
            this.salarioPersonal.ReadOnly = true;
            // 
            // fehaIngresoEmpleado
            // 
            this.fehaIngresoEmpleado.HeaderText = "Fecha de ingreso";
            this.fehaIngresoEmpleado.Name = "fehaIngresoEmpleado";
            this.fehaIngresoEmpleado.ReadOnly = true;
            this.fehaIngresoEmpleado.Width = 150;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 315);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Buscar empleado por ID";
            // 
            // tbBuscarIdPersonal
            // 
            this.tbBuscarIdPersonal.Location = new System.Drawing.Point(15, 352);
            this.tbBuscarIdPersonal.Name = "tbBuscarIdPersonal";
            this.tbBuscarIdPersonal.Size = new System.Drawing.Size(118, 20);
            this.tbBuscarIdPersonal.TabIndex = 2;
            // 
            // btnBuscarPersonal
            // 
            this.btnBuscarPersonal.Location = new System.Drawing.Point(149, 352);
            this.btnBuscarPersonal.Name = "btnBuscarPersonal";
            this.btnBuscarPersonal.Size = new System.Drawing.Size(75, 23);
            this.btnBuscarPersonal.TabIndex = 3;
            this.btnBuscarPersonal.Text = "Buscar";
            this.btnBuscarPersonal.UseVisualStyleBackColor = true;
            this.btnBuscarPersonal.Click += new System.EventHandler(this.btnBuscarPersonal_Click);
            // 
            // PersonalWindowForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(757, 395);
            this.Controls.Add(this.btnBuscarPersonal);
            this.Controls.Add(this.tbBuscarIdPersonal);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridPersonal);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PersonalWindowForm";
            this.Text = "Personal";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridPersonal)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridPersonal;
        private System.Windows.Forms.DataGridViewTextBoxColumn idPersonal;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombrePersonal;
        private System.Windows.Forms.DataGridViewTextBoxColumn cargoPersonal;
        private System.Windows.Forms.DataGridViewTextBoxColumn codioEmpleado;
        private System.Windows.Forms.DataGridViewTextBoxColumn salarioPersonal;
        private System.Windows.Forms.DataGridViewTextBoxColumn fehaIngresoEmpleado;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbBuscarIdPersonal;
        private System.Windows.Forms.Button btnBuscarPersonal;
    }
}