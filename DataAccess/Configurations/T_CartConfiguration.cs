using Library_Models.Entities.Concret;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Configurations
{
    public class T_CartConfiguration : IEntityTypeConfiguration<T_Cart>
    {
        public void Configure(EntityTypeBuilder<T_Cart> builder)
        {
            builder.HasKey(tc => tc.Id);
            builder.Property(tc => tc.Id).ValueGeneratedOnAdd();
            builder.Property(tc => tc.DateOut).IsRequired();
            builder.Property(tc => tc.DateIn).IsRequired();

            builder.HasOne(tc => tc.Teacher)
                .WithMany(t => t.T_Carts)
                .HasForeignKey(tc => tc.TeacherId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasOne(tc => tc.Book)
                .WithMany(b => b.T_Carts)
                .HasForeignKey(tc => tc.BookId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
