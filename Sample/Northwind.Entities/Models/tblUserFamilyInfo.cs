// ReSharper disable DoNotCallOverridableMethodsInConstructor
// ReSharper disable RedundantUsingDirective

using System;
using System.Collections.Generic;
using Repository.Pattern.Ef6;

namespace Northwind.Entities.Models
{
    public class tblUserFamilyInfo : Entity
    {
        public int ID { get; set; }
        public int? UserID { get; set; }
        public int? Title { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public int? Relation { get; set; }
        public int Occupation { get; set; }
        public string Age { get; set; }
        public DateTime? DatofBirth { get; set; }
        public string WetherResidingwithYou { get; set; }
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        public int CityID { get; set; }
        public int StateID { get; set; }
        public int CountryID { get; set; }
        public string PostalCode { get; set; }
        public string ContactNo { get; set; }
        public string EmailID { get; set; }
        public int MobileNo { get; set; }
        public bool IsKinRelative { get; set; }

        public tblUserFamilyInfo()
        {
            DatofBirth = DateTime.Now;
        }
    }

   
}