using System;
using RaceX.Utilities;

namespace RaceX.Models
{
    public class AutoHibrido : Auto
    {
        public AutoHibrido(string nombre) : base(nombre)
        {
            Tipo = "Híbrido";
        }

        public override void Avanzar(Clima clima)
        {
            int avance = new Random().Next(5, 16);
            if (clima == Clima.Ventoso) avance = Math.Max(0, avance - 1);
            DistanciaRecorrida += avance;
        }
    }
}