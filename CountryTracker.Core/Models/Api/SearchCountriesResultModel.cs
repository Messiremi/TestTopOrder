namespace CountryTracker.Core.Models.Api
{
	public class SearchCountriesResultModel
	{
		public List<RestCountries.CountryModel> Countries { get; set; } = new List<RestCountries.CountryModel>();
	}
}