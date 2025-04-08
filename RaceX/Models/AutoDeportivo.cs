using System.Security.Claims;
using System;
using RaceX.Utilities;

namespace RaceX.Models
{
    public class AutoDeportivo : Auto
    {
        public AutoDeportivo(string nombre) : base(nombre)
        {
            Tipo = "Deportivo";
        }

        public override void Avanzar(Clima clima)
        {
            int avance = new Random().Next(5, 16);
            if (clima == Clima.Soleado) avance += 3; 
            DistanciaRecorrida += avance;
        }
    }
}