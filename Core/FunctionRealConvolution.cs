using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    [ImmediateDraw]
    public class FunctionRealConvolution :Function
    {
        Function FFuncMain;
        Function FFuncSeed;
        public override event EventHandler<FuncEventArgs> OnNewPoint;
        public FunctionRealConvolution(Function AFuncLeft, Function AFuncRight)
        {
            FFuncMain = AFuncLeft;
            FFuncSeed = AFuncRight;
            Series.Name = "конв" + AFuncLeft.Series.Name+" "+AFuncRight.Series.Name;
            Series.ChangeView(DevExpress.XtraCharts.ViewType.Line);
        }


        protected override void FillList()
        {
            var convLength = FFuncMain.Count + FFuncSeed.Count - 2;
            List<PointF> a = new List<PointF>(FFuncMain);
            for (int i = 0; i < FFuncSeed.Count-1; i++)
            {
                a.Insert(0,new PointF());
            }
            List<PointF> b = new List<PointF>(FFuncSeed);
            b.Reverse();
            for (int i = 0; i < FFuncMain.Count-1; i++)
            {
                b.Add(new PointF());
            }
            for (int i = 0; i <= convLength; i++)
            {
                var sum = 0f;
                for (int j = 0; j < a.Count; j++)
                {
                    sum += a[j].Y * b[j].Y;
                }
                Add(new PointF(i,sum));
                b.Insert(0,new PointF());
                b.RemoveAt(b.Count - 1);
            }
        }
    }
}
