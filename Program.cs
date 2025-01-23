using System;
namespace EcoEnergySolutions
{
    public class Program
    {
        public static void Main()
        {
            const string WhatEnergy = "What type of energy do you wanna use?\n1) Solar, 2) HydroElectric or 3) Eolic";
            const string MaxSimulations = "How many simulations do you want to have as a maximum";
            const string LimitSimulation = "You have reached your stipulated maximum number of simulations";
            int menuOption, maxSimulations, energyType, energyFormQuantity;
            string simulationList = "|\tSimulation Number\t|\tType\t\t|\tEnergy Produced\t\t|\t\tDate\t\t|";
            bool exit = false;
            maxSimulations = 0;
            while (!exit)
            {
                MethodLibrary.ShowMenu();
                menuOption = MethodLibrary.GetNumberFromUser();
                MethodLibrary.MenuSelect(menuOption);
                switch (menuOption)
                {
                    case 1:
                        if (EnergySystem.SimulationNumber == 0) 
                        {
                            Console.WriteLine(MaxSimulations);
                            maxSimulations = MethodLibrary.GetNumberFromUser(); 
                        }
                        if (EnergySystem.SimulationNumber < maxSimulations)
                        {
                            Console.WriteLine(WhatEnergy);
                            energyType = MethodLibrary.GetNumberFromUser();
                            energyFormQuantity = MethodLibrary.GetEnergyQuantity(energyType);
                            simulationList += MethodLibrary.NewSimulation(energyType, energyFormQuantity);
                        }
                        else { Console.WriteLine(LimitSimulation); }
                        break;
                    case 2:
                        Console.WriteLine(simulationList);
                        break;
                    default:
                        exit = true;
                        break;
                }
            }
        }
    }
}
