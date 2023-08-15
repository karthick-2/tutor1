using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Data;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class TeacStuController : Controller
    {
        private Dbconnection db = new Dbconnection();
        // GET: TeacStu
        public ActionResult Index()
        {
            HOD hOD = new HOD();
            List<Student> student = new List<Student>();
            List<Teacher> teacher = new List<Teacher>();
            student=db.Students.ToList();
            teacher=db.Teachers.ToList();
            hOD.student = student;
            hOD.teacher = teacher;            
            return View(hOD);
        }
    }
}