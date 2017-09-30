using DevExpress.XtraCharts;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Graphic
{
    public class ACHFunction :Function
    {
        List<Complex> listOfHarminics;
        Function func;

        public ACHFunction(Function InpFunction)
        {
            func = InpFunction;
            Series.Name = GetType().Name;
            Series.ChangeView(ViewType.Bar);
            olviewType = ViewType.Bar;
        }

        public override event EventHandler<FuncEventArgs> OnNewPoint;

        protected override void FillList()
        {
            DPF.CallBack = (i,comp) => {
                var p = new PointF(i, (float)comp.Magnitude);
                Add(p);
                OnNewPoint?.Invoke(this, new FuncEventArgs(p));
            };

            listOfHarminics = DPF.GetDpf(func, 100);
        }
    }
}
