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
        Hemming,
        Rectangle
    }

    [ImmediateDraw]
    public class Window :Function
    {
        public override event EventHandler<FuncEventArgs> OnNewPoint;

        protected float N;
        Tuple<float, float> FInterestRegion;

        public Window(Function AInpFunc, Tuple<float,float> InterestRegion)
        {
            Left = 0;
            Right = AInpFunc.Count;
            QuantumAbs = 1;
            Series.Name = "Окно ";
            FInterestRegion = InterestRegion;
            N = FInterestRegion.Item2.AbsDiff(FInterestRegion.Item1) / QuantumAbs;
        }


        protected override void FillList()
        {
            float regionInterval = 0f;
            for (float i = Left; i < Right; i += QuantumAbs)
            {
                if (i>=FInterestRegion.Item1 && i <= FInterestRegion.Item2)
                {
                    var func = GetInputFunction(regionInterval);
                    PointF point = new PointF(i, func);
                    Add(point);
                    regionInterval += QuantumAbs;
                }
                else
                    Add(new PointF(i,0));
            }
        }

    }
}
