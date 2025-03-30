using CountryTracker.Application.Interfaces;
using CountryTracker.Core.Entities;

namespace CountryTracker.Application.Helpers
{
	internal static class FakeDataHelper
	{
		internal static void AddFakeData(this IApplicationContext db)
		{
			try
			{
				Country country1 = new Country()
				{
					Name = "France",
					Code = "FRA",
					Region = "Western Europe",
					Flag = "https://flagcdn.com/w320/fr.png",
					Map = "https://goo.gl/maps/g7QxxSFsWyTPKuzd7"
				};
				Country country2 = new Country()
				{
					Name = "Japan",
					Code = "JPN",
					Region = "Eastern Asia",
					Flag = "https://flagcdn.com/w320/jp.png",
					Map = "https://goo.gl/maps/NGTLSCSrA8bMrvnX9"
				};
				Country country3 = new Country()
				{
					Name = "Thailand",
					Code = "THA",
					Region = "South-Eastern Asia",
					Flag = "https://flagcdn.com/w320/th.png",
					Map = "https://goo.gl/maps/qeU6uqsfW4nCCwzw9"
				};

				db.Countries.Add(country1);
				db.Countries.Add(country2);
				db.Countries.Add(country3);
				db.SaveChanges();

				Trip trip1 = new Trip()
				{
					CountryId = country1.Id,
					Year = new DateTime(1991, 01, 01),
					Comment = "From birth"
				};
				Trip trip2 = new Trip()
				{
					CountryId = country2.Id,
					Year = new DateTime(2022, 09, 01),
					Comment = "Working holiday"
				};
				Trip trip3 = new Trip()
				{
					CountryId = country1.Id,
					Year = new DateTime(2024, 07, 01),
					Comment = "Family holiday"
				};
				Trip trip4 = new Trip()
				{
					CountryId = country3.Id,
					Year = new DateTime(2025, 03, 01),
					Comment = "Annual leaves"
				};
				db.Trips.Add(trip1);
				db.Trips.Add(trip2);
				db.Trips.Add(trip3);
				db.Trips.Add(trip4);
				db.SaveChanges();
			}
			catch (Exception)
			{
			}
		}
	}
}