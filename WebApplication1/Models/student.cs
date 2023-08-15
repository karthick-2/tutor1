using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class Student
    {
        public Student() { }
        [Key]
        [Required(ErrorMessage = "Roll number required please enter ")]
        public int rollno { get; set; }
        [StringLength(10, ErrorMessage = "must be length of 20")]
        public string name { get; set; }
        [Range(0, 20, ErrorMessage = "school student only allowed age of 20")]
        [Required(ErrorMessage = "Enter the age")]
        public int age { get; set; }
    }

    public class Teacher
    {
        [Key]
        public int staffId { get; set; }
        [Required]
        public string staffName { get; set; }
    }
    public class  HOD
    {

        public List<Teacher> teacher { get; set; }
        public List<Student> student { get; set; }
    }


}
