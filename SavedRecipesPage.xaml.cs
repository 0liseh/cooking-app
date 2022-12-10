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

            // The inital saved recipes 
            string[] title = { "Mac and Cheese", "Pizza", "Ceaser Salad" };
            string[] duration = { "30 MIN", "1 HR", "15 MIN" };
            string[] difficulty = { "EASY", "HARD", "EASY" };
            string[] rating = { "4.5", "4.1", "4.8" };
            string[] image = { "Mac and cheese.jpg", "Pizza.pg", "Ceaser Salad.jpg"};


            // Create a few default saved recipes initally 
            for (int i=0; i < 2; i++)
            {
                RecipeCard2 recipe = new RecipeCard2();

                recipe.Title = title[i];
                recipe.DurationText.Content = duration[i];
                recipe.DifficultyText.Content = difficulty[i];
                recipe.RatingText.Content = rating[i];

                Uri uri = new Uri("pack://application:,,,/cooking-app;component/img/ramen/" + image[i], UriKind.Absolute);
                ImageSource imgSource = new BitmapImage(uri);
                recipe.ImageCard = imgSource;

                this.SavedRecipes.Children.Add(recipe);
            }

        }

        // This will be called when the user clicks to save a recipe
        public void addSavedRecipe()
        {

        }

        // This will be called when the user clicks a saved recipe to remove it from the 
        public void removeSavedRecipe()
        {

        }

    }
}
