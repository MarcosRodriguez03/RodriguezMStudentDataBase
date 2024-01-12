
using Microsoft.AspNetCore.Mvc;
using RodriguezMStudentDataBase.Models;
using RodriguezMStudentDataBase.Services.StudentDataBase;

namespace RodriguezMStudentDataBase.Controllers;

[ApiController]
[Route("api/[controller]")]
public class StudentDataBaseController : ControllerBase
{
    private readonly IStudentDataBase _studentDataBase;

    public StudentDataBaseController(IStudentDataBase studentDataBase)
    {
        _studentDataBase = studentDataBase;
    }

    [HttpGet]
    [Route("ReadStudents")]

    public List<Student> ReadStudents()
    {
        return _studentDataBase.ReadStudents();
    }

    [HttpPost]
    [Route("AddStudent/{firstName}/{lastName}/{hobbies}")]
    public List<Student> AddStudent(string firstName, string lastName, string hobbies)
    {
        return _studentDataBase.AddStudent(firstName, lastName, hobbies);
    }

    [HttpDelete]
    [Route("DeleteStudent/{firstName}")]
    public List<Student> DeleteStudent(string firstName)
    {
        return _studentDataBase.DeleteStudent(firstName);
    }




}
