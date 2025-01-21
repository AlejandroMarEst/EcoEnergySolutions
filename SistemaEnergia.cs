using System;

namespace EcoEnergySolutions
{
    public abstract class SistemaEnergia
    {
        protected string Type { get; set; }
        protected double Energy { get; set; }
        protected DateTime Date { get; set; }
        protected static int SimulationNumber { get; set; }

    }
}
