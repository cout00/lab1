using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static alglib;

namespace Core
{
    [ImmediateDraw]
    public class FurieFunctionInverse:FurieFunction
    {
        FurieFunction _furieFunc;

        public FurieFunctionInverse(FurieFunction furieFunc)
        {
            _furieFunc = furieFunc;
            Series.Name = "обр преобр"+furieFunc.Series.Name;
            Series.ChangeView(DevExpress.XtraCharts.ViewType.Spline);         
        }

        protected override void FillList()
        {
            var arguments = _furieFunc.ComplexArr.Select(a => new complex(a.Real,a.Imaginary)).ToArray();
            double[] outPutArr;
            alglib.fftr1dinv(arguments,out outPutArr);
            var startDt = 0f;
            foreach (var item in outPutArr)
            {
                Add(new System.Drawing.PointF(startDt, (float)item));
                startDt += 1;
            }
        }

    }
}
