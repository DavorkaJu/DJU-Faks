using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using NBATeams.Models;

namespace NBATeams.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<NBATeams.Models.Team> Teams { get; set; }
        public DbSet<NBATeams.Models.Player> Players { get; set; }
    }
}
