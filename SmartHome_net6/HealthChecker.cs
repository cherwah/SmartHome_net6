namespace SmartHome_net6;

class HealthChecker 
{
  public void CheckHealth(IHealth appliance) 
  {
    // string type = appliance.GetType();
    
    // switch (type)
    // {
    //   case "Lamp":
    //     break;

    //   case "Fridge":
    //     break;
    // }

    if (appliance.GetType() == "Lamp") 
    {
      Console.WriteLine(appliance.GetName() + " needs servicing");
    }
  }
}