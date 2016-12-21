// ReSharper disable DoNotCallOverridableMethodsInConstructor
// ReSharper disable RedundantUsingDirective

using System;
using System.Collections.Generic;
using Repository.Pattern.Ef6;

namespace Northwind.Entities.Models 
{
    public class tblUserPersonalDeclaration : Entity
    {
        public int? ID { get; set; }
        public int? UserID { get; set; }
        public DateTime? EarlierOrganizationoResignedDate { get; set; }
        public DateTime? EarlierOrganizationRelevedDate { get; set; }
        public DateTime? DeclerationDate { get; set; }
        public string DeclerationPlace { get; set; }
        public string Title_DR { get; set; }
        public string FirstName_DR { get; set; }
        public string MiddleName_DR { get; set; }
        public string LastName_DR { get; set; }
        public string Releation_DR { get; set; }

        public tblUserPersonalDeclaration()
        {
            EarlierOrganizationoResignedDate = DateTime.Now;
            EarlierOrganizationRelevedDate = DateTime.Now;
            DeclerationDate = DateTime.Now;
        }
    }

    
}