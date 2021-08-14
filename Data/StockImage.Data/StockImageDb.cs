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
        public StockImageDb(DbContextOptions<StockImageDb> options)
            : base(options)
        {
        }
    }
}
