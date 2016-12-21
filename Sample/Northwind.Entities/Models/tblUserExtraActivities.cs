// ReSharper disable DoNotCallOverridableMethodsInConstructor
// ReSharper disable RedundantUsingDirective

using System;
using System.Collections.Generic;
using Repository.Pattern.Ef6;

namespace Northwind.Entities.Models 
{
    public class tblUserExtraActivities : Entity
    {
        public int? ID { get; set; }
        public int? UserID { get; set; }
        public int? ActivityID { get; set; }
        public string ActivityName { get; set; }
    }

    
}