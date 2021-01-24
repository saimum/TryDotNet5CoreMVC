using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TryDotNet5CoreMVC.Models
{
    public class Vehicle
    {
        public int ID { get; set; }
        
        [System.ComponentModel.DisplayName("Registration Number")]
        public string RegistrationNumber { get; set; }

        [System.ComponentModel.DisplayName("Engine Number")]
        public string EngineNumber { get; set; }

        [System.ComponentModel.DisplayName("Chassis Number")]
        public string ChassisNumber { get; set; }
        public Int64 Price { get; set; }

    }
}
