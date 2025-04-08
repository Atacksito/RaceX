using RaceX.Models;
using RaceX.Utilities;

public class AutoHibrido : Auto
{
    public AutoHibrido(string nombre) : base(nombre) { }

    public override void Avanzar(Clima clima)
    {
        switch (clima)
        {
            case Clima.Soleado:
                DistanciaRecorrida += 18; // Avanza más rápido en clima soleado
                break;
            case Clima.Lluvia:
                DistanciaRecorrida += 12; // Velocidad media en lluvia
                break;
            case Clima.Ventoso:
                DistanciaRecorrida += 8; // Avanza más lento en clima ventoso
                break;
        }
    }
}