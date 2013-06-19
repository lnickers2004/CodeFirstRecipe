using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CodeFirstModel;

namespace CodeFirstDataAccess
{
	public class SeededInitializer : CreateDatabaseIfNotExists<RecipeContext>
	{
		protected override void Seed( RecipeContext context )
		{
			//create your seed data

				var theRecipe = new Recipe()
				{
					RecipeName = "Onion Rings",
					Source = "Larry Nickerson",
					Headnote = "Texas-Sized-Southern-Fried"
				};

			context.Recipes.Add(theRecipe);

			//remembrer don't call savechanges when seeding in an initializer


			base.Seed( context );
		}
	}
}
