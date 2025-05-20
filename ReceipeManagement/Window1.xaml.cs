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
    
    public partial class Window1 : Window
    {
        public Recipes currentRecipe  { get; set; }
        public List<Recipes> allRecipes;
        public Window1(Recipes recipe, List<Recipes> recipes) //This constructor receives a list and class as a parameter.
        {
            InitializeComponent();
            currentRecipe = recipe ?? new Recipes();  //a recipe object is instantiated. 
            allRecipes = recipes ?? new List<Recipes>();
            DisplayRecipe();
            DefaultRecipes();
        }

        private void DefaultRecipes()
        {
            // Create and add default recipes
            Recipes defaultRecipe1 = new Recipes  //a recipe object is instantiated. 
            {
                Name = "Lasagna",
                IngredientsList = new List<Ingredients> 
            {
                new Ingredients { Name = "Ground beef", Quantity = 100, UnitOfMeasurement = "g", Calories = 200, FoodGroup = "Chicken, fish, meat and eggs" },
                new Ingredients { Name = "Tomato sauce", Quantity = 50, UnitOfMeasurement = "g", Calories = 150, FoodGroup = "Fats and oil" },
                new Ingredients { Name = "Mozzarella cheese", Quantity = 50, UnitOfMeasurement = "g", Calories = 150, FoodGroup = "Fats and oil" }

                },
                StepsList = new List<Steps>
            {
                new Steps { Description = "Step 1: cook ground beef, sausage, onion, and garlic until browned. Drain excess fat." },
                new Steps { Description = "Step 2: Cook lasagna noodles according to package instructions." },
                new Steps { Description = "Step 3: Stir in tomato sauce and Italian seasoning. Simmer for 10 minutes." }

                }
            };

            Recipes defaultRecipe2 = new Recipes
            {
                Name = "Oats",
                IngredientsList = new List<Ingredients>
            {
                new Ingredients { Name = "Rolled oats", Quantity = 200, UnitOfMeasurement = "g", Calories = 300, FoodGroup = "Dry beans, peas, lentils and soya" },
                new Ingredients { Name = "Water", Quantity = 75, UnitOfMeasurement = "ml", Calories = 180, FoodGroup = "Water" },
                new Ingredients { Name = "Honey", Quantity = 75, UnitOfMeasurement = "ml", Calories = 180, FoodGroup = "Fats and oil" }

                },
                StepsList = new List<Steps>
            {
                new Steps { Description = "Step 1: Bring water to a boil in a saucepan." },
                new Steps { Description = "Step 2: Stir in rolled oats and reduce heat to medium-low." },
                new Steps { Description = "Step 3: Serve hot, drizzled with honey and topped" }

                }
            };

            Recipes defaultRecipe3 = new Recipes
            {
                Name = "Beef Stew",
                IngredientsList = new List<Ingredients>
            {
                new Ingredients { Name = "Stewing beef", Quantity = 200, UnitOfMeasurement = "g", Calories = 300, FoodGroup = "Chicken, fish, meat and eggs" },
                new Ingredients { Name = "Tomato paste", Quantity = 75, UnitOfMeasurement = "ml", Calories = 180, FoodGroup = "Fats and oil" },
                new Ingredients { Name = "Worcestershire sauce", Quantity = 75, UnitOfMeasurement = "ml", Calories = 180, FoodGroup = "Fats and oil" }

                },
                StepsList = new List<Steps>
            {
                new Steps { Description = "Step 1: In a large pot, brown stewing beef in oil over medium-high heat." },
                new Steps { Description = "Step 2: Stir in beef broth, tomato paste, Worcestershire sauce, bay leaves, thyme, salt, and pepper." }
                }
            };

            Recipes defaultRecipe4 = new Recipes
            {
                Name = "Muffins",
                IngredientsList = new List<Ingredients>
            {
                new Ingredients { Name = "All-purpose flour", Quantity = 200, UnitOfMeasurement = "g", Calories = 300, FoodGroup = "Starchy foods" },
                new Ingredients { Name = "Sugar", Quantity = 75, UnitOfMeasurement = "ml", Calories = 180, FoodGroup = "Fats and oil" },
                new Ingredients { Name = "Baking powder", Quantity = 75, UnitOfMeasurement = "ml", Calories = 180, FoodGroup = "Starchy foods" }

                },
                StepsList = new List<Steps>
            {
                new Steps { Description = "Step 1: In a bowl, combine flour, sugar, baking powder, and salt." },
                new Steps { Description = "Step 2: In another bowl, whisk together milk, vegetable oil, egg, and vanilla extract." },
                new Steps { Description = "Step 3: Spoon batter into muffin cups, filling each about two-thirds full." }

                }
            };

            Recipes defaultRecipe5 = new Recipes
            {
                Name = "Red Velvet Cake",
                IngredientsList = new List<Ingredients>
            {
                new Ingredients { Name = "Cake flour", Quantity = 200, UnitOfMeasurement = "g", Calories = 300, FoodGroup = "Starchy foods" },
                new Ingredients { Name = "Red food coloring\r\n", Quantity = 75, UnitOfMeasurement = "ml", Calories = 180, FoodGroup = "Fats and oil" },
                new Ingredients { Name = "Cocoa powder", Quantity = 75, UnitOfMeasurement = "ml", Calories = 180, FoodGroup = "Dry beans, peas, lentils and soya" }

                },
                StepsList = new List<Steps>
            {
                new Steps { Description = "Step 1: In a bowl, sift together cake flour, cocoa powder, baking soda, and salt." },
                new Steps { Description = "Step 2: Add eggs one at a time, beating well after each addition." },
                new Steps { Description = "Step 3: Mix buttermilk, vinegar, vanilla extract, and red food coloring in a small bowl." }

                }
            };

            Recipes defaultRecipe6 = new Recipes
            {
                Name = "Chocolate Cake",
                IngredientsList = new List<Ingredients>
            {
                new Ingredients { Name = "All-purpose flour", Quantity = 200, UnitOfMeasurement = "g", Calories = 300, FoodGroup = "Starchy foods" },
                new Ingredients { Name = "Baking soda", Quantity = 75, UnitOfMeasurement = "ml", Calories = 180, FoodGroup = "Starchy foods" },
                new Ingredients { Name = "Butter", Quantity = 75, UnitOfMeasurement = "ml", Calories = 180, FoodGroup = "Milk and dairy products" }

                },
                StepsList = new List<Steps>
            {
                new Steps { Description = "Step 1: In another bowl, cream butter and sugar until light and fluffy." },
                new Steps { Description = "Step 2: Add eggs one at a time, beating well after each addition." },
                new Steps { Description = "Step 3: Mix milk and vanilla extract in a small bowl." }

                }
            };

            // Add default recipes to allRecipes list
            allRecipes.Add(defaultRecipe1);
            allRecipes.Add(defaultRecipe2);
            allRecipes.Add(defaultRecipe3);
            allRecipes.Add(defaultRecipe4);
            allRecipes.Add(defaultRecipe5);
            allRecipes.Add(defaultRecipe6);
        }

        private void ResetIngredients(double num)
        {
            foreach (var ingredient in currentRecipe.IngredientsList)
            {
                ingredient.Quantity /= num;
            }// Created a method to make calculations if the user wants their ingredients to be reset.
            DisplayRecipe();
        }
        private void btnReset_Click(object sender, RoutedEventArgs e)
        {
            double num = 0.0;
            // (Troelsen & Japikse, 2021)
            if (cmbScale.SelectedItem is ComboBoxItem selectedItem)
            {
                switch (selectedItem.Content.ToString())
                { // If the user enters a value from the options provided this if statement will perform these calculations.
                    case "Half":
                        num = 0.5; 
                        break;
                    case "Double":
                        num =  2; 
                        break;
                    case "Triple":
                        num =  3; 
                        break;
                }

                ResetIngredients(num);
            }
        }

        private void btnClear_Click(object sender, RoutedEventArgs e)
        {
            var result = MessageBox.Show("Are you sure you want to clear the recipe?", "Confirm Clear", MessageBoxButton.YesNo);

            if (result == MessageBoxResult.Yes)
            {
                lstDisplay.Items.Clear();
                currentRecipe.Name = null;
                currentRecipe.IngredientsList.Clear();
                currentRecipe.StepsList.Clear();
                DisplayRecipe();

                var createNew = MessageBox.Show("Do you want to create a new recipe?", "Confirm Clear", MessageBoxButton.YesNo);
                if (createNew == MessageBoxResult.Yes)
                {
                    Recipes newRecipe = new Recipes();
                    CreateRecipe createRecipeWindow = new CreateRecipe(newRecipe, allRecipes);
                    createRecipeWindow.Show();
                }
            }
            else
            {
                MessageBox.Show("Click 'Save' to save recipe");
            }


        }

        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            
            if (!allRecipes.Contains(currentRecipe))
            {
                allRecipes.Add(currentRecipe);
            }

            MessageBox.Show("Recipe saved!");

            AllRecipes listRecipes = new AllRecipes(allRecipes, currentRecipe);
            listRecipes.Show();

        }

        public void DisplayRecipe()
        {
          
            lstDisplay.Items.Clear();
            if (!string.IsNullOrEmpty(currentRecipe.Name))
            {
                lstDisplay.Items.Add(currentRecipe.Name);
            }
            lstDisplay.Items.Add("*****************************************");
            for (int i = 0; i < currentRecipe.IngredientsList.Count; i++)
            {
                var ingredient = currentRecipe.IngredientsList[i]; // (GeeksforGeeks, 2024)
                lstDisplay.Items.Add($"#{i + 1}\nIngredient: {ingredient.Name},\nQuantity: {ingredient.Quantity}, " +
                    $"\nUnit Of Measurement: {ingredient.UnitOfMeasurement},\nCalories: {ingredient.Calories} cal, \nFood group: {ingredient.FoodGroup}");
            }
            lstDisplay.Items.Add("*****************************************");
            /*  foreach (var ingredient in currentRecipe.IngredientsList)
              {
                  lstDisplay.Items.Add($"\nIngredient: {ingredient.Name}, Quantity: {ingredient.Quantity}, Unit Of Measurement: {ingredient.UnitOfMeasurement}, Calories: {ingredient.Calories} cal, Food group: {ingredient.FoodGroup}");
              }*/

            for (int i = 0; i < currentRecipe.StepsList.Count; i++)
            {
                lstDisplay.Items.Add($"Step {i + 1}: {currentRecipe.StepsList[i].Description}");
            }
            lstDisplay.Items.Add("*****************************************");

            int totalCalories =  currentRecipe.TotalCalories();
            lstDisplay.Items.Add("Total Calories: " + totalCalories + " cal");

        }

        private void cmbScale_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            double factor = 0;

            if (cmbScale.SelectedItem is ComboBoxItem selectedItem)
            {
                switch (selectedItem.Content.ToString())
                {// If the user enters a value from the options provided this if statement will perform these calculations.
                    case "Half":
                        factor = 0.5;
                        break;
                    case "Double":
                        factor = 2;
                        break;
                    case "Triple":
                        factor = 3;
                        break;
                }

                ScaleIngredients(factor);
            }// (Troelsen & Japikse, 2021)
        }

        private void ScaleIngredients(double factor)
        {// Created a method to make calculations if the user wants their ingredients to be scaled.
            foreach (var ingredient in currentRecipe.IngredientsList)
            {
                ingredient.Quantity *= factor;
            }
            DisplayRecipe();
        }
    }
}

//(Behance, [s.a.])