using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.DataVisualization.Charting;

namespace CurrencyApp.BLL
{
    internal class Charts
    {
        public void UpdateChartRCI(Chart chart, double principal, double annualRate, int years)
        {
            // Limpar séries existentes no gráfico
            chart.Series.Clear();

            // Criar uma nova série
            var series = new Series("Future Value");
            series.ChartType = SeriesChartType.Line;

            // Configurar o eixo X e Y
            for (int i = 1; i <= years; i++)
            {
                int months = i * 12; // Converter anos para meses
                var calc = new CalcCi.CompoundInterest();
                double futureValue = calc.Calculate(principal, annualRate, months);

                // Adicionar valores ao gráfico
                series.Points.AddXY(i, futureValue); // X = Ano, Y = Valor Futuro
            }

            // Adicionar a série ao gráfico
            chart.Series.Add(series);

            // Configurar títulos do gráfico
            chart.ChartAreas[0].Position = new ElementPosition(0, 0, 100, 85);// Posição: X=0%, Y=0%, Largura=100%, Altura=85%
            chart.ChartAreas[0].AxisX.Title = "Years";
            chart.ChartAreas[0].AxisY.Title = "Future Value ($)";
            // Configurar a posição da legenda
            chart.Legends[0].Docking = Docking.Bottom; // Mover legenda para baixo
            chart.Legends[0].Alignment = StringAlignment.Center; // Centralizar a legenda
        }

        public void UpdateChartCCI(Chart chart, double principal, double monthlyDeposit, double annualRate, int years)
        {
            // Limpar séries existentes no gráfico
            chart.Series.Clear();

            // Criar uma nova série
            var series = new Series("Future Value");
            series.ChartType = SeriesChartType.Line;

            // Configurar o eixo X e Y
            for (int i = 1; i <= years; i++)
            {
                int months = i * 12; // Converter anos para meses
                var calc = new CurrencyApp.BLL.CalcCi.CompoundInterestWithDeposits();
                double totalInvested;
                double futureValue = calc.Calculate(principal, monthlyDeposit, annualRate, months, out totalInvested);

                // Adicionar valores ao gráfico
                series.Points.AddXY(i, futureValue); // X = Ano, Y = Valor Futuro
            }

            // Adicionar a série ao gráfico
            chart.Series.Add(series);

            // Configurar títulos do gráfico
            chart.ChartAreas[0].AxisX.Title = "Years";
            chart.ChartAreas[0].AxisY.Title = "Future Value ($)";
            chart.ChartAreas[0].Position = new ElementPosition(0, 0, 100, 85);// Posição: X=0%, Y=0%, Largura=100%, Altura=85%
            // Configurar a posição da legenda
            chart.Legends[0].Docking = Docking.Bottom; // Mover legenda para baixo
            chart.Legends[0].Alignment = StringAlignment.Center; // Centralizar a legenda
        }

    }
}
