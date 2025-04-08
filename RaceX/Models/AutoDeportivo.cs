using System;
using RaceX.Models;

namespace RaceX.Models
{
    public class AutoDeportivo : Auto
    {
        private static readonly Random _random = new Random();

        public AutoDeportivo(string nombre) : base(nombre)
        {
            Tipo = "Deportivo";
        }

        public override void Avanzar(Clima clima)
        {
            int avanceBase = _random.Next(5, 16);
            DistanciaRecorrida += clima == Clima.Soleado ? avanceBase + 3 : avanceBase;
        }
    }
}