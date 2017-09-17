using DevExpress.XtraBars;
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
            
        }

        void DrawFunction(Function inpFunc)
        {
            inpFunc.Left = (float)Convert.ToDouble(ConrainsLeft.Text);
            inpFunc.Right = (float)Convert.ToDouble(ConrainsRight.Text);

            Func<TextEdit, float> TryConvert = (control) => {
                var result = 1F;
                if (float.TryParse(control.Text, out result))
                {
                   return result != 0? result : 0.1F;
                }
                return -1;
            };           
            inpFunc.QuantumOrd = 0;
            inpFunc.QuantumAbs = TryConvert(ConrainsQVAbs);
            inpFunc.Build();
            chart.Series[0].Points.Clear();
            //foreach (var item in inpFunc)
            //{
            //    chart.Series[0].Points.Add(item.ToSeriesPoint());
            //}

            var res = DPF.GetDpf(inpFunc, 200);
            foreach (var item in res)
            {
                chart.Series[0].Points.Add(item.ToSeriesPoint());
            }
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
            DrawFunction(new FunctionFromTask());
        }

        private void chart_Click(object sender, EventArgs e)
        {

        }
    }
}
