using AbstractFactory.Models.Interfaces;

namespace AbstractFactory.Models
{
    public class Computer
    {
        public IProcessor processor { get; set; }
        public IHardDisk hardDisk { get; set; }
        public IMonitor monitor { get; set; }

        public void  Test()
        {

        }
    }
}
