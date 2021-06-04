using AbstractFactory.Models.Interfaces;
using System;

namespace AbstractFactory.Models
{
    public class HighBudgetFactory : IComputerFactory
    {
        public IHardDisk getHdd()
        {
            return new ExpensiveHDD();
        }

        public IMonitor getMonitor()
        {
            return new ExpensiveMonitor();
        }

        public IProcessor Getprocessor()
        {
            return new ExpensiveProcessor();
        }
    }
}
