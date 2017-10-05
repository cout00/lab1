using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graphic
{
    public class FunctionQuantMistake :Function
    {
        public override event EventHandler<FuncEventArgs> OnNewPoint;
        Function inpFunction;

        public FunctionQuantMistake(Function inpFunc)
        {
            FunctionName = "Ошибка восстановления";
            Series.Name = FunctionName;
            inpFunction = inpFunc;
            Series.ChangeView(DevExpress.XtraCharts.ViewType.Spline);
        }

        protected override void FillList()
        {
            for (float i = 0; i < Math.Abs(inpFunction.Right-inpFunction.Left); i+=0.2f)
            {
                FunctionFromTaskQuantum quantedFunc = new FunctionFromTaskQuantum(inpFunction) { QuantumOrd = i, OnlyResult = true };
                quantedFunc.Build();
                SquareAproximationMistakeFunction aprox = new SquareAproximationMistakeFunction(quantedFunc) { OnlyResult = true };
                aprox.Build();
                var sum = aprox.Sum(a => Math.Abs(a.Y));
                OnNewPoint(this, new FuncEventArgs(new System.Drawing.PointF(i, sum)));

            }
        }
    }
}
