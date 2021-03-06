﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CodeFirstModel;
using CodeFirstDataAccess;

namespace CodeFirstConsole
{
	class Program
	{
		static void Main( string[] args )
		{
			//Database.SetInitializer<RecipeContext>(new DropCreateDatabaseAlways<RecipeContext>());
			Database.SetInitializer<RecipeContext>(new SeededInitializer());

			using (var db = new RecipeContext())
			{
				var theRecipe = new Recipe();


				theRecipe.Headnote = "A recipe";
				theRecipe.RecipeName = "Chopped Sui";


				db.Recipes.Add(theRecipe);


				db.SaveChanges();
			}
		}
	}
}
