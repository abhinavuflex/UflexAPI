// ReSharper disable DoNotCallOverridableMethodsInConstructor
// ReSharper disable RedundantUsingDirective

using System;
using System.Collections.Generic;
using Repository.Pattern.Ef6;

namespace Northwind.Entities.Models
{
    public class tblUserDetailsofLatestPreviousEmployment : Entity
    {
        public int? ID { get; set; }
        public int? UserID { get; set; }
        public Double? TotalExperience { get; set; }
        public Double? LineExperience { get; set; }
        public Double? OtherExperience { get; set; }
        public bool Areyoupresentlyemployed { get; set; }
        public string NameofEmployer { get; set; }
        public string ReportingtoWhom { get; set; }
        public DateTime? PeriodofEmployment_StartDate { get; set; }
        public DateTime? PeriodofEmployment_EndDate { get; set; }
        public string PositionHeldStarting { get; set; }
        public string PositionHeldLeaving { get; set; }
        public string Department { get; set; }
        public Double? LatestCTCSalary { get; set; }
        public Double? Basic { get; set; }
        public Double? VDAHRA { get; set; }
        public Double? Conveyance { get; set; }
        public Double? Allowances { get; set; }
        public Double? Others { get; set; }
        public Double? Total { get; set; }
        public string ResponsibilitiesandDuties { get; set; }

        public tblUserDetailsofLatestPreviousEmployment()
        {
            PeriodofEmployment_StartDate = DateTime.Now;
            PeriodofEmployment_EndDate = DateTime.Now;
        }
    }

   
}