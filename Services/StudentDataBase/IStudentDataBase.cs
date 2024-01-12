using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RodriguezMStudentDataBase.Models;

namespace RodriguezMStudentDataBase.Services.StudentDataBase;

public interface IStudentDataBase
{

    List<Student> ReadStudents();
    List<Student> AddStudent(string firstName, string lastName, string hobbies);
    List<Student> DeleteStudent(string firstName);


}
