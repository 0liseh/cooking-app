﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.DirectoryServices;
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
    /// Interaction logic for RecipeCard1.xaml
    /// </summary>
    public partial class RecipeCard1 : UserControl
    {
        public static List<String> recentlyViewedListTitle { get; set; } = new List<String>();
        List<string> recentlyViewedListDuration = new List<string>();
            List<string> recentlyViewedListRating = new List<string>();
            List<string> recentlyViewedListDifficulty = new List<string>();
            List<ImageSource> recentlyViewedListImage = new List<ImageSource>();





        public string title;
            public string Title
            {
                get { return title; }
                set
                {
                    title = value;
                    this.TitleSearchText.Content = this.title;
                }

            }

            public string duration;
            public string Duration
            {
                get { return duration; }
                set
                {
                    duration = value;
                    this.DurationSearchText.Content = this.duration;
                }

            }

            public string rating;
            public string Rating
            {
                get { return rating; }
                set
                {
                    rating = value;
                    this.RatingSearchText.Content = this.rating;
                }

            }

            public string difficulty;
            public string Difficulty
            {
                get { return difficulty; }
                set
                {
                    difficulty = value;
                    this.DifficultySearchText.Content = this.difficulty;
                }

            }

            public ImageSource img;
            public ImageSource ImageCard
            {
                get { return img; }
                set
                {
                    img = value;
                    this.ImgSearchCard.Source = this.img;
                }

            }

            public RecipeCard1()
        {
            InitializeComponent();
        }

        public void cardBtnClick(object sender, RoutedEventArgs e)
        {
            if(title.Contains("Miso Ramen", StringComparison.InvariantCultureIgnoreCase))
            {
                MainWindow.NavigateToPage(MenuButtons.misoRamen);
            }


            recentlyViewedListTitle.Add(title);
            recentlyViewedListDuration.Add(duration);
            recentlyViewedListRating.Add(rating);
            recentlyViewedListDifficulty.Add(difficulty);
            recentlyViewedListImage.Add(img);
        }

        public List<String> getList
        {
            get { return recentlyViewedListTitle; }
        }

        public void savedRecipeClick(object sender, RoutedEventArgs e)
        {
            RecipeCard2 recipe = new RecipeCard2();

            recipe.Title = title;
            recipe.DurationText.Content = duration;
            recipe.DifficultyText.Content = difficulty;
            recipe.RatingText.Content = rating;
            recipe.ImageCard = img;

            //MenuButtons.savedRecipesPage.SavedRecipes.Children.Insert(0, recipe);


            SavedRecipesPage page = new SavedRecipesPage();
            page.SavedRecipes.Children.Insert(0, recipe);

            //MenuButtons.savedRecipesPage.AddSavedRecipe(title, duration, difficulty, rating, img);

        }
    }
}
