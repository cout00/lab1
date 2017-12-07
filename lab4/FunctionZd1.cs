using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core;
using System.Drawing;

namespace lab4
{
    [ImmediateDraw]
    class FunctionZd1 :FunctionZd
    {
        const float SHIFT = 1f;
        protected override void FillList()
        {
            Left = 9.4f;
            Right = 11.4f;
            QuantumAbs = 0.002f;
            for (float i = Left+SHIFT; i <= Right+SHIFT; i += QuantumAbs)
            {
                var func = GetInputFunction(i);
                PointF point = new PointF(i - SHIFT, func);
                Add(point);
            }
        }

        public FunctionZd1(FunctionUd funcU, FunctionVd funcV) : base(funcU, funcV)
        {
            Series.Name = "zd1";
        }
    }
}
