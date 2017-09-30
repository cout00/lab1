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

        public float TryConvert(TextEdit control)
        {
            var result = 1F;
            if (float.TryParse(control.Text, out result))
            {
                return result != 0 ? result : 0.1F;
            }
            return -1;
        }

        void DrawFunction(Function inpFunc, Series whereDraw, bool isInterpolated)
        {
            
            //whereDraw.Points.Clear();

            //inpFunc.OnNewPoint += (sen, e) =>
            //{
            //    chartControl1.Invoke((Action)(() =>
            //    {
            //        chartControl1.Update();
            //        whereDraw.Points.Add(e.point.ToSeriesPoint());
            //    }));
            //};
            //chartControl1.BeginInit();
            //inpFunc.Build();
            //chartControl1.EndInit();
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
            //DrawFunction(new FunctionFromTask(), chartControl1.Series[0], false);

            //switch (((CheckBox)sender).CheckState)
            //{
            //    case CheckState.Unchecked:
            //        {
            //            chartControl1.Series[0].ChangeView(ViewType.Bar);
            //            break;
            //        }
            //    case CheckState.Checked:

            //        {
            //            chartControl1.Series[0].ChangeView(ViewType.Line);
            //            break;
            //        }
            //    case CheckState.Indeterminate:

            //        break;

            //}

        }

        private void tabFormControl1_SelectedPageChanged(object sender, TabFormSelectedPageChangedEventArgs e)
        {           
            if (e.Page == FunctionDiscret)
            {
                
                var func = FuncAnalog.internalDrawList.Find((a) => { return a.Series.Name == typeof(FunctionFromTask).Name;});
                if (func==null||FuncDiscretn.Equals(func))
                {
                    return;
                }
                FunctionFromTaskQuantum fc = new FunctionFromTaskQuantum(func);
                fc.QuantumOrd=TryConvert(ConrainsQVOrd);
                func.DestroySeries();
                FuncDiscretn.AddFunc(fc);
                FuncDiscretn.AddFunc(func);
                FuncDiscretn.DrawFunc();                
            }
            if (e.Page == FunctionACH)
            {
                var func = FuncDiscretn.internalDrawList.Find((a) => { return a.Series.Name == typeof(FunctionFromTaskQuantum).Name; });
                if (func == null || FuncAch.Equals(func))
                {
                    return;
                }
                ACHFunction fun = new ACHFunction(func);
                fun.DestroySeries();
                FuncAch.AddFunc(fun);
                FuncAch.DrawFunc();

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FunctionFromTask inpFunc = new FunctionFromTask();
            inpFunc.Left = (float)Convert.ToDouble(ConrainsLeft.Text);
            inpFunc.Right = (float)Convert.ToDouble(ConrainsRight.Text);
            inpFunc.QuantumOrd = 0;//TryConvert(ConrainsQVOrd);
            inpFunc.QuantumAbs = TryConvert(ConrainsQVAbs);
            FuncAnalog.AddFunc(inpFunc);
            FuncAnalog.DrawFunc();
        }

        private void FuncDiscretn_Load(object sender, EventArgs e)
        {

        }

        private void FuncAnalog_Load(object sender, EventArgs e)
        {

        }
    }
}
