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
using System.Xml.Linq;

namespace AdamHoffman_S00197432
{
    
    public partial class MainWindow : Window
    {
        GAMESdata db = new GAMESdata();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            var query = from c in db.Games
                        orderby c.Platform
                        select c;
                        

            

            
            LBX_GameList.ItemsSource = query.ToList();
           
        }

        private void LBX_GameList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Game SelectedGame = LBX_GameList.SelectedItem as Game;
            if(SelectedGame != null)
            {
                TXTBLK_GameDetails.Text = SelectedGame.MetaCriticScore;
                IMGBOX_Game.Source = new BitmapImage(new Uri(SelectedGame.Game_image, UriKind.Relative));
            }
        }
    }
}
