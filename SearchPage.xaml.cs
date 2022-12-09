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
    /// Interaction logic for SearchPage.xaml
    /// </summary>
    public partial class SearchPage : Page
    {
        String search;

        public static bool onSavedPage = false;
        public static bool onHomePage = false;

        //Initial values 
        String recentOne = "Mac and Cheese";
        String recentTwo = "30 minute Ramen";
        String recentThree = "Poke";
        String recentFour = "Burritos";
        String recentFive = "Easy Pizza";
        String recentSix = "Chicken Salad";
        String recentSeven = "Apple pie";
        String recentEight = "Overnight oats";
        String recentNine = "Turkey";
        public SearchPage()
        {
            InitializeComponent();

        }

        // Will get rid of the text in the search bar 
        private void searchBar_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            searchBar.Text = "";

        }

        //This will get rid of all the recently searched 
        private void clear_Click(object sender, RoutedEventArgs e)
        {
            recent1.Text = "";
            recentOne = "";

            recent2.Text = "";
            recentTwo = "";

            recent3.Text = "";
            recentThree = "";

            recent4.Text = "";
            recentFour = "";

            recent5.Text = "";
            recentFive = "";

            recent6.Text = "";
            recentSix = "";

            recent7.Text = "";
            recentSeven = "";

            recent8.Text = "";
            recentEight = "";

            recent9.Text = "";
            recentNine = "";
        }

        private void recent1_Click(object sender, RoutedEventArgs e)
        {

        }
        private void recent2_Click(object sender, RoutedEventArgs e)
        {

        }
        private void recent3_Click(object sender, RoutedEventArgs e)
        {

        }
        private void recent4_Click(object sender, RoutedEventArgs e)
        {

        }
        private void recent5_Click(object sender, RoutedEventArgs e)
        {

        }
        private void recent6_Click(object sender, RoutedEventArgs e)
        {

        }
        private void recent7_Click(object sender, RoutedEventArgs e)
        {

        }
        private void recent8_Click(object sender, RoutedEventArgs e)
        {

        }
        private void recent9_Click(object sender, RoutedEventArgs e)
        {

        }

        private void del_Click(object sender, RoutedEventArgs e)
        {

            if (searchBar.Text != null && searchBar.Text != "")
            {
                search = search.Substring(0, search.Length - 1);
                searchBar.Text = searchBar.Text.Substring(0, searchBar.Text.Length - 1);
            }
        }

        private void enter_Click(object sender, RoutedEventArgs e)
        {
            //Gets rid of search
            search = searchBar.Text;
            searchBar.Text = "`";

            //Adds the search to the recently searched
            recent9.Text = recentEight;
            recentNine = recentEight;

            recent8.Text = recentSeven;
            recentEight = recentSeven;

            recent7.Text = recentSix;
            recentSeven = recentSix;

            recent6.Text = recentFive;
            recentSix = recentFive;

            recent5.Text = recentFour;
            recentFive = recentFour;

            recent4.Text = recentThree;
            recentFour = recentThree;

            recent3.Text = recentTwo;
            recentThree = recentTwo;

            recent2.Text = recentOne;
            recentTwo = recentOne;

            recent1.Text = search;
            recentOne = search;

            //Navigate to the recipe results page 

        }

        private void shift_Click(object sender, RoutedEventArgs e)
        {

        }

        private void space_Click(object sender, RoutedEventArgs e)
        {
            search = search + " ";
            searchBar.Text = searchBar.Text + " ";
        }

        private void num_Click(object sender, RoutedEventArgs e)
        {
            //I dont know what this will do 
        }

        private void q_Click(object sender, RoutedEventArgs e)
        {
            searchBar.Text = searchBar.Text + "q";
        }
        private void w_Click(object sender, RoutedEventArgs e)
        {
            searchBar.Text = searchBar.Text + "w";
        }
        private void e_Click(object sender, RoutedEventArgs e)
        {

            searchBar.Text = searchBar.Text + "e";
        }
        private void r_Click(object sender, RoutedEventArgs e)
        {

            searchBar.Text = searchBar.Text + "r";
        }
        private void t_Click(object sender, RoutedEventArgs e)
        {
            searchBar.Text = searchBar.Text + "t";
        }
        private void y_Click(object sender, RoutedEventArgs e)
        {
            searchBar.Text = searchBar.Text + "y";
        }
        private void u_Click(object sender, RoutedEventArgs e)
        {
            searchBar.Text = searchBar.Text + "u";
        }
        private void i_Click(object sender, RoutedEventArgs e)
        {
            searchBar.Text = searchBar.Text + "i";
        }
        private void o_Click(object sender, RoutedEventArgs e)
        {
            searchBar.Text = searchBar.Text + "o";
        }
        private void p_Click(object sender, RoutedEventArgs e)
        {
            searchBar.Text = searchBar.Text + "p";
        }
        private void a_Click(object sender, RoutedEventArgs e)
        {
            searchBar.Text = searchBar.Text + "a";
        }
        private void s_Click(object sender, RoutedEventArgs e)
        {
            searchBar.Text = searchBar.Text + "s";
        }
        private void d_Click(object sender, RoutedEventArgs e)
        {
            searchBar.Text = searchBar.Text + "d";
        }
        private void f_Click(object sender, RoutedEventArgs e)
        {
            searchBar.Text = searchBar.Text + "f";
        }
        private void g_Click(object sender, RoutedEventArgs e)
        {
            searchBar.Text = searchBar.Text + "g";
        }
        private void h_Click(object sender, RoutedEventArgs e)
        {
            searchBar.Text = searchBar.Text + "h";
        }
        private void j_Click(object sender, RoutedEventArgs e)
        {
            searchBar.Text = searchBar.Text + "j";
        }
        private void k_Click(object sender, RoutedEventArgs e)
        {
            searchBar.Text = searchBar.Text + "k";
        }
        private void l_Click(object sender, RoutedEventArgs e)
        {
            searchBar.Text = searchBar.Text + "l";
        }
        private void z_Click(object sender, RoutedEventArgs e)
        {
            searchBar.Text = searchBar.Text + "z";
        }
        private void x_Click(object sender, RoutedEventArgs e)
        {
            searchBar.Text = searchBar.Text + "x";
        }
        private void c_Click(object sender, RoutedEventArgs e)
        {
            searchBar.Text = searchBar.Text + "c";
        }
        private void v_Click(object sender, RoutedEventArgs e)
        {
            searchBar.Text = searchBar.Text + "v";
        }
        private void b_Click(object sender, RoutedEventArgs e)
        {
            searchBar.Text = searchBar.Text + "b";
        }
        private void n_Click(object sender, RoutedEventArgs e)
        {
            searchBar.Text = searchBar.Text + "n";
        }
        private void m_Click(object sender, RoutedEventArgs e)
        {
            searchBar.Text = searchBar.Text + "m";
        }

        private void back_click(object sender, RoutedEventArgs e)
        {
            if(MenuButtons.onSavedRecipesPage == true)
            {
                MainWindow.NavigateToPage(MenuButtons.savedRecipesPage);
            }else if (MenuButtons.onHomePage == true)
            {
                MainWindow.NavigateToPage(MenuButtons.homePage);
            }
        }
    }
}
