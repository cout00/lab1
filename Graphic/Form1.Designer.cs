﻿namespace Graphic
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
            DevExpress.XtraCharts.XYDiagram xyDiagram13 = new DevExpress.XtraCharts.XYDiagram();
            DevExpress.XtraCharts.Series series17 = new DevExpress.XtraCharts.Series();
            DevExpress.XtraCharts.LineSeriesView lineSeriesView9 = new DevExpress.XtraCharts.LineSeriesView();
            DevExpress.XtraCharts.XYDiagram xyDiagram14 = new DevExpress.XtraCharts.XYDiagram();
            DevExpress.XtraCharts.Series series18 = new DevExpress.XtraCharts.Series();
            DevExpress.XtraCharts.StepLineSeriesView stepLineSeriesView5 = new DevExpress.XtraCharts.StepLineSeriesView();
            DevExpress.XtraCharts.Series series19 = new DevExpress.XtraCharts.Series();
            DevExpress.XtraCharts.LineSeriesView lineSeriesView10 = new DevExpress.XtraCharts.LineSeriesView();
            DevExpress.XtraCharts.XYDiagram xyDiagram15 = new DevExpress.XtraCharts.XYDiagram();
            DevExpress.XtraCharts.Series series20 = new DevExpress.XtraCharts.Series();
            this.tabFormControl1 = new DevExpress.XtraBars.TabFormControl();
            this.barStaticItem1 = new DevExpress.XtraBars.BarStaticItem();
            this.tabFormDefaultManager1 = new DevExpress.XtraBars.TabFormDefaultManager();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.tabFormPage2 = new DevExpress.XtraBars.TabFormPage();
            this.xtraScrollableControl2 = new DevExpress.XtraEditors.XtraScrollableControl();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
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
            this.chart = new DevExpress.XtraCharts.ChartControl();
            this.tabFormPage3 = new DevExpress.XtraBars.TabFormPage();
            this.xtraScrollableControl3 = new DevExpress.XtraEditors.XtraScrollableControl();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.chartControl1 = new DevExpress.XtraCharts.ChartControl();
            this.tabFormPage1 = new DevExpress.XtraBars.TabFormPage();
            this.xtraScrollableControl4 = new DevExpress.XtraEditors.XtraScrollableControl();
            this.tabFormPage4 = new DevExpress.XtraBars.TabFormPage();
            this.chartSpectr = new DevExpress.XtraCharts.ChartControl();
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
            ((System.ComponentModel.ISupportInitialize)(this.chart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(xyDiagram13)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series17)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(lineSeriesView9)).BeginInit();
            this.xtraScrollableControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(xyDiagram14)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series18)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(stepLineSeriesView5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series19)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(lineSeriesView10)).BeginInit();
            this.xtraScrollableControl4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartSpectr)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(xyDiagram15)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series20)).BeginInit();
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
            this.tabFormControl1.Pages.Add(this.tabFormPage2);
            this.tabFormControl1.Pages.Add(this.tabFormPage3);
            this.tabFormControl1.Pages.Add(this.tabFormPage4);
            this.tabFormControl1.SelectedPage = this.tabFormPage4;
            this.tabFormControl1.Size = new System.Drawing.Size(937, 61);
            this.tabFormControl1.TabForm = this;
            this.tabFormControl1.TabIndex = 0;
            this.tabFormControl1.TabStop = false;
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
            this.barDockControlTop.Size = new System.Drawing.Size(937, 0);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 613);
            this.barDockControlBottom.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.barDockControlBottom.Size = new System.Drawing.Size(937, 0);
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
            this.barDockControlRight.Location = new System.Drawing.Point(937, 61);
            this.barDockControlRight.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 552);
            // 
            // tabFormPage2
            // 
            this.tabFormPage2.ContentContainer = this.xtraScrollableControl2;
            this.tabFormPage2.Name = "tabFormPage2";
            this.tabFormPage2.Text = "Page 1";
            // 
            // xtraScrollableControl2
            // 
            this.xtraScrollableControl2.Controls.Add(this.groupControl1);
            this.xtraScrollableControl2.Controls.Add(this.panelControl1);
            this.xtraScrollableControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xtraScrollableControl2.Location = new System.Drawing.Point(0, 61);
            this.xtraScrollableControl2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.xtraScrollableControl2.Name = "xtraScrollableControl2";
            this.xtraScrollableControl2.Size = new System.Drawing.Size(937, 552);
            this.xtraScrollableControl2.TabIndex = 6;
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.groupBox2);
            this.groupControl1.Controls.Add(this.groupBox1);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(637, 0);
            this.groupControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(300, 552);
            this.groupControl1.TabIndex = 4;
            this.groupControl1.Text = "Параметры";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.ConrainsQVOrd);
            this.groupBox2.Controls.Add(this.ConrainsQVAbs);
            this.groupBox2.Controls.Add(this.labelControl4);
            this.groupBox2.Controls.Add(this.labelControl5);
            this.groupBox2.Location = new System.Drawing.Point(29, 265);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Size = new System.Drawing.Size(233, 247);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Квантование";
            // 
            // ConrainsQVOrd
            // 
            this.ConrainsQVOrd.EditValue = "0,5";
            this.ConrainsQVOrd.Location = new System.Drawing.Point(55, 124);
            this.ConrainsQVOrd.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ConrainsQVOrd.Name = "ConrainsQVOrd";
            this.ConrainsQVOrd.Size = new System.Drawing.Size(117, 22);
            this.ConrainsQVOrd.TabIndex = 2;
            this.ConrainsQVOrd.EditValueChanged += new System.EventHandler(this.OnChangeHandler);
            // 
            // ConrainsQVAbs
            // 
            this.ConrainsQVAbs.EditValue = "0,015";
            this.ConrainsQVAbs.Location = new System.Drawing.Point(55, 68);
            this.ConrainsQVAbs.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ConrainsQVAbs.Name = "ConrainsQVAbs";
            this.ConrainsQVAbs.Size = new System.Drawing.Size(117, 22);
            this.ConrainsQVAbs.TabIndex = 3;
            this.ConrainsQVAbs.EditValueChanged += new System.EventHandler(this.OnChangeHandler);
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(54, 44);
            this.labelControl4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(65, 16);
            this.labelControl4.TabIndex = 4;
            this.labelControl4.Text = "По абсцисс";
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(55, 101);
            this.labelControl5.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
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
            this.groupBox1.Location = new System.Drawing.Point(29, 58);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(233, 178);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ограничение";
            // 
            // ConrainsRight
            // 
            this.ConrainsRight.EditValue = "15";
            this.ConrainsRight.Location = new System.Drawing.Point(56, 114);
            this.ConrainsRight.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ConrainsRight.MenuManager = this.tabFormDefaultManager1;
            this.ConrainsRight.Name = "ConrainsRight";
            this.ConrainsRight.Size = new System.Drawing.Size(117, 22);
            this.ConrainsRight.TabIndex = 2;
            this.ConrainsRight.EditValueChanged += new System.EventHandler(this.OnChangeHandler);
            // 
            // ConrainsLeft
            // 
            this.ConrainsLeft.EditValue = "0";
            this.ConrainsLeft.Location = new System.Drawing.Point(56, 58);
            this.ConrainsLeft.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ConrainsLeft.MenuManager = this.tabFormDefaultManager1;
            this.ConrainsLeft.Name = "ConrainsLeft";
            this.ConrainsLeft.Size = new System.Drawing.Size(117, 22);
            this.ConrainsLeft.TabIndex = 3;
            this.ConrainsLeft.EditValueChanged += new System.EventHandler(this.OnChangeHandler);
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(56, 91);
            this.labelControl3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(43, 16);
            this.labelControl3.TabIndex = 4;
            this.labelControl3.Text = "Справа";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(55, 34);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(36, 16);
            this.labelControl1.TabIndex = 4;
            this.labelControl1.Text = "Слева";
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.chart);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Padding = new System.Windows.Forms.Padding(6);
            this.panelControl1.Size = new System.Drawing.Size(637, 552);
            this.panelControl1.TabIndex = 1;
            // 
            // chart
            // 
            xyDiagram13.AxisX.Alignment = DevExpress.XtraCharts.AxisAlignment.Zero;
            xyDiagram13.AxisX.GridLines.MinorVisible = true;
            xyDiagram13.AxisX.GridLines.Visible = true;
            xyDiagram13.AxisX.VisibleInPanesSerializable = "-1";
            xyDiagram13.AxisY.Alignment = DevExpress.XtraCharts.AxisAlignment.Zero;
            xyDiagram13.AxisY.GridLines.MinorVisible = true;
            xyDiagram13.AxisY.Visibility = DevExpress.Utils.DefaultBoolean.True;
            xyDiagram13.AxisY.VisibleInPanesSerializable = "-1";
            xyDiagram13.DefaultPane.BorderVisible = false;
            this.chart.Diagram = xyDiagram13;
            this.chart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chart.Location = new System.Drawing.Point(8, 8);
            this.chart.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.chart.Name = "chart";
            series17.Name = "Ряд 1";
            series17.View = lineSeriesView9;
            this.chart.SeriesSerializable = new DevExpress.XtraCharts.Series[] {
        series17};
            this.chart.Size = new System.Drawing.Size(621, 536);
            this.chart.TabIndex = 0;
            this.chart.Click += new System.EventHandler(this.chart_Click);
            // 
            // tabFormPage3
            // 
            this.tabFormPage3.ContentContainer = this.xtraScrollableControl3;
            this.tabFormPage3.Name = "tabFormPage3";
            this.tabFormPage3.Text = "Page 1";
            // 
            // xtraScrollableControl3
            // 
            this.xtraScrollableControl3.Controls.Add(this.checkBox1);
            this.xtraScrollableControl3.Controls.Add(this.chartControl1);
            this.xtraScrollableControl3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xtraScrollableControl3.Location = new System.Drawing.Point(0, 61);
            this.xtraScrollableControl3.Name = "xtraScrollableControl3";
            this.xtraScrollableControl3.Size = new System.Drawing.Size(937, 552);
            this.xtraScrollableControl3.TabIndex = 7;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(100, 365);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(98, 21);
            this.checkBox1.TabIndex = 1;
            this.checkBox1.Text = "checkBox1";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckStateChanged += new System.EventHandler(this.checkBox1_CheckStateChanged);
            // 
            // chartControl1
            // 
            xyDiagram14.AxisX.Alignment = DevExpress.XtraCharts.AxisAlignment.Zero;
            xyDiagram14.AxisX.GridLines.MinorVisible = true;
            xyDiagram14.AxisX.GridLines.Visible = true;
            xyDiagram14.AxisX.MinorCount = 1;
            xyDiagram14.AxisX.NumericScaleOptions.AutoGrid = false;
            xyDiagram14.AxisX.Visibility = DevExpress.Utils.DefaultBoolean.True;
            xyDiagram14.AxisX.VisibleInPanesSerializable = "-1";
            xyDiagram14.AxisY.Alignment = DevExpress.XtraCharts.AxisAlignment.Zero;
            xyDiagram14.AxisY.GridLines.MinorVisible = true;
            xyDiagram14.AxisY.NumericScaleOptions.AutoGrid = false;
            xyDiagram14.AxisY.NumericScaleOptions.GridSpacing = 0.9D;
            xyDiagram14.AxisY.VisibleInPanesSerializable = "-1";
            this.chartControl1.Diagram = xyDiagram14;
            this.chartControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.chartControl1.Location = new System.Drawing.Point(0, 0);
            this.chartControl1.Name = "chartControl1";
            series18.Name = "Ряд 1";
            series18.View = stepLineSeriesView5;
            series19.Name = "Ряд 2";
            series19.View = lineSeriesView10;
            this.chartControl1.SeriesSerializable = new DevExpress.XtraCharts.Series[] {
        series18,
        series19};
            this.chartControl1.Size = new System.Drawing.Size(937, 321);
            this.chartControl1.TabIndex = 0;
            // 
            // tabFormPage1
            // 
            this.tabFormPage1.Name = "tabFormPage1";
            this.tabFormPage1.Text = "Page 0";
            // 
            // xtraScrollableControl4
            // 
            this.xtraScrollableControl4.Controls.Add(this.chartSpectr);
            this.xtraScrollableControl4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xtraScrollableControl4.Location = new System.Drawing.Point(0, 61);
            this.xtraScrollableControl4.Name = "xtraScrollableControl4";
            this.xtraScrollableControl4.Size = new System.Drawing.Size(937, 552);
            this.xtraScrollableControl4.TabIndex = 8;
            // 
            // tabFormPage4
            // 
            this.tabFormPage4.ContentContainer = this.xtraScrollableControl4;
            this.tabFormPage4.Name = "tabFormPage4";
            this.tabFormPage4.Text = "Page 2";
            // 
            // chartSpectr
            // 
            xyDiagram15.AxisX.VisibleInPanesSerializable = "-1";
            xyDiagram15.AxisY.VisibleInPanesSerializable = "-1";
            this.chartSpectr.Diagram = xyDiagram15;
            this.chartSpectr.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chartSpectr.Location = new System.Drawing.Point(0, 0);
            this.chartSpectr.Name = "chartSpectr";
            series20.Name = "Ряд 1";
            this.chartSpectr.SeriesSerializable = new DevExpress.XtraCharts.Series[] {
        series20};
            this.chartSpectr.Size = new System.Drawing.Size(937, 552);
            this.chartSpectr.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(937, 613);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Controls.Add(this.xtraScrollableControl4);
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
            ((System.ComponentModel.ISupportInitialize)(xyDiagram13)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(lineSeriesView9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series17)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).EndInit();
            this.xtraScrollableControl3.ResumeLayout(false);
            this.xtraScrollableControl3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(xyDiagram14)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(stepLineSeriesView5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series18)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(lineSeriesView10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series19)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartControl1)).EndInit();
            this.xtraScrollableControl4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(xyDiagram15)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series20)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartSpectr)).EndInit();
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
        private DevExpress.XtraCharts.ChartControl chart;
        private DevExpress.XtraBars.TabFormPage tabFormPage2;
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
        private DevExpress.XtraCharts.ChartControl chartControl1;
        private DevExpress.XtraBars.TabFormPage tabFormPage3;
        private System.Windows.Forms.CheckBox checkBox1;
        private DevExpress.XtraEditors.XtraScrollableControl xtraScrollableControl4;
        private DevExpress.XtraCharts.ChartControl chartSpectr;
        private DevExpress.XtraBars.TabFormPage tabFormPage4;
    }
}
