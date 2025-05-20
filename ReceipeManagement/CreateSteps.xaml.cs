using poedraft;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
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
   
    public partial class CreateSteps : Window
    {
        public Recipes currentRecipe { get; set; }
        public List<Recipes> allRecipes;
       
        public CreateSteps(Recipes recipe) //This constructor receives a class as a parameter.
        {
            InitializeComponent();
            currentRecipe = recipe ?? new Recipes();  // (Microsoft Learn, [s.a.])

            UpdateStepsList();
        }

        private void btnAddStep_Click(object sender, RoutedEventArgs e)
        {
          
            string stepDescription = txtSteps.Text; //Assigning the textbox to the variable. 

            Steps steps = new Steps
            {
                Description = stepDescription, //Adding the input from user to class
               
            };
            currentRecipe.StepsList.Add(steps); //Adding the steps to list 
            UpdateStepsList();
            

            txtSteps.Clear(); //Clearing it, preparing it for next input from user.
        }

        private void btnDisplay_Click(object sender, RoutedEventArgs e)
        {
            Window1 displayRecipeWindow = new Window1(currentRecipe, allRecipes); //The button takes you to another window to display the recipe.
            displayRecipeWindow.Show();
            this.Close();
        }

        private void UpdateStepsList()
        {
            lstSteps.Items.Clear(); //Ading the steps the user has inputted to the list so that it can be displayed.
            for (int i = 0; i < currentRecipe.StepsList.Count; i++)
            {
                var steps = currentRecipe.StepsList[i];
                lstSteps.Items.Add($"Step {i + 1}: {steps.Description}");
            }
        }
    }
}


//(Behance, [s.a.])