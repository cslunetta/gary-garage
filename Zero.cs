using System;

namespace gary_garage
{
  public class Zero : Vehicle // Electric motorcycle
  {
    public double BatteryKWh { get; set; }

    public void ChargeBattery()
    {
      // method definition omitted
    }

    public override void Drive()
    {
      Console.WriteLine($"The {MainColor} Zero zips by you. Yeeeeeoooooowwww");
    }
  }
}