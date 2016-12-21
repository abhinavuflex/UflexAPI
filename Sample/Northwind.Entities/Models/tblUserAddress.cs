// ReSharper disable DoNotCallOverridableMethodsInConstructor
// ReSharper disable RedundantUsingDirective

using System;
using System.Collections.Generic;
using Repository.Pattern.Ef6;

namespace Northwind.Entities.Models
{
    public class tblUserAddress :Entity
    {
        public int? ID { get; set; }
        public int? UserID { get; set; }
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        public int? CityID { get; set; }
        public int? StateID { get; set; }
        public int? CountryID { get; set; }
        public int? Pincode { get; set; }
        public int? ContactNo { get; set; }
        public int? MobileNo { get; set; }
        public string EmailID { get; set; }

        public bool? IsPermanentAddress { get; set; }
    }

    
}