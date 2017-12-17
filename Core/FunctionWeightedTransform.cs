using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    [ImmediateDraw]
    class FunctionWeightedTransform :Function
    {
        Function FFunc1;
        Function FFunc2;

        public FunctionWeightedTransform(Function AFunc1, Function AFunc2)
        {
            Series.Name = "взвеш пр " + AFunc1.Series.Name + "+" + AFunc2.Series.Name;
            FFunc1 = AFunc1;
            FFunc2 = AFunc2;
            Series.ChangeView(DevExpress.XtraCharts.ViewType.Line);
        }

        public override event EventHandler<FuncEventArgs> OnNewPoint;

        protected override void FillList()
        {
            for (int i = 0; i < FFunc1.Count; i++)
            {
                Add(new PointF(FFunc1[i].X, FFunc1[i].Y * FFunc2[i].Y));
            }
        }

    }
}
