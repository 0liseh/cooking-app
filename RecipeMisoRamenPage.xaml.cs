using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Xml.Linq;

namespace cooking_app
{
    /// <summary>
    /// Interaction logic for RecipePage.xaml
    /// </summary>
    public partial class RecipeMisoRamenPage : Page
    {
        public RecipeMisoRamenPage()
        {
            InitializeComponent();
        }

        private void Back_Click(object sender, RoutedEventArgs e)
        {

        }

        private void ScrollToIngredients(object sender, RoutedEventArgs e)
        {
            Ingredients.BringIntoView();
        }

        private void ScrollToInstructions(object sender, RoutedEventArgs e)
        {
            
            Instructions.BringIntoView();
        }

        private void ScrollToNutrition(object sender, RoutedEventArgs e)
        {
            Nutrition.BringIntoView();
        }
        private void ScrollToReviews(object sender, RoutedEventArgs e)
        {
            Reviews.BringIntoView();
        }

        private void AddRating(object sender, RoutedEventArgs e)
        {
            foreach (UserControl Rating in FirstUserComment.Children.OfType<UserControl>())
            {
                
                MessageBox.Show(Rating.Name);
            }

        }
    }
}
