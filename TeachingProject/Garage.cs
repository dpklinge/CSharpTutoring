using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeachingProject
{
    public class Garage
    {
        public List<Vehicle> vehicles = new List<Vehicle>();

        public void StoreVehicle(Vehicle vehicle)
        {
            vehicles.Add(vehicle);
        }
    }
}
