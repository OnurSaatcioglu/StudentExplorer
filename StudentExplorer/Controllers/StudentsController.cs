using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using StudentExplorer.Models;

namespace StudentExplorer.Controllers
{
    public class StudentsController : Controller
    {
        StudentExplorerContext studentExplorerContext;
        
        public StudentsController(StudentExplorerContext context)
        {
            studentExplorerContext = context;
        }

        public IActionResult Index()
        {
            var students = studentExplorerContext.Students.ToList();
            return View(students);
        }

        public IActionResult Detay(int id)
        {
            Student student = studentExplorerContext.Students.Where(b => b.Id == id).FirstOrDefault();
            if (student != null)
            {
                return View(student);
            }
            else
            {
                return NotFound();
            }
        }
    }
}
