﻿using System;
namespace SmartHome_net6
{
    public class SmartFridge : ISmartHome
    {
        public SmartFridge()
        {
        }

        public bool Open()
        {
            return true;
        }

        public bool Close()
        {
            return true;
        }

        public string GetStatus()
        {
            return "";
        }

        public string GetServiceNumber()
        {
            return "";
        }
    }
}
