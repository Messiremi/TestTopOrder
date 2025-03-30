using CountryTracker.Application.Interfaces;
using CountryTracker.Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace CountryTracker.Infrastructure.Database
{
	public class ApplicationContext : DbContext, IApplicationContext
	{
		public DbSet<Country> Countries { get; set; }
		public DbSet<Trip> Trips { get; set; }

		public ApplicationContext()
		{

		}

		public ApplicationContext(DbContextOptions options)
		{

		}

		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			optionsBuilder.UseInMemoryDatabase("CountryTracker");
		}
	}
}
