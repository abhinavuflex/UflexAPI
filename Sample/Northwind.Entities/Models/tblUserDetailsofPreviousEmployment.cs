// ReSharper disable DoNotCallOverridableMethodsInConstructor
// ReSharper disable RedundantUsingDirective

using System;
using System.Collections.Generic;
using Repository.Pattern.Ef6;

namespace Northwind.Entities.Models
{
    public class tblUserDetailsofPreviousEmployment : Entity
    {
        public int? ID { get; set; }
        public int? UserID { get; set; }
        public string CompanyName { get; set; }
        public string Department { get; set; }
        public DateTime? PeriodofEmployment_StartDate { get; set; }
        public DateTime? PeriodofEmployment_EndDate { get; set; }
        public string PositionHeldStarting { get; set; }
        public string PositionHeldLeaving { get; set; }
        public string Reasonforleaving { get; set; }
        public int LatestSalaryCTC { get; set; }

        public tblUserDetailsofPreviousEmployment()
        {
            PeriodofEmployment_StartDate = DateTime.Now;
            PeriodofEmployment_EndDate = DateTime.Now;
        }
    }

  
}