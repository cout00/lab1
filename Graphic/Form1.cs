using DevExpress.XtraBars;
using DevExpress.XtraCharts;
using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Graphic
{
    public partial class Form1 :DevExpress.XtraBars.TabForm
    {
        public Form1()
        {
            InitializeComponent();
            OnChangeHandler(null, null);

        }


        void DrawFunction(Function inpFunc, Series whereDraw, bool isInterpolated)
        {
            inpFunc.Left = (float)Convert.ToDouble(ConrainsLeft.Text);
            inpFunc.Right = (float)Convert.ToDouble(ConrainsRight.Text);

            Func<TextEdit, float> TryConvert = (control) =>
            {
                var result = 1F;
                if (float.TryParse(control.Text, out result))
                {
                    return result != 0 ? result : 0.1F;
                }
                return -1;
            };
            inpFunc.QuantumOrd = isInterpolated ? 0 : TryConvert(ConrainsQVOrd);
            inpFunc.QuantumAbs = TryConvert(ConrainsQVAbs);
            whereDraw.Points.Clear();
            
            inpFunc.OnNewPoint += (sen, e) =>
            {
                chartControl1.Invoke((Action)(() =>
                {
                    
                    chartControl1.Update();
                    whereDraw.Points.Add(e.point.ToSeriesPoint());
                    
                }));


            };
            chartControl1.BeginInit();
            inpFunc.Build();
            chartControl1.EndInit();
            //currFunctions.Add(inpFunc);

        }

        void OnOuterFormCreating(object sender, OuterFormCreatingEventArgs e)
        {
            Form1 form = new Form1();
            form.TabFormControl.Pages.Clear();
            e.Form = form;
            OpenFormCount++;
        }
        static int OpenFormCount = 1;

        void OnChangeHandler(object sender, EventArgs e)
        {
            //chartControl1.Series["meme"].ChangeView(ViewType.Bar);
            //DrawFunction(new FunctionFromTask(), chart.Series[0], true);
            //DrawFunction(new FunctionFromTask(), chartControl1.Series[0], false);
            //DrawFunction(new FunctionFromTask(), chartControl1.Series[1], true);
            //DrawFunction(new ACHFunction(currFunctions[0]), chartSpectr.Series[0], true);
        }

        private void chart_Click(object sender, EventArgs e)
        {

        }

        private void tabFormControl1_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckStateChanged(object sender, EventArgs e)
        {
            DrawFunction(new FunctionFromTask(), chartControl1.Series[0], false);

            switch (((CheckBox)sender).CheckState)
            {
                case CheckState.Unchecked:
                    {
                        chartControl1.Series[0].ChangeView(ViewType.Bar);
                        break;
                    }
                case CheckState.Checked:

                    {
                        chartControl1.Series[0].ChangeView(ViewType.Line);
                        break;
                    }
                case CheckState.Indeterminate:

                    break;

            }

        }

        private void tabFormControl1_SelectedPageChanged(object sender, TabFormSelectedPageChangedEventArgs e)
        {
            foreach (var item in e.Page.ContentContainer Controls)
            {
                if (item is ChartControl)
                {
                    ((ChartControl)(item)).Series.Contains(whereDraw);
                    MessageBox.Show(((ChartControl)(item)).Name);
                }
            }

            //chartControl1.
            //MessageBox.Show(e.Page.Text);
        }
    }
}
