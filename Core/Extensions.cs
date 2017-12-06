using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevExpress.XtraCharts;
using System.Windows.Forms;
using System.Drawing;
using Core.WindowsList;

namespace Core
{
    public static class Extensions
    {
        public static SeriesPoint ToSeriesPoint(this PointF inpPoint)
        { 
            return new SeriesPoint(inpPoint.X, new object[] { ((object)(inpPoint.Y)) });
        }

        public static float Integral(this Function func)
        {
            return func.Sum((a) => a.Y);
        }

        public static FunctionPower Power(this Function func)
        {
           return new FunctionPower(func);
        }



        public static FurieFunction FurieTransform(this Function func)
        {
            FurieFunction Ffunc = new FurieFunction(func);
            Ffunc.Build();
            return Ffunc;
        }
        

        public static EnergySpectre EnergySpectre(this Function func)
        {
            EnergySpectre ensp = new Core.EnergySpectre(FurieTransform(func));
            ensp.Build();
            return ensp;
        }

        public static EnergySpectre RelativeEnergySpectre(this Function func, Function enotherFunc)
        {
            EnergySpectre ensp = new Core.EnergySpectre(FurieTransform(func), FurieTransform(enotherFunc));
            ensp.Build();
            return ensp;
        }

        public static float FullEnergy(this FurieFunction func)
        {
            return func.Select(a => a.Y).Sum();
        }

        public static FunctionContiniousCorrelation CorrelationFunctionContinous(this Function inpf, Function corFunc, float maxTau)
        {
            var func = new FunctionContiniousCorrelation(inpf, corFunc, false, maxTau, false);
            func.Build();
            return func;
        }

        public static FunctionDiscretCorrelation AutoCorrelationFunctionDiscret(this Function inpf, float maxTau)
        {
            var func = new FunctionDiscretCorrelation(inpf, null, true, maxTau,false);
            func.Build();
            return func;
        }
        public static FunctionDiscretCorrelation CorrelationFunctionDiscret(this Function inpf, Function corFunc, float maxTau)
        {
            var func = new FunctionDiscretCorrelation(inpf, corFunc, false, maxTau, false);
            func.Build();
            return func;
        }

        public static FunctionContiniousCorrelation AutoCorrelationContinous(this Function inpf, float maxTau)
        {
            var func = new FunctionContiniousCorrelation(inpf, null, true, maxTau, false);
            func.Build();
            return func;
        }

        public static FunctionContiniousCorrelation AutoCovariationContinous(this Function inpf, float maxTau)
        {
            var func = new FunctionContiniousCorrelation(inpf, null, true, maxTau, true);
            func.Build();
            return func;
        }

        public static FunctionContiniousCorrelation AutoCovariationDiscret(this Function inpf, float maxTau)
        {
            var func = new FunctionDiscretCorrelation(inpf, null, true, maxTau, true);
            func.Build();
            return func;
        }

        public static float Norma(this Function func)
        {
            var res = 0f;
            foreach (var item in func)
            {
                res += item.Y * item.Y;
            }
            return (float)Math.Sqrt(res);
        }

        public static float ScalarProduct(this Function inpFunc, Function nextFunc)
        {
            if (inpFunc.Count == nextFunc.Count)
            {
                var scalarProd = 0f;
                for (int i = 0; i < inpFunc.Count; i++)
                {
                    scalarProd += inpFunc[i].Y * nextFunc[i].Y;
                }
                return scalarProd;
            }
            else
                throw new Exception("Wrong input params. Functions must have equal dt");
        }

        public static Function FurieTransformInversion(this FurieFunction inpf)
        {
            var func = new FurieFunctionInverse(inpf);
            func.Build();    
            return func;
        }

        public static FurieFunction ComplexFrequrencyConvolution(this Function inpFunction, Function secondConplexFunc)
        {         
            var func = new FunctionConvolution(inpFunction.FurieTransform(), secondConplexFunc.FurieTransform());
            return func;
        }

        public static FurieFunction RealFrequrencyConvolution(this Function inpFunction, Function secondRealFunc)
        {
            var func = new FunctionConvolution(inpFunction.FurieTransform(), secondRealFunc);
            return func;
        }

        public static Function Shift(this Function inpFunc)
        {
            if (inpFunc.Count<2)
            {
                throw new Exception("Not valid Function");
            }
            inpFunc.Sort((ALeft, ARight) =>
            {
                if (ARight == null)
                    return 1;
                else
                    return ALeft.X.CompareTo(ARight.X);
            });
            var shiftSize = Math.Abs(Math.Abs(inpFunc[0].X)- Math.Abs(inpFunc[1].X))*inpFunc.Count/2;
            var tempCount = inpFunc.Count / 2;
            for (int i = 0; i < tempCount; i++)
            {
                PointF p = inpFunc[0];
                var oldX = p.X;
                p.X += shiftSize;
                PointF p1 = inpFunc[tempCount];
                p1.X = oldX;
                inpFunc[tempCount] = p1;
                inpFunc.Add(p);
                inpFunc.RemoveAt(0);
            }
            inpFunc.Sort((ALeft, ARight) =>
            {
                if (ARight == null)
                    return 1;
                else
                    return ALeft.X.CompareTo(ARight.X);
            });
            return inpFunc;
        }


        public static FurieFunction ApplyWindow(this Function inpFunc, Windows window)
        {
            FurieFunction res=null;
            switch (window)
            {
                case Windows.Barlette:
                    {
                        WindowBarlette wb = new WindowBarlette(inpFunc);
                        wb.Build();
                        res = inpFunc.RealFrequrencyConvolution(wb.Shift());
                        res.Build();                    
                        break;
                    }
                case Windows.Natol:
                    break;
                case Windows.Hemming:
                    break;
                default:
                    break;
            }
            return res;
        }

        
    }
}
