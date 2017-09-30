using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraCharts;

namespace Graphic
{
    public partial class ChartForFunction :UserControl, IEquatable<Function>
    {
        //[Serializable]
        public List<Function> internalDrawList;
        public void AddFunc(Function inpFunction)
        {
            var func = internalDrawList.Find((a) => { return a.Series.Name == inpFunction.Series.Name; });
            if (func != null)
            {
                internalDrawList.Remove(func);
                internalDrawList.Add(inpFunction);
                return;
            }
            internalDrawList.Add(inpFunction);
        }

        public void DrawFunc()
        {
            chart.Series.Clear();
            chart.BeginInit();
            foreach (var item in internalDrawList)
            {
                chart.Series.Add(item.Series);
                item.Series.Points.Clear();
                item.OnNewPoint += (sen, arg) =>
                {
                    
                        chart.BeginInvoke((Action)(() =>
                        {
                            chart.Series[item.Series.Name].Points.Add(arg.point.ToSeriesPoint());
                            chart.Refresh();
                        }));
                    
                    
                };
                item.Build();
            }
            chart.EndInit();
        }

        public bool Equals(Function other)
        {
            foreach (var item in internalDrawList)
            {
                if (item.Left == other.Left && item.Right == other.Right && item.QuantumAbs == other.QuantumAbs && item.QuantumOrd == other.QuantumOrd && item.Series.Name == other.Series.Name)
                {
                    return true;
                }
            }
            return false;
        }

        public ChartForFunction()
        {
            InitializeComponent();
            chart.CacheToMemory = true;
            chart.RefreshDataOnRepaint = false;
            chart.RuntimeHitTesting = false;
            internalDrawList = new List<Function>();
        }
    }
}
