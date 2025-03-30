using CountryTracker.Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace CountryTracker.Application.Interfaces
{
	public interface IApplicationContext:IDisposable
	{
		DbSet<Country> Countries { get; }
		DbSet<Trip> Trips { get; }
		int SaveChanges();
	}
}