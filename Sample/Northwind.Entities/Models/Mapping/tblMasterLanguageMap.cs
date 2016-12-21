using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Northwind.Entities.Models.Mapping
{
    public class tblMasterLanguageMap : EntityTypeConfiguration<tblMasterLanguage>
    {
        public tblMasterLanguageMap() : this("dbo") { }

        public tblMasterLanguageMap(string schema)
        {
            ToTable(schema + ".tblMasterLanguage");
            HasKey(x => new { });

            Property(x => x.ID)
                .HasColumnName("ID")
                .IsOptional()
                .HasColumnType("int")
                ;
            Property(x => x.LanguageName)
                .HasColumnName("LanguageName")
                .IsOptional()
                .HasColumnType("nvarchar")
                .HasMaxLength(250)
                ;

        }
    }
}
