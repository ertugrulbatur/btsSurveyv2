using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Survey2.Models;

namespace Survey2.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<AppUser> AppUser { get; set; }
        public DbSet<Question> Question { get; set; }
        public DbSet<Choice> Choice { get; set; }
        public DbSet<Annoucement> Annoucement { get; set; }
        public DbSet<Answer> Answer { get; set; }
        public DbSet<Survey> Survey { get; set; }
        public DbSet<Complaint> Complaint { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            #region User-Connections
            builder.Entity<AppUser>()
                .HasMany(a => a.Answers)
                .WithOne(b=>b.AppUser);

            builder.Entity<AppUser>()
                .HasMany(a => a.Complaints)
                .WithOne(b=>b.AppUser);

            builder.Entity<AppUser>()
                .HasMany(a => a.Questions)
                .WithOne(b=>b.AppUser);

            builder.Entity<AppUser>()
                .HasMany(a => a.Annoucements)
                .WithOne(b=>b.AppUser);

            builder.Entity<AppUser>()
                .HasMany(a => a.Surveys)
                .WithOne(b=>b.AppUser);

            #endregion
            #region Question Connection
            builder.Entity<Question>()
                .HasMany(a => a.Choices)
                .WithOne(b=>b.Question);
            #endregion
            #region Survey Connection
            builder.Entity<Survey>()
                .HasMany(a => a.Questions)
                .WithOne(b=>b.Survey);
            #endregion



            base.OnModelCreating(builder);
        }
    }
}
