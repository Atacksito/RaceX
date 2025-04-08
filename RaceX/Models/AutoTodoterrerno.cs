using RaceXSimulator.Models;
using System;

public class AutoTodoterreno : Auto
{
    public AutoTodoterreno(string nombre) : base(nombre)
    {
        Tipo = "Todoterreno";
    }

    public override void Avanzar(Clima clima)
    {
        int avanceBase = new Random().Next(5, 16);
        int bonificacion = (clima == Clima.Lluvia) ? 2 : 0;
        DistanciaRecorrida += avanceBase + bonificacion;
    }
}