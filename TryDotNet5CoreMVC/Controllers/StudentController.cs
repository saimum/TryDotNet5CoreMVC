using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TryDotNet5CoreMVC.Models;

namespace TryDotNet5CoreMVC.Controllers
{
    public class StudentController : Controller
    {
        public static List<Student> StudentList = new List<Student>()
        {
            new Student() { ID = 1, Name = "Student 1", Age = 11 },
            new Student() { ID = 2, Name = "Student 2", Age = 12 },
            new Student() { ID = 3, Name = "Student 3" , Age = 13},
            new Student() { ID = 4, Name = "Student 4" , Age = 14},
            new Student() { ID = 5, Name = "Student 5" , Age = 15}
        };
        public IActionResult Index()
        {
            return View(StudentList);
        }
        public IActionResult Edit(int id)
        {
            var student = StudentList.Where(std => std.ID == id).FirstOrDefault();
            return View(student);
        }
        [HttpPost]
        public IActionResult Edit(Student model)
        {
            var student = StudentList.Where(std => std.ID == model.ID).FirstOrDefault();
            student.Name = model.Name;
            student.Age = model.Age;
            return RedirectToAction("Index");
        }

        public IActionResult Details(int id)
        {
            var student = StudentList.Where(std => std.ID == id).FirstOrDefault();
            return View(student);
        }

        public IActionResult Delete(int id)
        {
            var student = StudentList.Where(std => std.ID == id).FirstOrDefault();
            return View(student);
        }
        [HttpPost]
        public IActionResult Delete(Student model)
        {
            var student = StudentList.Where(std => std.ID == model.ID).FirstOrDefault();
            StudentList.Remove(student);
            return RedirectToAction("Index");
        }
    }
}
