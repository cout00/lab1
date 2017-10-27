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

        public Boolean OnlyResult { get; set; } = false;
        //public Series Serieses;

        protected ViewType olviewType;

        public string FunctionName;

        public Series Series { get; set; }
        

        public void DestroySeries()
        {
            var tag = Series.Tag;

            Series = new Series();
            Series.ChangeView(olviewType);
            Series.Name = FunctionName;
            Series.Tag = tag;
        }


        protected float T;
        public abstract event EventHandler<FuncEventArgs> OnNewPoint;
        public void Build()
        {
            if (QuantumAbs != -1 && QuantumOrd != -1)
            {
                Clear();
                FillList();
            }
            
        }
        protected float GetInputFunction(float Left)
        {
            //return (float)(Math.Sin(Math.Sqrt(1 + Left * Left)));
            return (float)Math.Sin(Left) * (float)Math.Pow(Math.E, (Math.Cos(Left / 3)));
        }
        public Function()
        {
            Series = new DevExpress.XtraCharts.Series();
            Series.Tag = GetType().Name;
            
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
