﻿using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;



namespace ShowPulse.Models
{

    public class ShowContext : DbContext
    {
        public ShowContext() { }
        public ShowContext(DbContextOptions<ShowContext> options) : base(options) { }

        public virtual DbSet<Show> Shows { get; set; }

        public virtual DbSet<ShowInfo> ShowInfos { get; set; }
        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Show>()
                .HasOne(s => s.ShowInfo)
                .WithOne(si => si.Show)
                .HasForeignKey<ShowInfo>(si => si.ShowId); // Configure ShowId as a foreign key
        }
        
    }
}
