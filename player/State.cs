using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace player
{
    abstract public class State
    {
        protected Player _player;
        public void SetPlayer(Player player)
        {
            this._player = player;
        }

        public abstract void ClickPause(Path path, MediaPlayer player, MainWindow window);
        public abstract void ClickPlay(Path path, MediaPlayer player, MainWindow window);
        public abstract void ClickStop(Path path, MediaPlayer player, MainWindow window);

    }
}
