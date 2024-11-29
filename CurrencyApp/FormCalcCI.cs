using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CurrencyApp
{
    public partial class FormCalcCI : Form
    {
        public FormCalcCI()
        {
            InitializeComponent();
        }

        private void buttonClacRegularCI_Click(object sender, EventArgs e)
        {
            try
            {
                // Obter os valores inseridos pelo usuário
                double principal = Convert.ToDouble(textBoxAmountRCI.Text);
                double annualRate = Convert.ToDouble(textBoxAnnualRateRCI.Text);
                int months = Convert.ToInt32(textBoxDurationRCI.Text);
                int years = months /12;
                // Instanciar a classe CompoundInterest
                var calc = new CurrencyApp.BLL.CalcCi.CompoundInterest();

                // Calcular o valor futuro
                double futureValue = calc.Calculate(principal, annualRate, months);

                var charts = new CurrencyApp.BLL.Charts();
                charts.UpdateChartRCI(chartRCI, principal, annualRate, years);
                // Exibir o resultado em uma MessageBox
                MessageBox.Show($"O valor futuro (RCI) é: {futureValue:C}", "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao calcular. Verifique os valores inseridos.\n" + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonCCI_Click(object sender, EventArgs e)
        {
            try
            {
                // Obter os valores inseridos pelo usuário
                double principal = Convert.ToDouble(textBoxAmountCCI.Text);
                double monthlyDeposit = Convert.ToDouble(textBoxMonthlyDeposit.Text);
                double annualRate = Convert.ToDouble(textBoxAnnualRateCCI.Text);
                int months = Convert.ToInt32(textBoxDurationCCI.Text);
                int years = months /12;
                // Instanciar a classe CompoundInterestWithDeposits
                var calc = new CurrencyApp.BLL.CalcCi.CompoundInterestWithDeposits();

                // Calcular o valor futuro e obter o valor total aportado
                double totalInvested;
                double futureValue = calc.Calculate(principal, monthlyDeposit, annualRate, months, out totalInvested);
                // Instanciar a classe Charts e atualizar o gráfico
                var charts = new CurrencyApp.BLL.Charts();
                charts.UpdateChartCCI(chartCCI, principal, monthlyDeposit, annualRate, years);

                // Calcular os juros ganhos
                double interestEarned = futureValue - totalInvested;

                // Exibir os resultados em uma MessageBox
                MessageBox.Show(
                    $"Result:\n" +
                    $"- Future Value (CCI): {futureValue:C}\n" +
                    $"- Total Invested: {totalInvested:C}\n" +
                    $"- Interest Earned: {interestEarned:C}",
                    "Result",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error calculating. Please check the entered values.\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonExit2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
