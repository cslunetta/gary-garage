using System.Collections.Generic;

namespace gary_garage
{
  public interface IElectricVehicles
  {
    double BatteryKWh { get; set; }
    double CurrentChargePercentage { get; set; }
    void ChargeBattery();
  }
}