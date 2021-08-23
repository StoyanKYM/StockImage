using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using StockImage.Data.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace StockImage.Web.Data
{
    public class StockImageDb : IdentityDbContext<StockImageUser, IdentityRole, string>
    {
        public DbSet<Image> Images { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public StockImageDb(DbContextOptions<StockImageDb> options)
            : base(options)
        {
        }
    }
}
