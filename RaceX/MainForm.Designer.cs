namespace RaceX
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;

        // Controles del formulario
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.ComboBox cmbTipoAuto;
        private System.Windows.Forms.ComboBox cmbClima;
        private System.Windows.Forms.Button btnAgregarAuto;
        private System.Windows.Forms.Button btnIniciarCarrera;
        private System.Windows.Forms.Button btnSiguienteTurno;
        private System.Windows.Forms.DataGridView dgvAutos;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel;
        private System.Windows.Forms.Button btnReiniciar;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            // Configuración de controles (generado automáticamente)
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.cmbTipoAuto = new System.Windows.Forms.ComboBox();
            this.cmbClima = new System.Windows.Forms.ComboBox();
            this.btnAgregarAuto = new System.Windows.Forms.Button();
            this.btnIniciarCarrera = new System.Windows.Forms.Button();
            this.btnSiguienteTurno = new System.Windows.Forms.Button();
            this.dgvAutos = new System.Windows.Forms.DataGridView();
            this.flowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.btnReiniciar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAutos)).BeginInit();
            this.SuspendLayout();

            // ... (Configuración detallada de cada control: posición, tamaño, eventos, etc.)

            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.cmbTipoAuto);
            this.Controls.Add(this.cmbClima);
            this.Controls.Add(this.btnAgregarAuto);
            this.Controls.Add(this.btnIniciarCarrera);
            this.Controls.Add(this.btnSiguienteTurno);
            this.Controls.Add(this.dgvAutos);
            this.Controls.Add(this.flowLayoutPanel);
            this.Controls.Add(this.btnReiniciar);
            this.Name = "MainForm";
            this.Text = "RaceX - Simulador de Carreras";
            ((System.ComponentModel.ISupportInitialize)(this.dgvAutos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}