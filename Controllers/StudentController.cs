using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Student.Dto;
using Student.Models;
namespace StudentApi.Controllers
{
    [ApiController]
    [Route("/")]
    public class StudentController : ControllerBase
    {

        private static List<StudentModel> students = new List<StudentModel>();
        [HttpGet]
           public IActionResult GetStudents()
            {
            return Ok(students);
            }



        [HttpGet("{id}")]
        public IActionResult GetStudentById(int id)
        {
            var student = students.FirstOrDefault(s => s.Id == id);

            if(student == null)
            {
                return NotFound("Student Not Found.");
            }

            return Ok(student);
        }


        [HttpPost]
        public IActionResult AddStudent(StudentCreateDto studentDto)
        {
            StudentModel student = new StudentModel
            {
                Id = studentDto.Id,
                Name = studentDto.Name,
                City = studentDto.City

            };

            students.Add(student);

            return Ok("Student Aedded SuccesFully");
        }


        [HttpPut]
        public IActionResult UpdateStudent(int id,StudentModel updateStudent)
        {
            var student = students.FirstOrDefault(s => s.Id == id);

            if(student == null)
            {
                return NotFound("student Not Found.");
            }
            student.Name = updateStudent.Name;
            student.City = updateStudent.City;


            return Ok("Student Updated Successfully");
        }


        [HttpDelete("{id}")]
        
        public IActionResult DeleteStudent(int id)
        {
            var student = students.FirstOrDefault(s => s.Id == id);

            if(student == null)
            {
                return NotFound("Student Not Found.");
            }
            students.Remove(student);

            return Ok(student);
        }
      
    }
}
