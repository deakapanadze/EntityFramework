﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace EFEasyExample.DaraModels
{
	public class Context : DbContext
	{
		public DbSet<Class> Classes { get; set; }
		public DbSet<Student> Students { get; set; }

		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			optionsBuilder.UseSqlServer(@"Data Source = ****; Initial Catalog = EFEasyExample; User ID = khatia; Password = *********");
		}
	}
}
