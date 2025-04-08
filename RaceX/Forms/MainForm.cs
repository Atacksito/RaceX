using RaceXSimulator.Models;
using System;
using System.Windows.Forms;
using System.Linq;

namespace RaceXSimulator.Forms
{
    public partial class MainForm : Form
    {
        private Carrera _carrera = new Carrera();

        public MainForm()
        {
            InitializeComponent();
            cmbClima.DataSource = Enum.GetValues(typeof(Clima));
            cmbTipoAuto.Items.AddRange(new[] { "Deportivo", "Todoterreno", "Híbrido" });
        }

        private void btnAgregarAuto_Click(object sender, EventArgs e)
        {
            try
            {
                var auto = AutoFactory.CrearAuto(
                    cmbTipoAuto.SelectedItem?.ToString(),
                    txtNombreAuto.Text
                );
                _carrera.Autos.Add(auto);
                ActualizarProgreso();
                lblMensajes.Text = "Auto agregado correctamente.";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnIniciarCarrera_Click(object sender, EventArgs e)
        {
            try
            {
                _carrera.IniciarCarrera((Clima)cmbClima.SelectedItem);
                btnIniciarCarrera.Enabled = false;
                btnAgregarAuto.Enabled = false;
                lblMensajes.Text = "¡Carrera iniciada!";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSiguienteTurno_Click(object sender, EventArgs e)
        {
            _carrera.SiguienteTurno();
            ActualizarProgreso();

            var ganador = _carrera.ObtenerGanador();
            if (ganador != null)
            {
                lblMensajes.Text = $"¡Ganador: {ganador.Nombre}!";
                btnSiguienteTurno.Enabled = false;
            }
        }

        private void ActualizarProgreso()
        {
            dgvProgreso.DataSource = _carrera.Autos.Select(a => new
            {
                a.Nombre,
                a.Tipo,
                a.DistanciaRecorrida
            }).ToList();
        }
    }
}