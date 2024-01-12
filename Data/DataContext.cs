using Microsoft.EntityFrameworkCore;
using RodriguezMStudentDataBase.Models;

namespace RodriguezMStudentDataBase.Data;

public class DataContext : DbContext
{
    //this sets up database functionality on the class
    //DbContectOptions<DataContext> 
    public DataContext(DbContextOptions<DataContext> options) : base(options) //base keyword allows us to access stuff from the base class
    {

    }
    public DbSet<Student> Students { get; set; }
}
