using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace poedraft
{
    
    public partial class AllRecipes : Window
    {
        private List<Recipes> allRecipes;
        public Recipes currentRecipe { get; set; }
        public AllRecipes(List<Recipes> recipes, Recipes currentRecipe)
        //This constructor receives a list as a parameter.
        {
            InitializeComponent();
            allRecipes = recipes;
            DisplayRecipes(); //A method to display the recipe is called.
            this.currentRecipe = currentRecipe;
        }

        private void DisplayRecipes() //Method to display the recipes.
        {

            lstRecipes.Items.Clear();
           
            foreach (var recipe in allRecipes)
            {
                lstRecipes.Items.Add(recipe.Name); //Addiing the name of the recipes that exsist to the listbox.
            }
        }

        private void btnFilter_Click(object sender, RoutedEventArgs e)
        {
            string ingredientFilter = txtIngredients.Text.Trim(); //Assigns what user input to the variable and removing any white spaces
            string foodGroupFilter = (cmbFoodGroup.SelectedItem as ComboBoxItem)?.Content.ToString(); //Converting the selected option to a string
                                                                                                      // (Microsoft Learn, [s.a.])
                                                                                                      //and if its null it assigns nothing to it
            int maxCaloriesFilter = 0;

            if (int.TryParse(txtCalories.Text.Trim(), out maxCaloriesFilter))  
            {
                List<Recipes> filteredRecipes = new List<Recipes>();
//It looks through the recipe list to filter out the names of the recipes based on the user input.
                foreach (Recipes recipe in allRecipes)
                {
                    bool ingredientMatch = true; //First it checks if the name of the ingredient matches the one inside memory already.
                    if (!string.IsNullOrEmpty(ingredientFilter))
                    {
                        ingredientMatch = false;
                        foreach (Ingredients ingredient in recipe.IngredientsList)
                        {
                            if (ingredient.Name.ToLower().Contains(ingredientFilter.ToLower())) //String manipulation to check even if the name is in lower case.
                            {
                                ingredientMatch = true;
                                break;
                            }
                        }
                    }

                    bool foodGroupMatch = true; //Checks if the food group that user selected matches the one in memory
                    if (foodGroupFilter != "Select Food Group" && !string.IsNullOrEmpty(foodGroupFilter))
                    {
                        foodGroupMatch = false;
                        foreach (Ingredients ingredient in recipe.IngredientsList)
                        {
                            if (ingredient.FoodGroup.ToLower() == foodGroupFilter.ToLower()) //(Codecademy. [s.a.])
                            {
                                foodGroupMatch = true;
                                break;
                            }
                        }
                    }

                    bool caloriesMatch = true; //it calculates the total calories in each recipe and compares
                                               //it to a maximum calories limit
                    if (maxCaloriesFilter > 0)
                    {
                        int totalCalories = 0;
                        foreach (Ingredients ingredient in recipe.IngredientsList)
                        {
                            totalCalories += ingredient.Calories;
                        }
                        if (totalCalories > maxCaloriesFilter)
                        {
                            caloriesMatch = false;
                        }
                    }

                    if (ingredientMatch || foodGroupMatch || caloriesMatch)
                    {
                        filteredRecipes.Add(recipe);
                    }
                }

                DisplayFilteredRecipes(filteredRecipes);
            }
            else
            {
                MessageBox.Show("Please enter a valid number for maximum calories.");
            }
        }

        private void DisplayFilteredRecipes(List<Recipes> recipes)
        { //Display the filtered results
            lstRecipes.Items.Clear();
            foreach (var recipe in recipes) // (GeeksforGeeks, 2024)
            {
                lstRecipes.Items.Add(recipe.Name);
            }
        }
        private void btnNewRecipe_Click(object sender, RoutedEventArgs e)
        {//Redirects the user to the beginning where they can create a new recipe again.
            Recipes newRecipe = new Recipes();
            CreateRecipe createRecipeWindow = new CreateRecipe(newRecipe, allRecipes);
            createRecipeWindow.Show();
        }
    

        private void btnSearch_Click(object sender, RoutedEventArgs e)
        {
            string search = txtSearch.Text;
            SearchAndDisplayRecipe(search);

        }

        public void SearchAndDisplayRecipe(string recipeName)
        {
            lstIngredients1.Items.Clear();
            lstSteps1.Items.Clear();

            // Search for recipes matching the recipeName
            var foundRecipes = allRecipes.Where(recipe => recipe.Name.ToLower().Contains(recipeName.ToLower())); // (GeeksforGeeks, 2024)
            //This searches through the recipes list to check for the name the user enetered and returns the name that matches. If no such recipe is found, it assigns null to the currentRecipe variable.    
            //(GitHub, 2014) 
            foreach (var recipe in foundRecipes)
            {
                txtTitle.Text = recipe.Name; // Display recipe name
                foreach (var ingredient in recipe.IngredientsList)
                {
                    lstIngredients1.Items.Add($"Ingredient: {ingredient.Name}, Quantity: {ingredient.Quantity}, " +
                                         $"Unit Of Measurement: {ingredient.UnitOfMeasurement}, " +
                                         $"Calories: {ingredient.Calories} cal, Food group: {ingredient.FoodGroup}");
                }
                for (int i = 0; i < recipe.StepsList.Count; i++)
                {
                    lstSteps1.Items.Add($"Step {i + 1}: {recipe.StepsList[i].Description}");
                }
            }
        }

        private void lstRecipes_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
    
}
//(CodeProject, [s.a.])