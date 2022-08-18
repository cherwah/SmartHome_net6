using System;
namespace SmartHome_net6;
public class SmartLamp : ISmartHome
{
    private bool isOn;
    private uint svcLimit;
    private uint nUsed;
    private string name;

    public SmartLamp(string name) 
    {
        nUsed = 0;
        svcLimit = 10;
        isOn = false;
        this.name = name;
    }

    public bool IsOn
    {
        get {
            return isOn;
        }   

        set {    
            if (value) {
                if (! isOn) {
                    nUsed++;
                    isOn = true;
                } 
            } 
            else {
                isOn = false;
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


