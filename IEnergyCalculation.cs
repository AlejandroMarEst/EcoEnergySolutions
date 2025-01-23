using System;

namespace EcoEnergySolutions
{
    public interface IEnergyCalculation
    {
        double EnergyCalculation();
        bool CheckParameter(double energyMethod);
        string ShowSimulation();
    }
}
