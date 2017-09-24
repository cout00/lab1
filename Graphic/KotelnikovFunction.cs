using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graphic
{
    public class KotelnikovFunction :FunctionFromTask
    {
        Function InpFunction;
        double nu;
        public KotelnikovFunction(Function InpFunction)
        {
            this.InpFunction = InpFunction;
            nu = (Math.Abs(InpFunction.Left) + Math.Abs(InpFunction.Right)) / InpFunction.QuantumAbs;
        }

        protected override void FillList()
        {
                       
            float omega = (float)((2 * Math.PI) / T);
            for (float i = Left; i < Right; i += QuantumAbs)
            {
                var sum = 0F;
                foreach (var item in InpFunction)
                {
                    if (i - item.X==0)
                    {
                        continue;
                    }
                    var coeff = (float)(Math.PI * (i - item.X)/InpFunction.QuantumAbs);
                    sum += item.Y * ((float)Math.Sin(coeff)/coeff);
                }
                Add(new System.Drawing.PointF(i, sum));
            }
            var me = 1 ;
        }
    }
}
