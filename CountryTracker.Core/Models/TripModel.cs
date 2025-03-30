namespace CountryTracker.Core.Models
{
	public class TripModel
	{
		public int Id { get; set; }
		public DateTime Year { get; set; } = DateTime.Today;
		public string Comment { get; set; } = string.Empty;
		public string CountryName { get; set; } = string.Empty;
		public string CountryFlag { get; set; } = string.Empty;
	}
}