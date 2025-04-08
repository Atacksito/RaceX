using System;
using RaceX.Models;

namespace RaceX.Models
{
    public class AutoTodoterreno : Auto
    {
        private static readonly Random _random = new Random();

        public AutoTodoterreno(string nombre) : base(nombre)
        {
            Tipo = "Todoterreno";
        }

        public override void Avanzar(Clima clima)
        {
            int avanceBase = _random.Next(5, 16);
            DistanciaRecorrida += clima == Clima.Lluvia ? avanceBase + 2 : avanceBase;
        }
    }
}