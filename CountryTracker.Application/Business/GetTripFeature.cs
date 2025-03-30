using CountryTracker.Application.Interfaces;
using CountryTracker.Core.Models;
using Microsoft.EntityFrameworkCore;

namespace CountryTracker.Application.Business
{
	public class GetTripFeature
	{
		private readonly IApplicationDbContextFactory _dbFactory;

		public GetTripFeature(IApplicationDbContextFactory dbFactory)
		{
			_dbFactory = dbFactory;
		}

		/// <summary>
		/// Get a trip from its id
		/// </summary>
		/// <returns></returns>
		public TripModel Execute(int id)
		{
			using (var _db = _dbFactory.CreateDbContext())
			{
				var trip = _db.Trips.Include(r => r.Country).FirstOrDefault(r => r.Id == id);
				if (trip == null)
				{
					return new TripModel();
				}

				return new TripModel()
				{
					Id = id,
					Comment = trip.Comment,
					CountryFlag = trip.Country?.Flag ?? "",
					CountryName = trip.Country?.Name ?? "",
					Year = trip.Year
				};
			}
		}
	}
}