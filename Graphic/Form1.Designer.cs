namespace Graphic
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
            if (--OpenFormCount == 0) System.Windows.Forms.Application.Exit();
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabFormControl1 = new DevExpress.XtraBars.TabFormControl();
            this.barStaticItem1 = new DevExpress.XtraBars.BarStaticItem();
            this.tabFormDefaultManager1 = new DevExpress.XtraBars.TabFormDefaultManager();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.FuncStandart = new DevExpress.XtraBars.TabFormPage();
            this.xtraScrollableControl2 = new DevExpress.XtraEditors.XtraScrollableControl();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.ConrainsQVOrd = new DevExpress.XtraEditors.TextEdit();
            this.ConrainsQVAbs = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ConrainsRight = new DevExpress.XtraEditors.TextEdit();
            this.ConrainsLeft = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.FuncAnalog = new Graphic.ChartForFunction();
            this.FunctionDiscret = new DevExpress.XtraBars.TabFormPage();
            this.xtraScrollableControl3 = new DevExpress.XtraEditors.XtraScrollableControl();
            this.FuncDiscretn = new Graphic.ChartForFunction();
            this.FunctionACH = new DevExpress.XtraBars.TabFormPage();
            this.xtraScrollableControl4 = new DevExpress.XtraEditors.XtraScrollableControl();
            this.FuncAch = new Graphic.ChartForFunction();
            this.tabFormPage2 = new DevExpress.XtraBars.TabFormPage();
            this.xtraScrollableControl5 = new DevExpress.XtraEditors.XtraScrollableControl();
            this.tabFormPage3 = new DevExpress.XtraBars.TabFormPage();
            this.xtraScrollableControl6 = new DevExpress.XtraEditors.XtraScrollableControl();
            this.tabFormPage1 = new DevExpress.XtraBars.TabFormPage();
            this.chartForFunction1 = new Graphic.ChartForFunction();
            this.chartForFunction2 = new Graphic.ChartForFunction();
            this.chartForFunction3 = new Graphic.ChartForFunction();
            this.chartForFunction4 = new Graphic.ChartForFunction();
            ((System.ComponentModel.ISupportInitialize)(this.tabFormControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabFormDefaultManager1)).BeginInit();
            this.xtraScrollableControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ConrainsQVOrd.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ConrainsQVAbs.Properties)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ConrainsRight.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ConrainsLeft.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            this.xtraScrollableControl3.SuspendLayout();
            this.xtraScrollableControl4.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabFormControl1
            // 
            this.tabFormControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.barStaticItem1});
            this.tabFormControl1.Location = new System.Drawing.Point(0, 0);
            this.tabFormControl1.Manager = this.tabFormDefaultManager1;
            this.tabFormControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabFormControl1.Name = "tabFormControl1";
            this.tabFormControl1.Pages.Add(this.FuncStandart);
            this.tabFormControl1.Pages.Add(this.FunctionDiscret);
            this.tabFormControl1.Pages.Add(this.FunctionACH);
            this.tabFormControl1.Pages.Add(this.tabFormPage2);
            this.tabFormControl1.Pages.Add(this.tabFormPage3);
            this.tabFormControl1.SelectedPage = this.FunctionDiscret;
            this.tabFormControl1.Size = new System.Drawing.Size(1059, 61);
            this.tabFormControl1.TabForm = this;
            this.tabFormControl1.TabIndex = 0;
            this.tabFormControl1.TabStop = false;
            this.tabFormControl1.SelectedPageChanged += new DevExpress.XtraBars.TabFormSelectedPageChangedEventHandler(this.tabFormControl1_SelectedPageChanged);
            this.tabFormControl1.OuterFormCreating += new DevExpress.XtraBars.OuterFormCreatingEventHandler(this.OnOuterFormCreating);
            this.tabFormControl1.Click += new System.EventHandler(this.tabFormControl1_Click);
            // 
            // barStaticItem1
            // 
            this.barStaticItem1.Caption = "barStaticItem1";
            this.barStaticItem1.Id = 0;
            this.barStaticItem1.Name = "barStaticItem1";
            this.barStaticItem1.TextAlignment = System.Drawing.StringAlignment.Near;
            // 
            // tabFormDefaultManager1
            // 
            this.tabFormDefaultManager1.DockControls.Add(this.barDockControlTop);
            this.tabFormDefaultManager1.DockControls.Add(this.barDockControlBottom);
            this.tabFormDefaultManager1.DockControls.Add(this.barDockControlLeft);
            this.tabFormDefaultManager1.DockControls.Add(this.barDockControlRight);
            this.tabFormDefaultManager1.Form = this;
            this.tabFormDefaultManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.barStaticItem1});
            this.tabFormDefaultManager1.MaxItemId = 1;
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 61);
            this.barDockControlTop.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.barDockControlTop.Size = new System.Drawing.Size(1059, 0);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 613);
            this.barDockControlBottom.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.barDockControlBottom.Size = new System.Drawing.Size(1059, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 61);
            this.barDockControlLeft.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 552);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1059, 61);
            this.barDockControlRight.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 552);
            // 
            // FuncStandart
            // 
            this.FuncStandart.ContentContainer = this.xtraScrollableControl2;
            this.FuncStandart.Name = "FuncStandart";
            this.FuncStandart.Text = "Аналоговая";
            // 
            // xtraScrollableControl2
            // 
            this.xtraScrollableControl2.Controls.Add(this.groupControl1);
            this.xtraScrollableControl2.Controls.Add(this.panelControl1);
            this.xtraScrollableControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xtraScrollableControl2.Location = new System.Drawing.Point(0, 61);
            this.xtraScrollableControl2.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.xtraScrollableControl2.Name = "xtraScrollableControl2";
            this.xtraScrollableControl2.Size = new System.Drawing.Size(1059, 552);
            this.xtraScrollableControl2.TabIndex = 6;
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.button1);
            this.groupControl1.Controls.Add(this.groupBox2);
            this.groupControl1.Controls.Add(this.groupBox1);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(743, 0);
            this.groupControl1.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(316, 552);
            this.groupControl1.TabIndex = 4;
            this.groupControl1.Text = "Параметры";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(111, 298);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.ConrainsQVOrd);
            this.groupBox2.Controls.Add(this.ConrainsQVAbs);
            this.groupBox2.Controls.Add(this.labelControl4);
            this.groupBox2.Controls.Add(this.labelControl5);
            this.groupBox2.Location = new System.Drawing.Point(34, 326);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.groupBox2.Size = new System.Drawing.Size(272, 304);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Квантование";
            // 
            // ConrainsQVOrd
            // 
            this.ConrainsQVOrd.EditValue = "0,5";
            this.ConrainsQVOrd.Location = new System.Drawing.Point(64, 153);
            this.ConrainsQVOrd.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.ConrainsQVOrd.Name = "ConrainsQVOrd";
            this.ConrainsQVOrd.Size = new System.Drawing.Size(136, 22);
            this.ConrainsQVOrd.TabIndex = 2;
            this.ConrainsQVOrd.EditValueChanged += new System.EventHandler(this.OnChangeHandler);
            // 
            // ConrainsQVAbs
            // 
            this.ConrainsQVAbs.EditValue = "0,3";
            this.ConrainsQVAbs.Location = new System.Drawing.Point(64, 84);
            this.ConrainsQVAbs.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.ConrainsQVAbs.Name = "ConrainsQVAbs";
            this.ConrainsQVAbs.Size = new System.Drawing.Size(136, 22);
            this.ConrainsQVAbs.TabIndex = 3;
            this.ConrainsQVAbs.EditValueChanged += new System.EventHandler(this.OnChangeHandler);
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(63, 54);
            this.labelControl4.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(65, 16);
            this.labelControl4.TabIndex = 4;
            this.labelControl4.Text = "По абсцисс";
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(64, 124);
            this.labelControl5.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(67, 16);
            this.labelControl5.TabIndex = 4;
            this.labelControl5.Text = "По ординат";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ConrainsRight);
            this.groupBox1.Controls.Add(this.ConrainsLeft);
            this.groupBox1.Controls.Add(this.labelControl3);
            this.groupBox1.Controls.Add(this.labelControl1);
            this.groupBox1.Location = new System.Drawing.Point(34, 71);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.groupBox1.Size = new System.Drawing.Size(272, 219);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ограничение";
            // 
            // ConrainsRight
            // 
            this.ConrainsRight.EditValue = "15";
            this.ConrainsRight.Location = new System.Drawing.Point(65, 140);
            this.ConrainsRight.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.ConrainsRight.MenuManager = this.tabFormDefaultManager1;
            this.ConrainsRight.Name = "ConrainsRight";
            this.ConrainsRight.Size = new System.Drawing.Size(136, 22);
            this.ConrainsRight.TabIndex = 2;
            this.ConrainsRight.EditValueChanged += new System.EventHandler(this.OnChangeHandler);
            // 
            // ConrainsLeft
            // 
            this.ConrainsLeft.EditValue = "0";
            this.ConrainsLeft.Location = new System.Drawing.Point(65, 71);
            this.ConrainsLeft.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.ConrainsLeft.MenuManager = this.tabFormDefaultManager1;
            this.ConrainsLeft.Name = "ConrainsLeft";
            this.ConrainsLeft.Size = new System.Drawing.Size(136, 22);
            this.ConrainsLeft.TabIndex = 3;
            this.ConrainsLeft.EditValueChanged += new System.EventHandler(this.OnChangeHandler);
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(65, 112);
            this.labelControl3.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(43, 16);
            this.labelControl3.TabIndex = 4;
            this.labelControl3.Text = "Справа";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(64, 42);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(36, 16);
            this.labelControl1.TabIndex = 4;
            this.labelControl1.Text = "Слева";
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.FuncAnalog);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Padding = new System.Windows.Forms.Padding(7);
            this.panelControl1.Size = new System.Drawing.Size(743, 552);
            this.panelControl1.TabIndex = 1;
            // 
            // FuncAnalog
            // 
            this.FuncAnalog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FuncAnalog.Location = new System.Drawing.Point(9, 9);
            this.FuncAnalog.Name = "FuncAnalog";
            this.FuncAnalog.Size = new System.Drawing.Size(725, 534);
            this.FuncAnalog.TabIndex = 0;
            // 
            // FunctionDiscret
            // 
            this.FunctionDiscret.ContentContainer = this.xtraScrollableControl3;
            this.FunctionDiscret.Name = "FunctionDiscret";
            this.FunctionDiscret.Text = "Дискретная";
            // 
            // xtraScrollableControl3
            // 
            this.xtraScrollableControl3.Controls.Add(this.FuncDiscretn);
            this.xtraScrollableControl3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xtraScrollableControl3.Location = new System.Drawing.Point(0, 61);
            this.xtraScrollableControl3.Name = "xtraScrollableControl3";
            this.xtraScrollableControl3.Size = new System.Drawing.Size(1059, 552);
            this.xtraScrollableControl3.TabIndex = 7;
            // 
            // FuncDiscretn
            // 
            this.FuncDiscretn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FuncDiscretn.Location = new System.Drawing.Point(0, 0);
            this.FuncDiscretn.Name = "FuncDiscretn";
            this.FuncDiscretn.Size = new System.Drawing.Size(1059, 552);
            this.FuncDiscretn.TabIndex = 0;
            // 
            // FunctionACH
            // 
            this.FunctionACH.ContentContainer = this.xtraScrollableControl4;
            this.FunctionACH.Name = "FunctionACH";
            this.FunctionACH.Text = "АЧХ";
            // 
            // xtraScrollableControl4
            // 
            this.xtraScrollableControl4.Controls.Add(this.FuncAch);
            this.xtraScrollableControl4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xtraScrollableControl4.Location = new System.Drawing.Point(0, 61);
            this.xtraScrollableControl4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.xtraScrollableControl4.Name = "xtraScrollableControl4";
            this.xtraScrollableControl4.Size = new System.Drawing.Size(1059, 552);
            this.xtraScrollableControl4.TabIndex = 8;
            // 
            // FuncAch
            // 
            this.FuncAch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FuncAch.Location = new System.Drawing.Point(0, 0);
            this.FuncAch.Name = "FuncAch";
            this.FuncAch.Size = new System.Drawing.Size(1059, 552);
            this.FuncAch.TabIndex = 0;
            // 
            // tabFormPage2
            // 
            this.tabFormPage2.ContentContainer = this.xtraScrollableControl5;
            this.tabFormPage2.Name = "tabFormPage2";
            this.tabFormPage2.Text = "Page 3";
            // 
            // xtraScrollableControl5
            // 
            this.xtraScrollableControl5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xtraScrollableControl5.Location = new System.Drawing.Point(0, 61);
            this.xtraScrollableControl5.Name = "xtraScrollableControl5";
            this.xtraScrollableControl5.Size = new System.Drawing.Size(1059, 552);
            this.xtraScrollableControl5.TabIndex = 9;
            // 
            // tabFormPage3
            // 
            this.tabFormPage3.ContentContainer = this.xtraScrollableControl6;
            this.tabFormPage3.Name = "tabFormPage3";
            this.tabFormPage3.Text = "Page 4";
            // 
            // xtraScrollableControl6
            // 
            this.xtraScrollableControl6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xtraScrollableControl6.Location = new System.Drawing.Point(0, 61);
            this.xtraScrollableControl6.Name = "xtraScrollableControl6";
            this.xtraScrollableControl6.Size = new System.Drawing.Size(1059, 552);
            this.xtraScrollableControl6.TabIndex = 10;
            // 
            // tabFormPage1
            // 
            this.tabFormPage1.Name = "tabFormPage1";
            this.tabFormPage1.Text = "Page 0";
            // 
            // chartForFunction1
            // 
            this.chartForFunction1.Location = new System.Drawing.Point(0, 0);
            this.chartForFunction1.Name = "chartForFunction1";
            this.chartForFunction1.Size = new System.Drawing.Size(476, 360);
            this.chartForFunction1.TabIndex = 0;
            // 
            // chartForFunction2
            // 
            this.chartForFunction2.Location = new System.Drawing.Point(0, 0);
            this.chartForFunction2.Name = "chartForFunction2";
            this.chartForFunction2.Size = new System.Drawing.Size(476, 360);
            this.chartForFunction2.TabIndex = 0;
            // 
            // chartForFunction3
            // 
            this.chartForFunction3.Location = new System.Drawing.Point(0, 0);
            this.chartForFunction3.Name = "chartForFunction3";
            this.chartForFunction3.Size = new System.Drawing.Size(476, 360);
            this.chartForFunction3.TabIndex = 0;
            // 
            // chartForFunction4
            // 
            this.chartForFunction4.Location = new System.Drawing.Point(0, 0);
            this.chartForFunction4.Name = "chartForFunction4";
            this.chartForFunction4.Size = new System.Drawing.Size(476, 360);
            this.chartForFunction4.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1059, 613);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Controls.Add(this.xtraScrollableControl3);
            this.Controls.Add(this.tabFormControl1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.TabFormControl = this.tabFormControl1;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.tabFormControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabFormDefaultManager1)).EndInit();
            this.xtraScrollableControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ConrainsQVOrd.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ConrainsQVAbs.Properties)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ConrainsRight.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ConrainsLeft.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.xtraScrollableControl3.ResumeLayout(false);
            this.xtraScrollableControl4.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.TabFormControl tabFormControl1;
        private DevExpress.XtraBars.TabFormDefaultManager tabFormDefaultManager1;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraEditors.XtraScrollableControl xtraScrollableControl1;
        private DevExpress.XtraBars.TabFormPage tabFormPage1;
        private DevExpress.XtraBars.BarStaticItem barStaticItem1;
        private DevExpress.XtraEditors.XtraScrollableControl xtraScrollableControl2;
        private DevExpress.XtraBars.TabFormPage FuncStandart;
        private DevExpress.XtraEditors.TextEdit ConrainsLeft;
        private DevExpress.XtraEditors.TextEdit ConrainsRight;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private System.Windows.Forms.GroupBox groupBox2;
        private DevExpress.XtraEditors.TextEdit ConrainsQVOrd;
        private DevExpress.XtraEditors.TextEdit ConrainsQVAbs;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private System.Windows.Forms.GroupBox groupBox1;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.XtraScrollableControl xtraScrollableControl3;
        private DevExpress.XtraBars.TabFormPage FunctionDiscret;
        private DevExpress.XtraEditors.XtraScrollableControl xtraScrollableControl4;
        private DevExpress.XtraBars.TabFormPage FunctionACH;
        private System.Windows.Forms.Button button1;
        private DevExpress.XtraEditors.XtraScrollableControl xtraScrollableControl6;
        private DevExpress.XtraBars.TabFormPage tabFormPage2;
        private DevExpress.XtraEditors.XtraScrollableControl xtraScrollableControl5;
        private DevExpress.XtraBars.TabFormPage tabFormPage3;
        private ChartForFunction chartForFunction1;
        private ChartForFunction chartForFunction2;
        private ChartForFunction chartForFunction3;
        private ChartForFunction chartForFunction4;
        private ChartForFunction FuncDiscretn;
        private ChartForFunction FuncAnalog;
        private ChartForFunction FuncAch;
    }
}

