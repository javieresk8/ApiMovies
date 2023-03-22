using System;
using ApiMovies.Models;
using Microsoft.EntityFrameworkCore;

namespace ApiMovies.Data
{
	public class ApplicationDbContext: DbContext
	{
		// Inyección de dependencias, herede todos los méthods en el constructor
		public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options): base(options)
		{

		}

		// Aqui debemos tener cada uno de nuestros modelos
		// Desde aquí toma las clases para realizar las migraciones
		public DbSet<Category> Category { get; set; }

	}
}

