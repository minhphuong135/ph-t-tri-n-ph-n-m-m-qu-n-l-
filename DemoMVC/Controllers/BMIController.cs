using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using DemoMVC.Models;
namespace DemoMVC.Controllers;  
public class BMIController : Controller
{
    [HttpGet]
   public IActionResult Index()
   {
    return View();

   }
   [HttpPost]
   public IActionResult Index(BMI model )
   {
    String StrOutput="-" +model.Weight + "-"+model.Height+"-"+model.Gioitinh ;
    ViewBag.BMI = StrOutput;
    return View(model);  
   }
}