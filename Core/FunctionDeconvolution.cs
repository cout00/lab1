using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    [ImmediateDraw]
    public class FunctionDeconvolution:FunctionConvolution
    {
        public FunctionDeconvolution(FurieFunction funcComplex1, FurieFunction funcComplex2):base(funcComplex1,funcComplex2)
        {
            Series.Name = "деКонв" + funcComplex1.Series.Name + ":" + funcComplex2.Series.Name;
        }

        protected override void FillList()
        {
            ComplexArr = new List<System.Numerics.Complex>();
            for (int i = 0; i < funcComplex1.ComplexArr.Count; i++)
            {
                if (funcComplex2 != null)
                {
                    ComplexArr.Add(funcComplex1.ComplexArr[i] / funcComplex2.ComplexArr[i]);
                }                
            }
        }
    }
}
