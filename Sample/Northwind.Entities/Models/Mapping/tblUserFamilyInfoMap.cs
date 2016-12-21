using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Northwind.Entities.Models.Mapping
{
    public class tblUserFamilyInfoMapping : EntityTypeConfiguration<tblUserFamilyInfo>
    {
        public tblUserFamilyInfoMapping() : this("dbo") { }

        public tblUserFamilyInfoMapping(string schema)
        {
            ToTable(schema + ".tblUserFamilyInfo");
            HasKey(x => new { });

            Property(x => x.ID)
                .HasColumnName("ID")
                .IsRequired()
                .HasColumnType("int")
                ;
            Property(x => x.UserID)
                .HasColumnName("UserID")
                .IsOptional()
                .HasColumnType("int")
                ;
            Property(x => x.Title)
                .HasColumnName("Title")
                .IsOptional()
                .HasColumnType("int")
                                ;
            Property(x => x.FirstName)
                .HasColumnName("FirstName")
                .IsOptional()
                .HasColumnType("nvarchar")
                .HasMaxLength(150)
                ;
            Property(x => x.MiddleName)
                .HasColumnName("MiddleName")
                .IsOptional()
                .HasColumnType("nvarchar")
                .HasMaxLength(150)
                ;
            Property(x => x.LastName)
                .HasColumnName("LastName")
                .IsOptional()
                .HasColumnType("nvarchar")
                .HasMaxLength(150)
                ;
            Property(x => x.Relation)
                .HasColumnName("Relation")
                .IsOptional()
                .HasColumnType("int")
                
                ;
            Property(x => x.Occupation)
                .HasColumnName("Occupation")
                .IsOptional()
                .HasColumnType("int")
               
                ;
            Property(x => x.Age)
                .HasColumnName("Age")
                .IsOptional()
                .HasColumnType("nvarchar")
                .HasMaxLength(30)
                ;
            Property(x => x.DatofBirth)
                .HasColumnName("DatofBirth")
                .IsOptional()
                .HasColumnType("datetime")
                ;
            Property(x => x.WetherResidingwithYou)
                .HasColumnName("WetherResidingwithYou")
                .IsOptional()
                .HasColumnType("nvarchar")
                .HasMaxLength(30)
                ;
            Property(x => x.AddressLine1)
                .HasColumnName("AddressLine1")
                .IsOptional()
                .HasColumnType("nvarchar")
                .HasMaxLength(240)
                ;
            Property(x => x.AddressLine2)
                .HasColumnName("AddressLine2")
                .IsOptional()
                .HasColumnType("nvarchar")
                .HasMaxLength(240)
                ;
            Property(x => x.CityID)
                .HasColumnName("CityID")
                .IsOptional()
                .HasColumnType("int")
            
                ;
            Property(x => x.StateID)
                .HasColumnName("StateID")
                .IsOptional()
                .HasColumnType("int")
              
                ;
            Property(x => x.CountryID)
                .HasColumnName("CountryID")
                .IsOptional()
                .HasColumnType("int")
           
                ;
            Property(x => x.PostalCode)
                .HasColumnName("PostalCode")
                .IsOptional()
                .HasColumnType("nvarchar")
                .HasMaxLength(30)
                ;
            Property(x => x.ContactNo)
                .HasColumnName("ContactNo")
                .IsOptional()
                .HasColumnType("nvarchar")
                .HasMaxLength(60)
                ;
            Property(x => x.EmailID)
                .HasColumnName("EmailID")
                .IsOptional()
                .HasColumnType("nvarchar")
                .HasMaxLength(240)
                ;
            Property(x => x.MobileNo)
                .HasColumnName("MobileNo")
                .IsOptional()
                .HasColumnType("int")
               
                ;
            Property(x => x.IsKinRelative)
                .HasColumnName("IsKinRelative")
                .IsOptional()
                .HasColumnType("bit")
                
                ;

        }
    }
}
