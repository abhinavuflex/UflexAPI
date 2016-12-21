using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uflex.Model
{
 public  class EmployeeJoining
    {
        public string Division { get; set; }
        public DateTime  JoiningDate { get; set; }
        public string Designation { get; set; }
        public string Department { get; set; }
        public string Location { get; set; }
        public string UploadPhoto { get; set; }
        public string Title { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }

        //Address
        public ICollection<Address> _Address { get; set; }

        //Birth Detail
        public DateTime  BirthDate { get; set; }
        public int PlaceofBirth { get; set; }
        public int CountryofBirth { get; set; }

        //Natioanlity Details
        public int Nationality { get; set; }
        public int Religion { get; set; }
        public string Domicile { get; set; }

        //Language Details
        public ICollection<Language> _Language { get; set; }

        //Passport Detail
        public string  PassportNo { get; set; }
        public DateTime  validUpto { get; set; }
        public string IssuePlace { get; set; }

        //Maritial Details
        public int MaritalID { get; set; }
        public DateTime MarriageDate { get; set; }

        //Health Information

        public int RatePersonalHealth{ get; set; }
        public int TabacooUser { get; set; }
        public int BloodGroup { get; set; }
        public string MarkofIdentification { get; set; }
        public double Height { get; set; }
        public double Weight { get; set; }

        //Wear Glass Details
        public double PowerL { get; set; }
        public double PowerR { get; set; }

        public string PersonalPhysicalDetails { get; set; }

        //FamilyDetail
        public ICollection<FamilyDetail> _FamilyDetail { get; set; }

        //KinRelativeDetail
        public ICollection<KinRelativeDetail> _KinRelativeDetail { get; set; }

        //QualificationDetails
        public ICollection<Qualification> _Qualification { get; set; }

        //Extra Activities
        public ICollection<Hobbies> _Hobbies { get; set; }
        public ICollection<Sports> _Sports { get; set; }

        public ICollection<SpecialInterest> _SpecialInterest { get; set; }
        public ICollection<Literature> _Literature { get; set; }
        public ICollection<ProfessionalBodies> _ProfessionalBodies { get; set; }
        public ICollection<SocialOrganisation> _SocialOrganisation { get; set; }
        public ICollection<Clubs> _Clubs { get; set; }

        //Previous Employement Detials
        public int TotalExperience { get; set; }
        public int LineExperience { get; set; }
        public int OtherExperience { get; set; }
        public bool AreYouPresentlyEmployed { get; set; }
        public string EmployerName { get; set; }
        public string ReportingPerson { get; set; }
        public DateTime FromPeriodofEmployment { get; set; }
        public DateTime ToPeriodofEmployment { get; set; }
        public string StartingPosition { get; set; }
        public string LeavingPosition { get; set; }
        public string PreviousEmploymentDepartment { get; set; }
        public int LatestCTC { get; set; }

        //Salary /CTC at the time of leaving Break-up
        public int BasicSalory { get; set; }
        public int HRA { get; set; }
        public int Convey { get; set; }
        public int Allowances { get; set; }
        public int LTAExtrAllowance { get; set; }
        public int  Total { get; set; }
        public string Responsibilties { get; set; }

        //Previous Employment Details
        public ICollection<PreviousEmploymentDetails> _PreviousEmploymentDetails { get; set; }
        //Person of Refrences
        public ICollection<RefrencePerson> _RefrencePerson { get; set; }
        //Extra Details
        public string AnyCriminalCase { get; set; }
        public string Particularsofmaterialindebtedness { get; set; }
        public string insuredpreviouslyundertheprevisionofESI { get; set; }
        public string EPFSchemePFAccountNO { get; set; }
        public string AnyOtherInfo { get; set; }
        public DateTime SelfDeclarationDate { get; set; }
        public string DeclarationPlace { get; set; }
    }
    public class Address
    {
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        public int City { get; set; }
        public int State { get; set; }
        public int Country { get; set; }
        public int Pincode { get; set; }
        public int ContactNo { get; set; }
        public int MobileNo { get; set; }
        public string EmailId { get; set; }
        public bool IsPermanentAddress { get; set; }

    }
    public class Language
    {
        public int LanguageID { get; set; }
    }
    public class FamilyDetail
    {
        public int title_FD { get; set; }
        public string FirstName_FD { get; set; }
        public string MiddleName_FD { get; set; }
        public string LastName_FD { get; set; }
        public int Relationship { get; set; }
        public DateTime DateofBirth { get; set; }
        public int  Occupation { get; set; }
        public string WetherResidingwith { get; set; }

    }
    public class KinRelativeDetail
    {
        public int Title { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public int Releation { get; set; }
        public int Occupation { get; set; }
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        public int City { get; set; }
        public int State { get; set; }
        public int Country { get; set; }
        public string Pincode { get; set; }
        public int MobileNo { get; set; }
        public String EmailID { get; set; }
    }
    public class Qualification
    {
        public int DegreeName { get; set; }
        public int University { get; set; }
        public int PercentageofMarks { get; set; }
        public int Division { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int ModeofCourse { get; set; }
        public string Specialization { get; set; }
        public string MainSubjects { get; set; }
    }
    public class Hobbies
    {
        public string _Hobbies { get; set; }
    }
    public class Sports
    {
        public string _Sports { get; set; }
    }
    public class SpecialInterest
    {
        public string _SpecialInterest { get; set; }
    }
    public class Literature
    {
        public string _Literature { get; set; }

    }
    public class ProfessionalBodies
    {
        public string _ProfessionalBodies { get; set; }
    }
    public class SocialOrganisation
    {
        public string _SocialOrganisation { get; set; }
    }
    public class Clubs
    {
        public string _Clubs { get; set; }
    }
    public class PreviousEmploymentDetails
    {
        public string CompanyName { get; set; }
        public string Department { get; set; }
        public DateTime FromPeriodofEmployment { get; set; }
        public DateTime ToPeriodofEmployment { get; set; }
        public string StartingPostionHeld { get; set; }
        public string LeavePositionHeld { get; set; }
        public string ReasonOfLeaving { get; set; }
        public int LatestCTC { get; set; }

    }
    public class RefrencePerson
    {
        public int title { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string Job { get; set; }

        public string Releation { get; set; }
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        public int City { get; set; }
        public int State { get; set; }
        public int Country { get; set; }
        public int Pincode { get; set; }
        public int MobileNO { get; set; }
        public string EmailID { get; set; }
    }
}
