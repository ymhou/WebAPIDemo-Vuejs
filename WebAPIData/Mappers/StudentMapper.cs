using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;
using WebAPIData.Entities;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebAPIData.Mappers
{
    class StudentMapper : EntityTypeConfiguration<Student>
    {
        public StudentMapper()
        {
            this.ToTable("Student");

            this.HasKey(c => c.ID);   //主键
            this.Property(c => c.ID).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);  //主键自增长
            this.Property(c => c.ID).IsRequired();

            this.Property(c => c.Name).IsRequired();     //字段非空
            this.Property(c => c.Name).HasMaxLength(10);  //设定字段最大长度

            this.Property(c => c.StuID).IsRequired();
            this.Property(c => c.StuID).HasMaxLength(20);

            this.Property(c => c.Class).IsOptional();     //字段可以为空

            this.Property(c => c.Phone).IsRequired();
            this.Property(c => c.Phone).HasMaxLength(20);
            
        }
    }
}
