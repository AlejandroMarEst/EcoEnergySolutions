using System;

namespace EcoEnergySolutions
{
    public class SistemaEolic : SistemaEnergia, ICalculEnergia
    {
        public double WindVelocity {  get; set; }
        public SistemaEolic(double windVelocity)
        { 
            WindVelocity = windVelocity;
            Energy = CalculEnergia(WindVelocity);
        }
        public double CalculEnergia(double WindVelocity) => Math.Pow(WindVelocity, 3) * 0.2;
    }
}