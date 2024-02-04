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
    public class S_CartConfiguration : IEntityTypeConfiguration<S_Cart>
    {
        public void Configure(EntityTypeBuilder<S_Cart> builder)
        {
            builder.HasKey(sc => sc.Id);
            builder.Property(sc => sc.Id).ValueGeneratedOnAdd();

            builder.Property(sc => sc.DateOut).IsRequired();
            builder.Property(sc => sc.DateIn).IsRequired();

            builder.HasOne(sc => sc.Student)
                .WithMany(s => s.S_Carts)
                .HasForeignKey(sc => sc.StudentId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasOne(sc => sc.Book)
                .WithMany(b => b.S_Carts)
                .HasForeignKey(sc => sc.BookId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
