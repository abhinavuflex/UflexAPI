using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Northwind.Entities.Models.Mapping
{
    public class tblUserDetailsofPreviousEmploymentMapping : EntityTypeConfiguration<tblUserDetailsofPreviousEmployment>
    {
        public tblUserDetailsofPreviousEmploymentMapping() : this("dbo") { }

        public tblUserDetailsofPreviousEmploymentMapping(string schema)
        {
            ToTable(schema + ".tblUserDetailsofPreviousEmployment");
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
            Property(x => x.CompanyName)
                .HasColumnName("CompanyName")
                .IsOptional()
                .HasColumnType("nvarchar")
                .HasMaxLength(240)
                ;
            Property(x => x.Department)
                .HasColumnName("Department")
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
                .HasMaxLength(150)
                ;
            Property(x => x.PositionHeldLeaving)
                .HasColumnName("PositionHeldLeaving")
                .IsOptional()
                .HasColumnType("nvarchar")
                .HasMaxLength(150)
                ;
            Property(x => x.Reasonforleaving)
                .HasColumnName("Reasonforleaving")
                .IsOptional()
                .HasColumnType("nvarchar")
                .HasMaxLength(150)
                ;
            Property(x => x.LatestSalaryCTC)
                .HasColumnName("LatestSalaryCTC")
                .IsOptional()
                .HasColumnType("int")               
                ;

        }
    }
}
