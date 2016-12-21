using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Northwind.Entities.Models.Mapping
{
    public class tblUserAddressMapping : EntityTypeConfiguration<tblUserAddress>
    {
        public tblUserAddressMapping() : this("dbo") { }

        public tblUserAddressMapping(string schema)
        {
            ToTable(schema + ".tblUserAddress");
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
            Property(x => x.AddressLine1)
                .HasColumnName("AddressLine1")
                .IsOptional()
                .HasColumnType("nvarchar")
                .HasMaxLength(250)
                ;
            Property(x => x.AddressLine2)
                .HasColumnName("AddressLine2")
                .IsOptional()
                .HasColumnType("nvarchar")
                .HasMaxLength(250)
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
            Property(x => x.Pincode)
                .HasColumnName("Pincode")
                .IsOptional()
                .HasColumnType("int")
                ;
            Property(x => x.Pincode)
                .HasColumnName("ContactNo")
                .IsOptional()
                .HasColumnType("int")
                ;
            Property(x => x.Pincode)
                .HasColumnName("MobileNo")
                .IsOptional()
                .HasColumnType("int")
                ;
            Property(x => x.AddressLine2)
               .HasColumnName("EmailID")
               .IsOptional()
               .HasColumnType("nvarchar")
               .HasMaxLength(250)
               ;
            Property(x => x.IsPermanentAddress)
                .HasColumnName("IsPermanentAddress")
                .IsOptional()
                .HasColumnType("bit")
                ;

        }
    }
}
