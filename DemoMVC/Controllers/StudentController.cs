using DemoMVC.Models;
using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;
namespace DemoMVC.Controllers;
 public class StudentController : Controller
 {
    public IActionResult Index()
    {
        return View();
    }
    [HttpGet]
    public IActionResult Create()
    {
         Student std= new Student();
        std.Id="1";
        std.Fullname="Nguyen Van A";

       return View(); 
    }
    [HttpPost]
    public IActionResult Create(Student std)
    {
        ViewBag.Message="ID:" + std.Id +"Fullname:" + std.Fullname;
        return View();
    }

 }