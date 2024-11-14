using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ManagementUsers.Models;

namespace ManagementUsers.Data
{
    public class ManagementUsersContext : DbContext
    {
        public ManagementUsersContext (DbContextOptions<ManagementUsersContext> options)
            : base(options)
        {
        }

        public DbSet<ManagementUsers.Models.User> User { get; set; } = default!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {            
            modelBuilder.Entity<User>().ToTable("User");
        }
    }
}
