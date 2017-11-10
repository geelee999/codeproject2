namespace codeproject2.Database
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class EntityModel : DbContext
    {
        public EntityModel()
            : base("name=EntityModel")
        {
        }

        public virtual DbSet<Comment> Comments { get; set; }
        public virtual DbSet<Newsletter> Newsletters { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<Comment>()
            //    .Property(e => e.Content)
            //    .HasMaxLength(4096);
        }
    }
}
