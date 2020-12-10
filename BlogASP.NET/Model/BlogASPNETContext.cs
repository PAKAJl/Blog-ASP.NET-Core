using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace BlogASP.NET.Model
{
    public partial class BlogASPNETContext : DbContext
    {
        public BlogASPNETContext()
        {
        }

        public BlogASPNETContext(DbContextOptions<BlogASPNETContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Comment> Comment { get; set; }
        public virtual DbSet<Post> Post { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=DESKTOP-NMR6CUR\\SQLEXPRESS;Database=BlogASP.NET;Trusted_Connection=True;MultipleActiveResultSets=true");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Comment>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.AuthorId).HasColumnName("AuthorID");

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.Text).IsUnicode(false);
            });

            modelBuilder.Entity<Post>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.AuthorId).HasColumnName("AuthorID");

                entity.Property(e => e.Id).ValueGeneratedOnAdd();
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
