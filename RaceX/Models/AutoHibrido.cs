using System;
using RaceX.Models;

namespace RaceX.Models
{
    public class AutoHibrido : Auto
    {
        private static readonly Random _random = new Random();

        public AutoHibrido(string nombre) : base(nombre)
        {
            Tipo = "Híbrido";
        }

        public override void Avanzar(Clima clima)
        {
            int avanceBase = _random.Next(5, 16);
            DistanciaRecorrida += clima == Clima.Ventoso ? avanceBase - 1 : avanceBase;
        }
    }
}