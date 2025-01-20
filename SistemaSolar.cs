using System;

namespace EcoEnergySolutions
{
    public class SistemaSolar : SistemaEnergia, ICalculEnergia
    {
        public double SunHours { get; set; }
        public SistemaSolar(double sunHours)
        {
            SunHours = sunHours;
            Energy = CalculEnergia(SunHours);
        }
        public double CalculEnergia(double SunHours) => SunHours * 1.5;
    }
}