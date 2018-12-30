using MVVMFramework.Model;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace MVVMFramework.DataAccess
{
    internal sealed class DatabaseLayer
    {
        internal static ObservableCollection<Vehicle> GetVehiclesFromDatabase()
        {
            return new ObservableCollection<Vehicle>
            {
                new Vehicle("Audi", "A5", 140),
                new Vehicle("BMW", "M 240i", 294),
                new Vehicle("Mercedes", "C 350e", 155)
            };
        }

        internal static List<PocoVehicle> GetPocoVehiclesFromDatabase()
        {
            return new List<PocoVehicle>
            {
                new PocoVehicle("Audi", "A5", 140),
                new PocoVehicle("BMW", "M 240i", 294),
                new PocoVehicle("Mercedes", "C 350e", 155)
            };
        }
    }
}
