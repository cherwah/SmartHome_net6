namespace SmartHome_net6;

class HealthChecker 
{
  public void CheckHealth(ISmartHome appliance) 
  {
    if (! appliance.IsHealthy()) 
    {
      Console.WriteLine(appliance.GetName() + " needs servicing");
    }
  }
}