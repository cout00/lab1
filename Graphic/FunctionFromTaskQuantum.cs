using DevExpress.XtraCharts;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graphic
{
    public class FunctionFromTaskQuantum:Function
    {
        public override event EventHandler<FuncEventArgs> OnNewPoint;

        public FunctionFromTaskQuantum(Function inpF):base()
        {
            AddRange(inpF);
            Series.Name = GetType().Name;
            Series.ChangeView(ViewType.Line);
            olviewType = ViewType.Line;
            Left = inpF.Left;
            Right = inpF.Right;
            QuantumAbs = inpF.QuantumAbs;

        }

        protected override void FillList()
        {
            if (QuantumOrd != 0)
            {
                var MaxOrd = this.Max((d) => d.Y);
                var MinOrd = this.Min((d) => d.Y);
                var modMax = MaxOrd % QuantumOrd;
                var modMin = MinOrd % QuantumOrd;
                MaxOrd = MaxOrd > 0 ? MaxOrd - modMax : MaxOrd + modMax;
                MinOrd = MinOrd > 0 ? MinOrd + modMin : MinOrd - modMin;
                var quantumGridArray = new List<float>();
                var mantissa = 0;
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

                        if (Math.Round(curNear, mantissa) == Math.Round(bound, mantissa))
                        {
                            if (modNear > QuantumOrd / 2)
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
                    OnNewPoint?.Invoke(this, new FuncEventArgs(this[i]));
                }
            }
        }

    }
}
