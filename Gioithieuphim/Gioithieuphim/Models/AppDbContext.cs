﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Gioithieuphim.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> dbContextOptions) : base(dbContextOptions)
        {

        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Posts> Posts { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Category>().HasData(new Category { Id = 1, CategoryName = "Film" });
            modelBuilder.Entity<Category>().HasData(new Category { Id = 2, CategoryName = "Playstation" });
            modelBuilder.Entity<Category>().HasData(new Category { Id = 3, CategoryName = "Reviews" });

            modelBuilder.Entity<Posts>().HasData(new Posts
            {
                Id = 1,
                Title = "The best online game is out now!",
                Content = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Quis ipsum suspendisse ultrices gravida....",

                ImageUrl = "./img/blog/1.jpg",
                CategoryId = 1
            });
            modelBuilder.Entity<Posts>().HasData(new Posts
            {
                Id = 2,
                Title = "Top 5 best film in november",
                Content = "Ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Quis ipsum labore suspendisse ultrices gravida....",

                ImageUrl = "./img/blog/2.jpg",
                CategoryId = 2
            });



            modelBuilder.Entity<Posts>().HasData(new Posts
            {
                Id = 3,
                Title = "The best online game is out now!",
                Content = "Sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Quis ipsum suspendisse ultrices gravida ncididunt ut labore ....",

                ImageUrl = "./img/blog/3.jpg",
                CategoryId = 3
            });

            /*      modelBuilder.Entity<ProductTag>().HasKey(protag => new { protag.ProductId, protag.TagId });
                  //seeder data tag
                  modelBuilder.Entity<Tag>().HasData(new Tag
                  {
                      Id = 1,
                      Name = "Rẻ",
                  });
                  modelBuilder.Entity<Tag>().HasData(new Tag
                  {
                      Id = 2,
                      Name = "Ngon",
                  });
                  modelBuilder.Entity<Tag>().HasData(new Tag
                  {
                      Id = 3,
                      Name = "Bổ khỏe",
      */



        }
    }
}
