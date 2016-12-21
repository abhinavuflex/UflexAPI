using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Northwind.Entities.Models.Mapping
{
    public class tblDepartmentMapping : EntityTypeConfiguration<tblDepartment>
    {
        public tblDepartmentMapping() : this("dbo") { }

        public tblDepartmentMapping(string schema)
        {
            ToTable(schema + ".tblDepartment");
            HasKey(x => new { });

            Property(x => x.ID)
                .HasColumnName("ID")
                .IsOptional()
                .HasColumnType("int")
                ;
            Property(x => x.Department)
                .HasColumnName("Department")
                .IsOptional()
                .HasColumnType("nvarchar")
                .HasMaxLength(250)
                ;

        }
    }
}
