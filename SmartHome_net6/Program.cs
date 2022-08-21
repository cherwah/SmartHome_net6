using SmartHome_net6;

// create lamps
SmartLamp[] lamps = new SmartLamp[] { 
  new SmartLamp("living_room_lamp"),
  new SmartLamp("master_room_lamp"),
  new SmartLamp("study_room_lamp") 
};

// use lamps
foreach (SmartLamp lamp in lamps)
{
  for (int i=0; i<15; i++) 
  {
    // simulate use by turning ON and OFF
    lamp.TurnOn();
    lamp.TurnOff();
  }
}

// create fridge
SmartFridge fridge = new SmartFridge("fridge");

// use fridge
for (int i=0; i<15; i++)
{
  fridge.Open();
  fridge.Close();
}

// check the health of appliances
HealthChecker checker = new HealthChecker();

foreach (SmartLamp lamp in lamps) 
{
  checker.CheckHealth(lamp);
}
checker.CheckHealth(fridge);



