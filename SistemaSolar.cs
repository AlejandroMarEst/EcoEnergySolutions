using System;

namespace EcoEnergySolutions
{
    public class SistemaSolar : SistemaEnergia, ICalculEnergia
    {
        public double SunHours { get; set; }
        public SistemaSolar(double sunHours)
        {
            if(CheckParameter(sunHours))
            {
                Type = "Sun energy";
                SunHours = sunHours;
                Energy = CalculEnergia(SunHours);
                Date = DateTime.Now;
                SimulationNumber++;
            }
        }
        public double CalculEnergia(double SunHours) => Math.Round(SunHours * 1.5);
        public bool CheckParameter(double SunHours) => SunHours >= 1;
        public void ShowSimulation()
        {
            Console.WriteLine($"|\tSimulation Number\t|\tType\t\t|\tEnergy Produced\t\t|\t\tDate\t\t|\n|\t\t{SimulationNumber}\t\t|\t{Type}\t|\t\t{Energy}\t\t|\t{Date}\t|");
        }
    }
}