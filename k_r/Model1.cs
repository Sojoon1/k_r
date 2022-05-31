using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace k_r
{
    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=Model11")
        {
        }

        public virtual DbSet<Autotization> Autotizations { get; set; }
        public virtual DbSet<Cours> Courses { get; set; }
        public virtual DbSet<Group> Groups { get; set; }
        public virtual DbSet<Listener> Listeners { get; set; }
        public virtual DbSet<Role> Roles { get; set; }
        public virtual DbSet<Schedule> Schedules { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<User> Users { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Cours>()
                .HasMany(e => e.Listeners)
                .WithRequired(e => e.Cours)
                .HasForeignKey(e => e.Курс)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Group>()
                .HasMany(e => e.Listeners)
                .WithRequired(e => e.Group)
                .HasForeignKey(e => e.ID_Группа)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Listener>()
                .HasMany(e => e.Users)
                .WithRequired(e => e.Listener)
                .HasForeignKey(e => e.ID_Роль)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Role>()
                .HasMany(e => e.Users)
                .WithRequired(e => e.Role)
                .HasForeignKey(e => e.ID_Роль)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Schedule>()
                .HasMany(e => e.Groups)
                .WithRequired(e => e.Schedule)
                .HasForeignKey(e => e.ID_Расписания)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<User>()
                .HasMany(e => e.Autotizations)
                .WithRequired(e => e.User)
                .HasForeignKey(e => e.IDAuth)
                .WillCascadeOnDelete(false);
        }
    }
}
