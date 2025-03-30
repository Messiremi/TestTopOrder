using Microsoft.EntityFrameworkCore;

namespace CountryTracker.Application.Interfaces
{
	public interface IApplicationDbContextFactory
	{
		IApplicationContext CreateDbContext();
	}
}