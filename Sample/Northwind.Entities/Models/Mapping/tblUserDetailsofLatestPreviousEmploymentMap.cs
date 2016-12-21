using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Northwind.Entities.Models.Mapping
{
    public class tblUserDetailsofLatestPreviousEmploymentMap : EntityTypeConfiguration<tblUserDetailsofLatestPreviousEmployment>
    {
        public tblUserDetailsofLatestPreviousEmploymentMap() : this("dbo") { }

        public tblUserDetailsofLatestPreviousEmploymentMap(string schema)
        {
            ToTable(schema + ".tblUserDetailsofLatestPreviousEmployment");
            HasKey(x => new { });

            Property(x => x.ID)
                .HasColumnName("ID")
                .IsOptional()
                .HasColumnType("int")
                ;
            Property(x => x.UserID)
                .HasColumnName("UserID")
                .IsOptional()
                .HasColumnType("int")
                ;
            Property(x => x.TotalExperience)
                .HasColumnName("TotalExperience")
                .IsOptional()
                .HasColumnType("float")
                ;
            Property(x => x.LineExperience)
                .HasColumnName("LineExperience")
                .IsOptional()
                .HasColumnType("float")
                ;
            Property(x => x.OtherExperience)
                .HasColumnName("OtherExperience")
                .IsOptional()
                .HasColumnType("float")
                ;
            Property(x => x.Areyoupresentlyemployed)
                .HasColumnName("Areyoupresentlyemployed")
                .IsOptional()
                .HasColumnType("bit")
                
                ;
            Property(x => x.NameofEmployer)
                .HasColumnName("NameofEmployer")
                .IsOptional()
                .HasColumnType("nvarchar")
                .HasMaxLength(150)
                ;
            Property(x => x.ReportingtoWhom)
                .HasColumnName("ReportingtoWhom")
                .IsOptional()
                .HasColumnType("nvarchar")
                .HasMaxLength(150)
                ;
            Property(x => x.PeriodofEmployment_StartDate)
                .HasColumnName("PeriodofEmployment-StartDate")
                .IsOptional()
                .HasColumnType("datetime")
                ;
            Property(x => x.PeriodofEmployment_EndDate)
                .HasColumnName("PeriodofEmployment-EndDate")
                .IsOptional()
                .HasColumnType("datetime")
                ;
            Property(x => x.PositionHeldStarting)
                .HasColumnName("PositionHeldStarting")
                .IsOptional()
                .HasColumnType("nvarchar")
                .HasMaxLength(250)
                ;
            Property(x => x.PositionHeldLeaving)
                .HasColumnName("PositionHeldLeaving")
                .IsOptional()
                .HasColumnType("nvarchar")
                .HasMaxLength(250)
                ;
            Property(x => x.Department)
                .HasColumnName("Department")
                .IsOptional()
                .HasColumnType("nvarchar")
                .HasMaxLength(150)
                ;
            Property(x => x.LatestCTCSalary)
                .HasColumnName("LatestCTCSalary")
                .IsOptional()
                .HasColumnType("float")
                ;
            Property(x => x.Basic)
                .HasColumnName("Basic")
                .IsOptional()
                .HasColumnType("float")
                ;
            Property(x => x.VDAHRA)
                .HasColumnName("VDAHRA")
                .IsOptional()
                .HasColumnType("float")
                ;
            Property(x => x.Conveyance)
                .HasColumnName("Conveyance")
                .IsOptional()
                .HasColumnType("float")
                ;
            Property(x => x.Allowances)
                .HasColumnName("Allowances")
                .IsOptional()
                .HasColumnType("float")
                ;
            Property(x => x.Others)
                .HasColumnName("Others")
                .IsOptional()
                .HasColumnType("float")
                ;
            Property(x => x.Total)
                .HasColumnName("Total")
                .IsOptional()
                .HasColumnType("float")
                ;
            Property(x => x.ResponsibilitiesandDuties)
                .HasColumnName("ResponsibilitiesandDuties")
                .IsOptional()
                .HasColumnType("nvarchar")
                .HasMaxLength(500)
                ;

        }
    }
}
