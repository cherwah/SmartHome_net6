using System;
namespace SmartHome_net6
{
    public class SmartLamp : ISmartHome
    {
        private int nOnOff;
        private int service;

        public SmartLamp()
        {
        }

        public bool TurnOn()
        {
            return true;
        }

        public bool TurnOff()
        {
            return true;
        }

        public string GetHealthStatus()
        {
            return "";
        }

        public string GetServiceNumber()
        {
            return "";
        }
    }
}

