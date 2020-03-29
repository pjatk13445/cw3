using System;
using Cw3.Models;
using Microsoft.AspNetCore.Mvc;
namespace Cw3.Controllers
{
    [ApiController]
    [Route("api/students")]
    public class StudentsController: ControllerBase
    {
        public StudentsController()
        {
        }

        public string GetStudent()
        {
            return "Kowalski, Malewski, Andrzejewski";
        }

        [HttpGet("{id}")]
        public IActionResult GetStudent(int id)
        {
            if (id == 1)
            {
                return Ok("Kowalski");
            } else if (id == 2)
            {
                return Ok("Malewski");
            }
            return NotFound("Nie ma takiego studenta");
        }

        [HttpGet]
        public string GetStudents(string orderBy)
        {
            return $"Kowalski, Malewski, Andrzejewski sortowanie={orderBy}";
        }

        [HttpPost]
        public IActionResult CreateStudnet(Student student)
        {
            student.IndexNumber = $"s{new Random().Next(1, 100000)}";
            return Ok(student);
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteStudent(int id)
        {
            if (id == 1)
            {
                return Ok("Usuwanie ukończone");
            }
            else if (id == 2)
            {
                return Ok("Usuwanie ukończone");
            }
            return NotFound("Nie ma takiego studenta");
        }

        [HttpPut("{id}")]
        public IActionResult PutStudent(int id, Student student)
        {
            if (id == 1)
            {
                return Ok("Ąktualizacja dokończona");
            }
            else if (id == 2)
            {
                return Ok("Ąktualizacja dokończona");
            }
            return NotFound("Nie ma takiego studenta");
        }
    }
}
