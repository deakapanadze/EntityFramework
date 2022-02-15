using System.ComponentModel.DataAnnotations;
using EFEasyExample.Enums;

namespace EFEasyExample.DaraModels
{
	public class Class
	{

		public int ClassID { get; set; }
		[MaxLength(50)]
		public string ClassName { get; set; }
		[Required]
		public int MaxClassSize { get; set; }
		public Language ClassLanguage { get; set; }

	}
}