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
        String searchResult = "Ramen";

        string[] filterList;

        string[] ramenResults = { "Shoyu Ramen", "Tonkotsu Ramen", "Shio Ramen", "Hakodate", "Miso Ramen", "Hiroshima", "Sapporo Ramen", "Takayama", "Tsukemen", "Tokyo Ramen" };
        string[] ramenImg = { "ShoyuRamen.jpg", "Tonkatsu.jpg", "ShioRamen.jpg", "Hakodate.jpg", "MisoRamen.jpg", "Hiroshima.jpg", "Sapporo.jpg", "Takayama.jpg", "Tsukemen.jpg", "TokyoRamen.jpg" };
        string[] ramenRating = { "5.0", "5.0", "4.9", "4.8", "4.6", "4.5", "4.5", "4.5", "4.5", "4.3" };

        string[] macResults = { "Creamy Mac and Cheese", "Mac and Cheese", "Mac and Extra Cheese", "Baked Mac and Cheese", "Southern Mac and Cheese", "White Chedder Mac and Cheese", "Ultra Creamy Mac and Cheese", "3 Cheese Mac and Cheese", "Brie Mac and Cheese", "Simple Mac and Cheese" };
        string[] macRating = { "4.8", "4.8", "4.8", "4.7", "4.5", "4.4", "4.3", "4.3", "4.2", "4.0" };
        
        // change images to mac and cheese 
        string[] macImg = { "ShoyuRamen.jpg", "Tonkatsu.jpg", "ShioRamen.jpg", "Hakodate.jpg", "MisoRamen.jpg", "Hiroshima.jpg", "Sapporo.jpg", "Takayama.jpg", "Tsukemen.jpg", "TokyoRamen.jpg" };

        public SearchResultsPage()
        {
            InitializeComponent();

            if (searchResult.Contains("ramen", StringComparison.InvariantCultureIgnoreCase))
            {
                searchBar.Text = searchResult;
                for (int i = 0; i < 10; i++)
                {
                    RecipeCard rcard = new RecipeCard();
                    rcard.Title = ramenResults[i];
                    rcard.Difficulty = "EASY";
                    rcard.Rating = ramenRating[i];
                    rcard.Duration = "30 MIN";
                    Uri uri = new Uri("pack://application:,,,/cooking-app;component/img/ramen/" + ramenImg[i], UriKind.Absolute);
                    ImageSource imgSource = new BitmapImage(uri);
                    rcard.ImageCard = imgSource;
                    this.SearchResults.Children.Add(rcard);
                }
            } else if (searchResult.Contains("mac and cheese"))
            {
                for (int i = 0; i < 10; i++)
                {
                    RecipeCard rcard = new RecipeCard();
                    rcard.Title = macResults[i];
                    rcard.Difficulty = "EASY";
                    rcard.Rating = macRating[i];
                    rcard.Duration = "30 MIN";
                    // change to folder mac and cheese
                    Uri uri = new Uri("pack://application:,,,/cooking-app;component/img/ramen/" + macImg[i], UriKind.Absolute);
                    ImageSource imgSource = new BitmapImage(uri);
                    rcard.ImageCard = imgSource;
                    this.SearchResults.Children.Add(rcard);
                }
            }

        }

        private void searchBar_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            searchBar.Text = "";
            // navigate to search page 

        }

        private void btnFilter_MouseClick(object sender, MouseEventArgs e)
        {
            // navigate to filter page 
        }
    }
}
