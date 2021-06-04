using FactoryMethod.Models.Interfaces;

namespace FactoryMethod.Models.Interfaces
{
    public class Computer
    {
        public IProcessor processor { get; set; }
        public IHardDisk hardDisk { get; set; }
        public IMonitor monitor { get; set; }
    }
}
