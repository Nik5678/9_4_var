namespace _9_4_вариант
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            btnPlot = new Button();
            textBoxA = new TextBox();
            textBoxB = new TextBox();
            textBoxX0 = new TextBox();
            textBoxXk = new TextBox();
            textBoxDx = new TextBox();
            textBoxCustomFunc = new TextBox();
            dataGridViewResults = new DataGridView();
            chartFunctions = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)dataGridViewResults).BeginInit();
            ((System.ComponentModel.ISupportInitialize)chartFunctions).BeginInit();
            SuspendLayout();
            // 
            // btnPlot
            // 
            btnPlot.Location = new Point(170, 108);
            btnPlot.Name = "btnPlot";
            btnPlot.Size = new Size(116, 63);
            btnPlot.TabIndex = 0;
            btnPlot.Text = "Построить графики";
            btnPlot.UseVisualStyleBackColor = true;
            btnPlot.Click += btnPlot_Click_1;
            // 
            // textBoxA
            // 
            textBoxA.Location = new Point(12, 12);
            textBoxA.Name = "textBoxA";
            textBoxA.Size = new Size(113, 23);
            textBoxA.TabIndex = 2;
            textBoxA.Text = "a";
            textBoxA.TextAlign = HorizontalAlignment.Center;
            // 
            // textBoxB
            // 
            textBoxB.Location = new Point(12, 41);
            textBoxB.Name = "textBoxB";
            textBoxB.Size = new Size(113, 23);
            textBoxB.TabIndex = 3;
            textBoxB.Text = "b";
            textBoxB.TextAlign = HorizontalAlignment.Center;
            // 
            // textBoxX0
            // 
            textBoxX0.Location = new Point(12, 70);
            textBoxX0.Name = "textBoxX0";
            textBoxX0.Size = new Size(113, 23);
            textBoxX0.TabIndex = 4;
            textBoxX0.Text = "Xo";
            textBoxX0.TextAlign = HorizontalAlignment.Center;
            // 
            // textBoxXk
            // 
            textBoxXk.Location = new Point(12, 99);
            textBoxXk.Name = "textBoxXk";
            textBoxXk.Size = new Size(113, 23);
            textBoxXk.TabIndex = 5;
            textBoxXk.Text = "Xk";
            textBoxXk.TextAlign = HorizontalAlignment.Center;
            // 
            // textBoxDx
            // 
            textBoxDx.Location = new Point(12, 129);
            textBoxDx.Name = "textBoxDx";
            textBoxDx.Size = new Size(113, 23);
            textBoxDx.TabIndex = 6;
            textBoxDx.Text = "Dx";
            textBoxDx.TextAlign = HorizontalAlignment.Center;
            // 
            // textBoxCustomFunc
            // 
            textBoxCustomFunc.Location = new Point(12, 167);
            textBoxCustomFunc.Multiline = true;
            textBoxCustomFunc.Name = "textBoxCustomFunc";
            textBoxCustomFunc.Size = new Size(113, 25);
            textBoxCustomFunc.TabIndex = 7;
            textBoxCustomFunc.Text = "Math.Sin(x)";
            textBoxCustomFunc.TextAlign = HorizontalAlignment.Center;
            // 
            // dataGridViewResults
            // 
            dataGridViewResults.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewResults.Location = new Point(346, 5);
            dataGridViewResults.Name = "dataGridViewResults";
            dataGridViewResults.Size = new Size(297, 572);
            dataGridViewResults.TabIndex = 8;
            // 
            // chartFunctions
            // 
            chartArea2.Name = "ChartArea1";
            chartFunctions.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            chartFunctions.Legends.Add(legend2);
            chartFunctions.Location = new Point(682, 15);
            chartFunctions.Name = "chartFunctions";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            chartFunctions.Series.Add(series2);
            chartFunctions.Size = new Size(576, 579);
            chartFunctions.TabIndex = 9;
            chartFunctions.Text = "chart1";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1271, 604);
            Controls.Add(chartFunctions);
            Controls.Add(dataGridViewResults);
            Controls.Add(textBoxCustomFunc);
            Controls.Add(textBoxDx);
            Controls.Add(textBoxXk);
            Controls.Add(textBoxX0);
            Controls.Add(textBoxB);
            Controls.Add(textBoxA);
            Controls.Add(btnPlot);
            Name = "Form1";
            Text = "обоз";
            ((System.ComponentModel.ISupportInitialize)dataGridViewResults).EndInit();
            ((System.ComponentModel.ISupportInitialize)chartFunctions).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnPlot;
        private TextBox textBoxA;
        private TextBox textBoxB;
        private TextBox textBoxX0;
        private TextBox textBoxXk;
        private TextBox textBoxDx;
        private TextBox textBoxCustomFunc;
        private DataGridView dataGridViewResults;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartFunctions;
    }
}
