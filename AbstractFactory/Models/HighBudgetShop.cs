using AbstractFactory.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Models
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
