using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.SimpleFunctions
{
    [ImmediateDraw]
    public class FunctionCustom :Function
    {
        public override event EventHandler<FuncEventArgs> OnNewPoint;
        public FunctionCustom(params float[] prms)
        {
            Series.Name = "польз ф " + DateTime.Now.Millisecond.GetHashCode();
            for (int i = 0; i < prms.Length; i++)
            {
                Add(new System.Drawing.PointF(i, prms[i]));
            }
        }


        protected override void FillList()
        {
            
        }
    }
}
