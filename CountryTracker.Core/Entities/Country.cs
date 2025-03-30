using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CountryTracker.Core.Entities
{
	[Table("Country")]
	public class Country
	{
		[Key]
		[Column("Id")]
		public int Id { get; set; }
		[Column("Name")]
		public string Name { get; set; } = string.Empty;
		[Column("Code")]
		public string Code { get; set; } = string.Empty;
		[Column("Region")]
		public string Region { get; set; } = string.Empty;
		[Column("FlagUrl")]
		public string Flag { get; set; } = string.Empty;
		[Column("MapUrl")]
		public string Map { get; set; } = string.Empty;
	}
}