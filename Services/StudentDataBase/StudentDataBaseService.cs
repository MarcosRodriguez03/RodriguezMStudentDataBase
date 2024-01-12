using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RodriguezMStudentDataBase.Data;
using RodriguezMStudentDataBase.Models;

namespace RodriguezMStudentDataBase.Services.StudentDataBase;

public class StudentDataBaseService : IStudentDataBase
{


    private readonly DataContext _db;

    public StudentDataBaseService(DataContext db)
    {
        _db = db;
    }
    public List<Student> ReadStudents()
    {
        return _db.Students.ToList();
    }
    public List<Student> AddStudent(string firstName, string lastName, string hobbies)
    {
        Student newStudent = new();
        newStudent.FirstName = firstName;
        newStudent.LastName = lastName;
        newStudent.Hobbies = hobbies;

        _db.Students.Add(newStudent);
        _db.SaveChanges();

        return _db.Students.ToList();

        // studentList.Add(firstName);
        // studentList.Add(lastName);
        // studentList.Add(hobbies);
        // return studentList;
    }
    public List<Student> DeleteStudent(string firstName)
    {
        var student = _db.Students.FirstOrDefault(foundStudent => foundStudent.FirstName == firstName);
        if (student != null)
        {
            _db.Students.Remove(student);
            _db.SaveChanges();
        }
        return _db.Students.ToList();

    }
}
