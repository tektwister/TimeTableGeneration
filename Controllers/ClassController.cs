using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TimeTable.Models;
using TimeTable.DataAccess;

namespace TimeTable.Controllers
{
    public class ClassController : Controller
    {
        // GET: Class
        public ActionResult Index()
        {
            return View();
        }

        // GET: /Class/
        [HttpGet]
        public ActionResult InsertClass()
        {
            return View();
        }

        [HttpPost]
        public ActionResult InsertClass(Class c)
        {
            if (ModelState.IsValid) //checking model is valid or not
            {
                ClassDataAccess objDB = new ClassDataAccess();
                //Console.WriteLine(c.ClassId.ToString());
                ModelState.AddModelError("",c.ClassId.ToString());
                string result = objDB.insertClass(c);
                ViewData["result"] = result;
                //ModelState.Clear(); //clearing model
                return View();
            }
            else
            {
                ModelState.AddModelError("", "Error in saving data");
                return View();
        }

    }


}
}