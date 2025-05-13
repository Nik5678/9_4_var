namespace _9_4_вариант
{
    using System.Data;
    using System.Windows.Forms.DataVisualization.Charting;
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            textBoxA.Text = "1,35";
            textBoxB.Text = "-6,25";
            textBoxX0.Text = "5,3";
            textBoxXk.Text = "10,3";
            textBoxDx.Text = "0,25";
            textBoxCustomFunc.Text = "Sin(x)";

            InitializeDataGridView();
            InitializeChart();
        }

        private void btnPlot_Click_1(object sender, EventArgs e)
        {
            double a = double.Parse(textBoxA.Text);
            double b = double.Parse(textBoxB.Text);
            double x0 = double.Parse(textBoxX0.Text);
            double xk = double.Parse(textBoxXk.Text);
            double dx = double.Parse(textBoxDx.Text);
            string customFunc = textBoxCustomFunc.Text;

            dataGridViewResults.Rows.Clear();
            chartFunctions.Series[0].Points.Clear();
            chartFunctions.Series[1].Points.Clear();

            for (double x = x0; x <= xk; x += dx)
            {
                double xCubed = Math.Pow(x, 3);
                double term1 = a * xCubed;
                double term2 = Math.Pow(Math.Cos(xCubed - b), 2);
                double y = term1 + term2;

                double yCustom = EvaluateCustomFunction(customFunc, x);

                dataGridViewResults.Rows.Add(
                    x.ToString("F3"),
                    y.ToString("F5"),
                    yCustom.ToString("F5"));

                chartFunctions.Series[0].Points.AddXY(x, y);
                chartFunctions.Series[1].Points.AddXY(x, yCustom);
            }
        }
        private void InitializeDataGridView()
        {
            dataGridViewResults.Columns.Clear();
            dataGridViewResults.Columns.Add("X", "X");
            dataGridViewResults.Columns.Add("Y", "Y");
            dataGridViewResults.Columns.Add("Y_Custom", "Y (Custom)");
            dataGridViewResults.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void InitializeChart()
        {
            chartFunctions.Series.Clear();

            var series1 = new Series("Основная функция");
            series1.ChartType = SeriesChartType.Line;
            series1.Color = System.Drawing.Color.Blue;
            chartFunctions.Series.Add(series1);

            var series2 = new Series("Произвольная функция");
            series2.ChartType = SeriesChartType.Line;
            series2.Color = System.Drawing.Color.Red;
            chartFunctions.Series.Add(series2);

            chartFunctions.ChartAreas[0].AxisX.Title = "X";
            chartFunctions.ChartAreas[0].AxisY.Title = "Y";
        }
        private double EvaluateCustomFunction(string func, double x)
        {
            func = func.Replace("Math.", "").Replace("x", x.ToString());
            var expr = new DataTable();
            return Convert.ToDouble(expr.Compute(func, ""));
        }
    }
}
