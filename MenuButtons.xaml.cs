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
    /// Interaction logic for MenuButtons.xaml
    /// </summary>
    public partial class MenuButtons : UserControl
    {
        public static Page homePage = new HomePage();
        public static Page searchPage = new SearchPage();
        public static Page filterPage = new FilterPage();
        //public static Page profilePage = new ProfilePage();
        public static Page misoRamen = new RecipeMisoRamenPage();
        public static Page bobaTea = new RecipeBobaTeaPage();
        public static Page jollofRice = new RecipeJollofRicePage();
        public static Page chocolateCake = new RecipeChocolateCakePage();
        public static Page macAndCheese = new RecipeMacAndCheesePage();
        public static Page savedRecipesPage = new SavedRecipesPage();

        public static bool onSavedRecipesPage = false;
        public static bool onHomePage = false;
        public static bool onSearchPage = false;

        public MenuButtons()
        {
            InitializeComponent();
        }

        public void ProfileButtonClick(object sender, RoutedEventArgs e)
        {
            
        }

        public void HomeButtonClick(object sender, RoutedEventArgs e)
        {
            MainWindow.NavigateToPage(homePage);
        }

        public void SavedRecipesButtonClick(object sender, RoutedEventArgs e)
        {
            MainWindow.NavigateToPage(savedRecipesPage);
        }
    }
}
