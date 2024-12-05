using System;
using System.ComponentModel.DataAnnotations;

namespace WasteManagementSystem.Models
{
    public class WasteRequest
    {
        [Key]
        public int RequestID { get; set; }
        public int UserID { get; set; }
        public string WasteType { get; set; }
        public string Location { get; set; }
        public string Status { get; set; }
        public DateTime RequestDate { get; set; }
    }
}
