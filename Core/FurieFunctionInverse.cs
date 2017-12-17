using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static alglib;

namespace Core
{
    [ImmediateDraw]
    public class FurieFunctionInverse :FurieFunction
    {
        FurieFunction _furieFunc;

        public FurieFunctionInverse(FurieFunction furieFunc)
        {
            _furieFunc = furieFunc;
            Series.Name = "обр преобр" + furieFunc.Series.Name;
            Series.ChangeView(DevExpress.XtraCharts.ViewType.Line);
        }

        protected override void FillList()
        {
            var arguments = _furieFunc.ComplexArr.Select(a => new complex(a.Real, a.Imaginary)).ToArray();
            double[] outPutArr;
            try
            {
                alglib.fftr1dinv(arguments, out outPutArr);
                var startDt = 0f;
                foreach (var item in outPutArr)
                {
                    Add(new System.Drawing.PointF(startDt, (float)item));
                    startDt += 1;
                }
            }
            catch (alglib.alglibexception e)
            {
                MessageBox.Show(e.msg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
