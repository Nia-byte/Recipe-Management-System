using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace poedraft
{
    
    public partial class MainWindow : Window
    {
        private List<Recipes> allRecipes;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void CreateNewRecipe_Click(object sender, RoutedEventArgs e)
        {
            Recipes newRecipe = new Recipes(); // When this button is clicked the user will be redirected to this window.
            CreateRecipe createRecipeWindow = new CreateRecipe(newRecipe, allRecipes);
            createRecipeWindow.Show();
        }
    }
}
//(CodeProject, [s.a.])
/*Reference List:

Troelsen, A. and Japikse, P. 2021. Pro C# 9 with. NET 5: Foundational Principles and Practices in Programming. 10th ed. Apress. [eBook]. Available on EBSCOhost at: https://web-p-ebscohost-com.ezproxy.iielearn.ac.za/ehost/detail/detail?vid=0&sid=bddb495b-596b-4625-890b-707b12be994f%40redis&bdata=JnNpdGU9ZWhvc3QtbGl2ZSZzY29wZT1zaXRl#AN=2917701&db=nlebk [Accssed 5 April 2024]. 
 
w3resource. 2024. Convert user input string to integer with exception handling, 12 January 2024. [Online]. Available at: https://www.w3resource.com/csharp-exercises/exception-handling/csharp-exception-handling-exercise-6.php [Accessed 5 April 2024]. 

Syncfusion. 2023. Get Started with Tuples in C#: A Beginner's Handbook, 10 April 2023. [Online]. Available at: https://www.syncfusion.com/blogs/post/working-with-tuple-in-csharp [Accessed 10 April 2024]. 

Medium. 2020. Value Tuples: Returning Multiple Values from a Function in C#, 28 January 2020. [Online]. Available at: https://nosuchstudio.medium.com/value-tuples-returning-multiple-values-from-a-function-in-c-b2bcb365a958 [Accessed 10 April 2024]. 

GitHub. 2014. Query: Consider translating String.Equals(String, StringComparison) for selected values of StringComparison, 5 December 2024. [Online]. Available at: https://github.com/dotnet/efcore/issues/1222 [Accessed 25 May 2024]. 

Byte Hide. 2024. Sorting Lists in C#: Easy Tutorial, 1 January 2024. [Online]. Available at: https://github.com/dotnet/efcore/issues/1222 [Accessed 25 May 2024]. 

SweetLife. 2022. What are the different food groups? A simple explanation., 13 July 2022. [Online]. Available at: https://sweetlife.org.za/what-are-the-different-food-groups-a-simple-explanation/ [Accessed 25 May 2024]. 

Tutorials Teacher. [s.a.]. C# Delegates, [s.a.]. [Online]. Available at: https://www.tutorialsteacher.com/csharp/csharp-delegates [Accessed 25 May 2024].  

MicroSoft Learn. 2023. Walkthrough: Create and run unit tests for managed code, 11 March 2023. [Online]. Available at: https://learn.microsoft.com/en-us/visualstudio/test/walkthrough-creating-and-running-unit-tests-for-managed-code?view=vs-2022 [Accessed 25 May 2024]. 

Behance. [s.a.]. UX/UI Cookbook recipe mobile app Case Study, [s.a.]. [Online]. Available at: https://www.behance.net/gallery/199168511/UXUI-Cookbook-recipe-mobile-app-Case-Study?tracking_source=search_projects|recipe+app+design&l=12 [Accessed 22 June 2024]. 

CodeProject. [s.a.]. OOP - implementing lists using c# in wpf, 9 September 2024. [Online]. Available at: https://www.codeproject.com/Questions/252315/oop-implementing-lists-using-csharp-in-wpf [Accessed 22 June 2024]. //(CodeProject, [s.a.])

Microsoft Learn. [s.a.]. Int32.TryParse Method (System), [s.a.]. [Online]. Available at:https://learn.microsoft.com/en-us/dotnet/api/system.int32.tryparse?view=net-8.0 [Accessed 22 June 2024]. // (Microsoft Learn, [s.a.])

Microsoft Learn. [s.a.]. UWP C# ComboBox & the SelectedItem.ToString();, [s.a.]. [Online]. Available at: https://learn.microsoft.com/en-us/answers/questions/1080981/uwp-c-combobox-the-selecteditem-tostring()?page=1#answer-1081395 [Accessed 22 June 2024]. // (Microsoft Learn, [s.a.])


Microsoft Learn. [s.a.]?? and ??= operators - null-coalescing operators - C# reference, [s.a.]. [Online]. Available at: https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/operators/null-coalescing-operator [Accessed 22 June 2024]. // (Microsoft Learn, [s.a.])


GeeksforGeeks. 2024. C#: Implicitly Typed Local Variables - var, 10 April 2024. [Online]. Available at: https://www.geeksforgeeks.org/c-sharp-implicitly-typed-local-variables-var/ [Accessed 22 June 2024]. // (GeeksforGeeks, 2024)


Codecademy. [s.a.]. C#: Strings: .ToLower(), [s.a.]. [Online]. Available at: https://www.codecademy.com/resources/docs/c-sharp/strings/tolower [Accessed 22 June 2024]. //(Codecademy. [s.a.])

 
 
 */