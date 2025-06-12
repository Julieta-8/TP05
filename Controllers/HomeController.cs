using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Sala_Escape_05.Models;

namespace Sala_Escape_05.Controllers;

public class HomeController : Controller
{

    public IActionResult Index()
    {
        return View("Index");
    }
    public IActionResult Juego()
    {
        return View("juego");
    }
     public IActionResult Tutorial()
    {
        return View("Tutorial");
    }
        public IActionResult juego()
    {
        return View("juego");
    }
    public IActionResult Sala1(string clave)
    {   
        if (clave.Length != 0)
        {
            if(juego.Verificar(clave) == true)
            {
                return View("Sala2");
            } else
            {
                return View("Sala1");
            } 
        }
        return View("Sala1");
    }
         public IActionResult Sala2(string clave)
    { 
            if (clave.Length != 0)
    {  
          if(juego.Verificar(clave) == true){
 return View("Sala3");
    } else{
     return View("Sala2");
    } 
    }
}
}
