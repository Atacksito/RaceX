using System;

namespace RaceX.Models
{
    public static class AutoFactory
    {
        public static Auto CrearAuto(string tipo, string nombre)
        {
            return tipo switch
            {
                "Deportivo" => new AutoDeportivo(nombre),
                "Todoterreno" => new AutoTodoterreno(nombre),
                "Híbrido" => new AutoHibrido(nombre),
                _ => throw new ArgumentException("Tipo de auto no válido"),
            };
        }
    }
}