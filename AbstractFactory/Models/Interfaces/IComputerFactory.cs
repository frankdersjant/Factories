namespace AbstractFactory.Models.Interfaces
{
    public interface IComputerFactory
    {
        IProcessor Getprocessor();
        IHardDisk getHdd();
        IMonitor getMonitor();
    }
}