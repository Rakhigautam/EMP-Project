using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EMP_Project.Models;
namespace EMP_Project.Controllers
{
    public class StudentController : Controller
    {
        
       
        public IActionResult Index()
        {
          

            return View();
        }
    }
}
