using System;
using System.Collections.Generic;

#nullable disable

namespace DigitalClassroom.Models
{
    public partial class Teacher
    {
        public string TeacherId { get; set; }
        public string SubjectId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailId { get; set; }
    }
}
