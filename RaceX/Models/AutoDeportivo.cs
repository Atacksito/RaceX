using RaceX.Models;
using RaceX.Utilities;

public class AutoDeportivo : Auto
{
    public AutoDeportivo(string nombre) : base(nombre) { }

    public override void Avanzar(Clima clima)
    {
        switch (clima)
        {
            case Clima.Soleado:
                DistanciaRecorrida += 20; // Avanza más rápido en clima soleado
                break;
            case Clima.Lluvia:
                DistanciaRecorrida += 10; // Avanza más lento en lluvia
                break;
            case Clima.Ventoso:
                DistanciaRecorrida += 15; // Velocidad media en clima ventoso
                break;
        }
    }
}