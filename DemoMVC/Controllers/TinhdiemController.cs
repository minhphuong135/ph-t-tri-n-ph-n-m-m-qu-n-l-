using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using DemoMVC.Models;


namespace DemoMVC.Controllers;
public class  TinhdiemController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
    [HttpPost]
    public IActionResult Index(Tinhdiem ps)  
     { 
        string StrOutput = $"Diem"+ ps.DiemA +"-"+ps.DiemB +"-"+ps.DiemC +"-"+ps.FullName;
        ViewBag.Tinhdiem = StrOutput;
        return View(); 
     }


}