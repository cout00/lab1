using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    [ImmediateDraw]
    public class FunctionDiscretCorrelation :FunctionContiniousCorrelation
    {
        int discretTau;

        public FunctionDiscretCorrelation(Function inpFuncLeft, Function inpFuncRight, bool isAuto, float maxTau, bool isCov) : base(inpFuncLeft, inpFuncRight, isAuto, maxTau, isCov)
        {
            discretTau = (int)maxTau;
            Series.Name = !isAuto ? "дискр Кор функция" + inpFuncLeft.Series.Name : "дискр Автокор функ" + inpFuncLeft.Series.Name;
            Series.Name += inpFuncRight != null ? inpFuncRight.Series.Name:"";
            Series.Name += isCov ? " ков " : "";
        }

        protected override void FillList()
        {
            var avgLeft = _inpFuncLeft.Average(a => a.Y);
            var avgRight = _inpFuncRight != null ? _inpFuncRight.Average(a => a.Y) : 0;
            for (int i = 0; i <= discretTau; i++)
            {
                var sum = 0f;
                for (int j = discretTau; j < _inpFuncLeft.Count; j++)
                {
                    if (isAuto)
                    {
                        sum += (_inpFuncLeft[j].Y - (isCov ? avgLeft : 0)) * (_inpFuncLeft[j - i].Y - (isCov ? avgLeft : 0));
                        continue;
                    }
                    sum += (_inpFuncLeft[j].Y - (isCov ? avgLeft : 0)) * (_inpFuncRight[j - i].Y - (isCov ? avgRight : 0));
                }
                Add(new System.Drawing.PointF(i, sum));
            }
        }

    }
}
