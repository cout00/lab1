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

        public static float AbsDiff(this float inpParam1, float inpParam2)
        {
            return Math.Abs(Math.Abs(inpParam1) - Math.Abs(inpParam2));
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
            var func = new FunctionDiscretCorrelation(inpf, null, true, maxTau, false);
            func.Build();
            return func;
        }
        public static FunctionDiscretCorrelation CorrelationFunctionDiscret(this Function inpf, Function corFunc, float maxTau)
        {
            var func = new FunctionDiscretCorrelation(inpf, corFunc, false, maxTau, false);
            func.Build();
            return func;
        }


        public static FunctionDiscretCorrelation CovariationFunctionDiscret(this Function inpf, Function corFunc, float maxTau)
        {
            var func = new FunctionDiscretCorrelation(inpf, corFunc, false, maxTau, true);
            func.Build();
            //var pointList = new List<PointF>(func);
            //pointList.Reverse();
            //var curInd = func.Last().X;
            //func.AddRange(pointList.Select(a => {
            //    var point = a;
            //    curInd++;
            //    point.X = curInd;
            //    return point;
            //}));
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
            func.Build();
            return func;
        }


        public static FurieFunction ComplexFrequrencyDeconvolution(this Function inpFunction, Function secondConplexFunc)
        {
            //inpFunction.PushZerosToMaxLength(secondConplexFunc);
            var func = new FunctionDeconvolution(inpFunction.FurieTransform(), secondConplexFunc.FurieTransform());
            func.Build();
            return func;
        }


        public static FurieFunction RealFrequrencyConvolution(this Function inpFunction, Function secondRealFunc)
        {
            var func = new FunctionConvolution(inpFunction.FurieTransform(), secondRealFunc);
            func.Build();
            return func;
        }

        /// <summary>
        /// Возвращает взвешенное произведение функций
        /// </summary>
        /// <param name="inpFunc">Основная функция</param>
        /// <param name="weights">Весовое преобразование</param>
        /// <returns></returns>

        public static Function WeightedTransform(this Function inpFunc, Function weights)
        {
            FunctionWeightedTransform fwt = new FunctionWeightedTransform(inpFunc, weights);
            fwt.Build();
            return fwt;
        }

        public static void SortByX(this Function inpFunc)
        {
            inpFunc.Sort((ALeft, ARight) =>
            {
                if (ARight == null)
                    return 1;
                else
                    return ALeft.X.CompareTo(ARight.X);
            });
        }



        public static Function Shift(this Function inpFunc)
        {
            if (inpFunc.Count < 2)
            {
                throw new Exception("Not valid Function");
            }
            inpFunc.SortByX();
            var shiftSize = Math.Abs(Math.Abs(inpFunc[0].X) - Math.Abs(inpFunc[1].X)) * inpFunc.Count / 2;
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
            inpFunc.SortByX();
            return inpFunc;
        }


        public static Function InverseFunction(this Function inpFunc)
        {
            //FunctionRealInverse invSpectre = new FunctionRealInverse(inpFunc);
            FunctionInverseSpectre invSpectre = new FunctionInverseSpectre(inpFunc.FurieTransform());
            invSpectre.Build();
            return invSpectre.FurieTransformInversion();
        }

        public static FunctionInverseSpectre InverseSpectre(this Function inpfunc)
        {
            FunctionInverseSpectre invSpectre = new FunctionInverseSpectre(inpfunc.FurieTransform());
            invSpectre.Build();
            return invSpectre;
        }


        public static Function RealConvolution(this Function inpFunc, Function ConvSeed)
        {
            FunctionRealConvolution rc = new FunctionRealConvolution(inpFunc, ConvSeed);
            rc.Build();
            return rc;
        }

        public static Function ApplyWindow(this Function inpFunc, Windows window, Tuple<float, float> InterestRegion)
        {
            Function res = null;
            Window win=null;
            switch (window)
            {
                case Windows.Barlette:
                    {
                        win = new WindowBarlette(inpFunc, InterestRegion);                        
                        break;
                    }
                case Windows.Rectangle:
                    {
                        win = new WindowRectangle(inpFunc, InterestRegion);
                        break;
                    }
                case Windows.Natol:
                    break;
                case Windows.Hemming:
                    break;
                default:
                    break;
            }
            win.Build();
            res = inpFunc.WeightedTransform(win);
            res.Build();
            return res;
        }


    }
}
