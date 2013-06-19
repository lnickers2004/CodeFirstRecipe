using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodeFirstModel
{
	public class RecipeIngredient
	{
		public int RecipeIngredientId { get; set; }
		public decimal Amount { get; set; }
		public string Preparation { get; set; }
		public string Unit { get; set; }
	}
}
