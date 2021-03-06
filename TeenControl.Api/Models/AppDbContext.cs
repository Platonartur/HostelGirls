using GirlsRanking.Girls;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TeenControl.Api.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options): base(options)
        {

        }
        public DbSet<Teen> Teens { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Teen>().HasData(new Teen
            {
                Number = 0,
                Id = "https://vk.com/id412379471",
                Name = "Aurora Redfield",
                Img = "images/Amaliya.jpg",
                ImgName = "images/Amaliya.jpg".Remove("images/Amaliya.jpg".Length - 4),
                TeenId = 1
            });
            modelBuilder.Entity<Teen>().HasData(new Teen
            {
                Number = 0,
                Id = "https://vk.com/lellap",
                Name = "Elena Popovskikh",
                Img = "images/Sofia_kolotilina.jpg",
                ImgName = "images/Sofia_kolotilina.jpg".Remove("images/Sofia_kolotilina.jpg".Length - 4),
                TeenId = 2
            });
            modelBuilder.Entity<Teen>().HasData(new Teen
            {
                Number = 0,
                Id = "https://vk.com/die_young_my_baby",
                Name = "Anya Shelk",
                Img = "images/TopTelka.jpg",
                ImgName = "images/TopTelka.jpg".Remove("images/TopTelka.jpg".Length - 4),
                TeenId = 3
            });
            modelBuilder.Entity<Teen>().HasData(new Teen
            {
                Number = 0,
                Id = "",
                Name = "noname",
                Img = "images/DaryaAfanasieva.jpg",
                ImgName = "images/DaryaAfanasieva.jpg".Remove("images/DaryaAfanasieva.jpg".Length - 4),
                TeenId = 4
            });

        }
    }
}
