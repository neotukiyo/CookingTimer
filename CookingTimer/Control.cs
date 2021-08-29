using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;

namespace CookingTimer
{
    public class Control
    {
        private SoundPlayer player = null;
        private string sPath = "";

        public Control(string path)
        {
            sPath = path;
        }

        public void StartMusic()
        {
            // ミュージックファイルの取得
            player = new SoundPlayer(sPath);

            player.Play(); //非同期再生 
            
        }

        public void StopMusic()
        {
            if (player != null)
            {
                player.Stop();
                player.Dispose();
            }
        }

    }
}
