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
using static System.Net.Mime.MediaTypeNames;

namespace cooking_app
{
    /// <summary>
    /// Interaction logic for SearchResultsPage.xaml
    /// </summary>
    public partial class SearchResultsPage : Page


    {

        public static bool durationFilterClicked = false;
        public static string durationFilterText = "5Min";

        String searchResult = "ramen"; //MenuButtons.SearchPage.stringName

        string[] filterList = { "Dinner", "Japanese", "Easy" };//FilterPage.appliedFilters;


        // RAMEN SEARCH RESULTS
        string[] ramenResults = { "Shoyu Ramen", "Tonkotsu Ramen", "Shio Ramen", "Hakodate", "Miso Ramen", "Hiroshima", "Sapporo Ramen", "Takayama", "Tsukemen", "Tokyo Ramen" };
        string[] ramenImg = { "ShoyuRamen.jpg", "Tonkatsu.jpg", "ShioRamen.jpg", "Hakodate.jpg", "MisoRamen.jpg", "Hiroshima.jpg", "Sapporo.jpg", "Takayama.jpg", "Tsukemen.jpg", "TokyoRamen.jpg" };
        string[] ramenRating = { "5.0", "5.0", "4.9", "4.8", "4.6", "4.5", "4.5", "4.5", "4.5", "4.3" };


        // MAC AND CHEESE SEARCH RESULTS 
        string[] macResults = { "Creamy Mac and Cheese", "Mac and Cheese", "Mac and Extra Cheese", "Baked Mac and Cheese", "Southern Mac and Cheese", "White Chedder Mac and Cheese", "Ultra Creamy Mac and Cheese", "3 Cheese Mac and Cheese", "Brie Mac and Cheese", "Simple Mac and Cheese" };
        string[] macRating = { "4.8", "4.8", "4.8", "4.7", "4.5", "4.4", "4.3", "4.3", "4.2", "4.0" };
        string[] macImg = { "mac1.jpg", "mac2.jpg", "mac3.jpg", "mac4.jpg", "mac5.jpg", "mac6.jpg", "mac7.jpg", "mac8.jpg", "mac9.jpg", "mac10.jpg" };


        // 5 MINUTE QUICK EASY RECIPES 


        // 30 MINUTE RECIPES 

        public SearchResultsPage()
        {
            InitializeComponent();

            if (MenuButtons.durationFilterClicked == true)
            {
                for (int i = 0; i < 10; i++)
                {
                    RecipeCard1 rcard = new RecipeCard1();
                    rcard.Title = macResults[i];
                    rcard.Difficulty = "EASY";
                    rcard.Rating = macRating[i];
                    rcard.Duration = "30 MIN";
                    // change to folder mac and cheese
                    Uri uri = new Uri("pack://application:,,,/cooking-app;component/img/mac/" + macImg[i], UriKind.Absolute);
                    ImageSource imgSource = new BitmapImage(uri);
                    rcard.ImageCard = imgSource;
                    this.SearchResults.Children.Add(rcard);
                }

                if (MenuButtons.durationFilterText.Contains("1hr"))
                {
                    for (int i = 0; i < 10; i++)
                    {
                        RecipeCard1 rcard = new RecipeCard1();
                        rcard.Title = ramenResults[i];
                        rcard.Difficulty = "EASY";
                        rcard.Rating = ramenRating[i];
                        rcard.Duration = "1 HR";
                        Uri uri = new Uri("pack://application:,,,/cooking-app;component/img/ramen/" + ramenImg[i], UriKind.Absolute);
                        ImageSource imgSource = new BitmapImage(uri);
                        rcard.ImageCard = imgSource;
                        this.SearchResults.Children.Add(rcard);
                    }
                }


            } else
            {
                searchBar.Text = searchResult;

                if (searchResult.Contains("ramen", StringComparison.InvariantCultureIgnoreCase))
                {
                    for (int i = 0; i < 10; i++)
                    {
                        RecipeCard1 rcard = new RecipeCard1();
                        rcard.Title = ramenResults[i];
                        rcard.Difficulty = "EASY";
                        rcard.Rating = ramenRating[i];
                        rcard.Duration = "30 MIN";
                        Uri uri = new Uri("pack://application:,,,/cooking-app;component/img/ramen/" + ramenImg[i], UriKind.Absolute);
                        ImageSource imgSource = new BitmapImage(uri);
                        rcard.ImageCard = imgSource;
                        this.SearchResults.Children.Add(rcard);
                    }


                }
                else if (searchResult.Contains("mac and cheese", StringComparison.InvariantCultureIgnoreCase))
                {
                    for (int i = 0; i < 10; i++)
                    {
                        RecipeCard1 rcard = new RecipeCard1();
                        rcard.Title = macResults[i];
                        rcard.Difficulty = "EASY";
                        rcard.Rating = macRating[i];
                        rcard.Duration = "30 MIN";
                        // change to folder mac and cheese
                        Uri uri = new Uri("pack://application:,,,/cooking-app;component/img/mac/" + macImg[i], UriKind.Absolute);
                        ImageSource imgSource = new BitmapImage(uri);
                        rcard.ImageCard = imgSource;
                        this.SearchResults.Children.Add(rcard);
                    }
                }
                else
                {
                    for (int i = 0; i < 1; i++)
                    {
                        ErrorControl ecard = new ErrorControl();
                        ecard.ErrorMsg = "No search results found, please check the spelling of your search or if you have applied too many filters.";
                        this.SearchResults.Children.Add(ecard);
                    }
                }

            }
                for (int i = 0; i < filterList.Length; i++)
                {
                    FilterButton filterbtn = new FilterButton();
                    filterbtn.FilterText = filterList[i];
                    this.FilterResults.Children.Add(filterbtn);
                }
        }

        private void searchBar_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            //MenuButtons.onSearchResultsPage = true;
            MainWindow.NavigateToPage(MenuButtons.searchPage);

        }

        public void btnFilterButtonClick(object sender, RoutedEventArgs e)
        {
            MainWindow.NavigateToPage(MenuButtons.filterPage);
        }

        private void eventhandler(object sender, ScrollChangedEventArgs e)
        {
            var scrollViewer = (ScrollViewer)sender;
            if (scrollViewer.VerticalOffset == scrollViewer.ScrollableHeight)
            {
            //    for (int i = 0; i < 10; i++)
            //    {
            //        RecipeCard1 rcard = new RecipeCard1();
            //        rcard.Title = ramenResults[i];
            //        rcard.Difficulty = "EASY";
            //        rcard.Rating = ramenRating[i];
            //        rcard.Duration = "1 HR";
            //        Uri uri = new Uri("pack://application:,,,/cooking-app;component/img/ramen/" + ramenImg[i], UriKind.Absolute);
            //        ImageSource imgSource = new BitmapImage(uri);
            //        rcard.ImageCard = imgSource;
            //        this.SearchResults.Children.Add(rcard);
            //    }
            }
        }
    }

}
