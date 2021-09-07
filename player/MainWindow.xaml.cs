using Microsoft.Win32;
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
using System.Windows.Threading;

namespace player
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
       

        public Path path { get; set; }
        public MainWindow()
        {
            
                 Path path = new Path
                 {
                     path = "../../Images/mp3indirdur-DJ-Snake-Loco-Contigo-ft-J-Balvin-Tyga.mp3"
                 };

            player.Open(new Uri(path.path, UriKind.RelativeOrAbsolute));


            this.DataContext = this;
            InitializeComponent();
            MessageBox.Show("Click Music");
        }
        private MediaPlayer player = new MediaPlayer();
      
        private void Button_Click(object sender, RoutedEventArgs e)
        {

            m.Visibility = Visibility.Visible;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Player play = new Player(new StatePlay(player));
            play.ClickPlay(path, player,this);
            

        }
        
        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            Player play = new Player(new StatePause(player));

            play.ClickPause(path, player, this);

            
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            Player play = new Player(new StateStop(player));

            play.ClickStop(path, player, this);
            
        }
    }
}
