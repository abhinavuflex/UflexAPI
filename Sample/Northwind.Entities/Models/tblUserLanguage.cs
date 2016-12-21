// ReSharper disable DoNotCallOverridableMethodsInConstructor
// ReSharper disable RedundantUsingDirective

using System;
using System.Collections.Generic;
using Repository.Pattern.Ef6;

namespace Northwind.Entities.Models
{
    public class tblUserLanguage :Entity
    {
        public int? ID { get; set; }
        public int? UserID { get; set; }
        public int? LanguageID { get; set; }
    }

    
}