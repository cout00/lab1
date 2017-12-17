using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    [ImmediateDraw]
    public class FunctionRealInverse :Function
    {
        Function FFunction;

        public override event EventHandler<FuncEventArgs> OnNewPoint;
        public FunctionRealInverse(Function inpFunc)
        {
            FFunction = inpFunc;
        }

        protected override void FillList()
        {
            foreach (var item in FFunction)
            {
                Add(new System.Drawing.PointF(item.Y, item.X));
            }
            this.SortByX();
        }
    }
}
