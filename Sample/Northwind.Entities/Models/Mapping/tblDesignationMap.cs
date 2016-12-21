using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Northwind.Entities.Models.Mapping
{
    public class tblDesignationMap : EntityTypeConfiguration<tblDesignation>
    {
        public tblDesignationMap() : this("dbo") { }

        public tblDesignationMap(string schema)
        {
            ToTable(schema + ".tblDesignation");
            HasKey(x => new { });

            Property(x => x.ID)
                .HasColumnName("ID")
                .IsOptional()
                .HasColumnType("int")
                ;
            Property(x => x.Designation)
                .HasColumnName("Designation")
                .IsOptional()
                .HasColumnType("nvarchar")
                .HasMaxLength(250)
                ;

        }
    }
}
