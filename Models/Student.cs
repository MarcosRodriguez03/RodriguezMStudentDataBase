using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RodriguezMStudentDataBase.Models
{
    public class Student
    {
        public int Id { get; set; }
        public string FirstName { get; set; } = "Marcos";
        public string LastName { get; set; } = "Rodriguez";
        public string Hobbies { get; set; } = "BasketBall";
    }
}