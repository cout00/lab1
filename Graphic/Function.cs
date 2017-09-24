using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graphic
{
    public class Function :List<PointF>
    {
        public float Left { get; set; }
        public float Right { get; set; }
        public float QuantumAbs { get; set; }
        public float QuantumOrd { get; set; }

        protected float T;

        Task<Point> task;

        public void Build()
        {
            
            if (QuantumAbs!=-1&&QuantumOrd!=-1)
            {
                
                FillList();
            }
        }

        protected virtual void FillList()
        {

        }

    }
}
