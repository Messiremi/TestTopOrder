using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CountryTracker.Core.Entities
{
	[Table("Trip")]
	public class Trip
	{
		[Key]
		[Column("Id")]
		public int Id { get; set; }

		[Column("CountryId")]
		public int CountryId { get; set; }

		[ForeignKey("CountryId")]
		public virtual Country? Country { get; set; }

		[Column("Year")]
		public DateTime Year { get; set; } = DateTime.Today;

		[Column("Comment")]
		public string Comment { get;set; } = string.Empty;
	}
}