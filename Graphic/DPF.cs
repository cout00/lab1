using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Graphic
{
    static public class DPF
    {

        static int getNearTwoPow(int count)
        {
            int pow = 0;
            while (Math.Pow(2,pow)<count)
            {
                pow++;
            }
            return (int)Math.Pow(2, pow-1);
        }

        public static Action<int,Complex> CallBack;
        static public List<Complex> GetDpf(Function func, int count)
        {
            alglib.complex[] carr;
            var arr1 = (func.Select(a => (double)a.Y)).ToList();
            var nearpow = getNearTwoPow(arr1.Count);
            arr1.RemoveRange(nearpow, arr1.Count - nearpow);       
            alglib.fftr1d(arr1.ToArray(), out carr);
            var arr = new List<Complex>();
            for (int i = -carr.Count()/2; i < carr.Count()/2; i++)
            {
                if (i==0)
                {
                    CallBack?.Invoke(i, new Complex(0, 0));
                    continue;
                }
                CallBack?.Invoke(i, new Complex(carr[i+ carr.Count() / 2].x, carr[i+ carr.Count() / 2].y));
            }
            return arr;
        }

    }
}
