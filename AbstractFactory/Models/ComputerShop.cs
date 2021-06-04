using AbstractFactory.Models.Interfaces;

namespace AbstractFactory.Models
{
    public class ComputerShop
    {

        private IComputerFactory _factory;

        public ComputerShop(IComputerFactory fact)
        {
            this._factory = fact;
        }

        public Computer AssembleComputer()
        {
            Computer computer = new Computer();

            computer.hardDisk = _factory.getHdd();
            computer.monitor = _factory.getMonitor();
            computer.processor = _factory.Getprocessor();

            return computer;

        }
    }
}
