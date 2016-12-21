using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Northwind.Entities.Models.Mapping
{
    public class tblUserPersonsforReferenceMap : EntityTypeConfiguration<tblUserPersonsforReference>
    {
        public tblUserPersonsforReferenceMap() : this("dbo") { }

        public tblUserPersonsforReferenceMap(string schema)
        {
            ToTable(schema + ".tblUserPersonsforReference");
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
                .HasColumnType("nvarchar")
                .HasMaxLength(30)
                ;
            Property(x => x.JobWorkBusiness)
                .HasColumnName("JobWorkBusiness")
                .IsOptional()
                .HasColumnType("nvarchar")
                .HasMaxLength(240)
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
            Property(x => x.City)
                .HasColumnName("City")
                .IsOptional()
                .HasColumnType("int")
              
                ;
            Property(x => x.State)
                .HasColumnName("State")
                .IsOptional()
                .HasColumnType("int")
               
                ;
            Property(x => x.Country)
                .HasColumnName("Country")
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
                .HasColumnType("int")
              
                ;
            Property(x => x.EmailID)
                .HasColumnName("EmailID")
                .IsOptional()
                .HasColumnType("nvarchar")
                .HasMaxLength(60)
                ;

        }
    }
}
