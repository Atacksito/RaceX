using RaceX.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace RaceX.Models
{
    public class Carrera
    {
        public List<Auto> Autos { get; } = new List<Auto>();
        public Clima ClimaActual { get; private set; }
        public bool CarreraIniciada { get; private set; }
        private static readonly Random _random = new Random();

        public void IniciarCarrera(Clima clima)
        {
            if (Autos.Count >= 3)
            {
                ClimaActual = clima;
                CarreraIniciada = true;
            }
        }

        public void SimularTurno()
        {
            foreach (var auto in Autos)
            {
                auto.Avanzar(ClimaActual);
                if (_random.Next(0, 100) < 30)
                {
                    auto.DistanciaRecorrida = Math.Max(0, auto.DistanciaRecorrida - 5);
                }
            }
        }

        public List<Auto> VerificarGanadores()
        {
            return Autos.Where(a => a.DistanciaRecorrida >= 150).ToList();
        }
    }
}