using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Liftoff.Models;

namespace Liftoff.Data
{
    public class AccountDbContext : DbContext
    {
        public DbSet<Account> Accounts { get; set; }

        public DbSet<TrackingSheet> TrackingSheets { get; set; }

        public AccountDbContext(DbContextOptions<AccountDbContext> options)
            : base(options)
        { }
    }
}
