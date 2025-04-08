using System;

namespace RaceXSimulator.Models
{
    public class AutoDeportivo : Auto
    {
        public AutoDeportivo(string nombre) : base(nombre)
        {
            Tipo = "Deportivo";
        }

        public override void Avanzar(Clima clima)
        {
            int avanceBase = new Random().Next(5, 16);
            int bonificacion = (clima == Clima.Soleado) ? 3 : 0;
            DistanciaRecorrida += avanceBase + bonificacion;
        }
    }
}