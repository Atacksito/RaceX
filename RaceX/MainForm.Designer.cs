namespace RaceX
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.ComboBox cmbTipoAuto;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Button btnAgregarAuto;
        private System.Windows.Forms.ComboBox cmbClima;
        private System.Windows.Forms.Button btnIniciarCarrera;
        private System.Windows.Forms.Button btnSiguienteTurno;
        private System.Windows.Forms.Button btnReiniciar;
        private System.Windows.Forms.DataGridView dgvAutos;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.cmbTipoAuto = new System.Windows.Forms.ComboBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.btnAgregarAuto = new System.Windows.Forms.Button();
            this.cmbClima = new System.Windows.Forms.ComboBox();
            this.btnIniciarCarrera = new System.Windows.Forms.Button();
            this.btnSiguienteTurno = new System.Windows.Forms.Button();
            this.btnReiniciar = new System.Windows.Forms.Button();
            this.dgvAutos = new System.Windows.Forms.DataGridView();
            this.flowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAutos)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbTipoAuto
            // 
            this.cmbTipoAuto.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTipoAuto.FormattingEnabled = true;
            this.cmbTipoAuto.Location = new System.Drawing.Point(12, 12);
            this.cmbTipoAuto.Name = "cmbTipoAuto";
            this.cmbTipoAuto.Size = new System.Drawing.Size(140, 23);
            this.cmbTipoAuto.TabIndex = 0;
            this.cmbTipoAuto.Text = "Tipo de Auto";
            // 
            // txtNombre
            // 
            this.txtNombre.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F);
            this.txtNombre.Location = new System.Drawing.Point(158, 12);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(140, 23);
            this.txtNombre.TabIndex = 1;
            this.txtNombre.Text = "Nombre";
            // 
            // btnAgregarAuto
            // 
            this.btnAgregarAuto.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F);
            this.btnAgregarAuto.Location = new System.Drawing.Point(304, 10);
            this.btnAgregarAuto.Name = "btnAgregarAuto";
            this.btnAgregarAuto.Size = new System.Drawing.Size(120, 23);
            this.btnAgregarAuto.TabIndex = 2;
            this.btnAgregarAuto.Text = "Agregar Auto";
            this.btnAgregarAuto.UseVisualStyleBackColor = true;
            this.btnAgregarAuto.Click += new System.EventHandler(this.btnAgregarAuto_Click);
            // 
            // cmbClima
            // 
            this.cmbClima.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F);
            this.cmbClima.FormattingEnabled = true;
            this.cmbClima.Location = new System.Drawing.Point(12, 39);
            this.cmbClima.Name = "cmbClima";
            this.cmbClima.Size = new System.Drawing.Size(140, 23);
            this.cmbClima.TabIndex = 3;
            this.cmbClima.Text = "Clima";
            // 
            // btnIniciarCarrera
            // 
            this.btnIniciarCarrera.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F);
            this.btnIniciarCarrera.Location = new System.Drawing.Point(158, 37);
            this.btnIniciarCarrera.Name = "btnIniciarCarrera";
            this.btnIniciarCarrera.Size = new System.Drawing.Size(140, 23);
            this.btnIniciarCarrera.TabIndex = 4;
            this.btnIniciarCarrera.Text = "Iniciar Carrera";
            this.btnIniciarCarrera.UseVisualStyleBackColor = true;
            this.btnIniciarCarrera.Click += new System.EventHandler(this.btnIniciarCarrera_Click);
            // 
            // btnSiguienteTurno
            // 
            this.btnSiguienteTurno.Enabled = false;
            this.btnSiguienteTurno.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F);
            this.btnSiguienteTurno.Location = new System.Drawing.Point(304, 37);
            this.btnSiguienteTurno.Name = "btnSiguienteTurno";
            this.btnSiguienteTurno.Size = new System.Drawing.Size(120, 23);
            this.btnSiguienteTurno.TabIndex = 5;
            this.btnSiguienteTurno.Text = "Siguiente Turno";
            this.btnSiguienteTurno.UseVisualStyleBackColor = true;
            this.btnSiguienteTurno.Click += new System.EventHandler(this.btnSiguienteTurno_Click);
            // 
            // btnReiniciar
            // 
            this.btnReiniciar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F);
            this.btnReiniciar.Location = new System.Drawing.Point(12, 66);
            this.btnReiniciar.Name = "btnReiniciar";
            this.btnReiniciar.Size = new System.Drawing.Size(100, 23);
            this.btnReiniciar.TabIndex = 6;
            this.btnReiniciar.Text = "Reiniciar";
            this.btnReiniciar.UseVisualStyleBackColor = true;
            this.btnReiniciar.Click += new System.EventHandler(this.btnReiniciar_Click);
            // 
            // dgvAutos
            // 
            this.dgvAutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAutos.Location = new System.Drawing.Point(12, 95);
            this.dgvAutos.Name = "dgvAutos";
            this.dgvAutos.Size = new System.Drawing.Size(412, 150);
            this.dgvAutos.TabIndex = 7;
            // 
            // flowLayoutPanel
            // 
            this.flowLayoutPanel.AutoScroll = true;
            this.flowLayoutPanel.Location = new System.Drawing.Point(12, 251);
            this.flowLayoutPanel.Name = "flowLayoutPanel";
            this.flowLayoutPanel.Size = new System.Drawing.Size(412, 200);
            this.flowLayoutPanel.TabIndex = 8;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(436, 463);
            this.Controls.Add(this.flowLayoutPanel);
            this.Controls.Add(this.dgvAutos);
            this.Controls.Add(this.btnReiniciar);
            this.Controls.Add(this.btnSiguienteTurno);
            this.Controls.Add(this.btnIniciarCarrera);
            this.Controls.Add(this.cmbClima);
            this.Controls.Add(this.btnAgregarAuto);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.cmbTipoAuto);
            this.Name = "MainForm";
            this.Text = "RaceX";
            ((System.ComponentModel.ISupportInitialize)(this.dgvAutos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
    }
}