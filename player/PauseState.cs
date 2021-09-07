using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media;

namespace player
{
    public class StatePause : State
    {
        public MediaPlayer MediaPlayer { get; set; }
        public StatePause(MediaPlayer player)
        {
            MediaPlayer = player;
        }






       

        public override void ClickPause(Path path, MediaPlayer player, MainWindow window)
        {
            player.Pause();

        }

        public override void ClickPlay(Path path, MediaPlayer player, MainWindow window)
        {
          
            MessageBox.Show("");


        }

        public override void ClickStop(Path path, MediaPlayer player, MainWindow window)
        {
            MessageBox.Show("");

        }

       
    }
}
