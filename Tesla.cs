using System;

namespace gary_garage
{
  public class Tesla : Vehicle, IElectricVehicles
  {
    public double BatteryKWh { get; set; }
    public double CurrentChargePercentage { get; set; }

    public void ChargeBattery()
    {
      CurrentChargePercentage = 100;
    }


    public override void Drive()
    {
      Console.WriteLine($"The {MainColor} Tesla blazes by you. MMmmmmmm!");
    }
    public override void Turn(string direction)
    {
      Console.WriteLine($"The {MainColor} Tesla squeals around a {direction} turn.");
    }
    public override void Stop()
    {
      Console.WriteLine($"The {MainColor} Tesla silently stops as if it never moved.");
    }
  }
}