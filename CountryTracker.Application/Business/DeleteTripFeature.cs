using CountryTracker.Application.Interfaces;
using CountryTracker.Core.Entities;

namespace CountryTracker.Application.Business
{
	public class DeleteTripFeature
	{
		private readonly IApplicationDbContextFactory _dbFactory;

		public DeleteTripFeature(IApplicationDbContextFactory dbFactory)
		{
			_dbFactory = dbFactory;
		}

		/// <summary>
		/// Delete a trip
		/// </summary>
		/// <param name="id"></param>
		/// <returns></returns>
		public bool Execute(int id)
		{
			using (var _db = _dbFactory.CreateDbContext())
			{
				try
				{
					// check data
					Trip? trip = _db.Trips.FirstOrDefault(r => r.Id == id);
					if (trip == null)
					{
						return false;
					}

					_db.Trips.Remove(trip);
					_db.SaveChanges();

					return true;
				}
				catch (Exception)
				{
					return false;
				}
			}
		}
	}
}