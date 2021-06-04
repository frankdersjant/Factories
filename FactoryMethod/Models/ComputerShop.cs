using FactoryMethod.Models.Interfaces;

namespace FactoryMethod.Models
{
    public abstract class ComputerShop
    {

        public Computer AssembleComputer()
        {
            Computer computer = new Computer();

            computer.processor = CreateProcessor();
            computer.hardDisk = CreateHdd(); 
            computer.monitor = CreateMonitor();
            return computer;
        }

        public abstract IProcessor CreateProcessor();
        public abstract IHardDisk CreateHdd();
        public abstract IMonitor CreateMonitor();
    }
}
