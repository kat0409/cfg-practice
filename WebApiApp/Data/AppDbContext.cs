using Microsoft.EntityFrameworkCore;
using System;
using WebApiApp.Models;

namespace WebApiApp.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options)
        {
        }
    }
}
