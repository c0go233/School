using School.Models;
using School.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace School.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            School.ViewModels.IndexViewModel indexViewModel = new School.ViewModels.IndexViewModel();
            indexViewModel.Classrooms = GetClassrooms();
            indexViewModel.Students = new List<Student>();

            return View(indexViewModel);
        }

        public List<Classroom> GetClassrooms()
        {
            List<Classroom> classrooms = new List<Classroom>();
            using (SchoolEntities se = new SchoolEntities())
            {
                classrooms = se.Classrooms.ToList();
            }
            return classrooms;
        }

    }
}