using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Northwind.Entities.Models.Mapping
{
    public class tblUserExtraActivitiesMapping : EntityTypeConfiguration<tblUserExtraActivities>
    {
        public tblUserExtraActivitiesMapping() : this("dbo") { }

        public tblUserExtraActivitiesMapping(string schema)
        {
            ToTable(schema + ".tblUserExtraActivities");
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
            Property(x => x.ActivityID)
               .HasColumnName("ActivityID")
               .IsOptional()
               .HasColumnType("int")
               ;
            Property(x => x.ActivityName)
                .HasColumnName("ActivityName")
                .IsOptional()
                .HasColumnType("nvarchar")
                .HasMaxLength(240)
                ;

        }
    }
}
