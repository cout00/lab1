using DevExpress.XtraCharts;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Graphic
{
    public class FunctionFromTask :Function
    {
        public FunctionFromTask() : base()
        {
            Series.Name = GetType().Name;
            Series.ChangeView(ViewType.Spline);
            olviewType = ViewType.Spline;
        }

        public override event EventHandler<FuncEventArgs> OnNewPoint;

        protected override void FillList()
        {
            for (float Left = this.Left; Left < Right;)
            {
                var NotQuantedOrd = (float)Math.Sin(Left) * (float)Math.Pow(Math.E, (-Math.Sin(Left / 2)));

                Add(new PointF(Left, NotQuantedOrd));
                if (QuantumOrd == 0)
                {
                    OnNewPoint?.Invoke(this, new FuncEventArgs(new PointF(Left, NotQuantedOrd)));
                }
                Left += QuantumAbs;
            }

           
        }
    }
}
