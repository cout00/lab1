using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graphic
{
    public abstract class Function :List<PointF>
    {
        public float Left { get; set; }
        public float Right { get; set; }
        public float QuantumAbs { get; set; }
        public float QuantumOrd { get; set; }

        protected float T;

        public abstract event EventHandler<FuncEventArgs> OnNewPoint;

        public void Build()
        {           
            if (QuantumAbs!=-1&&QuantumOrd!=-1)
            {                
                FillList();
            }            
        }

        protected abstract void FillList();       
    }

    public class FuncEventArgs:EventArgs
    {
        public PointF point { get; private set; }

        public FuncEventArgs(PointF nP)
        {
            point = nP;
        }
    }

    

}
