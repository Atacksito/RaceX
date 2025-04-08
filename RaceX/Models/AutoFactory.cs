
using System;

namespace RaceXSimulator.Models
{
    public static class AutoFactory
    {
        public static Auto CrearAuto(string tipo, string nombre)
        {
            switch (tipo)
            {
                case "Deportivo":
                    return new AutoDeportivo(nombre);
                case "Todoterreno":
                    return new AutoTodoterreno(nombre);
                case "Híbrido":
                    return new AutoHibrido(nombre);
                default:
                    throw new ArgumentException("Tipo de auto no válido.");
            }
        }
    }
}