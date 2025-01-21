using System;
namespace EcoEnergySolutions
{
    public class Program
    {
        public static void Main()
        {
            SistemaHidroelectric Solaris = new SistemaHidroelectric(20.30);
            Solaris.ShowSimulation();
        }
    }
}
