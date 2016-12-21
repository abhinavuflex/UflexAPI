using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Northwind.Entities.Models.Mapping
{
    public class tblEmployeeJoiningInitiateProcessMap : EntityTypeConfiguration<tblEmployeeJoiningInitiateProcess>
    {
        public tblEmployeeJoiningInitiateProcessMap() : this("dbo") { }

        public tblEmployeeJoiningInitiateProcessMap(string schema)
        {
            ToTable(schema + ".tblEmployeeJoiningInitiateProcess");
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
            Property(x => x.JoiningDate)
                .HasColumnName("JoiningDate")
                .IsOptional()
                .HasColumnType("datetime")
                ;
            Property(x => x.DivisionID)
                .HasColumnName("DivisionID")
                .IsOptional()
                .HasColumnType("int")
                ;
            Property(x => x.DesignationID)
                .HasColumnName("DesignationID")
                .IsOptional()
                .HasColumnType("int")
                ;
            Property(x => x.DepartmentID)
                .HasColumnName("DepartmentID")
                .IsOptional()
                .HasColumnType("int")
                ;
            Property(x => x.LocationID)
                .HasColumnName("LocationID")
                .IsOptional()
                .HasColumnType("int")
                ;
            Property(x => x.Created_Date)
                .HasColumnName("Created_Date")
                .IsOptional()
                .HasColumnType("datetime")
                ;

        }
    }
}
