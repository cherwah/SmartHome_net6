using System;
namespace SmartHome_net6;

public interface IHealth
{
    public bool IsHealthy();

    public string GetName();
}


