using System;

namespace EcoEnergySolutions
{
    public class SistemaHidroelectric : SistemaEnergia, ICalculEnergia
    {
        public double WaterLevel { get; set; }
        public SistemaHidroelectric(double waterLevel)
        {
            if (CheckParameter(waterLevel))
            {
                Type = "Hydroelectric energy";
                WaterLevel = waterLevel;
                Energy = CalculEnergia(WaterLevel);
                Date = DateTime.Now;
                SimulationNumber++;
            }
        }
        public double CalculEnergia(double WaterLevel) => Math.Round(WaterLevel * 9.8 * 0.8, 2);
        public bool CheckParameter(double WaterLevel) => WaterLevel >= 5;
        public void ShowSimulation()
        {
            Console.WriteLine($"|\tSimulation Number\t|\t\tType\t\t|\tEnergy Produced\t|\t\tDate\t\t\t\t|\n|\t\t{SimulationNumber}\t\t|\t{Type}\t|\t\t{Energy}\t|\t{Date}\t|");
        }

    }
}