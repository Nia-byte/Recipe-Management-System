using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace poedraft
{
   public class Recipes
    {
        //Declarations
        public string Name { get; set; }
        public List<Ingredients> IngredientsList { get; set; }
        public List<Steps> StepsList { get; set; }
        // both constructors ensure that the IngredientsList and StepsList properties of the Recipe object are initialized with new instances of List<Ingredients> and List<Steps> respectively, guaranteeing that they are not null when you create a new Recipe object. The parameterized constructor additionally allows you to specify the name of the recipe during object creation.
        public Recipes(string name)
        {
            Name = name;
            IngredientsList = new List<Ingredients>();
            StepsList = new List<Steps>();
        }

        public Recipes()
        {
            IngredientsList = new List<Ingredients>();
            StepsList = new List<Steps>();
        }

        public int TotalCalories()
        {
            int total = 0;
            for (int i = 0; i < IngredientsList.Count; i++)
            {
                total += IngredientsList[i].Calories;
            }
            return total;
        }
    }
}
