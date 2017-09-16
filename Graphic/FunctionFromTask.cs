using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graphic
{
    class FunctionFromTask :Function
    {
        protected override void FillList()
        {
            var StartQuantedOrd = (float)Math.Sin(Left) * (float)Math.Pow(Math.E, (-Math.Sin(Left / 2)));
            for (float Left = this.Left; Left < Right;)
            {
                var NotQuantedOrd = (float)Math.Sin(Left) * (float)Math.Pow(Math.E, (-Math.Sin(Left / 2)));
                if (QuantumOrd == 0)
                {
                    Add(new PointF(Left, NotQuantedOrd));
                }
                else
                {
                    if (NotQuantedOrd < (StartQuantedOrd + StartQuantedOrd / 2))
                    {
                        Add(new PointF(Left, StartQuantedOrd));
                    }
                    else
                    {
                        Add(new PointF(Left, StartQuantedOrd + QuantumOrd));
                    }
                    StartQuantedOrd += QuantumOrd;
                }
                Left += QuantumAbs;
            }
        }
    }
}
