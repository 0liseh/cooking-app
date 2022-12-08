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
            IEnumerable<ToggleButton> stars = RatingSystemStars.Children.OfType<ToggleButton>();

            if (sender.Equals(FirstStar))
            {
                
                if (stars.ElementAt(0).IsChecked ?? false)
                {
                    stars.ElementAt(0).IsChecked = true;
                    
                }
                else
                {
                    stars.ElementAt(0).IsChecked = false;
                    stars.ElementAt(1).IsChecked = false;
                    stars.ElementAt(2).IsChecked = false;
                    stars.ElementAt(3).IsChecked = false;
                    stars.ElementAt(4).IsChecked = false;
                }

            }
            else if (sender.Equals(SecondStar))
            {
                stars.ElementAt(0).IsChecked = true;

                if (stars.ElementAt(1).IsChecked ?? false)
                {
                    stars.ElementAt(1).IsChecked = true;
                    
                }
                else
                {
                    stars.ElementAt(1).IsChecked = false;
                    stars.ElementAt(2).IsChecked = false;
                    stars.ElementAt(3).IsChecked = false;
                    stars.ElementAt(4).IsChecked = false;
                }

            }
            else if (sender.Equals(ThirdStar))
            {
                stars.ElementAt(0).IsChecked = true;
                stars.ElementAt(1).IsChecked = true;

                if (stars.ElementAt(2).IsChecked ?? false)
                {
                    stars.ElementAt(2).IsChecked = true;
                    
                }
                else
                {
                    stars.ElementAt(2).IsChecked = false;
                    stars.ElementAt(3).IsChecked = false;
                    stars.ElementAt(4).IsChecked = false;
                }
            }
            else if (sender.Equals(FourthStar))
            {
                stars.ElementAt(0).IsChecked = true;
                stars.ElementAt(1).IsChecked = true;
                stars.ElementAt(2).IsChecked = true;

                if (stars.ElementAt(3).IsChecked ?? false)
                {
                    stars.ElementAt(3).IsChecked = true;
                    
                }
                else
                {
                    stars.ElementAt(3).IsChecked = false;
                    stars.ElementAt(4).IsChecked = false;
                }
            }
            else if (sender.Equals(FifthStar))
            {
                stars.ElementAt(0).IsChecked = true;
                stars.ElementAt(1).IsChecked = true;
                stars.ElementAt(2).IsChecked = true;
                stars.ElementAt(3).IsChecked = true;
                if (stars.ElementAt(4).IsChecked ?? false)
                {
                    stars.ElementAt(4).IsChecked = true;
                }
                else
                {
                    stars.ElementAt(4).IsChecked = false;
                }

            }

        }
    }
}
