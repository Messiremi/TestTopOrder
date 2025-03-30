using CountryTracker.Core.Models.Api;

namespace CountryTracker.Application.Interfaces
{
	public interface ICountriesApi
	{
		/// <summary>
		/// Search countries from a partial name
		/// </summary>
		/// <param name="name"></param>
		/// <returns></returns>
		Task<List<CountryTracker.Core.Models.Api.RestCountries.CountryModel>> Search(string name);

		/// <summary>
		/// Used for the random generation button
		/// </summary>
		/// <returns></returns>
		Task<List<CountryTracker.Core.Models.Api.RestCountries.CountryModel>> GetAll();
	}
}