using System;
using RaceX.Utilities;

namespace RaceX.Models
{
    public class AutoTodoterreno : Auto
    {
        public AutoTodoterreno(string nombre) : base(nombre)
        {
            Tipo = "Todoterreno";
        }

        public override void Avanzar(Clima clima)
        {
            int avance = new Random().Next(5, 16);
            if (clima == Clima.Lluvia) avance += 2;
            DistanciaRecorrida += avance;
        }
    }
}