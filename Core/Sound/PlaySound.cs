using NAudio.Wave;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Core.Sound
{
    public class PlaySound
    {
        Function func;
        StreamPlayer player;
        CancellationTokenSource ts = new CancellationTokenSource();
        CancellationToken ct;
        public PlaySound(Function func)
        {
            this.func = func;
            ct = ts.Token;
        }

        void TaskMethod()
        {
            player = new StreamPlayer(2048);
            player.PlayAsync();
            while (true)
            {
                for (int i = 0; i < func.Count; i++)
                {
                    var v = (short)(func[i].Y * 1000);
                    player.Write(v);
                    
                }
                if (ct.IsCancellationRequested)
                {
                    break;
                }
                Thread.Sleep(50);
            }
        }

        public void Play()
        {            
           Task.Factory.StartNew(TaskMethod, ct);                                
        }

        public void Stop()
        {
            player.Stop();
            ts.Cancel();
        }


    }
}
