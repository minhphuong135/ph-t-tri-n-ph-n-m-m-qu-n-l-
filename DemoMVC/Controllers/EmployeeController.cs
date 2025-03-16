using Microsoft.AspNetCore.Mvc;
using DemoMVC.Models;
using System.Collections.Generic;
using System.Linq;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace YourNamespace.Controllers
{
    public class EmployeeController : Controller
    {
        // Danh sách nhân viên giả lập
        private static List<Employee> employees = new List<Employee>
        {
             //new Employee { PersonId = "P001", FullName = "Nguyen Van A", Address = "Ha Noi", EmployeeID = "E001", Age = 30 },
            //new Employee { PersonId = "P002", FullName = "Tran Thi B", Address = "Ho Chi Minh", EmployeeID = "E002", Age = 25 }
             
        };

        // Hiển thị danh sách nhân viên
        public IActionResult Index()
        {
            return View(employees);
        }

        // Hiển thị form thêm nhân viên
        public IActionResult Create()
        {
            return View();
        }

        // Xử lý thêm nhân viên
        [HttpPost]
        public IActionResult Create(Employee employee)
        {
            if (ModelState.IsValid)
            {
                employees.Add(employee);
                return RedirectToAction("Index");
            }
            return View(employee);
        }

        // Hiển thị form sửa nhân viên
        public IActionResult Edit(string id)
        {
            var employee = employees.FirstOrDefault(e => e.EmployeeID == id);
            if (employee == null)
            {
                return NotFound();
            }
            return View(employee);
        }

        // Xử lý sửa nhân viên
        [HttpPost]
        public IActionResult Edit(Employee updatedEmployee)
        {
            var employee = employees.FirstOrDefault(e => e.EmployeeID == updatedEmployee.EmployeeID);
            if (employee != null)
            {
                employee.PersonId = updatedEmployee.PersonId;
                employee.FullName = updatedEmployee.FullName;
                employee.Address = updatedEmployee.Address;
                employee.Age = updatedEmployee.Age;
            }
            return RedirectToAction("Index");
        }

        // Xóa nhân viên
        public IActionResult Delete(string id)
        {
            var employee = employees.FirstOrDefault(e => e.EmployeeID    == id);
            if (employee != null)
            {
                employees.Remove(employee);
            }
            return RedirectToAction("Index");
        }
    }
}
