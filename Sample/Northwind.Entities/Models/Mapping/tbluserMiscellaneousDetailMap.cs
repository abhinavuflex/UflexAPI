using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Northwind.Entities.Models.Mapping
{
    public class tblUserMiscellaneousDetailMap : EntityTypeConfiguration<tblUserMiscellaneousDetail>
    {
        public tblUserMiscellaneousDetailMap() : this("dbo") { }

        public tblUserMiscellaneousDetailMap(string schema)
        {
            ToTable(schema + ".tblUserMiscellaneousDetail");
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
            Property(x => x.ANY_CRIMINAL_CASE)
                .HasColumnName("ANY_CRIMINAL_CASE")
                .IsOptional()
                .HasColumnType("nvarchar")
                .HasMaxLength(30)
                ;
            Property(x => x.CRIMINAL_CASE_Details)
                .HasColumnName("CRIMINAL_CASE_Details")
                .IsOptional()
                .HasColumnType("nvarchar")
                .HasMaxLength(500)
                ;
            Property(x => x.material_indebtedness)
                .HasColumnName("material_indebtedness")
                .IsOptional()
                .HasColumnType("nvarchar")
                .HasMaxLength(30)
                ;
            Property(x => x.material_indebtedness_Details)
                .HasColumnName("material_indebtedness_Details")
                .IsOptional()
                .HasColumnType("nvarchar")
                .HasMaxLength(500)
                ;
            Property(x => x.PreviousESI)
                .HasColumnName("Previou_ ESI")
                .IsOptional()
                .HasColumnType("nvarchar")
                .HasMaxLength(30)
                ;
            Property(x => x.PreviousESI_Details)
                .HasColumnName("Previou_ ESI_Details")
                .IsOptional()
                .HasColumnType("nvarchar")
                .HasMaxLength(500)
                ;
            Property(x => x.Have_Pf_No)
                .HasColumnName("Have_Pf_No")
                .IsOptional()
                .HasColumnType("nvarchar")
                .HasMaxLength(30)
                ;
            Property(x => x.Pf_No_Details)
                .HasColumnName("Pf_No_Details")
                .IsOptional()
                .HasColumnType("nvarchar")
                .HasMaxLength(240)
                ;
            Property(x => x.Anyotherinformation)
                .HasColumnName("Anyotherinformation")
                .IsOptional()
                .HasColumnType("nvarchar")
                .HasMaxLength(30)
                ;
            Property(x => x.Details)
                .HasColumnName("Details")
                .IsOptional()
                .HasColumnType("nvarchar")
                .HasMaxLength(500)
                ;
            Property(x => x.SubmitDate)
                .HasColumnName("SubmitDate")
                .IsOptional()
                .HasColumnType("datetime")
                ;
            Property(x => x.SubmitPlace)
                .HasColumnName("SubmitPlace")
                .IsOptional()
                .HasColumnType("nvarchar")
                .HasMaxLength(240)
                ;

        }
    }
}
