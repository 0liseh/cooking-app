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
    /// Interaction logic for HomePage.xaml
    /// </summary>
    public partial class HomePage : Page
    {
        public HomePage()
        {
            InitializeComponent();

            for (int i = 0; i < 10; i++)
            {
                HomeRecipeCard rcard = new HomeRecipeCard();
                rcard.Title = "Chocolate" + i.ToString();
                this.Trending.Children.Add(rcard);
            }

            for (int i = 0; i < 10; i++)
            {
                HomeRecipeCard rcard = new HomeRecipeCard();
                rcard.Title = "Chocolate" + i.ToString();
                this.Recommended.Children.Add(rcard);
            }

            for (int i = 0; i < 10; i++)
            {
                HomeRecipeCard rcard = new HomeRecipeCard();
                rcard.Title = "Chocolate" + i.ToString();
                this.RecentlyViewed.Children.Add(rcard);
            }
        }

        HomeRecipeCard card1 = new HomeRecipeCard();

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void btn1Hr_Click(object sender, RoutedEventArgs e)
        {

        }

        private void searchBar_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            searchBar.Text = "";

        }
    }
}
