using CountryTracker.Application.Interfaces;
using CountryTracker.Core.Models;
using Microsoft.EntityFrameworkCore;

namespace CountryTracker.Application.Business
{
	public class GetTrackedCountriesFeature
	{
		private readonly IApplicationDbContextFactory _dbFactory;

		public GetTrackedCountriesFeature(IApplicationDbContextFactory dbFactory)
		{
			_dbFactory = dbFactory;
		}

		/// <summary>
		/// Get all countries
		/// </summary>
		/// <returns></returns>
		public List<CountryModel> Execute()
		{
			List<CountryModel> result = new List<CountryModel>();
			using (var _db = _dbFactory.CreateDbContext())
			{
				List<int> countriesVisited = _db.Trips.Select(r => r.CountryId).Distinct().ToList();
				_db.Countries.Where(r=> countriesVisited.Contains(r.Id)).ToList().ForEach(r =>
				{
					result.Add(new CountryModel()
					{
						Id = r.Id,
						Name = r.Name,
						Code = r.Code,
						Flag = r.Flag,
						Map = r.Map,
						Region = r.Region,
						TripsCount = _db.Trips.Count(s => s.CountryId == r.Id)
					});
				});
				return result;
			}
		}
	}
}