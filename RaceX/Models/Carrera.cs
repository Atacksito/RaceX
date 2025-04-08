using System;
using System.Collections.Generic;
using System.Linq;
using RaceX.Models;

namespace RaceX.Models
{
    public class Carrera
    {
        private readonly Random _random = new Random();
        public List<Auto> Autos { get; } = new List<Auto>();
        public Clima ClimaActual { get; private set; }
        public bool CarreraIniciada { get; private set; }

        public void IniciarCarrera(Clima clima)
        {
            if (Autos.Count < 3 || Autos.Select(a => a.Nombre).Distinct().Count() != Autos.Count)
                throw new InvalidOperationException("Se requieren 3 autos con nombres únicos");

            ClimaActual = clima;
            CarreraIniciada = true;
        }

        public void SiguienteTurno()
        {
            if (!CarreraIniciada) return;

            foreach (var auto in Autos.OrderBy(a => _random.Next()))
            {
                auto.Avanzar(ClimaActual);
                if (_random.NextDouble() <= 0.3)
                    auto.AjustarDistancia(-5);
            }
        }

        public Auto ObtenerGanador() => Autos.FirstOrDefault(a => a.DistanciaRecorrida >= 150);
    }
}