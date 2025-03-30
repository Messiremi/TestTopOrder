using CountryTracker.Application.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace CountryTracker.Infrastructure.Database
{
	public class ApplicationDbContextFactory<TContext> : IApplicationDbContextFactory
	where TContext : DbContext, IApplicationContext
	{
		private readonly IDbContextFactory<TContext> _factory;

		public ApplicationDbContextFactory(IDbContextFactory<TContext> factory)
		{
			_factory = factory;
		}

		public IApplicationContext CreateDbContext() => _factory.CreateDbContext();
	}
}