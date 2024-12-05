using System.ComponentModel.DataAnnotations;

namespace WasteManagementSystem.Models
{
    public class Vehicle
    {
        [Key]
        public int VehicleID { get; set; }
        public int DriverID { get; set; }
        public string Route { get; set; }
    }
}
