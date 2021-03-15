namespace gary_garage
{
  public interface IGasVehicles
  {
    double FuelCapacity { get; set; }
    double CurrentTankPercentage { get; set; }
    void RefuelTank();
  }
}