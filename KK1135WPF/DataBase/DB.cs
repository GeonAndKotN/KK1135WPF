using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;

namespace KK1135WPF.DataBase
{
    public class DB : DbContext
    {
        public DB()
        {
            Database.EnsureCreated();
        }

        public DbSet<Student> Students { get; set; }

        public DbSet<Section> Sections { get; set; }

        public DbSet<Task> Tasks { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseMySql("server=192.168.200.13;userid=student;password=student;database=WebKK1135", Microsoft.EntityFrameworkCore.ServerVersion.Parse("10.3.39-mariadb"));
        }
    }

    public class Student
    {
        public int Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Title { get; set; }

        public bool Freedom { get; set; } = true;
    }

    public class Section
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public Task Task { get; set; }
    }

    public class Task
    {
        public int Id { get; set; }

        public string Difficility { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }
    }


}
