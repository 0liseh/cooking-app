using System;
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

namespace cooking_app
{
    /// <summary>
    /// Interaction logic for RatingSystem.xaml
    /// </summary>
    public partial class RatingSystem : UserControl
    {
        public RatingSystem()
        {
            InitializeComponent();
        }

        public void ChangeRating(object sender, RoutedEventArgs e)
        {
            
            if (sender.Equals(FirstStar))
            {
                foreach (ToggleButton star in RatingSystemStars.Children.OfType<ToggleButton>())
                {

                    if (star.Name == "FirstButton")
                    {
                        star.IsChecked = true;
                        return;
                    }             

                }
            }
            else if (sender.Equals(SecondStar))
            {
                foreach (ToggleButton star in RatingSystemStars.Children.OfType<ToggleButton>())
                {
                    if (star.Name == "FirstButton")
                    {
                        star.IsChecked = true;
                        
                    }

                    if (star.Name == "SecondButton")
                    {
                        star.IsChecked = true;

                    }

                    if (star.Name == "ThirdButton")
                    {
                        star.IsChecked = false;

                    }

                    if (star.Name == "FourthButton")
                    {
                        star.IsChecked = false;

                    }

                    if (star.Name == "FifthButton")
                    {
                        star.IsChecked = false;

                    }

                }
            }
            else if (sender.Equals(ThirdStar))
            {

            }
            else if (sender.Equals(FourthStar))
            {

            }
            else if (sender.Equals(FifthStar))
            {

            }

        }
    }
}
