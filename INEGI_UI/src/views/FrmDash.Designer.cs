namespace INEGI.src.views
{
    partial class FrmDash
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
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            btnClose = new Button();
            lblTitulo = new Label();
            charActVivi = new System.Windows.Forms.DataVisualization.Charting.Chart();
            chartHabiVivi = new System.Windows.Forms.DataVisualization.Charting.Chart();
            label1 = new Label();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)charActVivi).BeginInit();
            ((System.ComponentModel.ISupportInitialize)chartHabiVivi).BeginInit();
            SuspendLayout();
            // 
            // btnClose
            // 
            btnClose.Cursor = Cursors.Hand;
            btnClose.FlatStyle = FlatStyle.Popup;
            btnClose.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnClose.Location = new Point(857, 12);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(75, 23);
            btnClose.TabIndex = 3;
            btnClose.Text = "CERRAR";
            btnClose.UseVisualStyleBackColor = true;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Century Gothic", 21.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblTitulo.Location = new Point(343, 12);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(185, 36);
            lblTitulo.TabIndex = 4;
            lblTitulo.Text = "Dashboards";
            // 
            // charActVivi
            // 
            chartArea1.AxisX.IntervalAutoMode = System.Windows.Forms.DataVisualization.Charting.IntervalAutoMode.VariableCount;
            chartArea1.Name = "ChartArea1";
            charActVivi.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            charActVivi.Legends.Add(legend1);
            charActVivi.Location = new Point(12, 99);
            charActVivi.Name = "charActVivi";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Bar;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            charActVivi.Series.Add(series1);
            charActVivi.Size = new Size(432, 267);
            charActVivi.TabIndex = 5;
            charActVivi.Text = "chart1";
            // 
            // chartHabiVivi
            // 
            chartArea2.Name = "ChartArea1";
            chartHabiVivi.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            chartHabiVivi.Legends.Add(legend2);
            chartHabiVivi.Location = new Point(470, 273);
            chartHabiVivi.Name = "chartHabiVivi";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
            series2.IsValueShownAsLabel = true;
            series2.LabelForeColor = Color.White;
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            chartHabiVivi.Series.Add(series2);
            chartHabiVivi.Size = new Size(462, 286);
            chartHabiVivi.TabIndex = 6;
            chartHabiVivi.Text = "chart2";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(12, 66);
            label1.Name = "label1";
            label1.Size = new Size(625, 30);
            label1.TabIndex = 7;
            label1.Text = "Cantidad de actividades económicas por Vivenda";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(467, 226);
            label2.Name = "label2";
            label2.Size = new Size(465, 30);
            label2.TabIndex = 8;
            label2.Text = "Promedio de habitantes por vivienda.";
            // 
            // FrmDash
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(944, 571);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(chartHabiVivi);
            Controls.Add(charActVivi);
            Controls.Add(lblTitulo);
            Controls.Add(btnClose);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmDash";
            Text = "FrmDash";
            ((System.ComponentModel.ISupportInitialize)charActVivi).EndInit();
            ((System.ComponentModel.ISupportInitialize)chartHabiVivi).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public Button btnClose;
        private Label lblTitulo;
        public System.Windows.Forms.DataVisualization.Charting.Chart charActVivi;
        public System.Windows.Forms.DataVisualization.Charting.Chart chartHabiVivi;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
        private Label label1;
        private Label label2;
    }
}