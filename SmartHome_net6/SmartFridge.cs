using System;
namespace SmartHome_net6;

public class SmartFridge : SmartAppliance, IHealth
{
    private bool isOpen;

    public SmartFridge(string name) : base(name)
    {
        isOpen = false;
    }

    public bool Open() 
    {
        if (! isOpen) {
            isOpen = true;
            nUsed++;

            return true;
        }

        return false;
    }

    public bool Close() 
    {
        if (isOpen) {
            isOpen = false;

            return true;
        }

        return false;
    }


    public uint GetUsageCount()
    {
        return nUsed;
    }

    public string GetApplType()
    {
        return "Fridge";
    }

    public string GetName()
    {
        return name;
    }
}

