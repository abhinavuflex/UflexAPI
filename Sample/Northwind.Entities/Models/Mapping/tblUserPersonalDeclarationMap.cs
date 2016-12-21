using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Northwind.Entities.Models.Mapping
{
    public class tblUserPersonalDeclarationMapping : EntityTypeConfiguration<tblUserPersonalDeclaration>
    {
        public tblUserPersonalDeclarationMapping() : this("dbo") { }

        public tblUserPersonalDeclarationMapping(string schema)
        {
            ToTable(schema + ".tblUserPersonalDeclaration");
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
            Property(x => x.EarlierOrganizationoResignedDate)
                .HasColumnName("EarlierOrganizationoResignedDate")
                .IsOptional()
                .HasColumnType("datetime")
                ;
            Property(x => x.EarlierOrganizationRelevedDate)
                .HasColumnName("EarlierOrganizationRelevedDate")
                .IsOptional()
                .HasColumnType("datetime")
                ;
            Property(x => x.DeclerationDate)
                .HasColumnName("DeclerationDate")
                .IsOptional()
                .HasColumnType("datetime")
                ;
            Property(x => x.DeclerationPlace)
                .HasColumnName("DeclerationPlace")
                .IsOptional()
                .HasColumnType("nvarchar")
                .HasMaxLength(150)
                ;
            Property(x => x.Title_DR)
                .HasColumnName("Title_DR")
                .IsOptional()
                .HasColumnType("nvarchar")
                .HasMaxLength(30)
                ;
            Property(x => x.FirstName_DR)
                .HasColumnName("FirstName_DR")
                .IsOptional()
                .HasColumnType("nvarchar")
                .HasMaxLength(150)
                ;
            Property(x => x.MiddleName_DR)
                .HasColumnName("MiddleName_DR")
                .IsOptional()
                .HasColumnType("nvarchar")
                .HasMaxLength(150)
                ;
            Property(x => x.LastName_DR)
                .HasColumnName("LastName_DR")
                .IsOptional()
                .HasColumnType("nvarchar")
                .HasMaxLength(150)
                ;
            Property(x => x.Releation_DR)
                .HasColumnName("Releation_DR")
                .IsOptional()
                .HasColumnType("nvarchar")
                .HasMaxLength(150)
                ;

        }
    }
}
