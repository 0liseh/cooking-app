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
    /// Interaction logic for FilterPage.xaml
    /// </summary>
    public partial class FilterPage : Page
    {
        public FilterPage()
        {
            InitializeComponent();
        }

        private void Back_Click(object sender, RoutedEventArgs e)
        {

        }

        int click = 0;
        private void Meal_click(object sender, RoutedEventArgs e)
        {

            click++;
            RadioButton s = (RadioButton)sender;
            s.IsChecked = click % 2 == 1;
            click %= 2;

        }

        int dLclick1 = 0;
        private void DiffLevel_click(object sender, RoutedEventArgs e)
        {

            dLclick1++;
            RadioButton s = (RadioButton)sender;
            s.IsChecked = dLclick1 % 2 == 1;
            dLclick1 %= 2;

        }
        int DietClick1 = 0;
        private void Diet_Click(object sender, RoutedEventArgs e)
        {

            DietClick1++;
            RadioButton s = (RadioButton)sender;
            s.IsChecked = DietClick1 % 2 == 1;
            DietClick1 %= 2;

        }

        int Cus_Click1 = 0;
        private void Cusine_Click(object sender, RoutedEventArgs e)
        {
            Cus_Click1++;
            RadioButton s = (RadioButton)sender;
            s.IsChecked = Cus_Click1 % 2 == 1;
            Cus_Click1 %= 2;


        }

        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {

        }
    }
}
