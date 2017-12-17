using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Core.WindowsList
{
    [ImmediateDraw]
   public class WindowBarlette :Window
    {
        public WindowBarlette(Function AInpFunc, Tuple<float, float> InterestRegion) : base(AInpFunc,InterestRegion)
        {
            Series.Name += Windows.Barlette.ToString();
        }

        public override float GetInputFunction(float Left)
        {
            if (Left>=0&&Left<(N-1)/2)
            {
                return 2 * Left/(N - 1);
            }
            if ((Left>(N-1)/2)&&(Left<=N-1))
            {
                return 2 * (N - Left) / (N - 1);
            }
            return 0;
        }

    }
}
