using System;
namespace SmartHome_net6
{
    public interface ISmartHome
    {
        public string GetHealthStatus();

        public string GetServiceNumber();
    }
}

