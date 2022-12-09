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
            IEnumerable<Button> tabs = TabSection.Children.OfType<Button>();

            if (sender.Equals(IngridentsTab))
            {
                tabs.ElementAt(0).Background = Brushes.Gray;
                tabs.ElementAt(1).Background = Brushes.White;
                tabs.ElementAt(2).Background = Brushes.White;
                tabs.ElementAt(3).Background = Brushes.White;
            }
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

        private void EggsPopup(object sender, RoutedEventArgs e)
        {
            if (EggPopup.IsOpen == true)
            {
                EggPopup.IsOpen = false;
            }
            else
            {
                EggPopup.IsOpen = true;
            }
                
        }

        private void DisplayUserComment(object sender, RoutedEventArgs e)
        {
            RecipePageSubmittedComment comment = new RecipePageSubmittedComment();
            comment.UserNameContainer.Text = "John Doe";
            comment.UserCommentContainer.Text = UserComment.Text;
            comment.addUserRating(UserRating.getNoOfStars());

            UserCommentsAdded.Items.Add(comment);
        }
    }
}
