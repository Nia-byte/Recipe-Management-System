using poedraft;
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
using static poedraft.CreateRecipe;
using System.Xml.Linq;

namespace poedraft
{
    public partial class CreateRecipe : Window
    {
        // Delegate declaration
        public delegate void CalorieNotification(string message);
        //List and Objects
        public Recipes currentRecipe  { get; set; } 
        private List<Recipes> allRecipes; //DECLARING THE LIST GOING TO BE USED TO STORE THE RECIPES

        private CalorieNotification notifyUser;
        public CreateRecipe(Recipes recipes, List<Recipes> recipeList)
       //Calling the method and passing the list to store the recipes.
                        
        {
            InitializeComponent();
            currentRecipe = recipes ?? new Recipes();  // (Microsoft Learn, [s.a.])
            allRecipes = recipeList ?? new List<Recipes>();
            notifyUser = NotifyUser;
            //assigns a method named NotifyUser to the delegate instance named notifyUser.

            UpdateIngredientList();
        }

      

        private void btnAddIngredient_Click(object sender, RoutedEventArgs e)
        {
           
            string nameOfRecipe = txtName.Text;
            
            currentRecipe.Name = nameOfRecipe;// Adding the name of the recipe to the variable inside the class.
            string nameOfIngredient = txtIngredient.Text;
            if (int.TryParse(txtQuantity.Text, out int quantity) && int.TryParse(txtCalories.Text, out int calories))  // (Microsoft Learn, [s.a.])

            { //This verifies if the inputs from the user are intergers.
                string unit = txtUnitOfMeasurement.Text;
                string foodGroup = (cmbFoodGroup.SelectedItem as ComboBoxItem)?.Content.ToString(); // (Microsoft Learn, [s.a.])

                //Checks if you have selected an option from the combobox and converts it to a  string.

                Ingredients ingredient = new Ingredients //Populating the class
                {
                    Name = nameOfIngredient,
                    Quantity = quantity,
                    UnitOfMeasurement = unit,
                    Calories = calories,
                    FoodGroup = foodGroup
                };

                currentRecipe.IngredientsList.Add(ingredient); //Adding to the list.
               // UpdateIngredientList(); //Displaying the ingredients in the listbox.

                lstIngredients.Items.Clear();
                UpdateIngredientList();
                //Clearing all inputs to allow user to enter new ingredients if they want to.
                txtIngredient.Clear();
                txtQuantity.Clear();
                txtUnitOfMeasurement.Clear();
                txtCalories.Clear();
                txtName.IsEnabled = false; //The user cannot change the RECIPE NAME AFTER IT HAVE BEEN ENTERED TO AVOID CONFUSION.



                if (TotalCalories() > 300)
                {
                    notifyUser("Total calories exceed 300!");
                }  //invokes the NotifyUser method via the delegate, passing it a message. 
            }
            else
            {
                MessageBox.Show("Please enter valid numbers for quantity and calories.");
            }

        }

        private void btnSteps_Click(object sender, RoutedEventArgs e)
        {
            CreateSteps stepsWindow = new CreateSteps(currentRecipe);
            stepsWindow.Show(); //Buttons redirects you to the steps window to eneter the steps.

        }
        private int TotalCalories() //Method Calculating the total calories. 
        {
            int total = 0;
            foreach (var ingredient in currentRecipe.IngredientsList) 
            {
                total += ingredient.Calories;
            }
            return total;
        }

        private void NotifyUser(string message)
        {
            MessageBox.Show(message, "Calorie Notification", MessageBoxButton.OK, MessageBoxImage.Warning);
        }

        private void UpdateIngredientList()
        {
           // lstIngredients.Items.Clear();
            for (int i = 0; i < currentRecipe.IngredientsList.Count; i++)
            {
                var ingredient = currentRecipe.IngredientsList[i]; // (GeeksforGeeks, 2024)
                lstIngredients.Items.Add($"#{i + 1}\nIngredient: {ingredient.Name},\nQuantity: {ingredient.Quantity}, " +
                    $"\nUnit Of Measurement: {ingredient.UnitOfMeasurement},\nCalories: {ingredient.Calories} cal, \nFood group: {ingredient.FoodGroup}");
            }
        }
    }

  
}

//(CodeProject, [s.a.])