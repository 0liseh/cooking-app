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
    /// Interaction logic for SavedRecipesPage.xaml
    /// </summary>
    public partial class SavedRecipesPage : Page
    {
        public SavedRecipesPage()
        { 
            InitializeComponent();

            for (int i=0; i < 10; i++)
            {
                RecipeCard2 recipe = new RecipeCard2();
                this.SavedRecipes.Children.Add(recipe);
            }

        }
    }
}
