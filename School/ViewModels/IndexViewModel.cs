using School.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace School.ViewModels
{
    public class IndexViewModel
    {
        public Student StudentToAdd { get; set; }
        public List<Student> Students { get; set; }
        public List<Classroom> Classrooms { get; set; }
    }
}