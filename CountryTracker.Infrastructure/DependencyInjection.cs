using CountryTracker.Application.Interfaces;
using CountryTracker.Infrastructure.Api;
using CountryTracker.Infrastructure.Database;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace CountryTracker.Infrastructure
{
	public static class DependencyInjection
	{
		public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
		{
			// databases
			services.AddDbContext<IApplicationContext, ApplicationContext>(options => options.UseInMemoryDatabase("CountryTracker"));
			services.AddDbContextFactory<ApplicationContext>(options =>options.UseInMemoryDatabase("CountryTracker"), ServiceLifetime.Scoped);
			//services.AddSingleton<IApplicationContext, ApplicationContext>();
			services.AddScoped<IApplicationDbContextFactory, ApplicationDbContextFactory<ApplicationContext>>();

			// api
			services.AddHttpClient<ICountriesApi, CountriesApi>(client =>
			{
				client.BaseAddress = new Uri(configuration.GetValue<string>("Api:CountriesApi") ?? "");
			});

			return services;
		}
	}
}