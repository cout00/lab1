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
        static public List<Complex> GetDpf(Function func, int count)
        {
            var arr = new List<Complex>();
            for (int u = 0; u < count; u++)
            {
                //цикл суммы 
                Complex summa = new Complex();
                for (int k = 0; k < func.Count; k++)
                {
                    Complex S = new Complex(func[k].X, func[k].Y);
                    double koeff = -2 * Math.PI * u * k / func.Count;
                    Complex e = new Complex(Math.Cos(koeff), Math.Sin(koeff));
                    summa += (S * e);
                }
                arr.Add(summa / func.Count);
            }
            return arr;
        }

    }
}
