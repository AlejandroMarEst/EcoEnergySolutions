using System;

namespace EcoEnergySolutions
{
    public class SistemaHidroelectric : SistemaEnergia, ICalculEnergia
    {
        public double WaterLevel { get; set; }
        public SistemaHidroelectric(double waterLevel)
        {
            WaterLevel = waterLevel;
            Energy = CalculEnergia(WaterLevel);
        }
        public double CalculEnergia(double WaterLevel) => WaterLevel * 9.8 * 0.8;
    }
}