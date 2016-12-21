using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;


namespace Northwind.Entities.Models.Mapping
{
    public class tblUserQualificationInfoMap : EntityTypeConfiguration<tblUserQualificationInfo>
    {
        public tblUserQualificationInfoMap() : this("dbo") { }

        public tblUserQualificationInfoMap(string schema)
        {
            ToTable(schema + ".tblUserQualificationInfo");
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
            Property(x => x.DegreeName)
                .HasColumnName("DegreeName")
                .IsOptional()
                .HasColumnType("int")
              
                ;
            Property(x => x.ModeofCourse)
                .HasColumnName("ModeofCourse")
                .IsOptional()
                .HasColumnType("int")
               
                ;
            Property(x => x.UniversityName)
                .HasColumnName("UniversityName")
                .IsOptional()
                .HasColumnType("int")
            
                ;
            Property(x => x.Specialization)
                .HasColumnName("Specialization")
                .IsOptional()
                .HasColumnType("nvarchar")
                .HasMaxLength(150)
                ;
            Property(x => x.Percentageofmarks)
                .HasColumnName("Percentageofmarks")
                .IsOptional()
                .HasColumnType("int")
               
                ;
            Property(x => x.Division)
                .HasColumnName("Division")
                .IsOptional()
                .HasColumnType("int")
               
                ;
            Property(x => x.StartDate)
                .HasColumnName("StartDate")
                .IsOptional()
                .HasColumnType("datetime")
                ;
            Property(x => x.EndDate)
                .HasColumnName("EndDate")
                .IsOptional()
                .HasColumnType("datetime")
                ;
            Property(x => x.Mainsubject)
                .HasColumnName("Mainsubject")
                .IsOptional()
                .HasColumnType("nvarchar")
                .HasMaxLength(150)
                ;

        }
    }
}
