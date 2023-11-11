using Entities.CustomValidations;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.School
{
    public class Student
    {
        public Student()
        {
            Projects = new HashSet<Project>();
        }
        public int StudentId { get; set; }


        [Display(Name = "Onoma")]
        [Required(ErrorMessage ="You must give a name")]
        public string Name { get; set; }


        [CustomValidation(typeof(MyValidationMethods),"Validate0_150")]
        [Required]
        public int Age { get; set; }


        public ICollection<Project> Projects { get; set; }
    }
}
