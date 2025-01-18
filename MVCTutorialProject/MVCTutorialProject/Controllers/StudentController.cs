using DataLayer;
using MVCTutorialProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCTutorialProject.Controllers
{
    public class StudentController : Controller
    {
        StudentDBEntities db = new StudentDBEntities();
        
        // GET: Student
        public ActionResult Index()
        {
            return View("CustomTemplate");
        }

        [HttpGet]
        public ActionResult Register()
        {
            var Result = from S in db.Student 
                         where S.FirstName == "Kambiz"
                         select S;

            return View(Result);
        }

        //[HttpPost]
        //public ActionResult Register(Student student)
        //{
        //    return RedirectToAction("Register");
        //}
    }
}