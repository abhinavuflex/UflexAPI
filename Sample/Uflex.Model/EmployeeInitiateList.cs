using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uflex.Model
{
public class EmployeeInitiateList
    {
        public string  EmployeeName { get; set; }
        public int? MobileNo { get; set; }
        public string EmailID { get; set; }
        public DateTime? JoiningDate { get; set; }
        public string Division { get; set; }
        public DateTime ApplyDate { get; set; }
    }
}
