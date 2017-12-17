using DevExpress.XtraBars;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Core;
using Core.WindowsList;
using Lab2;
using Core.Sound;
using Core.SimpleFunctions;
using System.Threading;

namespace Lab3
{
    public partial class Form1 :DevExpress.XtraBars.TabForm
    {
        public Form1()
        {
            InitializeComponent();
            Action<ChartForFunction, Quarter> AddChart = (chart, quarter) =>
            {
                PartFunction pf = new PartFunction(quarter);
                pf.Build();
                pf.MadeDiscret();
                Function_8Bit_1khz_Sinus sin = new Function_8Bit_1khz_Sinus();
                sin.Left = 0;
                sin.Right = 50;
                sin.QuantumAbs = 0.1f;
                sin.Build();
                sin.MadeDiscret();
                chart.AddFunc(sin);
                WindowBarlette wb = new WindowBarlette(sin, new Tuple<float, float>(0,100f));
                wb.Build();
                WindowRectangle rec = new WindowRectangle(sin, new Tuple<float, float>(0, 100f));
                rec.Build();
                var winFunc = sin.ApplyWindow(Windows.Barlette, new Tuple<float, float>(0, 100f));
                var sinRec = sin.ApplyWindow(Windows.Rectangle, new Tuple<float, float>(0, 100f));
                chart.AddFunc(wb);
                //chart.AddFunc(wb.FurieTransform().GetAFR);
                chart.AddFunc(rec);
                //chart.AddFunc(rec.FurieTransform().GetAFR);
                chart.AddFunc(sinRec);
                chart.AddFunc(sinRec.FurieTransform().GetAFR);
                chart.AddFunc(winFunc);
                chart.AddFunc(winFunc.FurieTransform().GetAFR);
                //chart.AddFunc(pf);
                //chart.AddFunc(pf.FurieTransform().GetAFR);
                //chart.AddFunc(winFunc);
                //chart.AddFunc(winFunc.FurieTransform().GetAFR);
                //chart.AddFunc(pf.FurieTransform().GetAFR);
                chart.DrawFunc();
            };
            AddChart(chrtWindows1, Quarter.First);
            //AddChart(chrtWindows2, Quarter.Second);
            //AddChart(chrtWindows3, Quarter.Third);
            //AddChart(chrtWindows4, Quarter.Fourth);
        }





        void OnOuterFormCreating(object sender, OuterFormCreatingEventArgs e)
        {
            Form1 form = new Form1();
            form.TabFormControl.Pages.Clear();
            e.Form = form;
            OpenFormCount++;
        }
        static int OpenFormCount = 1;

        private void chrtWindows_Click(object sender, EventArgs e)
        {

        }

        private void chrtWindows_DoubleClick(object sender, EventArgs e)
        {

        }
    }
}
