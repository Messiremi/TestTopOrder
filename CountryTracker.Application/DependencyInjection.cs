using CountryTracker.Application.Business;
using CountryTracker.Application.Helpers;
using CountryTracker.Application.Interfaces;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountryTracker.Application
{
	public static class DependencyInjection
	{
		public static IServiceCollection AddApplication(this IServiceCollection services)
		{
			// fake data
			var serviceProvider = services.BuildServiceProvider();
			serviceProvider.GetRequiredService<IApplicationContext>().AddFakeData();

			// business features
			services.AddScoped<AddTripFeature>();
			services.AddScoped<DeleteTripFeature>();
			services.AddScoped<EditTripFeature>();
			services.AddScoped<GetAllTripsFeature>();
			services.AddScoped<GetTrackedCountriesFeature>();
			services.AddScoped<GetTripFeature>();

			return services;
		}
	}
}
