// ReSharper disable DoNotCallOverridableMethodsInConstructor
// ReSharper disable RedundantUsingDirective

using System;
using System.Collections.Generic;
using Repository.Pattern.Ef6;

namespace Northwind.Entities.Models
{
    public class tblEmployeeJoiningInitiateProcess :Entity
    {
        public int? ID { get; set; }
        public int? UserID { get; set; }
        public DateTime? JoiningDate { get; set; }
        public int? DivisionID { get; set; }
        public int? DesignationID { get; set; }
        public int? DepartmentID { get; set; }
        public int? LocationID { get; set; }
        public DateTime? Created_Date { get; set; }

        public tblEmployeeJoiningInitiateProcess()
        {
            JoiningDate = DateTime.Now;
            Created_Date = DateTime.Now;
        }
    }

    
}