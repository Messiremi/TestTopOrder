using CountryTracker.Application.Interfaces;
using CountryTracker.Core.Models.Api;

namespace CountryTracker.Infrastructure.Api
{
	public class CountriesApi : ICountriesApi
	{
		private readonly HttpClient _httpClient;

		public CountriesApi(HttpClient httpClient)
		{
			_httpClient = httpClient;
		}

		/// <summary>
		/// Search countries from a partial name
		/// </summary>
		/// <param name="name"></param>
		/// <returns></returns>
		public async Task<List<CountryTracker.Core.Models.Api.RestCountries.CountryModel>> Search(string name)
		{
			try
			{
				var response = await _httpClient.GetAsync($"name/{name}");
				response.EnsureSuccessStatusCode();
				var data = await response.Content.ReadAsStringAsync();
				return System.Text.Json.JsonSerializer.Deserialize<List<CountryTracker.Core.Models.Api.RestCountries.CountryModel>>(data) ?? new();
			}
			catch (Exception)
			{
				return new();
			}
		}

		/// <summary>
		/// Used for the random generation button
		/// </summary>
		/// <returns></returns>
		public async Task<List<CountryTracker.Core.Models.Api.RestCountries.CountryModel>> GetAll()
		{
			try
			{
				var response = await _httpClient.GetAsync($"all");
				response.EnsureSuccessStatusCode();
				var data = await response.Content.ReadAsStringAsync();
				return System.Text.Json.JsonSerializer.Deserialize<List<CountryTracker.Core.Models.Api.RestCountries.CountryModel>>(data) ?? new();
			}
			catch (Exception)
			{
				return new();
			}
		}
	}
}