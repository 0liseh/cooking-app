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
    /// Interaction logic for SearchResultsPage.xaml
    /// </summary>
    public partial class SearchResultsPage : Page
    {
        public SearchResultsPage()
        {
            InitializeComponent();

            for (int i = 0; i < 10; i++)
            {
                RecipeCard rcard = new RecipeCard();
                //rcard.Title = "Chocolate" + i.ToString();
                this.SearchResults.Children.Add(rcard);
            }
        }
    }
}
