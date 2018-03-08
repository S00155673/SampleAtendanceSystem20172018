﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace StudentAttendance.Models.Banner
{
    public class Student
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int  id { get; set; }
        public string FirstName { get; set; }
        public int SecondName { get; set; }
        [EmailAddress]
        public string Email { get; set; }
        [RegularExpression(@"^\(?([0-9]{3})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{4})$",
        ErrorMessage = "Personal phone format is not valid.")]
        public string PhoneNumber { get; set; }

        public virtual ICollection<Enrollment> EnrolledFor { get; set; }
        public virtual ICollection<Delivery> Attends { get; set; }


    }
}