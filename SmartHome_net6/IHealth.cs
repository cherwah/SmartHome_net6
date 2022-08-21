using System;
namespace SmartHome_net6;

public interface IHealth
{
    public uint GetUsageCount();

    public string GetApplType();

    public string GetName();
}


