using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Application.Models
{
    public class Student
    {
        [DisplayName("ID")]
        public int id { get; set; }
        [DisplayName("Student Name")]
        [Required]
        public String studentName { get; set; }
        [DisplayName("Father's Name")]
        [Required]
        public String fatherName { get; set; }
        [DisplayName("Father's Occupation")]
        [Required]
        public String fatherOccupation { get; set; }
        [DisplayName("Mother's Name")]
        [Required]
        public String motherName { get; set; }
        [DisplayName("Mother's Occupation")]
        [Required]
        public String motherOccupation { get; set; }
        [DisplayName("Date Of Birth")]
        [Required]
        public String dateOfBirth { get; set; }
        [DisplayName("Present Address")]
        [Required]
        public string presentAddress { get; set; }
        [DisplayName("Permanent Addresses")]
        [Required]
        public string permanentAddresses { get; set; }
        [DisplayName("Father's Mobile Number")]
        [Required]
        public long fatherMobileNumber { get; set; }
        [DisplayName("Mother's Mobile Number")]
        [Required]
        public long motherMobileNumber { get; set; }
        [DisplayName("Legal Guardian Name")]
        [Required]
        public string legalGuardianName { get; set; }
        [DisplayName("Legal Guardian Relation")]
        [Required]
        public string legalGuardianRelation { get; set; }
        [DisplayName("Legal Guardian Occupation")]
        [Required]
        public string legalGuardianOccupation { get; set; }
        [DisplayName("Legal Guardian Mobile Number")]
        [Required]
        public long legalGuardianMobileNumber { get; set; }
        [DisplayName("Name Of The University Previous Studied")]
        [Required]
        public string nameOfTheUniversityPreviousStudied { get; set; }
        [DisplayName("NOC Number")]
        [Required]
        public long NOCnumber { get; set; }
        [DisplayName("NOC date")]
        [Required]
        public String NOCdate { get; set; }
        [DisplayName("The Class That Wants To Be Admitted")]
        [Required]
        public string theClassThatWantsToBeAdmitted { get; set; }
        [DisplayName("Admition Date")]
        [Required]
        public String admitionDate { get; set; }
    }
}