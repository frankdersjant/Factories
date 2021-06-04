using AbstractFactory.Models;
using AbstractFactory.Models.Interfaces;
using System;

namespace AbstractFactory
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
            IComputerFactory factory = new HighBudgetFactory();
            ComputerShop computerShop = new ComputerShop(factory);
            Computer computer = computerShop.AssembleComputer();
            computer.Test();

            IComputerFactory factory2 = new CheapBudgetFactory();
            ComputerShop computerShop2 = new ComputerShop(factory2);
            Computer computer2 = computerShop.AssembleComputer();
            computer.Test();

        }
    }
}
