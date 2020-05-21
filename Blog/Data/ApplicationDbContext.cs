using System;
using System.Collections.Generic;
using System.Text;
using Blog.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Blog.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
            Database.EnsureCreated();
        }

        public virtual DbSet<ApplicationUser> ApplicationUsers { get; set; }
        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<Comment> Comments { get; set; }
        public virtual DbSet<Post> Posts { get; set; }
        public virtual DbSet<MessageModel> Messages { get; set; }
        public virtual DbSet<File> Files { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            //Fluent API to establish relationship between tables in DataBase

            builder.Entity<Category>()
                .HasOne(c => c.ApplicationUser)
                .WithMany(au => au.Categories)
                .HasForeignKey(c => c.UserId);

            builder.Entity<Post>()
                .HasOne(p => p.Category)
                .WithMany(c => c.Posts)
                .HasForeignKey(c => c.CategoryId);

            builder.Entity<Post>()
               .HasOne(p => p.ApplicationUser)
               .WithMany(au => au.Posts)
               .HasForeignKey(p => p.UserId);

            builder.Entity<Comment>()
                .HasOne(c => c.ApplicationUser)
                .WithMany(au => au.Comments)
                .HasForeignKey(c => c.UserId);

            builder.Entity<Comment>()
                .HasOne(c => c.Post)
                .WithMany(p => p.Comments)
                .HasForeignKey(c => c.PostId);

            builder.Entity<MessageModel>()
                .HasOne<ApplicationUser>(a => a.Sender)
                .WithMany(d => d.Messages)
                .HasForeignKey(d => d.UserId);
        }
    }
}
