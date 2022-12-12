﻿using System;
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
    /// Interaction logic for SearchSavedRecipesResults.xaml
    /// </summary>
    public partial class SearchSavedRecipesResuts : Page
    {
        public SearchSavedRecipesResuts()
        {

            InitializeComponent();

            // The inital saved recipes 
           // string[] title = { "MAC AND CHEESE", "PIZZA", "CEASER SALAS", "CHICKEN NOODLE SOUP" };
           // string[] duration = { "30 MIN", "1 HR", "15 MIN", "45 MIN" };
           // string[] difficulty = { "EASY", "HARD", "EASY", "MEDIUM" };
           // string[] rating = { "4.5", "4.1", "4.8", "4.0" };
           // string[] image = { "Mac and cheese.jpg", "Pizza.jpg", "Ceaser Salad.jpg" };


            // Create a few default saved recipes initally 
          //  for (int i = 0; i < 4; i++)
           // {
           //     RecipeCard2 recipe = new RecipeCard2();

           //     recipe.Title = title[i];
           //     recipe.DurationText.Content = duration[i];
           //     recipe.DifficultyText.Content = difficulty[i];
           //     recipe.RatingText.Content = rating[i];

          //      this.SavedRecipes.Children.Add(recipe);
         //   }

            if (MenuButtons.savedSearch == "ramen")
            {
                RecipeCard2 recipe = new RecipeCard2();
                recipe.Title = "RAMEN";
                recipe.DurationText.Content = "30 MIN";
                recipe.DifficultyText.Content = "EASY";
                recipe.RatingText.Content = "4.0";

                this.SavedRecipes.Children.Add(recipe);
                
            }

            else if(MenuButtons.savedSearch == "chocolate cake")
            {
                RecipeCard2 recipe = new RecipeCard2();
                recipe.Title = "CHOCOLATE CAKE";
                recipe.DurationText.Content = "30 MIN";
                recipe.DifficultyText.Content = "EASY";
                recipe.RatingText.Content = "4.0";

                this.SavedRecipes.Children.Add(recipe);

            }

        }

        // This will be called when the user clicks to save a recipe
        public void addSavedRecipe(string title, string duration, string difficulty, string rating, ImageSource img)
        {
            RecipeCard2 recipe = new RecipeCard2();

            recipe.Title = title;
            recipe.DurationText.Content = duration;
            recipe.DifficultyText.Content = difficulty;
            recipe.RatingText.Content = rating;
            recipe.ImageCard = img;

            this.SavedRecipes.Children.Insert(0, recipe);

        }


        // When the user clicks to filter the saved recipes 
        private void catergory1_Click(object sender, RoutedEventArgs e)
        {

        }

        private void catergory2_Click(object sender, RoutedEventArgs e)
        {

        }

        private void catergory3_Click(object sender, RoutedEventArgs e)
        {

        }

        private void catergory4_Click(object sender, RoutedEventArgs e)
        {

        }

        private void catergory5_Click(object sender, RoutedEventArgs e)
        {

        }

        private void catergory6_Click(object sender, RoutedEventArgs e)
        {

        }

        private void generalSearch_Click(object sender, RoutedEventArgs e)
        {
            MenuButtons.onSavedRecipesPage = true;
            MainWindow.NavigateToPage(MenuButtons.searchPage);

        }

        // Only searches through the saved recipes 
        private void searchSaved_Click(object sender, RoutedEventArgs e)
        {
            MenuButtons.onSavedRecipesPage = true;
            MainWindow.NavigateToPage(MenuButtons.searchSavedPage);
        }

        private void back_Click(object sender, RoutedEventArgs e)
        {
            MainWindow.NavigateToPage(MenuButtons.savedRecipesPage);
        }
    }
}