using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media;

namespace player
{





































    public class StatePlay : State
    {
        public MediaPlayer MediaPlayer { get; set; }
        public StatePlay(MediaPlayer player)
        {
            MediaPlayer = player;
        }
       

      

        

       
        public override void ClickPause(Path path, MediaPlayer player, MainWindow window)
        {
            MessageBox.Show("");
        }

        public override void ClickPlay(Path path, MediaPlayer player, MainWindow window)
        {
            player.Play();

        }

        public override void ClickStop(Path path, MediaPlayer player, MainWindow window)
        {
            MessageBox.Show("");

        }

       
    }
}
