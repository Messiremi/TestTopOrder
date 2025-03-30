using CountryTracker.Application.Interfaces;
using CountryTracker.Core.Entities;

namespace CountryTracker.Application.Business
{
	public class AddTripFeature
	{
		private readonly IApplicationDbContextFactory _dbFactory;

		public AddTripFeature(IApplicationDbContextFactory dbFactory)
		{
			_dbFactory = dbFactory;
		}

		/// <summary>
		/// Add a new trip
		/// </summary>
		/// <param name="selectedCountry"></param>
		/// <param name="date"></param>
		/// <param name="comment"></param>
		/// <returns></returns>
		public int Execute(Core.Models.Api.RestCountries.CountryModel selectedCountry, DateTime date, string comment)
		{
			using (var _db = _dbFactory.CreateDbContext())
			{
				try
				{
					// check data
					if (selectedCountry == null ||
						string.IsNullOrEmpty(selectedCountry.Name.Common) ||
						date.Year < DateTime.Now.Year - 100)
					{
						return 0;
					}

					Country? country = _db.Countries.FirstOrDefault(r => r.Name == selectedCountry.Name.Common);
					// first save country if it doesnt exist
					if (country == null)
					{
						country = new Country()
						{
							Name = selectedCountry.Name.Common,
							Code = selectedCountry.CountryCode,
							Flag = selectedCountry.Flags.Png,
							Map = selectedCountry.Maps.GoogleMap,
							Region = selectedCountry.Region
						};
						_db.Countries.Add(country);
						_db.SaveChanges();
					}

					// save trip
					if (country.Id <= 0)
					{
						return 0;
					}
					Trip trip = new Trip()
					{
						CountryId = country.Id,
						Year = date,
						Comment = comment
					};
					_db.Trips.Add(trip);
					_db.SaveChanges();
					return trip.Id;
				}
				catch (Exception)
				{
					return 0;
				}
			}
		}
	}
}