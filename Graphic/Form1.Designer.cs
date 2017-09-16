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
            DevExpress.XtraCharts.XYDiagram xyDiagram3 = new DevExpress.XtraCharts.XYDiagram();
            DevExpress.XtraCharts.Series series3 = new DevExpress.XtraCharts.Series();
            DevExpress.XtraCharts.LineSeriesView lineSeriesView3 = new DevExpress.XtraCharts.LineSeriesView();
            this.tabFormControl1 = new DevExpress.XtraBars.TabFormControl();
            this.tabFormDefaultManager1 = new DevExpress.XtraBars.TabFormDefaultManager();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.tabFormPage1 = new DevExpress.XtraBars.TabFormPage();
            this.xtraScrollableControl1 = new DevExpress.XtraEditors.XtraScrollableControl();
            this.barStaticItem1 = new DevExpress.XtraBars.BarStaticItem();
            this.xtraScrollableControl2 = new DevExpress.XtraEditors.XtraScrollableControl();
            this.tabFormPage2 = new DevExpress.XtraBars.TabFormPage();
            this.chart = new DevExpress.XtraCharts.ChartControl();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.ConrainsRight = new DevExpress.XtraEditors.TextEdit();
            this.ConrainsLeft = new DevExpress.XtraEditors.TextEdit();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.ConrainsQVAbs = new DevExpress.XtraEditors.TextEdit();
            this.ConrainsQVOrd = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.tabFormControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabFormDefaultManager1)).BeginInit();
            this.xtraScrollableControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(xyDiagram3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(lineSeriesView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ConrainsRight.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ConrainsLeft.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ConrainsQVAbs.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ConrainsQVOrd.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // tabFormControl1
            // 
            this.tabFormControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.barStaticItem1});
            this.tabFormControl1.Location = new System.Drawing.Point(0, 0);
            this.tabFormControl1.Manager = this.tabFormDefaultManager1;
            this.tabFormControl1.Name = "tabFormControl1";
            this.tabFormControl1.Pages.Add(this.tabFormPage1);
            this.tabFormControl1.Pages.Add(this.tabFormPage2);
            this.tabFormControl1.SelectedPage = this.tabFormPage2;
            this.tabFormControl1.Size = new System.Drawing.Size(803, 50);
            this.tabFormControl1.TabForm = this;
            this.tabFormControl1.TabIndex = 0;
            this.tabFormControl1.TabStop = false;
            this.tabFormControl1.OuterFormCreating += new DevExpress.XtraBars.OuterFormCreatingEventHandler(this.OnOuterFormCreating);
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
            this.barDockControlTop.Location = new System.Drawing.Point(0, 50);
            this.barDockControlTop.Size = new System.Drawing.Size(803, 0);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 498);
            this.barDockControlBottom.Size = new System.Drawing.Size(803, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 50);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 448);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(803, 50);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 448);
            // 
            // tabFormPage1
            // 
            this.tabFormPage1.ContentContainer = this.xtraScrollableControl1;
            this.tabFormPage1.Name = "tabFormPage1";
            this.tabFormPage1.Text = "Page 0";
            // 
            // xtraScrollableControl1
            // 
            this.xtraScrollableControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.xtraScrollableControl1.Location = new System.Drawing.Point(0, 50);
            this.xtraScrollableControl1.Name = "xtraScrollableControl1";
            this.xtraScrollableControl1.Size = new System.Drawing.Size(803, 448);
            this.xtraScrollableControl1.TabIndex = 1;
            // 
            // barStaticItem1
            // 
            this.barStaticItem1.Caption = "barStaticItem1";
            this.barStaticItem1.Id = 0;
            this.barStaticItem1.Name = "barStaticItem1";
            this.barStaticItem1.TextAlignment = System.Drawing.StringAlignment.Near;
            // 
            // xtraScrollableControl2
            // 
            this.xtraScrollableControl2.Controls.Add(this.groupControl1);
            this.xtraScrollableControl2.Controls.Add(this.panelControl1);
            this.xtraScrollableControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xtraScrollableControl2.Location = new System.Drawing.Point(0, 50);
            this.xtraScrollableControl2.Name = "xtraScrollableControl2";
            this.xtraScrollableControl2.Size = new System.Drawing.Size(803, 448);
            this.xtraScrollableControl2.TabIndex = 6;
            // 
            // tabFormPage2
            // 
            this.tabFormPage2.ContentContainer = this.xtraScrollableControl2;
            this.tabFormPage2.Name = "tabFormPage2";
            this.tabFormPage2.Text = "Page 1";
            // 
            // chart
            // 
            xyDiagram3.AxisX.Alignment = DevExpress.XtraCharts.AxisAlignment.Zero;
            xyDiagram3.AxisX.GridLines.MinorVisible = true;
            xyDiagram3.AxisX.GridLines.Visible = true;
            xyDiagram3.AxisX.VisibleInPanesSerializable = "-1";
            xyDiagram3.AxisY.Alignment = DevExpress.XtraCharts.AxisAlignment.Zero;
            xyDiagram3.AxisY.GridLines.MinorVisible = true;
            xyDiagram3.AxisY.Visibility = DevExpress.Utils.DefaultBoolean.True;
            xyDiagram3.AxisY.VisibleInPanesSerializable = "-1";
            xyDiagram3.DefaultPane.BorderVisible = false;
            this.chart.Diagram = xyDiagram3;
            this.chart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chart.Location = new System.Drawing.Point(7, 7);
            this.chart.Name = "chart";
            series3.Name = "Ряд 1";
            series3.View = lineSeriesView3;
            this.chart.SeriesSerializable = new DevExpress.XtraCharts.Series[] {
        series3};
            this.chart.Size = new System.Drawing.Size(532, 434);
            this.chart.TabIndex = 0;
            this.chart.Click += new System.EventHandler(this.chart_Click);
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.chart);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Padding = new System.Windows.Forms.Padding(5);
            this.panelControl1.Size = new System.Drawing.Size(546, 448);
            this.panelControl1.TabIndex = 1;
            // 
            // ConrainsRight
            // 
            this.ConrainsRight.EditValue = "15";
            this.ConrainsRight.Location = new System.Drawing.Point(48, 93);
            this.ConrainsRight.MenuManager = this.tabFormDefaultManager1;
            this.ConrainsRight.Name = "ConrainsRight";
            this.ConrainsRight.Size = new System.Drawing.Size(100, 20);
            this.ConrainsRight.TabIndex = 2;
            this.ConrainsRight.EditValueChanged += new System.EventHandler(this.OnChangeHandler);
            // 
            // ConrainsLeft
            // 
            this.ConrainsLeft.EditValue = "-15";
            this.ConrainsLeft.Location = new System.Drawing.Point(48, 47);
            this.ConrainsLeft.MenuManager = this.tabFormDefaultManager1;
            this.ConrainsLeft.Name = "ConrainsLeft";
            this.ConrainsLeft.Size = new System.Drawing.Size(100, 20);
            this.ConrainsLeft.TabIndex = 3;
            this.ConrainsLeft.EditValueChanged += new System.EventHandler(this.OnChangeHandler);
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.groupBox2);
            this.groupControl1.Controls.Add(this.groupBox1);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(546, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(257, 448);
            this.groupControl1.TabIndex = 4;
            this.groupControl1.Text = "Параметры";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(47, 28);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(31, 13);
            this.labelControl1.TabIndex = 4;
            this.labelControl1.Text = "Слева";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ConrainsRight);
            this.groupBox1.Controls.Add(this.ConrainsLeft);
            this.groupBox1.Controls.Add(this.labelControl3);
            this.groupBox1.Controls.Add(this.labelControl1);
            this.groupBox1.Location = new System.Drawing.Point(25, 47);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 145);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ограничение";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.ConrainsQVOrd);
            this.groupBox2.Controls.Add(this.ConrainsQVAbs);
            this.groupBox2.Controls.Add(this.labelControl4);
            this.groupBox2.Controls.Add(this.labelControl5);
            this.groupBox2.Location = new System.Drawing.Point(25, 215);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 201);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Квантование";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(48, 74);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(37, 13);
            this.labelControl3.TabIndex = 4;
            this.labelControl3.Text = "Справа";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(46, 36);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(55, 13);
            this.labelControl4.TabIndex = 4;
            this.labelControl4.Text = "По абсцисс";
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(47, 82);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(59, 13);
            this.labelControl5.TabIndex = 4;
            this.labelControl5.Text = "По ординат";
            // 
            // ConrainsQVAbs
            // 
            this.ConrainsQVAbs.EditValue = "0,5";
            this.ConrainsQVAbs.Location = new System.Drawing.Point(47, 55);
            this.ConrainsQVAbs.Name = "ConrainsQVAbs";
            this.ConrainsQVAbs.Size = new System.Drawing.Size(100, 20);
            this.ConrainsQVAbs.TabIndex = 3;
            this.ConrainsQVAbs.EditValueChanged += new System.EventHandler(this.OnChangeHandler);
            // 
            // ConrainsQVOrd
            // 
            this.ConrainsQVOrd.EditValue = "0,5";
            this.ConrainsQVOrd.Location = new System.Drawing.Point(47, 101);
            this.ConrainsQVOrd.Name = "ConrainsQVOrd";
            this.ConrainsQVOrd.Size = new System.Drawing.Size(100, 20);
            this.ConrainsQVOrd.TabIndex = 2;
            this.ConrainsQVOrd.EditValueChanged += new System.EventHandler(this.OnChangeHandler);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(803, 498);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Controls.Add(this.xtraScrollableControl2);
            this.Controls.Add(this.tabFormControl1);
            this.Name = "Form1";
            this.TabFormControl = this.tabFormControl1;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.tabFormControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabFormDefaultManager1)).EndInit();
            this.xtraScrollableControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(xyDiagram3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(lineSeriesView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ConrainsRight.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ConrainsLeft.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ConrainsQVAbs.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ConrainsQVOrd.Properties)).EndInit();
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
    }
}

