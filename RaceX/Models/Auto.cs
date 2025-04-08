// Auto.cs
using System;

namespace RaceXSimulator.Models
{
    public abstract class Auto
    {
        public string Nombre { get; private set; }
        public int DistanciaRecorrida { get; protected set; }
        public string Tipo { get; protected set; }

        protected Auto(string nombre)
        {
            if (string.IsNullOrEmpty(nombre))
                throw new ArgumentException("El nombre no puede estar vacío.");

            Nombre = nombre;
        }

        public abstract void Avanzar(Clima clima);

        public void AjustarDistancia(int ajuste)
        {
            DistanciaRecorrida = Math.Max(0, DistanciaRecorrida + ajuste);
        }
    }
}