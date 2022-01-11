using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Entities;
using Microsoft.EntityFrameworkCore;

namespace API.Data
{
  public class DataContext : DbContext //when this class is called constructor below is called
  { 
    public DataContext(DbContextOptions options) : base(options) 
    {
    }

    public DbSet<AppUser> Users { get; set; } //Setting database to app user and calls table users
  }
}