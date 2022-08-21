using System.Collections.Generic;

namespace SmartHome_net6;

class HealthChecker 
{
  private Dictionary<string, uint> svcLimit;

  public HealthChecker(Dictionary<string, uint> svcLimit)
  {
    this.svcLimit = svcLimit;
  }

  public void CheckHealth(IHealth appliance) 
  {
    uint limit;
 
    if (svcLimit.TryGetValue(appliance.GetApplType(), out limit))
    {
      uint nUsed = appliance.GetUsageCount();

      if (nUsed > limit) {
        Console.WriteLine("{0} needs servicing after {1} uses.",
          appliance.GetName(), nUsed);
      }
      else {
        Console.WriteLine("{0} is healthy after {1} uses.",
          appliance.GetName(), nUsed);
      }
    }  
  }
}