using CodeFirstModel;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstDataAccess
{
	class RecipeContext : DbContext
	{
		public <DbSet<Recipe> Recipes { get; set; }
	}
}
