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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace cooking_app
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        

        public MainWindow()
        {
            InitializeComponent();
            //CookingApplication.Content = new HomePage();
            CookingApplication.Content = new SearchResultsPage();
            //CookingApplication.Content = new FilterPage();
            //CookingApplication.Content = new RecipeMisoRamenPage();
            //CookingApplication.Content = new RecipeJollofRicePage();
            //CookingApplication.Content = new RecipeChocolateCakePage();
            //CookingApplication.Content = new RecipeMacAndCheesePage();
            //CookingApplication.Content = new RecipeBobaTeaPage();
            //CookingApplication.Content = new SavedRecipesPage();
        }

        public static void NavigateToPage(Page page)
        {
            //Need to set CookingApplication on an instance of the MainWindow class
            ((MainWindow)Application.Current.MainWindow).CookingApplication.Content = page;
        }

    }
}
