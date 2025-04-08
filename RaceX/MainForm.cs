using RaceX.Models;
using RaceX.Utilities;
using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace RaceX
{
    public partial class MainForm : Form
    {
        private Carrera carrera = new Carrera();

        public MainForm()
        {
            InitializeComponent();
            ConfigurarControles();
        }

        private void ConfigurarControles()
        {
            cmbTipoAuto.Items.AddRange(new[] { "Deportivo", "Todoterreno", "Híbrido" });
            cmbClima.DataSource = Enum.GetValues(typeof(Clima));
        }

        // Botón: Agregar Auto
        private void btnAgregarAuto_Click(object sender, EventArgs e)
        {
            try
            {
                ValidarNombreAuto();
                var auto = AutoFactory.CrearAuto(cmbTipoAuto.Text, txtNombre.Text);
                ValidarNombreDuplicado(auto.Nombre);
                carrera.Autos.Add(auto);
                ActualizarListaAutos();
                txtNombre.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Botón: Iniciar Carrera
        private void btnIniciarCarrera_Click(object sender, EventArgs e)
        {
            if (cmbClima.SelectedItem == null)
            {
                MessageBox.Show("Seleccione un clima antes de iniciar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (carrera.Autos.Count < 3)
            {
                MessageBox.Show("¡Mínimo 3 autos para iniciar!", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            carrera.IniciarCarrera((Clima)cmbClima.SelectedItem);
            BloquearControles();
            MessageBox.Show("¡Carrera iniciada!", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // Botón: Siguiente Turno
        private void btnSiguienteTurno_Click(object sender, EventArgs e)
        {
            carrera.SimularTurno();
            ActualizarProgreso();
            var ganadores = carrera.VerificarGanadores();
            if (ganadores.Any())
            {
                string mensaje = ganadores.Count == 1
                    ? $"¡{ganadores[0].Nombre} ha ganado!"
                    : $"¡Empate entre: {string.Join(", ", ganadores.Select(g => g.Nombre))}!";
                MessageBox.Show(mensaje, "Fin de la carrera", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                btnSiguienteTurno.Enabled = false;
            }
        }

        // Botón: Reiniciar
        private void btnReiniciar_Click(object sender, EventArgs e)
        {
            ReiniciarControles();
        }

        // Métodos auxiliares
        private void ValidarNombreAuto()
        {
            if (string.IsNullOrWhiteSpace(txtNombre.Text))
                throw new ArgumentException("El nombre no puede estar vacío");
        }

        private void ValidarNombreDuplicado(string nombre)
        {
            if (carrera.Autos.Any(a => a.Nombre.Equals(nombre, StringComparison.OrdinalIgnoreCase)))
                throw new ArgumentException("Nombre duplicado");
        }

        private void ActualizarListaAutos()
        {
            dgvAutos.DataSource = carrera.Autos.Select(a => new { a.Nombre, a.Tipo }).ToList();
        }

        private void ActualizarProgreso()
        {
            if (InvokeRequired)
            {
                Invoke(new MethodInvoker(ActualizarProgreso));
                return;
            }
            flowLayoutPanel.Controls.Clear();
            foreach (var auto in carrera.Autos)
            {
                var progressBar = new ProgressBar
                {
                    Width = 300,
                    Maximum = 150,
                    //Value = auto.DistanciaRecorrida,
                    Style = ProgressBarStyle.Continuous
                };
                var label = new Label { Text = $"{auto.Nombre}: m" };
                flowLayoutPanel.Controls.Add(label);
                flowLayoutPanel.Controls.Add(progressBar);
            }
        }

        private void BloquearControles()
        {
            txtNombre.Enabled = false;
            cmbTipoAuto.Enabled = false;
            btnAgregarAuto.Enabled = false;
            cmbClima.Enabled = false;
            btnIniciarCarrera.Enabled = false;
            btnSiguienteTurno.Enabled = true;
        }

        private void ReiniciarControles()
        {
            txtNombre.Enabled = true;
            cmbTipoAuto.Enabled = true;
            btnAgregarAuto.Enabled = true;
            cmbClima.Enabled = true;
            btnIniciarCarrera.Enabled = true;
            btnSiguienteTurno.Enabled = false;
            flowLayoutPanel.Controls.Clear();
            dgvAutos.DataSource = null;
            carrera = new Carrera();
        }
    }
}