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
    /// Interaction logic for RecipeCard.xaml
    /// </summary>
    public partial class RecipeCard : UserControl
    {

        private string title;
        public string Title
        {
            get { return title; }
            set
            {
                title = value;
                this.TitleSearchText.Content = this.title;
            }

        }

        private string duration;
        public string Duration
        {
            get { return duration; }
            set
            {
                duration = value;
                this.DurationSearchText.Content = this.duration;
            }

        }

        private string rating;
        public string Rating
        {
            get { return rating; }
            set
            {
                rating = value;
                this.RatingSearchText.Content = this.rating;
            }

        }

        private string difficulty;
        public string Difficulty
        {
            get { return difficulty; }
            set
            {
                difficulty = value;
                this.DifficultySearchText.Content = this.difficulty;
            }

        }

        private ImageSource img;
        public ImageSource ImageCard
        {
            get { return img; }
            set
            {
                img = value;
                this.ImgSearchCard.Source = this.img;
            }

        }

        public RecipeCard()
        {
            InitializeComponent();
        }
    }
}
