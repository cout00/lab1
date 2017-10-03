using DevExpress.XtraCharts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graphic
{
    public class KotelnikovSmooth :Function
    {
        public override event EventHandler<FuncEventArgs> OnNewPoint;
        KotelnikovFunction inpFunc;

        public KotelnikovSmooth(KotelnikovFunction inpF)
        {
            Series.Name = GetType().Name;
            Series.ChangeView(ViewType.Spline);
            olviewType = ViewType.Spline;
            inpFunc = inpF;
        }
        protected override void FillList()
        {
            var max = inpFunc.Select(a => a.Y).Max()*0.01;

            for (int i = 0; i < inpFunc.Count; i++)
            {
                if (inpFunc[i].Y<max)
                {
                    Add(inpFunc[i]);
                    OnNewPoint?.Invoke(this, new FuncEventArgs(inpFunc[i]));
                }
            }
        }
    }
}
