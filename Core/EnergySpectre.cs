using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    [ImmediateDraw]
    public class EnergySpectre :FurieFunction
    {
        public override event EventHandler<FuncEventArgs> OnNewPoint;
        FurieFunction furieFunc;
        FurieFunction furieFunc1;
        public EnergySpectre(FurieFunction func1)
        {
            Series.Name = "Эн "+func1.Series.Name;
            Series.ChangeView(DevExpress.XtraCharts.ViewType.Spline);
            furieFunc = func1;

        }

        public EnergySpectre(FurieFunction func1, FurieFunction func2)
        {
            Series.Name = "Вз эн " + func1.Series.Name+@"\"+ func2.Series.Name;
            Series.ChangeView(DevExpress.XtraCharts.ViewType.Spline);
            furieFunc = func1;
            furieFunc1=func2;
        }


        protected override void FillList()
        {
            oldDt = furieFunc.oldDt;
            ComplexArr = new List<System.Numerics.Complex>();
            //var firstPart = furieFunc.ComplexArr.Take(furieFunc.ComplexArr.Count / 2).ToList();
            for (int i = 0; i < furieFunc.ComplexArr.Count; i++)
            {
                if (furieFunc1!=null)
                {
                    if (furieFunc1.Count==furieFunc.Count)
                    {
                        ComplexArr.Add(furieFunc.ComplexArr[i] * Complex.Conjugate(furieFunc1.ComplexArr[i]));
                    }
                    continue;
                }
                ComplexArr.Add(furieFunc.ComplexArr[i] * Complex.Conjugate(furieFunc.ComplexArr[i]));
            }
        }
    }
}
