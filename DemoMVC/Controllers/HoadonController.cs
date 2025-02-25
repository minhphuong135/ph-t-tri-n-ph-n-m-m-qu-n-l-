using Microsoft.AspNetCore.Mvc;
using DemoMVC.Models;
using System.Reflection.Metadata.Ecma335;
namespace DemoMVC.Controllers;
public class HoadonController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
    [HttpPost]
    public IActionResult Index (Hoadon HD) 
    {
        ViewBag.Message = $"hoa don cua ban{HD.FullName} co tong la{HD.soluong*HD.dongia}";
        return View();
    }
}