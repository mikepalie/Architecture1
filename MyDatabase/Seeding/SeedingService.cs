using Entities.School;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDatabase.Seeding
{
    public class SeedingService
    {
        ApplicationDbContext db;

        public SeedingService(ApplicationDbContext context)
        {
            db = context;
        }


        public void SeedStudents()
        {
            Student s1 = new Student() { Name = "Hector", Age=23  };
            Student s2 = new Student() { Name = "Mixalis", Age = 22 };
            Student s3 = new Student() { Name = "Mpampis", Age = 43 };
            Student s4 = new Student() { Name = "Fanis", Age = 33 };

            Project p1 = new Project() { Title = "C#" };
            Project p2 = new Project() { Title = "Java" };
            Project p3 = new Project() { Title = "Python" };
            Project p4 = new Project() { Title = "Html" };

            p1.Student = s1;
            p2.Student = s2;
            p3.Student = s3;
            p4.Student = s4;

            db.Projects.Add(p1);
            db.Projects.Add(p2);
            db.Projects.Add(p3);
            db.Projects.Add(p4);


            db.Students.Add(s1);
            db.Students.Add(s2);
            db.Students.Add(s3);
            db.Students.Add(s4);

            db.SaveChanges();
        }


    }
}
