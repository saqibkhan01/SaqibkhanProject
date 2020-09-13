using System;
using System.Data.Entity;

namespace Student.Models
{
    public class StudentModel
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public DateTime DateofBirth { get; set; }
        public string Gender { get; set; }
        public decimal Fee { get; set; }
    }

    public class StudentDBContext : DbContext
    {
        public DbSet<StudentModel> Students { get; set; }
    }
}