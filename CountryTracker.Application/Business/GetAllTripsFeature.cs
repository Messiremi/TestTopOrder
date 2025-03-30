using CountryTracker.Application.Interfaces;
using CountryTracker.Core.Models;
using Microsoft.EntityFrameworkCore;

namespace CountryTracker.Application.Business
{
	public class GetAllTripsFeature
	{
		private readonly IApplicationDbContextFactory _dbFactory;

		public GetAllTripsFeature(IApplicationDbContextFactory dbFactory)
		{
			_dbFactory = dbFactory;
		}

		/// <summary>
		/// Get all trips
		/// </summary>
		/// <returns></returns>
		public List<TripModel> Execute()
		{
			List<TripModel> result = new List<TripModel>();
			using (var _db = _dbFactory.CreateDbContext())
			{
				_db.Trips.Include(r => r.Country).ToList().ForEach(r =>
				{
					result.Add(new TripModel()
					{
						Id = r.Id,
						CountryName = r.Country?.Name ?? string.Empty,
						CountryFlag = r.Country?.Flag ?? string.Empty,
						Comment = r.Comment,
						Year = r.Year
					});
				});
				return result;
			}
		}
	}
}