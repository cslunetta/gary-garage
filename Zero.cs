using System;

namespace gary_garage
{
  public class Zero : Vehicle, IElectricVehicles // Electric motorcycle
  {
    public double BatteryKWh { get; set; }
    public double CurrentChargePercentage { get; set; }

    public void ChargeBattery()
    {
      CurrentChargePercentage = 100;
    }

    public override void Drive()
    {
      Console.WriteLine($"The {MainColor} Zero zips by you. Yeeeeeoooooowwww");
    }
  }
}