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
        public KotelnikovFunction(Function InpFunction):base()
        {
            FunctionName = "Восстановленная функция";
            this.InpFunction = InpFunction;
            Series.Name = FunctionName;
            nu = (Math.Abs(InpFunction.Right) - Math.Abs(InpFunction.Left)) / InpFunction.QuantumAbs;
        }
        public override event EventHandler<FuncEventArgs> OnNewPoint;
        protected override void FillList()
        {
            Left = InpFunction.Left;
            Right = InpFunction.Right;
            QuantumAbs = InpFunction.QuantumAbs/2;
            float omega = (float)((2 * Math.PI) *nu);
            for (float i = Left; i < Right; i += QuantumAbs)
            {
                var sum = 0F;
                foreach (var item in InpFunction)
                {
                    if (i - item.X==0)
                    {
                        //sum++;
                        continue;
                    }
                    var coeff = (float)(omega * (i - item.X));
                    sum += item.Y * ((float)Math.Sin(coeff)/coeff);
                }
                OnNewPoint?.Invoke(this, new FuncEventArgs(new System.Drawing.PointF(i, sum)));
                Add(new System.Drawing.PointF(i, sum));
            }
        }
    }
}
