namespace Graphic
{
    partial class ChartForFunction
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            DevExpress.XtraCharts.XYDiagram xyDiagram2 = new DevExpress.XtraCharts.XYDiagram();
            DevExpress.XtraCharts.Series series2 = new DevExpress.XtraCharts.Series();
            DevExpress.XtraCharts.LineSeriesView lineSeriesView2 = new DevExpress.XtraCharts.LineSeriesView();
            this.chart = new DevExpress.XtraCharts.ChartControl();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(xyDiagram2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(lineSeriesView2)).BeginInit();
            this.SuspendLayout();
            // 
            // chart
            // 
            xyDiagram2.AxisX.Alignment = DevExpress.XtraCharts.AxisAlignment.Zero;
            xyDiagram2.AxisX.GridLines.MinorVisible = true;
            xyDiagram2.AxisX.GridLines.Visible = true;
            xyDiagram2.AxisX.VisibleInPanesSerializable = "-1";
            xyDiagram2.AxisY.Alignment = DevExpress.XtraCharts.AxisAlignment.Zero;
            xyDiagram2.AxisY.GridLines.MinorVisible = true;
            xyDiagram2.AxisY.VisibleInPanesSerializable = "-1";
            this.chart.Diagram = xyDiagram2;
            this.chart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chart.Legend.UseCheckBoxes = true;
            this.chart.Legend.Visibility = DevExpress.Utils.DefaultBoolean.True;
            this.chart.Location = new System.Drawing.Point(0, 0);
            this.chart.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.chart.Name = "chart";
            series2.Name = "Ряд 1";
            series2.View = lineSeriesView2;
            this.chart.SeriesSerializable = new DevExpress.XtraCharts.Series[] {
        series2};
            this.chart.Size = new System.Drawing.Size(357, 292);
            this.chart.TabIndex = 1;
            this.chart.Click += new System.EventHandler(this.chart_Click);
            // 
            // ChartForFunction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.chart);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ChartForFunction";
            this.Size = new System.Drawing.Size(357, 292);
            this.Load += new System.EventHandler(this.ChartForFunction_Load);
            ((System.ComponentModel.ISupportInitialize)(xyDiagram2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(lineSeriesView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public DevExpress.XtraCharts.ChartControl chart;
    }
}
