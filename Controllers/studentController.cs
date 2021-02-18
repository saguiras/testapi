using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using TestApplication.Models;

namespace TestApplication.controllers
{
    [ApiController]
    [Route("[controller]")]

    public class StudentsController : ControllerBase
    {
        public static List<Students> GetStudents()
        {
            List<Students> Students = new List<Students>();
            Students.Add(new Students(){Id = 1, First_name = "Sudent ", Last_name = "Sudent ", Age = 19});
            Students.Add(new Students(){Id = 2, First_name = "Sudent ", Last_name = "Sudent ", Age = 19});
            Students.Add(new Students(){Id = 3, First_name = "Sudent ", Last_name = "Sudent ", Age = 20});
            return Students;
        }

        [HttpGet]

        public IEnumerable<Students> Getstudents_list()
        {
            return GetStudents();
        }

        [HttpGet("{id}")]

        public ActionResult<Students> GetGame_byId(int id)
        {
            var Students = GetStudents().Find(x => x.Id == id);
            if(Students != null)
            {
                return Students;
            }
            else
            {
                return NotFound();
            }
            
            
        }
    }
}
