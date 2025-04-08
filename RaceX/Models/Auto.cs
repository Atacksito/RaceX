using RaceX.Utilities; // Añadido para referencia a Clima

namespace RaceX.Models
{
    public abstract class Auto
    {
        public string Nombre { get; private set; }
        public string Tipo { get; protected set; }
        public int DistanciaRecorrida { get; protected set; }

        protected Auto(string nombre)
        {
            Nombre = nombre;
            DistanciaRecorrida = 0;
        }

        public abstract void Avanzar(Clima clima);
    }
}