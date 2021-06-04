using FactoryMethod.Models;
using FactoryMethod.Models.Interfaces;

namespace FactoryMethod.Models
{
    public class HighBudgetShop : ComputerShop
    {
        public override IHardDisk CreateHdd()
        {
            return new ExpensiveHDD();
        }

        public override IMonitor CreateMonitor()
        {
            return new ExpensiveMonitor();
        }

        public override IProcessor CreateProcessor()
        {
            return new ExpensiveProcessor(); 
        }
    }
}
