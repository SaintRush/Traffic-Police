using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace Traffic_Police
{
    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=Model12")
        {
        }

        public virtual DbSet<Drivers> Drivers { get; set; }
        public virtual DbSet<Users> Users { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Drivers>()
                .Property(e => e.Photo)
                .IsUnicode(false);

            modelBuilder.Entity<Users>()
                .Property(e => e.role)
                .IsFixedLength();
        }
    }
}
