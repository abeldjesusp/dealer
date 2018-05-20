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
            this.dataGridPersonal = new System.Windows.Forms.DataGridView();
            this.idPersonal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombrePersonal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cargoPersonal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codioEmpleado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salarioPersonal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fehaIngresoEmpleado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridPersonal)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridPersonal
            // 
            this.dataGridPersonal.AllowUserToAddRows = false;
            this.dataGridPersonal.AllowUserToDeleteRows = false;
            this.dataGridPersonal.AllowUserToOrderColumns = true;
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
            this.dataGridPersonal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridPersonal.Location = new System.Drawing.Point(0, 0);
            this.dataGridPersonal.Name = "dataGridPersonal";
            this.dataGridPersonal.Size = new System.Drawing.Size(757, 395);
            this.dataGridPersonal.TabIndex = 0;
            // 
            // idPersonal
            // 
            this.idPersonal.HeaderText = "ID";
            this.idPersonal.Name = "idPersonal";
            // 
            // nombrePersonal
            // 
            this.nombrePersonal.HeaderText = "Nombre";
            this.nombrePersonal.Name = "nombrePersonal";
            // 
            // cargoPersonal
            // 
            this.cargoPersonal.HeaderText = "Cargo que ocupa";
            this.cargoPersonal.Name = "cargoPersonal";
            this.cargoPersonal.Width = 130;
            // 
            // codioEmpleado
            // 
            this.codioEmpleado.HeaderText = "Código de empleado";
            this.codioEmpleado.Name = "codioEmpleado";
            this.codioEmpleado.Width = 130;
            // 
            // salarioPersonal
            // 
            this.salarioPersonal.HeaderText = "Salario";
            this.salarioPersonal.Name = "salarioPersonal";
            // 
            // fehaIngresoEmpleado
            // 
            this.fehaIngresoEmpleado.HeaderText = "Fecha de ingreso";
            this.fehaIngresoEmpleado.Name = "fehaIngresoEmpleado";
            this.fehaIngresoEmpleado.Width = 150;
            // 
            // PersonalWindowForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(757, 395);
            this.Controls.Add(this.dataGridPersonal);
            this.Name = "PersonalWindowForm";
            this.Text = "PersonalWindowForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridPersonal)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridPersonal;
        private System.Windows.Forms.DataGridViewTextBoxColumn idPersonal;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombrePersonal;
        private System.Windows.Forms.DataGridViewTextBoxColumn cargoPersonal;
        private System.Windows.Forms.DataGridViewTextBoxColumn codioEmpleado;
        private System.Windows.Forms.DataGridViewTextBoxColumn salarioPersonal;
        private System.Windows.Forms.DataGridViewTextBoxColumn fehaIngresoEmpleado;
    }
}