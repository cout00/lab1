using DevExpress.XtraBars;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Core.SimpleFunctions;
using Core;

namespace KR
{
    public partial class Form1 :DevExpress.XtraBars.TabForm
    {
        public Form1()
        {
            InitializeComponent();
            FunctionRectangleImpulse rectImp = new FunctionRectangleImpulse(-3, 30);
            rectImp.Left = -4;
            rectImp.Right = 75;
            rectImp.Build();
            rectImp.MadeDiscret();

            FunctionRectangleImpulse rectImp2 = new FunctionRectangleImpulse(-3, 30);
            rectImp2.Left = -4;
            rectImp2.Right = 75;
            rectImp2.Build();
            rectImp2.MadeDiscret();

            var realConv = rectImp.RealConvolution(rectImp2);
            var invFunc = rectImp.InverseFunction();
            var spectraclConv = rectImp.ComplexFrequrencyConvolution(rectImp2).FurieTransformInversion();
            //FunctionCustom fc = new FunctionCustom(0.21f,0.3f,0.26f,0.15f,0.05f,0.02f);
            //chrtMain.AddFunc(fc);
            //chrtMain.AddFunc(fc.InverseFunction());

            chrtMain.AddFunc(rectImp);
            chrtMain.AddFunc(spectraclConv);
            chrtMain.AddFunc(spectraclConv.ComplexFrequrencyDeconvolution(rectImp).FurieTransformInversion());
            chrtMain.AddFunc(realConv);
            chrtMain.AddFunc(invFunc);

            chrtMain.AddFunc(rectImp.FurieTransform().GetAFR);
            chrtMain.AddFunc(rectImp.InverseSpectre().GetAFR);
            chrtMain.AddFunc(realConv.RealConvolution(invFunc));
            chrtMain.DrawFunc();
        }
        void OnOuterFormCreating(object sender, OuterFormCreatingEventArgs e)
        {
            Form1 form = new Form1();
            form.TabFormControl.Pages.Clear();
            e.Form = form;
            OpenFormCount++;
        }
        static int OpenFormCount = 1;
    }
}
