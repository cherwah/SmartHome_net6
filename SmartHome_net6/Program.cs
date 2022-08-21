using System.Collections.Generic;
using SmartHome_net6;

Random rand = new Random();

// create lamps
SmartLamp[] lamps = new SmartLamp[] {
  new SmartLamp("living_room_lamp"),
  new SmartLamp("master_room_lamp"),
  new SmartLamp("study_room_lamp")
};

// use lamps
foreach (SmartLamp lamp in lamps)
{
  for (int i = 0; i < rand.Next(14, 21); i++)
  {
    // simulate use by turning ON and OFF
    lamp.TurnOn();
    lamp.TurnOff();
  }
}

// create fridge
SmartFridge fridge = new SmartFridge("fridge");

// use fridge
for (int i = 0; i < rand.Next(18, 25); i++)
{
  fridge.Open();
  fridge.Close();
}

// check the health of appliances

Dictionary<string, uint> dict = new Dictionary<string, uint>() {
  { "Lamp", 15 },
  { "Fridge", 20 }
};

HealthChecker checker = new HealthChecker(dict);

foreach (SmartLamp lamp in lamps)
{
  checker.CheckHealth(lamp);
}
checker.CheckHealth(fridge);



