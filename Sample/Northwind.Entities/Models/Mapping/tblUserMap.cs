using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Northwind.Entities.Models.Mapping
{
    public class tblUserMap : EntityTypeConfiguration<tblUser>
    {
        public tblUserMap()
        {
            ToTable("tblUser");

            Property(x => x.ID)
                .HasColumnName("ID")
                .IsRequired()
                .HasColumnType("int")
                ;
            Property(x => x.Tittle)
                .HasColumnName("Tittle")
                .IsOptional()
                .HasColumnType("nvarchar")
                .HasMaxLength(30)
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
            Property(x => x.MobileNo)
                .HasColumnName("MobileNo")
                .IsOptional()
                .HasColumnType("int")
                ;
            Property(x => x.EmailID)
                .HasColumnName("EmailID")
                .IsOptional()
                .HasColumnType("nvarchar")
                .HasMaxLength(150)
                ;
            Property(x => x.DateofBirth)
                .HasColumnName("DateofBirth")
                .IsOptional()
                .HasColumnType("datetime")
                ;
            Property(x => x.Age)
                .HasColumnName("Age")
                .IsOptional()
                .HasColumnType("nvarchar")
                .HasMaxLength(100)
                ;
            Property(x => x.PlaceofBirth)
                .HasColumnName("PlaceofBirth")
                .IsOptional()
                .HasColumnType("int")
                ;
            Property(x => x.CountryofBirth)
                .HasColumnName("CountryofBirth")
                .IsOptional()
                .HasColumnType("int")
                       ;
            Property(x => x.Nationality)
                .HasColumnName("Nationality")
                .IsOptional()
                .HasColumnType("int")
               
                ;
            Property(x => x.Castreligion)
                .HasColumnName("Castreligion")
                .IsOptional()
                .HasColumnType("int")
               
                ;
            Property(x => x.Domicile)
                .HasColumnName("Domicile")
                .IsOptional()
                .HasColumnType("nvarchar")
                .HasMaxLength(100)
                ;
            Property(x => x.PassportNo)
                .HasColumnName("PassportNo")
                .IsOptional()
                .HasColumnType("nvarchar")
                .HasMaxLength(30)
                ;
            Property(x => x.Validupto)
                .HasColumnName("Validupto")
                .IsOptional()
                .HasColumnType("datetime")
                ;
            Property(x => x.PlaceofIssue)
                .HasColumnName("PlaceofIssue")
                .IsOptional()
                .HasColumnType("nvarchar")
                .HasMaxLength(30)
                ;
            Property(x => x.MaritalStatus)
                .HasColumnName("MaritalStatus")
                .IsOptional()
                .HasColumnType("int")
               
                ;
            Property(x => x.MarriageDate)
                .HasColumnName("MarriageDate")
                .IsOptional()
                .HasColumnType("datetime")
                ;
            Property(x => x.Wear_Specs)
                .HasColumnName("Wear_Specs")
                .IsOptional()
                .HasColumnType("nvarchar")
                .HasMaxLength(10)
                ;
            Property(x => x.PowerL)
                .HasColumnName("PowerL")
                .IsOptional()
                .HasColumnType("float")
                ;
            Property(x => x.PowerR)
                .HasColumnName("PowerR")
                .IsOptional()
                .HasColumnType("float")
                ;
            Property(x => x.Height_CM)
                .HasColumnName("Height_CM")
                .IsOptional()
                .HasColumnType("float")
                ;
            Property(x => x.Weight_KG)
                .HasColumnName("Weight_KG")
                .IsOptional()
                .HasColumnType("float")
                ;
            Property(x => x.BloodGroup)
                .HasColumnName("BloodGroup")
                .IsOptional()
                .HasColumnType("int")
               
                ;
            Property(x => x.TobacooUser)
                .HasColumnName("TobacooUser")
                .IsOptional()
                .HasColumnType("int")
               
                ;
            Property(x => x.HEALTH_RATE)
                .HasColumnName("HEALTH_RATE")
                .IsOptional()
                .HasColumnType("int")               
                ;
            Property(x => x.Comments)
                .HasColumnName("Comments")
                .IsOptional()
                .HasColumnType("nvarchar")
                .HasMaxLength(1000)
                ;
            Property(x => x.Markofidentification)
                .HasColumnName("Markofidentification")
                .IsOptional()
                .HasColumnType("nvarchar")
                .HasMaxLength(30)
                ;

        }
    }
}
