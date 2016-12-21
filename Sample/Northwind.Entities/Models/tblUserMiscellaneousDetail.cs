// ReSharper disable DoNotCallOverridableMethodsInConstructor
// ReSharper disable RedundantUsingDirective

using System;
using System.Collections.Generic;
using Repository.Pattern.Ef6;

namespace Northwind.Entities.Models
{
    public class tblUserMiscellaneousDetail : Entity
    {
        public int? ID { get; set; }
        public int? UserID { get; set; }
        public string ANY_CRIMINAL_CASE { get; set; }
        public string CRIMINAL_CASE_Details { get; set; }
        public string material_indebtedness { get; set; }
        public string material_indebtedness_Details { get; set; }
        public string PreviousESI { get; set; }
        public string PreviousESI_Details { get; set; }
        public string Have_Pf_No { get; set; }
        public string Pf_No_Details { get; set; }
        public string Anyotherinformation { get; set; }
        public string Details { get; set; }
        public DateTime? SubmitDate { get; set; }
        public string SubmitPlace { get; set; }

        public tblUserMiscellaneousDetail()
        {
            SubmitDate = DateTime.Now;
        }
    }

    
}