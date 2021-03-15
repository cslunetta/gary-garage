using System;
using System.Collections.Generic;

namespace gary_garage
{
  class Program
  {
    static void Main(string[] args)
    {
      Zero fxs = new Zero();
      Zero fx = new Zero();
      Tesla modelS = new Tesla();

      List<IElectricVehicles> electricVehicles = new List<IElectricVehicles>() {
        fx, fxs, modelS
            };

      Console.WriteLine("Electric Vehicles");
      foreach (IElectricVehicles ev in electricVehicles)
      {
        Console.WriteLine($"{ev.CurrentChargePercentage}%");
      }

      foreach (IElectricVehicles ev in electricVehicles)
      {
        // This should charge the vehicle to 100%
        ev.ChargeBattery();
      }

      foreach (IElectricVehicles ev in electricVehicles)
      {
        Console.WriteLine($"{ev.CurrentChargePercentage}%");
      }

      /***********************************************/

      Ram ram = new Ram();
      Cessna cessna150 = new Cessna();

      List<IGasVehicles> gasVehicles = new List<IGasVehicles>() {
        ram, cessna150
            };

      Console.WriteLine("Gas Vehicles");
      foreach (IGasVehicles gv in gasVehicles)
      {
        Console.WriteLine($"{gv.CurrentTankPercentage}%");
      }

      foreach (IGasVehicles gv in gasVehicles)
      {
        // This should completely refuel the gas tank
        gv.RefuelTank();
      }

      foreach (IGasVehicles gv in gasVehicles)
      {
        Console.WriteLine($"{gv.CurrentTankPercentage}%");
      }
    }
  }
}


// using System;
// using System.Collections.Generic;

// namespace gary_garage
// {
//   class Program
//   {
//     static void Main(string[] args)
//     {
//       Zero fxs = new Zero()
//       {
//         MainColor = "Midnight Blue"
//       };
//       Zero fxs2 = new Zero()
//       {
//         MainColor = "Black"
//       };
//       Tesla modelS = new Tesla()
//       {
//         MainColor = "Burgundy"
//       };
//       Cessna mx410 = new Cessna()
//       {
//         MainColor = "White"
//       };
//       Ram trx1500 = new Ram()
//       {
//         MainColor = "Silver"
//       };

//       fxs.Drive();
//       fxs.Turn("right");
//       fxs.Stop();
//       Console.WriteLine("");

//       fxs2.Drive();
//       fxs2.Turn("right");
//       fxs2.Stop();
//       Console.WriteLine("");

//       modelS.Drive();
//       modelS.Turn("right");
//       modelS.Stop();
//       Console.WriteLine("");

//       trx1500.Drive();
//       trx1500.Turn("right");
//       trx1500.Stop();
//       Console.WriteLine("");

//       mx410.Drive();
//       mx410.Turn("right");
//       mx410.Stop();
//       Console.WriteLine("");
//     }
//   }
// }