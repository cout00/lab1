using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core;

namespace Core
{
    [ImmediateDraw]
    public class FunctionContiniousCorrelation :Function
    {
        public override event EventHandler<FuncEventArgs> OnNewPoint;
        protected Function _inpFuncLeft;
        protected Function _inpFuncRight;
        protected float maxTau;
        protected bool isAuto;
        protected bool isCov;

        public FunctionContiniousCorrelation(Function inpFuncLeft,Function inpFuncRight, bool isAuto, float maxTau, bool isCov)
        {
            _inpFuncLeft = inpFuncLeft;
            _inpFuncRight = inpFuncRight;
            if (!isAuto&&_inpFuncLeft.Count!=_inpFuncRight.Count)
            {
                throw new Exception("Wrong params count must be equal");               
            }
            this.maxTau = maxTau;
            this.isAuto = isAuto;
            this.isCov = isCov;
            Left = _inpFuncLeft.Left;
            Right = _inpFuncLeft.Right;
            QuantumAbs = _inpFuncLeft.QuantumAbs;
            Series.ChangeView(DevExpress.XtraCharts.ViewType.Spline);         
            Series.Name = !isAuto?"Кор функция" + inpFuncLeft.Series.Name: "Автокор функ" + inpFuncLeft.Series.Name;
            Series.Name += inpFuncRight != null ? @"\" + inpFuncRight.Series.Name:"";
            Series.Name += isCov ? "ков ":"";
        }

        protected override void FillList()
        {
            var avgLeft = _inpFuncLeft.Average(a => a.Y);
            var avgRight = _inpFuncRight!=null?_inpFuncRight.Average(a => a.Y):0;
            for (float i = 0; i < maxTau; i+=QuantumAbs)
            {
                var sum = 0f;
                for (int j = 0; j < _inpFuncLeft.Count; j++)
                {
                    if (isAuto)
                    {
                        sum += (_inpFuncLeft[j].Y-(isCov?avgLeft:0)) * (_inpFuncLeft.GetInputFunction(_inpFuncLeft[j].X + i)-(isCov ? avgLeft : 0));
                        continue;
                    }
                    sum += (_inpFuncLeft[j].Y - (isCov ? avgLeft : 0))  * (_inpFuncRight.GetInputFunction(_inpFuncRight[j].X + i) - (isCov ? avgRight : 0));
                }
                Add(new System.Drawing.PointF(i, sum/(_inpFuncLeft.Last().X-_inpFuncLeft.First().X)));
            }
        }
    }
}
