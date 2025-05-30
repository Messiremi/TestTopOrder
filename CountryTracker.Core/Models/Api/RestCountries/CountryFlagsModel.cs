﻿using System.Text.Json.Serialization;

namespace CountryTracker.Core.Models.Api.RestCountries
{
	/// <summary>
	/// Class to modelize RestCountries api returns
	/// </summary>
	public class CountryFlagsModel
	{
		[JsonPropertyName("png")]
		public string Png { get; set; } = string.Empty;
	}
}