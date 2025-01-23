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
        /// <summary>
        /// Shows the UI of the program
        /// </summary>
        public static void ShowMenu()
        {
            const string Logo = "\n\n::::::::::  ::::::::   ::::::::  :::::::::: ::::    ::: :::::::::: :::::::::   ::::::::  :::   :::    \r\n:+:        :+:    :+: :+:    :+: :+:        :+:+:   :+: :+:        :+:    :+: :+:    :+: :+:   :+:    \r\n+:+        +:+        +:+    +:+ +:+        :+:+:+  +:+ +:+        +:+    +:+ +:+         +:+ +:+     \r\n+#++:++#   +#+        +#+    +:+ +#++:++#   +#+ +:+ +#+ +#++:++#   +#++:++#:  :#:          +#++:      \r\n+#+        +#+        +#+    +#+ +#+        +#+  +#+#+# +#+        +#+    +#+ +#+   +#+#    +#+       \r\n#+#        #+#    #+# #+#    #+# #+#        #+#   #+#+# #+#        #+#    #+# #+#    #+#    #+#       \r\n##########  ########   ########  ########## ###    #### ########## ###    ###  ########     ###       \r\n";
            const string Menu = "\t\t\tWhere do you want to go?\n\t\t\t> 1) Create simulation\n\t\t\t> 2) Show simulation list\n\t\t\t> 3) Exit";
            Console.WriteLine(Logo);
            Console.WriteLine(Menu);
        }
        /// <summary>
        /// Takes an input and writes a message according to the menu you choose
        /// </summary>
        /// <param name="selection"> Number that decides what message you get </param>
        public static void MenuSelect(int selection)
        {
            
            const string UserSelected = "You selected ";
            const string Simulation = "to create a simulation";
            const string List = "to show the simulation list";
            const string Exit = "to exit";
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
        /// <summary>
        /// Gets a number from the user to garantee it's a number
        /// </summary>
        /// <returns> Input from user </returns>
        public static int GetNumberFromUser()
        {
            // Processes an input in numeric format
            const string ErrorMsg = "Error: Introdueix un nombre vàlid.";
            bool isValidInput = false;
            int number;
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
        /// <summary>
        ///  Gets the amount of the parameter needed to build the objects, the paramater changes depending on the type of energy you choose
        /// </summary>
        /// <param name="energyType"> A number inputted by the user that determines the type of energy used </param>
        /// <returns> The quantitity of each energy type </returns>
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
        /// <summary>
        /// Creates a new simulation (object) using an amount of energy input and the energy tyoe
        /// </summary>
        /// <param name="energyType"> Type of energy used in number form (1 - solar, 2 - hydro, 3 - eolic)</param>
        /// <param name="energyQuantity"> Amount of energy input</param>
        /// <returns> String to get a list of simulations </returns>
        public static string NewSimulation(int energyType, int energyQuantity) 
        {
            const string Invalid = "Energy Type";
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
            }       
        }
    }
}
