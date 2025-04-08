namespace RaceXSimulator.Forms
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.TextBox txtNombreAuto;
        private System.Windows.Forms.ComboBox cmbTipoAuto;
        private System.Windows.Forms.ComboBox cmbClima;
        private System.Windows.Forms.Button btnAgregarAuto;
        private System.Windows.Forms.Button btnIniciarCarrera;
        private System.Windows.Forms.Button btnSiguienteTurno;
        private System.Windows.Forms.DataGridView dgvProgreso;
        private System.Windows.Forms.Label lblMensajes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.txtNombreAuto = new System.Windows.Forms.TextBox();
            this.cmbTipoAuto = new System.Windows.Forms.ComboBox();
            this.cmbClima = new System.Windows.Forms.ComboBox();
            this.btnAgregarAuto = new System.Windows.Forms.Button();
            this.btnIniciarCarrera = new System.Windows.Forms.Button();
            this.btnSiguienteTurno = new System.Windows.Forms.Button();
            this.dgvProgreso = new System.Windows.Forms.DataGridView();
            this.lblMensajes = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProgreso)).BeginInit();
            this.SuspendLayout();

            // 
            // txtNombreAuto
            // 
            this.txtNombreAuto.Location = new System.Drawing.Point(20, 40);
            this.txtNombreAuto.Name = "txtNombreAuto";
            this.txtNombreAuto.Size = new System.Drawing.Size(150, 20);
            this.txtNombreAuto.TabIndex = 0;

            // 
            // cmbTipoAuto
            // 
            this.cmbTipoAuto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipoAuto.FormattingEnabled = true;
            this.cmbTipoAuto.Location = new System.Drawing.Point(20, 90);
            this.cmbTipoAuto.Name = "cmbTipoAuto";
            this.cmbTipoAuto.Size = new System.Drawing.Size(150, 21);
            this.cmbTipoAuto.TabIndex = 1;

            // 
            // cmbClima
            // 
            this.cmbClima.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbClima.FormattingEnabled = true;
            this.cmbClima.Location = new System.Drawing.Point(20, 140);
            this.cmbClima.Name = "cmbClima";
            this.cmbClima.Size = new System.Drawing.Size(150, 21);
            this.cmbClima.TabIndex = 2;

            // 
            // btnAgregarAuto
            // 
            this.btnAgregarAuto.Location = new System.Drawing.Point(20, 180);
            this.btnAgregarAuto.Name = "btnAgregarAuto";
            this.btnAgregarAuto.Size = new System.Drawing.Size(150, 30);
            this.btnAgregarAuto.TabIndex = 3;
            this.btnAgregarAuto.Text = "Agregar Auto";
            this.btnAgregarAuto.UseVisualStyleBackColor = true;
            this.btnAgregarAuto.Click += new System.EventHandler(this.btnAgregarAuto_Click);

            // 
            // btnIniciarCarrera
            // 
            this.btnIniciarCarrera.Location = new System.Drawing.Point(20, 220);
            this.btnIniciarCarrera.Name = "btnIniciarCarrera";
            this.btnIniciarCarrera.Size = new System.Drawing.Size(150, 30);
            this.btnIniciarCarrera.TabIndex = 4;
            this.btnIniciarCarrera.Text = "Iniciar Carrera";
            this.btnIniciarCarrera.UseVisualStyleBackColor = true;
            this.btnIniciarCarrera.Click += new System.EventHandler(this.btnIniciarCarrera_Click);

            // 
            // btnSiguienteTurno
            // 
            this.btnSiguienteTurno.Enabled = false;
            this.btnSiguienteTurno.Location = new System.Drawing.Point(20, 260);
            this.btnSiguienteTurno.Name = "btnSiguienteTurno";
            this.btnSiguienteTurno.Size = new System.Drawing.Size(150, 30);
            this.btnSiguienteTurno.TabIndex = 5;
            this.btnSiguienteTurno.Text = "Siguiente Turno";
            this.btnSiguienteTurno.UseVisualStyleBackColor = true;
            this.btnSiguienteTurno.Click += new System.EventHandler(this.btnSiguienteTurno_Click);

            // 
            // dgvProgreso
            // 
            this.dgvProgreso.AllowUserToAddRows = false;
            this.dgvProgreso.AllowUserToDeleteRows = false;
            this.dgvProgreso.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProgreso.Location = new System.Drawing.Point(200, 40);
            this.dgvProgreso.Name = "dgvProgreso";
            this.dgvProgreso.ReadOnly = true;
            this.dgvProgreso.Size = new System.Drawing.Size(350, 250);
            this.dgvProgreso.TabIndex = 6;

            // 
            // lblMensajes
            // 
            this.lblMensajes.AutoSize = true;
            this.lblMensajes.Location = new System.Drawing.Point(20, 300);
            this.lblMensajes.Name = "lblMensajes";
            this.lblMensajes.Size = new System.Drawing.Size(0, 13);
            this.lblMensajes.TabIndex = 7;

            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Nombre del Vehículo";

            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Tipo de Vehículo";

            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Clima";

            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(570, 350);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblMensajes);
            this.Controls.Add(this.dgvProgreso);
            this.Controls.Add(this.btnSiguienteTurno);
            this.Controls.Add(this.btnIniciarCarrera);
            this.Controls.Add(this.btnAgregarAuto);
            this.Controls.Add(this.cmbClima);
            this.Controls.Add(this.cmbTipoAuto);
            this.Controls.Add(this.txtNombreAuto);
            this.Name = "MainForm";
            this.Text = "RaceX Simulator";
            ((System.ComponentModel.ISupportInitialize)(this.dgvProgreso)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}