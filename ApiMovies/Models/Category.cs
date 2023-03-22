using System;
using System.ComponentModel.DataAnnotations;

namespace ApiMovies.Models
{
	public class Category
	{
		// Importado de DataAnnotations
		// ** Necesariamente necesitamos ponerle el nombre 'Id' para que sea
		// auto incremental**
		[Key]
		public int Id { get; set; }

		[Required]
		public string Name { get; set; }

		public DateTime CreationDate { get; set; }
	}
}

