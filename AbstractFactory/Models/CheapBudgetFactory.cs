using AbstractFactory.Models.Interfaces;

namespace AbstractFactory.Models
{
    public class CheapBudgetFactory : IComputerFactory
    {
        public IHardDisk getHdd()
        {

            return new CheapHDD();
        }

        public IMonitor getMonitor()
        {
            return new CheapMonitor();
        }

        public IProcessor Getprocessor()
        {
            return new CheapProcessor();
        }
    }
}
