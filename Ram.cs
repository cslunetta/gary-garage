using System;

namespace gary_garage
{
  public class Ram : Vehicle, IGasVehicles // Gas powered truck
  {
    public double FuelCapacity { get; set; }
    public double CurrentTankPercentage { get; set; }

    public void RefuelTank()
    {
      CurrentTankPercentage = 100;
    }
    
    public override void Drive()
    {
      Console.WriteLine($"The {MainColor} Ram growls by you. Rrrrrruuummmmbbbble!");
    }
  }
}