using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    public enum Windows
    {
        Barlette,
        Natol,
        Hemming
    }

    [ImmediateDraw]
    public class Window :Function
    {
        public override event EventHandler<FuncEventArgs> OnNewPoint;

        protected float N;

        public Window(Function AInpFunc)
        {
            Left = 0;
            Right = AInpFunc.Count;
            QuantumAbs = 1;
            Series.Name = "Окно ";
            N = AInpFunc.Count / QuantumAbs;
        }


        protected override void FillList()
        {
            for (float i = Left; i < Right; i += QuantumAbs)
            {
                var func = GetInputFunction(i);
                PointF point = new PointF(i, func);
                Add(point);
            }
        }

    }
}
