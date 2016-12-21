using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using Northwind.Entities.Models.Mapping;
using Repository.Pattern.Ef6;

namespace Northwind.Entities.Models
{
    public partial class NorthwindContext : DataContext
    {
        static NorthwindContext()
        {
            Database.SetInitializer<NorthwindContext>(null);
        }

        public NorthwindContext()
            : base("Name=NorthwindContext")
        {
        }


        public DbSet<tblUser> tblUsers { get; set; }
        public DbSet<tblUserDetailsofLatestPreviousEmployment> tblUserDetailsofLatestPreviousEmployments { get; set; }
        public DbSet<tblUserDetailsofPreviousEmployment> tblUserDetailsofPreviousEmployments { get; set; }
        public DbSet<tblUserExtraActivities> tblUserExtraActivities { get; set; }
        public DbSet<tblUserFamilyInfo> tblUserFamilyInfos { get; set; }
        public DbSet<tblUserMiscellaneousDetail> tblUserMiscellaneousDetails { get; set; }
        public DbSet<tblUserPersonalDeclaration> tblUserPersonalDeclarations { get; set; }
        public DbSet<tblUserPersonsforReference> tblUserPersonsforReferences { get; set; }
        public DbSet<tblUserQualificationInfo> tblUserQualificationInfos { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {

            modelBuilder.Configurations.Add(new tblUserMap());
           


        }
    }
}
    
