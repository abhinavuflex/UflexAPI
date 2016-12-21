using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Northwind.Entities.Models.Mapping
{
    public class tblUserLanguageMap : EntityTypeConfiguration<tblUserLanguage>
    {
        public tblUserLanguageMap() : this("dbo") { }

        public tblUserLanguageMap(string schema)
        {
            ToTable(schema + ".tblUserLanguage");
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
            Property(x => x.LanguageID)
                .HasColumnName("LanguageID")
                .IsOptional()
                .HasColumnType("int")
                ;

        }
    }
}
