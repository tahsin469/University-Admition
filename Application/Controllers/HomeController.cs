using Application.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Application.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            StudentDbContext db = new StudentDbContext();
            List<Student> obj = db.GetEmployees();
            return View(obj);
        }

        //GET : CreateForm
        public ActionResult Create()
        {
            //Student stu = new Student();
            return View();
        }

        //POST : Create/Submit
        [HttpPost]

        public ActionResult Create(Student stu)
        {
            try
            {
                if (ModelState.IsValid == true)
                {
                    StudentDbContext context = new StudentDbContext();
                    bool check = context.AddStudent(stu);
                    if (check == true)
                    {
                        TempData["InsertMassage"] = "Data has been Inserted Succesfully.";
                        ModelState.Clear();
                        return RedirectToAction("Index");
                    }
                }
                return View();
            }
            catch
            {
                return View();
            }
        }

        //GET : Update
        public ActionResult Edit(int id)
        {
            StudentDbContext context = new StudentDbContext();
            var row = context.GetEmployees().Find(model => model.id == id);
            return View(row);
        }

        //Update Save
        [HttpPost]
        public ActionResult Edit(Student stu)
        {
            if (ModelState.IsValid == true)
            {
                StudentDbContext context = new StudentDbContext();
                bool check = context.UpdateStudent(stu);
                if (check == true)
                {
                    TempData["UpdateMassage"] = "Data has been Updated Succesfully.";
                    ModelState.Clear();
                    return RedirectToAction("Index");
                }
            }
            return View();
        }


        //GET : Confarm Delete ?
        [HttpGet]
        public ActionResult Delete(int id)
        {
            StudentDbContext context = new StudentDbContext();
            var row = context.GetEmployees().Find(model => model.id == id);
            return View(row);
        }

        //post : Delete
        [HttpPost]
        public ActionResult Delete(int id, Student stu)
        {
            StudentDbContext context = new StudentDbContext();
            bool check = context.DeleteStudent(id); 
            if (check == true)
            {
                TempData["DeleteMassage"] = "Data has been Deleted Succesfully.";
                ModelState.Clear();
                return RedirectToAction("Index");
            }
            return View();
        }

        //GET : Details
        public ActionResult Details(int id)
        {
            StudentDbContext context = new StudentDbContext();
            var row = context.GetEmployees().Find(model => model.id == id);
            return View(row);
        }

    }
}