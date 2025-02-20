using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EF01_ITI.Configuration;
using EF01_ITI.Entities;
using Microsoft.EntityFrameworkCore;

namespace EF01_ITI.Contexts
{
    class AppDBContext : DbContext
    {

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            #region Fluent API
            //modelBuilder.Entity<Instructor>().HasKey(I => I.Id);
            //modelBuilder.Entity<Instructor>()
            //    .Property(I => I.Name).IsRequired();
            //modelBuilder.Entity<Instructor>()
            //    .Property(I => I.Address).HasDefaultValue("cairo");
            //modelBuilder.Entity<Instructor>().Property(I => I.Salary).HasColumnType("money");
            //modelBuilder.Entity<Instructor>(I =>
            //{
            //    I.HasKey(I => I.Id);
            //    I.Property(I => I.Name).IsRequired();
            //    I.Property(I => I.Address).HasDefaultValue("cairo");
            //    I.Property(I => I.Salary).HasColumnType("money");
            //}); 
            #endregion

            modelBuilder.ApplyConfiguration(new InstructorConfiguration());

            base.OnModelCreating(modelBuilder);
        }

        public AppDBContext() : base()
        {
            
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server = .; Database = EF_ITI; Trusted_Connection = True; TrustServerCertificate = True");
        }

        public DbSet<Student> Students { get; set; }
        public DbSet<Course> courses { get; set; }
        public DbSet<Topic> topics { get; set; }
        public DbSet<Stud_Course> Student_Courses { get; set; }
        public DbSet<Department> departments { get; set; }
        public DbSet<Course_Inst> course_Insts { get; set; }
    }
}
