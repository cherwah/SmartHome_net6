using System;
namespace SmartHome_net6;

public class SmartFridge : IHealth
{
    private bool isOpen;
    private uint svcLimit;
    private uint nUsed;
    private string name;

    public SmartFridge(string name)
    {
        nUsed = 0;
        isOpen = false;
        svcLimit = 20;
        this.name = name;
    }

    public bool IsOpen
    {
        get {
            return isOpen;
        }

        set {
            if (value) {
                if (! isOpen) {
                    nUsed++;
                    isOpen = true;
                }
            }
            else {
                isOpen = false;
            }
        }
    }

    public bool IsHealthy()
    {
        return (nUsed < svcLimit);
    }

    public string GetName()
    {
        return name;
    }
}

