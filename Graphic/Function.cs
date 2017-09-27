using DevExpress.XtraCharts;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graphic
{
    [Serializable]
    public abstract class Function :List<PointF>
    {
        public float Left { get; set; }
        public float Right { get; set; }
        public float QuantumAbs { get; set; }
        public float QuantumOrd { get; set; }

        //public Series Serieses;

        protected ViewType olviewType;

        public Series Series { get; set; }
        

        public void DestroySeries()
        {
            Series = new Series();
            Series.ChangeView(olviewType);
            Series.Name = GetType().Name;
        }


        protected float T;
        public abstract event EventHandler<FuncEventArgs> OnNewPoint;
        public void Build()
        {
            if (QuantumAbs != -1 && QuantumOrd != -1)
            {
                FillList();
            }
        }

        public Function()
        {
            Series = new DevExpress.XtraCharts.Series();
        }
        protected abstract void FillList();
    }

    public class FuncEventArgs :EventArgs
    {
        public PointF point { get; private set; }

        public FuncEventArgs(PointF nP)
        {
            point = nP;
        }
    }



}
