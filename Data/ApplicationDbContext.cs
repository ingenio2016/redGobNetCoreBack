
using AngularASPNETCore2WebApiAuth.Models.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace AngularASPNETCore2WebApiAuth.Data
{
  public class ApplicationDbContext : IdentityDbContext<AppUser>
  {
    public ApplicationDbContext(DbContextOptions options)
        : base(options)
    {
    }

    public DbSet<Country> Countries { get; set; }
    public DbSet<Department> Departments { get; set; }
    public DbSet<City> Cities { get; set; }
    public DbSet<Genre> Genres { get; set; }
    public DbSet<User> DataUsers { get; set; }
    public DbSet<Commune> Communes { get; set; }
    public DbSet<RedUser> RedUsers { get; set; }
    public DbSet<VotingPlace> VotingPlaces { get; set; }
    public DbSet<Boss> Bosses { get; set; }
    public DbSet<Link> Links { get; set; }
    public DbSet<Coordinator> Coordinators { get; set; }
    public DbSet<Leader> Leaders { get; set; }
    public DbSet<Voter> Voters { get; set; }
  }
}
