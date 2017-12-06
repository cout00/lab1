using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    [ImmediateDraw]
    public class FunctionPower :Function
    {
        public override event EventHandler<FuncEventArgs> OnNewPoint;
        Function _func;

        public FunctionPower(Function func)
        {
            _func = func;
            Series.Name = "Мощность: " + func.Series.Name;
            FillList();
        }

        protected override void FillList()
        {
            for (int i = 0; i < _func.Count; i++)
            {
                Add(new System.Drawing.PointF(_func[i].X, _func[i].Y* _func[i].Y));
            }
        }
    }
}
