using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    [ImmediateDraw]
    public class FunctionInverseSpectre:FurieFunction
    {
        public FunctionInverseSpectre(FurieFunction inpF):base(inpF)
        {
            Series.Name = "обр спектр " + inpF.Series.Name;
        }

        protected override void FillList()
        {
            ComplexArr = new List<System.Numerics.Complex>();
            foreach (var item in ((FurieFunction)_inpFunction).ComplexArr)
            {
                ComplexArr.Add(1 / item);
            }
        }
    }
}
