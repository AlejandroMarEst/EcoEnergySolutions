using System;

namespace EcoEnergySolutions
{
    public interface ICalculEnergia
    {
        double CalculEnergia(double energyMethod);
        bool CheckParameter(double energyMethod);
        void ShowSimulation();
    }
}
