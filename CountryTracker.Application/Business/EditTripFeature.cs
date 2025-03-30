using CountryTracker.Application.Interfaces;
using CountryTracker.Core.Entities;
using CountryTracker.Core.Models;

namespace CountryTracker.Application.Business
{
	public class EditTripFeature
	{
		private readonly IApplicationDbContextFactory _dbFactory;

		public EditTripFeature(IApplicationDbContextFactory dbFactory)
		{
			_dbFactory = dbFactory;
		}

		/// <summary>
		/// Edit a trip
		/// </summary>
		/// <param name="tripToUpdate"></param>
		/// <returns></returns>
		public int Execute(TripModel tripToUpdate)
		{
			using (var _db = _dbFactory.CreateDbContext())
			{
				try
				{
					// check data
					Trip? trip = _db.Trips.FirstOrDefault(r => r.Id == tripToUpdate.Id);
					if (trip == null)
					{
						return 0;
					}

					trip.Comment = tripToUpdate.Comment;
					trip.Year = tripToUpdate.Year;
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