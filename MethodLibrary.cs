using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace EcoEnergySolutions
{
    public class MethodLibrary
    {
        public static void ShowMenu()
        {
            const string Logo = "\n\n::::::::::  ::::::::   ::::::::  :::::::::: ::::    ::: :::::::::: :::::::::   ::::::::  :::   :::    \r\n:+:        :+:    :+: :+:    :+: :+:        :+:+:   :+: :+:        :+:    :+: :+:    :+: :+:   :+:    \r\n+:+        +:+        +:+    +:+ +:+        :+:+:+  +:+ +:+        +:+    +:+ +:+         +:+ +:+     \r\n+#++:++#   +#+        +#+    +:+ +#++:++#   +#+ +:+ +#+ +#++:++#   +#++:++#:  :#:          +#++:      \r\n+#+        +#+        +#+    +#+ +#+        +#+  +#+#+# +#+        +#+    +#+ +#+   +#+#    +#+       \r\n#+#        #+#    #+# #+#    #+# #+#        #+#   #+#+# #+#        #+#    #+# #+#    #+#    #+#       \r\n##########  ########   ########  ########## ###    #### ########## ###    ###  ########     ###       \r\n";
            const string Menu = "\t\t\tWhere do you want to go?\n\t\t\t> 1) Create simulation\n\t\t\t> 2) Show simulation list\n\t\t\t> 3) Exit";
            Console.WriteLine(Logo);
            Console.WriteLine(Menu);
        }
        public static void MenuSelect(int selection)
        {
            const string UserSelected = "You selected ";
            const string Simulation = "to create a simulation";
            const string List = "to show the simulation list";
            const string Exit = "to exit";
            const string Secret = "a secret option!";
            const string Invalid = "an invalid option";
            switch (selection)
            {
                case 1:
                    Console.WriteLine(UserSelected + Simulation);
                    break;
                case 2:
                    Console.WriteLine(UserSelected + List);
                    break;
                case 3:
                    Console.WriteLine(UserSelected + Exit);
                    break;
                default:
                    Console.WriteLine(UserSelected + Invalid);
                    break;
            }
        }
        public static int GetNumberFromUser()
        {
            const string ErrorMsg = "Error: Introdueix un nombre vàlid.";
            bool isValidInput = false;
            int number = 0;
            do
            {
                string? input = Console.ReadLine();
                if (int.TryParse(input, out number))
                {
                    isValidInput = true;
                }
                else
                {
                    Console.WriteLine(ErrorMsg);
                }
            } while (!isValidInput);
            return number;
        }
        public static int GetEnergyQuantity(int energyType)
        {
            const string solarEnergyQuantity = "How many sun hours?";
            const string hydroEnergyQuantity = "How much is the water level?";
            const string eolicEnergyQuantity = "How fast is the wind=";
            switch (energyType)
            {
                case 1:
                    Console.WriteLine(solarEnergyQuantity);
                    return GetNumberFromUser();
                case 2:
                    Console.WriteLine(hydroEnergyQuantity);
                    return GetNumberFromUser();
                case 3:
                    Console.WriteLine(eolicEnergyQuantity);
                    return GetNumberFromUser();
                default:
                    return -1;
            }
        }
        public static string NewSimulation(ref string simulationList, int energyType, int energyQuantity) 
        {
            const string Invalid = "Energy Type";
            bool Repeat = false;
            switch(energyType)
            {
                case 1:
                    SolarSystem solarSystem = new SolarSystem(energyQuantity);
                    return solarSystem.ShowSimulation();
                case 2:
                    HydroElectricSystem hydroElectricSystem = new HydroElectricSystem(energyQuantity);
                    return hydroElectricSystem.ShowSimulation();
                case 3:
                    EolicSystem eolicSystem = new EolicSystem(energyQuantity);
                    return eolicSystem.ShowSimulation();
                default:
                    Console.WriteLine(Invalid);
                    return "";
                    break;
            }       
        }
        public static void ShowSimulationList()
        {
            for (int i = 0; i < EnergySystem.SimulationNumber; i++)
            {
                const string Table = "|\tSimulation Number\t|\tType\t\t|\tEnergy Produced\t\t|\t\tDate\t\t|";
                const string Template = "|\t\t{0}\t\t |\t{1}\t |\t\t{2}\t\t |\t{3}\t |";
                Console.WriteLine(Table);
                Console.WriteLine(Template,EnergySystem.SimulationNumber);
            }
        }
    }
}
