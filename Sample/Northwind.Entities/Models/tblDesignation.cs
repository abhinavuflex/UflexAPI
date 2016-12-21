// ReSharper disable DoNotCallOverridableMethodsInConstructor
// ReSharper disable RedundantUsingDirective

using System;
using System.Collections.Generic;
using Repository.Pattern.Ef6;

namespace Northwind.Entities.Models
{
    public class tblDesignation : Entity
    {
        public int? ID { get; set; }
        public string Designation { get; set; }
    }

   
}