using AbstractFactory.Models.Interfaces;

namespace AbstractFactory.Models
{
    public class CheapBudgetShop : ComputerShop
    {
        public override IHardDisk CreateHdd()
        {
            return new CheapHDD();
        }

        public override IMonitor CreateMonitor()
        {
            return new CheapMonitor();
        }

        public override IProcessor CreateProcessor()
        {
            return new CheapProcessor();
        }
    }
}
