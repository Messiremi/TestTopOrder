using System.Text.Json.Serialization;

namespace CountryTracker.Core.Models.Api.RestCountries
{
	/// <summary>
	/// Class to modelize RestCountries api returns
	/// </summary>
	public class CountryNameModel
	{
		[JsonPropertyName("common")]
		public string Common { get; set; } = string.Empty;
	}
}