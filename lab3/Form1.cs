using NCalc;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace lab3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            InitializaChart();
        }

        public void InitializaChart()
        {
            chart1.Series.Clear();
            chart1.ChartAreas.Clear();

            var chartArea = new ChartArea("MainArea");
            chartArea.AxisX.Title = "X";
            chartArea.AxisY.Title = "Y";
            chartArea.AxisX.Minimum = -10;
            chartArea.AxisX.Maximum = 10;
            chartArea.AxisX.Interval = 2;
            chartArea.AxisY.Minimum = -10;
            chartArea.AxisY.Maximum = 10;
            chartArea.AxisY.Interval = 2;
            chart1.ChartAreas.Add(chartArea);

            chart1.Legends.Clear();
            var legend = new Legend("MainLegend");
            legend.Docking = Docking.Bottom;
            chart1.Legends.Add(legend);

            var series1 = new Series("Функция 1");
            series1.ChartType = SeriesChartType.Line;
            series1.MarkerStyle = MarkerStyle.Circle;
            series1.MarkerSize = 5;
            series1.Color = Color.Blue;
            series1.BorderWidth = 2;
            chart1.Series.Add(series1);

            var series2 = new Series("Функция 2");
            series2.ChartType = SeriesChartType.Line;
            series2.MarkerStyle = MarkerStyle.Square;
            series2.MarkerSize = 5;
            series2.Color = Color.Red;
            series2.BorderWidth = 2;
            chart1.Series.Add(series2);
        }

        private void ButtonDrawClick(object sender, EventArgs e)
        {
            var formula1 = textBoxFormula1.Text.Trim();
            var formula2 = textBoxFormula2.Text.Trim();

            if (string.IsNullOrEmpty(formula1) || string.IsNullOrEmpty(formula2))
            {
                MessageBox.Show("Введите формулы");
                return;
            }

            chart1.Series["Функция 1"].Points.Clear();
            chart1.Series["Функция 2"].Points.Clear();

            var minX = -10;
            var maxX = 10;
            var step = 0.5;

            DrawFormula(formula1, "Функция 1", minX, maxX, step);
            DrawFormula(formula2, "Функция 2", minX, maxX, step);

            chart1.ChartAreas["MainArea"].RecalculateAxesScale();

            chart1.Refresh();
        }

        private void DrawFormula(string formula, string series, double minX, double maxX, double step)
        {
            try
            {
                var expr2 = new Expression(formula);
                for (var x = minX; x <= maxX; x += step)
                {
                    expr2.Parameters["x"] = x;
                    var y = (double)expr2.Evaluate();
                    chart1.Series[series].Points.AddXY(x, y);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка парсинга формулы: {formula}\n Ошибка парсинга: {ex.Message}");
            }
        }
    }
}
