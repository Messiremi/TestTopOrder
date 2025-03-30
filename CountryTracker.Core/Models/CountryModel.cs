namespace CountryTracker.Core.Models
{
	public class CountryModel
	{
		public int Id { get; set; }
		public string Name { get; set; } = string.Empty;
		public string Code { get; set; } = string.Empty;
		public string Region { get; set; } = string.Empty;
		public string Flag { get; set; } = string.Empty;
		public string Map { get; set; } = string.Empty;
		public int TripsCount { get; set; } = 0;
	}
}