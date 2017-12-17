using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.SimpleFunctions
{
    [ImmediateDraw]
    public class Function_8Bit_1khz_Sinus :Function
    {
        public override event EventHandler<FuncEventArgs> OnNewPoint;

        public Function_8Bit_1khz_Sinus()
        {
            Series.Name = "sin";
            Series.ChangeView(DevExpress.XtraCharts.ViewType.Line);
        }

        public override float GetInputFunction(float Left)
        {
            return (float)Math.Sin(Left*(2*Math.PI/ 10)) * byte.MaxValue;
        }

        protected override void FillList()
        {
            for (float i = Left; i < Right; i+=QuantumAbs)
            {
                Add(new System.Drawing.PointF(i, GetInputFunction(i)));
            }
        }
    }
}
