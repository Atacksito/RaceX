using System;
using System.Collections.Generic;
using System.Linq;

namespace RaceXSimulator.Models
{
    public class Carrera
    {
        public List<Auto> Autos { get; } = new List<Auto>();
        public Clima ClimaActual { get; private set; }
        public bool CarreraIniciada { get; private set; }

        public void IniciarCarrera(Clima clima)
        {
            if (Autos.Count < 3)
                throw new InvalidOperationException("Mínimo 3 autos requeridos.");

            if (Autos.Select(a => a.Nombre).Distinct().Count() != Autos.Count)
                throw new InvalidOperationException("Nombres duplicados detectados.");

            ClimaActual = clima;
            CarreraIniciada = true;
        }

        public void SiguienteTurno()
        {
            if (!CarreraIniciada) return;

            var rnd = new Random();
            foreach (var auto in Autos.OrderBy(a => rnd.Next()))
            {
                auto.Avanzar(ClimaActual);
                if (rnd.NextDouble() <= 0.3)
                    auto.AjustarDistancia(-5);
            }
        }

        public Auto ObtenerGanador() => Autos.FirstOrDefault(a => a.DistanciaRecorrida >= 150);
    }
}