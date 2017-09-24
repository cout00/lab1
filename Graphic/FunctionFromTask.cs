using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Graphic
{
    public class  FunctionFromTask :Function
    {
        

        public FunctionFromTask()
        {
            T = 12 / 1000F;
        }

        protected override void FillList()
        {
            

            var StartQuantedOrd = (float)Math.Sin(Left) * (float)Math.Pow(Math.E, (-Math.Sin(Left / 2)));
            for (float Left = this.Left; Left < Right;)
            {
                var NotQuantedOrd = (float)Math.Sin(Left) * (float)Math.Pow(Math.E, (-Math.Sin(Left / 2)));

                Add(new PointF(Left, NotQuantedOrd));
                
                Left += QuantumAbs;
            }

            if (QuantumOrd != 0)
            {
                var MaxOrd = this.Max((d) => d.Y);
                var MinOrd = this.Min((d) => d.Y);
                var modMax = MaxOrd % QuantumOrd;
                var modMin = MinOrd % QuantumOrd;
                MaxOrd = MaxOrd > 0 ? MaxOrd - modMax : MaxOrd + modMax;
                MinOrd = MinOrd > 0 ? MinOrd + modMin : MinOrd - modMin;
                var quantumGridArray = new List<float>();
                var mantissa=0;
                try
                {
                    mantissa = QuantumOrd.ToString().Split(',')[1].Count();
                }
                catch (Exception)
                {
                }                
                for (float i = MinOrd; i <= MaxOrd; i += QuantumOrd)
                {
                    quantumGridArray.Add(i);
                }
                for (int i = 0; i < Count; i++)
                {
                    var modNear = this[i].Y % QuantumOrd;
                    var curNear = this[i].Y - modNear;

                    foreach (var bound in quantumGridArray)
                    {
                        
                        if (Math.Round(curNear,mantissa) == Math.Round(bound,mantissa))
                        {
                            if (modNear>QuantumOrd/2)
                            {
                                PointF p = new PointF(this[i].X, bound + QuantumOrd);
                                this[i] = p;
                            }
                            else
                            {
                                PointF p = new PointF(this[i].X, bound);
                                this[i] = p;
                            }
                        }
                    }
                }


                
                


            }
        }
    }
}
