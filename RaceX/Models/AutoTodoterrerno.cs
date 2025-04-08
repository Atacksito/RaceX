using RaceX.Models;
using RaceX.Utilities;

public class AutoTodoterreno : Auto
{
    public AutoTodoterreno(string nombre) : base(nombre) { }

    public override void Avanzar(Clima clima)
    {
        switch (clima)
        {
            case Clima.Soleado:
                DistanciaRecorrida += 15; // Velocidad media en clima soleado
                break;
            case Clima.Lluvia:
                DistanciaRecorrida += 15; // Avanza igual en lluvia
                break;
            case Clima.Ventoso:
                DistanciaRecorrida += 15; // Avanza igual en clima ventoso
                break;
        }
    }
}