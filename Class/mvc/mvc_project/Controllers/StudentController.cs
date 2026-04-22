//controller means logical layer it is brain of MVC handles user request and response.
//connects model and view
using System.Runtime.InteropServices;
using Microsoft.AspNetCore.Mvc;
using studentmvc.Models;

namespace studentmvc.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Index()
        {
            List<Student> students = new List<Student>()
            {
                new Student(){id=1,name="sai", Course="MCA", Email="sai@gmail.com"},
                new Student(){id=2,name="siva", Course="MSc", Email="siva@gmail.com"},
                new Student(){id=3,name="kumar", Course="BA", Email="kumar@gmail.com"},
            };
            return View(students);
        }
    }
}
