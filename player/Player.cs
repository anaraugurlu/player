using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace player
{
   public class Player
    {
        #region s
        public Player(State state)
        {
            this.Change(state);
        }
        public void Change(State state)
        {
            this._state = state;
            this._state.SetPlayer(this);
        }
        
        public void ClickPlay(Path path,MediaPlayer player,  MainWindow window)
        {
            this._state.ClickPlay(path ,player,  window);
        }
        public void ClickPause( Path path,MediaPlayer player, MainWindow window)
        {
            this._state.ClickPause(path,player,  window);
        }
        public void ClickStop( Path path,MediaPlayer player, MainWindow window)
        {
            this._state.ClickStop(path,player,  window);
        }

     
        private State _state = null;
        #endregion 
    }
}
