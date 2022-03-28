using System;
using System.Collections.Generic;

#nullable disable

namespace DigitalClassroom.Models
{
    public partial class Student
    {
        public string StudentId { get; set; }
        public string SubjectId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime? Dob { get; set; }
        public string Email { get; set; }
    }
}
