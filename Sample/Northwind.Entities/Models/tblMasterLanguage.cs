// ReSharper disable DoNotCallOverridableMethodsInConstructor
// ReSharper disable RedundantUsingDirective

using System;
using System.Collections.Generic;
using Repository.Pattern.Ef6;

namespace Northwind.Entities.Models
{
    public class tblMasterLanguage :Entity
    {
        public int? ID { get; set; }
        public string LanguageName { get; set; }
    }

   
}