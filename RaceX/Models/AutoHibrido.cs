using RaceXSimulator.Models;
using System;

public class AutoHibrido : Auto
{
    public AutoHibrido(string nombre) : base(nombre)
    {
        Tipo = "Híbrido";
    }

    public override void Avanzar(Clima clima)
    {
        int avanceBase = new Random().Next(5, 16);
        int penalizacion = (clima == Clima.Ventoso) ? -1 : 0;
        DistanciaRecorrida += avanceBase + penalizacion;
    }
}
