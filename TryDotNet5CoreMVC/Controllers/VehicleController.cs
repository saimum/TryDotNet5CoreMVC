using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TryDotNet5CoreMVC.Models;

namespace TryDotNet5CoreMVC.Controllers
{
    public class VehicleController : Controller
    {
        public static List<Vehicle> VehicleList = new List<Vehicle>()
        {
            new Vehicle() { ID = 1, RegistrationNumber = "DHAK METRO-U-66-0001", EngineNumber = "EN0001", ChassisNumber= "CSS0001", Price = 610000 },
            new Vehicle() { ID = 2, RegistrationNumber = "DHAK METRO-U-66-0002", EngineNumber = "EN0002", ChassisNumber= "CSS0002", Price = 620000 },
            new Vehicle() { ID = 3, RegistrationNumber = "DHAK METRO-U-66-0003", EngineNumber = "EN0003", ChassisNumber= "CSS0003", Price = 630000 },
            new Vehicle() { ID = 4, RegistrationNumber = "DHAK METRO-U-66-0004", EngineNumber = "EN0004", ChassisNumber= "CSS0004", Price = 640000 },
            new Vehicle() { ID = 5, RegistrationNumber = "DHAK METRO-U-66-0005", EngineNumber = "EN0005", ChassisNumber= "CSS0005", Price = 650000 },
        };
        public IActionResult Index()
        {
            return View(VehicleList);
        }
        public IActionResult Edit(int id)
        {
            var vehicle = VehicleList.Where(v => v.ID == id).FirstOrDefault();
            return View(vehicle);
        }
        [HttpPost]
        public IActionResult Edit(Vehicle model)
        {
            var vehicle = VehicleList.Where(v => v.ID == model.ID).FirstOrDefault();
            vehicle.RegistrationNumber = model.RegistrationNumber;
            vehicle.Price = model.Price;
            return RedirectToAction("Index");
        }

        public IActionResult Details(int id)
        {
            var vehicle = VehicleList.Where(v => v.ID == id).FirstOrDefault();
            return View(vehicle);
        }

        public IActionResult Delete(int id)
        {
            var vehicle = VehicleList.Where(v => v.ID == id).FirstOrDefault();
            return View(vehicle);
        }
        [HttpPost]
        public IActionResult Delete(Vehicle model)
        {
            var vehicle = VehicleList.Where(v => v.ID == model.ID).FirstOrDefault();
            VehicleList.Remove(vehicle);
            return RedirectToAction("Index");
        }
    }
}
