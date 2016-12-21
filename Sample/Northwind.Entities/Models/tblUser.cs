using System;
using System.Collections.Generic;
using Repository.Pattern.Ef6;

namespace Northwind.Entities.Models
{
    public partial class tblUser : Entity
    {
        public int ID { get; set; }
        public string Tittle { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public int? MobileNo { get; set; }
        public string EmailID { get; set; }
        public DateTime? DateofBirth { get; set; }
        public string Age { get; set; }
        public int PlaceofBirth { get; set; }
        public int CountryofBirth { get; set; }
        public int Nationality { get; set; }
        public int Castreligion { get; set; }
        public string Domicile { get; set; }
        public string PassportNo { get; set; }
        public DateTime? Validupto { get; set; }
        public string PlaceofIssue { get; set; }
        public int MaritalStatus { get; set; }
        public DateTime? MarriageDate { get; set; }
        public string Wear_Specs { get; set; }
        public Double? PowerL { get; set; }
        public Double? PowerR { get; set; }
        public Double? Height_CM { get; set; }
        public Double? Weight_KG { get; set; }
        public int BloodGroup { get; set; }
        public int TobacooUser { get; set; }
        public int HEALTH_RATE  { get; set; }
        public string Comments { get; set; }
        public string Markofidentification { get; set; }

        public tblUser()
        {
            DateofBirth = DateTime.Now;
            Validupto = DateTime.Now;
            MarriageDate = DateTime.Now;
        }
    }

 
}