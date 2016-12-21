using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Northwind.Entities.Models.Mapping
{
    public class tblDivisionMap : EntityTypeConfiguration<tblDivision>
    {
        public tblDivisionMap() : this("dbo") { }

        public tblDivisionMap(string schema)
        {
            ToTable(schema + ".tblDivision");
            HasKey(x => new { });

            Property(x => x.ID)
                .HasColumnName("ID")
                .IsOptional()
                .HasColumnType("int")
                ;
            Property(x => x.Division)
                .HasColumnName("Division")
                .IsOptional()
                .HasColumnType("nvarchar")
                .HasMaxLength(250)
                ;

        }
    }
}
