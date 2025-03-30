using System.Text.Json.Serialization;

namespace CountryTracker.Core.Models.Api.RestCountries
{
	/// <summary>
	/// Class to modelize RestCountries api returns
	/// </summary>
	public class CountryModel
	{
		[JsonPropertyName("name")]
		public CountryNameModel Name { get; set; } = new CountryNameModel();
		[JsonPropertyName("cca3")]
		public string CountryCode { get; set; } = string.Empty;
		[JsonPropertyName("subregion")]
		public string Region { get; set; } = string.Empty;
		[JsonPropertyName("maps")]
		public CountryMapsModel Maps { get; set; } = new CountryMapsModel();
		[JsonPropertyName("flags")]
		public CountryFlagsModel Flags { get; set; } = new CountryFlagsModel();
	}
}