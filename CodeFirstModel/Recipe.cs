using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodeFirstModel
{
	public class Recipe
	{
		public string Headnote { get; set; }

		public int RecipeId { get; set; }
		public string RecipeName { get; set; }
		public string Source { get; set; }

		public List<RecipeStep> Steps { get; set; }
		public List<RecipeIngredient> Ingredients { get; set; }
	}
}
