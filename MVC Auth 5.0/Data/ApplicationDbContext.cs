using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using MVC_Auth_5._0.Models;

namespace MVC_Auth_5._0.Data
{
    public sealed class ApplicationDbContext : IdentityDbContext
    {
        public DbSet<Author> Authors { get; set; }
        public DbSet<Book> Books { get; set; }
        
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
            ChangeTracker.Tracked += OnEntityTracket;
        }

        private void OnEntityTracket(object? sender, EntityTrackedEventArgs e)
        {
            if (e.Entry.Entity is Book {Codes: null} book)
            {
                book.Codes = new HashSet<string>();
            }
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<Book>(b =>
            {
                b.Property(e => e.Codes).HasConversion<string>(
                    set => JsonSerializer.Serialize(set, null),
                    str => JsonSerializer.Deserialize<HashSet<string>>(str, null));
            });
        }
    }
}