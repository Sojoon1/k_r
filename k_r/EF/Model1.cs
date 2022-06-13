using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace k_r.EF
{
    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=Model1")
        {
        }

        public virtual DbSet<Groups> Groups { get; set; }
        public virtual DbSet<Listener> Listener { get; set; }
        public virtual DbSet<Role> Role { get; set; }
        public virtual DbSet<Schedule> Schedule { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<Users> Users { get; set; }
        public virtual DbSet<Сourses> Сourses { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Groups>()
                .HasMany(e => e.Listener)
                .WithRequired(e => e.Groups)
                .HasForeignKey(e => e.ID_Группа)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Role>()
                .HasMany(e => e.Listener)
                .WithRequired(e => e.Role)
                .HasForeignKey(e => e.ID_Role)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Role>()
                .HasMany(e => e.Users)
                .WithRequired(e => e.Role)
                .HasForeignKey(e => e.ID_Role)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Schedule>()
                .HasMany(e => e.Groups)
                .WithRequired(e => e.Schedule)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Сourses>()
                .HasMany(e => e.Listener)
                .WithRequired(e => e.Сourses)
                .HasForeignKey(e => e.ID_Курсы)
                .WillCascadeOnDelete(false);
        }
    }
}
