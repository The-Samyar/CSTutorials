using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCTutorialProject.Models
{
    public class Student
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string StudentNo { get; set; }
        public Standard standard { get; set; }
    }
}