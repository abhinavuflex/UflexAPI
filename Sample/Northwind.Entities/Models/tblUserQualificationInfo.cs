// ReSharper disable DoNotCallOverridableMethodsInConstructor
// ReSharper disable RedundantUsingDirective

using System;
using System.Collections.Generic;
using Repository.Pattern.Ef6;

namespace Northwind.Entities.Models
{
    public class tblUserQualificationInfo : Entity
    {
        public int? ID { get; set; }
        public int? UserID { get; set; }
        public int? DegreeName { get; set; }
        public int? ModeofCourse { get; set; }
        public int? UniversityName { get; set; }
        public string Specialization { get; set; }
        public int? Percentageofmarks { get; set; }
        public int? Division { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public string Mainsubject { get; set; }

        public tblUserQualificationInfo()
        {
            StartDate = DateTime.Now;
            EndDate = DateTime.Now;
        }
    }

  
}