﻿using DiscGolfRounds.ClassLibrary.Areas.Courses.Models;
using DiscGolfRounds.ClassLibrary.Areas.Players.Models;
using DiscGolfRounds.ClassLibrary.Areas.Rounds.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace DiscGolfRounds.ClassLibrary.DataAccess
{
    public class DiscGolfContext : DbContext
    {
        public DiscGolfContext() : base() { }
        public DiscGolfContext(DbContextOptions<DiscGolfContext> options) : base(options) { }

        public DbSet<Player> Players { get; set; }
        public DbSet<Hole> Holes { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<CourseVariant> CourseVariants { get; set; }
        public DbSet<Round> Rounds { get; set; }
        public DbSet<Score> Scores { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            
            modelBuilder.Entity<Course>()
                .HasMany<CourseVariant>(c => c.Variants)
                .WithOne(v => v.Course)
                .HasForeignKey(v => v.CourseId);
            

            modelBuilder.Entity<CourseVariant>()
                .HasMany(cv => cv.Holes)
                .WithOne(h => h.CourseVariant)
                .HasForeignKey(h => h.CourseVariantID);


            modelBuilder.Entity<Hole>()
                .HasOne(h => h.CourseVariant)
                .WithMany(cv => cv.Holes)
               .HasForeignKey(cv => cv.CourseVariantID);

            modelBuilder.Entity<Player>()
                 .HasMany(p => p.Rounds)
                 .WithOne(r => r.Player)
                 .HasForeignKey(r => r.PlayerID);

            modelBuilder.Entity<Score>()
                .HasOne(s=> s.Round)
                .WithMany(r=> r.Scores)
                .HasForeignKey(s=> s.RoundID);


            
        }
    }
}
