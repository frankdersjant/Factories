using FactoryMethod.Models;
using FactoryMethod.Models.Interfaces;
using System;

namespace FactoryMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            Program myProgram = new Program();
            myProgram.Start();
        }

        void Start()
        {
            Console.WriteLine("[shop creating expensive computers]");
            // ... create shop
            ComputerShop HighEndComputerShop = new HighBudgetShop();
            // ... assemble (one) machine
            Computer highEndCompter = HighEndComputerShop.AssembleComputer();
        }
    }
}
