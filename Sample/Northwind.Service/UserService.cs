#region

using System.Collections.Generic;
using Northwind.Entities.Models;
using Northwind.Repository.Models;
using Northwind.Repository.Repositories;
using Repository.Pattern.Repositories;
using Service.Pattern;
using Uflex.Model;
using System;
using System.Linq;

#endregion

namespace Northwind.Service
{
    /// <summary>
    ///     Add any custom business logic (methods) here
    /// </summary>
    public interface IUserService : IService<tblUser>
    {
        decimal CustomerOrderTotalByYear(string customerId, int year);
        void InsertInitiateDetails(InitiateDetails objInitiateDetails);
    }

    /// <summary>
    ///     All methods that are exposed from Repository in Service are overridable to add business logic,
    ///     business logic should be in the Service layer and not in repository for separation of concerns.
    /// </summary>
    public class UserService : Service<tblUser>, IUserService
    {
        private readonly IRepositoryAsync<tblUser> _repositorytblUser;
        private readonly IRepositoryAsync<tblUserFamilyInfo> _repositorytblUserFamilyInfo;
        private readonly IRepositoryAsync<tblUserQualificationInfo> _repositorytblUserQualificationInfo;
        private readonly IRepositoryAsync<tblEmployeeJoiningInitiateProcess> _repositorytblEmployeeJoiningInitiateProcess;
        private readonly IRepositoryAsync<tblDepartment> _repositorytblDepartment;
        private readonly IRepositoryAsync<tblDesignation> _repositorytblDesignation;
        private readonly IRepositoryAsync<tblDivision> _repositorytblDivision;
        private readonly IRepositoryAsync<tblUserAddress> _repositorytblUserAddress;
        private readonly IRepositoryAsync<tblUserLanguage> _repositorytblUserLanguage;
        private readonly IRepositoryAsync<tblUserDetailsofLatestPreviousEmployment> _repositorytblUserDetailsofLatestPreviousEmployment;
        private readonly IRepositoryAsync<tblUserDetailsofPreviousEmployment> _repositorytblUserDetailsofPreviousEmployment;
        private readonly IRepositoryAsync<tblUserPersonsforReference> _repositorytblUserPersonsforReference;
        private readonly IRepositoryAsync<tblUserMiscellaneousDetail> _repositorytblUserMiscellaneousDetail;


        public UserService(IRepositoryAsync<tblUser> repositorytblUser, IRepositoryAsync<tblUserFamilyInfo> repositorytblUserFamilyInfo, IRepositoryAsync<tblUserQualificationInfo> repositorytblUserQualificationInfo, IRepositoryAsync<tblEmployeeJoiningInitiateProcess>
            repositorytblEmployeeJoiningInitiateProcess, IRepositoryAsync<tblDepartment> repositorytblDepartment, IRepositoryAsync<tblDesignation> repositorytblDesignation,
            IRepositoryAsync<tblDivision> repositorytblDivision, IRepositoryAsync<tblUserAddress> repositorytblUserAddress, IRepositoryAsync<tblUserLanguage> repositorytblUserLanguage,
            IRepositoryAsync<tblUserDetailsofLatestPreviousEmployment> repositorytblUserDetailsofLatestPreviousEmployment, IRepositoryAsync<tblUserDetailsofPreviousEmployment> repositorytblUserDetailsofPreviousEmployment
            , IRepositoryAsync<tblUserPersonsforReference> repositorytblUserPersonsforReference, IRepositoryAsync<tblUserMiscellaneousDetail> repositorytblUserMiscellaneousDetail)
            : base(repositorytblUser)
        {
            _repositorytblUser = repositorytblUser;
            _repositorytblUserFamilyInfo = repositorytblUserFamilyInfo;
            _repositorytblUserQualificationInfo = repositorytblUserQualificationInfo;
            _repositorytblEmployeeJoiningInitiateProcess = repositorytblEmployeeJoiningInitiateProcess;
            _repositorytblDepartment = repositorytblDepartment;
            _repositorytblDesignation = repositorytblDesignation;
            _repositorytblDivision = repositorytblDivision;
            _repositorytblUserAddress = repositorytblUserAddress;
            _repositorytblUserLanguage = repositorytblUserLanguage;
            _repositorytblUserDetailsofLatestPreviousEmployment = repositorytblUserDetailsofLatestPreviousEmployment;
            _repositorytblUserDetailsofPreviousEmployment = repositorytblUserDetailsofPreviousEmployment;
            _repositorytblUserPersonsforReference = repositorytblUserPersonsforReference;
            _repositorytblUserMiscellaneousDetail = repositorytblUserMiscellaneousDetail;
        }

        public decimal CustomerOrderTotalByYear(string customerId, int year)
        {
            // add business logic here
            // return _repository.GetCustomerOrderTotalByYear(customerId, year);
            return 87;
        }
        public void InsertInitiateDetails(InitiateDetails objInitiateDetails)
        {
            tblUser objUser = new tblUser();
            tblEmployeeJoiningInitiateProcess objEmployeeJoiningInitiateProcess = new tblEmployeeJoiningInitiateProcess();
            objUser.Tittle = objInitiateDetails.Title;
            objUser.FirstName = objInitiateDetails.FirstName;
            objUser.MiddleName = objInitiateDetails.MiddleName;
            objUser.LastName = objInitiateDetails.LastName;
            objUser.MobileNo = objInitiateDetails.MobileNo;
            objUser.EmailID = objInitiateDetails.EmailID;
            _repositorytblUser.Insert(objUser);

            objEmployeeJoiningInitiateProcess.JoiningDate = objInitiateDetails.JoiningDate;
            objEmployeeJoiningInitiateProcess.DepartmentID = objInitiateDetails.Department;
            objEmployeeJoiningInitiateProcess.DesignationID = objInitiateDetails.Designation;
            objEmployeeJoiningInitiateProcess.DivisionID = objInitiateDetails.Division;
            objEmployeeJoiningInitiateProcess.LocationID = objInitiateDetails.Location;
            _repositorytblEmployeeJoiningInitiateProcess.Insert(objEmployeeJoiningInitiateProcess);

        }

        public List<EmployeeInitiateList> GetEmployeeInitiateListByDate(DateTime fromDate, DateTime toDate)
        {
            tblUser objUser = new tblUser();
            tblEmployeeJoiningInitiateProcess objEmployeeJoiningInitiateProcess = new tblEmployeeJoiningInitiateProcess();
            List<EmployeeInitiateList> collEmployeeInitiateList = new List<EmployeeInitiateList>();
            EmployeeInitiateList objEmployeeInitiateList = new EmployeeInitiateList();

            var objUserCollection = _repositorytblEmployeeJoiningInitiateProcess.Queryable().Where(x => x.JoiningDate >= fromDate && x.JoiningDate <= toDate).ToList();
            foreach (var Detail in objUserCollection)
            {
                var objUserResult = _repositorytblUser.Queryable().FirstOrDefault(x => x.ID == Detail.UserID);
                objEmployeeInitiateList.EmployeeName = objUserResult.Tittle + "" + objUserResult.FirstName + "" + objUserResult.MiddleName + "" + objUserResult.LastName;
                objEmployeeInitiateList.MobileNo = objUserResult.MobileNo;
                objEmployeeInitiateList.EmailID = objUserResult.EmailID;
                // var objEmployeeJoiningInitiateProcessResult = _repositorytblEmployeeJoiningInitiateProcess.Queryable().FirstOrDefault(x => x.ID == EmployeeID);
                objEmployeeInitiateList.JoiningDate = Detail.JoiningDate;
                var objDivisionResult = _repositorytblDivision.Queryable().FirstOrDefault(x => x.ID == Detail.UserID);
                objEmployeeInitiateList.Division = objDivisionResult.Division;
                collEmployeeInitiateList.Add(objEmployeeInitiateList);
            }
            return collEmployeeInitiateList;
        }
        public EmployeeInitiateList GetEmployeeInitiateListByName(int EmployeeID)
        {
            tblUser objUser = new tblUser();
            tblEmployeeJoiningInitiateProcess objEmployeeJoiningInitiateProcess = new tblEmployeeJoiningInitiateProcess();
            List<EmployeeInitiateList> collEmployeeInitiateList = new List<EmployeeInitiateList>();
            EmployeeInitiateList objEmployeeInitiateList = new EmployeeInitiateList();

            var objUserResult = _repositorytblUser.Queryable().FirstOrDefault(x => x.ID == EmployeeID);
            objEmployeeInitiateList.EmployeeName = objUserResult.Tittle + "" + objUserResult.FirstName + "" + objUserResult.MiddleName + "" + objUserResult.LastName;
            objEmployeeInitiateList.MobileNo = objUserResult.MobileNo;
            objEmployeeInitiateList.EmailID = objUserResult.EmailID;

            var objEmployeeJoiningInitiateProcessResult = _repositorytblEmployeeJoiningInitiateProcess.Queryable().FirstOrDefault(x => x.ID == EmployeeID);
            objEmployeeInitiateList.JoiningDate = objEmployeeJoiningInitiateProcessResult.JoiningDate;
            var objDivisionResult = _repositorytblDivision.Queryable().FirstOrDefault(x => x.ID == objEmployeeJoiningInitiateProcessResult.UserID);
            objEmployeeInitiateList.Division = objDivisionResult.Division;
            return objEmployeeInitiateList;

        }

        public void InsertEmployeeJoining(EmployeeJoining objEmployeeJoining)
        {
            tblUser objUser = new tblUser();
            tblUserAddress objUserAddress = new tblUserAddress();
            tblUserLanguage objtblUserLanguage = new tblUserLanguage();
            tblUserFamilyInfo objtblUserFamilyInfo = new tblUserFamilyInfo();
            tblUserFamilyInfo objtblUserFamilyInfoKin = new tblUserFamilyInfo();
            tblUserQualificationInfo objtblUserQualificationInfo = new tblUserQualificationInfo();
            tblUserExtraActivities objtblUserExtraActivities = new tblUserExtraActivities();
            tblUserDetailsofLatestPreviousEmployment objtblUserDetailsofLatestPreviousEmployment = new tblUserDetailsofLatestPreviousEmployment();
            tblUserDetailsofPreviousEmployment objtblUserDetailsofPreviousEmployment = new tblUserDetailsofPreviousEmployment();
            tblUserPersonsforReference objtblUserPersonsforReference = new tblUserPersonsforReference();
            tblUserMiscellaneousDetail objtblUserMiscellaneousDetail = new tblUserMiscellaneousDetail();

            objUser.Tittle = objEmployeeJoining.Title;
            objUser.FirstName = objEmployeeJoining.FirstName;
            objUser.MiddleName = objEmployeeJoining.MiddleName;
            objUser.LastName = objEmployeeJoining.LastName;
            _repositorytblUser.Insert(objUser);

            foreach (var objAddress in objEmployeeJoining._Address)
            {
                //objUserAddress.UserID=
                objUserAddress.AddressLine1 = objAddress.AddressLine1;
                objUserAddress.AddressLine2 = objAddress.AddressLine2;
                objUserAddress.CityID = objAddress.City;
                objUserAddress.StateID = objAddress.State;
                objUserAddress.CountryID = objAddress.Country;
                objUserAddress.Pincode = objAddress.Pincode;
                objUserAddress.ContactNo = objAddress.ContactNo;
                objUserAddress.MobileNo = objAddress.MobileNo;
                objUserAddress.EmailID = objAddress.EmailId;
                objUserAddress.IsPermanentAddress = objAddress.IsPermanentAddress;
                _repositorytblUserAddress.Insert(objUserAddress);
            }
            objUser.DateofBirth = objEmployeeJoining.BirthDate;
            objUser.PlaceofBirth = objEmployeeJoining.PlaceofBirth;
            objUser.CountryofBirth = objEmployeeJoining.CountryofBirth;
            objUser.Nationality = objEmployeeJoining.Nationality;
            objUser.Castreligion = objEmployeeJoining.Religion;
            objUser.Domicile = objEmployeeJoining.Domicile;

            foreach (var objlanguage in objEmployeeJoining._Language)
            {
                //  objtblUserLanguage.UserID=
                objtblUserLanguage.LanguageID = objlanguage.LanguageID;
            }
            objUser.PassportNo = objEmployeeJoining.PassportNo;
            objUser.Validupto = objEmployeeJoining.validUpto;
            objUser.PlaceofIssue = objEmployeeJoining.IssuePlace;
            objUser.MaritalStatus = objEmployeeJoining.MaritalID;
            objUser.MarriageDate = objEmployeeJoining.MarriageDate;
            objUser.HEALTH_RATE = objEmployeeJoining.RatePersonalHealth;
            objUser.TobacooUser = objEmployeeJoining.TabacooUser;
            objUser.BloodGroup = objEmployeeJoining.BloodGroup;
            objUser.Markofidentification = objEmployeeJoining.MarkofIdentification;
            objUser.Height_CM = objEmployeeJoining.Height;
            objUser.Weight_KG = objEmployeeJoining.Weight;
            objUser.PowerL = objEmployeeJoining.PowerL;
            objUser.PowerR = objEmployeeJoining.PowerR;
            objUser.Comments = objEmployeeJoining.PersonalPhysicalDetails;
            _repositorytblUser.Insert(objUser);

            foreach (var objFamilyInfo in objEmployeeJoining._FamilyDetail)
            {
               // objtblUserFamilyInfo.UserID=
                objtblUserFamilyInfo.Title = objFamilyInfo.title_FD;
                objtblUserFamilyInfo.FirstName = objFamilyInfo.FirstName_FD;
                objtblUserFamilyInfo.MiddleName = objFamilyInfo.MiddleName_FD;
                objtblUserFamilyInfo.LastName = objFamilyInfo.LastName_FD;
                objtblUserFamilyInfo.Relation = objFamilyInfo.Relationship;
                objtblUserFamilyInfo.DatofBirth = objFamilyInfo.DateofBirth;
                objtblUserFamilyInfo.Occupation = objFamilyInfo.Occupation;
                objtblUserFamilyInfo.WetherResidingwithYou = objFamilyInfo.WetherResidingwith;
                objtblUserFamilyInfo.IsKinRelative = false;
                _repositorytblUserFamilyInfo.Insert(objtblUserFamilyInfo);
            }
            foreach (var objFamilyInfoKin in objEmployeeJoining._KinRelativeDetail)
            {
                // objtblUserFamilyInfoKin.UserID=
                objtblUserFamilyInfoKin.Title = objFamilyInfoKin.Title;
                objtblUserFamilyInfoKin.FirstName = objFamilyInfoKin.FirstName;
                objtblUserFamilyInfoKin.MiddleName = objFamilyInfoKin.MiddleName;
                objtblUserFamilyInfoKin.LastName = objFamilyInfoKin.LastName;
                objtblUserFamilyInfoKin.Relation = objFamilyInfoKin.Releation;
                objtblUserFamilyInfoKin.Occupation = objFamilyInfoKin.Occupation;
                objtblUserFamilyInfoKin.AddressLine1 = objFamilyInfoKin.AddressLine1;
                objtblUserFamilyInfoKin.AddressLine2 = objFamilyInfoKin.AddressLine2;
                objtblUserFamilyInfoKin.CityID = objFamilyInfoKin.City;
                objtblUserFamilyInfoKin.StateID = objFamilyInfoKin.State;
                objtblUserFamilyInfoKin.CountryID = objFamilyInfoKin.Country;
                objtblUserFamilyInfoKin.MobileNo = objFamilyInfoKin.MobileNo;
                objtblUserFamilyInfoKin.EmailID = objFamilyInfoKin.EmailID;
                objtblUserFamilyInfoKin.IsKinRelative = true;
                _repositorytblUserFamilyInfo.Insert(objtblUserFamilyInfoKin);
            }
            foreach (var objDegree in objEmployeeJoining._Qualification)
            {
               // objtblUserQualificationInfo.UserID=
                objtblUserQualificationInfo.DegreeName = objDegree.DegreeName;
                objtblUserQualificationInfo.UniversityName = objDegree.University;
                objtblUserQualificationInfo.Percentageofmarks = objDegree.PercentageofMarks;
                objtblUserQualificationInfo.Division = objDegree.Division;
                objtblUserQualificationInfo.StartDate = objDegree.StartDate;
                objtblUserQualificationInfo.EndDate = objDegree.EndDate;
                objtblUserQualificationInfo.ModeofCourse = objDegree.ModeofCourse;
                objtblUserQualificationInfo.Specialization = objDegree.Specialization;
                objtblUserQualificationInfo.Mainsubject = objDegree.MainSubjects;
                _repositorytblUserQualificationInfo.Insert(objtblUserQualificationInfo);
            }
            foreach(var objhobbies in objEmployeeJoining._Hobbies)
            {
                // objtblUserExtraActivities.UserID=
                objtblUserExtraActivities.ActivityID = 1;
                objtblUserExtraActivities.ActivityName = objhobbies._Hobbies;
                
            }
            foreach (var objhobbies in objEmployeeJoining._Sports)
            {
                // objtblUserExtraActivities.UserID=
                objtblUserExtraActivities.ActivityID = 2;
                objtblUserExtraActivities.ActivityName = objhobbies._Sports;
            }
            foreach (var objhobbies in objEmployeeJoining._SpecialInterest)
            {
                // objtblUserExtraActivities.UserID=
                objtblUserExtraActivities.ActivityID = 3;
                objtblUserExtraActivities.ActivityName = objhobbies._SpecialInterest;
            }
            foreach (var objhobbies in objEmployeeJoining._Literature)
            {
                // objtblUserExtraActivities.UserID=
                objtblUserExtraActivities.ActivityID = 4;
                objtblUserExtraActivities.ActivityName = objhobbies._Literature;
            }
            foreach (var objhobbies in objEmployeeJoining._ProfessionalBodies)
            {
                // objtblUserExtraActivities.UserID=
                objtblUserExtraActivities.ActivityID = 5;
                objtblUserExtraActivities.ActivityName = objhobbies._ProfessionalBodies;
            }
            foreach (var objhobbies in objEmployeeJoining._SocialOrganisation)
            {
                // objtblUserExtraActivities.UserID=
                objtblUserExtraActivities.ActivityID = 6;
                objtblUserExtraActivities.ActivityName = objhobbies._SocialOrganisation;
            }
            foreach (var objhobbies in objEmployeeJoining._Clubs)
            {
                // objtblUserExtraActivities.UserID=
                objtblUserExtraActivities.ActivityID = 7;
                objtblUserExtraActivities.ActivityName = objhobbies._Clubs;
            }
           // objtblUserDetailsofLatestPreviousEmployment.UserID=
            objtblUserDetailsofLatestPreviousEmployment.TotalExperience = objEmployeeJoining.TotalExperience;
            objtblUserDetailsofLatestPreviousEmployment.LineExperience = objEmployeeJoining.LineExperience;
            objtblUserDetailsofLatestPreviousEmployment.OtherExperience = objEmployeeJoining.OtherExperience;
            objtblUserDetailsofLatestPreviousEmployment.Areyoupresentlyemployed = objEmployeeJoining.AreYouPresentlyEmployed;
            objtblUserDetailsofLatestPreviousEmployment.NameofEmployer = objEmployeeJoining.EmployerName;
            objtblUserDetailsofLatestPreviousEmployment.ReportingtoWhom = objEmployeeJoining.ReportingPerson;
            objtblUserDetailsofLatestPreviousEmployment.PeriodofEmployment_StartDate = objEmployeeJoining.FromPeriodofEmployment;
            objtblUserDetailsofLatestPreviousEmployment.PeriodofEmployment_EndDate = objEmployeeJoining.ToPeriodofEmployment;
            objtblUserDetailsofLatestPreviousEmployment.PositionHeldStarting = objEmployeeJoining.StartingPosition;
            objtblUserDetailsofLatestPreviousEmployment.PositionHeldLeaving = objEmployeeJoining.LeavingPosition;
            objtblUserDetailsofLatestPreviousEmployment.Department = objEmployeeJoining.Department;
            objtblUserDetailsofLatestPreviousEmployment.LatestCTCSalary = objEmployeeJoining.LatestCTC;
            objtblUserDetailsofLatestPreviousEmployment.Basic = objEmployeeJoining.BasicSalory;
            objtblUserDetailsofLatestPreviousEmployment.VDAHRA = objEmployeeJoining.HRA;
            objtblUserDetailsofLatestPreviousEmployment.Conveyance = objEmployeeJoining.Convey;
            objtblUserDetailsofLatestPreviousEmployment.Allowances = objEmployeeJoining.Allowances;
            objtblUserDetailsofLatestPreviousEmployment.Others = objEmployeeJoining.LTAExtrAllowance;
            objtblUserDetailsofLatestPreviousEmployment.Total = objEmployeeJoining.Total;
            objtblUserDetailsofLatestPreviousEmployment.ResponsibilitiesandDuties = objEmployeeJoining.Responsibilties;
            _repositorytblUserDetailsofLatestPreviousEmployment.Insert(objtblUserDetailsofLatestPreviousEmployment);
            foreach(var objPreviousEmployment in objEmployeeJoining._PreviousEmploymentDetails)
            {
               // objtblUserDetailsofPreviousEmployment.UserID=
                objtblUserDetailsofPreviousEmployment.CompanyName = objPreviousEmployment.CompanyName;
                objtblUserDetailsofPreviousEmployment.Department = objPreviousEmployment.Department;
                objtblUserDetailsofPreviousEmployment.PeriodofEmployment_StartDate = objPreviousEmployment.FromPeriodofEmployment;
                objtblUserDetailsofPreviousEmployment.PeriodofEmployment_EndDate = objPreviousEmployment.ToPeriodofEmployment;
                objtblUserDetailsofPreviousEmployment.PositionHeldStarting = objPreviousEmployment.StartingPostionHeld;
                objtblUserDetailsofPreviousEmployment.PositionHeldLeaving = objPreviousEmployment.LeavePositionHeld;
                objtblUserDetailsofPreviousEmployment.Reasonforleaving = objPreviousEmployment.ReasonOfLeaving;
                objtblUserDetailsofPreviousEmployment.LatestSalaryCTC = objPreviousEmployment.LatestCTC;
                _repositorytblUserDetailsofPreviousEmployment.Insert(objtblUserDetailsofPreviousEmployment);
            }
            foreach(var objReference in objEmployeeJoining._RefrencePerson)
            {
               // objtblUserPersonsforReference.UserID=
                objtblUserPersonsforReference.Title = objReference.title;
                objtblUserPersonsforReference.FirstName = objReference.FirstName;
                objtblUserPersonsforReference.MiddleName = objReference.MiddleName;
                objtblUserPersonsforReference.LastName = objReference.LastName;
                objtblUserPersonsforReference.JobWorkBusiness = objReference.Job;
                objtblUserPersonsforReference.Relation = objReference.Releation;
                objtblUserPersonsforReference.AddressLine1 = objReference.AddressLine1;
                objtblUserPersonsforReference.AddressLine2 = objReference.AddressLine2;
                objtblUserPersonsforReference.City = objReference.City;
                objtblUserPersonsforReference.State = objReference.State;
                objtblUserPersonsforReference.Country = objReference.Country;
                objtblUserPersonsforReference.ContactNo = objReference.MobileNO;
                objtblUserPersonsforReference.EmailID = objReference.EmailID;
                _repositorytblUserPersonsforReference.Insert(objtblUserPersonsforReference);

            }
            //  objtblUserMiscellaneousDetail.UserID=
            objtblUserMiscellaneousDetail.CRIMINAL_CASE_Details = objEmployeeJoining.AnyCriminalCase;
            objtblUserMiscellaneousDetail.material_indebtedness_Details = objEmployeeJoining.Particularsofmaterialindebtedness;
            objtblUserMiscellaneousDetail.PreviousESI_Details = objEmployeeJoining.insuredpreviouslyundertheprevisionofESI;
            objtblUserMiscellaneousDetail.Pf_No_Details = objEmployeeJoining.EPFSchemePFAccountNO;
            objtblUserMiscellaneousDetail.Details = objEmployeeJoining.AnyOtherInfo;
            objtblUserMiscellaneousDetail.SubmitDate = objEmployeeJoining.SelfDeclarationDate;
            objtblUserMiscellaneousDetail.SubmitPlace = objEmployeeJoining.DeclarationPlace;
            _repositorytblUserMiscellaneousDetail.Insert(objtblUserMiscellaneousDetail);
        }
    }
}