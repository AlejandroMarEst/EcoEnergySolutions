using System;

namespace EcoEnergySolutions
{
    public class SistemaEolic : SistemaEnergia, ICalculEnergia
    {
        public double WindVelocity {  get; set; }
        public SistemaEolic(double windVelocity)
        {
            if (CheckParameter(windVelocity))
            {
                Type = "Wind energy";
                WindVelocity = windVelocity;
                Energy = CalculEnergia(WindVelocity);
                Date = DateTime.Now;
                SimulationNumber++;
            }
        }
        public double CalculEnergia(double WindVelocity) => Math.Round(Math.Pow(WindVelocity, 3) * 0.2, 2);
        public bool CheckParameter(double WindVelocity) => WindVelocity >= 20;
        public void ShowSimulation()
        {
            Console.WriteLine($"|\tSimulation Number\t|\tType\t\t|\tEnergy Produced\t\t|\t\tDate\t\t|\n|\t\t{SimulationNumber}\t\t|\t{Type}\t|\t\t{Energy}\t\t|\t{Date}\t|");
        }
    }
}