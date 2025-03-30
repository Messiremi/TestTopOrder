using System.Text.Json.Serialization;

namespace CountryTracker.Core.Models.Api.RestCountries
{
	/// <summary>
	/// Class to modelize RestCountries api returns
	/// </summary>
	public class CountryMapsModel
	{
		[JsonPropertyName("googleMaps")]
		public string GoogleMap { get; set; } = string.Empty;
	}
}