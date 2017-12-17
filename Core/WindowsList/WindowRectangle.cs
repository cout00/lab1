using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.WindowsList
{
    [ImmediateDraw]
    public class WindowRectangle :Window
    {
        public WindowRectangle(Function AInpFunc, Tuple<float, float> InterestRegion) : base(AInpFunc, InterestRegion)
        {
            Series.Name += Windows.Rectangle.ToString();
        }

        public override float GetInputFunction(float Left)
        {
            return 1;
        }
    }
}
