using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    [ImmediateDraw]
    public class FunctionConvolution:FurieFunction
    {
        protected FurieFunction funcComplex1;
        protected FurieFunction funcComplex2;
        protected Function funcReal;

        public FunctionConvolution(FurieFunction funcComplex1, FurieFunction funcComplex2)
        {
            this.funcComplex1 = funcComplex1;
            this.funcComplex2 = funcComplex2;
            Series.Name = "Конв" + funcComplex1.Series.Name + ":" + funcComplex2.Series.Name;
            if (funcComplex1.ComplexArr.Count!=funcComplex2.ComplexArr.Count)
            {
                throw new Exception("func1 not equal func2");
            }
        }


        public FunctionConvolution(FurieFunction funcComplex1, Function funcReal)
        {
            this.funcComplex1 = funcComplex1;
            this.funcReal = funcReal;
            Series.Name= "Конв" + funcComplex1.Series.Name + ":" + funcReal.Series.Name;
            if (funcComplex1.ComplexArr.Count != funcReal.Count)
            {
                throw new Exception("func1 not equal func2");
            }
        }

        protected override void FillList()
        {
            ComplexArr = new List<System.Numerics.Complex>();
            for (int i = 0; i < funcComplex1.ComplexArr.Count; i++)
            {
                if (funcComplex2!=null)
                {
                    ComplexArr.Add(funcComplex1.ComplexArr[i] * funcComplex2.ComplexArr[i]);
                }
                else
                {
                    ComplexArr.Add(funcComplex1.ComplexArr[i] * funcReal[i].Y);
                }
            }
        }

    }
}
