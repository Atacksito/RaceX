using RaceX.Models;
using System;
using System.Linq;
using System.Windows.Forms;

namespace RaceX.Forms
{
    public partial class MainForm : Form
    {
        private Carrera _carrera = new Carrera();

        public MainForm()
        {
            InitializeComponent();
            ConfigurarDataGridView();
            cmbClima.DataSource = Enum.GetValues(typeof(Clima));
            cmbTipoAuto.Items.AddRange(new[] { "Deportivo", "Todoterreno", "Híbrido" });
            btnSiguienteTurno.Enabled = false;
        }

        private void ConfigurarDataGridView()
        {
            dgvProgreso.AutoGenerateColumns = false;

            dgvProgreso.Columns.Add(new DataGridViewTextBoxColumn()
            {
                DataPropertyName = "Nombre",
                HeaderText = "Nombre",
                Width = 120
            });

            dgvProgreso.Columns.Add(new DataGridViewTextBoxColumn()
            {
                DataPropertyName = "Tipo",
                HeaderText = "Tipo",
                Width = 100
            });

            dgvProgreso.Columns.Add(new DataGridViewTextBoxColumn()
            {
                DataPropertyName = "Distancia",
                HeaderText = "Distancia",
                Width = 80
            });
        }

        private void btnAgregarAuto_Click(object sender, EventArgs e)
        {
            try
            {
                var nuevoAuto = AutoFactory.CrearAuto(
                    cmbTipoAuto.SelectedItem?.ToString(),
                    txtNombreAuto.Text.Trim()
                );

                if (_carrera.Autos.Any(a => a.Nombre.Equals(nuevoAuto.Nombre, StringComparison.OrdinalIgnoreCase)))
                    throw new ArgumentException("¡Nombre duplicado!");

                _carrera.Autos.Add(nuevoAuto);
                ActualizarProgreso();
                txtNombreAuto.Clear();
                lblMensajes.Text = $"{nuevoAuto.Nombre} agregado ✅";
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
                btnSiguienteTurno.Enabled = true;
                lblMensajes.Text = $"🏁 Carrera iniciada - Clima: {_carrera.ClimaActual}";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSiguienteTurno_Click(object sender, EventArgs e)
        {
            try
            {
                _carrera.SiguienteTurno();
                ActualizarProgreso();

                var ganador = _carrera.ObtenerGanador();
                if (ganador != null)
                {
                    lblMensajes.Text = $"🏆 ¡{ganador.Nombre} ganó con {ganador.DistanciaRecorrida}m!";
                    btnSiguienteTurno.Enabled = false;
                    MessageBox.Show("¡Carrera finalizada!", "RaceX", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    lblMensajes.Text = "⏭ Turno completado";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ActualizarProgreso()
        {
            dgvProgreso.DataSource = _carrera.Autos.Select(a => new ProgresoAuto
            {
                Nombre = a.Nombre,
                Tipo = a.Tipo,
                Distancia = $"{a.DistanciaRecorrida}m",
                Progreso = a.DistanciaRecorrida
            }).ToList();
        }
    }
}