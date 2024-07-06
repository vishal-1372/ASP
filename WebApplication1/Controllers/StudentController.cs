using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication4.Models;

namespace WebApplication4.Controllers
{
    public class StudentController : Controller
    {
        // GET: Student
        public ActionResult Index()
        {
            List<Student> list = new List<Student>() {
        new Student() {
                    Id = 1,
                    Name = "Vishal",
                    Desc = "Rajkot",

            },
            new Student() {
                    Id = 2,
                    Name = "Milan",
                    Desc = "morbi",

            },
            new Student() {
                    Id = 3,
                    Name = "Khan",
                    Desc = "surat",

            },

            new Student() {
                    Id = 4,
                    Name = "krushal",
                    Desc = "morbi",

            },
    };
            ViewBag.model = list;
            return View();
        }
        public ActionResult About()
        {
            ViewData["Country"] = new List<String>() { "India", "Pakistan","Uk","Us","Rus" };


            

            return View();
        }
        public ActionResult Contact()
        {
            return View();
        }

    }
}