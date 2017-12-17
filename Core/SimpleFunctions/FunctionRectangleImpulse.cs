using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.SimpleFunctions
{
    [ImmediateDraw]
    public class FunctionRectangleImpulse :Function
    {
        public override event EventHandler<FuncEventArgs> OnNewPoint;

        float FLeftPos;
        float FRightPos;
        public FunctionRectangleImpulse(float ALeftPos, float ARightPos)
        {
            FLeftPos = ALeftPos;
            FRightPos = ARightPos;
            Series.Name = "прям импульс";
            Series.ChangeView(DevExpress.XtraCharts.ViewType.Line);
        }


        protected override void FillList()
        {
            for (float i = Left; i < Right; i++)
            {           
                if (i >= FLeftPos && i <= FRightPos)
                {                   
                    Add(new System.Drawing.PointF(i, 1));
                }
                else
                {   
                    Add(new System.Drawing.PointF(i, 0));
                }
            }
        }
    }
}
