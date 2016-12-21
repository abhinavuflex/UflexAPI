// ReSharper disable DoNotCallOverridableMethodsInConstructor
// ReSharper disable RedundantUsingDirective

using System;
using System.Collections.Generic;
using Repository.Pattern.Ef6;

namespace Northwind.Entities.Models
{
    public class tblUserPersonsforReference : Entity
    {
        public int? ID { get; set; }
        public int? UserID { get; set; }
        public int Title { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string Relation { get; set; }
        public string JobWorkBusiness { get; set; }
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        public int City { get; set; }
        public int State { get; set; }
        public int Country { get; set; }
        public string PostalCode { get; set; }
        public int ContactNo { get; set; }
        public string EmailID { get; set; }
    }

    
}